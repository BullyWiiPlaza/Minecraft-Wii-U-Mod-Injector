using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U;

namespace Minecraft_Wii_U_Mod_Injector.Wii_U.Minecraft
{
    class MCVectorFunctions
    {
        private static void MemMove(uint dest, uint src, uint n)
        {
            MainForm.GeckoU.CallFunction(0x02AD54DC, dest, src, n);
        }

        public static void EraseVectorObject(uint vector_ptr, uint vector_position, uint sizeOfEachElement)
        {
            uint size = GetVectorSize(vector_ptr, sizeOfEachElement, out uint start, out uint end, out _);
            for (uint i = 0; i < size; i++)
            {
                uint pos = start + i * sizeOfEachElement;
                if (pos == vector_position) // found position
                {
                    MemMove(pos, pos + sizeOfEachElement, end - (pos + sizeOfEachElement));
                    end -= sizeOfEachElement;
                    MainForm.GeckoU.WriteUInt(vector_ptr + 8, end);
                    break;
                }
            }
            return;
        }

        public static uint GetVectorSize(uint vector_ptr, uint sizeOfElement, out uint start, out uint end, out uint max)
        {
            byte[] data = MainForm.GeckoU.ReadBytes(vector_ptr + 4, 12);
            if (data.Any())
            {
                start = ByteSwap.Swap(BitConverter.ToUInt32(data, 0));
                end = ByteSwap.Swap(BitConverter.ToUInt32(data, 4));
                max = ByteSwap.Swap(BitConverter.ToUInt32(data, 8)); // will be important when pack injection is stable
                return (end - start) / sizeOfElement;
            }
            start = end = max = 0;
            return 0;
        }
    }
}
