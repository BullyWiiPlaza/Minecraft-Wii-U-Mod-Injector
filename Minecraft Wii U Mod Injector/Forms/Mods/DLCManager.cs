using System;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U;
using Minecraft_Wii_U_Mod_Injector.Wii_U.Minecraft;

namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    public partial class DLCManager : MetroForm
    {
        public DLCManager(MainForm form)
        {
            InitializeComponent();
            StyleMngr.Style = Style = form.StyleMngr.Style;
            StyleMngr.Theme = Theme = form.StyleMngr.Theme;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DiscordRP.SetPresence("Connected", "DLC Manager");
        }

        private void OnExit(object sender, FormClosingEventArgs e)
        {
            DiscordRP.SetPresence("Connected", new MainForm().MainTabs.SelectedTab.Text + " tab");
            Dispose();
        }

        private int currentAmount = 0;
        private readonly uint DLCManager_ptr = 0x10A2AFD0;
        private void UpdatePackCountLabel()
        {
            PackCountLabel.Text = "Current Pack amount : " + currentAmount.ToString();
        }

        private void GetPackInfo(uint dlcPack, out uint ChildPackCount, out uint LicenseMask, out uint DLCMountIndex, out uint DLCDeviceID, out uint PackID)
        {
            byte[] data = MainForm.GeckoU.ReadBytes(dlcPack + 0xf4, 0xa0); // to use less traffic and get everything we want in one go
            Array.Reverse(data);
            ChildPackCount = (BitConverter.ToUInt32(data, 0x98) - BitConverter.ToUInt32(data, 0x9c)) >> 2;
            LicenseMask = BitConverter.ToUInt32(data, 0x14);
            DLCMountIndex = BitConverter.ToUInt32(data, 0x10);
            DLCDeviceID = BitConverter.ToUInt32(data, 0xc);
            PackID = BitConverter.ToUInt32(data, 0);
        }

        private string GetPackName(uint dlcPack)
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
                currentAmount = MCVectorFunctions.GetVectorSize(DLCManager_ptr, 4, out uint start, out uint end, out _) - 1;
                UpdatePackCountLabel();
                for (uint i = 1; i < currentAmount - 1; i++)
                {
                    uint dlcPack = MainForm.GeckoU.PeekUInt(start + i * 4);
                    string name = GetPackName(dlcPack);
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

        private void SetLicenseMask(object sender, EventArgs e)
        {
            uint dlcPack = uint.Parse(DLCPackListView.SelectedItems[0].SubItems[1].Text);
            MainForm.GeckoU.WriteInt(dlcPack + 0x17c, 1);
            setLicenseMaskBtn.Enabled = false;
        }

        private void ViewPackInfo(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            removePackBtn.Enabled = true;
            uint dlcPack = uint.Parse(e.Item.SubItems[1].Text);
            GetPackInfo(dlcPack, out uint ChildpacksCount, out uint licenseMask, out uint DLCMountIndex, out uint DLCDeviceID, out uint PackID);
            setLicenseMaskBtn.Enabled = licenseMask == 0;
            dlcPackInfoLabel.Text = $"DLC Pack Info\n" +
                $"Name: {e.Item.Text}\n" +
                $"Pack ID: {PackID}\n" +
                $"DLC Mount Index: {DLCMountIndex}\n" +
                $"DLC Device ID: {DLCDeviceID}\n" +
                $"LicenseMask: {licenseMask}\n" +
                $"Child Pack Count: {ChildpacksCount}";
        }

        private bool RemoveDLCTexturePack(uint childStart,uint childCount)
        {
            uint texturePackRepo = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109cd8e4) + 0x160);
            uint vec_ptr = MainForm.GeckoU.PeekUInt(texturePackRepo + 0x4c);
            int currentSize = MCVectorFunctions.GetVectorSize(vec_ptr, 4, out uint start, out _, out _);
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
                        MCVectorFunctions.EraseVectorObject(vec_ptr, pos, 4);
                        MainForm.GeckoU.CallFunction(0x030b5204, dlcTexturePack, 1); // DLCTexturePack::~DLCTexturePack
                        break;
                    }
                }
            }
            return found;
        }

        private bool RemoveLevelGenOpt(uint dlcpack_ref)
        {
            uint LevelGenerator_ptr = MainForm.GeckoU.PeekUInt(0x10A2B3E0);
            int GenerationOptionsCount = MCVectorFunctions.GetVectorSize(LevelGenerator_ptr, 4, out uint GenerationOptionsStart, out _, out _);
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

        private void RemovePackBtn_Click(object sender, EventArgs e)
        {
            // someone please clean this up :|
            if (MessageBox.Show("Do you really want to delete this Skin/Texture Pack?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            uint dlcPack = uint.Parse(DLCPackListView.SelectedItems[0].SubItems[1].Text);
            DLCPackListView.SelectedItems[0].Remove();
            //MessageBox.Show(dlcPack.ToString("X8"));
            // first check if it has child packs that are used in texturepacks
            int childCount = MCVectorFunctions.GetVectorSize(dlcPack + 0xf0, 4, out uint childStart, out _, out _);
            var res = false;
            if (childCount != 0)
            {
                res = RemoveDLCTexturePack(childStart, (uint)childCount);
            }
            var res2 = RemoveLevelGenOpt(dlcPack);
            MessageBox.Show("Contained in Texturepack : " + res.ToString() + "\nContained in Game Rule Manager : " + res2.ToString());
            MainForm.GeckoU.CallFunction(0x02ae7e30, DLCManager_ptr, dlcPack); // DLCManager::removePack(DLCPack *)
            removePackBtn.Enabled = false;
            setLicenseMaskBtn.Enabled = false;
            currentAmount -= 1;
            UpdatePackCountLabel();
        }
    }
}
