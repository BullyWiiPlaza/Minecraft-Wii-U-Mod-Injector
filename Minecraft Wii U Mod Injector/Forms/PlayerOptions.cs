using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using System;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class PlayerOptions : MetroForm
    {
        private readonly uint _localPlayer = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x10A0A648) + 0x2C);
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
            MainForm.GeckoU.WriteUInt(0x1B000000,
                0x0); //Write the gamemode values to free memory space so we can pass them through RPC
            MainForm.GeckoU.WriteUInt(0x1B000004, 0x1);
            MainForm.GeckoU.WriteUInt(0x1B000008, 0x2);
            //MainForm.GeckoU.WriteUInt(0x1B00000C, 0x4); I don't see how this is different from survival or adventure...

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

               /* case 4:
                    MainForm.GeckoU.CallFunction(0x031F49B0, _localPlayer, 0x1B00000C);
                    break;*/
            }
        }

        private void DropStackBtnClicked(object sender, EventArgs e)
        {
            MainForm.GeckoU.CallFunction(0x031E7534, _localPlayer, 0x0);
        }

        private readonly UInt32[] capeIDTable =
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

        private void CapeBoxChanged(object sender, EventArgs e)
        {
            UInt32 capeID = (UInt32)capeIDTable[CapeBox.SelectedIndex];
            MainForm.GeckoU.CallFunction(0x2f6fc2c,0 ,capeID ,0 ); // static GameSettings::SetPlayerCape(int, unsigned int, bool)
        }
    }
}
