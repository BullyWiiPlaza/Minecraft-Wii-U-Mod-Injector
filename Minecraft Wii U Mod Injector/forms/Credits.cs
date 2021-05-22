using MetroFramework.Forms;

namespace Minecraft_Wii_U_Mod_Injector.forms
{
    public partial class Credits : MetroForm
    {
        public Credits(MainForm Injector)
        {
            InitializeComponent();
            StyleManager.Style = this.Style = Injector.StyleManager.Style;
            StyleManager.Theme = this.Theme = Injector.StyleManager.Theme;
        }

        private void Exiting(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {

        }
    }
}
