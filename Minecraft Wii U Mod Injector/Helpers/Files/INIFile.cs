using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Minecraft_Wii_U_Mod_Injector.Helpers.Files
{
    class IniFile
    {
        string _path;
        string _exe = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string section, string key, string value, string filePath);
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string section, string key, string @default, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32.dll")]
        static extern int GetPrivateProfileSection(string lpAppName, byte[] lpszReturnBuffer, int nSize, string lpFileName);

        public IniFile(string iniPath = null)
        {
            _path = new FileInfo(iniPath ?? _exe + ".ini").FullName;
        }

        public string Read(string key, string section = null)
        {
            var retVal = new StringBuilder(255);
            GetPrivateProfileString(section ?? _exe, key, "", retVal, 255, _path);
            return retVal.ToString();
        }

        public void Write(string key, string value, string section = null)
        {
            WritePrivateProfileString(section ?? _exe, key, value, _path);
        }

        public void DeleteKey(string key, string section = null)
        {
            Write(key, null, section ?? _exe);
        }

        public void DeleteSection(string section = null)
        {
            Write(null, null, section ?? _exe);
        }

        public bool KeyExists(string key, string section = null)
        {
            return Read(key, section).Length > 0;
        }

        public List<string> GetKeys(string section)
        {
            List<string> result = new List<string>();
            byte[] buffer = new byte[12048];
            GetPrivateProfileSection(section, buffer, 12048, _path);
            string[] tmp = Encoding.ASCII.GetString(buffer).Trim('\0').Split('\0');

            foreach (string entry in tmp)
            {
                if (entry.Length > 0)
                    result.Add(entry.Substring(0, entry.IndexOf("=", StringComparison.Ordinal)));
            }

            return result;
        }
    }
}