using MetroFramework.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class Credits : MetroForm
    {
        public Credits(MainForm Injector)
        {
            InitializeComponent();
            StyleMngr.Style = this.Style = Injector.StyleMngr.Style;
            StyleMngr.Theme = this.Theme = Injector.StyleMngr.Theme;
        }
    }
}
