using System;
using System.Linq;
using Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U;

namespace Minecraft_Wii_U_Mod_Injector.Wii_U.Minecraft
{
    class MCVectorFunctions
    {
        private static void MemMove(uint dest, uint src, uint n)
        {
            MainForm.GeckoU.CallFunction(0x02AD54DC, dest, src, n);
        }

        public static void EraseVectorObject(uint vector_ptr, uint vector_position, uint sizeOfElement)
        {
            int size = GetVectorSize(vector_ptr, sizeOfElement, out uint start, out uint end, out _);
            for (uint i = 0; i < size; i++)
            {
                uint pos = start + i * sizeOfElement;
                if (pos == vector_position) // found position
                {
                    MemMove(pos, pos + sizeOfElement, end - (pos + sizeOfElement));
                    end -= sizeOfElement;
                    MainForm.GeckoU.WriteUInt(vector_ptr + 8, end);
                    break;
                }
            }
            return;
        }

        public static bool AppendVectorObject(uint vector_ptr,uint sizeOfElement, byte[] Object)
        {
            uint start, end, max;
            int count = GetVectorSize(vector_ptr, sizeOfElement, out start, out end, out max);
            int maxCount = (int)((max - start) / sizeOfElement);
            if (maxCount == count) return false;

            MainForm.GeckoU.WriteBytes(end, Object);
            MainForm.GeckoU.WriteUInt(end, end + sizeOfElement);
            return true;
        }

        public static int GetVectorSize(uint vector_ptr, uint sizeOfElement, out uint start, out uint end, out uint max)
        {
            byte[] data = MainForm.GeckoU.ReadBytes(vector_ptr + 4, 12);
            if (data.Any())
            {
                start = ByteSwap.Swap(BitConverter.ToUInt32(data, 0));
                end = ByteSwap.Swap(BitConverter.ToUInt32(data, 4));
                max = ByteSwap.Swap(BitConverter.ToUInt32(data, 8));
                return (int)((end - start) / sizeOfElement);
            }
            start = end = max = 0;
            return 0;
        }
        public static int GetMaxVectorSize(uint vector_ptr, uint sizeOfElement)
        {
            uint start, max;
            GetVectorSize(vector_ptr, sizeOfElement, out start, out _, out max);
            return (int)((max - start) / sizeOfElement);
        }
    }
}
