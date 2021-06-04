using MetroFramework.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class Credits : MetroForm
    {
        public Credits(MainForm injector)
        {
            InitializeComponent();
            StyleMngr.Style = this.Style = injector.StyleMngr.Style;
            StyleMngr.Theme = this.Theme = injector.StyleMngr.Theme;
        }
    }
}
