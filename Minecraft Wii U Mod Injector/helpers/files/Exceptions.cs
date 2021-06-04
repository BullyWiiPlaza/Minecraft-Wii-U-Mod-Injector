using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;

namespace Minecraft_Wii_U_Mod_Injector.Helpers.Files
{
    class Exceptions
    {
        public static IniFile Ini = new IniFile(Application.StartupPath + "/logs/");
        public static string ExceptionDate = DateTime.Now.ToString(CultureInfo.CurrentCulture).Replace("/", "-").Replace(":", "-");

        public static void LogError(Exception errorLog, string information, bool showLogs, bool showMsg)
        {
            try
            {              
                if (!Directory.Exists(Application.StartupPath + "/logs/"))
                    Directory.CreateDirectory(Application.StartupPath + "/logs/");

                Ini = new IniFile(Application.StartupPath + "/logs/mcwiiuinjector-" + Setup.LocalVer + "-" + ExceptionDate + "-" + errorLog.Source + ".ini");
                Ini.Write("Exception Message", errorLog.Message);
                Ini.Write("Exception Information", information);
                Ini.Write("Stack Trace", errorLog.StackTrace);

                Clipboard.SetText(errorLog.StackTrace);

                if (showLogs)
                {
                    Process.Start(Application.StartupPath + "/logs/mcwiiuinjector-" + Setup.LocalVer + "-" + ExceptionDate + "-" + errorLog.Source + ".ini");
                    Messaging.Show(MessageBoxIcon.Stop, "An Error has occured, a log file has been written to /logs/mcwiiuinjector-" + Setup.LocalVer + "-" + ExceptionDate + "-" + errorLog.Source + ".ini, the file has been opened.\nFurther more, the stack trace has been copied to your clipboard.");
                }

                if(showMsg)
                    Messaging.Show(MessageBoxIcon.Stop, "An Error has occured, a log file has been written to /logs/mcwiiuinjector-" + Setup.LocalVer + "-" + ExceptionDate + "-" + errorLog.Source + ".ini\nFurther more, the stack trace has been copied to your clipboard.");
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }
    }
}
