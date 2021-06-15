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
            this.MainTabs = new MetroFramework.Controls.MetroTabControl();
            this.InstalledLangTab = new MetroFramework.Controls.MetroTabPage();
            this.LanguagesList = new MetroFramework.Controls.MetroGrid();
            this.DownloadableLangTab = new MetroFramework.Controls.MetroTabPage();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.ExportTemplateBtn = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.FIlePathBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.MainTabs.SuspendLayout();
            this.InstalledLangTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LanguagesList)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            // 
            // MainTabs
            // 
            this.MainTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.MainTabs.Controls.Add(this.InstalledLangTab);
            this.MainTabs.Controls.Add(this.DownloadableLangTab);
            this.MainTabs.ItemSize = new System.Drawing.Size(446, 1);
            this.MainTabs.Location = new System.Drawing.Point(218, 63);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(907, 440);
            this.MainTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabs.TabIndex = 46;
            this.MainTabs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainTabs.UseSelectable = true;
            // 
            // InstalledLangTab
            // 
            this.InstalledLangTab.Controls.Add(this.LanguagesList);
            this.InstalledLangTab.HorizontalScrollbarBarColor = true;
            this.InstalledLangTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InstalledLangTab.HorizontalScrollbarSize = 10;
            this.InstalledLangTab.Location = new System.Drawing.Point(4, 4);
            this.InstalledLangTab.Name = "InstalledLangTab";
            this.InstalledLangTab.Size = new System.Drawing.Size(899, 431);
            this.InstalledLangTab.TabIndex = 0;
            this.InstalledLangTab.Text = "Installed Language(\'s)";
            this.InstalledLangTab.VerticalScrollbarBarColor = true;
            this.InstalledLangTab.VerticalScrollbarHighlightOnWheel = false;
            this.InstalledLangTab.VerticalScrollbarSize = 10;
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
            this.LanguagesList.Location = new System.Drawing.Point(0, 1);
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
            this.LanguagesList.Size = new System.Drawing.Size(899, 431);
            this.LanguagesList.TabIndex = 2;
            this.LanguagesList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApplyLanguage);
            // 
            // DownloadableLangTab
            // 
            this.DownloadableLangTab.HorizontalScrollbarBarColor = true;
            this.DownloadableLangTab.HorizontalScrollbarHighlightOnWheel = false;
            this.DownloadableLangTab.HorizontalScrollbarSize = 10;
            this.DownloadableLangTab.Location = new System.Drawing.Point(4, 4);
            this.DownloadableLangTab.Name = "DownloadableLangTab";
            this.DownloadableLangTab.Size = new System.Drawing.Size(899, 431);
            this.DownloadableLangTab.TabIndex = 1;
            this.DownloadableLangTab.Text = "Downloadable Language(\'s)";
            this.DownloadableLangTab.VerticalScrollbarBarColor = true;
            this.DownloadableLangTab.VerticalScrollbarHighlightOnWheel = false;
            this.DownloadableLangTab.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 67);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(189, 60);
            this.metroTile1.TabIndex = 47;
            this.metroTile1.Text = "Installed Language(\'s)";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(23, 133);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(189, 60);
            this.metroTile2.TabIndex = 48;
            this.metroTile2.Text = "Downloadable Language(\'s)";
            this.metroTile2.UseSelectable = true;
            // 
            // ExportTemplateBtn
            // 
            this.ExportTemplateBtn.Location = new System.Drawing.Point(23, 199);
            this.ExportTemplateBtn.Name = "ExportTemplateBtn";
            this.ExportTemplateBtn.Size = new System.Drawing.Size(189, 23);
            this.ExportTemplateBtn.TabIndex = 49;
            this.ExportTemplateBtn.Text = "Export Template";
            this.ExportTemplateBtn.UseSelectable = true;
            this.ExportTemplateBtn.Click += new System.EventHandler(this.ExportTemplateBtnClicked);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 228);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(189, 23);
            this.metroButton1.TabIndex = 50;
            this.metroButton1.Text = "Refresh";
            this.metroButton1.UseSelectable = true;
            // 
            // FIlePathBox
            // 
            this.FIlePathBox.HeaderText = "File Path";
            this.FIlePathBox.Name = "FIlePathBox";
            this.FIlePathBox.ReadOnly = true;
            this.FIlePathBox.Visible = false;
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
            // NameBox
            // 
            this.NameBox.HeaderText = "Name";
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LanguageMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 505);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.ExportTemplateBtn);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.MainTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LanguageMngr";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Language Manager";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Init);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            this.MainTabs.ResumeLayout(false);
            this.InstalledLangTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LanguagesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTabControl MainTabs;
        private MetroFramework.Controls.MetroTabPage InstalledLangTab;
        private MetroFramework.Controls.MetroGrid LanguagesList;
        private MetroFramework.Controls.MetroTabPage DownloadableLangTab;
        private MetroFramework.Controls.MetroButton ExportTemplateBtn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIlePathBox;
    }
}