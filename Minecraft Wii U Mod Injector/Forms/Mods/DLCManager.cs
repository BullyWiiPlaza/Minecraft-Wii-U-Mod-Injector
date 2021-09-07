using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

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

        private void ListPacksBtn_Click(object sender, EventArgs e)
        {
            DLCPackListView.Clear();
            uint start = MainForm.GeckoU.PeekUInt(0x10A2AFD4);
            uint end = MainForm.GeckoU.PeekUInt(0x10A2AFD8);
            uint maxStorage = MainForm.GeckoU.PeekUInt(0x10A2AFDc);

            currentAmount = ((end - start) >> 2)-1;
            uint maxAmount = ((maxStorage - start) >> 2);
            updatePackCountLabel();
            // this is very messy code :|
            for (uint i = 1;i<currentAmount-1;i++)
            {
                uint dlcPack = MainForm.GeckoU.PeekUInt(start + i * 4);
                uint strLength = MainForm.GeckoU.PeekUInt(dlcPack + 0x13c + 0x18);
                string name;
                if (strLength > 7)
                {
                    uint wchar_ptr = MainForm.GeckoU.PeekUInt(dlcPack + 0x13c + 0x14);
                    name = MainForm.GeckoU.PeekString16((int)strLength*2,wchar_ptr);
                }
                else
                    name = MainForm.GeckoU.PeekString16((int)strLength*2, dlcPack + 0x13c + 4);

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
            StringBuilder packInfo = new StringBuilder("DLC Pack Info\n");
            uint dlcPack = uint.Parse(e.Item.SubItems[1].Text);
            uint licenseMask = MainForm.GeckoU.PeekUInt(dlcPack + 0x17c);
            setLicenseMaskBtn.Enabled = licenseMask == 0;
            packInfo.Append("Name : ");
            packInfo.Append(e.Item.Text + "\n");
            packInfo.Append("Pack ID : ");
            packInfo.Append(MainForm.GeckoU.PeekUInt(dlcPack + 0x190) + "\n");
            packInfo.Append("DLC Mount Index : ");
            packInfo.Append(MainForm.GeckoU.PeekUInt(dlcPack + 0x180) + "\n");
            packInfo.Append("DLC Device ID : ");
            packInfo.Append(MainForm.GeckoU.PeekUInt(dlcPack + 0x184) + "\n");
            packInfo.Append("LicenseMask : ");
            packInfo.Append(licenseMask);
            dlcPackInfoLabel.Text = packInfo.ToString();
        }

        private void removePackBtn_Click(object sender, EventArgs e)
        {
            uint dlcPack = uint.Parse(DLCPackListView.SelectedItems[0].SubItems[1].Text);
            removePackBtn.Enabled = setLicenseMaskBtn.Enabled = false;
            currentAmount -= 1;
            updatePackCountLabel();
            DLCPackListView.SelectedItems[0].Remove();
            uint[] args = { 0x10A2AFD0, dlcPack };
            MainForm.GeckoU.CallFunction(0x02ae7e30, args); // DLCManager::removePack(DLCPack *)
        }
    }
}
