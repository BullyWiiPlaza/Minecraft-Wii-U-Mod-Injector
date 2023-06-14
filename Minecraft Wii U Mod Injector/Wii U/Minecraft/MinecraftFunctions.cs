using System;
using Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U;

namespace Minecraft_Wii_U_Mod_Injector.Wii_U.Minecraft
{
    internal class MinecraftFunctions
    {
        public static GeckoU GeckoU;

        public MinecraftFunctions(GeckoU geckoUCore)
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
        /// Gets the address of the current Minigame
        /// </summary>
        /// <returns>Level pointer</returns>
        public static uint GetMinigame()
        {
            return GeckoU.CallFunction(0x0318C878, GetMinecraft(), 0x0);
        }

        /// <summary>
        /// Gets the ID of the current Minigame
        /// </summary>
        /// <returns>Minigame ID</returns>
        public static uint GetMinigameId()
        {
            return GeckoU.CallFunction(0x0318C878, GetMinecraft(), 0x0);
        }

        /// <summary>
        /// Gets the address of the current MinecraftServer Pointer, returns 0 if not the host
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

        /// <summary>
        /// Pauses the server
        /// </summary>
        /// <param name="b">Whether to pause the server or not</param>
        public static void FjSetServerPaused(bool b)
        {
            GeckoU.CallFunction(0x03226298, GetMinecraftServer(), Convert.ToUInt32(b));
        }

        /// <summary>
        /// Retrieves whether the server is paused or not
        /// </summary>
        /// <returns>bool</returns>
        public static bool IsServerPaused()
        {
            uint test = GeckoU.PeekUInt(GetMinecraftServer() + 0x13C) << 4;
            return Convert.ToBoolean(test);
        }

        // TODO
        // Clear memory
        public static string GetPlayerSkinName(uint p_index)
        { 
            GeckoU.CallFunction(0x02F70154, 0x10120000, p_index);
            var skin_name = GeckoU.PeekString16(0x24, GeckoU.PeekUInt(0x10120014));

            return skin_name.Remove(skin_name.IndexOf(".png"));
        }

        public static string GetPlayerCapeName(uint p_index)
        {
            GeckoU.CallFunction(0x02F6FD3C, 0x10120000, p_index);
            var cape_name = GeckoU.PeekString16(0x24, GeckoU.PeekUInt(0x10120014));

            return cape_name.Remove(cape_name.IndexOf(".png"));
        }

        /// <summary>
        /// Retrieves the NQRNetworkManager pointer
        /// </summary>
        /// <returns>uint</returns>
        public static uint GetNQRNetworkManager_WiiU()
        {
            var _nqrNetworkManager = GeckoU.PeekUInt(GeckoU.PeekUInt(0x109C91E4) + 0x10);
            return _nqrNetworkManager;
        }

        /// <summary>
        /// Grabs the NQRNetworkPlayer_WiiU class pointer for the selected player
        /// </summary>
        /// <param name="p_index">Index of the player</param>
        /// <returns>Pointer to the specified player index</returns>
        public static uint GetNQRNetworkPlayer_WiiU(uint p_index)
        {
            var _nqrNetworkPlayer = GeckoU.CallFunction(0x0349CBB8, GetNQRNetworkManager_WiiU(), p_index);
            return _nqrNetworkPlayer;
        }

        /// <summary>
        /// Returns the name of the selected player
        /// </summary>
        /// <param name="p_index">The index of the player</param>
        /// <returns>Player name</returns>
        public static string GetPlayerNetworkName(uint p_index)
        {
            var _nqrNetworkPlayer = GetNQRNetworkPlayer_WiiU(p_index);
            var _nameAddress = GeckoU.CallFunction(0x03467024, _nqrNetworkPlayer) + 0x16;

            return GeckoU.PeekString16(0x22, _nameAddress);
        }

        /// <summary>
        /// Returns the name of the Mii of the selected player
        /// </summary>
        /// <param name="p_index">The index of the player</param>
        /// <returns>Mii Name</returns>
        public static string GetPlayerMiiName(uint p_index)
        {
            var _nqrNetworkPlayer = GetNQRNetworkPlayer_WiiU(p_index);
            var _miiNameAddress = GeckoU.CallFunction(0x0346701C, _nqrNetworkPlayer);

            return GeckoU.PeekString16(0x16, _miiNameAddress);
        }

        /// <summary>
        /// Returns the amount of players in the current session
        /// </summary>
        /// <returns>uint</returns>
        public static uint GetNQRNetworkManager_PlayerCount()
        {
            return GeckoU.CallFunction(0x0349C9E8, GetNQRNetworkManager_WiiU());
        }

        /// <summary>
        /// Returns the NQRNetworkPlayer of the host
        /// </summary>
        /// <returns>NQRNetworkPlayer Class Pointer</returns>
        public static uint GetNQRNetworkManager_GetHostPlayer()
        {
            return GeckoU.CallFunction(0x0349D670, GetNQRNetworkManager_WiiU());
        }

        /// <summary>
        /// Removes the selected player index from the current session
        /// </summary>
        /// <param name="p_index">The player index you wish to remove</param>
        public static void NQRNetworkManager_RemoveConnectedPlayer(uint p_index)
        {
            GeckoU.CallFunction(0x0348BDD8, GetNQRNetworkManager_WiiU(), GetNQRNetworkPlayer_WiiU(p_index));
        }
    }
}
