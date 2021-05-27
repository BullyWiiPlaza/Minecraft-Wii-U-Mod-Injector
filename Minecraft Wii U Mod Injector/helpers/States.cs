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

        public States(MainForm MainForm)
        {
            Injector = MainForm;
        }

        public static void SwapState(StatesIds State)
        {
            if (State == StatesIds.Disconnected)
            {
                Injector.connectBtn.Text = "Connect";
                Injector.connectBtn.Enabled = true;
                Injector.wiiuIpv4Box.Text = Configuration.ReadKey("WiiUHost", "Wii U");
                SetupTabs(Injector, false);
                Injector.GetStates = StatesIds.Disconnected;
            }
            if (State == StatesIds.Connected)
            {
                Injector.connectBtn.Enabled = true;
                Injector.connectBtn.Text = "Disconnect";
                Configuration.WriteKey("WiiUHost", Injector.wiiuIpv4Box.Text, "Wii U");
                SetupTabs(Injector, true);
                Injector.GetStates = StatesIds.Connected;
            }
            if (State == StatesIds.Connecting)
            {
                Injector.connectBtn.Enabled = false;
                Injector.connectBtn.Text = "Connecting...";
                SetupTabs(Injector, false);
                Injector.GetStates = StatesIds.Connecting;
            }
        }

        public static void SetupTabs(MainForm Injector, bool enabled)
        {
            foreach (MetroFramework.Controls.MetroTabPage Page in Injector.MainTabs.TabPages)
            {
                if ((string)Page.Tag == "GeckoUNeeded")
                {
                    foreach (Control c in Page.Controls)
                    {
                        c.Enabled = enabled;
                    }
                }

                Injector.minigamesTab.Enabled = enabled;
            }
        }
    }
}
