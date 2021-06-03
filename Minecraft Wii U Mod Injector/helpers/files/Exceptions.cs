using Minecraft_Wii_U_Mod_Injector.Helpers.Winforms;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Helpers.Files
{
    class Exceptions
    {
        public static IniFile INI = new IniFile(Application.StartupPath + "/logs/");
        public static string exceptionDate = DateTime.Now.ToString().Replace("/", "-").Replace(":", "-");

        public static void LogError(Exception errorLog, string information, bool showLogs, bool showMsg)
        {
            try
            {              
                if (!Directory.Exists(Application.StartupPath + "/logs/"))
                    Directory.CreateDirectory(Application.StartupPath + "/logs/");

                INI = new IniFile(Application.StartupPath + "/logs/mcwiiuinjector-" + Setup.LocalVer + "-" + exceptionDate + "-" + errorLog.Source + ".ini");
                INI.Write("Exception Message", errorLog.Message);
                INI.Write("Exception Information", information);
                INI.Write("Stack Trace", errorLog.StackTrace);

                Clipboard.SetText(errorLog.StackTrace);

                if (showLogs)
                {
                    Process.Start(Application.StartupPath + "/logs/mcwiiuinjector-" + Setup.LocalVer + "-" + exceptionDate + "-" + errorLog.Source + ".ini");
                    Messaging.Show(MessageBoxIcon.Stop, "An Error has occured, a log file has been written to /logs/mcwiiuinjector-" + Setup.LocalVer + "-" + exceptionDate + "-" + errorLog.Source + ".ini, the file has been opened.\nFurther more, the stack trace has been copied to your clipboard.");
                }

                if(showMsg)
                    Messaging.Show(MessageBoxIcon.Stop, "An Error has occured, a log file has been written to /logs/mcwiiuinjector-" + Setup.LocalVer + "-" + exceptionDate + "-" + errorLog.Source + ".ini\nFurther more, the stack trace has been copied to your clipboard.");
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }
    }
}
