using System;
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
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x02000000;
                return cp;
            }
        }

        private void Init(object sender, EventArgs e)
        {
            if (!Directory.Exists(_langRootDir))
                Directory.CreateDirectory(_langRootDir);

            LoadInstalledLangs();

            DiscordRp.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected", "Language Manager");
        }

        private void LoadInstalledLangs()
        {
            var index = 0;
            try
            {
                var files = Directory.GetFiles(_langRootDir);

                if (files.Length > 0)
                {
                    LanguagesList.Rows.Add(files.Length);

                    foreach (var t in files)
                    {
                        var file = new FileInfo(t);
                        var langFile = new IniFile(_langRootDir + file.Name);

                        LanguagesList.Rows[index].Cells[0].Value = langFile.Read("name", "meta");
                        LanguagesList.Rows[index].Cells[1].Value = langFile.Read("description", "meta");
                        LanguagesList.Rows[index].Cells[2].Value = file.FullName;

                        index++;
                    }
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
            templateFile.Write("description", "Template Language file to start making a new language file", "meta");

            foreach (var c in Miscellaneous.AllMetroControls())
            {
                templateFile.Write(c.Name, c.Text, "controls");
            }
        }

        private void ApplyLanguage(object sender, DataGridViewCellEventArgs e)
        {
            var langFile = new IniFile(LanguagesList.Rows[e.RowIndex].Cells[2].Value.ToString());

            foreach (Control c in _iw.Controls)
            {
                if (c is MetroButton || c is MetroLabel || c is MetroTextBox || c is MetroTile)
                {
                    c.Text = langFile.Read(c.Name, "controls");
                }
            }

            foreach (MetroTabPage page in _iw.MainTabs.TabPages)
            {
                foreach (Control c in page.Controls)
                {
                    if (c is MetroCheckBox || c is MetroButton || c is MetroLabel)
                    {
                        c.Text = langFile.Read(c.Name, "controls");
                    }
                }
            }

            foreach (MetroTabPage page in _iw.MinigamesTabs.TabPages)
            {
                foreach (Control c in page.Controls)
                {
                    if (c is MetroCheckBox || c is MetroLabel || c is MetroButton)
                    {
                        c.Text = langFile.Read(c.Name, "controls");
                    }
                }
            }

            Messaging.Show("Succesfully changed language to \"" + langFile.Read("name", "meta") + "\"!");
        }
    }
}
