using System;
using System.IO;
using System.Net.Sockets;

namespace WiiU.GeckoU
{
    public class GeckoUConnect
    {
        private TcpClient _tcpClient;
        public NetworkStream NetworkStream;
        
        public string Host { get; }
        public int Port { get; }

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
            _tcpClient = new TcpClient()
            {
                NoDelay = true
            };

            var tcpAsyncResult = _tcpClient.BeginConnect(Host, Port, null, null);
            var tcpWaitHandle = tcpAsyncResult.AsyncWaitHandle;

            try
            {
                if (!tcpAsyncResult.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(5), false))
                {
                    _tcpClient.Close();
                    throw new IOException("Unable to Connect to the Wii U, connection timed-out", new TimeoutException());
                }

                _tcpClient.EndConnect(tcpAsyncResult);
                tcpWaitHandle.Close();
            }
            catch
            {
                throw new IOException("Unable to connect to the Wii U, connection timed-out", new TimeoutException());
            }

            NetworkStream = _tcpClient.GetStream();
            NetworkStream.ReadTimeout = NetworkStream.WriteTimeout = 10000;
        }

        /// <summary>
        /// Disconnect from the Wii U
        /// </summary>
        public void Close()
        {
            try
            {
                if (_tcpClient == null)
                {
                    return;
                }

                _tcpClient.Close();
                _tcpClient.Dispose();
                NetworkStream?.Close();
                NetworkStream?.Dispose();
            }
            catch (Exception)
            {
                throw new IOException("Unable to close the connection from the Wii U");
            }
            finally
            {
                _tcpClient = null;
                NetworkStream = null;
            }
        }

        /// <summary>
        /// Read from the Wii U from the buffer
        /// </summary>
        /// <param name="buffer">The Buffer</param>
        /// <param name="byteCount">NoBytes</param>
        /// <param name="bytesRead">Amount of bytes read</param>
        public void Read(byte[] buffer, uint byteCount, ref uint bytesRead)
        {
            try
            {
                if (NetworkStream == null)
                {
                    return;
                }

                var offset = 0;
                bytesRead = 0;

                while (byteCount > 0)
                {
                    var read = NetworkStream.Read(buffer, offset, (int) byteCount);

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
            catch (Exception exception)
            {
                throw new IOException("Connection closed", exception);
            }
        }

        /// <summary>
        /// Write data to the Wii U from the Buffer
        /// </summary>
        /// <param name="buffer">The Buffer</param>
        /// <param name="byteCount">NoBytes</param>
        /// <param name="bytesWritten">Amount of bytes written</param>
        public void Write(byte[] buffer, int byteCount, ref uint bytesWritten)
        {
            try
            {
                if (NetworkStream == null)
                {
                    throw new IOException("The NetworkStream was null", new NullReferenceException());
                }

                NetworkStream.Write(buffer, 0, byteCount);

                if (byteCount >= 0)
                {
                    bytesWritten = (uint)byteCount;
                }
                else
                {
                    bytesWritten = 0;
                }

                NetworkStream.Flush();
            }
            catch (Exception exception)
            {
                throw new IOException("Connection closed", exception);
            }
        }
    }
}