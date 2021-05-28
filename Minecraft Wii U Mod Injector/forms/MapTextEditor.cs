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
            DiscordRP.SetPresence("Connected", "Map Text Editor");
        }

        private void SetMapTextClicked(object sender, EventArgs e)
        {
            uint TextStart = 0x108E2834;
            string MapTextNew = "\0" + StringUtils.InsertStrings(MapText.Text, 1, "\0");

            MainForm.GeckoU.ClearString(TextStart, 0x108E2858);
            MainForm.GeckoU.WriteString(TextStart, MapTextNew);
        }

        private void variablesBtnClicked(object sender, EventArgs e)
        {
            Messaging.Show("Map Text Variables:\n%i: Coordinate as an Integer\n%d: Coordinate as a decimal\n%f: Coordinate as a float\n%x: Coordinate as a Hexadecimal");
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRP.SetPresence("Connected", new MainForm().generalTab.Text);
        }
    }
}
