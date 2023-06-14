using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    public partial class MapTextEditor : MetroForm
    {
        private readonly IniFile _savedData = new(Application.StartupPath + @"\Saved\Data\Minecraft.Wii.U.Mod.Injector.Data.ini");
        private readonly string _savedDataDir = Application.StartupPath + @"\Saved\Data\";

        public MapTextEditor(MainForm iw)
        {
            InitializeComponent();
            StyleMngr.Style = Style = iw.StyleMngr.Style;
            StyleMngr.Theme = Theme = iw.StyleMngr.Theme;
            DiscordRpc.SetPresence("Connected", "Map Text Editor");

            if (!System.IO.Directory.Exists(_savedDataDir))
                System.IO.Directory.CreateDirectory(_savedDataDir);

            foreach (var saved in _savedData.GetKeys("MapTextEditor"))
                MapText.AutoCompleteCustomSource.Add(_savedData.Read(saved, "MapTextEditor"));
        }

        private void SetMapTextClicked(object sender, EventArgs e)
        {
            const uint textStart = 0x108E2834;

            MainForm.GeckoU.ClearString(textStart, 0x24);
            MainForm.GeckoU.WriteString16(textStart, MapText.Text);
            _savedData.Write("SavedText" + _savedData.GetKeys("MapTextEditor").Count, MapText.Text, "MapTextEditor");
        }

        private void VariablesBtnClicked(object sender, EventArgs e)
        {
            Messaging.Show(
                "Map Text Variables:\n%i: Coordinate as an Integer\n%d: Coordinate as a decimal\n%f: Coordinate as a float\n%x: Coordinate as a Hexadecimal");
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRpc.SetPresence("Connected", new MainForm().MainTabs.SelectedTab.Text + " Tab");
            Dispose();
        }
    }
}