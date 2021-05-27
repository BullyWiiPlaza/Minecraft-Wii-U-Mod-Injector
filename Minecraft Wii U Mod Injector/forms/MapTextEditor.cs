using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using Minecraft_Wii_U_Mod_Injector.Helpers.Winforms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class MapTextEditor : MetroForm
    {
        MainForm IWindow = new MainForm();

        public MapTextEditor(MainForm IW)
        {
            InitializeComponent();
            IWindow = IW;
            StyleManager.Style = this.Style = IWindow.StyleManager.Style;
            StyleManager.Theme = this.Theme = IWindow.StyleManager.Theme;
            DiscordRP.SetPresence("Modding", "in Map Text Editor");
        }

        private void SetMapTextClicked(object sender, EventArgs e)
        {
            uint TextStart = 0x108E283B;
            string MapTextNew = "\0" + StringUtils.InsertStrings(MapText.Text, 1, "\0");

            MainForm.GeckoU.ClearString(TextStart, 0x108E2858);
            MainForm.GeckoU.WriteString(TextStart, MapTextNew);
        }

        private void variablesBtnClicked(object sender, EventArgs e)
        {
            Messaging.Show("Map Text Variables:\n\r%i: Coordinate as an Integer\n\r%d: Coordinate as a decimal\n\r%f: Coordinate as a float\n\r%x: Coordinate as a Hexadecimal");
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRP.SetPresence("Modding", "Idle");
        }
    }
}
