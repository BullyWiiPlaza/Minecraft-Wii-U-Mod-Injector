using MetroFramework;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using Octokit;
using System;
using System.Threading.Tasks;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;
using Minecraft_Wii_U_Mod_Injector.Properties;
using Settings = Minecraft_Wii_U_Mod_Injector.Helpers.Files.Settings;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using Application = System.Windows.Forms.Application;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
{
    class Setup
    {
        public static MainForm Injector = new MainForm();

        public static string LocalVer = "v5.2.0";
        public static string GitVer = string.Empty;
        public static string UpdaterPath = $@"{Application.StartupPath}\Minecraft.Wii.U.Mod.Injector.Updater.exe";

        public static bool PreRelease;

        public Setup(MainForm window)
        {
            Injector = window;
        }

        public static async void SetupInjector()
        {
            try
            {
#if !DEBUG
                await RetrieveGitVersion();
#endif
#if DEBUG
                LocalVer = LocalVer + " (Debugging)";
#endif

                Injector.BuildNotesBox.Text = Resources.releaseNotes;
                Injector.BuildVerTitleLbl.Text = @"Patch Notes for " + LocalVer;
                Injector.BuildTile.Text = LocalVer;

                DiscordRp.Initialize();

                SetupUserPrefs();

                DiscordRp.SetPresence("Disconnected", "Idle");
                States.SwapState(States.StatesIds.Disconnected);
            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Failed to setup", true);
                DiscordRp.Deinitialize();
                Environment.Exit(0);
            }
        }

        public static async Task RetrieveGitVersion(bool auto = true)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //Fix for Windows 7 Systems
                var verChecker = new GitHubClient(new ProductHeaderValue("MCWiiUMIClient"));
                var releases = await verChecker.Repository.Release.GetAll("Kashiiera", "Minecraft-Wii-U-Mod-Injector");

                GitVer = releases[0].TagName;
                PreRelease = releases[0].Prerelease;

                if (LocalVer != GitVer)
                {
                    if (!PreRelease)
                    {
                        using (var wc = new WebClient())
                        {
                            wc.DownloadFile(
                                "https://github.com/vylryna/MCUModInjector-Updater/releases/latest/download/Minecraft.Wii.U.Mod.Injector.Updater.exe",
                                UpdaterPath);
                        }

                        Process.Start(UpdaterPath);
                        Application.Exit();
                    }
                    else if (Settings.EqualsTo("PrereleaseOptIn", "True", "Updates") && PreRelease)
                    {
                        using (var wc = new WebClient())
                        {
                            wc.DownloadFile(
                                "https://github.com/vylryna/MCUModInjector-Updater/releases/latest/download/Minecraft.Wii.U.Mod.Injector.Updater.exe",
                                UpdaterPath);
                        }

                        Process.Start(UpdaterPath);
                        Application.Exit();
                    }
                }
                else
                {
                    if (!auto)
                        Messaging.Show(MessageBoxIcon.Information,
                            "You are already running the latest version " + LocalVer);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                Exceptions.LogError(error,
                    "Something went wrong while retrieving the latest release, please try re-launching the Injector.\n" +
                    "If this issue persist please contact the developers.", true);
            }
        }

        public static void SetupUserPrefs()
        {
            try
            {
                try
                {
                    if (!Settings.Exists("FirstLaunch", "Display"))
                        Settings.Write("FirstLaunch", "True", "Display");

                    var firstLaunch = Convert.ToBoolean(Settings.Read("FirstLaunch", "Display"));

                    if (firstLaunch)
                        Messaging.Show(
                            "Welcome to the Minecraft: Wii U Mod Injector! the first and longest lasting Mod Injector for Minecraft: Wii U Edition!\n" +
                            "Before we get started, please take a look at the setup tutorial here: https://www.youtube.com/watch?v=be5fNSgxhrU. \n\nIf you appreciate all the work " +
                            "I've put into this software, a sub is appreciated. Happy modding!");

                    Settings.Write("FirstLaunch", "False", "Display");

                    Injector.Style = Injector.StyleMngr.Style =
                        (MetroColorStyle) Enum.Parse(typeof(MetroColorStyle), Settings.Read("Color", "Display"));

                    Injector.colorsBox.Text = Settings.Read("Color", "Display");

                    Injector.MainTabs.SelectedIndex = Convert.ToInt32(Settings.Read("TabIndex", "Display"));

                    Injector.CheckForPreRelease.Checked =
                        Convert.ToBoolean(Settings.Read("PrereleaseOptIn", "Updates"));

                    Injector.discordRpcCheckBox.Checked = Convert.ToBoolean(Settings.Read("DiscordRPC", "Discord"));
                }
                catch (Exception)
                {
                    //Failing to set User Preferences isn't a big deal, so we ignore the exception if one happens
                }

                if (Settings.EqualsTo("ReleaseNotes", "all", "Display"))
                {
                    Injector.releaseNotesToggle.Checked = false;
                    Injector.BuildNotesBox.Text = Resources.releaseNotes;
                }
                else if (Settings.EqualsTo("ReleaseNotes", "current", "Display"))
                {
                    Injector.releaseNotesToggle.Checked = true;
                    Injector.BuildNotesBox.Text = Resources.releaseNote;
                }
            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Exception in SetupUserPrefs()", true);
                Environment.Exit(0);
            }
        }
    }
}