using MetroFramework.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class FAQ : MetroForm
    {
        public FAQ(MainForm Injector)
        {
            InitializeComponent();
            StyleMngr.Style = Style = Injector.StyleMngr.Style;
            StyleMngr.Theme = Theme = Injector.StyleMngr.Theme;
        }
    }
}
