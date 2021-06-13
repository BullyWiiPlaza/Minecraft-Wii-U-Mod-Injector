using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class MapTextEditor : MetroForm
    {
        private MainForm _iw;

        public MapTextEditor(MainForm iw)
        {
            InitializeComponent();
            _iw = iw;
            StyleMngr.Style = Style = _iw.StyleMngr.Style;
            StyleMngr.Theme = Theme = _iw.StyleMngr.Theme;
            DiscordRp.SetPresence("Connected", "Map Text Editor");
        }

        private void SetMapTextClicked(object sender, EventArgs e)
        {
            uint textStart = 0x108E2834;
            string mapTextNew = "\0" + StringUtils.InsertStrings(MapText.Text, 1, "\0");

            MainForm.GeckoU.ClearString(textStart, 0x108E2858);
            MainForm.GeckoU.WriteString(textStart, mapTextNew);
        }

        private void VariablesBtnClicked(object sender, EventArgs e)
        {
            Messaging.Show("Map Text Variables:\n%i: Coordinate as an Integer\n%d: Coordinate as a decimal\n%f: Coordinate as a float\n%x: Coordinate as a Hexadecimal");
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRp.SetPresence("Connected", _iw.generalTab.Text + " tab");
        }

        private void MapTextEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
