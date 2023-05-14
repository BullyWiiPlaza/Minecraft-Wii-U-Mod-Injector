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

        /// <summary>
        /// Gets the address of the current Minecraft pointer
        /// </summary>
        /// <returns>Mincraft Pointer</returns>
        public static uint GetMinecraft()
        {
            return GeckoU.CallFunction(0x03166818, 0x0);
        }

        /// <summary>
        /// Gets the address of the current ClientMasterGameMode pointer
        /// </summary>
        /// <returns>ClientMasterGameMode Pointer</returns>
        public static uint GetClientMasterGameMode()
        {
            return GeckoU.CallFunction(0x0318D01C, GetMinecraft(), 0x0);
        }

        /// <summary>
        /// Gets the address of the current Level pointer
        /// </summary>
        /// <returns>Level pointer</returns>
        public static uint GetLevel()
        {
            return GeckoU.CallFunction(0x0318C878, GetMinecraft(), 0x0);
        }

        /// <summary>
        /// Gets the address of the current MinecraftServer Pointer
        /// </summary>
        /// <returns>MincraftServer Pointer</returns>
        public static uint GetMinecraftServer()
        {
            return GeckoU.PeekUInt(0x109CD8FC);
        }

        /// <summary>
        /// Is the current session client side?
        /// </summary>
        /// <returns>boolean</returns>
        public static bool IsClientSide()
        {
            return GeckoU.PeekUInt(0x109CD8FC) == 0x01;
        }
    }
}
