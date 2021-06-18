namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    partial class LanguageMngr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageMngr));
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.LanguagesList = new MetroFramework.Controls.MetroGrid();
            this.NameBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIlePathBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownloadTile = new MetroFramework.Controls.MetroTile();
            this.ExportTile = new MetroFramework.Controls.MetroTile();
            this.RefreshTile = new MetroFramework.Controls.MetroTile();
            this.EmptyTile = new MetroFramework.Controls.MetroTile();
            this.ToolTips = new MetroFramework.Components.MetroToolTip();
            this.InstalledTile = new MetroFramework.Controls.MetroTile();
            this.MainTabs = new MetroFramework.Controls.MetroTabControl();
            this.InstalledLangsTab = new MetroFramework.Controls.MetroTabPage();
            this.DownloadableLangsTab = new MetroFramework.Controls.MetroTabPage();
            this.ServerLanguageList = new MetroFramework.Controls.MetroGrid();
            this.ServerNameBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerUrlBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResetTile = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguagesList)).BeginInit();
            this.MainTabs.SuspendLayout();
            this.InstalledLangsTab.SuspendLayout();
            this.DownloadableLangsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerLanguageList)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            // 
            // LanguagesList
            // 
            this.LanguagesList.AllowUserToAddRows = false;
            this.LanguagesList.AllowUserToDeleteRows = false;
            this.LanguagesList.AllowUserToResizeRows = false;
            this.LanguagesList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LanguagesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LanguagesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LanguagesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LanguagesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LanguagesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LanguagesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameBox,
            this.DescriptionBox,
            this.AuthorBox,
            this.FIlePathBox});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LanguagesList.DefaultCellStyle = dataGridViewCellStyle2;
            this.LanguagesList.EnableHeadersVisualStyles = false;
            this.LanguagesList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LanguagesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LanguagesList.Location = new System.Drawing.Point(-2, 1);
            this.LanguagesList.Name = "LanguagesList";
            this.LanguagesList.ReadOnly = true;
            this.LanguagesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LanguagesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LanguagesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LanguagesList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LanguagesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LanguagesList.ShowCellErrors = false;
            this.LanguagesList.ShowEditingIcon = false;
            this.LanguagesList.ShowRowErrors = false;
            this.LanguagesList.Size = new System.Drawing.Size(942, 432);
            this.LanguagesList.TabIndex = 2;
            this.LanguagesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApplyLanguageBtnClicked);
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
            // DownloadTile
            // 
            this.DownloadTile.ActiveControl = null;
            this.DownloadTile.Location = new System.Drawing.Point(0, 129);
            this.DownloadTile.Name = "DownloadTile";
            this.DownloadTile.PaintTileCount = false;
            this.DownloadTile.Size = new System.Drawing.Size(169, 60);
            this.DownloadTile.TabIndex = 47;
            this.DownloadTile.Text = "Download Languages";
            this.DownloadTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DownloadTile.TileCount = 1;
            this.DownloadTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ToolTips.SetToolTip(this.DownloadTile, "Views currently available to download languages");
            this.DownloadTile.UseSelectable = true;
            this.DownloadTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // ExportTile
            // 
            this.ExportTile.ActiveControl = null;
            this.ExportTile.Location = new System.Drawing.Point(0, 189);
            this.ExportTile.Name = "ExportTile";
            this.ExportTile.PaintTileCount = false;
            this.ExportTile.Size = new System.Drawing.Size(169, 60);
            this.ExportTile.TabIndex = 52;
            this.ExportTile.Text = "Export Template";
            this.ExportTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExportTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ToolTips.SetToolTip(this.ExportTile, "Exports a file with all control texts so\r\nyou can make your own language file");
            this.ExportTile.UseSelectable = true;
            this.ExportTile.Click += new System.EventHandler(this.ExportTemplateBtnClicked);
            // 
            // RefreshTile
            // 
            this.RefreshTile.ActiveControl = null;
            this.RefreshTile.Location = new System.Drawing.Point(0, 249);
            this.RefreshTile.Name = "RefreshTile";
            this.RefreshTile.PaintTileCount = false;
            this.RefreshTile.Size = new System.Drawing.Size(169, 60);
            this.RefreshTile.TabIndex = 53;
            this.RefreshTile.Text = "Refresh";
            this.RefreshTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefreshTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ToolTips.SetToolTip(this.RefreshTile, "Refreshes the Language List");
            this.RefreshTile.UseSelectable = true;
            this.RefreshTile.Click += new System.EventHandler(this.RefreshTileClicked);
            // 
            // EmptyTile
            // 
            this.EmptyTile.ActiveControl = null;
            this.EmptyTile.Enabled = false;
            this.EmptyTile.Location = new System.Drawing.Point(0, 368);
            this.EmptyTile.Name = "EmptyTile";
            this.EmptyTile.PaintTileCount = false;
            this.EmptyTile.Size = new System.Drawing.Size(169, 137);
            this.EmptyTile.TabIndex = 54;
            this.EmptyTile.Text = "Currently Viewing:\r\nInstalled Languages\r\n";
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
            this.InstalledTile.Text = "Installed Languages";
            this.InstalledTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InstalledTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ToolTips.SetToolTip(this.InstalledTile, "Views currently installed languages");
            this.InstalledTile.UseSelectable = true;
            this.InstalledTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.InstalledLangsTab);
            this.MainTabs.Controls.Add(this.DownloadableLangsTab);
            this.MainTabs.ItemSize = new System.Drawing.Size(473, 1);
            this.MainTabs.Location = new System.Drawing.Point(175, 67);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(950, 438);
            this.MainTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabs.TabIndex = 55;
            this.MainTabs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainTabs.UseSelectable = true;
            // 
            // InstalledLangsTab
            // 
            this.InstalledLangsTab.Controls.Add(this.LanguagesList);
            this.InstalledLangsTab.HorizontalScrollbarBarColor = true;
            this.InstalledLangsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InstalledLangsTab.HorizontalScrollbarSize = 10;
            this.InstalledLangsTab.Location = new System.Drawing.Point(4, 5);
            this.InstalledLangsTab.Name = "InstalledLangsTab";
            this.InstalledLangsTab.Size = new System.Drawing.Size(942, 429);
            this.InstalledLangsTab.TabIndex = 0;
            this.InstalledLangsTab.Text = "Installed Languages";
            this.InstalledLangsTab.VerticalScrollbarBarColor = true;
            this.InstalledLangsTab.VerticalScrollbarHighlightOnWheel = false;
            this.InstalledLangsTab.VerticalScrollbarSize = 10;
            // 
            // DownloadableLangsTab
            // 
            this.DownloadableLangsTab.Controls.Add(this.ServerLanguageList);
            this.DownloadableLangsTab.HorizontalScrollbarBarColor = true;
            this.DownloadableLangsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.DownloadableLangsTab.HorizontalScrollbarSize = 10;
            this.DownloadableLangsTab.Location = new System.Drawing.Point(4, 5);
            this.DownloadableLangsTab.Name = "DownloadableLangsTab";
            this.DownloadableLangsTab.Size = new System.Drawing.Size(942, 429);
            this.DownloadableLangsTab.TabIndex = 1;
            this.DownloadableLangsTab.Text = "Downloadable Languages";
            this.DownloadableLangsTab.VerticalScrollbarBarColor = true;
            this.DownloadableLangsTab.VerticalScrollbarHighlightOnWheel = false;
            this.DownloadableLangsTab.VerticalScrollbarSize = 10;
            // 
            // ServerLanguageList
            // 
            this.ServerLanguageList.AllowUserToAddRows = false;
            this.ServerLanguageList.AllowUserToDeleteRows = false;
            this.ServerLanguageList.AllowUserToResizeRows = false;
            this.ServerLanguageList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ServerLanguageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServerLanguageList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ServerLanguageList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServerLanguageList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ServerLanguageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServerLanguageList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServerNameBox,
            this.ServerUrlBox});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServerLanguageList.DefaultCellStyle = dataGridViewCellStyle5;
            this.ServerLanguageList.EnableHeadersVisualStyles = false;
            this.ServerLanguageList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ServerLanguageList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ServerLanguageList.Location = new System.Drawing.Point(-2, 1);
            this.ServerLanguageList.Name = "ServerLanguageList";
            this.ServerLanguageList.ReadOnly = true;
            this.ServerLanguageList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServerLanguageList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ServerLanguageList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ServerLanguageList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ServerLanguageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServerLanguageList.ShowCellErrors = false;
            this.ServerLanguageList.ShowEditingIcon = false;
            this.ServerLanguageList.ShowRowErrors = false;
            this.ServerLanguageList.Size = new System.Drawing.Size(942, 432);
            this.ServerLanguageList.TabIndex = 3;
            this.ServerLanguageList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DownloadServerLang);
            // 
            // ServerNameBox
            // 
            this.ServerNameBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServerNameBox.HeaderText = "Name";
            this.ServerNameBox.Name = "ServerNameBox";
            this.ServerNameBox.ReadOnly = true;
            this.ServerNameBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ServerNameBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ServerUrlBox
            // 
            this.ServerUrlBox.HeaderText = "File Path";
            this.ServerUrlBox.Name = "ServerUrlBox";
            this.ServerUrlBox.ReadOnly = true;
            this.ServerUrlBox.Visible = false;
            // 
            // ResetTile
            // 
            this.ResetTile.ActiveControl = null;
            this.ResetTile.Location = new System.Drawing.Point(0, 309);
            this.ResetTile.Name = "ResetTile";
            this.ResetTile.PaintTileCount = false;
            this.ResetTile.Size = new System.Drawing.Size(169, 60);
            this.ResetTile.TabIndex = 57;
            this.ResetTile.Text = "Reset";
            this.ResetTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ToolTips.SetToolTip(this.ResetTile, "Resets your language preferences\r\n(requires restart)");
            this.ResetTile.UseSelectable = true;
            this.ResetTile.Click += new System.EventHandler(this.ResetTileClicked);
            // 
            // LanguageMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 505);
            this.Controls.Add(this.ResetTile);
            this.Controls.Add(this.InstalledTile);
            this.Controls.Add(this.MainTabs);
            this.Controls.Add(this.RefreshTile);
            this.Controls.Add(this.ExportTile);
            this.Controls.Add(this.DownloadTile);
            this.Controls.Add(this.EmptyTile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LanguageMngr";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Minecraft: Wii U Mod Injector - Language Manager";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exiting);
            this.Load += new System.EventHandler(this.Init);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguagesList)).EndInit();
            this.MainTabs.ResumeLayout(false);
            this.InstalledLangsTab.ResumeLayout(false);
            this.DownloadableLangsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServerLanguageList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Components.MetroToolTip ToolTips;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIlePathBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerNameBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerUrlBox;
        public MetroFramework.Controls.MetroTile DownloadTile;
        public MetroFramework.Controls.MetroGrid LanguagesList;
        public MetroFramework.Controls.MetroTile EmptyTile;
        public MetroFramework.Controls.MetroTile RefreshTile;
        public MetroFramework.Controls.MetroTile ExportTile;
        public MetroFramework.Controls.MetroTile InstalledTile;
        public MetroFramework.Controls.MetroTabControl MainTabs;
        public MetroFramework.Controls.MetroTabPage InstalledLangsTab;
        public MetroFramework.Controls.MetroTabPage DownloadableLangsTab;
        public MetroFramework.Controls.MetroGrid ServerLanguageList;
        public MetroFramework.Controls.MetroTile ResetTile;
    }
}