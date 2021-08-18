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

        private void CapeBoxChanged(object sender, EventArgs e)
        {
            switch (CapeBox.SelectedIndex)
            {
                case 0:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80001518);
                    break;

                case 1:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80001519);
                    break;

                case 2:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x8000151A);
                    break;

                case 3:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x8000151B);
                    break;

                case 4:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x8000151C);
                    break;

                case 5:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000BB8);
                    break;

                case 6:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000C81);
                    break;

                case 7:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000C82);
                    break;

                case 8:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000C83);
                    break;

                case 9:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000C84);
                    break;

                case 10:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000C85);
                    break;

                case 11:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000C92);
                    break;

                case 12:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000519);
                    break;

                case 13:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x8000051C);
                    break;

                case 14:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x8000051D);
                    break;

                case 15:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x8000051E);
                    break;

                case 16:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B1A);
                    break;

                case 17:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B1B);
                    break;

                case 18:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B17);
                    break;

                case 19:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B1E);
                    break;

                case 20:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B1F);
                    break;

                case 21:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B07);
                    break;

                case 22:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B0B);
                    break;

                case 23:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B0D);
                    break;

                case 24:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B0E);
                    break;

                case 25:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B10);
                    break;

                case 26:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B18);
                    break;

                case 27:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B13);
                    break;

                case 28:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B14);
                    break;

                case 29:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B0B);
                    break;

                case 30:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B1C);
                    break;

                case 31:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x80000B1D);
                    break;

                case 32:
                    MainForm.GeckoU.CallFunction(0x031F3A40, _localPlayer, 0x8000065A);
                    break;
            }
        }
    }
}
