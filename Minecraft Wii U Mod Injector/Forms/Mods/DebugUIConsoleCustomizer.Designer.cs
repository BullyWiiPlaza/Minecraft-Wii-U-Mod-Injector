
namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    partial class DebugUIConsoleCustomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugUIConsoleCustomizer));
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ToolTipManager = new MetroFramework.Components.MetroToolTip();
            this.setBGColorBtn = new MetroFramework.Controls.MetroButton();
            this.AlphaSlider = new MetroFramework.Controls.MetroTrackBar();
            this.ListStringsBtn = new MetroFramework.Controls.MetroButton();
            this.selectedStringTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DebugUIStringsListView = new MetroFramework.Controls.MetroListView();
            this.setStringBtn = new MetroFramework.Controls.MetroButton();
            this.TransparentcyLabel = new MetroFramework.Controls.MetroLabel();
            this.ResolutionLabel = new MetroFramework.Controls.MetroLabel();
            this.UIControl_LabelInfo = new MetroFramework.Controls.MetroLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = null;
            this.StyleMngr.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ToolTipManager
            // 
            this.ToolTipManager.Style = MetroFramework.MetroColorStyle.Default;
            this.ToolTipManager.StyleManager = null;
            this.ToolTipManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // setBGColorBtn
            // 
            resources.ApplyResources(this.setBGColorBtn, "setBGColorBtn");
            this.setBGColorBtn.Name = "setBGColorBtn";
            this.setBGColorBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setBGColorBtn.UseSelectable = true;
            this.setBGColorBtn.Click += new System.EventHandler(this.setBGColorBtn_Click);
            // 
            // AlphaSlider
            // 
            resources.ApplyResources(this.AlphaSlider, "AlphaSlider");
            this.AlphaSlider.BackColor = System.Drawing.Color.Transparent;
            this.AlphaSlider.Maximum = 255;
            this.AlphaSlider.Name = "AlphaSlider";
            this.AlphaSlider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AlphaSlider.Value = 89;
            this.AlphaSlider.ValueChanged += new System.EventHandler(this.AlphaSlider_ValueChanged);
            // 
            // ListStringsBtn
            // 
            resources.ApplyResources(this.ListStringsBtn, "ListStringsBtn");
            this.ListStringsBtn.Name = "ListStringsBtn";
            this.ListStringsBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ListStringsBtn.UseSelectable = true;
            this.ListStringsBtn.Click += new System.EventHandler(this.ListStringsBtn_Click);
            // 
            // selectedStringTextBox
            // 
            // 
            // 
            // 
            this.selectedStringTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.selectedStringTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.selectedStringTextBox.CustomButton.Name = "";
            this.selectedStringTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.selectedStringTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.selectedStringTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.selectedStringTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.selectedStringTextBox.CustomButton.UseSelectable = true;
            this.selectedStringTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            resources.ApplyResources(this.selectedStringTextBox, "selectedStringTextBox");
            this.selectedStringTextBox.Lines = new string[] {
        "StringsText"};
            this.selectedStringTextBox.MaxLength = 32767;
            this.selectedStringTextBox.Name = "selectedStringTextBox";
            this.selectedStringTextBox.PasswordChar = '\0';
            this.selectedStringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.selectedStringTextBox.SelectedText = "";
            this.selectedStringTextBox.SelectionLength = 0;
            this.selectedStringTextBox.SelectionStart = 0;
            this.selectedStringTextBox.ShortcutsEnabled = true;
            this.selectedStringTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.selectedStringTextBox.UseSelectable = true;
            this.selectedStringTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.selectedStringTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DebugUIStringsListView
            // 
            resources.ApplyResources(this.DebugUIStringsListView, "DebugUIStringsListView");
            this.DebugUIStringsListView.FullRowSelect = true;
            this.DebugUIStringsListView.MultiSelect = false;
            this.DebugUIStringsListView.Name = "DebugUIStringsListView";
            this.DebugUIStringsListView.OwnerDraw = true;
            this.DebugUIStringsListView.UseCompatibleStateImageBehavior = false;
            this.DebugUIStringsListView.UseSelectable = true;
            this.DebugUIStringsListView.View = System.Windows.Forms.View.List;
            this.DebugUIStringsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DebugUIStringsListView_ItemSelectionChanged);
            // 
            // setStringBtn
            // 
            resources.ApplyResources(this.setStringBtn, "setStringBtn");
            this.setStringBtn.Name = "setStringBtn";
            this.setStringBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setStringBtn.UseSelectable = true;
            this.setStringBtn.Click += new System.EventHandler(this.setStringBtn_Click);
            // 
            // TransparentcyLabel
            // 
            resources.ApplyResources(this.TransparentcyLabel, "TransparentcyLabel");
            this.TransparentcyLabel.Name = "TransparentcyLabel";
            this.TransparentcyLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ResolutionLabel
            // 
            resources.ApplyResources(this.ResolutionLabel, "ResolutionLabel");
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UIControl_LabelInfo
            // 
            resources.ApplyResources(this.UIControl_LabelInfo, "UIControl_LabelInfo");
            this.UIControl_LabelInfo.Name = "UIControl_LabelInfo";
            this.UIControl_LabelInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // numericUpDown2
            // 
            resources.ApplyResources(this.numericUpDown2, "numericUpDown2");
            this.numericUpDown2.Name = "numericUpDown2";
            // 
            // metroButton1
            // 
            resources.ApplyResources(this.metroButton1, "metroButton1");
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.setPosition);
            // 
            // DebugUIConsoleCustomizer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.UIControl_LabelInfo);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.TransparentcyLabel);
            this.Controls.Add(this.setStringBtn);
            this.Controls.Add(this.DebugUIStringsListView);
            this.Controls.Add(this.selectedStringTextBox);
            this.Controls.Add(this.ListStringsBtn);
            this.Controls.Add(this.AlphaSlider);
            this.Controls.Add(this.setBGColorBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebugUIConsoleCustomizer";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnExit);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Components.MetroToolTip ToolTipManager;
        private MetroFramework.Controls.MetroButton setBGColorBtn;
        private MetroFramework.Controls.MetroTrackBar AlphaSlider;
        private MetroFramework.Controls.MetroButton ListStringsBtn;
        private MetroFramework.Controls.MetroTextBox selectedStringTextBox;
        private MetroFramework.Controls.MetroListView DebugUIStringsListView;
        private MetroFramework.Controls.MetroButton setStringBtn;
        private MetroFramework.Controls.MetroLabel TransparentcyLabel;
        private MetroFramework.Controls.MetroLabel ResolutionLabel;
        private MetroFramework.Controls.MetroLabel UIControl_LabelInfo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}