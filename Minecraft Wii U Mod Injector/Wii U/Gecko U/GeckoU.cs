using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U {
    public class GeckoUCore {
        #region base vars

        public GeckoUConnect Tcp;

        private const int CmdDefaultPort = 7331;
        private const uint CmdMaximumMemoryChunkSize = 0x400;

        public enum FtdiCommand {
            CmdResultError,
            CmdFatalError,
            CmdOk
        }

        #endregion base vars

        #region init
        /// <summary>
        /// Initialize the GeckoUConnection Class
        /// </summary>
        /// <param name="host">Wii U IP Address</param>
        public GeckoUCore(string host) {
            Tcp = new GeckoUConnect(host, CmdDefaultPort);
        }

        #endregion connection

        #region the magic
        protected FtdiCommand GeckoURead(byte[] recbyte, uint nobytes) {
            uint bytesRead;

            try {
                Tcp.Read(recbyte, nobytes, out bytesRead);
            } catch (IOException) {
                Tcp.Close();
                return FtdiCommand.CmdFatalError;
            }

            return bytesRead != nobytes ? FtdiCommand.CmdResultError : FtdiCommand.CmdOk;
        }

        protected FtdiCommand GeckoUWrite(byte[] sendbyte, int nobytes) {
            uint bytesWritten;

            try {
                Tcp.Write(sendbyte, nobytes, out bytesWritten);
            } catch (IOException) {
                Tcp.Close();
                return FtdiCommand.CmdFatalError;
            }

            return bytesWritten != nobytes ? FtdiCommand.CmdResultError : FtdiCommand.CmdOk;
        }

        /// <summary>
        /// Send a Raw Command to the Wii U
        /// </summary>
        /// <param name="id">The raw command id</param>
        /// <returns>FTDICommand</returns>
        public FtdiCommand RawCommand(byte id) {
            return GeckoUWrite(BitConverter.GetBytes(id), 1);
        }

        /// <summary>
        /// Sends a command to the Wii U
        /// </summary>
        /// <param name="command">Command to send</param>
        private void SendCommand(GeckoUCommands.Command command) {
            Tcp.Write(new[] { (byte)command }, 1, out _);
        }

        /// <summary>
        /// Read bytes from the Wii U
        /// </summary>
        /// <param name="address">Address to read</param>
        /// <param name="length">Length of the bytes</param>
        /// <returns></returns>
        public byte[] ReadBytes(uint address, uint length) {
            try {
                RequestBytes(address, length);

                var response = new byte[1];
                Tcp.Read(response, 1, out _);

                var ms = new MemoryStream();

                if (response[0] == 0xB0) {
                    return ms.ToArray();
                }

                var remainingBytesCount = length;
                while (remainingBytesCount > 0) {
                    var chunkSize = remainingBytesCount;

                    if (chunkSize > CmdMaximumMemoryChunkSize) {
                        chunkSize = CmdMaximumMemoryChunkSize;
                    }

                    var buffer = new byte[chunkSize];
                    Tcp.Read(buffer, chunkSize, out _);

                    ms.Write(buffer, 0, (int)chunkSize);

                    remainingBytesCount -= chunkSize;
                }

                return ms.ToArray();
            } catch (Exception) {
                // ignored
            }

            return null;
        }

        /// <summary>
        /// Reads memory (bytes) from the Wii U
        /// </summary>
        /// <param name="address">Address to read</param>
        /// <param name="length">Length of the bytes</param>
        private void RequestBytes(uint address, uint length) {
            try {
                SendCommand(GeckoUCommands.Command.CommandReadMemory);

                var bytes = BitConverter.GetBytes(ByteSwap.Swap(address));
                var bytes2 = BitConverter.GetBytes(ByteSwap.Swap(address + length));
                Tcp.Write(bytes, 4, out _);
                Tcp.Write(bytes2, 4, out _);
            } catch (Exception) {
                // ignored
            }
        }

        /// <summary>
        /// Upload Bytes to the Wii U
        /// </summary>
        /// <param name="address">Address to read</param>
        /// <param name="bytes">Bytes to write</param>
        /// <returns></returns>
        public uint UploadBytes(uint address, byte[] bytes) {
            var length = bytes.Length;

            var endAddress = address + (uint)bytes.Length;
            Tcp.Write(bytes, length, out _);

            return endAddress;
        }

        /// <summary>
        /// Write paritioned bytes to the Wii U
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="byteChunks">Partitioned Bytes to write</param>
        private void WritePartitionedBytes(uint address, IEnumerable<byte[]> byteChunks) {
            IEnumerable<byte[]> enumerable = byteChunks as IList<byte[]> ?? byteChunks.ToList();
            var length = (uint)enumerable.Sum(chunk => chunk.Length);

            try {
                SendCommand(GeckoUCommands.Command.CommandUploadMemory);

                var start = BitConverter.GetBytes(ByteSwap.Swap(address));
                var end = BitConverter.GetBytes(ByteSwap.Swap(address + length));

                Tcp.Write(start, 4, out _);
                Tcp.Write(end, 4, out _);

                enumerable.Aggregate(address, UploadBytes);
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        /// <summary>
        /// Paritition the given bytes
        /// </summary>
        /// <param name="bytes">Bytes to partition</param>
        /// <param name="chunkSize">Size of the chunk</param>
        /// <returns></returns>
        private static IEnumerable<byte[]> Partition(byte[] bytes, uint chunkSize) {
            var byteArrayChunks = new List<byte[]>();
            uint startingIndex = 0;

            while (startingIndex < bytes.Length) {
                var end = Math.Min(bytes.Length, startingIndex + chunkSize);
                byteArrayChunks.Add(CopyOfRange(bytes, startingIndex, end));
                startingIndex += chunkSize;
            }

            return byteArrayChunks;
        }

        /// <summary>
        /// Copy a range of bytes
        /// </summary>
        /// <param name="src">The bytes to copy from</param>
        /// <param name="start">Start of the range</param>
        /// <param name="end">End of the range</param>
        /// <returns>Bytes</returns>
        private static byte[] CopyOfRange(byte[] src, long start, long end) {
            var len = end - start;
            var dest = new byte[len];
            Array.Copy(src, start, dest, 0, len);
            return dest;
        }

        /// <summary>
        /// Write bytes the specified address
        /// </summary>
        /// <param name="address">Address to write</param>
        /// <param name="bytes">Bytes to write</param>
        public void WriteBytes(uint address, byte[] bytes) // Write bytes to the specified memory address
        {
            var partitionedBytes = Partition(bytes, CmdMaximumMemoryChunkSize);
            WritePartitionedBytes(address, partitionedBytes);
        }
        #endregion the magic

        #region rpc
        /// <summary>
        /// Call a function from an RPL/RPX
        /// </summary>
        /// <param name="address">The function address to call</param>
        /// <param name="args">The arguements to pass through</param>
        /// <returns>uint</returns>
        public uint CallFunction(uint address, params uint[] args) {
            return (uint)(CallFunction64(address, args) >> 32);
        }

        /// <summary>
        /// Call a function from an RPL/RPX
        /// </summary>
        /// <param name="address">The function address to call</param>
        /// <param name="args">The arguements to pass through</param>
        /// <returns>UInt64</returns>
        public ulong CallFunction64(uint address, params uint[] args) {
            var buffer = new byte[4 + 8 * 4];

            address = ByteSwap.Swap(address);

            BitConverter.GetBytes(address).CopyTo(buffer, 0);

            for (var i = 0; i < 8; i++) {
                if (i < args.Length) {
                    BitConverter.GetBytes(ByteSwap.Swap(args[i])).CopyTo(buffer, 4 + i * 4);
                } else {
                    BitConverter.GetBytes(0xfecad0ba).CopyTo(buffer, 4 + i * 4);
                }
            }

            if (RawCommand(GeckoUCommands.Rpc) != FtdiCommand.CmdOk)
                throw new GeckoUException(GeckoUException.EtcpErrorCode.FtdiCommandSendError);

            if (GeckoUWrite(buffer, buffer.Length) != FtdiCommand.CmdOk)
                throw new GeckoUException(GeckoUException.EtcpErrorCode.FtdiCommandSendError);

            if (GeckoURead(buffer, 8) != FtdiCommand.CmdOk)
                throw new GeckoUException(GeckoUException.EtcpErrorCode.FtdiCommandSendError);

            return ByteSwap.Swap(BitConverter.ToUInt64(buffer, 0));
        }

        public uint getSymbol(string rplname, string sysname, byte data = 0) {
            byte[] rplnbuf = Encoding.UTF8.GetBytes(rplname);
            byte[] sysnbuf = Encoding.UTF8.GetBytes(sysname);
            byte[] startStuff = { 0x0, 0x0, 0x0, 0x8 };
            byte[] startStuff1 = BitConverter.GetBytes(8 + rplnbuf.Length + 1);
            Array.Reverse(startStuff1);

            byte[] size = { (byte)(rplnbuf.Length + sysnbuf.Length + 10) };
            var ms = new MemoryStream(new byte[size[0]], 0, size[0], true, true);
            ms.Write(startStuff, 0, startStuff.Length);
            ms.Write(startStuff1, 0, startStuff.Length);
            ms.Write(rplnbuf, 0, rplnbuf.Length);
            ms.Write(new byte[] { 0 }, 0, 1); // null terminator
            ms.Write(sysnbuf, 0, sysnbuf.Length);
            ms.Write(new byte[] { 0 }, 0, 1);
            byte[] buffer = ms.GetBuffer();
            byte[] Data = { data };

            if (RawCommand((byte)GeckoUCommands.Command.CommandGetSymbol) != FtdiCommand.CmdOk)
                throw new GeckoUException(GeckoUException.EtcpErrorCode.FtdiCommandSendError);

            if (GeckoUWrite(size, 1) != FtdiCommand.CmdOk)
                throw new GeckoUException(GeckoUException.EtcpErrorCode.FtdiCommandSendError);

            if (GeckoUWrite(buffer, buffer.Length) != FtdiCommand.CmdOk)
                throw new GeckoUException(GeckoUException.EtcpErrorCode.FtdiCommandSendError);

            if (GeckoUWrite(Data, 1) != FtdiCommand.CmdOk)
                throw new GeckoUException(GeckoUException.EtcpErrorCode.FtdiCommandSendError);

            if (GeckoURead(buffer, 4) != FtdiCommand.CmdOk)
                throw new GeckoUException(GeckoUException.EtcpErrorCode.FtdiCommandSendError);

            return ByteSwap.Swap(BitConverter.ToUInt32(buffer, 0));
        }

        public void excecuteAssembly(string AssemblyString) {
            byte[] buffer = Encoding.UTF8.GetBytes(AssemblyString);
            if (RawCommand((byte)GeckoUCommands.Command.CommandExecuteAssembly) != FtdiCommand.CmdOk)
                throw new GeckoUException(GeckoUException.EtcpErrorCode.FtdiCommandSendError);
            if (GeckoUWrite(buffer, buffer.Length) != FtdiCommand.CmdOk)
                throw new GeckoUException(GeckoUException.EtcpErrorCode.FtdiCommandSendError);
        }

        public void RpcToggle(uint address1, uint address2, uint value1, uint value2, bool toggle) {
            switch (toggle) {
                case true:
                    CallFunction64(address1, value1);
                    break;

                case false:
                    CallFunction64(address2, value2);
                    break;
            }
        }

        public void RpcToggle(uint address, uint classAddress, uint[] value, bool toggle, int indexOn, int indexOff) {
            switch (toggle) {
                case true:
                    CallFunction64(address, classAddress, value[indexOn]);
                    break;

                case false:
                    CallFunction64(address, classAddress, value[indexOff]);
                    break;
            }
        }


        #endregion rpc

        #region writing
        /// <summary>
        /// Writes a value to an address when toggled
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write to when toggled</param>
        /// <param name="originalValue">Value to write to when untoggled</param>
        /// <param name="toggle">Whether the addresses should be poked</param>
        public void WriteUIntToggle(uint address, uint value, uint originalValue, bool toggle) {
            switch (toggle) {
                case true:
                    WriteUInt(address, value);
                    break;

                case false:
                    WriteUInt(address, originalValue);
                    break;
            }
        }

        /// <summary>
        /// Writes a value to an address when toggled
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write to when toggled</param>
        /// <param name="originalValue">Value to write to when untoggled</param>
        /// <param name="toggle">Whether the addresses should be poked</param>
        public void WriteLongToggle(uint address, long value, long originalValue, bool toggle) {
            switch (toggle) {
                case true:
                    WriteLong(address, value);
                    break;

                case false:
                    WriteLong(address, originalValue);
                    break;
            }
        }

        /// <summary>
        /// Writes a value to an address when toggled
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write to when toggled</param>
        /// <param name="originalValue">Value to write to when Untoggled</param>
        /// <param name="toggle">Whether the addresses should be poked</param>
        public void WriteULongToggle(uint address, ulong value, ulong originalValue, bool toggle) {
            switch (toggle) {
                case true:
                    WriteULong(address, value);
                    break;

                case false:
                    WriteULong(address, originalValue);
                    break;
            }
        }

        /// <summary>
        /// Writes a uint to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteUInt(uint address, uint value) {
            var bytes = BitConverter.GetBytes(value);
            try {
                Array.Reverse(bytes);
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a unsigned interger to the given addresses
        /// </summary>
        /// <param name="addresses"></param>
        /// <param name="value"></param>
        public void WriteUInt(uint[] addresses, uint value) {
            var bytes = BitConverter.GetBytes(value);
            try {
                Array.Reverse(bytes);
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }

            foreach (uint address in addresses)
                WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a Long to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteLong(uint address, long value) {
            var bytes = BitConverter.GetBytes(value);
            try {
                Array.Reverse(bytes);
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a Unsigned Long to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteULong(uint address, ulong value) {
            var bytes = BitConverter.GetBytes(value);
            try {
                Array.Reverse(bytes);
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a float to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteFloat(uint address, float value) {
            var bytes = BitConverter.GetBytes(value);
            try {
                Array.Reverse(bytes);
            } catch (ArgumentNullException error) {
                MessageBox.Show(error.Message);
            } catch (RankException error) {
                MessageBox.Show(error.Message);
            }

            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a double to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteDouble(uint address, double value) {
            var bytes = BitConverter.GetBytes(value);
            try {
                Array.Reverse(bytes);
            } catch (ArgumentNullException error) {
                MessageBox.Show(error.Message);
            } catch (RankException error) {
                MessageBox.Show(error.Message);
            }

            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a Int32 to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteInt(uint address, int value) {
            var bytes = BitConverter.GetBytes(value);
            try {
                Array.Reverse(bytes);
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a Short to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteShort(uint address, short value) {
            var bytes = BitConverter.GetBytes(value);
            try {
                Array.Reverse(bytes);
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a ushort to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteUShort(uint address, ushort value) {
            var bytes = BitConverter.GetBytes(value);
            try {
                Array.Reverse(bytes);
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a String to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">String to write</param>
        public void WriteString(uint address, string value, Encoding type, bool terminate = false) {
            byte[] bytes;
            if (terminate) {
                bytes = type.GetBytes(value + char.MinValue);
            } else {
                bytes = type.GetBytes(value);
            }
            WriteBytes(address, bytes);
        }
        public void WriteString16(uint address, string value) {
            var bytes = Encoding.BigEndianUnicode.GetBytes(value);
            WriteBytes(address, bytes);
        }
        #endregion Writing, Poking

        #region reading

        /// <summary>
        /// Peeks a Unsigned Integer from the Wii U
        /// </summary>
        /// <param name="address">The address to peak</param>
        /// <returns>The peeked Unsigned Integer</returns>
        public uint PeekUInt(uint address) {
            var bytes = ReadBytes(address, 0x4);
            uint value;

            try {
                Array.Reverse(bytes);
                value = !bytes.Any() ? 0 : BitConverter.ToUInt32(bytes, 0);
            } catch (Exception) {
                return 0;
            }

            return value;
        }

        /// <summary>
        /// Peeks a long from the Wii U
        /// </summary>
        /// <param name="address">The address to peak</param>
        /// <returns>The peeked Long</returns>
        public long PeekLong(uint address) {
            var bytes = ReadBytes(address, 0x8);
            long value;

            try {
                Array.Reverse(bytes);
                value = !bytes.Any() ? 0 : BitConverter.ToInt64(bytes, 0);
            } catch (Exception) {
                return 0;
            }

            return value;
        }

        /// <summary>
        /// Peeks a Unsigned Long from the Wii U
        /// </summary>
        /// <param name="address">The address to peak</param>
        /// <returns>The peeked Unsigned Long</returns>
        public ulong PeekULong(uint address) {
            var bytes = ReadBytes(address, 0x8);
            ulong value;

            try {
                Array.Reverse(bytes);
                value = !bytes.Any() ? 0 : BitConverter.ToUInt64(bytes, 0);
            } catch (Exception) {
                return 0;
            }

            return value;
        }

        /// <summary>
        /// Peeks a float from the Wii U
        /// </summary>
        /// <param name="address">The address to peak</param>
        /// <returns>The peeked Float</returns>
        public float PeekFloat(uint address) {
            var bytes = ReadBytes(address, 0x4);
            float value;

            try {
                Array.Reverse(bytes);
                value = !bytes.Any() ? 0 : BitConverter.ToSingle(bytes, 0);
            } catch (Exception) {
                return 0;
            }

            return value;
        }

        /// <summary>
        /// Peeks a double from the Wii U
        /// </summary>
        /// <param name="address">The address to peak</param>
        /// <returns>The peeked Double</returns>
        public double PeekDouble(uint address) {
            var bytes = ReadBytes(address, 8);
            double value;

            try {
                Array.Reverse(bytes);
                value = !bytes.Any() ? 0 : BitConverter.ToDouble(bytes, 0);
            } catch (Exception) {
                return 0;
            }

            return value;
        }

        public string PeekString(int length, uint address) {
            var peekedString = ReadBytes(address, (uint)length);
            return Encoding.UTF8.GetString(peekedString).Replace("\0", "");
        }
        public string PeekString16(int length, uint address) {
            var peekedString = ReadBytes(address, (uint)length * 2);
            return Encoding.BigEndianUnicode.GetString(peekedString);
        }

        #endregion reading

        #region commands
        /*/// <summary>
        /// Reads the Data Buffer Size on the Wii U
        /// </summary>
        /// <returns>UInt</returns>
        private uint ReadDataBufferSize()
        {
            SendCommand(GeckoUCommands.Command.CommandGetDataBufferSize);

            var response = new byte[4];
            Tcp.Read(response, 4, out _);

            Array.Reverse(response);
            var bufferSize = BitConverter.ToUInt32(response, 0);

            return bufferSize;
        }*/

        /// <summary>
        /// Reads the Code Handler Installation address
        /// </summary>
        /// <returns>UInt</returns>
        public uint ReadCodeHandlerAddress() {
            SendCommand(GeckoUCommands.Command.CommandGetCodeHandlerAddress);

            var response = new byte[4];
            Tcp.Read(response, 4, out _);

            Array.Reverse(response);
            var bufferSize = BitConverter.ToUInt32(response, 0);

            return bufferSize;
        }

        /// <summary>
        /// Reads the User Account Identifier
        /// </summary>
        /// <returns>UInt</returns>
        public uint ReadAccountIdentifier() {
            SendCommand(GeckoUCommands.Command.CommandAccountIdentifier);

            var response = new byte[4];
            Tcp.Read(response, 4, out _);

            Array.Reverse(response);
            var bufferSize = BitConverter.ToUInt32(response, 0);

            return bufferSize;
        }

        public uint ReadVersionHash() {
            SendCommand(GeckoUCommands.Command.CommandGetVersionHash);

            var response = new byte[4];
            Tcp.Read(response, 4, out _);

            Array.Reverse(response);
            var versionHash = BitConverter.ToUInt32(response, 0);

            return versionHash;
        }

        /// <summary>
        /// Grabs the current Wii U firmware version
        /// </summary>
        /// <returns>Wii U Firmware version</returns>
        public uint ReadOsVersion() {
            SendCommand(GeckoUCommands.Command.CommandGetOsVersion);

            var response = new byte[4];
            Tcp.Read(response, 4, out _);

            Array.Reverse(response);
            var osVer = BitConverter.ToUInt32(response, 0);

            return osVer;
        }

        /// <summary>
        /// Grabs the currently used account name
        /// </summary>
        /// <param name="address">Address to write/read the name to/from</param>
        /// <returns>The name of the account which is currently logged in</returns>
        public string ReadAccountName(uint address) {
            CallFunction(0x03863C8C, address);
            return PeekString(28, address);
        }

        /// <summary>
        /// Grabs the country the Wii U is in
        /// </summary>
        /// <param name="address">Address to write/read the country code to/from</param>
        /// <returns>A country code (e.g US, JP, BE)</returns>
        public string ReadCountryCode(uint address) {
            CallFunction(0x0384E79C, address);
            return PeekString(4, address);
        }

        /// <summary>
        /// Grabs the currently running Title ID
        /// </summary>
        /// <returns>A Wii U application/game's Title ID</returns>
        public string ReadTitleId() {
            return CallFunction64(getSymbol("coreinit.rpl", "OSGetTitleID")).ToString("x8");
        }
        #endregion Commands

        #region misc

        /// <summary>
        /// Fits in a value into the given value
        /// </summary>
        /// <param name="baseValue">The base value</param>
        /// <param name="val">The value to fit in</param>
        /// <returns></returns>
        public uint Mix(uint baseValue, decimal val) {
            var d = 0x0 + val;
            var value = baseValue;
            value += (uint)d * 0x01;

            return value;
        }

        /// <summary>
        /// Clears a buffer
        /// </summary>
        /// <param name="buffer">The buffer to clear</param>
        public void ClearBuffer(byte[] buffer) {
            for (var i = 0; i < buffer.Length; i++) {
                buffer[i] = 0;
            }
        }

        public void ClearString(uint address) {
            var clearingAddress = address;

            while (PeekUInt(clearingAddress) != 0x00000000) {
                WriteUInt(clearingAddress, 0x00000000);
                clearingAddress += 4;
            }
        }

        public void ClearString(uint addressStart, uint addressEnd) {
            ClearString(addressStart, (int)(addressEnd - addressStart));
        }

        public void ClearString(uint address, int length) {
            byte[] buffer = new byte[length];
            WriteBytes(address, buffer);
        }

        public uint malloc(uint size, uint alignment = 4) {
            uint symbol = getSymbol("coreinit.rpl", "MEMAllocFromDefaultHeapEx", 1);
            uint funcAddy = PeekUInt(symbol);
            return CallFunction(funcAddy, size, alignment);
        }

        public void free(uint address) {
            uint symbol = getSymbol("coreinit.rpl", "MEMFreeToDefaultHeap", 1);
            uint funcAddy = PeekUInt(symbol);
            CallFunction(funcAddy, address);
        }

        #endregion misc
    }
}