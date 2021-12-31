using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using MetroFramework.Controls;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class LanguageMngr : MetroForm
    {
        private MainForm _iw;
        private readonly string _langRootDir = Application.StartupPath + @"\Languages\";

        public LanguageMngr(MainForm iw)
        {
            InitializeComponent();
            _iw = iw;
            StyleMngr.Style = this.Style = iw.StyleMngr.Style;
            StyleMngr.Theme = this.Theme = iw.StyleMngr.Theme;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void Init(object sender, EventArgs e)
        {
            if (!Directory.Exists(_langRootDir))
                Directory.CreateDirectory(_langRootDir);

            if (Settings.EqualsTo("SeenLangMngr", "False", "Display") || !Settings.Exists("SeenLangMngr", "Display"))
                Messaging.Show(
                    "Welcome to the language manager, here you can apply or create new language files for the Mod Injector!" +
                    "\nYou are not limited to only making new languages, you can freely customize any text to your liking!");

            Settings.Write("SeenLangMngr", "True", "Display");

            LoadInstalledLangs();

            DiscordRp.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected", "Language Manager");
        }

        private void LoadInstalledLangs()
        {
            var index = 0;
            try
            {
                var files = Directory.GetFiles(_langRootDir);

                if (files.Length <= 0)
                {
                    return;
                }

                LanguagesList.Rows.Add(files.Length);

                foreach (var t in files)
                {
                    var file = new FileInfo(t);
                    var langFile = new IniFile(_langRootDir + file.Name);

                    LanguagesList.Rows[index].Cells[0].Value = langFile.Read("name", "meta");
                    LanguagesList.Rows[index].Cells[1].Value = langFile.Read("description", "meta");
                    LanguagesList.Rows[index].Cells[2].Value = langFile.Read("authors", "meta");
                    LanguagesList.Rows[index].Cells[3].Value = file.FullName;

                    index++;
                }
            }
            catch (Exception e)
            {
                Exceptions.LogError(e, "Failed to load Installed languages", false, true);
            }
        }

        private void ExportTemplateBtnClicked(object sender, EventArgs e)
        {
            var templateFile = new IniFile(_langRootDir + "template.ini");

            templateFile.Write("name", "Template Language", "meta");
            templateFile.Write("authors", "Kashiiera", "meta");
            templateFile.Write("description", "Template Language file to start making a new language file", "meta");

            foreach (var c in Miscellaneous.AllMetroControls())
            {
                templateFile.Write(c.Name, c.Text, "controls");
            }
        }

        private IniFile GetLanguageFile(DataGridViewCellEventArgs e)
        {
            return new(LanguagesList.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void ApplyLanguage(IEnumerable controls, DataGridViewCellEventArgs e, bool excludeMetroTextBox = false)
        {
            var languageFile = GetLanguageFile(e);
            
            foreach (Control control in controls)
            {
                if (excludeMetroTextBox && control is MetroTextBox)
                {
                    continue;
                }

                if (control is MetroButton || control is MetroLabel || control is MetroTextBox || control is MetroTile)
                {
                    control.Text = languageFile.Read(control.Name, "controls");
                }
            }
        }

        private void ApplyLanguage(object sender, DataGridViewCellEventArgs e)
        {
            ApplyLanguage(_iw.Controls, e);

            foreach (MetroTabPage page in _iw.MainTabs.TabPages)
            {
                ApplyLanguage(page.Controls, e, true);
            }

            foreach (MetroTabPage page in _iw.MinigamesTabs.TabPages)
            {
                ApplyLanguage(page.Controls, e);
            }

            var languageFile = GetLanguageFile(e);
            Messaging.Show("Successfully changed language to \"" + languageFile.Read("name", "meta") + "\"!");
        }

        private void DownloadTileClicked(object sender, EventArgs e)
        {
            Messaging.Show("Sorry, currently languages cannot be downloaded since the languages repository has been removed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Process.Start("https://github.com/Kashiiera/Minecraft-Wii-U-Mod-Injector-Languages");
        }

        private void RefreshTileClicked(object sender, EventArgs e)
        {
            if (LanguagesList.Rows.Count > 0)
            {
                LanguagesList.Rows.Clear();
            }

            LoadInstalledLangs();
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRp.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected", "Settings tab");
        }
    }
}
