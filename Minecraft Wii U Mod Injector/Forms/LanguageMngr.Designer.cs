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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageMngr));
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.LanguagesList = new MetroFramework.Controls.MetroGrid();
            this.DownloadTile = new MetroFramework.Controls.MetroTile();
            this.ExportTile = new MetroFramework.Controls.MetroTile();
            this.RefreshTile = new MetroFramework.Controls.MetroTile();
            this.EmptyTile = new MetroFramework.Controls.MetroTile();
            this.ToolTips = new MetroFramework.Components.MetroToolTip();
            this.NameBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIlePathBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguagesList)).BeginInit();
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
            this.LanguagesList.Location = new System.Drawing.Point(175, 67);
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
            this.LanguagesList.Size = new System.Drawing.Size(946, 438);
            this.LanguagesList.TabIndex = 2;
            this.LanguagesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApplyLanguage);
            // 
            // DownloadTile
            // 
            this.DownloadTile.ActiveControl = null;
            this.DownloadTile.Location = new System.Drawing.Point(0, 67);
            this.DownloadTile.Name = "DownloadTile";
            this.DownloadTile.PaintTileCount = false;
            this.DownloadTile.Size = new System.Drawing.Size(169, 60);
            this.DownloadTile.TabIndex = 47;
            this.DownloadTile.Text = "Download Languages";
            this.DownloadTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DownloadTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ToolTips.SetToolTip(this.DownloadTile, "Redirects you to the official repostiry for language files");
            this.DownloadTile.UseSelectable = true;
            this.DownloadTile.Click += new System.EventHandler(this.DownloadTileClicked);
            // 
            // ExportTile
            // 
            this.ExportTile.ActiveControl = null;
            this.ExportTile.Location = new System.Drawing.Point(0, 127);
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
            this.RefreshTile.Location = new System.Drawing.Point(0, 187);
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
            this.EmptyTile.Location = new System.Drawing.Point(0, 247);
            this.EmptyTile.Name = "EmptyTile";
            this.EmptyTile.PaintTileCount = false;
            this.EmptyTile.Size = new System.Drawing.Size(169, 258);
            this.EmptyTile.TabIndex = 54;
            this.EmptyTile.Text = "\r\n";
            this.EmptyTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EmptyTile.UseSelectable = true;
            // 
            // ToolTips
            // 
            this.ToolTips.Style = MetroFramework.MetroColorStyle.Default;
            this.ToolTips.StyleManager = null;
            this.ToolTips.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // NameBox
            // 
            this.NameBox.HeaderText = "Name";
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // LanguageMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 505);
            this.Controls.Add(this.EmptyTile);
            this.Controls.Add(this.RefreshTile);
            this.Controls.Add(this.ExportTile);
            this.Controls.Add(this.LanguagesList);
            this.Controls.Add(this.DownloadTile);
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
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Controls.MetroTile DownloadTile;
        private MetroFramework.Controls.MetroGrid LanguagesList;
        private MetroFramework.Controls.MetroTile EmptyTile;
        private MetroFramework.Controls.MetroTile RefreshTile;
        private MetroFramework.Controls.MetroTile ExportTile;
        private MetroFramework.Components.MetroToolTip ToolTips;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIlePathBox;
    }
}