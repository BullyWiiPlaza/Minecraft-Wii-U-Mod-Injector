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
            this.readNameBtn = new MetroFramework.Controls.MetroButton();
            this.NNIDResetBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.SuspendLayout();
            // 
            // NNIDNameLbl
            // 
            this.NNIDNameLbl.AutoSize = true;
            this.NNIDNameLbl.Location = new System.Drawing.Point(23, 97);
            this.NNIDNameLbl.Name = "NNIDNameLbl";
            this.NNIDNameLbl.Size = new System.Drawing.Size(48, 19);
            this.NNIDNameLbl.TabIndex = 0;
            this.NNIDNameLbl.Text = "Name:";
            this.NNIDNameLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // NNIDNameBox
            // 
            this.NNIDNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.NNIDNameBox.CustomButton.Image = null;
            this.NNIDNameBox.CustomButton.Location = new System.Drawing.Point(439, 1);
            this.NNIDNameBox.CustomButton.Name = "";
            this.NNIDNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NNIDNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NNIDNameBox.CustomButton.TabIndex = 1;
            this.NNIDNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NNIDNameBox.CustomButton.UseSelectable = true;
            this.NNIDNameBox.CustomButton.Visible = false;
            this.NNIDNameBox.Lines = new string[0];
            this.NNIDNameBox.Location = new System.Drawing.Point(77, 97);
            this.NNIDNameBox.MaxLength = 32;
            this.NNIDNameBox.Name = "NNIDNameBox";
            this.NNIDNameBox.PasswordChar = '\0';
            this.NNIDNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NNIDNameBox.SelectedText = "";
            this.NNIDNameBox.SelectionLength = 0;
            this.NNIDNameBox.SelectionStart = 0;
            this.NNIDNameBox.ShortcutsEnabled = true;
            this.NNIDNameBox.Size = new System.Drawing.Size(461, 23);
            this.NNIDNameBox.TabIndex = 1;
            this.NNIDNameBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.NNIDNameBox, "The name to set");
            this.NNIDNameBox.UseSelectable = true;
            this.NNIDNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NNIDNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NNIDChangeBtn
            // 
            this.NNIDChangeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NNIDChangeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NNIDChangeBtn.Location = new System.Drawing.Point(77, 126);
            this.NNIDChangeBtn.Name = "NNIDChangeBtn";
            this.NNIDChangeBtn.Size = new System.Drawing.Size(560, 23);
            this.NNIDChangeBtn.TabIndex = 2;
            this.NNIDChangeBtn.Text = "Change";
            this.NNIDChangeBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.NNIDChangeBtn, "Changes your Nintendo Network ID");
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
            this.WarningLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarningLbl.AutoSize = true;
            this.WarningLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.WarningLbl.Location = new System.Drawing.Point(80, 60);
            this.WarningLbl.Name = "WarningLbl";
            this.WarningLbl.Size = new System.Drawing.Size(507, 25);
            this.WarningLbl.Style = MetroFramework.MetroColorStyle.Red;
            this.WarningLbl.TabIndex = 5;
            this.WarningLbl.Text = "You won\'t see changes and other people won\'t unless they rejoin!";
            this.WarningLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WarningLbl.UseStyleColors = true;
            // 
            // ToolTips
            // 
            this.ToolTips.Style = MetroFramework.MetroColorStyle.Default;
            this.ToolTips.StyleManager = null;
            this.ToolTips.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // readNameBtn
            // 
            this.readNameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.readNameBtn.Location = new System.Drawing.Point(542, 97);
            this.readNameBtn.Name = "readNameBtn";
            this.readNameBtn.Size = new System.Drawing.Size(95, 23);
            this.readNameBtn.TabIndex = 6;
            this.readNameBtn.Text = "Read";
            this.readNameBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.readNameBtn, "Reads your Nintendo Network ID");
            this.readNameBtn.UseSelectable = true;
            this.readNameBtn.Click += new System.EventHandler(this.ReadNameBtnClicked);
            // 
            // NNIDResetBtn
            // 
            this.NNIDResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NNIDResetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NNIDResetBtn.Location = new System.Drawing.Point(77, 154);
            this.NNIDResetBtn.Name = "NNIDResetBtn";
            this.NNIDResetBtn.Size = new System.Drawing.Size(560, 23);
            this.NNIDResetBtn.TabIndex = 7;
            this.NNIDResetBtn.Text = "Reset";
            this.NNIDResetBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.NNIDResetBtn, "Resets your name to your default\r\nNintendo Network ID");
            this.NNIDResetBtn.UseSelectable = true;
            this.NNIDResetBtn.Click += new System.EventHandler(this.NNIDResetBtn_Click);
            // 
            // NnidEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 200);
            this.Controls.Add(this.NNIDResetBtn);
            this.Controls.Add(this.readNameBtn);
            this.Controls.Add(this.WarningLbl);
            this.Controls.Add(this.NNIDChangeBtn);
            this.Controls.Add(this.NNIDNameBox);
            this.Controls.Add(this.NNIDNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(3840, 200);
            this.MinimumSize = new System.Drawing.Size(660, 200);
            this.Name = "NnidEditor";
            this.Text = "Minecraft: Wii U Mod Injector - Nintendo Network Editor";
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
        private MetroFramework.Controls.MetroButton readNameBtn;
        private MetroFramework.Controls.MetroButton NNIDResetBtn;
    }
}