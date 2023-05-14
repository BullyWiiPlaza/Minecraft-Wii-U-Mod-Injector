namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    partial class EntityEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityEditor));
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ToolTips = new MetroFramework.Components.MetroToolTip();
            this.WoolMultiplier = new System.Windows.Forms.NumericUpDown();
            this.DontLoseWoolBox = new MetroFramework.Controls.MetroCheckBox();
            this.BabyRateSlider = new System.Windows.Forms.NumericUpDown();
            this.WoolMultiplierLbl = new MetroFramework.Controls.MetroLabel();
            this.SheepLbl = new MetroFramework.Controls.MetroLabel();
            this.armorPanel = new MetroFramework.Controls.MetroPanel();
            this.VillagersLbl = new MetroFramework.Controls.MetroLabel();
            this.VillagersPnl = new MetroFramework.Controls.MetroPanel();
            this.ProfessionBox = new MetroFramework.Controls.MetroComboBox();
            this.ProfessionLbl = new MetroFramework.Controls.MetroLabel();
            this.StyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.LlamaLbl = new MetroFramework.Controls.MetroLabel();
            this.LlamaPnl = new MetroFramework.Controls.MetroPanel();
            this.LlamaVariantBox = new MetroFramework.Controls.MetroComboBox();
            this.LlamaVariantLbl = new MetroFramework.Controls.MetroLabel();
            this.ParrotLbl = new MetroFramework.Controls.MetroLabel();
            this.ParrotPnl = new MetroFramework.Controls.MetroPanel();
            this.ParrotVariantBox = new MetroFramework.Controls.MetroComboBox();
            this.ParrotVariantLbl = new MetroFramework.Controls.MetroLabel();
            this.RabbitLbl = new MetroFramework.Controls.MetroLabel();
            this.RabbitPnl = new MetroFramework.Controls.MetroPanel();
            this.RabbitVariantBox = new MetroFramework.Controls.MetroComboBox();
            this.RabbitVariantLbl = new MetroFramework.Controls.MetroLabel();
            this.ZombieLbl = new MetroFramework.Controls.MetroLabel();
            this.ZombiePnl = new MetroFramework.Controls.MetroPanel();
            this.BabyRateLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WoolMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BabyRateSlider)).BeginInit();
            this.armorPanel.SuspendLayout();
            this.VillagersPnl.SuspendLayout();
            this.LlamaPnl.SuspendLayout();
            this.ParrotPnl.SuspendLayout();
            this.RabbitPnl.SuspendLayout();
            this.ZombiePnl.SuspendLayout();
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
            // WoolMultiplier
            // 
            this.StyleExtender.SetApplyMetroTheme(this.WoolMultiplier, true);
            this.WoolMultiplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.WoolMultiplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.WoolMultiplier.Location = new System.Drawing.Point(114, 10);
            this.WoolMultiplier.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.WoolMultiplier.Name = "WoolMultiplier";
            this.WoolMultiplier.Size = new System.Drawing.Size(135, 20);
            this.WoolMultiplier.TabIndex = 167;
            this.WoolMultiplier.Tag = "";
            this.ToolTips.SetToolTip(this.WoolMultiplier, "How much should we multiply wool from sheared sheep?");
            this.WoolMultiplier.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.WoolMultiplier.ValueChanged += new System.EventHandler(this.WoolMultiplierChanged);
            // 
            // DontLoseWoolBox
            // 
            this.DontLoseWoolBox.AutoSize = true;
            this.DontLoseWoolBox.Location = new System.Drawing.Point(114, 36);
            this.DontLoseWoolBox.Name = "DontLoseWoolBox";
            this.DontLoseWoolBox.Size = new System.Drawing.Size(105, 15);
            this.DontLoseWoolBox.TabIndex = 177;
            this.DontLoseWoolBox.Text = "Don\'t lose wool";
            this.DontLoseWoolBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.DontLoseWoolBox, "Sheep will not lose their wool when sheared");
            this.DontLoseWoolBox.UseSelectable = true;
            this.DontLoseWoolBox.CheckedChanged += new System.EventHandler(this.DontLoseWoolBoxChecked);
            // 
            // BabyRateSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.BabyRateSlider, true);
            this.BabyRateSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.BabyRateSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BabyRateSlider.Location = new System.Drawing.Point(82, 20);
            this.BabyRateSlider.Name = "BabyRateSlider";
            this.BabyRateSlider.Size = new System.Drawing.Size(197, 20);
            this.BabyRateSlider.TabIndex = 167;
            this.BabyRateSlider.Tag = "";
            this.ToolTips.SetToolTip(this.BabyRateSlider, "How frequent do baby zombies spawn?");
            this.BabyRateSlider.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BabyRateSlider.ValueChanged += new System.EventHandler(this.BabyRateSliderChanged);
            // 
            // WoolMultiplierLbl
            // 
            this.WoolMultiplierLbl.AutoSize = true;
            this.WoolMultiplierLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.WoolMultiplierLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WoolMultiplierLbl.Location = new System.Drawing.Point(3, 8);
            this.WoolMultiplierLbl.Name = "WoolMultiplierLbl";
            this.WoolMultiplierLbl.Size = new System.Drawing.Size(105, 19);
            this.WoolMultiplierLbl.TabIndex = 166;
            this.WoolMultiplierLbl.Tag = "";
            this.WoolMultiplierLbl.Text = "Wool Multiplier:";
            this.WoolMultiplierLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SheepLbl
            // 
            this.SheepLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheepLbl.AutoSize = true;
            this.SheepLbl.BackColor = System.Drawing.Color.Transparent;
            this.SheepLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SheepLbl.Location = new System.Drawing.Point(27, 53);
            this.SheepLbl.Name = "SheepLbl";
            this.SheepLbl.Size = new System.Drawing.Size(46, 19);
            this.SheepLbl.TabIndex = 171;
            this.SheepLbl.Text = "Sheep";
            this.SheepLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // armorPanel
            // 
            this.armorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.armorPanel.Controls.Add(this.DontLoseWoolBox);
            this.armorPanel.Controls.Add(this.WoolMultiplier);
            this.armorPanel.Controls.Add(this.WoolMultiplierLbl);
            this.armorPanel.HorizontalScrollbarBarColor = true;
            this.armorPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.armorPanel.HorizontalScrollbarSize = 10;
            this.armorPanel.Location = new System.Drawing.Point(23, 63);
            this.armorPanel.Name = "armorPanel";
            this.armorPanel.Size = new System.Drawing.Size(254, 60);
            this.armorPanel.TabIndex = 170;
            this.armorPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.armorPanel.VerticalScrollbarBarColor = true;
            this.armorPanel.VerticalScrollbarHighlightOnWheel = false;
            this.armorPanel.VerticalScrollbarSize = 10;
            // 
            // VillagersLbl
            // 
            this.VillagersLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VillagersLbl.AutoSize = true;
            this.VillagersLbl.BackColor = System.Drawing.Color.Transparent;
            this.VillagersLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.VillagersLbl.Location = new System.Drawing.Point(27, 126);
            this.VillagersLbl.Name = "VillagersLbl";
            this.VillagersLbl.Size = new System.Drawing.Size(54, 19);
            this.VillagersLbl.TabIndex = 173;
            this.VillagersLbl.Text = "Villager";
            this.VillagersLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // VillagersPnl
            // 
            this.VillagersPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VillagersPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VillagersPnl.Controls.Add(this.ProfessionBox);
            this.VillagersPnl.Controls.Add(this.ProfessionLbl);
            this.VillagersPnl.HorizontalScrollbarBarColor = true;
            this.VillagersPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.VillagersPnl.HorizontalScrollbarSize = 10;
            this.VillagersPnl.Location = new System.Drawing.Point(23, 136);
            this.VillagersPnl.Name = "VillagersPnl";
            this.VillagersPnl.Size = new System.Drawing.Size(254, 40);
            this.VillagersPnl.TabIndex = 172;
            this.VillagersPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VillagersPnl.VerticalScrollbarBarColor = true;
            this.VillagersPnl.VerticalScrollbarHighlightOnWheel = false;
            this.VillagersPnl.VerticalScrollbarSize = 10;
            // 
            // ProfessionBox
            // 
            this.ProfessionBox.FormattingEnabled = true;
            this.ProfessionBox.ItemHeight = 23;
            this.ProfessionBox.Items.AddRange(new object[] {
            "Farmer/Fletcher/Fisherman/Sheperd",
            "Librarian/Cartographer",
            "Cleric",
            "Tool/Weapon Smith",
            "Butcher/Leatherworker",
            "Nitwit"});
            this.ProfessionBox.Location = new System.Drawing.Point(84, 5);
            this.ProfessionBox.Name = "ProfessionBox";
            this.ProfessionBox.Size = new System.Drawing.Size(165, 29);
            this.ProfessionBox.TabIndex = 168;
            this.ProfessionBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.ProfessionBox, "What profession should all villagers be?");
            this.ProfessionBox.UseSelectable = true;
            this.ProfessionBox.SelectedIndexChanged += new System.EventHandler(this.ProfessionBoxChanged);
            // 
            // ProfessionLbl
            // 
            this.ProfessionLbl.AutoSize = true;
            this.ProfessionLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ProfessionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProfessionLbl.Location = new System.Drawing.Point(3, 10);
            this.ProfessionLbl.Name = "ProfessionLbl";
            this.ProfessionLbl.Size = new System.Drawing.Size(75, 19);
            this.ProfessionLbl.TabIndex = 167;
            this.ProfessionLbl.Tag = "";
            this.ProfessionLbl.Text = "Profession:";
            this.ProfessionLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // StyleExtender
            // 
            this.StyleExtender.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LlamaLbl
            // 
            this.LlamaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LlamaLbl.AutoSize = true;
            this.LlamaLbl.BackColor = System.Drawing.Color.Transparent;
            this.LlamaLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LlamaLbl.Location = new System.Drawing.Point(27, 181);
            this.LlamaLbl.Name = "LlamaLbl";
            this.LlamaLbl.Size = new System.Drawing.Size(45, 19);
            this.LlamaLbl.TabIndex = 177;
            this.LlamaLbl.Text = "Llama";
            this.LlamaLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LlamaPnl
            // 
            this.LlamaPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LlamaPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LlamaPnl.Controls.Add(this.LlamaVariantBox);
            this.LlamaPnl.Controls.Add(this.LlamaVariantLbl);
            this.LlamaPnl.HorizontalScrollbarBarColor = true;
            this.LlamaPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.LlamaPnl.HorizontalScrollbarSize = 10;
            this.LlamaPnl.Location = new System.Drawing.Point(23, 191);
            this.LlamaPnl.Name = "LlamaPnl";
            this.LlamaPnl.Size = new System.Drawing.Size(254, 40);
            this.LlamaPnl.TabIndex = 176;
            this.LlamaPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LlamaPnl.VerticalScrollbarBarColor = true;
            this.LlamaPnl.VerticalScrollbarHighlightOnWheel = false;
            this.LlamaPnl.VerticalScrollbarSize = 10;
            // 
            // LlamaVariantBox
            // 
            this.LlamaVariantBox.FormattingEnabled = true;
            this.LlamaVariantBox.ItemHeight = 23;
            this.LlamaVariantBox.Items.AddRange(new object[] {
            "Cream",
            "White",
            "Brown",
            "Gray"});
            this.LlamaVariantBox.Location = new System.Drawing.Point(64, 5);
            this.LlamaVariantBox.Name = "LlamaVariantBox";
            this.LlamaVariantBox.Size = new System.Drawing.Size(185, 29);
            this.LlamaVariantBox.TabIndex = 168;
            this.LlamaVariantBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.LlamaVariantBox, "Which variant should all llamas be?");
            this.LlamaVariantBox.UseSelectable = true;
            this.LlamaVariantBox.SelectedIndexChanged += new System.EventHandler(this.LlamaVariantBoxChanged);
            // 
            // LlamaVariantLbl
            // 
            this.LlamaVariantLbl.AutoSize = true;
            this.LlamaVariantLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LlamaVariantLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LlamaVariantLbl.Location = new System.Drawing.Point(3, 10);
            this.LlamaVariantLbl.Name = "LlamaVariantLbl";
            this.LlamaVariantLbl.Size = new System.Drawing.Size(55, 19);
            this.LlamaVariantLbl.TabIndex = 167;
            this.LlamaVariantLbl.Tag = "";
            this.LlamaVariantLbl.Text = "Variant:";
            this.LlamaVariantLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ParrotLbl
            // 
            this.ParrotLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParrotLbl.AutoSize = true;
            this.ParrotLbl.BackColor = System.Drawing.Color.Transparent;
            this.ParrotLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ParrotLbl.Location = new System.Drawing.Point(27, 236);
            this.ParrotLbl.Name = "ParrotLbl";
            this.ParrotLbl.Size = new System.Drawing.Size(47, 19);
            this.ParrotLbl.TabIndex = 179;
            this.ParrotLbl.Text = "Parrot";
            this.ParrotLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ParrotPnl
            // 
            this.ParrotPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParrotPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParrotPnl.Controls.Add(this.ParrotVariantBox);
            this.ParrotPnl.Controls.Add(this.ParrotVariantLbl);
            this.ParrotPnl.HorizontalScrollbarBarColor = true;
            this.ParrotPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.ParrotPnl.HorizontalScrollbarSize = 10;
            this.ParrotPnl.Location = new System.Drawing.Point(23, 246);
            this.ParrotPnl.Name = "ParrotPnl";
            this.ParrotPnl.Size = new System.Drawing.Size(254, 40);
            this.ParrotPnl.TabIndex = 178;
            this.ParrotPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ParrotPnl.VerticalScrollbarBarColor = true;
            this.ParrotPnl.VerticalScrollbarHighlightOnWheel = false;
            this.ParrotPnl.VerticalScrollbarSize = 10;
            // 
            // ParrotVariantBox
            // 
            this.ParrotVariantBox.FormattingEnabled = true;
            this.ParrotVariantBox.ItemHeight = 23;
            this.ParrotVariantBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Cyan",
            "Gray"});
            this.ParrotVariantBox.Location = new System.Drawing.Point(64, 5);
            this.ParrotVariantBox.Name = "ParrotVariantBox";
            this.ParrotVariantBox.Size = new System.Drawing.Size(185, 29);
            this.ParrotVariantBox.TabIndex = 168;
            this.ParrotVariantBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.ParrotVariantBox, "What variant should all parrots be?");
            this.ParrotVariantBox.UseSelectable = true;
            this.ParrotVariantBox.SelectedIndexChanged += new System.EventHandler(this.ParrotVariantBoxChanged);
            // 
            // ParrotVariantLbl
            // 
            this.ParrotVariantLbl.AutoSize = true;
            this.ParrotVariantLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ParrotVariantLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ParrotVariantLbl.Location = new System.Drawing.Point(3, 10);
            this.ParrotVariantLbl.Name = "ParrotVariantLbl";
            this.ParrotVariantLbl.Size = new System.Drawing.Size(55, 19);
            this.ParrotVariantLbl.TabIndex = 167;
            this.ParrotVariantLbl.Tag = "";
            this.ParrotVariantLbl.Text = "Variant:";
            this.ParrotVariantLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RabbitLbl
            // 
            this.RabbitLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RabbitLbl.AutoSize = true;
            this.RabbitLbl.BackColor = System.Drawing.Color.Transparent;
            this.RabbitLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.RabbitLbl.Location = new System.Drawing.Point(27, 291);
            this.RabbitLbl.Name = "RabbitLbl";
            this.RabbitLbl.Size = new System.Drawing.Size(48, 19);
            this.RabbitLbl.TabIndex = 181;
            this.RabbitLbl.Text = "Rabbit";
            this.RabbitLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RabbitPnl
            // 
            this.RabbitPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RabbitPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RabbitPnl.Controls.Add(this.RabbitVariantBox);
            this.RabbitPnl.Controls.Add(this.RabbitVariantLbl);
            this.RabbitPnl.HorizontalScrollbarBarColor = true;
            this.RabbitPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.RabbitPnl.HorizontalScrollbarSize = 10;
            this.RabbitPnl.Location = new System.Drawing.Point(23, 301);
            this.RabbitPnl.Name = "RabbitPnl";
            this.RabbitPnl.Size = new System.Drawing.Size(254, 40);
            this.RabbitPnl.TabIndex = 180;
            this.RabbitPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RabbitPnl.VerticalScrollbarBarColor = true;
            this.RabbitPnl.VerticalScrollbarHighlightOnWheel = false;
            this.RabbitPnl.VerticalScrollbarSize = 10;
            // 
            // RabbitVariantBox
            // 
            this.RabbitVariantBox.FormattingEnabled = true;
            this.RabbitVariantBox.ItemHeight = 23;
            this.RabbitVariantBox.Items.AddRange(new object[] {
            "Brown",
            "White",
            "Black",
            "Black and White",
            "Gold",
            "Salt and Pepper",
            "The Killer Bunny"});
            this.RabbitVariantBox.Location = new System.Drawing.Point(64, 5);
            this.RabbitVariantBox.Name = "RabbitVariantBox";
            this.RabbitVariantBox.Size = new System.Drawing.Size(185, 29);
            this.RabbitVariantBox.TabIndex = 168;
            this.RabbitVariantBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.RabbitVariantBox, "What variant should all rabbits be?");
            this.RabbitVariantBox.UseSelectable = true;
            this.RabbitVariantBox.SelectedIndexChanged += new System.EventHandler(this.RabbitVariantBoxChanged);
            // 
            // RabbitVariantLbl
            // 
            this.RabbitVariantLbl.AutoSize = true;
            this.RabbitVariantLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.RabbitVariantLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RabbitVariantLbl.Location = new System.Drawing.Point(3, 10);
            this.RabbitVariantLbl.Name = "RabbitVariantLbl";
            this.RabbitVariantLbl.Size = new System.Drawing.Size(55, 19);
            this.RabbitVariantLbl.TabIndex = 167;
            this.RabbitVariantLbl.Tag = "";
            this.RabbitVariantLbl.Text = "Variant:";
            this.RabbitVariantLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ZombieLbl
            // 
            this.ZombieLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZombieLbl.AutoSize = true;
            this.ZombieLbl.BackColor = System.Drawing.Color.Transparent;
            this.ZombieLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ZombieLbl.Location = new System.Drawing.Point(287, 53);
            this.ZombieLbl.Name = "ZombieLbl";
            this.ZombieLbl.Size = new System.Drawing.Size(55, 19);
            this.ZombieLbl.TabIndex = 183;
            this.ZombieLbl.Text = "Zombie";
            this.ZombieLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ZombiePnl
            // 
            this.ZombiePnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZombiePnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZombiePnl.Controls.Add(this.BabyRateSlider);
            this.ZombiePnl.Controls.Add(this.BabyRateLbl);
            this.ZombiePnl.HorizontalScrollbarBarColor = true;
            this.ZombiePnl.HorizontalScrollbarHighlightOnWheel = false;
            this.ZombiePnl.HorizontalScrollbarSize = 10;
            this.ZombiePnl.Location = new System.Drawing.Point(283, 63);
            this.ZombiePnl.Name = "ZombiePnl";
            this.ZombiePnl.Size = new System.Drawing.Size(284, 60);
            this.ZombiePnl.TabIndex = 182;
            this.ZombiePnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ZombiePnl.VerticalScrollbarBarColor = true;
            this.ZombiePnl.VerticalScrollbarHighlightOnWheel = false;
            this.ZombiePnl.VerticalScrollbarSize = 10;
            // 
            // BabyRateLbl
            // 
            this.BabyRateLbl.AutoSize = true;
            this.BabyRateLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.BabyRateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BabyRateLbl.Location = new System.Drawing.Point(3, 19);
            this.BabyRateLbl.Name = "BabyRateLbl";
            this.BabyRateLbl.Size = new System.Drawing.Size(73, 19);
            this.BabyRateLbl.TabIndex = 166;
            this.BabyRateLbl.Tag = "";
            this.BabyRateLbl.Text = "Baby Rate:";
            this.BabyRateLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // EntityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 350);
            this.Controls.Add(this.ZombieLbl);
            this.Controls.Add(this.ZombiePnl);
            this.Controls.Add(this.RabbitLbl);
            this.Controls.Add(this.RabbitPnl);
            this.Controls.Add(this.ParrotLbl);
            this.Controls.Add(this.ParrotPnl);
            this.Controls.Add(this.LlamaLbl);
            this.Controls.Add(this.LlamaPnl);
            this.Controls.Add(this.VillagersLbl);
            this.Controls.Add(this.VillagersPnl);
            this.Controls.Add(this.SheepLbl);
            this.Controls.Add(this.armorPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(3840, 350);
            this.MinimumSize = new System.Drawing.Size(590, 350);
            this.Name = "EntityEditor";
            this.Text = "Minecraft: Wii U Mod Injector - Entity Editor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exiting);
            this.Load += new System.EventHandler(this.Init);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WoolMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BabyRateSlider)).EndInit();
            this.armorPanel.ResumeLayout(false);
            this.armorPanel.PerformLayout();
            this.VillagersPnl.ResumeLayout(false);
            this.VillagersPnl.PerformLayout();
            this.LlamaPnl.ResumeLayout(false);
            this.LlamaPnl.PerformLayout();
            this.ParrotPnl.ResumeLayout(false);
            this.ParrotPnl.PerformLayout();
            this.RabbitPnl.ResumeLayout(false);
            this.RabbitPnl.PerformLayout();
            this.ZombiePnl.ResumeLayout(false);
            this.ZombiePnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Components.MetroToolTip ToolTips;
        public System.Windows.Forms.NumericUpDown WoolMultiplier;
        public MetroFramework.Controls.MetroLabel WoolMultiplierLbl;
        private MetroFramework.Controls.MetroLabel SheepLbl;
        private MetroFramework.Controls.MetroPanel armorPanel;
        private MetroFramework.Controls.MetroLabel VillagersLbl;
        private MetroFramework.Controls.MetroPanel VillagersPnl;
        private MetroFramework.Controls.MetroCheckBox DontLoseWoolBox;
        private MetroFramework.Components.MetroStyleExtender StyleExtender;
        private MetroFramework.Controls.MetroComboBox ProfessionBox;
        public MetroFramework.Controls.MetroLabel ProfessionLbl;
        private MetroFramework.Controls.MetroLabel LlamaLbl;
        private MetroFramework.Controls.MetroPanel LlamaPnl;
        private MetroFramework.Controls.MetroComboBox LlamaVariantBox;
        public MetroFramework.Controls.MetroLabel LlamaVariantLbl;
        private MetroFramework.Controls.MetroLabel ParrotLbl;
        private MetroFramework.Controls.MetroPanel ParrotPnl;
        private MetroFramework.Controls.MetroComboBox ParrotVariantBox;
        public MetroFramework.Controls.MetroLabel ParrotVariantLbl;
        private MetroFramework.Controls.MetroLabel RabbitLbl;
        private MetroFramework.Controls.MetroPanel RabbitPnl;
        private MetroFramework.Controls.MetroComboBox RabbitVariantBox;
        public MetroFramework.Controls.MetroLabel RabbitVariantLbl;
        private MetroFramework.Controls.MetroLabel ZombieLbl;
        private MetroFramework.Controls.MetroPanel ZombiePnl;
        public System.Windows.Forms.NumericUpDown BabyRateSlider;
        public MetroFramework.Controls.MetroLabel BabyRateLbl;
    }
}