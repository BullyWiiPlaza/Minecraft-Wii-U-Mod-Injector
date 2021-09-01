using System;
using System.Windows.Forms;
using Minecraft_Wii_U_Mod_Injector.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;

namespace Minecraft_Wii_U_Mod_Injector.Helpers.Files
{
    class Exceptions
    {
        public static void LogError(Exception errorLog, string information, bool showMsg)
        {
            try
            {
                Console.WriteLine(errorLog);
                Clipboard.SetText(errorLog.StackTrace);

                if(showMsg) Messaging.Show(MessageBoxIcon.Stop, "Oops! An Error has occurred:\n" + information + "\nThe Stack Trace has been copied to your clipboard.");
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }
    }
}
