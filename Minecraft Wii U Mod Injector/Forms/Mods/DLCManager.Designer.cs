
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
            resources.ApplyResources(DLCPackNames, "DLCPackNames");
            // 
            // ListPacksBtn
            // 
            resources.ApplyResources(this.ListPacksBtn, "ListPacksBtn");
            this.ListPacksBtn.Name = "ListPacksBtn";
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
            resources.ApplyResources(this.PackCountLabel, "PackCountLabel");
            this.PackCountLabel.Name = "PackCountLabel";
            this.PackCountLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DLCPackListView
            // 
            resources.ApplyResources(this.DLCPackListView, "DLCPackListView");
            this.DLCPackListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            DLCPackNames});
            this.DLCPackListView.FullRowSelect = true;
            this.DLCPackListView.GridLines = true;
            this.DLCPackListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("DLCPackListView.Groups")))});
            this.DLCPackListView.MultiSelect = false;
            this.DLCPackListView.Name = "DLCPackListView";
            this.DLCPackListView.OwnerDraw = true;
            this.DLCPackListView.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DLCPackListView.UseCompatibleStateImageBehavior = false;
            this.DLCPackListView.UseSelectable = true;
            this.DLCPackListView.View = System.Windows.Forms.View.List;
            this.DLCPackListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ViewPackInfo);
            // 
            // dlcPackInfoLabel
            // 
            resources.ApplyResources(this.dlcPackInfoLabel, "dlcPackInfoLabel");
            this.dlcPackInfoLabel.Name = "dlcPackInfoLabel";
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
            resources.ApplyResources(this.setLicenseMaskBtn, "setLicenseMaskBtn");
            this.setLicenseMaskBtn.Name = "setLicenseMaskBtn";
            this.setLicenseMaskBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.setLicenseMaskBtn, resources.GetString("setLicenseMaskBtn.ToolTip"));
            this.setLicenseMaskBtn.UseSelectable = true;
            this.setLicenseMaskBtn.Click += new System.EventHandler(this.SetLicenseMask);
            // 
            // removePackBtn
            // 
            resources.ApplyResources(this.removePackBtn, "removePackBtn");
            this.removePackBtn.Name = "removePackBtn";
            this.removePackBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.removePackBtn, resources.GetString("removePackBtn.ToolTip"));
            this.removePackBtn.UseSelectable = true;
            this.removePackBtn.Click += new System.EventHandler(this.RemovePackBtn_Click);
            // 
            // DLCManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removePackBtn);
            this.Controls.Add(this.setLicenseMaskBtn);
            this.Controls.Add(this.dlcPackInfoLabel);
            this.Controls.Add(this.PackCountLabel);
            this.Controls.Add(this.DLCPackListView);
            this.Controls.Add(this.ListPacksBtn);
            this.MaximizeBox = false;
            this.Name = "DLCManager";
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