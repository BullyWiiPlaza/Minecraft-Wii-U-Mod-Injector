using MetroFramework;
using Minecraft_Wii_U_Mod_Injector.helpers.files;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector.helpers
{
    class Setup
    {
        public static MainForm Injector = new MainForm();

        public Setup(MainForm window)
        {
            Injector = window;
        }

        public static void SetupInjector()
        {
            try
            {
                // https://stackoverflow.com/a/2904963/3764804
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                Security.StartRAMEditingToolsSearch();
                DiscordRP.Initialize();
                SetupUserPrefs();

                DiscordRP.SetPresence("Modding", "Idle");
                States.SwapState(States.StatesIds.Disconnected);
            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Failed to setup", Exceptions.ExceptionId.FailedtoSetup);
                DiscordRP.Deinitialize();
                Environment.Exit(0);
            }
        }

        public static void SetupUserPrefs()
        {
            try
            {
                try
                {
                    Injector.Theme = Injector.StyleManager.Theme = (MetroThemeStyle) Enum.Parse(typeof(MetroThemeStyle),
                        Configuration.ReadKey("StyleTheme", "Theming"));
                    Injector.Style = Injector.StyleManager.Style = (MetroColorStyle) Enum.Parse(typeof(MetroColorStyle),
                        Configuration.ReadKey("ColorTheme", "Theming"));
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Exception in SetupUserPrefs() \n" + error,
                    Exceptions.ExceptionId.FailedtoSetup);
                Environment.Exit(0);
            }
        }
    }
}