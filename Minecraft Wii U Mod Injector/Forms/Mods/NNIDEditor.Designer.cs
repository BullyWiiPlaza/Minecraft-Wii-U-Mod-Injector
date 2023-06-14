namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    partial class NnidEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NnidEditor));
            this.NNIDNameLbl = new MetroFramework.Controls.MetroLabel();
            this.NNIDNameBox = new MetroFramework.Controls.MetroTextBox();
            this.NNIDChangeBtn = new MetroFramework.Controls.MetroButton();
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.WarningLbl = new MetroFramework.Controls.MetroLabel();
            this.ToolTips = new MetroFramework.Components.MetroToolTip();
            this.NNIDResetBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.SuspendLayout();
            // 
            // NNIDNameLbl
            // 
            resources.ApplyResources(this.NNIDNameLbl, "NNIDNameLbl");
            this.NNIDNameLbl.Name = "NNIDNameLbl";
            this.NNIDNameLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // NNIDNameBox
            // 
            resources.ApplyResources(this.NNIDNameBox, "NNIDNameBox");
            // 
            // 
            // 
            this.NNIDNameBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.NNIDNameBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.NNIDNameBox.CustomButton.Name = "";
            this.NNIDNameBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.NNIDNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NNIDNameBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.NNIDNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NNIDNameBox.CustomButton.UseSelectable = true;
            this.NNIDNameBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.NNIDNameBox.Lines = new string[0];
            this.NNIDNameBox.MaxLength = 32;
            this.NNIDNameBox.Name = "NNIDNameBox";
            this.NNIDNameBox.PasswordChar = '\0';
            this.NNIDNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NNIDNameBox.SelectedText = "";
            this.NNIDNameBox.SelectionLength = 0;
            this.NNIDNameBox.SelectionStart = 0;
            this.NNIDNameBox.ShortcutsEnabled = true;
            this.NNIDNameBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.NNIDNameBox, resources.GetString("NNIDNameBox.ToolTip"));
            this.NNIDNameBox.UseSelectable = true;
            this.NNIDNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NNIDNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NNIDChangeBtn
            // 
            resources.ApplyResources(this.NNIDChangeBtn, "NNIDChangeBtn");
            this.NNIDChangeBtn.Name = "NNIDChangeBtn";
            this.NNIDChangeBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.NNIDChangeBtn, resources.GetString("NNIDChangeBtn.ToolTip"));
            this.NNIDChangeBtn.UseSelectable = true;
            this.NNIDChangeBtn.Click += new System.EventHandler(this.NnidChangeBtnClicked);
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            this.StyleMngr.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // WarningLbl
            // 
            resources.ApplyResources(this.WarningLbl, "WarningLbl");
            this.WarningLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.WarningLbl.Name = "WarningLbl";
            this.WarningLbl.Style = MetroFramework.MetroColorStyle.Red;
            this.WarningLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WarningLbl.UseStyleColors = true;
            // 
            // ToolTips
            // 
            this.ToolTips.Style = MetroFramework.MetroColorStyle.Default;
            this.ToolTips.StyleManager = null;
            this.ToolTips.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // NNIDResetBtn
            // 
            resources.ApplyResources(this.NNIDResetBtn, "NNIDResetBtn");
            this.NNIDResetBtn.Name = "NNIDResetBtn";
            this.NNIDResetBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.NNIDResetBtn, resources.GetString("NNIDResetBtn.ToolTip"));
            this.NNIDResetBtn.UseSelectable = true;
            this.NNIDResetBtn.Click += new System.EventHandler(this.NNIDResetBtn_Click);
            // 
            // NnidEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NNIDResetBtn);
            this.Controls.Add(this.WarningLbl);
            this.Controls.Add(this.NNIDChangeBtn);
            this.Controls.Add(this.NNIDNameBox);
            this.Controls.Add(this.NNIDNameLbl);
            this.MaximizeBox = false;
            this.Name = "NnidEditor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exiting);
            this.Load += new System.EventHandler(this.Init);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel NNIDNameLbl;
        private MetroFramework.Controls.MetroTextBox NNIDNameBox;
        private MetroFramework.Controls.MetroButton NNIDChangeBtn;
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Controls.MetroLabel WarningLbl;
        private MetroFramework.Components.MetroToolTip ToolTips;
        private MetroFramework.Controls.MetroButton NNIDResetBtn;
    }
}