using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;

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

        private void OnLoad(object sender, EventArgs e)
        {
            DiscordRp.SetPresence("Connected", "DLC Manager");
        }

        private void OnExit(object sender, FormClosingEventArgs e)
        {
            DiscordRp.SetPresence("Connected", new MainForm().MainTabs.SelectedTab.Text + " tab");
            Dispose();
        }

        private uint currentAmount = 0;
        private readonly uint DLCManager_ptr = 0x10A2AFD0;
        private void updatePackCountLabel()
        {
            PackCountLabel.Text = "Current Pack amount : " + currentAmount.ToString();
        }

        private void memmove(uint __dest, uint __src, uint __n)
        {
            uint[] args = { __dest, __src, __n };
            MainForm.GeckoU.CallFunction(0x02ad54dc, args);
        }

        private void eraseVectorObject(uint vector_ptr, uint vector_position, uint sizeOfEachElement)
        {
            uint start, end;
            uint size = getVectorSize(vector_ptr, sizeOfEachElement, out start, out end, out _);
            for (uint i = 0; i < size; i++)
            {
                uint pos = start + i * sizeOfEachElement;
                if (pos == vector_position) // found position
                {
                    memmove(pos, pos + sizeOfEachElement, end - (pos + sizeOfEachElement));
                    end -= sizeOfEachElement;
                    MainForm.GeckoU.WriteUInt(vector_ptr + 8, end);
                    break;
                }
            }
            return;
        }
        private uint getVectorSize(uint vector_ptr,uint sizeOfElement,out uint start,out uint end, out uint max)
        {
            byte[] data = MainForm.GeckoU.ReadBytes(vector_ptr + 4, 12);
            if (data.Length > 1)
            {
                start = ByteSwap.Swap(BitConverter.ToUInt32(data, 0));
                end = ByteSwap.Swap(BitConverter.ToUInt32(data, 4));
                max = ByteSwap.Swap(BitConverter.ToUInt32(data, 8)); // will be important when pack injection is stable
                return (end - start) / sizeOfElement;
            }
            start = end = max = 0;
            return 0;
        }

        private void getPackInfos(uint dlcPack,out uint ChildPackCount, out uint LicenseMask, out uint DLCMountIndex, out uint DLCDeviceID, out uint PackID)
        {
            byte[] data = MainForm.GeckoU.ReadBytes(dlcPack + 0xf4, 0xa0); // to make less trafic and get everthing we want in one way
            Array.Reverse(data);
            ChildPackCount = (BitConverter.ToUInt32(data, 0x98) - BitConverter.ToUInt32(data, 0x9c)) >> 2;
            LicenseMask = BitConverter.ToUInt32(data, 0x14);
            DLCMountIndex = BitConverter.ToUInt32(data, 0x10);
            DLCDeviceID = BitConverter.ToUInt32(data, 0xc);
            PackID = BitConverter.ToUInt32(data, 0);
        }

        private string getPackName(uint dlcPack)
        {
            byte[] data = MainForm.GeckoU.ReadBytes(dlcPack + 0x13c, 0x20);
            uint strLength = ByteSwap.Swap(BitConverter.ToUInt32(data, 0x18));
            uint capacity = ByteSwap.Swap(BitConverter.ToUInt32(data, 0x1c));
            if (capacity > 7)
            {
                uint wchar_ptr = ByteSwap.Swap(BitConverter.ToUInt32(data, 0x14));
                return MainForm.GeckoU.PeekString16((int)strLength, wchar_ptr);
            }
            return Encoding.BigEndianUnicode.GetString(data, 4, (int)strLength * 2);
        }

        private void ListPacksBtn_Click(object sender, EventArgs e)
        {
            var Btn = (MetroButton)sender;

            try
            {
                Btn.Text = @"Gathering...";
                Btn.Enabled = false;

                DLCPackListView.Clear();
                uint start, end;
                currentAmount = getVectorSize(DLCManager_ptr, 4, out start, out end, out _) - 1;
                updatePackCountLabel();
                for (uint i = 1; i < currentAmount - 1; i++)
                {
                    uint dlcPack = MainForm.GeckoU.PeekUInt(start + i * 4);
                    string name = getPackName(dlcPack);
                    DLCPackListView.Items.Add(name).SubItems.Add(dlcPack.ToString());
                }

                Btn.Text = @"List DLC Packs";
                Btn.Enabled = true;
            }
            catch (Exception exception)
            {
                Exceptions.LogError(exception, "Failed to list DLC Packs", true);
                Btn.Text = @"List DLC Packs";
                Btn.Enabled = true;
            }
        }

        private void setLicenseMaskBtn_Click(object sender, EventArgs e)
        {
            uint dlcPack = uint.Parse(DLCPackListView.SelectedItems[0].SubItems[1].Text);
            MainForm.GeckoU.WriteInt(dlcPack + 0x17c, 1);
            setLicenseMaskBtn.Enabled = false;
        }

        private void viewPackInfo(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            removePackBtn.Enabled = true;
            StringBuilder packInfo = new StringBuilder("DLC Pack Info");
            uint dlcPack = uint.Parse(e.Item.SubItems[1].Text);
            uint ChildpacksCount, licenseMask, DLCMountIndex, DLCDeviceID, PackID;
            getPackInfos(dlcPack, out ChildpacksCount, out licenseMask, out DLCMountIndex, out DLCDeviceID, out PackID);
            setLicenseMaskBtn.Enabled = licenseMask == 0;
            packInfo.Append("\nName: ");
            packInfo.Append(e.Item.Text);
            packInfo.Append("\nPack ID: ");
            packInfo.Append(PackID);
            packInfo.Append("\nDLC Mount Index: ");
            packInfo.Append(DLCMountIndex);
            packInfo.Append("\nDLC Device ID: ");
            packInfo.Append(DLCDeviceID);
            packInfo.Append("\nLicenseMask: ");
            packInfo.Append(licenseMask);
            packInfo.Append("\nChild Pack Count: ");
            packInfo.Append(ChildpacksCount);
            dlcPackInfoLabel.Text = packInfo.ToString();
        }


        private bool removeDLCTexturePack(uint childStart,uint childCount)
        {
            uint texturePackRepo = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109cd8e4) + 0x160);
            uint vec_ptr = MainForm.GeckoU.PeekUInt(texturePackRepo + 0x4c);
            uint start;
            uint currentSize = getVectorSize(vec_ptr, 4, out start, out _, out _);
            uint pos;
            bool found = false;
            for (uint i = 0; i < currentSize; i++) // loop through the texturepack repo vector
            {
                if (found) break;
                pos = start + i * 4;
                uint dlcTexturePack = MainForm.GeckoU.PeekUInt(pos);
                uint textureDLCPack = MainForm.GeckoU.PeekUInt(dlcTexturePack + 0xf0);
                for (uint j = 0; j < childCount; j++)
                {
                    uint DlcpackChild = MainForm.GeckoU.PeekUInt(childStart + j * 4);
                    found = textureDLCPack == DlcpackChild;
                    if (found)
                    {
                        eraseVectorObject(vec_ptr, pos, 4);
                        MainForm.GeckoU.CallFunction(0x030b5204, dlcTexturePack, 1); // DLCTexturePack::~DLCTexturePack
                        break;
                    }
                }
            }
            return found;
        }

        private bool removeLevelGenOpt(uint dlcpack_ref)
        {
            uint LevelGenerator_ptr = MainForm.GeckoU.PeekUInt(0x10A2B3E0);
            uint GenerationOptionsStart;
            uint GenerationOptionsCount = getVectorSize(LevelGenerator_ptr, 4, out GenerationOptionsStart, out _, out _);
            bool found = false;
            for (uint i = 0; i < GenerationOptionsCount; i++)
            {
                uint LevelGenOpt_ptr = MainForm.GeckoU.PeekUInt(GenerationOptionsStart + i * 4);
                uint GenOptPack_ptr = MainForm.GeckoU.PeekUInt(LevelGenOpt_ptr + 0x174);
                found = GenOptPack_ptr == dlcpack_ref;
                if (found)
                {
                    // MainForm.GeckoU.CallFunction(0x02d18280, LevelGenOpt_ptr, 1); // LevelGenerationOptions::~LevelGenerationOptions
                    MainForm.GeckoU.CallFunction(0x02d163e8, LevelGenerator_ptr, LevelGenOpt_ptr); // LevelGenerators::removeLevelGenerator
                    break;
                }
            }
            return found;
        }

        private void removePackBtn_Click(object sender, EventArgs e)
        {
            // someone please clean this up :|
            var choice = MessageBox.Show("Do you really want to delete this Skin/Texture Pack?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (choice != DialogResult.Yes) return;
            uint dlcPack = uint.Parse(DLCPackListView.SelectedItems[0].SubItems[1].Text);
            DLCPackListView.SelectedItems[0].Remove();
            //MessageBox.Show(dlcPack.ToString("X8"));
            // first check if it has child packs that are used in texturepacks
            uint childStart;
            uint childCount = getVectorSize(dlcPack + 0xf0, 4, out childStart, out _, out _);
            var res = false;
            if (childCount != 0)
            {
                res = removeDLCTexturePack(childStart, childCount);
            }
            var res2 = removeLevelGenOpt(dlcPack);
            MessageBox.Show("Contained in Texturepack : " + res.ToString() + "\nContained in Game Rule Manager : " + res2.ToString());
            MainForm.GeckoU.CallFunction(0x02ae7e30, DLCManager_ptr, dlcPack); // DLCManager::removePack(DLCPack *)
            removePackBtn.Enabled = false;
            setLicenseMaskBtn.Enabled = false;
            currentAmount -= 1;
            updatePackCountLabel();
        }
    }
}
