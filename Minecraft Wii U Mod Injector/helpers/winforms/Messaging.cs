using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Helpers.Winforms
{
    class Messaging
    {
        public static MainForm Owner = new MainForm();

        public Messaging(MainForm owner)
        {
            Owner = owner;
        }

        public static void Show(string message)
        {
            FlexibleMessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static void Show(MessageBoxIcon icon, string message)
        {
            FlexibleMessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, icon);
        }

        public static void Show(MessageBoxIcon icon, MessageBoxButtons btns, string message)
        {
            FlexibleMessageBox.Show(message, Application.ProductName, btns, icon);
        }

        public static DialogResult Show(string message, MessageBoxButtons btns)
        {
            return FlexibleMessageBox.Show(message, Application.ProductName, btns, MessageBoxIcon.Question);
        }
        public static DialogResult Show(string message, MessageBoxButtons btns, MessageBoxIcon icon)
        {
            return FlexibleMessageBox.Show(message, Application.ProductName, btns, icon);
        }
    }
}
