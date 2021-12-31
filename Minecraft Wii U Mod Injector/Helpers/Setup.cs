using Octokit;
using System;
using System.Threading.Tasks;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;
using Minecraft_Wii_U_Mod_Injector.Properties;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using MetroFramework;
using MetroFramework.Controls;
using Minecraft_Wii_U_Mod_Injector.Forms.Managers;
using Application = System.Windows.Forms.Application;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
{
    class Setup
    {
        public static MainForm Injector = new();

        public static string LocalVer = "v5.3.0.q8.1";
        public static string GitVer = string.Empty;
        public static string UpdaterPath = $@"{Application.StartupPath}\Minecraft.Wii.U.Mod.Injector.Updater.exe";

        public static bool PreRelease;

        public Setup(MainForm window)
        {
            Injector = window;
        }

        public async static void SetupInjector()
        {
            try
            {
#if !DEBUG
                await RetrieveGitVersion();
#endif
#if DEBUG
                LocalVer += " (Dev)";
#endif

                if (Settings.Default.UpdateSettings)
                {
                    Settings.Default.Upgrade();
                    Settings.Default.UpdateSettings = false;
                    Settings.Default.Save();
                }

                DiscordRp.Initialize();

                SetupUserPrefs();

                DiscordRp.SetPresence("Disconnected", "Idle");
                States.SwapState(States.StatesIds.Disconnected);

                Injector.Opacity = 100; // Everything has finished setting up, we can show the form now
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
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // Fix for Windows 7 Systems
                var verChecker = new GitHubClient(new ProductHeaderValue("MCWiiUMIClient"));
                var releases = await verChecker.Repository.Release.GetAll(ApplicationUrls.GitHubProfileName, "Minecraft-Wii-U-Mod-Injector");

                GitVer = releases[0].TagName;
                PreRelease = releases[0].Prerelease;

                if (LocalVer != GitVer)
                {
                    if (!PreRelease)
                    {
                        using (var wc = new WebClient())
                        {
                            wc.DownloadFile(ApplicationUrls.InjectorUpdaterUrl, UpdaterPath);
                        }

                        Process.Start(UpdaterPath);
                        Environment.Exit(0);
                    }
                    else if (Settings.Default.PrereleaseOptIn && PreRelease)
                    {
                        using (var wc = new WebClient())
                        {
                            wc.DownloadFile(ApplicationUrls.InjectorUpdaterUrl, UpdaterPath);
                        }

                        Process.Start(UpdaterPath, GitVer);
                        Environment.Exit(0);
                    }
                }
                else
                {
                    if (!auto)
                    {
                        Messaging.Show(MessageBoxIcon.Information, "You are already running the latest version " + LocalVer);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                Exceptions.LogError(error,
                    "Something went wrong while retrieving the latest release, this may be because you have no active internet connection\nor Github servers" +
                    " are down. Please try re-launching the mod injector later and if the issue persists, contact the developers.\nThank you.", true);
                Environment.Exit(0);
            }
        }

        public static void SetupUserPrefs()
        {
            try
            {
                try
                {
                    Injector.Style = Injector.StyleMngr.Style = Settings.Default.Style;
                    Injector.ColorsBox.Text = Settings.Default.Style.ToString();
                    Injector.TextAlign = Settings.Default.FormTxtAlign;
                    Injector.TextAllignBox.Text = Settings.Default.FormTxtAlign.ToString();
                    Injector.MainTabs.SelectedIndex = Settings.Default.TabIndex;
                    Injector.CheckForPreRelease.Checked = Settings.Default.PrereleaseOptIn;
                    Injector.discordRpcCheckBox.Checked = Settings.Default.DiscordRPC;

                    if(!Settings.Default.DiscordRPC)
                        DiscordRp.Deinitialize();

                    Injector.HostIndicators.Checked = Settings.Default.HostIndicators;
                    Injector.SeasonalThemes.Checked = Settings.Default.SeasonalThemes;

                    if(Settings.Default.Language != "Default")
                    {
                        foreach (MetroTabPage page in Injector.MainTabs.TabPages)
                            LanguageMngr.ApplyLanguage(page.Controls, Settings.Default.Language);
                        foreach (MetroTabPage page in Injector.MinigamesTabs.TabPages)
                            LanguageMngr.ApplyLanguage(page.Controls, Settings.Default.Language);
                    }

                    if (Settings.Default.SeasonalThemes)
                    {
                        if (DateTime.Now.ToString("MM") == "10") //Halloween
                        {
                            Injector.Style = Injector.StyleMngr.Style = MetroColorStyle.Orange;
                            Injector.BuildTile.Text = LocalVer + @"
Halloween Edition";
                            Injector.ColorsBox.Enabled = false;
                            Injector.Refresh();
                        }

                        if (DateTime.Now.ToString("MM") == "12") //Christmas TODO: Make this way better, looks kind of ugly?
                        {
                            Injector.Style = MetroColorStyle.Red;
                            Injector.StyleMngr.Style = MetroColorStyle.Green;
                            Injector.BuildTile.Text = LocalVer + @"
Christmas Edition";
                            Injector.ColorsBox.Enabled = false;
                            Injector.Refresh();
                        }
                    }
                }
                catch (Exception)
                {
                    //Failing to set User Preferences isn't a big deal, so we ignore the exception if one happens
                }

                if (Settings.Default.ReleaseNotes == "Current")
                {
                    Injector.releaseNotesToggle.Checked = true;
                    Injector.BuildNotesBox.Text = Resources.releaseNote;
                }
                else
                {
                    Injector.releaseNotesToggle.Checked = false;
                    Injector.BuildNotesBox.Text = Resources.releaseNotes;
                }

                Miscellaneous.DoHostIndicators(Settings.Default.HostIndicators);
            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Exception in SetupUserPrefs()", true);
                Environment.Exit(0);
            }
        }
    }
}