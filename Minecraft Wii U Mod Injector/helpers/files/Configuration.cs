namespace Minecraft_Wii_U_Mod_Injector.Helpers.Files
{
    public class Configuration
    {
        private static IniFile INIConfig = new IniFile();

        public static void WriteKey(string key, string value, string section)
        {
            INIConfig.Write(key, value, section);
        }

        public static void DeleteKey(string key, string section)
        {
            INIConfig.DeleteKey(key, section);
        }

        public static string ReadKey(string key, string section)
        {
            return INIConfig.Read(key, section);
        }

        public static bool KeyEqualsTo(string key, string value, string section)
        {
            if (INIConfig.Read(key, section) == value)
                return true;
            else
                return false;
        }

        public static bool KeyExists(string key, string section)
        {
            return INIConfig.KeyExists(key, section);
        }
    }
}
