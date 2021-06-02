using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using System;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class NNIDEditor : MetroForm
    {
        public uint nnid_name_address = MainForm.GeckoU.PeekUInt(0x109D1DDC) + 0xED8;
        public NNIDEditor(MainForm Injector)
        {
            InitializeComponent();
            StyleManager.Style = this.Style = Injector.StyleManager.Style;
            StyleManager.Theme = this.Theme = Injector.StyleManager.Theme;
        }

        private void Init(object sender, EventArgs e)
        {
            DiscordRP.SetPresence("Connected", "Nintendo Network ID Editor");
        }

        private void NNIDChangeBtnClicked(object sender, EventArgs e)
        {
            MainForm.GeckoU.ClearString(nnid_name_address, nnid_name_address + 0x24);
            MainForm.GeckoU.WriteString(nnid_name_address, NNIDNameBox.Text);
            this.Close();
        }

        private void readNameBtnClicked(object sender, EventArgs e)
        {
            NNIDNameBox.Text = MainForm.GeckoU.PeekString(16, nnid_name_address); //This is a bit broken, last letter appears distorted
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRP.SetPresence("Connected", new MainForm().playersTab.Text + " tab");
        }
    }
}
