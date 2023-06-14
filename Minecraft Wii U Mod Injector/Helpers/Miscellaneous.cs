using System;
using MetroFramework.Controls;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MetroFramework;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
{
    public class Miscellaneous
    {
        public static MainForm Injector = new();
        public static int Read { get; private set; }

        public Miscellaneous(MainForm iw)
        {
            Injector = iw;
        }
        public static void DoHostIndicators(bool enabled)
        {
            foreach (MetroTabPage page in Injector.MainTabs.TabPages)
            foreach (Control c in page.Controls)
            {
                if (!string.IsNullOrWhiteSpace((string)c.Tag))
                    switch (c)
                    {
                        case MetroCheckBox cb:
                        {
                            cb.UseStyleColors = enabled;
                            cb.Style = (string)cb.Tag switch
                            {
                                "Host" => MetroColorStyle.Orange,
                                "NonHost" => MetroColorStyle.Blue,
                                _ => cb.Style
                            };

                            if (!enabled) cb.Style = MetroColorStyle.Default;
                            break;
                        }

                        case MetroLabel lb:
                        {
                            lb.UseStyleColors = enabled;
                            lb.Style = (string)lb.Tag switch
                            {
                                "Host" => MetroColorStyle.Orange,
                                "NonHost" => MetroColorStyle.Blue,
                                _ => lb.Style
                            };

                            if (!enabled) lb.Style = MetroColorStyle.Default;
                            break;
                        }

                        case MetroButton bt:
                        {
                            bt.UseStyleColors = enabled;
                            bt.Style = (string)bt.Tag switch
                            {
                                "Host" => MetroColorStyle.Orange,
                                "NonHost" => MetroColorStyle.Blue,
                                _ => bt.Style
                            };

                            if (!enabled) bt.Style = MetroColorStyle.Default;
                            break;
                        }
                    }

            }

            foreach (MetroTabPage page in Injector.MinigamesTabs.TabPages)
            foreach (Control c in page.Controls)
            {
                if (!string.IsNullOrWhiteSpace((string)c.Tag))
                    switch (c)
                    {
                        case MetroCheckBox cb:
                            cb.UseStyleColors = enabled;
                            cb.Style = (string)cb.Tag switch
                            {
                                "Host" => MetroColorStyle.Orange,
                                "NonHost" => MetroColorStyle.Blue,
                                _ => cb.Style
                            };

                            if (!enabled) cb.Style = MetroColorStyle.Default;
                            break;

                        case MetroLabel lb:
                            lb.UseStyleColors = enabled;
                            lb.Style = (string)lb.Tag switch
                            {
                                "Host" => MetroColorStyle.Orange,
                                "NonHost" => MetroColorStyle.Blue,
                                _ => lb.Style
                            };

                            if (!enabled) lb.Style = MetroColorStyle.Default;
                            break;

                        case MetroButton bt:
                            bt.UseStyleColors = enabled;
                            bt.Style = (string)bt.Tag switch
                            {
                                "Host" => MetroColorStyle.Orange,
                                "NonHost" => MetroColorStyle.Blue,
                                _ => bt.Style
                            };

                            if (!enabled) bt.Style = MetroColorStyle.Default;
                            break;
                    }
            }

            Injector.Refresh();
        }

        public static Encoding GetEncoding(string filename)
        {
            try
            {
                // Read the BOM
                var bom = new byte[4];
                using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    Read = file.Read(bom, 0, 4);
                }

                // Analyze the BOM
                if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
                if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
                if (bom[0] == 0xff && bom[1] == 0xfe && bom[2] == 0 && bom[3] == 0) return Encoding.UTF32; //UTF-32LE
                if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
                if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
                if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff)
                    return new UTF32Encoding(true, true); //UTF-32BE

                return Encoding.ASCII;
            }
            catch (Exception e)
            {
                Exceptions.LogError(e, "Unable to process Encoding type", true);
                return Encoding.ASCII;
            }
        }

        public static void ChangeEncoding(string path, Encoding encoding)
        {
            try
            {
                File.WriteAllText(path, File.ReadAllText(path), encoding);
            }
            catch (Exception e)
            {
                Exceptions.LogError(e, "", true);
            }
        }

        public static void CopyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            var files = Directory.GetFiles(sourceFolder);
            foreach (var file in files)
            {
                var name = Path.GetFileName(file);
                var dest = Path.Combine(destFolder, name);
                File.Copy(file, dest, true);
            }

            var folders = Directory.GetDirectories(sourceFolder);
            foreach (var folder in folders)
            {
                var name = Path.GetFileName(folder);
                var dest = Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
            }
        }

        public static unsafe int FloatToInt32Bits(float f)
        {
            return *((int*)&f);
        }
    }
}
