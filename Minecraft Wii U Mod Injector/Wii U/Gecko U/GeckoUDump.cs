using System;
using System.IO;

namespace Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U
{
    /// <summary>
    /// Add for sake of completness
    /// </summary>
    public class GeckoUDump
    {
        public GeckoUDump(UInt32 theStartAddress, UInt32 theEndAddress)
        {
            Construct(theStartAddress, theEndAddress, 0);
        }

        public GeckoUDump(UInt32 theStartAddress, UInt32 theEndAddress, int theFileNumber)
        {
            Construct(theStartAddress, theEndAddress, theFileNumber);
        }

        private void Construct(UInt32 theStartAddress, UInt32 theEndAddress, int theFileNumber)
        {
            _startAddress = theStartAddress;
            _endAddress = theEndAddress;
            _readCompletedAddress = theStartAddress;
            Mem = new Byte[_endAddress - _startAddress];
            _fileNumber = theFileNumber;
        }


        public UInt32 ReadAddress32(UInt32 addressToRead)
        {
            //dumpStream.Seek(addressToRead - startAddress, SeekOrigin.Begin);
            //byte [] buffer = new byte[4];

            //dumpStream.Read(buffer, 0, 4);
            if (addressToRead < _startAddress) return 0;
            if (addressToRead > _endAddress - 4) return 0;
            Byte[] buffer = new Byte[4];
            Buffer.BlockCopy(Mem, Index(addressToRead), buffer, 0, 4);
            //GeckoApp.SubArray<byte> buffer = new GeckoApp.SubArray<byte>(mem, (int)(addressToRead - startAddress), 4);

            //Read buffer
            UInt32 result = BitConverter.ToUInt32(buffer, 0);

            //Swap to machine endianness and return
            return ByteSwap.Swap(result);
        }

        private int Index(UInt32 addressToRead)
        {
            return (int)(addressToRead - _startAddress);
        }

        public UInt32 ReadAddress(UInt32 addressToRead, int numBytes)
        {
            if (addressToRead < _startAddress) return 0;
            if (addressToRead > _endAddress - numBytes) return 0;

            Byte[] buffer = new Byte[4];
            Buffer.BlockCopy(Mem, Index(addressToRead), buffer, 0, numBytes);

            //Read buffer
            switch (numBytes)
            {
                case 4:
                    UInt32 result = BitConverter.ToUInt32(buffer, 0);

                    //Swap to machine endianness and return
                    return ByteSwap.Swap(result);

                case 2:
                    UInt16 result16 = BitConverter.ToUInt16(buffer, 0);

                    //Swap to machine endianness and return
                    return ByteSwap.Swap(result16);

                default:
                    return buffer[0];
            }
        }

        public void WriteStreamToDisk()
        {
            string myDirectory = Environment.CurrentDirectory + @"\searchdumps\";
            if (!Directory.Exists(myDirectory))
            {
                Directory.CreateDirectory(myDirectory);
            }
            string myFile = myDirectory + "dump" + _fileNumber.ToString() + ".dmp";

            WriteStreamToDisk(myFile);
        }

        public void WriteStreamToDisk(string filepath)
        {
            FileStream foo = new FileStream(filepath, FileMode.Create);
            foo.Write(Mem, 0, (int)(_endAddress - _startAddress));
            foo.Close();
            foo.Dispose();
        }

        /*public void WriteCompressedStreamToDisk(string filepath)
         {
             ZipFile foo = new ZipFile(filepath);
             foo.AddEntry("mem", mem);
             foo.Dispose();
         }*/

        public Byte[] Mem;
        private UInt32 _startAddress;
        public UInt32 StartAddress
        {
            get { return _startAddress; }
        }
        private UInt32 _endAddress;
        public UInt32 EndAddress
        {
            get { return _endAddress; }
        }
        private UInt32 _readCompletedAddress;
        public UInt32 ReadCompletedAddress
        {
            get { return _readCompletedAddress; }
            set { _readCompletedAddress = value; }
        }
        private int _fileNumber;
    }
}
