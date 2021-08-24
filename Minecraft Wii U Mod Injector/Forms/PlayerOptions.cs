using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class PlayerOptions : MetroForm
    {
        private readonly uint _localPlayer = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x10A0A648) + 0x2C);

        private readonly uint[] _capeIdTable =
        {
            0x80001518, 0x80001519, 0x8000151A, 0x8000151B,
            0x8000151C, 0x80000BB8, 0x80000C81, 0x80000C82,
            0x80000C83, 0x80000C84, 0x80000C85, 0x80000C92,
            0x80000519, 0x8000051C, 0x8000051D, 0x8000051E,
            0x80000B1A, 0x80000B1B, 0x80000B17, 0x80000B1E,
            0x80000B1F, 0x80000B07, 0x80000B0B, 0x80000B0D,
            0x80000B0E, 0x80000B10, 0x80000B18, 0x80000B13,
            0x80000B14, 0x80000B0B, 0x80000B1C, 0x80000B1D,
            0x8000065A
        };

        public PlayerOptions(MainForm injector)
        {
            InitializeComponent();
            StyleMngr.Style = Style = injector.StyleMngr.Style;
            StyleMngr.Theme = Theme = injector.StyleMngr.Theme;
        }

        private void Init(object sender, EventArgs e)
        {
            DiscordRp.SetPresence("Connected", "Player Options window");
#if DEBUG
            Console.WriteLine(@"LocalPlayer: 0x" + _localPlayer.ToString("X4"));
#endif
            foreach (string skin in Settings.Keys("Skins"))
            {
                SkinList.Items.Add(Settings.Read(skin, "Skins") + " | " + skin);
            }
        }

        private void CloseContainersBtnClicked(object sender, EventArgs e)
        {
            MainForm.GeckoU.CallFunction(0x031E8710, _localPlayer, 0x0);
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRp.SetPresence("Connected", new MainForm().playersTab.Text + " tab");
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
            MainForm.GeckoU.WriteUInt(0x1B000000, 0x0);
            MainForm.GeckoU.WriteUInt(0x1B000004, 0x1);
            MainForm.GeckoU.WriteUInt(0x1B000008, 0x2);

            switch (GameModeBox.SelectedIndex)
            {
                case 0:
                    MainForm.GeckoU.CallFunction(0x031F40A0, _localPlayer, 0x1B000000);
                    break;

                case 1:
                    MainForm.GeckoU.CallFunction(0x031F40A0, _localPlayer, 0x1B000004);
                    break;

                case 2:
                    MainForm.GeckoU.CallFunction(0x031F40A0, _localPlayer, 0x1B000008);
                    break;

                case 3:
                    MainForm.GeckoU.CallFunction(0x031F49B0, _localPlayer, 0x0);
                    break;
            }
        }

        private void DropStackBtnClicked(object sender, EventArgs e)
        {
            MainForm.GeckoU.CallFunction(0x031E7534, _localPlayer, 0x0);
        }

        private void CapeBoxChanged(object sender, EventArgs e)
        {
            var capeId = _capeIdTable[CapeBox.SelectedIndex];
            MainForm.GeckoU.CallFunction(0x02F6FC2C, 0, capeId,
                0); //static GameSettings::SetPlayerCape(int, unsigned int, bool)
        }

        private void AddSkinBtnClicked(object sender, EventArgs e)
        {
            var skinId = Convert.ToString(SkinIDBox.Value, CultureInfo.InvariantCulture);

            Settings.Write(skinId, SkinNameBox.Text, "Skins");

            SkinList.Items.Add(SkinNameBox.Text + " | " + skinId);
        }

        private void SkinListChanged(object sender, EventArgs e)
        {
            //this can be cleaned up but yeah I am lazy lmao
            var skinIdString = SkinList.Text;
            skinIdString = skinIdString.Substring(skinIdString.IndexOf('|') + 1);
            skinIdString = Regex.Replace(skinIdString, @"\s+", "");

            MainForm.GeckoU.CallFunction(0x02F70028, 0, Convert.ToUInt32(skinIdString), 0);
        }

        private void GetSkinIDBtnClicked(object sender, EventArgs e)
        {
            SkinIDBox.Value = MainForm.GeckoU.CallFunction(0x02F70178, 0);
        }

        private void LoopSkinsToggled(object sender, EventArgs e)
        {
            SkinLoopTimer.Enabled = LoopSkins.Checked;
        }

        private void SkinLooper(object sender, EventArgs e)
        {
            SkinList.SelectedIndex = new Random().Next(0, SkinList.Items.Count);
        }
    }
}