using Octokit;
using System;
using System.Threading.Tasks;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;
using Minecraft_Wii_U_Mod_Injector.Properties;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using Application = System.Windows.Forms.Application;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
{
    internal class Setup
    {
        public static MainForm Injector = new();

        public static string LocalVer = "1.533.00";
        public static string GitVer = string.Empty;
        public static string UpdaterPath = $@"{Application.StartupPath}\Minecraft.Wii.U.Mod.Injector.Updater.exe";

        public static bool PreRelease;

        public Setup(MainForm window)
        {
            Injector = window;
        }

        public static void SetupInjector()
        {
            try
            {
#if !DEBUG
                // Uncomment this when auto updater is fixed
                //await RetrieveGitVersion();
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

                DiscordRpc.Initialize();

                SetupUserPrefs();

                DiscordRpc.SetPresence("Disconnected", "Idle");
                States.SwapState(States.StatesIds.Disconnected);

                // Setup is finished, we can show the window now
                Injector.Opacity = 100;
            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Failed to setup", true);
                DiscordRpc.Deinitialize();
                Environment.Exit(0);
            }
        }

        public static async Task RetrieveGitVersion(bool auto = true)
        {
            try
            {
                // Fix for Windows 7 Systems
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var verChecker = new GitHubClient(new ProductHeaderValue("MinecraftWiiUModInjector"));
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
                        Messaging.Show(MessageBoxIcon.Information, "You are already running the latest version: " + LocalVer);
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
                    Injector.MainTabs.SelectedIndex = Settings.Default.TabIndex;
                    Injector.CheckForPreRelease.Checked = Settings.Default.PrereleaseOptIn;
                    Injector.discordRpcCheckBox.Checked = Settings.Default.DiscordRPC;

                    if(!Settings.Default.DiscordRPC)
                        DiscordRpc.Deinitialize();

                    Injector.HostIndicators.Checked = Settings.Default.HostIndicators;

                    // TODO Implement new language switcher logic here.. once there are languages setup
                }
                catch (Exception)
                {
                    //Failing to set User Preferences isn't a big deal, so we ignore the exception if one happens
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