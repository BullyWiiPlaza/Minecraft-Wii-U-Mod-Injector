namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    partial class PlayerOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerOptions));
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ToolTips = new MetroFramework.Components.MetroToolTip();
            this.CloseContainersBtn = new MetroFramework.Controls.MetroButton();
            this.CameraBox = new MetroFramework.Controls.MetroComboBox();
            this.OpenScoreboardBtn = new MetroFramework.Controls.MetroButton();
            this.GameModeBox = new MetroFramework.Controls.MetroComboBox();
            this.CameraLbl = new MetroFramework.Controls.MetroLabel();
            this.GameModeLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            // 
            // ToolTips
            // 
            this.ToolTips.Style = MetroFramework.MetroColorStyle.Default;
            this.ToolTips.StyleManager = null;
            this.ToolTips.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CloseContainersBtn
            // 
            this.CloseContainersBtn.Location = new System.Drawing.Point(23, 162);
            this.CloseContainersBtn.Name = "CloseContainersBtn";
            this.CloseContainersBtn.Size = new System.Drawing.Size(517, 23);
            this.CloseContainersBtn.TabIndex = 6;
            this.CloseContainersBtn.Text = "Close Container";
            this.ToolTips.SetToolTip(this.CloseContainersBtn, "Closes out of any container such as:\r\n\r\nFurnace, chest, hopper, crafting etc...");
            this.CloseContainersBtn.UseSelectable = true;
            this.CloseContainersBtn.Click += new System.EventHandler(this.CloseContainersBtnClicked);
            // 
            // CameraBox
            // 
            this.CameraBox.DisplayMember = "1";
            this.CameraBox.FormattingEnabled = true;
            this.CameraBox.ItemHeight = 23;
            this.CameraBox.Items.AddRange(new object[] {
            "First Person",
            "Third Person (Back)",
            "Third Person (Front)"});
            this.CameraBox.Location = new System.Drawing.Point(104, 98);
            this.CameraBox.MaxDropDownItems = 3;
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(436, 29);
            this.CameraBox.TabIndex = 8;
            this.ToolTips.SetToolTip(this.CameraBox, "What camera prespective should we be in?");
            this.CameraBox.UseSelectable = true;
            this.CameraBox.ValueMember = "1";
            this.CameraBox.SelectedIndexChanged += new System.EventHandler(this.CameraBoxChanged);
            // 
            // OpenScoreboardBtn
            // 
            this.OpenScoreboardBtn.Location = new System.Drawing.Point(23, 133);
            this.OpenScoreboardBtn.Name = "OpenScoreboardBtn";
            this.OpenScoreboardBtn.Size = new System.Drawing.Size(517, 23);
            this.OpenScoreboardBtn.TabIndex = 9;
            this.OpenScoreboardBtn.Text = "Open Scoreboard";
            this.ToolTips.SetToolTip(this.OpenScoreboardBtn, "Opens the scoreboard");
            this.OpenScoreboardBtn.UseSelectable = true;
            this.OpenScoreboardBtn.Click += new System.EventHandler(this.OpenScoreboardBtnClicked);
            // 
            // GameModeBox
            // 
            this.GameModeBox.DisplayMember = "1";
            this.GameModeBox.FormattingEnabled = true;
            this.GameModeBox.ItemHeight = 23;
            this.GameModeBox.Items.AddRange(new object[] {
            "Survival",
            "Creative",
            "Adventure",
            "Spectator"});
            this.GameModeBox.Location = new System.Drawing.Point(139, 63);
            this.GameModeBox.MaxDropDownItems = 3;
            this.GameModeBox.Name = "GameModeBox";
            this.GameModeBox.Size = new System.Drawing.Size(401, 29);
            this.GameModeBox.TabIndex = 11;
            this.ToolTips.SetToolTip(this.GameModeBox, "What game mode should we be in?");
            this.GameModeBox.UseSelectable = true;
            this.GameModeBox.ValueMember = "0";
            this.GameModeBox.SelectedIndexChanged += new System.EventHandler(this.GameModeBoxChanged);
            // 
            // CameraLbl
            // 
            this.CameraLbl.AutoSize = true;
            this.CameraLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CameraLbl.Location = new System.Drawing.Point(19, 98);
            this.CameraLbl.Name = "CameraLbl";
            this.CameraLbl.Size = new System.Drawing.Size(75, 25);
            this.CameraLbl.TabIndex = 7;
            this.CameraLbl.Text = "Camera:";
            // 
            // GameModeLbl
            // 
            this.GameModeLbl.AutoSize = true;
            this.GameModeLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.GameModeLbl.Location = new System.Drawing.Point(19, 63);
            this.GameModeLbl.Name = "GameModeLbl";
            this.GameModeLbl.Size = new System.Drawing.Size(110, 25);
            this.GameModeLbl.TabIndex = 10;
            this.GameModeLbl.Text = "Game Mode:";
            // 
            // PlayerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 199);
            this.Controls.Add(this.GameModeBox);
            this.Controls.Add(this.GameModeLbl);
            this.Controls.Add(this.OpenScoreboardBtn);
            this.Controls.Add(this.CameraBox);
            this.Controls.Add(this.CameraLbl);
            this.Controls.Add(this.CloseContainersBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayerOptions";
            this.Resizable = false;
            this.Text = "Minecraft: Wii U Mod Injector - Player Options";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exiting);
            this.Load += new System.EventHandler(this.Init);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Components.MetroToolTip ToolTips;
        private MetroFramework.Controls.MetroButton CloseContainersBtn;
        private MetroFramework.Controls.MetroComboBox CameraBox;
        private MetroFramework.Controls.MetroLabel CameraLbl;
        private MetroFramework.Controls.MetroButton OpenScoreboardBtn;
        private MetroFramework.Controls.MetroComboBox GameModeBox;
        private MetroFramework.Controls.MetroLabel GameModeLbl;
    }
}