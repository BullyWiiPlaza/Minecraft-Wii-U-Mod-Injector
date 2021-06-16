using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using MetroFramework.Controls;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;
using Octokit;
using System.Collections.Generic;
using System.Net;
using Application = System.Windows.Forms.Application;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class LanguageMngr : MetroForm
    {
        private readonly MainForm _iw;
        private readonly string _langRootDir = Application.StartupPath + @"\Languages\";

        public static List<string> ServerNames = new();
        public static List<string> ServerUrls = new();

        public LanguageMngr(MainForm iw)
        {
            InitializeComponent();
            _iw = iw;
            StyleMngr.Style = Style = iw.StyleMngr.Style;
            StyleMngr.Theme = Theme = iw.StyleMngr.Theme;
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

        private async void Init(object sender, EventArgs e)
        {
            var index = 0;

            if (!Directory.Exists(_langRootDir))
                Directory.CreateDirectory(_langRootDir);

            if (Settings.EqualsTo("SeenLangMngr", "False", "Display") || !Settings.Exists("SeenLangMngr", "Display"))
                Messaging.Show(
                    "Welcome to the language manager, here you can apply or create new language files for the Mod Injector!" +
                    "\nYou are not limited to only making new languages, you can freely customize any text to your liking as-well as edit control" +
                    "\nproperties such as size and location!");

            Settings.Write("SeenLangMngr", "True", "Display");

            LoadInstalledLangs();

            await RetrieveServerLangs();

            //this whole region could get cleaned up but I'm lazy and don't really care, it works.
            ServerLanguageList.Rows.Add(ServerNames.Count);

            foreach (var a in ServerNames)
            {
                ServerLanguageList.Rows[index].Cells[0].Value = a;
                index++;
            }

            index = 0;

            foreach (var a in ServerUrls)
            {
                ServerLanguageList.Rows[index].Cells[1].Value = a;
                index++;
            }

            DiscordRp.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected", "Language Manager");
        }

        private void SwapTab(object sender, EventArgs e)
        {
            var tile = (MetroTile) sender;

            if (MainTabs.SelectedIndex != tile.TileCount)
                MainTabs.SelectedIndex = tile.TileCount;

            EmptyTile.Text = "Currently Viewing:\n" + MainTabs.SelectedTab.Text;
        }

        public static async Task RetrieveServerLangs()
        {
            try
            {
                var gitClient = new GitHubClient(new ProductHeaderValue("MCWiiUMIClient"));
                var contents = await gitClient.Repository.Content.GetAllContents(
                    "Kashiiera",
                    "Minecraft-Wii-U-Mod-Injector-Languages");

                foreach (var t in contents)
                {
                    ServerNames.Add(t.Name);
                    ServerUrls.Add(t.DownloadUrl);
                }
            }
            catch (Exception error)
            {
                Exceptions.LogError(error,
                    "Something went wrong while retrieving languages files.\n" +
                    "If this issue persist please contact the developers.", false, false);
            }
        }

        private void LoadInstalledLangs()
        {
            var index = 0;
            try
            {
                var files = Directory.GetFiles(_langRootDir);

                if (files.Length <= 0) return;

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

        private void DownloadServerLang(object sender, DataGridViewCellEventArgs e)
        {
            var downloader = new WebClient();

            downloader.DownloadFile((string) ServerLanguageList.Rows[e.RowIndex].Cells[1].Value,
                _langRootDir + (string) ServerLanguageList.Rows[e.RowIndex].Cells[0].Value);

            Messaging.Show("Succesfully downloaded \"" + ServerLanguageList.Rows[e.RowIndex].Cells[0].Value + "\"!");
            downloader.Dispose();
        }

        private void ApplyLanguageBtnClicked(object sender, DataGridViewCellEventArgs e)
        {
            ApplyLanguage(_iw.Controls, e);

            foreach (MetroTabPage page in _iw.MainTabs.TabPages) ApplyLanguage(page.Controls, e, true);

            foreach (MetroTabPage page in _iw.MinigamesTabs.TabPages) ApplyLanguage(page.Controls, e);

            var languageFile = GetLanguageFile(e);
            Messaging.Show("Successfully changed language to \"" + languageFile.Read("name", "meta") + "\"!");
        }

        private void ExportTemplateBtnClicked(object sender, EventArgs e)
        {
            var templateFile = new IniFile(_langRootDir + "template.ini");

            templateFile.Write("name", "Template Language", "meta");
            templateFile.Write("authors", "Kashiiera", "meta");
            templateFile.Write("description", "Template Language file to start making a new language file", "meta");

            foreach (var c in Miscellaneous.AllMetroControls()) templateFile.Write(c.Name, c.Text, "controls");

            if (Messaging.Show(
                "Some controls might overlap if their text is longer than the default." +
                "\nWould you like to export control size and locations too? (so you can fine tune them incase they don't fit)",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                foreach (var c in Miscellaneous.AllMetroControls())
                {
                    templateFile.Write(c.Name + ".sizeWidth", c.Size.Width.ToString(), "controls.properties");
                    templateFile.Write(c.Name + ".sizeHeight", c.Size.Height.ToString(), "controls.properties");
                    templateFile.Write(c.Name + ".locationX", c.Location.X.ToString(), "controls.properties");
                    templateFile.Write(c.Name + ".locationY", c.Location.Y.ToString(), "controls.properties");
                }

            Messaging.Show("Template File has been created in:\n" + _langRootDir + "template.ini");
        }

        private IniFile GetLanguageFile(DataGridViewCellEventArgs e)
        {
            return new(LanguagesList.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private IniFile GetLanguageFile(string filePath)
        {
            return new(filePath);
        }

        public void ApplyLanguage(IEnumerable controls, DataGridViewCellEventArgs e, bool excludeMetroTextBox = false)
        {
            var languageFile = GetLanguageFile(e);

            foreach (Control control in controls)
            {
                if (excludeMetroTextBox && control is MetroTextBox) continue;

                if (control.Name == "BuildTile" || control.Name == "BuildVerTitleLbl") continue;

                if (control is MetroButton || control is MetroLabel || control is MetroTextBox ||
                    control is MetroTile || control is MetroCheckBox)
                {
                    control.Text = languageFile.Read(control.Name, "controls");

                    if (languageFile.KeyExists(control.Name + ".sizeWidth", "controls.properties"))
                        control.Size =
                            new Size(
                                Convert.ToInt32(languageFile.Read(control.Name + ".sizeWidth", "controls.properties")),
                                Convert.ToInt32(languageFile.Read(control.Name + ".sizeHeight",
                                    "controls.properties")));

                    if (languageFile.KeyExists(control.Name + ".locationX", "controls.properties"))
                        control.Location =
                            new Point(
                                Convert.ToInt32(languageFile.Read(control.Name + ".locationX", "controls.properties")),
                                Convert.ToInt32(languageFile.Read(control.Name + ".locationY", "controls.properties")));
                }
            }

            Settings.Write("Language", LanguagesList.Rows[e.RowIndex].Cells[3].Value.ToString(), "Display");
        }

        public void ApplyLanguage(IEnumerable controls, string filePath, bool excludeMetroTextBox = false)
        {
            var languageFile = GetLanguageFile(filePath);

            foreach (Control control in controls)
            {
                if (excludeMetroTextBox && control is MetroTextBox) continue;

                if (control.Name == "BuildTile" || control.Name == "BuildVerTitleLbl") continue;

                if (control is MetroButton || control is MetroLabel || control is MetroTextBox ||
                    control is MetroTile || control is MetroCheckBox)
                {
                    control.Text = languageFile.Read(control.Name, "controls");

                    if (languageFile.KeyExists(control.Name + ".sizeWidth", "controls.properties"))
                        control.Size =
                            new Size(
                                Convert.ToInt32(languageFile.Read(control.Name + ".sizeWidth", "controls.properties")),
                                Convert.ToInt32(languageFile.Read(control.Name + ".sizeHeight",
                                    "controls.properties")));

                    if (languageFile.KeyExists(control.Name + ".locationX", "controls.properties"))
                        control.Location =
                            new Point(
                                Convert.ToInt32(languageFile.Read(control.Name + ".locationX", "controls.properties")),
                                Convert.ToInt32(languageFile.Read(control.Name + ".locationY", "controls.properties")));
                }
            }
        }

        public void ApplyLanguage(string filePath)
        {
            if (filePath == string.Empty || !File.Exists(filePath))
                return;

            ApplyLanguage(_iw.Controls, filePath);

            foreach (MetroTabPage page in _iw.MainTabs.TabPages) ApplyLanguage(page.Controls, filePath);

            foreach (MetroTabPage page in _iw.MinigamesTabs.TabPages) ApplyLanguage(page.Controls, filePath);
        }

        private void RefreshTileClicked(object sender, EventArgs e)
        {
            if (LanguagesList.Rows.Count > 0) LanguagesList.Rows.Clear();

            LoadInstalledLangs();
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            ServerNames.Clear();
            ServerUrls.Clear();
            
            DiscordRp.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected", "Settings tab");
        }
    }
}
