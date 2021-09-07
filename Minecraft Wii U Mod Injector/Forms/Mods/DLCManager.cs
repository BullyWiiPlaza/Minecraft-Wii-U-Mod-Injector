using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U;
using Minecraft_Wii_U_Mod_Injector.Helpers;

namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    public partial class DLCManager : MetroForm
    {
        public DLCManager(MainForm _iw)
        {
            InitializeComponent();
            StyleMngr.Style = Style = _iw.StyleMngr.Style;
            StyleMngr.Theme = Theme = _iw.StyleMngr.Theme;
        }

        private uint currentAmount = 0;
        private void updatePackCountLabel()
        {
            PackCountLabel.Text = "Current Pack amount : " + currentAmount.ToString();
        }

        private void getPackInfos(uint dlcPack,out uint ChildPackCount, out uint LicenseMask, out uint DLCMountIndex, out uint DLCDeviceID, out uint PackID,out uint ParentPack)
        {
            byte[] data = MainForm.GeckoU.ReadBytes(dlcPack + 0xf4, 0xa0); // to make less trafic and get everthing we want in one way
            try
            {
                Array.Reverse(data);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            ChildPackCount = (BitConverter.ToUInt32(data, 0x94) - BitConverter.ToUInt32(data, 0x98)) >> 2;
            LicenseMask = BitConverter.ToUInt32(data, 0x14);
            DLCMountIndex = BitConverter.ToUInt32(data, 0x10);
            DLCDeviceID = BitConverter.ToUInt32(data, 0xc);
            PackID = BitConverter.ToUInt32(data, 0);
            ParentPack = BitConverter.ToUInt32(data, 0x94);
            }

        private string getPackName(uint dlcPack)
        {
            byte[] data = MainForm.GeckoU.ReadBytes(dlcPack + 0x13c, 0x20);
            uint strLength = ByteSwap.Swap(BitConverter.ToUInt32(data, 0x18));
            if (strLength > 7)
            {
                uint wchar_ptr = ByteSwap.Swap(BitConverter.ToUInt32(data, 0x14));
                return MainForm.GeckoU.PeekString16((int)strLength, wchar_ptr);
            }
            return Encoding.BigEndianUnicode.GetString(data,4,(int)strLength*2);
        }

        private void ListPacksBtn_Click(object sender, EventArgs e)
        {
            DLCPackListView.Clear();
            uint start = MainForm.GeckoU.PeekUInt(0x10A2AFD4);
            uint end = MainForm.GeckoU.PeekUInt(0x10A2AFD8);
            uint maxStorage = MainForm.GeckoU.PeekUInt(0x10A2AFDc);

            currentAmount = ((end - start) >> 2)-1;
            uint maxAmount = ((maxStorage - start) >> 2);
            updatePackCountLabel();
            for (uint i = 1;i<currentAmount-1;i++)
            {
                uint dlcPack = MainForm.GeckoU.PeekUInt(start + i * 4);
                string name = getPackName(dlcPack);
                DLCPackListView.Items.Add(name).SubItems.Add(dlcPack.ToString());
            }
        }

        private void setLicenseMaskBtn_Click(object sender, EventArgs e)
        {
            uint dlcPack = uint.Parse(DLCPackListView.SelectedItems[0].SubItems[1].Text);
            MainForm.GeckoU.WriteInt(dlcPack + 0x17c,1);
        }

        private void viewPackInfo(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            removePackBtn.Enabled = true;
            StringBuilder packInfo = new StringBuilder("DLC Pack Info");
            uint dlcPack = uint.Parse(e.Item.SubItems[1].Text);
            uint ChildpacksCount = 0, licenseMask = 0, DLCMountIndex = 0, DLCDeviceID = 0, PackID = 0, parentPack = 0;
            getPackInfos(dlcPack, out ChildpacksCount, out licenseMask, out DLCMountIndex, out DLCDeviceID, out PackID, out parentPack);
            setLicenseMaskBtn.Enabled = licenseMask == 0;
            packInfo.Append("\nName : ");
            packInfo.Append(e.Item.Text);
            packInfo.Append("\nPack ID : ");
            packInfo.Append(PackID);
            packInfo.Append("\nDLC Mount Index : ");
            packInfo.Append(DLCMountIndex);
            packInfo.Append("\nDLC Device ID : ");
            packInfo.Append(DLCDeviceID);
            packInfo.Append("\nLicenseMask : ");
            packInfo.Append(licenseMask);
            packInfo.Append("\nChild Pack Count : ");
            packInfo.Append(ChildpacksCount);
            packInfo.Append("\nParent Pack : ");
            packInfo.Append(parentPack.ToString("X8"));
            dlcPackInfoLabel.Text = packInfo.ToString();
        }

        private void removePackBtn_Click(object sender, EventArgs e)
        {
            uint dlcPack = uint.Parse(DLCPackListView.SelectedItems[0].SubItems[1].Text);
            DLCPackListView.SelectedItems[0].Remove();
            // first check if it has child packs that are use in texturepacks :)
            

            uint[] args = { 0x10A2AFD0, dlcPack };
            MainForm.GeckoU.CallFunction(0x02ae7e30, args); // DLCManager::removePack(DLCPack *)
            removePackBtn.Enabled = false;
            setLicenseMaskBtn.Enabled = false;
            currentAmount -= 1;
            updatePackCountLabel();
        }
    }
}
