using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using System;
using System.Windows.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class LootTableEditor : MetroForm
    {
        //These are entity loot tables values/address organized by the first letter of their name (Bat, Blaze etc etc) so DONT change these unless you're adding more

        private readonly uint[] _loottableIds =
        {
            0x7ED0, 0x7F20, 0x7FC0, 0x8010, 0x80B0, 0x8100, 0x8150, 0x81A0, 0x81F0, 0x82E0, 0x83D0, 0x8330, 0x8380,
            0x8470, 0x8420, 0x84C0, 0x8510, 0x8560, 0x85B0, 0x000, 0x3FC8, 0x86A0, 0x86F0, 0x87E0, 0x8880,
            0x88D0, 0x8920, 0x8970, 0x9460, 0x8A10, 0x8A60, 0x8AB0, 0x8B50, 0x8BF0, 0x8CE0, 0x8D80, 0x8E20, 0x8E70,
            0x8EC0, 0x8F10, 0x8F60, 0x8FB0, 0x9000, 0x8BA0, 0x9050, 0x90F0, 0x8650, 0x9140, 0x91E0,
            0x9280, 0x9320, 0x9370, 0x9410, 0x9500
        };

        private uint[] _loottableAddr =
        {
            0x020A1DE0, 0x0214B4F8, 0x021CBD38, 0x021BB0C4, 0x022764FC, 0x022759C4, 0x022D3008, 0x022D0CF8, 0x022E040C,
            0x022DE57C, 0x02399D88,
            0x023B7968, 0x023C7CAC, 0x023B9D9C, 0x023CD6E0, 0x0245881C, 0x0245AE24, 0x0245CFF8, 0x02507EAC, 0x024E6050,
            0x02511480, 0x025E3130, 0x025F1358, 0x02667B10,
            0x0275F504, 0x0278AEFC, 0x0278DD80, 0x0275BD28, 0x02763998, 0x027953C0, 0x0282A0AC, 0x0282CE3C, 0x02853BE0,
            0x0288087C, 0x028C0338, 0x0293F554, 0x0294C73C,
            0x02942E64, 0x02952208, 0x02944EC8, 0x0294FB40, 0x02949110, 0x02A56F50, 0x02A5A450, 0x02A45768, 0x02A7B0A4,
            0x02A8ACC4, 0x02A47CB4, 0x02A443F8, 0x02A498B4,
            0x02A827D4, 0x02A3D8B0, 0x02A4D46C, 0x02A4CC90
        };
        public LootTableEditor(MainForm injector)
        {
            InitializeComponent();
            StyleMngr.Style = Style = injector.StyleMngr.Style;
            StyleMngr.Theme = Theme = injector.StyleMngr.Theme;
        }

        private void Init(object sender, EventArgs e)
        {
            DiscordRp.SetPresence("Connected", "Loot Table Editor");
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRp.SetPresence("Connected", new MainForm().worldTab.Text + " tab");
        }

        private void ApplyBtnClicked(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(_loottableAddr[replaceBox.SelectedIndex], MainForm.GeckoU.Mix(0x38630000, _loottableIds[withBox.SelectedIndex]));
            this.Close();
        }
    }
}
