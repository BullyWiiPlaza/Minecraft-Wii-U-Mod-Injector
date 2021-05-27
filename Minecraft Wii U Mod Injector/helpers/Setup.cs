using MetroFramework;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using System;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
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
                SetupUserPrefs();

                DiscordRP.Initialize();
                DiscordRP.SetPresence("Modding", "Idle");
                States.SwapState(States.StatesIds.Disconnected);
            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Failed to setup", Exceptions.ExceptionId.FailedtoSetup, false, true);
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

                    Injector.themeBox.Text = Configuration.ReadKey("StyleTheme", "Theming");
                    Injector.colorsBox.Text = Configuration.ReadKey("ColorTheme", "Theming");

                    if (Configuration.KeyEqualsTo("DiscordRPC", "true", "Discord"))
                        Injector.discordRpcCheckBox.Checked = true;
                    else
                        Injector.discordRpcCheckBox.Checked = false;
                }
                catch (Exception)
                {
                
                }
            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Exception in SetupUserPrefs() \n" + error, Exceptions.ExceptionId.FailedtoSetup, false, true);
                Environment.Exit(0);
            }
        }
    }
}