using System;
using System.IO;

namespace com.slothwiiplaza.geckou
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
            startAddress = theStartAddress;
            endAddress = theEndAddress;
            readCompletedAddress = theStartAddress;
            mem = new Byte[endAddress - startAddress];
            fileNumber = theFileNumber;
        }


        public UInt32 ReadAddress32(UInt32 addressToRead)
        {
            //dumpStream.Seek(addressToRead - startAddress, SeekOrigin.Begin);
            //byte [] buffer = new byte[4];

            //dumpStream.Read(buffer, 0, 4);
            if (addressToRead < startAddress) return 0;
            if (addressToRead > endAddress - 4) return 0;
            Byte[] buffer = new Byte[4];
            Buffer.BlockCopy(mem, index(addressToRead), buffer, 0, 4);
            //GeckoApp.SubArray<byte> buffer = new GeckoApp.SubArray<byte>(mem, (int)(addressToRead - startAddress), 4);

            //Read buffer
            UInt32 result = BitConverter.ToUInt32(buffer, 0);

            //Swap to machine endianness and return
            return ByteSwap.Swap(result);
        }

        private int index(UInt32 addressToRead)
        {
            return (int)(addressToRead - startAddress);
        }

        public UInt32 ReadAddress(UInt32 addressToRead, int numBytes)
        {
            if (addressToRead < startAddress) return 0;
            if (addressToRead > endAddress - numBytes) return 0;

            Byte[] buffer = new Byte[4];
            Buffer.BlockCopy(mem, index(addressToRead), buffer, 0, numBytes);

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
            string myFile = myDirectory + "dump" + fileNumber.ToString() + ".dmp";

            WriteStreamToDisk(myFile);
        }

        public void WriteStreamToDisk(string filepath)
        {
            FileStream foo = new FileStream(filepath, FileMode.Create);
            foo.Write(mem, 0, (int)(endAddress - startAddress));
            foo.Close();
            foo.Dispose();
        }

        /*public void WriteCompressedStreamToDisk(string filepath)
         {
             ZipFile foo = new ZipFile(filepath);
             foo.AddEntry("mem", mem);
             foo.Dispose();
         }*/

        public Byte[] mem;
        private UInt32 startAddress;
        public UInt32 StartAddress
        {
            get { return startAddress; }
        }
        private UInt32 endAddress;
        public UInt32 EndAddress
        {
            get { return endAddress; }
        }
        private UInt32 readCompletedAddress;
        public UInt32 ReadCompletedAddress
        {
            get { return readCompletedAddress; }
            set { readCompletedAddress = value; }
        }
        private int fileNumber;
    }
}
