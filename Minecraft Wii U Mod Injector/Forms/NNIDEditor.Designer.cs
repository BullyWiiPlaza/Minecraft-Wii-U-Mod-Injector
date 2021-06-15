namespace Minecraft_Wii_U_Mod_Injector.Forms
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
            // 
            // NNIDNameBox
            // 
            // 
            // 
            // 
            this.NNIDNameBox.CustomButton.Image = null;
            this.NNIDNameBox.CustomButton.Location = new System.Drawing.Point(437, 1);
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
            this.NNIDNameBox.Size = new System.Drawing.Size(459, 23);
            this.NNIDNameBox.TabIndex = 1;
            this.ToolTips.SetToolTip(this.NNIDNameBox, "The name to set");
            this.NNIDNameBox.UseSelectable = true;
            this.NNIDNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NNIDNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NNIDChangeBtn
            // 
            this.NNIDChangeBtn.Location = new System.Drawing.Point(77, 126);
            this.NNIDChangeBtn.Name = "NNIDChangeBtn";
            this.NNIDChangeBtn.Size = new System.Drawing.Size(558, 23);
            this.NNIDChangeBtn.TabIndex = 2;
            this.NNIDChangeBtn.Text = "Change";
            this.ToolTips.SetToolTip(this.NNIDChangeBtn, "Changes your name to the given one");
            this.NNIDChangeBtn.UseSelectable = true;
            this.NNIDChangeBtn.Click += new System.EventHandler(this.NnidChangeBtnClicked);
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            // 
            // WarningLbl
            // 
            this.WarningLbl.AutoSize = true;
            this.WarningLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.WarningLbl.Location = new System.Drawing.Point(80, 60);
            this.WarningLbl.Name = "WarningLbl";
            this.WarningLbl.Size = new System.Drawing.Size(507, 25);
            this.WarningLbl.Style = MetroFramework.MetroColorStyle.Red;
            this.WarningLbl.TabIndex = 5;
            this.WarningLbl.Text = "You won\'t see changes and other people won\'t unless they rejoin!";
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
            this.readNameBtn.Location = new System.Drawing.Point(542, 97);
            this.readNameBtn.Name = "readNameBtn";
            this.readNameBtn.Size = new System.Drawing.Size(93, 23);
            this.readNameBtn.TabIndex = 6;
            this.readNameBtn.Text = "Read";
            this.ToolTips.SetToolTip(this.readNameBtn, "Changes your name to the given one");
            this.readNameBtn.UseSelectable = true;
            this.readNameBtn.Click += new System.EventHandler(this.ReadNameBtnClicked);
            // 
            // NnidEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 168);
            this.Controls.Add(this.readNameBtn);
            this.Controls.Add(this.WarningLbl);
            this.Controls.Add(this.NNIDChangeBtn);
            this.Controls.Add(this.NNIDNameBox);
            this.Controls.Add(this.NNIDNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NnidEditor";
            this.Resizable = false;
            this.Text = "Minecraft: Wii U Mod Injector - Nintendo Network Editor";
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
    }
}