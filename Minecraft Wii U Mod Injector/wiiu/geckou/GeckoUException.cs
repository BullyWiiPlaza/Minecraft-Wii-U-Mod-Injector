using System;

namespace WiiU.GeckoU
{
    public class GeckoUException : Exception
    {
        public enum ETCPErrorCode
        {
            FTDIQueryError,
            noFTDIDevicesFound,
            noTCPGeckoFound,
            FTDIResetError,
            FTDIPurgeRxError,
            FTDIPurgeTxError,
            FTDITimeoutSetError,
            FTDITransferSetError,
            FTDICommandSendError,
            FTDIReadDataError,
            FTDIInvalidReply,
            TooManyRetries,
            REGStreamSizeInvalid,
            CheatStreamSizeInvalid
        }

        private ETCPErrorCode PErrorCode;

        public ETCPErrorCode ErrorCode
        {
            get
            {
                return PErrorCode;
            }
        }

        public GeckoUException(ETCPErrorCode code) : base()
        {
            PErrorCode = code;
        }
        public GeckoUException(ETCPErrorCode code, string message) : base(message)
        {
            PErrorCode = code;
        }
        public GeckoUException(ETCPErrorCode code, string message, Exception inner) : base(message, inner)
        {
            PErrorCode = code;
        }
    }
}
