namespace Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U
{
    public enum AddressType
    {
        Rw,
        Ro,
        Ex,
        Unknown
    }

    public static class ValidMemory
    {
        private const bool CmdAddressDebug = false;

        private static readonly AddressRange[] ValidAreas =
        {
            new AddressRange(AddressType.Ex, 0x01000000, 0x01800000),
            new AddressRange(AddressType.Ex, 0x0e300000, 0x10000000),
            new AddressRange(AddressType.Rw, 0x10000000, 0x50000000),
            new AddressRange(AddressType.Ro, 0xe0000000, 0xe4000000),
            new AddressRange(AddressType.Ro, 0xe8000000, 0xea000000),
            new AddressRange(AddressType.Ro, 0xf4000000, 0xf6000000),
            new AddressRange(AddressType.Ro, 0xf6000000, 0xf6800000),
            new AddressRange(AddressType.Ro, 0xf8000000, 0xfb000000),
            new AddressRange(AddressType.Ro, 0xfb000000, 0xfb800000),
            new AddressRange(AddressType.Rw, 0xfffe0000, 0xffffffff)
        };

        public static AddressType RangeCheck(uint address)
        {
            var id = RangeCheckId(address);
            return id == -1 ? AddressType.Unknown : ValidAreas[id].Description;
        }

        private static int RangeCheckId(uint address)
        {
            for (var i = 0; i < ValidAreas.Length; i++)
            {
                var range = ValidAreas[i];
                if (address >= range.Low && address < range.High)
                {
                    return i;
                }
            }

            return -1;
        }

        private static bool ValidAddress(uint address, bool debug)
        {
            if (debug)
            {
                return true;
            }

            return RangeCheckId(address) >= 0;
        }

        public static bool ValidAddress(uint address)
        {
            return ValidAddress(address, CmdAddressDebug);
        }

        private static bool ValidRange(uint low, uint high, bool debug)
        {
            if (debug)
            {
                return true;
            }

            return RangeCheckId(low) == RangeCheckId(high - 1);
        }

        public static bool ValidRange(uint low, uint high)
        {
            return ValidRange(low, high, CmdAddressDebug);
        }
    }

    public class AddressRange
    {
        private AddressRange(AddressType desc, byte id, uint low, uint high)
        {
            Id = id;
            Description = desc;
            Low = low;
            High = high;
        }

        public AddressRange(AddressType desc, uint low, uint high)
            : this(desc, (byte)(low >> 24), low, high)
        {
        }

        public AddressType Description { get; private set; }

        private byte Id { get; set; }

        public uint Low { get; private set; }

        public uint High { get; private set; }
    }
}