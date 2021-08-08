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
            Console.WriteLine(@"LocalPlayer: 0x" + _localPlayer.ToString("X4"));
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
    }
}
