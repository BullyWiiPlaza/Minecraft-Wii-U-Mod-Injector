namespace Minecraft_Wii_U_Mod_Injector.Helpers.Files
{
    public class Settings
    {
        private static IniFile _settingsFile = new IniFile();

        public static void Write(string key, string value, string section)
        {
            _settingsFile.Write(key, value, section);
        }

        public static void Delete(string key, string section)
        {
            _settingsFile.DeleteKey(key, section);
        }

        public static string Read(string key, string section)
        {
            if(Exists(key, section))
                return _settingsFile.Read(key, section);
            else
            {
                return "NOT FOUND";
            }
        }

        public static bool EqualsTo(string key, string value, string section)
        {
            if (_settingsFile.Read(key, section) == value)
                return true;
            else
                return false;
        }

        public static bool Exists(string key, string section)
        {
            return _settingsFile.KeyExists(key, section);
        }
    }
}
