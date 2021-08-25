using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using MetroFramework.Controls;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;
using System.Text;
using Application = System.Windows.Forms.Application;
using System.Diagnostics;
using Minecraft_Wii_U_Mod_Injector.Properties;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    /*TODO - Quick Mods Manager
    I wrote alot of this while on basically no sleep, this could all use a clean up and use ALOT of improvements so if anyone is up to do that,
    feel free to :) - Kiera
    */
    public partial class QuickModsMngr : MetroForm
    {
        #region references

        private readonly MainForm _iw;
        private readonly string _qmmRootDir = Application.StartupPath + @"\Saved\QuickMods\";

        #endregion

        #region init

        public QuickModsMngr(MainForm iw)
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

        private void Init(object sender, EventArgs e)
        {
            if (!Directory.Exists(_qmmRootDir))
                Directory.CreateDirectory(_qmmRootDir);

            if (!Settings.Default.SeenQmmMngr)
                Messaging.Show(
                    "Welcome to the Quick Mods Manager!\nQuick Mods are basically mod presets, you activate a quick mod and it activates a bunch of mods within that" +
                    " preset.\nThis is useful for whenever you want to activate a large amount of mods at once. Have fun!");

            Settings.Default.SeenQmmMngr = true;

            LoadInstalledQmms();

            foreach (MetroTabPage page in _iw.MainTabs.TabPages)
            {
                if (page.Name == "settingsTab") continue;

                PopulateModsList(page);
            }

            foreach (MetroTabPage page in _iw.MinigamesTabs.TabPages) PopulateModsList(page);

            DiscordRp.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected",
                "Quick Mods Manager - Browsing Quick Mods");
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRp.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected", _iw.MainTabs.SelectedTab.Text + " tab");
        }

        #endregion

        #region control handlers

        private void PopulateModsList(MetroTabPage page)
        {
            var controlList = new List<Control>();

            foreach (Control c in page.Controls)
            {
                var newBox = new MetroCheckBox();
                if (c is MetroCheckBox)
                {
                    newBox.Text = c.Text;
                    newBox.Name = c.Name;
                    newBox.AutoSize = true;
                    newBox.Theme = Theme;
                    newBox.Style = Style;
                    controlList.Add(newBox);
                }
            }

            qmmModsList.Controls.AddRange(controlList.ToArray());
        }

        private void SwapTab(object sender, EventArgs e)
        {
            var tile = (MetroTile) sender;

            if (MainTabs.SelectedIndex != tile.TileCount)
                MainTabs.SelectedIndex = tile.TileCount;

            if (MainTabs.SelectedIndex == 0)
            {
                qmmNameBox.Text = string.Empty;
                qmmAuthBox.Text = string.Empty;
                qmmDescBox.Text = string.Empty;

                foreach (MetroCheckBox c in qmmModsList.Controls) c.Checked = false;

                RefreshTileClicked(null, null);
            }

            if (tile.TileCount == 0)
                DiscordRp.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected",
                    "Quick Mods Manager - Browsing Quick Mods");
            else
                DiscordRp.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected",
                    "Quick Mods Manager - Making a new Quick Mod");

            EmptyTile.Text = @"Currently Viewing:
" + MainTabs.SelectedTab.Text;
        }

        private void ApplyQmmBtnClicked(object sender, DataGridViewCellEventArgs e)
        {
            var filePath = QuickModsList.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (!_iw.IsConnected)
            {
                Messaging.Show(
                    "Quick Mods can only be activated once you are connected to your Wii U, please do so and try again.");
                return;
            }

            if (!Equals(Miscellaneous.GetEncoding(filePath), Encoding.Unicode))
                Miscellaneous.ChangeEncoding(filePath, Encoding.Unicode);

            foreach (MetroTabPage page in _iw.MainTabs.TabPages) ApplyQmm(page.Controls, e);
            foreach (MetroTabPage page in _iw.MinigamesTabs.TabPages) ApplyQmm(page.Controls, e);

            Messaging.Show("Successfully applied " + QuickModsList.Rows[e.RowIndex].Cells[0].Value + "!");
        }

        private void RefreshTileClicked(object sender, EventArgs e)
        {
            if (QuickModsList.Rows.Count > 0) QuickModsList.Rows.Clear();

            LoadInstalledQmms();
        }

        private void OpenTileClicked(object sender, EventArgs e)
        {
            if(Directory.Exists(_qmmRootDir))
                Process.Start(_qmmRootDir);
        }

        #endregion

        #region qmm functions

        private IniFile GetQmmFile(DataGridViewCellEventArgs e)
        {
            return new IniFile(QuickModsList.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void LoadInstalledQmms()
        {
            var index = 0;
            try
            {
                var files = Directory.GetFiles(_qmmRootDir);

                if (files.Length <= 0) return;

                QuickModsList.Rows.Add(files.Length);

                foreach (var t in files)
                {
                    var file = new FileInfo(t);
                    var langFile = new IniFile(_qmmRootDir + file.Name);

                    QuickModsList.Rows[index].Cells[0].Value = langFile.Read("name", "meta");
                    QuickModsList.Rows[index].Cells[1].Value = langFile.Read("desc", "meta");
                    QuickModsList.Rows[index].Cells[2].Value = langFile.Read("author", "meta");
                    QuickModsList.Rows[index].Cells[3].Value = file.FullName;

                    index++;
                }
            }
            catch (Exception e)
            {
                Exceptions.LogError(e, "Failed to load Installed Quick Mods", true);
            }
        }

        public void ApplyQmm(IEnumerable controls, DataGridViewCellEventArgs e)
        {
            var qmmFile = GetQmmFile(e);

            foreach (Control control in controls)
            {
                if (!qmmFile.KeyExists(control.Name, "controls")) continue;

                if (control is MetroCheckBox c)
                    c.Checked = Convert.ToBoolean(qmmFile.Read(control.Name, "controls"));
            }
        }

        public void UndoQmm(IEnumerable controls)
        {
            foreach (Control control in controls)
            {
                if (control is MetroCheckBox c)
                    c.Checked = false;
            }
        }

        private void SaveQm(object sender, EventArgs e)
        {
            try
            {
                var quickMod = new IniFile(_qmmRootDir + qmmNameBox.Text + ".ini");

                quickMod.Write("name", qmmNameBox.Text, "meta");
                quickMod.Write("desc", qmmDescBox.Text, "meta");
                quickMod.Write("author", qmmAuthBox.Text, "meta");

                foreach (Control c in qmmModsList.Controls)
                    if (c is MetroCheckBox b)
                        quickMod.Write(c.Name, b.Checked.ToString(), "controls");

                Messaging.Show("Successfully saved \"" + qmmNameBox.Text + "\"!");

                SwapTab(InstalledTile, null);
            }
            catch (Exception exception)
            {
                Exceptions.LogError(exception, "Failed to save Quick Mod", true);
                throw;
            }
        }
        #endregion

        #region right click menu

        private void Creator(IniFile file)
        {
            SwapTab(CreatorTile, null);

            DiscordRp.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected",
                "Quick Mods Manager - Editing " + file.Read("name", "meta"));

            qmmNameBox.Text = file.Read("name", "meta");
            qmmAuthBox.Text = file.Read("author", "meta");
            qmmDescBox.Text = file.Read("desc", "meta");

            foreach (MetroCheckBox c in qmmModsList.Controls)
                if (file.KeyExists(c.Name))
                    c.Checked = Convert.ToBoolean(file.Read(c.Name, "controls"));
                else c.Checked = false;
        }

        private void OpenQmmMenu(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
                if (e.Button == MouseButtons.Right)
                {
                    var clickedCell = (sender as DataGridView)?.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    QuickModsList.CurrentCell = clickedCell;
                    var relativeMousePosition = QuickModsList.PointToClient(Cursor.Position);

                    qmmMenu.Show(QuickModsList, relativeMousePosition);
                }
        }

        private void QmmMenuHandler(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == editQmmBtn)
                if (QuickModsList.CurrentRow != null)
                {
                    var qmmFile =
                        new IniFile((string) QuickModsList.Rows[QuickModsList.CurrentRow.Index].Cells[3].Value);
                    Creator(qmmFile);
                }

            if (e.ClickedItem == deleteQmmBtn)
                if (QuickModsList.CurrentRow != null)
                {
                    var confirmation = Messaging.Show("Are you sure you want to delete this Quick Mod?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                        File.Delete((string) QuickModsList.Rows[QuickModsList.CurrentRow.Index].Cells[3].Value);

                    RefreshTileClicked(null, null);
                }

            if (e.ClickedItem == undoQmmBtn)
            {
                foreach (MetroTabPage page in _iw.MainTabs.TabPages) UndoQmm(page.Controls);
                foreach (MetroTabPage page in _iw.MinigamesTabs.TabPages) UndoQmm(page.Controls);
                Messaging.Show("Quick Mod has been undone!");
            }
        }
        #endregion
    }
}