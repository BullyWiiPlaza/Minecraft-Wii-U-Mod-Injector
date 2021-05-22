using Minecraft_Wii_U_Mod_Injector.helpers.winforms;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector.helpers.files
{
    class Exceptions
    {
        public static IniFile INI = new IniFile(Application.StartupPath + "/logs/");

        public enum ExceptionId
        {
            FailedUpdate = 1,
            ConnectionProblem = 2,
            FailedtoLog = 3,
            FailedtoSetup = 4,
            FailedtoClose = 5,
            FailedtoGetGameLanguage = 6,
            FailedtoReadINI = 7,
            FailedtoWriteINI = 8,
            UnknownFail = 9,
            NullReference = 10,
            TimedOut = 11,
            DatabaseError = 12,
        }

        public static void LogError(Exception ErrorLog, string Information, ExceptionId ErrorCode, bool showLogs, bool showMsg)
        {
            try
            {
                string CleanDate = DateTime.Now.ToString().Replace("/", "-").Replace(":", "-");

                if (!Directory.Exists(Application.StartupPath + "/logs/"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "/logs/");
                }

                INI = new IniFile(Application.StartupPath + "/logs/" + CleanDate + "-" + ErrorLog.Source + ".ini");
                INI.Write("ExceptionMessage", ErrorLog.Message);
                INI.Write("ExceptionInformation", Information);
                INI.Write("ExceptionID", ErrorCode.ToString());
                INI.Write("ExceptionString", ErrorLog.ToString());
                INI.Write("Timestamp", CleanDate);

                if(showLogs)
                    Process.Start(Application.StartupPath + "/logs/" + CleanDate + "-" + ErrorLog.Source + ".ini");

                Messaging.Show(MessageBoxIcon.Stop, "An Error has occured, a log file has been written to /logs/" + CleanDate + "-" + ErrorLog.Source + ".ini, the file has been opened.");
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }
    }
}
