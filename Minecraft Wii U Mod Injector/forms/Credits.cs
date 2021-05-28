using MetroFramework.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class Credits : MetroForm
    {
        public Credits(MainForm Injector)
        {
            InitializeComponent();
            StyleManager.Style = this.Style = Injector.StyleManager.Style;
            StyleManager.Theme = this.Theme = Injector.StyleManager.Theme;
        }
    }
}
