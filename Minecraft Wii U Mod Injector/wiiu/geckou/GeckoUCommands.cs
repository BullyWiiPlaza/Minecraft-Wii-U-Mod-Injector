using System;

namespace WiiU.GeckoU
{
    class GeckoUCommands
    {
        public const Byte cmd_poke08 = 0x01;
        public const Byte cmd_poke16 = 0x02;
        public const Byte cmd_pokemem = 0x03;
        public const Byte cmd_readmem = 0x04;
        public const Byte cmd_pause = 0x06;
        public const Byte cmd_unfreeze = 0x07;
        public const Byte cmd_breakpoint = 0x09;
        public const Byte cmd_writekern = 0x0b;
        public const Byte cmd_readkern = 0x0c;
        public const Byte cmd_breakpointx = 0x10;
        public const Byte cmd_sendregs = 0x2F;
        public const Byte cmd_getregs = 0x30;
        public const Byte cmd_cancelbp = 0x38;
        public const Byte cmd_sendcheats = 0x40;
        public const Byte cmd_upload = 0x41;
        public const Byte cmd_hook = 0x42;
        public const Byte cmd_hookpause = 0x43;
        public const Byte cmd_step = 0x44;
        public const Byte cmd_status = 0x50;
        public const Byte cmd_cheatexec = 0x60;
        public const Byte cmd_rpc = 0x70;
        public const Byte cmd_nbreakpoint = 0x89;
        public const Byte cmd_version = 0x99;
        public const Byte cmd_os_version = 0x9A;

        public enum Command
        {
            COMMAND_WRITE_8 = 0x01,
            COMMAND_WRITE_16 = 0x02,
            COMMAND_WRITE_32 = 0x03,
            COMMAND_READ_MEMORY = 0x04,
            COMMAND_READ_MEMORY_KERNEL = 0x05,
            COMMAND_VALIDATE_ADDRESS_RANGE = 0x06,
            COMMAND_MEMORY_DISASSEMBLE = 0x08,
            //COMMAND_READ_MEMORY_COMPRESSED = 0x09,
            COMMAND_KERNEL_WRITE = 0x0B,
            COMMAND_KERNEL_READ = 0x0C,
            COMMAND_TAKE_SCREEN_SHOT = 0x0D,
            COMMAND_UPLOAD_MEMORY = 0x41,
            COMMAND_SERVER_STATUS = 0x50,
            COMMAND_GET_DATA_BUFFER_SIZE = 0x51,
            COMMAND_READ_FILE = 0x52,
            COMMAND_READ_DIRECTORY = 0x53,
            COMMAND_REPLACE_FILE = 0x54,
            COMMAND_GET_CODE_HANDLER_ADDRESS = 0x55,
            COMMAND_READ_THREADS = 0x56,
            COMMAND_ACCOUNT_IDENTIFIER = 0x57,
            //COMMAND_WRITE_SCREEN = 0x58,
            COMMAND_FOLLOW_POINTER = 0x60,
            COMMAND_REMOTE_PROCEDURE_CALL = 0x70,
            COMMAND_GET_SYMBOL = 0x71,
            COMMAND_MEMORY_SEARCH_32 = 0x72,
            COMMAND_ADVANCED_MEMORY_SEARCH = 0x73,
            COMMAND_EXECUTE_ASSEMBLY = 0x81,
            COMMAND_PAUSE_CONSOLE = 0x82,
            COMMAND_RESUME_CONSOLE = 0x83,
            COMMAND_IS_CONSOLE_PAUSED = 0x84,
            COMMAND_SERVER_VERSION = 0x99,
            COMMAND_GET_OS_VERSION = 0x9A,
            COMMAND_SET_DATA_BREAKPOINT = 0xA0,
            COMMAND_SET_INSTRUCTION_BREAKPOINT = 0xA2,
            COMMAND_TOGGLE_BREAKPOINT = 0xA5,
            COMMAND_REMOVE_ALL_BREAKPOINTS = 0xA6,
            COMMAND_POKE_REGISTERS = 0xA7,
            COMMAND_GET_STACK_TRACE = 0xA8,
            COMMAND_GET_ENTRY_POINT_ADDRESS = 0xB1,
            COMMAND_RUN_KERNEL_COPY_SERVICE = 0xCD,
            //COMMAND_IOSU_HAX_READ_FILE = 0xD0,
            COMMAND_GET_VERSION_HASH = 0xE0,
            COMMAND_PERSIST_ASSEMBLY = 0xE1,
            COMMAND_CLEAR_ASSEMBLY = 0xE2
        }
    }
}
