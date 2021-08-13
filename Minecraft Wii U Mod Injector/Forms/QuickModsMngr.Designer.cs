namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    partial class QuickModsMngr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickModsMngr));
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.QuickModsList = new MetroFramework.Controls.MetroGrid();
            this.NameBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIlePathBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qmmMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.editQmmBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteQmmBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.CreatorTile = new MetroFramework.Controls.MetroTile();
            this.RefreshTile = new MetroFramework.Controls.MetroTile();
            this.EmptyTile = new MetroFramework.Controls.MetroTile();
            this.ToolTips = new MetroFramework.Components.MetroToolTip();
            this.InstalledTile = new MetroFramework.Controls.MetroTile();
            this.OpenTile = new MetroFramework.Controls.MetroTile();
            this.MainTabs = new MetroFramework.Controls.MetroTabControl();
            this.QuickModsTab = new MetroFramework.Controls.MetroTabPage();
            this.CreatorTab = new MetroFramework.Controls.MetroTabPage();
            this.SaveQMBtn = new MetroFramework.Controls.MetroButton();
            this.qmmModsList = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.qmmDescBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.qmmAuthBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.qmmNameBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.StyleExt = new MetroFramework.Components.MetroStyleExtender(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuickModsList)).BeginInit();
            this.qmmMenu.SuspendLayout();
            this.MainTabs.SuspendLayout();
            this.QuickModsTab.SuspendLayout();
            this.CreatorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            // 
            // QuickModsList
            // 
            this.QuickModsList.AllowUserToAddRows = false;
            this.QuickModsList.AllowUserToDeleteRows = false;
            this.QuickModsList.AllowUserToResizeRows = false;
            this.QuickModsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QuickModsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuickModsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.QuickModsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuickModsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.QuickModsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuickModsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameBox,
            this.DescriptionBox,
            this.AuthorBox,
            this.FIlePathBox});
            this.QuickModsList.ContextMenuStrip = this.qmmMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QuickModsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.QuickModsList.EnableHeadersVisualStyles = false;
            this.QuickModsList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.QuickModsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QuickModsList.Location = new System.Drawing.Point(-2, 1);
            this.QuickModsList.Name = "QuickModsList";
            this.QuickModsList.ReadOnly = true;
            this.QuickModsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuickModsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.QuickModsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.QuickModsList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuickModsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuickModsList.ShowCellErrors = false;
            this.QuickModsList.ShowEditingIcon = false;
            this.QuickModsList.ShowRowErrors = false;
            this.QuickModsList.Size = new System.Drawing.Size(942, 432);
            this.QuickModsList.TabIndex = 2;
            this.QuickModsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApplyQmmBtnClicked);
            this.QuickModsList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OpenQmmMenu);
            // 
            // NameBox
            // 
            this.NameBox.HeaderText = "Name";
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameBox.Width = 200;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionBox.HeaderText = "Description";
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ReadOnly = true;
            this.DescriptionBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DescriptionBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AuthorBox
            // 
            this.AuthorBox.HeaderText = "Author(\'s)";
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.ReadOnly = true;
            this.AuthorBox.Width = 200;
            // 
            // FIlePathBox
            // 
            this.FIlePathBox.HeaderText = "File Path";
            this.FIlePathBox.Name = "FIlePathBox";
            this.FIlePathBox.ReadOnly = true;
            this.FIlePathBox.Visible = false;
            // 
            // qmmMenu
            // 
            this.qmmMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.qmmMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.qmmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editQmmBtn,
            this.deleteQmmBtn});
            this.qmmMenu.Name = "qmmMenu";
            this.qmmMenu.Size = new System.Drawing.Size(108, 48);
            this.qmmMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.QmmMenuHandler);
            // 
            // editQmmBtn
            // 
            this.editQmmBtn.Image = global::Minecraft_Wii_U_Mod_Injector.Properties.Resources.EditBtn;
            this.editQmmBtn.Name = "editQmmBtn";
            this.editQmmBtn.ShortcutKeyDisplayString = "";
            this.editQmmBtn.Size = new System.Drawing.Size(107, 22);
            this.editQmmBtn.Text = "Edit";
            // 
            // deleteQmmBtn
            // 
            this.deleteQmmBtn.Image = global::Minecraft_Wii_U_Mod_Injector.Properties.Resources.DeleteBtn;
            this.deleteQmmBtn.Name = "deleteQmmBtn";
            this.deleteQmmBtn.Size = new System.Drawing.Size(107, 22);
            this.deleteQmmBtn.Text = "Delete";
            // 
            // CreatorTile
            // 
            this.CreatorTile.ActiveControl = null;
            this.CreatorTile.Location = new System.Drawing.Point(0, 129);
            this.CreatorTile.Name = "CreatorTile";
            this.CreatorTile.PaintTileCount = false;
            this.CreatorTile.Size = new System.Drawing.Size(169, 60);
            this.CreatorTile.TabIndex = 47;
            this.CreatorTile.Text = "Quick Mod Creator";
            this.CreatorTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreatorTile.TileCount = 1;
            this.CreatorTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ToolTips.SetToolTip(this.CreatorTile, "Opens the Quick Mod Creator");
            this.CreatorTile.UseSelectable = true;
            this.CreatorTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // RefreshTile
            // 
            this.RefreshTile.ActiveControl = null;
            this.RefreshTile.Location = new System.Drawing.Point(0, 189);
            this.RefreshTile.Name = "RefreshTile";
            this.RefreshTile.PaintTileCount = false;
            this.RefreshTile.Size = new System.Drawing.Size(169, 60);
            this.RefreshTile.TabIndex = 53;
            this.RefreshTile.Text = "Refresh";
            this.RefreshTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefreshTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ToolTips.SetToolTip(this.RefreshTile, "Refreshes the Quick Mods List");
            this.RefreshTile.UseSelectable = true;
            this.RefreshTile.Click += new System.EventHandler(this.RefreshTileClicked);
            // 
            // EmptyTile
            // 
            this.EmptyTile.ActiveControl = null;
            this.EmptyTile.Enabled = false;
            this.EmptyTile.Location = new System.Drawing.Point(0, 309);
            this.EmptyTile.Name = "EmptyTile";
            this.EmptyTile.PaintTileCount = false;
            this.EmptyTile.Size = new System.Drawing.Size(169, 196);
            this.EmptyTile.TabIndex = 54;
            this.EmptyTile.Text = "Currently Viewing:\r\nAvailable Quick Mods\r\n\r\n";
            this.EmptyTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EmptyTile.UseSelectable = true;
            // 
            // ToolTips
            // 
            this.ToolTips.Style = MetroFramework.MetroColorStyle.Default;
            this.ToolTips.StyleManager = null;
            this.ToolTips.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // InstalledTile
            // 
            this.InstalledTile.ActiveControl = null;
            this.InstalledTile.Location = new System.Drawing.Point(0, 69);
            this.InstalledTile.Name = "InstalledTile";
            this.InstalledTile.PaintTileCount = false;
            this.InstalledTile.Size = new System.Drawing.Size(169, 60);
            this.InstalledTile.TabIndex = 56;
            this.InstalledTile.Text = "Available Quick Mods";
            this.InstalledTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InstalledTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ToolTips.SetToolTip(this.InstalledTile, "Views currently installed Quick Mods");
            this.InstalledTile.UseSelectable = true;
            this.InstalledTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // OpenTile
            // 
            this.OpenTile.ActiveControl = null;
            this.OpenTile.Location = new System.Drawing.Point(0, 249);
            this.OpenTile.Name = "OpenTile";
            this.OpenTile.PaintTileCount = false;
            this.OpenTile.Size = new System.Drawing.Size(169, 60);
            this.OpenTile.TabIndex = 57;
            this.OpenTile.Text = "Open Directory";
            this.OpenTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ToolTips.SetToolTip(this.OpenTile, "Opens the Quick Mods directory");
            this.OpenTile.UseSelectable = true;
            this.OpenTile.Click += new System.EventHandler(this.OpenTileClicked);
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.QuickModsTab);
            this.MainTabs.Controls.Add(this.CreatorTab);
            this.MainTabs.ItemSize = new System.Drawing.Size(473, 1);
            this.MainTabs.Location = new System.Drawing.Point(175, 67);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 1;
            this.MainTabs.Size = new System.Drawing.Size(950, 438);
            this.MainTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabs.TabIndex = 55;
            this.MainTabs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainTabs.UseSelectable = true;
            // 
            // QuickModsTab
            // 
            this.QuickModsTab.Controls.Add(this.QuickModsList);
            this.QuickModsTab.HorizontalScrollbarBarColor = true;
            this.QuickModsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.QuickModsTab.HorizontalScrollbarSize = 10;
            this.QuickModsTab.Location = new System.Drawing.Point(4, 5);
            this.QuickModsTab.Name = "QuickModsTab";
            this.QuickModsTab.Size = new System.Drawing.Size(942, 429);
            this.QuickModsTab.TabIndex = 0;
            this.QuickModsTab.Text = "Available Quick Mods";
            this.QuickModsTab.VerticalScrollbarBarColor = true;
            this.QuickModsTab.VerticalScrollbarHighlightOnWheel = false;
            this.QuickModsTab.VerticalScrollbarSize = 10;
            // 
            // CreatorTab
            // 
            this.CreatorTab.Controls.Add(this.SaveQMBtn);
            this.CreatorTab.Controls.Add(this.qmmModsList);
            this.CreatorTab.Controls.Add(this.metroLabel4);
            this.CreatorTab.Controls.Add(this.qmmDescBox);
            this.CreatorTab.Controls.Add(this.metroLabel3);
            this.CreatorTab.Controls.Add(this.qmmAuthBox);
            this.CreatorTab.Controls.Add(this.metroLabel2);
            this.CreatorTab.Controls.Add(this.qmmNameBox);
            this.CreatorTab.Controls.Add(this.metroLabel1);
            this.CreatorTab.HorizontalScrollbarBarColor = true;
            this.CreatorTab.HorizontalScrollbarHighlightOnWheel = false;
            this.CreatorTab.HorizontalScrollbarSize = 10;
            this.CreatorTab.Location = new System.Drawing.Point(4, 5);
            this.CreatorTab.Name = "CreatorTab";
            this.CreatorTab.Size = new System.Drawing.Size(942, 429);
            this.CreatorTab.TabIndex = 1;
            this.CreatorTab.Text = "Quick Mod Creator";
            this.CreatorTab.VerticalScrollbarBarColor = true;
            this.CreatorTab.VerticalScrollbarHighlightOnWheel = false;
            this.CreatorTab.VerticalScrollbarSize = 10;
            // 
            // SaveQMBtn
            // 
            this.SaveQMBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveQMBtn.Location = new System.Drawing.Point(86, 391);
            this.SaveQMBtn.Name = "SaveQMBtn";
            this.SaveQMBtn.Size = new System.Drawing.Size(832, 35);
            this.SaveQMBtn.TabIndex = 10;
            this.SaveQMBtn.Text = "Save";
            this.SaveQMBtn.UseSelectable = true;
            this.SaveQMBtn.Click += new System.EventHandler(this.SaveQm);
            // 
            // qmmModsList
            // 
            this.StyleExt.SetApplyMetroTheme(this.qmmModsList, true);
            this.qmmModsList.AutoScroll = true;
            this.qmmModsList.Location = new System.Drawing.Point(86, 97);
            this.qmmModsList.Name = "qmmModsList";
            this.qmmModsList.Size = new System.Drawing.Size(832, 288);
            this.qmmModsList.TabIndex = 9;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 97);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Mods:";
            // 
            // qmmDescBox
            // 
            // 
            // 
            // 
            this.qmmDescBox.CustomButton.Image = null;
            this.qmmDescBox.CustomButton.Location = new System.Drawing.Point(810, 1);
            this.qmmDescBox.CustomButton.Name = "";
            this.qmmDescBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.qmmDescBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.qmmDescBox.CustomButton.TabIndex = 1;
            this.qmmDescBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.qmmDescBox.CustomButton.UseSelectable = true;
            this.qmmDescBox.CustomButton.Visible = false;
            this.qmmDescBox.Lines = new string[0];
            this.qmmDescBox.Location = new System.Drawing.Point(86, 68);
            this.qmmDescBox.MaxLength = 32767;
            this.qmmDescBox.Name = "qmmDescBox";
            this.qmmDescBox.PasswordChar = '\0';
            this.qmmDescBox.WaterMark = "This is my awesome quick mod";
            this.qmmDescBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.qmmDescBox.SelectedText = "";
            this.qmmDescBox.SelectionLength = 0;
            this.qmmDescBox.SelectionStart = 0;
            this.qmmDescBox.ShortcutsEnabled = true;
            this.qmmDescBox.Size = new System.Drawing.Size(832, 23);
            this.qmmDescBox.TabIndex = 7;
            this.qmmDescBox.UseSelectable = true;
            this.qmmDescBox.WaterMark = "This is my awesome quick mod";
            this.qmmDescBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.qmmDescBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 68);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Description:";
            // 
            // qmmAuthBox
            // 
            // 
            // 
            // 
            this.qmmAuthBox.CustomButton.Image = null;
            this.qmmAuthBox.CustomButton.Location = new System.Drawing.Point(810, 1);
            this.qmmAuthBox.CustomButton.Name = "";
            this.qmmAuthBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.qmmAuthBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.qmmAuthBox.CustomButton.TabIndex = 1;
            this.qmmAuthBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.qmmAuthBox.CustomButton.UseSelectable = true;
            this.qmmAuthBox.CustomButton.Visible = false;
            this.qmmAuthBox.Lines = new string[0];
            this.qmmAuthBox.Location = new System.Drawing.Point(86, 39);
            this.qmmAuthBox.MaxLength = 32767;
            this.qmmAuthBox.Name = "qmmAuthBox";
            this.qmmAuthBox.PasswordChar = '\0';
            this.qmmAuthBox.WaterMark = "Me";
            this.qmmAuthBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.qmmAuthBox.SelectedText = "";
            this.qmmAuthBox.SelectionLength = 0;
            this.qmmAuthBox.SelectionStart = 0;
            this.qmmAuthBox.ShortcutsEnabled = true;
            this.qmmAuthBox.Size = new System.Drawing.Size(832, 23);
            this.qmmAuthBox.TabIndex = 5;
            this.qmmAuthBox.UseSelectable = true;
            this.qmmAuthBox.WaterMark = "Me";
            this.qmmAuthBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.qmmAuthBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 39);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Author:";
            // 
            // qmmNameBox
            // 
            // 
            // 
            // 
            this.qmmNameBox.CustomButton.Image = null;
            this.qmmNameBox.CustomButton.Location = new System.Drawing.Point(810, 1);
            this.qmmNameBox.CustomButton.Name = "";
            this.qmmNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.qmmNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.qmmNameBox.CustomButton.TabIndex = 1;
            this.qmmNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.qmmNameBox.CustomButton.UseSelectable = true;
            this.qmmNameBox.CustomButton.Visible = false;
            this.qmmNameBox.Lines = new string[0];
            this.qmmNameBox.Location = new System.Drawing.Point(86, 10);
            this.qmmNameBox.MaxLength = 32767;
            this.qmmNameBox.Name = "qmmNameBox";
            this.qmmNameBox.PasswordChar = '\0';
            this.qmmNameBox.WaterMark = "My awesome quick mod";
            this.qmmNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.qmmNameBox.SelectedText = "";
            this.qmmNameBox.SelectionLength = 0;
            this.qmmNameBox.SelectionStart = 0;
            this.qmmNameBox.ShortcutsEnabled = true;
            this.qmmNameBox.Size = new System.Drawing.Size(832, 23);
            this.qmmNameBox.TabIndex = 3;
            this.qmmNameBox.UseSelectable = true;
            this.qmmNameBox.WaterMark = "My awesome quick mod";
            this.qmmNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.qmmNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Name:";
            // 
            // QuickModsMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 505);
            this.Controls.Add(this.OpenTile);
            this.Controls.Add(this.InstalledTile);
            this.Controls.Add(this.RefreshTile);
            this.Controls.Add(this.CreatorTile);
            this.Controls.Add(this.MainTabs);
            this.Controls.Add(this.EmptyTile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuickModsMngr";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Minecraft: Wii U Mod Injector - Quick Mods Manager";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exiting);
            this.Load += new System.EventHandler(this.Init);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuickModsList)).EndInit();
            this.qmmMenu.ResumeLayout(false);
            this.MainTabs.ResumeLayout(false);
            this.QuickModsTab.ResumeLayout(false);
            this.CreatorTab.ResumeLayout(false);
            this.CreatorTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Components.MetroToolTip ToolTips;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIlePathBox;
        public MetroFramework.Controls.MetroTile CreatorTile;
        public MetroFramework.Controls.MetroGrid QuickModsList;
        public MetroFramework.Controls.MetroTile EmptyTile;
        public MetroFramework.Controls.MetroTile RefreshTile;
        public MetroFramework.Controls.MetroTile InstalledTile;
        public MetroFramework.Controls.MetroTabControl MainTabs;
        public MetroFramework.Controls.MetroTabPage QuickModsTab;
        public MetroFramework.Controls.MetroTabPage CreatorTab;
        public MetroFramework.Controls.MetroTile OpenTile;
        private MetroFramework.Controls.MetroTextBox qmmDescBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox qmmAuthBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox qmmNameBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel qmmModsList;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Components.MetroStyleExtender StyleExt;
        private MetroFramework.Controls.MetroButton SaveQMBtn;
        private MetroFramework.Controls.MetroContextMenu qmmMenu;
        private System.Windows.Forms.ToolStripMenuItem editQmmBtn;
        private System.Windows.Forms.ToolStripMenuItem deleteQmmBtn;
    }
}