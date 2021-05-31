using DiscordRPC;
using System;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
{
    class DiscordRP
    {
        public static DiscordRpcClient client;
        public static DateTime startUpTime = DateTime.UtcNow;

        public static void Initialize()
        {
            client = new DiscordRpcClient("839430556583854101");
            client.Initialize();         
        }

        public static void SetPresence(string details, string state)
        {
            if (Files.Configuration.ReadKey("DiscordRPC", "Discord") == "true" || !Files.Configuration.KeyExists("DiscordRPC", "Discord"))
            {
                client.SetPresence(new RichPresence()
                {
                    Details = Setup.version + " - " + details,
                    State = state,
                    Timestamps = new Timestamps() { Start = startUpTime },
                    Assets = new Assets()
                    {
                        LargeImageKey = "icon_large",
                        LargeImageText = "Minecraft Wii U Mod Injector",
                    }
                }); ;
            }
            else
                return;
        }

        public static void Deinitialize()
        {
            if(client != null)
                client.Dispose();

            client = null;
        }
    }
}
