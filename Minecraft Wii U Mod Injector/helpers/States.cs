using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
{
    public class States
    {
        public static MainForm Injector = new MainForm();

        public enum StatesIds
        {
            Disconnected = 1,
            Connecting = 2,
            Connected = 3,
            Error = 4
        }

        public static StatesIds currentState = StatesIds.Disconnected;

        public States(MainForm MainForm)
        {
            Injector = MainForm;
        }

        public static void SwapState(StatesIds State)
        {
            switch (State)
            {
                case StatesIds.Disconnected:
                    Injector.connectBtn.Text = "Connect";
                    Injector.connectBtn.Enabled = true;
                    SetupTabs(Injector, false);
                    Injector.wiiuIpv4Box.Text = Settings.Read("WiiUIPv4", "Wii U");
                    currentState = StatesIds.Disconnected;
                    break;

                case StatesIds.Connected:
                    Injector.connectBtn.Enabled = true;
                    Injector.connectBtn.Text = "Disconnect";
                    SetupTabs(Injector, true);
                    Settings.Write("WiiUIPv4", Injector.wiiuIpv4Box.Text, "Wii U");
                    currentState = StatesIds.Connected;
                    break;

                case StatesIds.Connecting:
                    Injector.connectBtn.Enabled = false;
                    Injector.connectBtn.Text = "Connecting...";
                    SetupTabs(Injector, false);
                    currentState = StatesIds.Connecting;
                    break;
            }
        }

        public static void SetupTabs(MainForm Injector, bool enabled)
        {
            foreach (MetroFramework.Controls.MetroTabPage Page in Injector.MainTabs.TabPages)
            {
                if ((string)Page.Tag == "needsGeckoU")
                {
                    foreach (Control c in Page.Controls)
                    {
                        c.Enabled = enabled;
                    }
                }
            }

            Injector.minigamesTab.Enabled = enabled;
        }
    }
}
