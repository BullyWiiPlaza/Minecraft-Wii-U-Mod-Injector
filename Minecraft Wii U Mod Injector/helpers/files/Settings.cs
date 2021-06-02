namespace Minecraft_Wii_U_Mod_Injector.Helpers.Files
{
    public class Settings
    {
        private static IniFile settingsFile = new IniFile();

        public static void Write(string key, string value, string section)
        {
            settingsFile.Write(key, value, section);
        }

        public static void Delete(string key, string section)
        {
            settingsFile.DeleteKey(key, section);
        }

        public static string Read(string key, string section)
        {
            return settingsFile.Read(key, section);
        }

        public static bool EqualsTo(string key, string value, string section)
        {
            if (settingsFile.Read(key, section) == value)
                return true;
            else
                return false;
        }

        public static bool Exists(string key, string section)
        {
            return settingsFile.KeyExists(key, section);
        }
    }
}
