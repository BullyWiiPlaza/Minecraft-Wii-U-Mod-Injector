using MetroFramework.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class FAQ : MetroForm
    {
        public FAQ(MainForm Injector)
        {
            InitializeComponent();
            StyleManager.Style = Style = Injector.StyleManager.Style;
            StyleManager.Theme = Theme = Injector.StyleManager.Theme;
        }
    }
}
