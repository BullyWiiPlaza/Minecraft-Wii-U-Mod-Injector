using System;

namespace Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U
{
    public static class ByteSwap
    {
        public static ushort Swap(ushort input)
        {
            if (BitConverter.IsLittleEndian)
            {
                return (ushort)(((0xFF00 & input) >> 8) | ((0x00FF & input) << 8));
            }

            return input;
        }

        public static uint Swap(uint input)
        {
            if (BitConverter.IsLittleEndian)
            {
                return ((0xFF000000 & input) >> 24) | ((0x00FF0000 & input) >> 8) | ((0x0000FF00 & input) << 8)
                       | ((0x000000FF & input) << 24);
            }

            return input;
        }

        public static ulong Swap(ulong input)
        {
            if (BitConverter.IsLittleEndian)
            {
                return ((0xFF00000000000000 & input) >> 56) | ((0x00FF000000000000 & input) >> 40)
                       | ((0x0000FF0000000000 & input) >> 24) | ((0x000000FF00000000 & input) >> 8)
                       | ((0x00000000FF000000 & input) << 8) | ((0x0000000000FF0000 & input) << 24)
                       | ((0x000000000000FF00 & input) << 40) | ((0x00000000000000FF & input) << 56);
            }

            return input;
        }
    }
}