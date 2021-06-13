using MetroFramework.Forms;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class Faq : MetroForm
    {
        public Faq(MainForm injector)
        {
            InitializeComponent();
            StyleMngr.Style = Style = injector.StyleMngr.Style;
            StyleMngr.Theme = Theme = injector.StyleMngr.Theme;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams CP = base.CreateParams;
                CP.ExStyle = CP.ExStyle | 0x02000000;
                return CP;
            }
        }
    }
}
