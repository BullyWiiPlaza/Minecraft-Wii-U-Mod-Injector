
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
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
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
            this.setBGColorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setBGColorBtn.Location = new System.Drawing.Point(922, 615);
            this.setBGColorBtn.Name = "setBGColorBtn";
            this.setBGColorBtn.Size = new System.Drawing.Size(147, 23);
            this.setBGColorBtn.TabIndex = 1;
            this.setBGColorBtn.Text = "Set Background Color";
            this.setBGColorBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setBGColorBtn.UseSelectable = true;
            this.setBGColorBtn.Click += new System.EventHandler(this.setBGColorBtn_Click);
            // 
            // AlphaSlider
            // 
            this.AlphaSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AlphaSlider.BackColor = System.Drawing.Color.Transparent;
            this.AlphaSlider.Location = new System.Drawing.Point(922, 585);
            this.AlphaSlider.Maximum = 255;
            this.AlphaSlider.Name = "AlphaSlider";
            this.AlphaSlider.Size = new System.Drawing.Size(147, 24);
            this.AlphaSlider.TabIndex = 2;
            this.AlphaSlider.Text = "Transparentcy";
            this.AlphaSlider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AlphaSlider.Value = 89;
            this.AlphaSlider.ValueChanged += new System.EventHandler(this.AlphaSlider_ValueChanged);
            // 
            // ListStringsBtn
            // 
            this.ListStringsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ListStringsBtn.Location = new System.Drawing.Point(769, 615);
            this.ListStringsBtn.Name = "ListStringsBtn";
            this.ListStringsBtn.Size = new System.Drawing.Size(147, 23);
            this.ListStringsBtn.TabIndex = 3;
            this.ListStringsBtn.Text = "List Strings";
            this.ListStringsBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ListStringsBtn.UseSelectable = true;
            this.ListStringsBtn.Click += new System.EventHandler(this.ListStringsBtn_Click);
            // 
            // selectedStringTextBox
            // 
            // 
            // 
            // 
            this.selectedStringTextBox.CustomButton.Image = null;
            this.selectedStringTextBox.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.selectedStringTextBox.CustomButton.Name = "";
            this.selectedStringTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.selectedStringTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.selectedStringTextBox.CustomButton.TabIndex = 1;
            this.selectedStringTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.selectedStringTextBox.CustomButton.UseSelectable = true;
            this.selectedStringTextBox.CustomButton.Visible = false;
            this.selectedStringTextBox.Enabled = false;
            this.selectedStringTextBox.Lines = new string[] {
        "StringsText"};
            this.selectedStringTextBox.Location = new System.Drawing.Point(23, 615);
            this.selectedStringTextBox.MaxLength = 32767;
            this.selectedStringTextBox.Name = "selectedStringTextBox";
            this.selectedStringTextBox.PasswordChar = '\0';
            this.selectedStringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.selectedStringTextBox.SelectedText = "";
            this.selectedStringTextBox.SelectionLength = 0;
            this.selectedStringTextBox.SelectionStart = 0;
            this.selectedStringTextBox.ShortcutsEnabled = true;
            this.selectedStringTextBox.Size = new System.Drawing.Size(147, 23);
            this.selectedStringTextBox.TabIndex = 4;
            this.selectedStringTextBox.Text = "StringsText";
            this.selectedStringTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.selectedStringTextBox.UseSelectable = true;
            this.selectedStringTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.selectedStringTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DebugUIStringsListView
            // 
            this.DebugUIStringsListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DebugUIStringsListView.FullRowSelect = true;
            this.DebugUIStringsListView.Location = new System.Drawing.Point(24, 64);
            this.DebugUIStringsListView.MultiSelect = false;
            this.DebugUIStringsListView.Name = "DebugUIStringsListView";
            this.DebugUIStringsListView.OwnerDraw = true;
            this.DebugUIStringsListView.Size = new System.Drawing.Size(299, 545);
            this.DebugUIStringsListView.TabIndex = 5;
            this.DebugUIStringsListView.UseCompatibleStateImageBehavior = false;
            this.DebugUIStringsListView.UseSelectable = true;
            this.DebugUIStringsListView.View = System.Windows.Forms.View.List;
            this.DebugUIStringsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DebugUIStringsListView_ItemSelectionChanged);
            // 
            // setStringBtn
            // 
            this.setStringBtn.Enabled = false;
            this.setStringBtn.Location = new System.Drawing.Point(176, 615);
            this.setStringBtn.Name = "setStringBtn";
            this.setStringBtn.Size = new System.Drawing.Size(147, 23);
            this.setStringBtn.TabIndex = 6;
            this.setStringBtn.Text = "Set String";
            this.setStringBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setStringBtn.UseSelectable = true;
            this.setStringBtn.Click += new System.EventHandler(this.setStringBtn_Click);
            // 
            // TransparentcyLabel
            // 
            this.TransparentcyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TransparentcyLabel.AutoSize = true;
            this.TransparentcyLabel.Location = new System.Drawing.Point(922, 560);
            this.TransparentcyLabel.Name = "TransparentcyLabel";
            this.TransparentcyLabel.Size = new System.Drawing.Size(88, 19);
            this.TransparentcyLabel.TabIndex = 7;
            this.TransparentcyLabel.Text = "Transparentcy";
            this.TransparentcyLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(784, 64);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(76, 19);
            this.ResolutionLabel.TabIndex = 8;
            this.ResolutionLabel.Text = "Resolution: ";
            this.ResolutionLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UIControl_LabelInfo
            // 
            this.UIControl_LabelInfo.AutoSize = true;
            this.UIControl_LabelInfo.Location = new System.Drawing.Point(329, 64);
            this.UIControl_LabelInfo.Name = "UIControl_LabelInfo";
            this.UIControl_LabelInfo.Size = new System.Drawing.Size(31, 19);
            this.UIControl_LabelInfo.TabIndex = 9;
            this.UIControl_LabelInfo.Text = "Info";
            this.UIControl_LabelInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DebugUIConsoleCustomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 661);
            this.Controls.Add(this.UIControl_LabelInfo);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.TransparentcyLabel);
            this.Controls.Add(this.setStringBtn);
            this.Controls.Add(this.DebugUIStringsListView);
            this.Controls.Add(this.selectedStringTextBox);
            this.Controls.Add(this.ListStringsBtn);
            this.Controls.Add(this.AlphaSlider);
            this.Controls.Add(this.setBGColorBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebugUIConsoleCustomizer";
            this.Text = "Minecraft: Wii U Mod Injector - Debug UI Console Customizer";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnExit);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
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
    }
}