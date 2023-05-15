using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;

namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    public partial class PlayerOptions : MetroForm
    {
        private readonly IniFile _savedData = new(Application.StartupPath + @"\Saved\Data\Minecraft.Wii.U.Mod.Injector.Data.ini");
        private readonly string _savedDataDir = Application.StartupPath + @"\Saved\Data\";

        // Are these 2 the same? I can't tell
        private readonly uint _localPlayer = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x10A0A648) + 0x2C);
        private readonly uint _Player = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34);
        
        private readonly Dictionary<string, uint> _Capes = new()
        {
            { "Minecon 2011", 0x80001518 },
            { "Minecon 2012", 0x80001519 },
            { "Minecon 2013", 0x8000151A },
            { "Minecon 2015", 0x8000151B },
            { "Minecon 2016", 0x8000151C },
            { "Jeb Ponytail", 0x80000BB8 },
            { "The Grim Reaper", 0x80000C81 },
            { "Devil", 0x80000C82 },
            { "Dracula", 0x80000C83 },
            { "Evil Wizard", 0x80000C84 },
            { "Bride of Frankenstein", 0x80000C85 },
            { "Wicked Witch", 0x80000C92 },
            { "Senator Padmé Amidala", 0x80000519 },
            { "Senator Palpatine", 0x8000051C },
            { "Count Dooku", 0x8000051D },
            { "General Grievous", 0x8000051E },
            { "Erinyes", 0x80000B1A },
            { "Dryad", 0x80000B1B },
            { "Spartoi", 0x80000B17 },
            { "Hephaestus", 0x80000B1E },
            { "Prometheus", 0x80000B1F },
            { "Heracles", 0x80000B07 },
            { "Zeus", 0x80000B0D },
            { "Hades", 0x80000B0E },
            { "Poseidon", 0x80000B10 },
            { "Apollo", 0x80000B18 },
            { "Artemis", 0x80000B13 },
            { "Athena",  0x80000B14 },
            { "Perseus/Trojan Warrior", 0x80000B0B },
            { "Atlanta", 0x80000B1C },
            { "Cadmus", 0x80000B1D },
            { "Drone", 0x8000065A }
        };

        public PlayerOptions(MainForm injector)
        {
            InitializeComponent();
            StyleMngr.Style = Style = injector.StyleMngr.Style;
            StyleMngr.Theme = Theme = injector.StyleMngr.Theme;
        }

        private void Init(object sender, EventArgs e)
        {
            DiscordRP.SetPresence("Connected", "Player Options window");
#if DEBUG
            Console.WriteLine(@"PLAYER OPTIONS: LocalPlayer: 0x" + _localPlayer.ToString("X4"));
            Console.WriteLine(@"PLAYER OPTIONS: SelfPlayer: 0x" + _Player.ToString("X4"));
#endif
            if (!System.IO.Directory.Exists(_savedDataDir))
                System.IO.Directory.CreateDirectory(_savedDataDir);

            foreach (var skin in _savedData.GetKeys("Skins"))
                SkinList.Items.Add(_savedData.Read(skin, "Skins") + " | " + skin);

            CapeBox.DataSource = new BindingSource(_Capes, null);
            CapeBox.DisplayMember = "Key";
            CapeBox.ValueMember = "Value";
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRP.SetPresence("Connected", new MainForm().MainTabs.SelectedTab.Text + " Tab");
            Dispose();
        }

        private string GetIDFromList(string skinId)
        {
            var skinIdString = skinId;
            skinIdString = skinIdString.Substring(skinIdString.IndexOf('|') + 1);
            skinIdString = Regex.Replace(skinIdString, @"\s+", "");

            return skinIdString;
        }

        private void CloseContainersBtnClicked(object sender, EventArgs e)
        {
            MainForm.GeckoU.CallFunction(0x031E8710, _localPlayer, 0x0);
        }

        private void CameraBoxChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.CallFunction(0x031F22A4, _localPlayer, (uint) CameraBox.SelectedIndex);
        }

        private void OpenScoreboardBtnClicked(object sender, EventArgs e)
        {
            MainForm.GeckoU.CallFunction(0x031A09A8, _localPlayer, 0x01);
        }

        private void GameModeBoxChanged(object sender, EventArgs e)
        {
            if (GameModeBox.SelectedIndex < 3)
            {
                uint gametype = MainForm.GeckoU.PeekUInt(0x109C4D24 + (uint)GameModeBox.SelectedIndex * 4);
                MainForm.GeckoU.CallFunction(0x031F40A0, _localPlayer, gametype);
            }
            else
            {
                MainForm.GeckoU.CallFunction(0x031F49B0, _localPlayer, 0x0);
            }
        }

        private void DropStackBtnClicked(object sender, EventArgs e)
        {
            MainForm.GeckoU.CallFunction(0x031E7534, _localPlayer, 0x0);
        }

        private void CapeBoxChanged(object sender, EventArgs e)
        {
            // Prevent the CapeBox event from running when the ComboBox isn't clicked, this is to prevent it from changing when populating
            MetroComboBox cb = (MetroComboBox)sender;
            if (!cb.Focused)
            {
                return;
            }

            var capeId = _Capes[CapeBox.Text];
            MainForm.GeckoU.CallFunction(0x02F6FC2C, 0, capeId, 0);
        }

        private void SwapOffhandBtn_Click(object sender, EventArgs e)
        {
            var xyzPos = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x54;
            var packet = MainForm.GeckoU.CallFunction(0x028AEC5C, 0x0, 0x6, xyzPos, MainForm.GeckoU.PeekUInt(0x109C46A0), 0x0);
            MainForm.GeckoU.WriteBytes(0x12000000, new byte[8]);
            MainForm.GeckoU.WriteUInt(0x12000000, packet);
            MainForm.GeckoU.CallFunction64(0x0304A5D8, MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x878), 0x12000000);
        }

        private void XpLevelSliderChanged(object sender, EventArgs e)
        {
            var level = (uint)XpLevelSlider.Value;

            MainForm.GeckoU.CallFunction(0x031EA12C, _localPlayer, level, level, level);
        }

        #region skins
        private void AddSkinBtnClicked(object sender, EventArgs e)
        {
            var skinId = Convert.ToString(SkinIDBox.Value, CultureInfo.InvariantCulture);

            _savedData.Write(skinId, SkinNameBox.Text, "Skins");

            SkinList.Items.Add(SkinNameBox.Text + " | " + skinId);
        }

        private void DeleteSkinBtnClicked(object sender, EventArgs e)
        {
            _savedData.DeleteKey(GetIDFromList(SkinList.Text), "Skins");
            SkinList.Items.RemoveAt(SkinList.SelectedIndex);
        }

        private void SkinListChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.CallFunction(0x02F70028, 0, Convert.ToUInt32(GetIDFromList(SkinList.Text)), 0);
        }

        private void GetSkinIdBtnClicked(object sender, EventArgs e)
        {
            SkinIDBox.Value = MainForm.GeckoU.CallFunction(0x02F70178, 0);
        }
        #endregion

        #region skin loop
        private void LoopSkinsToggled(object sender, EventArgs e)
        {
            SkinLoopTimer.Enabled = LoopSkins.Checked;
        }

        private void SkinLooper(object sender, EventArgs e)
        {
            SkinList.SelectedIndex = new Random().Next(0, SkinList.Items.Count);
        }
        #endregion

        private void UpdatePlrInfoBtnClicked(object sender, EventArgs e)
        {
            ModeratorBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x0272B714, _Player)).ToString();
            InvisiblePrivilegeBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x0271B6A0, _Player, 0x0)).ToString();
            InvulnerablePrivilegeBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x0270F670, _Player, 0x0)).ToString();
            CanHarmAnimalsBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x0272B304, _Player)).ToString();
            CanHarmPlayersBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x0271B720, _Player)).ToString();
            CanFlyBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x0271AA10, _Player)).ToString();
            CanIgnoreExhaustionBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x0271BA08, _Player)).ToString();
            CanMineBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x0272B284, _Player)).ToString();
            CanBuildBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x027256D0, _Player, 0x0)).ToString();
            IsXpDropperBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x027259E8, _Player)).ToString();
            IsCreativeFlyingBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x0272B74C, _Player, 0x0)).ToString();
            IsHurtBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x02725624, _Player, 0x0)).ToString();
            IsImmobileBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x02712158, _Player, 0x0)).ToString();
            IsInWallBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x02720690, _Player, 0x0)).ToString();
            IsLocalPlayerBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x027206E4, _Player)).ToString();
            IsPushedByWaterBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x02726FB0, _Player, 0x0)).ToString();
            IsReducedDebugBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x02728584, _Player, 0x0)).ToString();
            IsRespawnedForcedBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x02721D5C, _Player, 0x0)).ToString();
            //IsSendMsgBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x026D2F80, _Player, 0x0)).ToString(); // Crashes? Not sure how else to call this..
            IsSleepingBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x02721D10, _Player, 0x0)).ToString();
            IsSleepingEnoughBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x02721D18, _Player, 0x0)).ToString();
            IsSpectatingPlayerBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x0272C57C, _Player, 0x0)).ToString();
            IsStarvingBox.Text = Convert.ToBoolean(MainForm.GeckoU.CallFunction(0x0270BC78, _Player, 0x0)).ToString();
        }

        private void JumpBtnClicked(object sender, EventArgs e)
        {
            MainForm.GeckoU.CallFunction(0x02721E08, _Player);
        }

        private void PlayRingSndBtnClicked(object sender, EventArgs e)
        {
            MainForm.GeckoU.CallFunction(0x0270FD94, _Player, 0x0);
        }
    }
}