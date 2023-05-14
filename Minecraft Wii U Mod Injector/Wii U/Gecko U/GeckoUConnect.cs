using System;
using System.IO;
using System.Net.Sockets;
using Minecraft_Wii_U_Mod_Injector.Helpers;

namespace Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U
{
    public class GeckoUConnect
    {
        private TcpClient _tcpClient;
        public NetworkStream NetworkStream;
        
        public string Host { get; }
        public int Port { get; }

        public uint CmdMaxBufferSize { get; private set; }

        public GeckoUConnect(string host, int port)
        {
            Host = host;
            Port = port;
        }

        /// <summary>
        /// Connects to the Wii U
        /// </summary>
        public void Connect()
        {
#if DEBUG
            Console.WriteLine(@"GECKO U: Attempting connection to " + Host + @":" + Port);
#endif
            _tcpClient = new TcpClient
            {
                NoDelay = true
            };

            var tcpAsyncResult = _tcpClient.BeginConnect(Host, Port, null, null);
            var tcpWaitHandle = tcpAsyncResult.AsyncWaitHandle;

            try
            {
                if (!tcpAsyncResult.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(5), false))
                {
#if DEBUG
                    Console.WriteLine(@"GECKO U: Connection to " + Host + @":" + Port + @" unsuccessful, timed out");
#endif
                    _tcpClient.Close();
                    throw new IOException("Unable to Connect to the Wii U, connection timed-out", new TimeoutException());
                }

                _tcpClient.EndConnect(tcpAsyncResult);
                tcpWaitHandle.Close();
            }
            catch
            {
#if DEBUG
                Console.WriteLine(@"GECKO U: Connection to " + Host + @":" + Port + @" unsuccessful");
#endif
                throw new IOException("Unable to connect to the Wii U, connection timed-out", new TimeoutException());

            }

            NetworkStream = _tcpClient.GetStream();
            NetworkStream.ReadTimeout = NetworkStream.WriteTimeout = 10000;

            NetworkStream.Write(new byte[] { 0x51 }, 0, 1);

            byte[] CmdMaximumMemoryChunkSizeOut = { 0, 0, 0, 0 };
            NetworkStream.Read(CmdMaximumMemoryChunkSizeOut, 0, 4);
            Array.Reverse(CmdMaximumMemoryChunkSizeOut);
            
            CmdMaxBufferSize = BitConverter.ToUInt32(CmdMaximumMemoryChunkSizeOut, 0);
#if DEBUG
            Console.WriteLine(@"GECKO U: Connection to " + Host + @":" + Port + @" successful");
#endif
        }

        /// <summary>
        /// Disconnect from the Wii U
        /// </summary>
        public void Close()
        {
#if DEBUG
            Console.WriteLine(@"GECKO U: Closing connection " + Host + @":" + Port);
#endif
            try
            {
                _tcpClient?.Close();
                _tcpClient?.Dispose();
                NetworkStream?.Close();
                NetworkStream?.Dispose();
            }
            catch (Exception)
            {
                throw new IOException("Unable to close the connection to the Wii U");
            }
            finally
            {
                _tcpClient = null;
                NetworkStream = null;

#if DEBUG
                Console.WriteLine(@"GECKO U: Connection closed");
#endif
            }
        }

        /// <summary>
        /// Read from the Wii U from the buffer
        /// </summary>
        /// <param name="buffer">The Buffer</param>
        /// <param name="byteCount">NoBytes</param>
        /// <param name="bytesRead">Amount of bytes read</param>
        public void Read(byte[] buffer, uint byteCount, out uint bytesRead)
        {
            var offset = 0;
            bytesRead = 0;

            while (byteCount > 0)
            {
#if DEBUG
                Console.WriteLine(@"GECKO U: Reading " + byteCount + @" from the network stream");
#endif
                var read = NetworkStream.Read(buffer, offset, (int)byteCount);
#if DEBUG
                Console.WriteLine(@"GECKO U: Read buffer: " + StringUtils.ByteArrayToString(buffer));
#endif

                if (read >= 0)
                {
                    bytesRead += (uint)read;
                    offset += read;
                    byteCount -= (uint)read;
                }
                else
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Write data to the Wii U from the Buffer
        /// </summary>
        /// <param name="buffer">The Buffer</param>
        /// <param name="byteCount">NoBytes</param>
        /// <param name="bytesWritten">Amount of bytes written</param>
        public void Write(byte[] buffer, int byteCount, out uint bytesWritten)
        {
#if DEBUG
            Console.WriteLine(@"GECKO U: Writing to the network stream: " + StringUtils.ByteArrayToString(buffer));
#endif
            NetworkStream.Write(buffer, 0, byteCount);

            if (byteCount >= 0)
            {
                bytesWritten = (uint)byteCount;
            }
            else
            {
                bytesWritten = 0;
            }

#if DEBUG
            Console.WriteLine(@"GECKO U: Flushing network stream");
#endif
            NetworkStream.Flush();
        }
    }
}