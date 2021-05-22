using MetroFramework.Controls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector.helpers
{
    public class Miscellaneous
    {
        public static MainForm Injector = new MainForm();

        public Miscellaneous(MainForm IW)
        {
            Injector = IW;
        }

        public static List<Control> AllMetroControls()
        {
            List<Control> Controls = new List<Control>();

            foreach (Control C in Injector.Controls)
                if (C is MetroButton || C is MetroLabel || C is MetroTextBox || C is MetroTile)
                    Controls.Add(C);

            foreach (MetroTabPage Page in Injector.MainTabs.TabPages)
                foreach (Control C in Page.Controls)
                    if (C is MetroCheckBox || C is MetroLabel || C is MetroButton)
                        Controls.Add(C);

            foreach (MetroTabPage Page in Injector.MinigamesTabs.TabPages)
                foreach (Control C in Page.Controls)
                    if (C is MetroCheckBox || C is MetroLabel || C is MetroButton)
                        Controls.Add(C);

            return Controls;
        }
    }
}
