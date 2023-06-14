using DiscordRPC;
using System;
using System.Diagnostics;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
{
    internal class DiscordRpc
    {
        public static DiscordRpcClient Client;
        public static DateTime StartUpTime = DateTime.UtcNow;

        public static void Initialize()
        {
            Client = new DiscordRpcClient("839430556583854101");
            Client.Initialize();

            Debug.WriteLine(@"Setting Initialized", "DiscordRpc");
        }

        public static void SetPresence(string details, string state)
        {
            Client?.SetPresence(new RichPresence()
            {
                Details = Setup.LocalVer + " - " + details,
                State = state,
                Timestamps = new Timestamps() { Start = StartUpTime },
                Assets = new Assets()
                {
                    LargeImageKey = "icon_large",
                    LargeImageText = "Minecraft Wii U Mod Injector",
                }
            });
            Debug.WriteLine(@"Setting Presence Details: " + details + @" State: " + state, "DiscordRpc");
        }

        public static void Deinitialize()
        {
            Client?.Dispose();
            Client = null;

            Debug.WriteLine(@"Disposing", "DiscordRpc");
        }
    }
}
