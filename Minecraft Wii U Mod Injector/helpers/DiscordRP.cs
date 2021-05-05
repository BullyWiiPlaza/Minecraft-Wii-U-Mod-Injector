using DiscordRPC;
using System;

namespace Minecraft_Wii_U_Mod_Injector.helpers
{
    class DiscordRP
    {
        public static DiscordRpcClient client;

        public static void Initialize()
        {
            client = new DiscordRpcClient("839430556583854101");
            client.Initialize();
        }

        public static void SetPresence(string details, string state)
        {
            client.SetPresence(new RichPresence()
            {
                Details = details,
                State = state,
                Timestamps = new Timestamps() { Start = DateTime.UtcNow },
                Assets = new Assets()
                {
                    LargeImageKey = "icon_large",
                    LargeImageText = "Minecraft Wii U Mod Injector",
                }
            }); ;
        }

        public static void Deinitialize()
        {
            client.Dispose();
        }
    }
}
