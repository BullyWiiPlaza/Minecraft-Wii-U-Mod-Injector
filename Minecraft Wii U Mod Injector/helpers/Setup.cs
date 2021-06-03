using MetroFramework;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using Minecraft_Wii_U_Mod_Injector.Helpers.Winforms;
using Octokit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
{
    class Setup
    {
        public static MainForm Injector = new MainForm();

        public static string LocalVer = "v5.1.5";
        public static string GitVer = string.Empty;
        public static bool PreRelease = false;

        public Setup(MainForm window)
        {
            Injector = window;
        }

        public static void SetupInjector()
        {
            try
            {
                RetrieveGitVersion();

                Injector.buildNotesBox.Text = Properties.Resources.releaseNotes;
                Injector.buildVerTitleLbl.Text = "Patch Notes for " + LocalVer;
                Injector.buildTile.Text = LocalVer;

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

        public static async Task RetrieveGitVersion()
        {
            try
            {
                GitHubClient VerChecker = new GitHubClient(new ProductHeaderValue("MCWiiUMIClient"));
                IReadOnlyList<Release> Releases = await VerChecker.Repository.Release.GetAll("Kashiiera", "Minecraft-Wii-U-Mod-Injector");

                GitVer = Releases[0].TagName;
                PreRelease = Releases[0].Prerelease;

                if (LocalVer != GitVer && !PreRelease)
                {
                    Messaging.Show("The current injector version " + LocalVer + " is outdated! Please download version " + GitVer + " at " +
                        "https://github.com/Kashiiera/Minecraft-Wii-U-Mod-Injector/releases \nas it may contain feature updates, bug fixes and more.");
                    Environment.Exit(0);
                }
                if (LocalVer != GitVer && Settings.EqualsTo("PrereleaseOptIn", "True", "Updates") && PreRelease)
                {
                    Messaging.Show("Thank you for being interested in testing pre-releases!\nThe current injector version " + LocalVer +
                        " is outdated! Please download version " + GitVer + " at " + "https://github.com/Kashiiera/Minecraft-Wii-U-Mod-Injector/releases \nas it may contain feature updates, bug fixes and more.");
                    Environment.Exit(0);
                }
            }
            catch (Exception Error)
            {
                Exceptions.LogError(Error, "Something went wrong while retrieving the latest release, please try re-launching the Injector.\n" +
                    "If this issue persist please contact the developers.", false, false);
            }
        }

        public static void SetupUserPrefs()
        {
            try
            {
                try
                {
                    Injector.Theme = Injector.StyleMngr.Theme = (MetroThemeStyle)Enum.Parse(typeof(MetroThemeStyle), Settings.Read("Theme", "Display"));
                    Injector.Style = Injector.StyleMngr.Style = (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), Settings.Read("Color", "Display"));

                    Injector.themeBox.Text = Settings.Read("Theme", "Display");
                    Injector.colorsBox.Text = Settings.Read("Color", "Display");

                    Injector.MainTabs.SelectedIndex = Convert.ToInt32(Settings.Read("TabIndex", "Display"));

                    Injector.CheckForPreRelease.Checked = Convert.ToBoolean(Settings.Read("PrereleaseOptIn", "Updates"));
                    Injector.discordRpcCheckBox.Checked = Convert.ToBoolean(Settings.Read("DiscordRPC", "Discord"));
                }
                catch (Exception)
                { }
                
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