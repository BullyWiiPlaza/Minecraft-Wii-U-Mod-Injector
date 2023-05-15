using DiscordRPC;
using System;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
{
    class DiscordRP
    {
        public static DiscordRpcClient Client;
        public static DateTime StartUpTime = DateTime.UtcNow;

        public static void Initialize()
        {
            Client = new DiscordRpcClient("839430556583854101");
            Client.Initialize();
#if DEBUG
            Console.WriteLine(@"DISCORD RPC: Setting Initialized");
#endif
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
#if DEBUG
            Console.WriteLine(@"DISCORD RPC: Setting Presence Details: " + details + @" State: " + state);
#endif
        }

        public static void Deinitialize()
        {
            Client?.Dispose();
            Client = null;
#if DEBUG
            Console.WriteLine(@"DISCORD RPC: Disposing");
#endif
        }
    }
}
