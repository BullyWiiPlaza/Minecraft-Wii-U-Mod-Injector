using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Ookii.Dialogs.WinForms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;
using Minecraft_Wii_U_Mod_Injector.Properties;
using Application = System.Windows.Forms.Application;

namespace Minecraft_Wii_U_Mod_Injector.Forms.Managers
{
    public partial class CemuPckMngr : MetroForm
    {
        #region references

        private readonly MainForm _iw;
        private readonly string _cemuPckRootDir = Application.StartupPath + @"\Saved\Cemu\";

        private readonly StringBuilder _cemuGraphicPckRulesBuilder = new();
        private readonly StringBuilder _cemuGraphicPckPatchesBuilder = new();

        private readonly Dictionary<string, double> _sliderDefaults = new ()
        {
            { "EnchantmentLevelSlider", 0 },
            { "JumpHeightSlider", 0.420 },
            { "ReachSlider", 4.5 },
            { "HitBoxScaleSlider", 0.5 },
            { "FieldOfViewSlider", 1.875 },
            { "FieldOfViewSplitSlider", 0.700 },
            { "RiptideFlyingSpeedSlider", 0.2500 },
            { "WalkingSpeedScaleSlider", 0.163 },
            { "SprintingSpeedScaleSlider", 1.875 },
            { "PlayerModelScaleSlider", 0.9375 },
            { "FrictionSlider", 0.91000003 },
            { "WaterDownStrengthSlider", 1.285 },
            { "AirborneSpeedSlider", 0.2 },
            { "PotionAmplifierSlider", 0 },
            { "MaxStackSlider", 64 },
            { "LureSlider", 0 },
            { "LuckSlider", 0 },
            { "WorldSizeSlider", 172 },
            { "NetherSizeSlider", 176 },
            { "BabyRateSlider", 5 },
            { "WoolMultiplierSlider", 3 },
            { "RequiredPlayersSlider", 2 },
            { "RefillIntervalSlider", 30 },
            { "RingScoreGreen", 0 },
            { "RingScoreOrange", 0 },
            { "RingScoreBlue", 0 },
            { "LiquidSpreadTimeSlider", 0 }
        };
        #endregion

        public CemuPckMngr(MainForm iw)
        {
            InitializeComponent();

            _iw = iw;

            // Apply themes
            StyleMngr.Style = Style = iw.StyleMngr.Style;
            StyleMngr.Theme = Theme = iw.StyleMngr.Theme;

            // The TabControls their selected index are stored from the editor so we reset them here
            MainTabs.SelectedIndex = 0;
            ModificationTabs.SelectedIndex = 0;
            MinigamesTabs.SelectedIndex = 0;

            // Set the ItemSize properties for TabControls so we can navigate them in the editor but not at Runtime
            MainTabs.ItemSize = MainTabs.ItemSize with { Height = 1 };
            ModificationTabs.ItemSize = ModificationTabs.ItemSize with { Height = 1 };
            MinigamesTabs.ItemSize = MinigamesTabs.ItemSize with { Height = 1 };
        }

        private void Init(object sender, EventArgs e)
        {
            if (!Directory.Exists(_cemuPckRootDir))
                Directory.CreateDirectory(_cemuPckRootDir);

            if (!Settings.Default.SeenCemuMngr)
            {
                Messaging.Show(
                    "Welcome to the Cemu Graphics Pack Manager!\nHere you are able to make Cemu graphics packs so you can use mods on Cemu. For now" +
                    " slider mods aren't supported but may in a future update.\nAll created graphics pack NEED to go into the /graphicsPack/ folder in your Cemu" +
                    " installation folder.");

                Settings.Default.SeenCemuMngr = true;
                Settings.Default.Save();
                Settings.Default.Upgrade();
            }

            DiscordRP.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected",
                "Cemu Graphics Pack Manager");
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            // Clear out the Graphic Pack builders
            _cemuGraphicPckPatchesBuilder.Clear();
            _cemuGraphicPckRulesBuilder.Clear();

            // Delete the directory containing all the individual graphic packs
            if(Directory.Exists(_cemuPckRootDir + "/temp/"))
                Directory.Delete(_cemuPckRootDir + "/temp/", true);

            DiscordRP.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected",
                _iw.MainTabs.SelectedTab.Text + " Tab");
            Dispose();
        }

        private void SwapTab(object sender, EventArgs e)
        {
            var tile = (MetroTile)sender;
            if ((string)tile.Tag == "ModTile")
            {
                if (tile == ModificationsTile)
                {
                    NavMenuModsPnl.Visible = !NavMenuModsPnl.Visible;
                    return;
                }

                // The main tab control will switch back to Modifications tab page when any of the Modification tiles are clicked
                if (MainTabs.SelectedIndex != 1) MainTabs.SelectedIndex = 1;
                if (ModificationTabs.SelectedIndex != tile.TileCount)
                    ModificationTabs.SelectedIndex = tile.TileCount;
                else
                    return;
                return;
            }

            if ((string)tile.Tag == "MgTile")
            {
                if (tile == MinigamesTile) NavMenuMgPnl.Visible = !NavMenuMgPnl.Visible;
                if (MinigamesTabs.SelectedIndex != tile.TileCount)
                    MinigamesTabs.SelectedIndex = tile.TileCount;
                else
                    return;

                // The main tab control will switch back to Minigames tab page when any of the Minigame tiles are clicked
                if (ModificationTabs.SelectedIndex != 3) ModificationTabs.SelectedIndex = 3;
                return;
            }

            if (MainTabs.SelectedIndex != tile.TileCount) MainTabs.SelectedIndex = tile.TileCount;
        }

        //TODO: Checks for whether any mods have even been applied and if not, display an error and abort
        private void SaveBtnClicked(object sender, EventArgs e)
        {
            try
            {
                _cemuGraphicPckRulesBuilder.AppendLine("[Definition]\ntitleIds = " + TitleIdsBox.Text + "\nname = " +
                                                       NameBox.Text + "\npath = " + PathBox.Text + NameBox.Text + "\n" +
                                                       "description = " + DescriptionBox.Text +
                                                       " - Generated by the Minecraft: Wii U Mod Injector\nversion = 6");

                if (string.IsNullOrWhiteSpace(NameBox.Text))
                {
                    Messaging.Show("Please enter a valid name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var gfxPckFolder = _cemuPckRootDir + "Minecraft Wii U Mod Injector - " +
                                   StringUtils.StripInvalidChars(NameBox.Text);

                _cemuGraphicPckPatchesBuilder.AppendLine("[Minecraft]\r\nmoduleMatches = " + ModuleMatchesBox.Text);

                foreach (MetroTabPage page in ModificationTabs.TabPages)
                foreach (Control c in page.Controls)
                {
                    if (c is MetroCheckBox { Checked: true } cb)
                    {
#if DEBUG
                        Console.WriteLine(@"CEMU GRAPHICS PACK MANAGER: Writing values for CheckBox " + cb.Name);
#endif
                            // Writes the control name of the CheckBox for identification purposes
                            _cemuGraphicPckPatchesBuilder.AppendLine("#" + cb.Text);

                        // We can modify multiple instructions/addresses by seperating them with | in the tag
                        if (cb.Tag.ToString().Contains("|"))
                        {
                            // Export
                            _cemuGraphicPckPatchesBuilder.AppendLine(cb.Tag.ToString().Replace('|', '\n'));
                            continue;
                        }

                        // Export
                        _cemuGraphicPckPatchesBuilder.AppendLine(cb.Tag.ToString());
                    }

                    if (c is NumericUpDown sldr)
                    {

                        if (!_sliderDefaults.TryGetValue(sldr.Name, out _))
                        {
#if DEBUG
                            Console.WriteLine(@"CEMU GRAPHICS PACK MANAGER: No default value found for " + sldr.Name +
                                              @". Skipping");
#endif
                            continue;
                        }

                        if (sldr.Value != (decimal)_sliderDefaults[sldr.Name])
                        {
#if DEBUG
                            Console.WriteLine(@"CEMU GRAPHICS PACK MANAGER: Writing values for Slider " + sldr.Name);
#endif
                            // Writes the control name of the slider for identification purposes
                            _cemuGraphicPckPatchesBuilder.AppendLine("#" + sldr.Name);

                            // Decide how we export the Slider, this is a really hacky way of doing it

                            // Exports the slider as a data section modification
                            if (sldr.Tag.ToString().Contains(".data"))
                            {
                                // We can modify multiple addresses by seperating them with & in the tag
                                if (sldr.Tag.ToString().Contains("&"))
                                {
                                    var addreStrings = sldr.Tag.ToString().Split('&');
                                    foreach (var adr in addreStrings)
                                        _cemuGraphicPckPatchesBuilder.AppendLine(adr + " = .float " + sldr.Value);
                                    continue;
                                }

                                // Export
                                _cemuGraphicPckPatchesBuilder.AppendLine(sldr.Tag.ToString().Replace(".data ", "") +
                                                                         " = .float " + sldr.Value);
                                continue;
                            }

                            // We can modify multiple addresses by seperating them with & in the tag
                            if (sldr.Tag.ToString().Contains("&"))
                            {
                                var addreStrings = sldr.Tag.ToString().Split('&');
                                foreach (var adr in addreStrings)
                                    _cemuGraphicPckPatchesBuilder.AppendLine(adr + " = li r3,0x" +
                                                                             StringUtils.ToHex(sldr.Value));
                                continue;
                            }

                            // Finally if the Slider does not modify the data section or multiple addresses, we just export it as a code section modification
                            _cemuGraphicPckPatchesBuilder.AppendLine(
                                sldr.Tag + "0x" + StringUtils.ToHex(sldr.Value));
                        }
                    }

                    // Hacky, this should probabaly get reworked
                    if (c is MetroComboBox comB)
                    {
#if DEBUG
                        Console.WriteLine(@"CEMU GRAPHICS PACK MANAGER: Writing values for ComboBox " + comB.Name);
#endif
                            if (comB == RabbitVariantBox && comB.SelectedIndex == 6)
                        {
                            _cemuGraphicPckPatchesBuilder.AppendLine("#" + comB.Name + "\n" + comB.Tag + "0x63");
                            continue;
                        }

                        if (comB.Text != string.Empty)
                            _cemuGraphicPckPatchesBuilder.AppendLine("#" + comB.Name + "\n" + comB.Tag + "0x" +
                                                                     StringUtils.ToHex(comB.SelectedIndex));
                    }
                }

                foreach (MetroTabPage page in MinigamesTabs.TabPages)
                foreach (Control c in page.Controls)
                {
                    if (c is MetroCheckBox cb)
                        if (cb.Checked)
                        {
                            _cemuGraphicPckPatchesBuilder.AppendLine("#" + cb.Text);
                            if (cb.Tag.ToString().Contains("|"))
                            {
                                _cemuGraphicPckPatchesBuilder.AppendLine(cb.Tag.ToString().Replace('|', '\n'));
                                continue;
                            }

                            _cemuGraphicPckPatchesBuilder.AppendLine(cb.Tag.ToString());
                        }

                    if (c is NumericUpDown sldrMini)
                        if (sldrMini.Value != (decimal)_sliderDefaults[sldrMini.Name])
                        {
                            _cemuGraphicPckPatchesBuilder.AppendLine("#" + sldrMini.Name);

                            if (sldrMini.Tag.ToString().Contains("&"))
                            {
                                var addreStrings = sldrMini.Tag.ToString().Split('&');
                                foreach (var adr in addreStrings)
                                    _cemuGraphicPckPatchesBuilder.AppendLine(adr + " = li r3,0x" +
                                                                             StringUtils.ToHex(sldrMini.Value));
                                continue;
                            }

                            _cemuGraphicPckPatchesBuilder.AppendLine(
                                sldrMini.Tag + "0x" + StringUtils.ToHex(sldrMini.Value));
                        }

                    if (c is MetroComboBox comB)
                        if (comB.Text != string.Empty)
                            _cemuGraphicPckPatchesBuilder.AppendLine("#" + comB.Name + "\n" + comB.Tag + "0x" +
                                                                     StringUtils.ToHex(comB.SelectedIndex));
                }

                if (!Directory.Exists(gfxPckFolder)) Directory.CreateDirectory(gfxPckFolder);

                using (var file = new StreamWriter(gfxPckFolder + @"\rules.txt"))
                {
                    file.WriteLine(_cemuGraphicPckRulesBuilder.ToString());
                }

                using (var file = new StreamWriter(gfxPckFolder + @"\patches.txt"))
                {
                    file.WriteLine(_cemuGraphicPckPatchesBuilder.ToString());
                }

                Messaging.Show("Successfully saved " + NameBox.Text + " to\n" + gfxPckFolder);

                if (Messaging.Show("Would you like to automatically export the graphics pack to Cemu?",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var folderBrowser = new VistaFolderBrowserDialog();
                    folderBrowser.SelectedPath = Settings.Default.CemuGfxLoc;

                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        Settings.Default.CemuGfxLoc = folderBrowser.SelectedPath;
                        Settings.Default.Save();
                        Miscellaneous.CopyFolder(gfxPckFolder,
                            folderBrowser.SelectedPath + @"\Minecraft Wii U Mod Injector - " + NameBox.Text);
                        Messaging.Show("Graphics Pack has been successfully installed!");
                    }
                }

                // Clear out the string builders so they don't duplicate
                _cemuGraphicPckPatchesBuilder.Clear();
                _cemuGraphicPckRulesBuilder.Clear();
            }
            catch (Exception exception)
            {
                Exceptions.LogError(exception, "An error occurred while saving/exporting Graphics Pack", true);
            }
        }

        private void LoadBtnClicked(object sender, EventArgs e)
        {
            try
            {
                IniFile gfxPckFile;
                var folderBrowser = new VistaFolderBrowserDialog();

                folderBrowser.SelectedPath = _cemuPckRootDir;

                // I wanna also check whether any controls are checked/changed but this is good enough for now
                if (NameBox.Text != string.Empty || DescriptionBox.Text != string.Empty)
                    if (Messaging.Show("Any unsaved changes will be discarded, continue?", MessageBoxButtons.YesNo) ==
                        DialogResult.No)
                        return;

                if (folderBrowser.ShowDialog() != DialogResult.OK) return;

                // Load in all the metadata
                gfxPckFile = new IniFile(folderBrowser.SelectedPath + @"\rules.txt", true);
                NameBox.Text = gfxPckFile.Read("name", "Definition");
                PathBox.Text = gfxPckFile.Read("path", "Definition");
                DescriptionBox.Text = gfxPckFile.Read("description", "Definition")
                    .Replace("- Generated by the Minecraft: Wii U Mod Injector", string.Empty);

                // Load in all the mods (Only CheckBoxes right now)
                using (var reader = new StreamReader(folderBrowser.SelectedPath + @"\patches.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();

                        if (line != null && line.StartsWith("#"))
                            foreach (MetroTabPage page in ModificationTabs.TabPages)
                            foreach (Control c in page.Controls)
                            {
                                if (c is MetroCheckBox cb)
                                    // Then check all the mods inside of the pack
                                    if (line.Trim('#').Contains(cb.Text))
                                        cb.Checked = true;

                                if (c is NumericUpDown sldr)
                                {
                                    // Set the sliders back to default if they aren't already
                                    if (line.Trim('#').Contains(sldr.Name))

                                        if (!_sliderDefaults.TryGetValue(sldr.Name, out _))
                                        {
#if DEBUG
                                            Console.WriteLine(
                                                @"CEMU GRAPHICS PACK MANAGER: No default value found for " + sldr.Name +
                                                @". Skipping");
#endif
                                            continue;
                                        }

                                    if (sldr.Value != (decimal)_sliderDefaults[sldr.Name])
                                        sldr.Value = (decimal)_sliderDefaults[sldr.Name];
                                }
                            }
                    }

                    reader.Close();
                }
            }
            catch (Exception exception)
            {
                Exceptions.LogError(exception, "An error occurred while loading Graphics Pack", true);
            }
        }


        private void ExportAllBtnClicked(object sender, EventArgs e)
        {
            try
            {
                string tempFfxPckFolder;
                var folderBrowser = new VistaFolderBrowserDialog();

                // Clears out the Graphics Pack builders
                _cemuGraphicPckRulesBuilder.Clear();
                _cemuGraphicPckPatchesBuilder.Clear();
                
                foreach (MetroTabPage page in ModificationTabs.TabPages)
                foreach (Control c in page.Controls)
                    if (c is MetroCheckBox cb)
                    {
                        tempFfxPckFolder = _cemuPckRootDir + "/temp/Minecraft Wii U Mod Injector - " + cb.Text;

                        // Build the graphic packs metadata
                        if (page == PlayersTab) {
                            _cemuGraphicPckRulesBuilder.AppendLine("[Definition]\ntitleIds = " + TitleIdsBox.Text +
                                                                   "\nname = " +
                                                                   cb.Text +
                                                                   "\npath = Minecraft: Wii U Edition/Minecraft Wii U Mod Injector/Players & Items/" +
                                                                   cb.Text +
                                                                   "\n" +
                                                                   "description = " +
                                                                   ToolTips.GetToolTip(cb).Replace(
                                                                       Environment.NewLine,
                                                                       string.Empty) +
                                                                   " - Generated by the Minecraft: Wii U Mod Injector\nversion = 6");
                        } 
                        else if (page == worldTab) {
                            _cemuGraphicPckRulesBuilder.AppendLine("[Definition]\ntitleIds = " + TitleIdsBox.Text +
                                                                   "\nname = " +
                                                                   cb.Text +
                                                                   "\npath = Minecraft: Wii U Edition/Minecraft Wii U Mod Injector/Entities & World/" +
                                                                   cb.Text +
                                                                   "\n" +
                                                                   "description = " +
                                                                   ToolTips.GetToolTip(cb).Replace(
                                                                       Environment.NewLine,
                                                                       string.Empty) +
                                                                   " - Generated by the Minecraft: Wii U Mod Injector\nversion = 6");
                        }
                        else if (page == generalTab)
                        {
                            _cemuGraphicPckRulesBuilder.AppendLine("[Definition]\ntitleIds = " + TitleIdsBox.Text +
                                                                   "\nname = " +
                                                                   cb.Text +
                                                                   "\npath = Minecraft: Wii U Edition/Minecraft Wii U Mod Injector/General/" +
                                                                   cb.Text +
                                                                   "\n" +
                                                                   "description = " +
                                                                   ToolTips.GetToolTip(cb).Replace(
                                                                       Environment.NewLine,
                                                                       string.Empty) +
                                                                   " - Generated by the Minecraft: Wii U Mod Injector\nversion = 6");
                        }


                            // Build the graphic packs patches
                            _cemuGraphicPckPatchesBuilder.AppendLine("[Minecraft]\r\nmoduleMatches = " +
                                                                 ModuleMatchesBox.Text); // Module Matches

                        _cemuGraphicPckPatchesBuilder.AppendLine("#" + cb.Text); // Name identifier

                        // Some mods require more than one patches, this splits up the seperators
                        if (cb.Tag.ToString().Contains("|"))
                            _cemuGraphicPckPatchesBuilder.AppendLine(cb.Tag.ToString().Replace('|', '\n'));

                        else
                            _cemuGraphicPckPatchesBuilder.AppendLine(cb.Tag.ToString());


                        // If the directory doesn't exist, we create it here
                        if (!Directory.Exists(tempFfxPckFolder))
                            Directory.CreateDirectory(tempFfxPckFolder);

                        // Write the metadata file to the disk
                        using (var file = new StreamWriter(tempFfxPckFolder + @"\rules.txt"))
                            file.WriteLine(_cemuGraphicPckRulesBuilder.ToString());

                        // Write the patches file to the disk
                        using (var file = new StreamWriter(tempFfxPckFolder + @"\patches.txt"))
                            file.WriteLine(StringUtils.RemoveEmpties(_cemuGraphicPckPatchesBuilder.ToString())
                                .Replace(Environment.NewLine, string.Empty).Replace(Environment.NewLine, string.Empty));

                        // Clears out the Graphics Pack builders
                        _cemuGraphicPckRulesBuilder.Clear();
                        _cemuGraphicPckPatchesBuilder.Clear();
                    }

                foreach (MetroTabPage page in MinigamesTabs.TabPages)
                foreach (Control c in page.Controls)
                    if (c is MetroCheckBox cb)
                    {
                        tempFfxPckFolder = _cemuPckRootDir + "/temp/Minecraft Wii U Mod Injector - " + cb.Text;

                        // Build the graphic packs metadata
                        if (page == GeneralMgTab)
                        {
                            _cemuGraphicPckRulesBuilder.AppendLine("[Definition]\ntitleIds = " + TitleIdsBox.Text +
                                                                   "\nname = " +
                                                                   cb.Text +
                                                                   "\npath = Minecraft: Wii U Edition/Minecraft Wii U Mod Injector/Minigames/" +
                                                                   cb.Text +
                                                                   "\n" +
                                                                   "description = " +
                                                                   ToolTips.GetToolTip(cb).Replace(
                                                                       Environment.NewLine,
                                                                       string.Empty) +
                                                                   " - Generated by the Minecraft: Wii U Mod Injector\nversion = 6");
                        }
                        else if (page == BattleTab)
                        {
                            _cemuGraphicPckRulesBuilder.AppendLine("[Definition]\ntitleIds = " + TitleIdsBox.Text +
                                                                   "\nname = " +
                                                                   cb.Text +
                                                                   "\npath = Minecraft: Wii U Edition/Minecraft Wii U Mod Injector/Minigames/Battle/" +
                                                                   cb.Text +
                                                                   "\n" +
                                                                   "description = " +
                                                                   ToolTips.GetToolTip(cb).Replace(
                                                                       Environment.NewLine,
                                                                       string.Empty) +
                                                                   " - Generated by the Minecraft: Wii U Mod Injector\nversion = 6");
                        }
                        else if (page == TumbleTab)
                        {
                            _cemuGraphicPckRulesBuilder.AppendLine("[Definition]\ntitleIds = " + TitleIdsBox.Text +
                                                                   "\nname = " +
                                                                   cb.Text +
                                                                   "\npath = Minecraft: Wii U Edition/Minecraft Wii U Mod Injector/Minigames/Tumble/" +
                                                                   cb.Text +
                                                                   "\n" +
                                                                   "description = " +
                                                                   ToolTips.GetToolTip(cb).Replace(
                                                                       Environment.NewLine,
                                                                       string.Empty) +
                                                                   " - Generated by the Minecraft: Wii U Mod Injector\nversion = 6");
                        }
                        else if (page == GlideTab)
                        {
                            _cemuGraphicPckRulesBuilder.AppendLine("[Definition]\ntitleIds = " + TitleIdsBox.Text +
                                                                   "\nname = " +
                                                                   cb.Text +
                                                                   "\npath = Minecraft: Wii U Edition/Minecraft Wii U Mod Injector/Minigames/Glide/" +
                                                                   cb.Text +
                                                                   "\n" +
                                                                   "description = " +
                                                                   ToolTips.GetToolTip(cb).Replace(
                                                                       Environment.NewLine,
                                                                       string.Empty) +
                                                                   " - Generated by the Minecraft: Wii U Mod Injector\nversion = 6");
                        }

                        // Build the graphic packs patches
                        _cemuGraphicPckPatchesBuilder.AppendLine("[Minecraft]\r\nmoduleMatches = " +
                                                                 ModuleMatchesBox.Text); // Module Matches

                        _cemuGraphicPckPatchesBuilder.AppendLine("#" + cb.Text); // Name identifier

                        // Some mods require more than one patches, this splits up the seperators
                        if (cb.Tag.ToString().Contains("|"))
                            _cemuGraphicPckPatchesBuilder.AppendLine(cb.Tag.ToString().Replace('|', '\n'));

                        else
                            _cemuGraphicPckPatchesBuilder.AppendLine(cb.Tag.ToString());


                        // If the directory doesn't exist, we create it here
                        if (!Directory.Exists(tempFfxPckFolder))
                            Directory.CreateDirectory(tempFfxPckFolder);

                        // Write the metadata file to the disk
                        using (var file = new StreamWriter(tempFfxPckFolder + @"\rules.txt"))
                        {
                            file.WriteLine(_cemuGraphicPckRulesBuilder.ToString());
                        }

                        // Write the patches file to the disk
                        using (var file = new StreamWriter(tempFfxPckFolder + @"\patches.txt"))
                        {
                            file.WriteLine(StringUtils.RemoveEmpties(_cemuGraphicPckPatchesBuilder.ToString())
                                .Replace(Environment.NewLine, string.Empty).Replace(Environment.NewLine, string.Empty));
                        }

                        // Clears out the Graphics Pack builders
                        _cemuGraphicPckRulesBuilder.Clear();
                        _cemuGraphicPckPatchesBuilder.Clear();
                    }

                folderBrowser.SelectedPath = Settings.Default.CemuGfxLoc;

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                    Miscellaneous.CopyFolder(_cemuPckRootDir + "/temp/", folderBrowser.SelectedPath);

                Messaging.Show("All mods have been exported as individual Graphic Packs!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Exceptions.LogError(exception, "An error occurred while exporting individual Graphics Packs", true);
            }
        }

        private void WorldSizeBtnClicked(object sender, EventArgs e)
        {
            Messaging.Show(
                "Changing the size of the world/nether works as follow:\nThe value you put in is multiplied by that value to determine how many chunks will be generated in your world.\n" +
                "So if you want a 4 chunk world your value should be 2 as it will be multiplied by 2 which is 4 chunks.\n\nSaving a world with a custom size and reloading it without the " +
                "Mod Injector will reset the world border to it's\noriginal size and generate/remove new chunks.");
        }
    }
}