using Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U;

namespace Minecraft_Wii_U_Mod_Injector.Wii_U.Minecraft
{
    internal class MinecraftFunctions
    {
        public static GeckoUCore GeckoU;

        public MinecraftFunctions(GeckoUCore geckoUCore)
        {
            GeckoU = geckoUCore;
        }

        public static uint GetMinecraft()
        {
            return GeckoU.CallFunction(0x03166818, 0x0);
        }

        public static uint GetClientMasterGameMode()
        {
            return GeckoU.CallFunction(0x0318D01C, GetMinecraft(), 0x0);
        }

        public static uint GetLevel()
        {
            return GeckoU.CallFunction(0x0318C878, GetMinecraft(), 0x0);
        }

        public static uint GetMinecraftServer()
        {
            return GeckoU.PeekUInt(0x109CD8FC);
        }
    }
}
