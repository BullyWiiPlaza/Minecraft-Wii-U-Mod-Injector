using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.helpers;
using System;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector.forms
{
    public partial class NNIDEditor : MetroForm
    {
        public NNIDEditor(MainForm Injector)
        {
            InitializeComponent();
            StyleManager.Style = this.Style = Injector.StyleManager.Style;
            StyleManager.Theme = this.Theme = Injector.StyleManager.Theme;
        }

        private void Init(object sender, EventArgs e)
        {
            DiscordRP.SetPresence("Modding", "In NNID Editor");
        }

        private void NNIDChangeBtnClicked(object sender, EventArgs e)
        {
            uint nnid_name_address = MainForm.GeckoU.PeekUInt(0x109D1DDC) + 0xED8;
            MainForm.GeckoU.ClearString(nnid_name_address, nnid_name_address + 0x24);
            MainForm.GeckoU.WriteString(nnid_name_address, NNIDNameBox.Text);
            this.Close();
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRP.SetPresence("Modding", "In " + new MainForm().MainTabs.SelectedTab.Text + " tab");
        }
    }
}
