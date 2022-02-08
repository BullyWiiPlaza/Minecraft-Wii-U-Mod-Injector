using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;

namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods {
    public partial class KeyboardCustomizer : MetroForm {
        public KeyboardCustomizer(MainForm form) {
            InitializeComponent();
            StyleMngr.Style = Style = form.StyleMngr.Style;
            StyleMngr.Theme = Theme = form.StyleMngr.Theme;
        }

        private void OnLoad(object sender, EventArgs e) {
            DiscordRP.SetPresence("Connected", "Keyboard Customizer");
        }

        private void OnExit(object sender, FormClosingEventArgs e) {
            DiscordRP.SetPresence("Connected", $"{new MainForm().MainTabs.SelectedTab.Text} tab");
            Dispose();
        }

        private void ApplyKeyboardChanges(object sender, EventArgs e) {
            foreach (Control txt in metroPanel2.Controls) {
                if (txt is MetroTextBox && String.IsNullOrWhiteSpace(txt.Text)) {
                    MessageBox.Show("One or more of the keys are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                } else {
                    break;
                }
            }
            var str = customKeyQ.Text + customKeyW.Text + customKeyE.Text + customKeyR.Text + customKeyT.Text + customKeyY.Text + customKeyU.Text + customKeyI.Text + customKeyO.Text + customKeyP.Text + customKeyAT.Text + customKeyA.Text + customKeyS.Text + customKeyD.Text + customKeyF.Text + customKeyG.Text + customKeyH.Text + customKeyJ.Text + customKeyK.Text + customKeyL.Text + customKeyApostrophe.Text + customKeyExclamation.Text + customKeyZ.Text + customKeyX.Text + customKeyC.Text + customKeyV.Text + customKeyB.Text + customKeyN.Text + customKeyM.Text + customKeyComma.Text + customKeyPeriod.Text + customKeyQuestion.Text;
            MainForm.GeckoU.WriteString(0x15A64AF8, str, Encoding.BigEndianUnicode);
            MainForm.GeckoU.WriteString(0x15A64BF8, str, Encoding.BigEndianUnicode);
        }

        private void ApplyPhrase(object sender, EventArgs e) {
            MainForm.GeckoU.WriteString(0x15A64AF8, phraseInput.Text, Encoding.BigEndianUnicode);
            MainForm.GeckoU.WriteString(0x15A64BF8, phraseInput.Text, Encoding.BigEndianUnicode);
        }

        private void ResetKeyboard(object sender, EventArgs e) {
            phraseInput.Clear();
            MainForm.GeckoU.WriteString(0x15A64AF8, "qwertyuiop@asdfghjkl'!zxcvbnm,.?", Encoding.BigEndianUnicode);
            MainForm.GeckoU.WriteString(0x15A64BF8, "qwertyuiop@asdfghjkl'!zxcvbnm,.?", Encoding.BigEndianUnicode);
            customKeyQ.Text = "q";
            customKeyW.Text = "w";
            customKeyE.Text = "e";
            customKeyR.Text = "r";
            customKeyT.Text = "t";
            customKeyY.Text = "y";
            customKeyU.Text = "u";
            customKeyI.Text = "i";
            customKeyO.Text = "o";
            customKeyP.Text = "p";
            customKeyAT.Text = "@";
            customKeyA.Text = "a";
            customKeyS.Text = "s";
            customKeyD.Text = "d";
            customKeyF.Text = "f";
            customKeyG.Text = "g";
            customKeyH.Text = "h";
            customKeyJ.Text = "j";
            customKeyK.Text = "k";
            customKeyL.Text = "l";
            customKeyApostrophe.Text = "'";
            customKeyExclamation.Text = "!";
            customKeyZ.Text = "z";
            customKeyX.Text = "x";
            customKeyC.Text = "c";
            customKeyV.Text = "v";
            customKeyB.Text = "b";
            customKeyN.Text = "n";
            customKeyM.Text = "m";
            customKeyComma.Text = ",";
            customKeyPeriod.Text = ".";
            customKeyQuestion.Text = "?";
        }
    }
}
