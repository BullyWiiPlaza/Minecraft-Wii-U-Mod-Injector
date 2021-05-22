using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Minecraft_Wii_U_Mod_Injector.helpers
{
    class StringUtils
    {
        public static string Shuffle(string str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }

        public static string HexIt(string yourString)
        {
            byte[] ba = Encoding.Default.GetBytes(yourString);
            var hexString = BitConverter.ToString(ba);
            hexString = hexString.Replace("-", "");
            return hexString;
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length / 2;
            byte[] bytes = new byte[NumberChars];
            using (var sr = new System.IO.StringReader(hex))
            {
                for (int i = 0; i < NumberChars; i++)
                    bytes[i] =
                      Convert.ToByte(new string(new char[2] { (char)sr.Read(), (char)sr.Read() }), 16);
            }
            return bytes;
        }

        public static string InsertStrings(string s, int insertEvery, string insert)
        {
            char[] ins = s.ToCharArray();
            char[] inserts = insert.ToCharArray();
            int insertLength = inserts.Length;
            int length = s.Length + (s.Length / insertEvery) * insert.Length;
            if (ins.Length % insertEvery == 0)
            {
                length -= insert.Length;
            }
            var outs = new char[length];
            long di = 0;
            long si = 0;
            while (si < s.Length - insertEvery)
            {
                Array.Copy(ins, si, outs, di, insertEvery);
                si += insertEvery;
                di += insertEvery;
                Array.Copy(inserts, 0, outs, di, insertLength);
                di += insertLength;
            }
            Array.Copy(ins, si, outs, di, ins.Length - si);
            return new string(outs);
        }

        public static bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
                return false;

            if (ipString == "127.0.0.1")
                return false;

            string[] splitValues = ipString.Split('.');

            if (splitValues.Length != 4)
                return false;

            return splitValues.All(r => byte.TryParse(r, out byte tempForParsing));
        }

        #region StringEnum
        public class StringValue : System.Attribute
        {
            private readonly string _value;

            public StringValue(string value)
            {
                _value = value;
            }

            public string Value
            {
                get { return _value; }
            }

        }

        public static string GetStringValue(Enum value)
        {
            string output = null;
            Type type = value.GetType();

            FieldInfo fi = type.GetField(value.ToString());
            StringValue[] attrs =
               fi.GetCustomAttributes(typeof(StringValue),
                                       false) as StringValue[];
            if (attrs.Length > 0)
                output = attrs[0].Value;

            return output;
        }

        public static object Parse(Type type, string stringValue, bool ignoreCase)
        {
            object output = null;
            string enumStringValue = null;

            if (!type.IsEnum)
                throw new ArgumentException(String.Format("Supplied type must be an Enum.  Type was {0}", type.ToString()));

            foreach (FieldInfo fi in type.GetFields())
            {
                StringValue[] attrs = fi.GetCustomAttributes(typeof(StringValue), false) as StringValue[];
                if (attrs.Length > 0)
                    enumStringValue = attrs[0].Value;

                if (string.Compare(enumStringValue, stringValue, ignoreCase) == 0)
                {
                    output = Enum.Parse(type, fi.Name);
                    break;
                }
            }

            return output;
        }
        #endregion
    }
}
