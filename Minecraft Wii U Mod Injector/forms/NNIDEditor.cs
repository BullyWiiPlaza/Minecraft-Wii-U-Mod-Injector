using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using System;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class NnidEditor : MetroForm
    {
        public uint NnidNameAddress = MainForm.GeckoU.PeekUInt(0x109D1DDC) + 0xED8;
        public NnidEditor(MainForm injector)
        {
            InitializeComponent();
            StyleMngr.Style = Style = injector.StyleMngr.Style;
            StyleMngr.Theme = Theme = injector.StyleMngr.Theme;
        }

        private void Init(object sender, EventArgs e)
        {
            DiscordRp.SetPresence("Connected", "Nintendo Network ID Editor");
        }

        private void NnidChangeBtnClicked(object sender, EventArgs e)
        {
            MainForm.GeckoU.ClearString(NnidNameAddress, NnidNameAddress + 0x24);
            MainForm.GeckoU.WriteString(NnidNameAddress, NNIDNameBox.Text);
            this.Close();
        }

        private void ReadNameBtnClicked(object sender, EventArgs e)
        {
            NNIDNameBox.Text = MainForm.GeckoU.PeekString(16, NnidNameAddress); //This is a bit broken, last letter appears distorted
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRp.SetPresence("Connected", new MainForm().playersTab.Text + " tab");
        }
    }
}
