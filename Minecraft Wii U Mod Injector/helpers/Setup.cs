using MetroFramework;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using System;
using System.Drawing;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
{
    class Setup
    {
        public static MainForm Injector = new MainForm();

        public static string version = "v5.1.4";

        public Setup(MainForm window)
        {
            Injector = window;
        }

        public static void SetupInjector()
        {
            try
            {
                Injector.buildNotesBox.Text = Properties.Resources.releaseNotes;
                Injector.buildVerTitleLbl.Text = "Patch Notes for " + version;
                Injector.buildTile.Text = version;

                DiscordRP.Initialize();

                SetupUserPrefs();
                DebugCheck();

                DiscordRP.SetPresence("Disconnected", "Idle");
                States.SwapState(States.StatesIds.Disconnected);
            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Failed to setup", false, true);
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
                    Injector.Theme = Injector.StyleManager.Theme = (MetroThemeStyle)Enum.Parse(typeof(MetroThemeStyle), Settings.Read("Theme", "Display"));
                    Injector.Style = Injector.StyleManager.Style = (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), Settings.Read("Color", "Display"));

                    Injector.themeBox.Text = Settings.Read("Theme", "Display");
                    Injector.colorsBox.Text = Settings.Read("Color", "Display");

                    Injector.MainTabs.SelectedIndex = Convert.ToInt32(Settings.Read("TabIndex", "Display"));
                }
                catch (Exception)
                { }

                if (Settings.EqualsTo("DiscordRPC", "true", "Discord"))
                    Injector.discordRpcCheckBox.Checked = true;
                else
                    Injector.discordRpcCheckBox.Checked = false;
                

                if (Settings.EqualsTo("ReleaseNotes", "all", "Display"))
                {
                    Injector.releaseNotesToggle.Checked = false;
                    Injector.buildNotesBox.Text = Properties.Resources.releaseNotes;
                }
                else if (Settings.EqualsTo("ReleaseNotes", "current", "Display"))
                {
                    Injector.releaseNotesToggle.Checked = true;
                    Injector.buildNotesBox.Text = Properties.Resources.releaseNote;
                }

            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Exception in SetupUserPrefs()", false, true);
                Environment.Exit(0);
            }
        }

        public static void DebugCheck()
        {
            try
            {
                if (!Settings.Exists("debug", "Advanced") || Settings.EqualsTo("debug", "false", "Advanced"))
                {
                    Size tabSize = new(140, 1);
                    Size verSize = new(160, 147);
                    Point verLoc = new(0, 461);
                    Injector.debugTile.Visible = false;
                    Injector.MainTabs.HideTab(Injector.debugTab);
                    Injector.MainTabs.ItemSize = tabSize;
                    Injector.buildTile.Size = verSize;
                    Injector.buildTile.Location = verLoc;
                }
            }
            catch(Exception)
            { }
        }
    }
}