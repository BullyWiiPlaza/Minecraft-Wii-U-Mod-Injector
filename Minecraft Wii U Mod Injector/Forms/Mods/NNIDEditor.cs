using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;

namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    public partial class NnidEditor : MetroForm
    {
        public uint NnidNameAddress = MainForm.GeckoU.PeekUInt(0x10AD1C58) + 0x50;
        public NnidEditor(MainForm injector)
        {
            InitializeComponent();
            StyleMngr.Style = Style = injector.StyleMngr.Style;
            StyleMngr.Theme = Theme = injector.StyleMngr.Theme;
        }

        private void Init(object sender, EventArgs e)
        {
            DiscordRpc.SetPresence("Connected", "Nintendo Network ID Editor");

            if(!MainForm.IsPointerLoaded())
                WarningLbl.Hide();
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRpc.SetPresence("Connected", new MainForm().MainTabs.SelectedTab.Text + " Tab");
            Dispose();
        }

        private void NnidChangeBtnClicked(object sender, EventArgs e)
        {
            MainForm.GeckoU.ClearString(NnidNameAddress, NnidNameAddress + 0x44);
            MainForm.GeckoU.WriteString16(NnidNameAddress, NNIDNameBox.Text);
            Close();
        }

        private void ReadNameBtnClicked(object sender, EventArgs e)
        {
            NNIDNameBox.Text = MainForm.GeckoU.PeekString16(0x22, NnidNameAddress);
        }

        private void NNIDResetBtn_Click(object sender, EventArgs e)
        {
            var defaultNNID = MainForm.GeckoU.PeekString(0x12, NnidNameAddress + 0x239);
            MainForm.GeckoU.ClearString(NnidNameAddress, NnidNameAddress + 0x44);
            MainForm.GeckoU.WriteString16(NnidNameAddress, defaultNNID);
            Close();
        }
    }
}
