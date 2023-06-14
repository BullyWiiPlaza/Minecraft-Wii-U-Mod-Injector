using System;
using System.Diagnostics;
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
        /// Attempts a connection to the Wii U
        /// </summary>
        public void Connect()
        {

            Debug.WriteLine(@"Attempting connection to " + Host + @":" + Port, "GeckoUConnect");

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
                    Debug.WriteLine(@"Connection to " + Host + @":" + Port + @" unsuccessful, timed out", "GeckoUConnect");
                    _tcpClient.Close();
                    throw new IOException("Unable to Connect to the Wii U, connection timed-out", new TimeoutException());
                }

                _tcpClient.EndConnect(tcpAsyncResult);
                tcpWaitHandle.Close();
            }
            catch
            {

                Debug.WriteLine(@"Connection to " + Host + @":" + Port + @" unsuccessful", "GeckoUConnect");
                throw new IOException("Unable to connect to the Wii U, connection timed-out", new TimeoutException());

            }

            NetworkStream = _tcpClient.GetStream();
            NetworkStream.ReadTimeout = NetworkStream.WriteTimeout = 10000;

            NetworkStream.Write(new byte[] { 0x51 }, 0, 1);

            byte[] CmdMaximumMemoryChunkSizeOut = { 0, 0, 0, 0 };
            NetworkStream.Read(CmdMaximumMemoryChunkSizeOut, 0, 4);
            Array.Reverse(CmdMaximumMemoryChunkSizeOut);
            
            CmdMaxBufferSize = BitConverter.ToUInt32(CmdMaximumMemoryChunkSizeOut, 0);
            Debug.WriteLine(@"Connection to " + Host + @":" + Port + @" successful");
        }

        /// <summary>
        /// Disconnects from the Wii U
        /// </summary>
        public void Close()
        {
            Debug.WriteLine(@"Closing connection " + Host + @":" + Port, "GeckoUConnect");
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

                Debug.WriteLine(@"Connection closed", "GeckoUConnect");
            }
        }

        /// <summary>
        /// Read bytes from the network stream
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
                Debug.WriteLine(@"Reading " + byteCount + @" from the network stream", "GeckoUConnect");
                var read = NetworkStream.Read(buffer, offset, (int)byteCount);
                Debug.WriteLine(@"Read buffer: " + StringUtils.ByteArrayToString(buffer), "GeckoUConnect");

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
        /// Writes bytes to the network stream
        /// </summary>
        /// <param name="buffer">The Buffer</param>
        /// <param name="byteCount">NoBytes</param>
        /// <param name="bytesWritten">Amount of bytes written</param>
        public void Write(byte[] buffer, int byteCount, out uint bytesWritten)
        {
            Debug.WriteLine(@"Writing to the network stream: " + StringUtils.ByteArrayToString(buffer), "GeckoUConnect");
            NetworkStream.Write(buffer, 0, byteCount);

            if (byteCount >= 0)
            {
                bytesWritten = (uint)byteCount;
            }
            else
            {
                bytesWritten = 0;
            }

            Debug.WriteLine(@"Flushing network stream", "GeckoUConnect");
            NetworkStream.Flush();
        }
    }
}