using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
{
    internal class StringUtils
    {
        public static string ToHex(decimal val)
        {
            return new System.Numerics.BigInteger(val).ToString("X");
        }

        public static string StripInvalidChars(string str)
        {
            return string.Join("", str.Split(Path.GetInvalidFileNameChars()));
        }

        public static string RemoveEmpties(string str)
        {
            return Regex.Replace(str, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
        }

        public static bool ValidateIPv4(string ipString)
        {
            if (string.IsNullOrWhiteSpace(ipString))
                return false;

            if (ipString == "127.0.0.1")
                return false;

            var splitValues = ipString.Split('.');

            return splitValues.Length == 4 && splitValues.All(r => byte.TryParse(r, out _));
        }

        #region StringEnum

        public static string ByteArrayToString(byte[] ba)
        {
            var hex = new StringBuilder(ba.Length * 2);
            foreach (var b in ba)
            {
                hex.AppendFormat("{0:x2}", b);
            }

            return hex.ToString();
        }

        #endregion
    }
}
