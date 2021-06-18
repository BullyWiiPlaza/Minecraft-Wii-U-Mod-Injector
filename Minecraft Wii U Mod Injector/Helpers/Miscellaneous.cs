using System;
using MetroFramework.Controls;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;

namespace Minecraft_Wii_U_Mod_Injector.Helpers
{
    public class Miscellaneous
    {
        public static MainForm Injector = new MainForm();

        public Miscellaneous(MainForm iw)
        {
            Injector = iw;
        }

        public static List<Control> AllMetroControls()
        {
            List<Control> controls = new List<Control>();

            foreach (Control c in Injector.Controls)
                if (c is MetroButton || c is MetroLabel || c is MetroTextBox || c is MetroTile)
                    controls.Add(c);

            foreach (MetroTabPage page in Injector.MainTabs.TabPages)
                foreach (Control c in page.Controls)
                    if (c is MetroCheckBox || c is MetroLabel || c is MetroButton)
                        controls.Add(c);

            foreach (MetroTabPage page in Injector.MinigamesTabs.TabPages)
                foreach (Control c in page.Controls)
                    if (c is MetroCheckBox || c is MetroLabel || c is MetroButton)
                        controls.Add(c);

            return controls;
        }

        public static List<Control> AllSliderControls()
        {
            List<Control> controls = new List<Control>();

            foreach (MetroTabPage page in Injector.MainTabs.TabPages)
            foreach (Control c in page.Controls)
                if (c is NumericUpDown)
                    controls.Add(c);

            foreach (MetroTabPage page in Injector.MinigamesTabs.TabPages)
            foreach (Control c in page.Controls)
                if (c is NumericUpDown)
                    controls.Add(c);

            return controls;
        }

        public static Encoding GetEncoding(string filename)
        {
            try
            {
                // Read the BOM
                var bom = new byte[4];
                using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    file.Read(bom, 0, 4);
                }

                // Analyze the BOM
                if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
                if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
                if (bom[0] == 0xff && bom[1] == 0xfe && bom[2] == 0 && bom[3] == 0) return Encoding.UTF32; //UTF-32LE
                if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
                if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
                if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return new UTF32Encoding(true, true);  //UTF-32BE

                return Encoding.ASCII;
            }
            catch (Exception e)
            {
                Exceptions.LogError(e, "Unable to process Encoding type", false);
                return Encoding.ASCII;
            }
        }

        public static void ChangeEncoding(string path, Encoding encoding)
        {
            File.WriteAllText(path, File.ReadAllText(path), encoding);
        }
    }
}
