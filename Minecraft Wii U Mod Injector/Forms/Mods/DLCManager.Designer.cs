
namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    partial class DLCManager
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
            System.Windows.Forms.ColumnHeader DLCPackNames;
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("DLCName", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLCManager));
            this.ListPacksBtn = new MetroFramework.Controls.MetroButton();
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.PackCountLabel = new MetroFramework.Controls.MetroLabel();
            this.DLCPackListView = new MetroFramework.Controls.MetroListView();
            this.dlcPackInfoLabel = new MetroFramework.Controls.MetroLabel();
            this.ToolTipManager = new MetroFramework.Components.MetroToolTip();
            this.setLicenseMaskBtn = new MetroFramework.Controls.MetroButton();
            this.removePackBtn = new MetroFramework.Controls.MetroButton();
            DLCPackNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.SuspendLayout();
            // 
            // DLCPackNames
            // 
            DLCPackNames.Width = 200;
            // 
            // ListPacksBtn
            // 
            this.ListPacksBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPacksBtn.Location = new System.Drawing.Point(864, 533);
            this.ListPacksBtn.Name = "ListPacksBtn";
            this.ListPacksBtn.Size = new System.Drawing.Size(263, 23);
            this.ListPacksBtn.TabIndex = 0;
            this.ListPacksBtn.Text = "List DLC Packs";
            this.ListPacksBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ListPacksBtn.UseSelectable = true;
            this.ListPacksBtn.Click += new System.EventHandler(this.ListPacksBtn_Click);
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = null;
            this.StyleMngr.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PackCountLabel
            // 
            this.PackCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PackCountLabel.AutoSize = true;
            this.PackCountLabel.Location = new System.Drawing.Point(864, 508);
            this.PackCountLabel.Name = "PackCountLabel";
            this.PackCountLabel.Size = new System.Drawing.Size(143, 19);
            this.PackCountLabel.TabIndex = 2;
            this.PackCountLabel.Text = "Current Pack amount : ";
            this.PackCountLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DLCPackListView
            // 
            this.DLCPackListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.DLCPackListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DLCPackListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            DLCPackNames});
            this.DLCPackListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DLCPackListView.FullRowSelect = true;
            this.DLCPackListView.GridLines = true;
            listViewGroup1.Header = "DLCName";
            listViewGroup1.Name = "DLCName";
            this.DLCPackListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.DLCPackListView.Location = new System.Drawing.Point(23, 63);
            this.DLCPackListView.MultiSelect = false;
            this.DLCPackListView.Name = "DLCPackListView";
            this.DLCPackListView.OwnerDraw = true;
            this.DLCPackListView.Size = new System.Drawing.Size(835, 464);
            this.DLCPackListView.TabIndex = 1;
            this.DLCPackListView.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DLCPackListView.UseCompatibleStateImageBehavior = false;
            this.DLCPackListView.UseSelectable = true;
            this.DLCPackListView.View = System.Windows.Forms.View.List;
            this.DLCPackListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ViewPackInfo);
            // 
            // dlcPackInfoLabel
            // 
            this.dlcPackInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dlcPackInfoLabel.AutoSize = true;
            this.dlcPackInfoLabel.Location = new System.Drawing.Point(864, 63);
            this.dlcPackInfoLabel.Name = "dlcPackInfoLabel";
            this.dlcPackInfoLabel.Size = new System.Drawing.Size(88, 19);
            this.dlcPackInfoLabel.TabIndex = 3;
            this.dlcPackInfoLabel.Text = "DLC Pack Info";
            this.dlcPackInfoLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ToolTipManager
            // 
            this.ToolTipManager.Style = MetroFramework.MetroColorStyle.Default;
            this.ToolTipManager.StyleManager = null;
            this.ToolTipManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // setLicenseMaskBtn
            // 
            this.setLicenseMaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setLicenseMaskBtn.Enabled = false;
            this.setLicenseMaskBtn.Location = new System.Drawing.Point(443, 533);
            this.setLicenseMaskBtn.Name = "setLicenseMaskBtn";
            this.setLicenseMaskBtn.Size = new System.Drawing.Size(415, 23);
            this.setLicenseMaskBtn.TabIndex = 4;
            this.setLicenseMaskBtn.Text = "Set License Mask";
            this.setLicenseMaskBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.setLicenseMaskBtn, "Set the License Mask e.g unlocks the selected DLC Pack");
            this.setLicenseMaskBtn.UseSelectable = true;
            this.setLicenseMaskBtn.Click += new System.EventHandler(this.SetLicenseMask);
            // 
            // removePackBtn
            // 
            this.removePackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removePackBtn.Enabled = false;
            this.removePackBtn.Location = new System.Drawing.Point(23, 533);
            this.removePackBtn.Name = "removePackBtn";
            this.removePackBtn.Size = new System.Drawing.Size(415, 23);
            this.removePackBtn.TabIndex = 5;
            this.removePackBtn.Text = "Remove Pack";
            this.removePackBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.removePackBtn, "Removes the selected DLC Pack from memory");
            this.removePackBtn.UseSelectable = true;
            this.removePackBtn.Click += new System.EventHandler(this.RemovePackBtn_Click);
            // 
            // DLCManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 580);
            this.Controls.Add(this.removePackBtn);
            this.Controls.Add(this.setLicenseMaskBtn);
            this.Controls.Add(this.dlcPackInfoLabel);
            this.Controls.Add(this.PackCountLabel);
            this.Controls.Add(this.DLCPackListView);
            this.Controls.Add(this.ListPacksBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(3840, 580);
            this.MinimumSize = new System.Drawing.Size(1150, 580);
            this.Name = "DLCManager";
            this.Text = "Minecraft: Wii U Mod Injector - DLC Manager [BETA]";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnExit);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton ListPacksBtn;
        public MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Controls.MetroLabel PackCountLabel;
        private MetroFramework.Controls.MetroLabel dlcPackInfoLabel;
        private MetroFramework.Components.MetroToolTip ToolTipManager;
        private MetroFramework.Controls.MetroListView DLCPackListView;
        private MetroFramework.Controls.MetroButton setLicenseMaskBtn;
        private MetroFramework.Controls.MetroButton removePackBtn;
    }
}