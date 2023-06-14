using System;

namespace Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U
{
    public class GeckoUException : Exception
    {
        public enum EtcpErrorCode
        {
            //FtdiQueryError,
            //NoFtdiDevicesFound,
            //NoTcpGeckoFound,
            //FtdiResetError,
            //FtdiPurgeRxError,
            //FtdiPurgeTxError,
            //FtdiTimeoutSetError,
            //FtdiTransferSetError,
            FtdiCommandSendError,
            //FtdiReadDataError,
            //FtdiInvalidReply,
            //TooManyRetries,
            //RegStreamSizeInvalid,
            //CheatStreamSizeInvalid
        }

        public EtcpErrorCode ErrorCode { get; }

        public GeckoUException(EtcpErrorCode code)
        {
            ErrorCode = code;
        }
        public GeckoUException(EtcpErrorCode code, string message) : base(message)
        {
            ErrorCode = code;
        }
        public GeckoUException(EtcpErrorCode code, string message, Exception inner) : base(message, inner)
        {
            ErrorCode = code;
        }
    }
}
