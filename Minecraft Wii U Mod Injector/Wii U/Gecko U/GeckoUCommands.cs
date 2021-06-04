using System;

namespace Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U
{
    class GeckoUCommands
    {
        public const Byte Poke08 = 0x01;
        public const Byte Poke16 = 0x02;
        public const Byte Pokemem = 0x03;
        public const Byte Readmem = 0x04;
        public const Byte Pause = 0x06;
        public const Byte Unfreeze = 0x07;
        public const Byte Breakpoint = 0x09;
        public const Byte Writekern = 0x0b;
        public const Byte Readkern = 0x0c;
        public const Byte Breakpointx = 0x10;
        public const Byte Sendregs = 0x2F;
        public const Byte Getregs = 0x30;
        public const Byte Cancelbp = 0x38;
        public const Byte Sendcheats = 0x40;
        public const Byte Upload = 0x41;
        public const Byte Hook = 0x42;
        public const Byte Hookpause = 0x43;
        public const Byte Step = 0x44;
        public const Byte Status = 0x50;
        public const Byte Cheatexec = 0x60;
        public const Byte Rpc = 0x70;
        public const Byte Nbreakpoint = 0x89;
        public const Byte Version = 0x99;
        public const Byte OsVersion = 0x9A;

        public enum Command
        {
            CommandWrite8 = 0x01,
            CommandWrite16 = 0x02,
            CommandWrite32 = 0x03,
            CommandReadMemory = 0x04,
            CommandReadMemoryKernel = 0x05,
            CommandValidateAddressRange = 0x06,
            CommandMemoryDisassemble = 0x08,
            //COMMAND_READ_MEMORY_COMPRESSED = 0x09,
            CommandKernelWrite = 0x0B,
            CommandKernelRead = 0x0C,
            CommandTakeScreenShot = 0x0D,
            CommandUploadMemory = 0x41,
            CommandServerStatus = 0x50,
            CommandGetDataBufferSize = 0x51,
            CommandReadFile = 0x52,
            CommandReadDirectory = 0x53,
            CommandReplaceFile = 0x54,
            CommandGetCodeHandlerAddress = 0x55,
            CommandReadThreads = 0x56,
            CommandAccountIdentifier = 0x57,
            //COMMAND_WRITE_SCREEN = 0x58,
            CommandFollowPointer = 0x60,
            CommandRemoteProcedureCall = 0x70,
            CommandGetSymbol = 0x71,
            CommandMemorySearch32 = 0x72,
            CommandAdvancedMemorySearch = 0x73,
            CommandExecuteAssembly = 0x81,
            CommandPauseConsole = 0x82,
            CommandResumeConsole = 0x83,
            CommandIsConsolePaused = 0x84,
            CommandServerVersion = 0x99,
            CommandGetOsVersion = 0x9A,
            CommandSetDataBreakpoint = 0xA0,
            CommandSetInstructionBreakpoint = 0xA2,
            CommandToggleBreakpoint = 0xA5,
            CommandRemoveAllBreakpoints = 0xA6,
            CommandPokeRegisters = 0xA7,
            CommandGetStackTrace = 0xA8,
            CommandGetEntryPointAddress = 0xB1,
            CommandRunKernelCopyService = 0xCD,
            //COMMAND_IOSU_HAX_READ_FILE = 0xD0,
            CommandGetVersionHash = 0xE0,
            CommandPersistAssembly = 0xE1,
            CommandClearAssembly = 0xE2
        }
    }
}
