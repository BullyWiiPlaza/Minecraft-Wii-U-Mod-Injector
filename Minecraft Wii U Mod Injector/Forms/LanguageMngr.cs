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
using System.Linq;
using System.Net;
using System.Text;
using Application = System.Windows.Forms.Application;
using System.Diagnostics;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class LanguageMngr : MetroForm
    {
        #region references
        private readonly MainForm _iw;
        private readonly string _langRootDir = Application.StartupPath + @"\Languages\";

        public static List<string> ServerNames = new List<string>();
        public static List<string> ServerUrls = new List<string>();

        public string[] BlackList = {"BuildTile", "BuildVerTitleLbl"};
        #endregion

        #region init
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

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            ServerNames.Clear();
            ServerUrls.Clear();

            DiscordRp.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected", "Settings tab");
        }
        #endregion

        #region control handlers

        private void SwapTab(object sender, EventArgs e)
        {
            var tile = (MetroTile) sender;

            if (MainTabs.SelectedIndex != tile.TileCount)
                MainTabs.SelectedIndex = tile.TileCount;

            EmptyTile.Text = @"Currently Viewing:
" + MainTabs.SelectedTab.Text;
        }

        private void ApplyLanguageBtnClicked(object sender, DataGridViewCellEventArgs e)
        {
            string filePath = LanguagesList.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (!GetLanguageFile(e).KeyExists("version", "meta") || GetLanguageFile(e).Read("version", "meta") != Setup.LocalVer)
            {
                if (Messaging.Show(
                    "This Language has last been modified for a different version of the Mod Injector, do you still want to apply?\n" +
                    "(Some things may not be translated/have broken positioning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            if (!Equals(Miscellaneous.GetEncoding(filePath), Encoding.Unicode)) 
                Miscellaneous.ChangeEncoding(filePath, Encoding.Unicode);

            ApplyLanguage(_iw.Controls, e);

            foreach (MetroTabPage page in _iw.MainTabs.TabPages) ApplyLanguage(page.Controls, e);
            foreach (MetroTabPage page in _iw.MinigamesTabs.TabPages) ApplyLanguage(page.Controls, e);

            Messaging.Show("Language has been changed to " + LanguagesList.Rows[e.RowIndex].Cells[0].Value);
        }

        private void DownloadServerLang(object sender, DataGridViewCellEventArgs e)
        {
            var downloader = new WebClient();

            downloader.DownloadFile((string) ServerLanguageList.Rows[e.RowIndex].Cells[1].Value,
                _langRootDir + (string) ServerLanguageList.Rows[e.RowIndex].Cells[0].Value);

            Messaging.Show(ServerLanguageList.Rows[e.RowIndex].Cells[0].Value + " has been downloaded.");
            downloader.Dispose();
        }

        private void ExportTemplateBtnClicked(object sender, EventArgs e)
        {
            var templateFile = new IniFile(_langRootDir + "template.ini");

            templateFile.Write("name", "Template Language", "meta");
            templateFile.Write("authors", "Kashiiera", "meta");
            templateFile.Write("description", "Template Language file to start making a new language file", "meta");
            templateFile.Write("version", Setup.LocalVer, "meta");

            foreach (var c in Miscellaneous.AllMetroControls()) templateFile.Write(c.Name, c.Text, "controls");

            if (Messaging.Show(
                "Some controls might overlap if their text is longer than the default." +
                "\nWould you like to export control size and locations too? (so you can fine tune them in-case they don't fit)",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                foreach (var c in Miscellaneous.AllMetroControls())
                {
                    templateFile.Write(c.Name + ".sizeWidth", c.Size.Width.ToString(), "controls.properties");
                    templateFile.Write(c.Name + ".sizeHeight", c.Size.Height.ToString(), "controls.properties");
                    templateFile.Write(c.Name + ".locationX", c.Location.X.ToString(), "controls.properties");
                    templateFile.Write(c.Name + ".locationY", c.Location.Y.ToString(), "controls.properties");
                }

            foreach (var c in Miscellaneous.AllSliderControls())
            {
                templateFile.Write(c.Name + ".sizeWidth", c.Size.Width.ToString(), "controls.properties");
                templateFile.Write(c.Name + ".locationX", c.Location.X.ToString(), "controls.properties");
                templateFile.Write(c.Name + ".locationY", c.Location.Y.ToString(), "controls.properties");
            }

            Messaging.Show("Template File has been created in:\n" + _langRootDir + "template.ini");
        }

        private void RefreshTileClicked(object sender, EventArgs e)
        {
            if (LanguagesList.Rows.Count > 0) LanguagesList.Rows.Clear();

            LoadInstalledLangs();
        }

        private void OpenTileClicked(object sender, EventArgs e)
        {
            Process.Start(_langRootDir);
        }
        #endregion

        #region language functions

        private IniFile GetLanguageFile(DataGridViewCellEventArgs e)
        {
            return new IniFile(LanguagesList.Rows[e.RowIndex].Cells[3].Value.ToString());
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
                Exceptions.LogError(e, "Failed to load Installed languages", true);
            }

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
                    "If this issue persist please contact the developers.", true);
            }
        }

        public void ApplyLanguage(IEnumerable controls, DataGridViewCellEventArgs e)
        {
            var languageFile = GetLanguageFile(e);

            foreach (Control control in controls)
            {
                if (BlackList.Contains(control.Name)) continue;

                if (!languageFile.KeyExists(control.Name, "controls")) continue;

                if (control is MetroButton || control is MetroLabel || control is MetroTile || control is MetroCheckBox)
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

        #endregion
    }
}