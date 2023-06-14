using System.Windows.Forms;
using Minecraft_Wii_U_Mod_Injector.Properties;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
{
    public class States
    {
        public static MainForm Injector = new();

        public enum StatesIds
        {
            Disconnected = 1,
            Connecting = 2,
            Connected = 3
        }

        public static StatesIds CurrentState = StatesIds.Disconnected;

        public States(MainForm mainForm)
        {
            Injector = mainForm;
        }

        /// <summary>
        /// Switches between different connection states that affect usability of certain features
        /// </summary>
        /// <param name="state">State we should be in</param>
        public static void SwapState(StatesIds state)
        {
            switch (state)
            {
                case StatesIds.Disconnected:
                    Injector.ConnectBtn.Text = @"Connect";
                    Injector.ConnectBtn.Enabled = true;
                    SetupTabs(Injector, false);
                    Injector.WiiUIPv4Box.Text = Settings.Default.WiiUIPv4;
                    CurrentState = StatesIds.Disconnected;
                    break;

                case StatesIds.Connected:
                    Injector.ConnectBtn.Enabled = true;
                    Injector.ConnectBtn.Text = @"Disconnect";
                    SetupTabs(Injector, true);
                    Settings.Default.WiiUIPv4 = Injector.WiiUIPv4Box.Text;
                    CurrentState = StatesIds.Connected;
                    break;

                case StatesIds.Connecting:
                    Injector.ConnectBtn.Enabled = false;
                    Injector.ConnectBtn.Text = @"Connecting...";
                    SetupTabs(Injector, false);
                    CurrentState = StatesIds.Connecting;
                    break;
            }
        }

        /// <summary>
        /// Setup Tabs which depending on connection status
        /// </summary>
        /// <param name="injector">The Main Window</param>
        /// <param name="enabled">Whether pages that require an active connection to the Wii U should be enabled</param>
        public static void SetupTabs(MainForm injector, bool enabled)
        {
            foreach (MetroFramework.Controls.MetroTabPage page in injector.MainTabs.TabPages)
            {
                if ((string)page.Tag != "GeckoURequired") 
                    continue;

                foreach (Control c in page.Controls)
                {
                    if(c.Enabled != enabled)
                        c.Enabled = enabled;
                }
            }

            Injector.MinigamesTab.Enabled = enabled;
        }
    }
}
