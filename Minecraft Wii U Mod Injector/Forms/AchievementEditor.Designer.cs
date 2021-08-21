namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    partial class AchievementEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AchievementEditor));
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ToolTips = new MetroFramework.Components.MetroToolTip();
            this.withBox = new MetroFramework.Controls.MetroComboBox();
            this.ApplyBtn = new MetroFramework.Controls.MetroButton();
            this.replaceBox = new MetroFramework.Controls.MetroComboBox();
            this.withLbl = new MetroFramework.Controls.MetroLabel();
            this.replaceLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            this.StyleMngr.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ToolTips
            // 
            this.ToolTips.Style = MetroFramework.MetroColorStyle.Default;
            this.ToolTips.StyleManager = null;
            this.ToolTips.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // withBox
            // 
            this.withBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.withBox.DisplayMember = "1";
            this.withBox.FormattingEnabled = true;
            this.withBox.ItemHeight = 23;
            this.withBox.Items.AddRange(new object[] {
            "Taking Inventory",
            "Getting Wood",
            "Benchmarking",
            "Time to Mine!",
            "Hot Topic",
            "Acquire Hardware",
            "Time to Farm!",
            "Bake Bread",
            "The Lie",
            "Getting an Upgrade",
            "Delicious Fish",
            "On A Rail",
            "Time to Strike!",
            "Monster Hunter",
            "Cow Tipper",
            "When Pigs Fly",
            "Leader of the Pack",
            "MOAR Tools",
            "Dispense With This",
            "Into The Nether",
            "Pork Chop",
            "Passing the Time",
            "Archer",
            "Sniper Duel",
            "DIAMONDS!",
            "Return to Sender",
            "Into Fire",
            "Local Brewery",
            "The End?",
            "The End.",
            "Enchanter",
            "Overkill",
            "Librarian",
            "Adventuring Time",
            "Repopulation",
            "Diamonds to you!",
            "The Haggler",
            "Pot Planter",
            "It\'s a Sign!",
            "Iron Belly",
            "Have a Shearful Day",
            "Rainbow Collection",
            "Stayin\' Frosty",
            "Chestful of Cobblestone",
            "Renewable Energy",
            "Music to my Ears",
            "Body Guard",
            "Iron Man",
            "Zombie Doctor",
            "Lion Tamer",
            "The Beginning?",
            "The Beginning.",
            "Beaconator",
            "Overpowered",
            "Tie Dye Outfit",
            "Trampoline",
            "The Student...",
            "...has become the Master",
            "\'Tis but a scratch",
            "Cupid",
            "Hunger Pain",
            "Mine!",
            "The End... Again...",
            "You Need a Mint",
            "Super Sonic",
            "Dry Spell",
            "Free Diver",
            "Super Fuel",
            "Saddle Up",
            "Taste of Your Own Medicine",
            "Beam Me Up",
            "Map Room",
            "Camouflage",
            "Back from the Dead",
            "S-No Throw",
            "Snow Storm",
            "Hotshot",
            "Snowplough",
            "Overlord",
            "Underdog",
            "The Deep End",
            "Great View From Up Here",
            "Change of Sheets",
            "Cheating Death",
            "So I Got That Going For Me...",
            "Let It Go!",
            "Feeling Ill",
            "One Pickle, Two Pickle, Sea Pickle, Four",
            "Alternative Fuel",
            "Moskstraumen",
            "Castaway",
            "Sleep with the Fishes",
            "Echolocation"});
            this.withBox.Location = new System.Drawing.Point(72, 98);
            this.withBox.MaxDropDownItems = 3;
            this.withBox.Name = "withBox";
            this.withBox.Size = new System.Drawing.Size(477, 29);
            this.withBox.TabIndex = 8;
            this.withBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.withBox, "Which achievement do you want to replace the selected one with?");
            this.withBox.UseSelectable = true;
            this.withBox.ValueMember = "1";
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyBtn.Location = new System.Drawing.Point(23, 133);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(526, 23);
            this.ApplyBtn.TabIndex = 9;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.ApplyBtn, "Applies the achievement edit");
            this.ApplyBtn.UseSelectable = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtnClicked);
            // 
            // replaceBox
            // 
            this.replaceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceBox.DisplayMember = "1";
            this.replaceBox.FormattingEnabled = true;
            this.replaceBox.ItemHeight = 23;
            this.replaceBox.Items.AddRange(new object[] {
            "Taking Inventory",
            "Getting Wood",
            "Benchmarking",
            "Time to Mine!",
            "Hot Topic",
            "Acquire Hardware",
            "Time to Farm!",
            "Bake Bread",
            "The Lie",
            "Getting an Upgrade",
            "Delicious Fish",
            "On A Rail",
            "Time to Strike!",
            "Monster Hunter",
            "Cow Tipper",
            "When Pigs Fly",
            "Leader of the Pack",
            "MOAR Tools",
            "Dispense With This",
            "Into The Nether",
            "Pork Chop",
            "Passing the Time",
            "Archer",
            "Sniper Duel",
            "DIAMONDS!",
            "Return to Sender",
            "Into Fire",
            "Local Brewery",
            "The End?",
            "The End.",
            "Enchanter",
            "Overkill",
            "Librarian",
            "Adventuring Time",
            "Repopulation",
            "Diamonds to you!",
            "The Haggler",
            "Pot Planter",
            "It\'s a Sign!",
            "Iron Belly",
            "Have a Shearful Day",
            "Rainbow Collection",
            "Stayin\' Frosty",
            "Chestful of Cobblestone",
            "Renewable Energy",
            "Music to my Ears",
            "Body Guard",
            "Iron Man",
            "Zombie Doctor",
            "Lion Tamer",
            "The Beginning?",
            "The Beginning.",
            "Beaconator",
            "Overpowered",
            "Tie Dye Outfit",
            "Trampoline",
            "The Student...",
            "...has become the Master",
            "\'Tis but a scratch",
            "Cupid",
            "Hunger Pain",
            "Mine!",
            "The End... Again...",
            "You Need a Mint",
            "Super Sonic",
            "Dry Spell",
            "Free Diver",
            "Super Fuel",
            "Saddle Up",
            "Taste of Your Own Medicine",
            "Beam Me Up",
            "Map Room",
            "Camouflage",
            "Back from the Dead",
            "S-No Throw",
            "Snow Storm",
            "Hotshot",
            "Snowplough",
            "Overlord",
            "Underdog",
            "The Deep End",
            "Great View From Up Here",
            "Change of Sheets",
            "Cheating Death",
            "So I Got That Going For Me...",
            "Let It Go!",
            "Feeling Ill",
            "One Pickle, Two Pickle, Sea Pickle, Four",
            "Alternative Fuel",
            "Moskstraumen",
            "Castaway",
            "Sleep with the Fishes",
            "Echolocation"});
            this.replaceBox.Location = new System.Drawing.Point(100, 63);
            this.replaceBox.MaxDropDownItems = 3;
            this.replaceBox.Name = "replaceBox";
            this.replaceBox.Size = new System.Drawing.Size(449, 29);
            this.replaceBox.TabIndex = 11;
            this.replaceBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.replaceBox, "What achievement should be edited?");
            this.replaceBox.UseSelectable = true;
            this.replaceBox.ValueMember = "0";
            // 
            // withLbl
            // 
            this.withLbl.AutoSize = true;
            this.withLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.withLbl.Location = new System.Drawing.Point(19, 98);
            this.withLbl.Name = "withLbl";
            this.withLbl.Size = new System.Drawing.Size(47, 25);
            this.withLbl.TabIndex = 7;
            this.withLbl.Text = "with:";
            this.withLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // replaceLbl
            // 
            this.replaceLbl.AutoSize = true;
            this.replaceLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.replaceLbl.Location = new System.Drawing.Point(19, 63);
            this.replaceLbl.Name = "replaceLbl";
            this.replaceLbl.Size = new System.Drawing.Size(75, 25);
            this.replaceLbl.TabIndex = 10;
            this.replaceLbl.Text = "Replace:";
            this.replaceLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AchievementEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 173);
            this.Controls.Add(this.replaceBox);
            this.Controls.Add(this.replaceLbl);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.withBox);
            this.Controls.Add(this.withLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(572, 173);
            this.Name = "AchievementEditor";
            this.Resizable = false;
            this.Text = "Minecraft: Wii U Mod Injector - Achievement Editor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
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
        private MetroFramework.Controls.MetroComboBox withBox;
        private MetroFramework.Controls.MetroLabel withLbl;
        private MetroFramework.Controls.MetroButton ApplyBtn;
        private MetroFramework.Controls.MetroComboBox replaceBox;
        private MetroFramework.Controls.MetroLabel replaceLbl;
    }
}