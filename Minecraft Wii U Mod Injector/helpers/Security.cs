using System;
using System.Diagnostics;
using System.Timers;

namespace Minecraft_Wii_U_Mod_Injector.helpers
{
    class Security
    {
        private static Timer RAMEditingToolsTimer = new Timer();
        public static void StartRAMEditingToolsSearch()
        {
            RAMEditingToolsTimer.Elapsed += new ElapsedEventHandler(CheckForLiveRAMEditing);
            RAMEditingToolsTimer.Interval = 10000;
            RAMEditingToolsTimer.Start();
        }

        private static void CheckForLiveRAMEditing(object source, ElapsedEventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainWindowTitle.Contains("JGecko U"))
                {
                    p.Kill();
                    Environment.Exit(0);
                }
                if (p.MainWindowTitle.Contains("tcpGecko dotNET"))
                {
                    p.Kill();
                    Environment.Exit(0);
                }
                if(p.ProcessName == "python")
                {
                    p.Kill();
                    Environment.Exit(0);
                }
            }
        }
    }
}
