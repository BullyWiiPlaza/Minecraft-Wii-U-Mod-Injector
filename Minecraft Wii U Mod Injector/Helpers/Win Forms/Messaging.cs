using System.Windows.Forms;
using MetroFramework;

namespace Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms
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

        public static void Show(string message, string caption)
        {
            FlexibleMessageBox.Show(message, Application.ProductName + caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static void ShowTutorial(string message, string caption)
        {
            MetroMessageBox.Show(Owner, message, Application.ProductName + caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static void Show(MessageBoxIcon icon, string message)
        {
            FlexibleMessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, icon);
        }

        public static void Show(MessageBoxIcon icon, MessageBoxButtons btns, string message)
        {
            FlexibleMessageBox.Show(message, Application.ProductName, btns, icon);
        }

        //TODO: Maybe some other time, sucks the colors aren't customizable instead of being locked to icons
        /*public static void ShowMetro(string message, string caption, MetroColorStyle color) 
        {
            switch (color)
            {
                case MetroColorStyle.Blue:
                    MetroMessageBox.Show(Owner, message, Application.ProductName + caption, MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
                case MetroColorStyle.Red:
                    MetroMessageBox.Show(Owner, message, Application.ProductName + caption, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
                case MetroColorStyle.Orange:
                    MetroMessageBox.Show(Owner, message, Application.ProductName + caption, MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case MetroColorStyle.Green:
                    MetroMessageBox.Show(Owner, message, Application.ProductName + caption, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                case MetroColorStyle.White:
                    MetroMessageBox.Show(Owner, message, Application.ProductName + caption, MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                    break;
            }
        }*/

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
