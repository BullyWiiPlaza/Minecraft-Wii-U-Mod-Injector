namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    partial class EnchantmentEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnchantmentEditor));
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ToolTips = new MetroFramework.Components.MetroToolTip();
            this.DepthStriderLvlSlider = new System.Windows.Forms.NumericUpDown();
            this.DepthStriderLvl = new MetroFramework.Controls.MetroLabel();
            this.FrostWalkerLvlSlider = new System.Windows.Forms.NumericUpDown();
            this.FrostWalkerLvl = new MetroFramework.Controls.MetroLabel();
            this.ArmorLbl = new MetroFramework.Controls.MetroLabel();
            this.armorPanel = new MetroFramework.Controls.MetroPanel();
            this.ToolsLbl = new MetroFramework.Controls.MetroLabel();
            this.toolsPanel = new MetroFramework.Controls.MetroPanel();
            this.FireAspectSlider = new System.Windows.Forms.NumericUpDown();
            this.EfficiencySlider = new System.Windows.Forms.NumericUpDown();
            this.FireAspectLbl = new MetroFramework.Controls.MetroLabel();
            this.EfficiencyLbl = new MetroFramework.Controls.MetroLabel();
            this.LuckOfTheSeaSlider = new System.Windows.Forms.NumericUpDown();
            this.LuckOfTheSeaLbl = new MetroFramework.Controls.MetroLabel();
            this.LureSlider = new System.Windows.Forms.NumericUpDown();
            this.LureLbl = new MetroFramework.Controls.MetroLabel();
            this.LootingSlider = new System.Windows.Forms.NumericUpDown();
            this.LootingLbl = new MetroFramework.Controls.MetroLabel();
            this.KnockbackSlider = new System.Windows.Forms.NumericUpDown();
            this.KnockbackLbl = new MetroFramework.Controls.MetroLabel();
            this.RespirationSlider = new System.Windows.Forms.NumericUpDown();
            this.RespirationLbl = new MetroFramework.Controls.MetroLabel();
            this.cursesLbl = new MetroFramework.Controls.MetroLabel();
            this.cursesPanel = new MetroFramework.Controls.MetroPanel();
            this.BindingCurseBox = new MetroFramework.Controls.MetroCheckBox();
            this.AquaInfinityBox = new MetroFramework.Controls.MetroCheckBox();
            this.VanishingCurseBox = new MetroFramework.Controls.MetroCheckBox();
            this.ChannelingBox = new MetroFramework.Controls.MetroCheckBox();
            this.StyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthStriderLvlSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrostWalkerLvlSlider)).BeginInit();
            this.armorPanel.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireAspectSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfficiencySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuckOfTheSeaSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LureSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LootingSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KnockbackSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RespirationSlider)).BeginInit();
            this.cursesPanel.SuspendLayout();
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
            // DepthStriderLvlSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.DepthStriderLvlSlider, true);
            this.DepthStriderLvlSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DepthStriderLvlSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DepthStriderLvlSlider.Location = new System.Drawing.Point(97, 33);
            this.DepthStriderLvlSlider.Name = "DepthStriderLvlSlider";
            this.DepthStriderLvlSlider.Size = new System.Drawing.Size(138, 20);
            this.DepthStriderLvlSlider.TabIndex = 169;
            this.DepthStriderLvlSlider.Tag = "";
            this.ToolTips.SetToolTip(this.DepthStriderLvlSlider, "What level of Depth Strider do we have?");
            this.DepthStriderLvlSlider.ValueChanged += new System.EventHandler(this.DepthStriderLvlSliderChanged);
            // 
            // DepthStriderLvl
            // 
            this.DepthStriderLvl.AutoSize = true;
            this.DepthStriderLvl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.DepthStriderLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DepthStriderLvl.Location = new System.Drawing.Point(3, 34);
            this.DepthStriderLvl.Name = "DepthStriderLvl";
            this.DepthStriderLvl.Size = new System.Drawing.Size(94, 19);
            this.DepthStriderLvl.TabIndex = 168;
            this.DepthStriderLvl.Tag = "";
            this.DepthStriderLvl.Text = "Depth Strider:";
            // 
            // FrostWalkerLvlSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.FrostWalkerLvlSlider, true);
            this.FrostWalkerLvlSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FrostWalkerLvlSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FrostWalkerLvlSlider.Location = new System.Drawing.Point(97, 7);
            this.FrostWalkerLvlSlider.Name = "FrostWalkerLvlSlider";
            this.FrostWalkerLvlSlider.Size = new System.Drawing.Size(138, 20);
            this.FrostWalkerLvlSlider.TabIndex = 167;
            this.FrostWalkerLvlSlider.Tag = "";
            this.ToolTips.SetToolTip(this.FrostWalkerLvlSlider, "What level of Frost Walker do we have?");
            this.FrostWalkerLvlSlider.ValueChanged += new System.EventHandler(this.FrostWalkerLvlSliderChanged);
            // 
            // FrostWalkerLvl
            // 
            this.FrostWalkerLvl.AutoSize = true;
            this.FrostWalkerLvl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.FrostWalkerLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FrostWalkerLvl.Location = new System.Drawing.Point(3, 8);
            this.FrostWalkerLvl.Name = "FrostWalkerLvl";
            this.FrostWalkerLvl.Size = new System.Drawing.Size(88, 19);
            this.FrostWalkerLvl.TabIndex = 166;
            this.FrostWalkerLvl.Tag = "";
            this.FrostWalkerLvl.Text = "Frost Walker:";
            // 
            // ArmorLbl
            // 
            this.ArmorLbl.AutoSize = true;
            this.ArmorLbl.BackColor = System.Drawing.Color.Transparent;
            this.ArmorLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ArmorLbl.Location = new System.Drawing.Point(27, 53);
            this.ArmorLbl.Name = "ArmorLbl";
            this.ArmorLbl.Size = new System.Drawing.Size(48, 19);
            this.ArmorLbl.TabIndex = 171;
            this.ArmorLbl.Text = "Armor";
            // 
            // armorPanel
            // 
            this.armorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.armorPanel.Controls.Add(this.AquaInfinityBox);
            this.armorPanel.Controls.Add(this.RespirationSlider);
            this.armorPanel.Controls.Add(this.RespirationLbl);
            this.armorPanel.Controls.Add(this.DepthStriderLvlSlider);
            this.armorPanel.Controls.Add(this.FrostWalkerLvlSlider);
            this.armorPanel.Controls.Add(this.DepthStriderLvl);
            this.armorPanel.Controls.Add(this.FrostWalkerLvl);
            this.armorPanel.HorizontalScrollbarBarColor = true;
            this.armorPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.armorPanel.HorizontalScrollbarSize = 10;
            this.armorPanel.Location = new System.Drawing.Point(23, 63);
            this.armorPanel.Name = "armorPanel";
            this.armorPanel.Size = new System.Drawing.Size(254, 109);
            this.armorPanel.TabIndex = 170;
            this.armorPanel.VerticalScrollbarBarColor = true;
            this.armorPanel.VerticalScrollbarHighlightOnWheel = false;
            this.armorPanel.VerticalScrollbarSize = 10;
            // 
            // ToolsLbl
            // 
            this.ToolsLbl.AutoSize = true;
            this.ToolsLbl.BackColor = System.Drawing.Color.Transparent;
            this.ToolsLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ToolsLbl.Location = new System.Drawing.Point(27, 173);
            this.ToolsLbl.Name = "ToolsLbl";
            this.ToolsLbl.Size = new System.Drawing.Size(40, 19);
            this.ToolsLbl.TabIndex = 173;
            this.ToolsLbl.Text = "Tools";
            // 
            // toolsPanel
            // 
            this.toolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolsPanel.Controls.Add(this.ChannelingBox);
            this.toolsPanel.Controls.Add(this.KnockbackSlider);
            this.toolsPanel.Controls.Add(this.KnockbackLbl);
            this.toolsPanel.Controls.Add(this.LootingSlider);
            this.toolsPanel.Controls.Add(this.LootingLbl);
            this.toolsPanel.Controls.Add(this.LureSlider);
            this.toolsPanel.Controls.Add(this.LureLbl);
            this.toolsPanel.Controls.Add(this.LuckOfTheSeaSlider);
            this.toolsPanel.Controls.Add(this.LuckOfTheSeaLbl);
            this.toolsPanel.Controls.Add(this.FireAspectSlider);
            this.toolsPanel.Controls.Add(this.EfficiencySlider);
            this.toolsPanel.Controls.Add(this.FireAspectLbl);
            this.toolsPanel.Controls.Add(this.EfficiencyLbl);
            this.toolsPanel.HorizontalScrollbarBarColor = true;
            this.toolsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.toolsPanel.HorizontalScrollbarSize = 10;
            this.toolsPanel.Location = new System.Drawing.Point(23, 183);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(254, 193);
            this.toolsPanel.TabIndex = 172;
            this.toolsPanel.VerticalScrollbarBarColor = true;
            this.toolsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.toolsPanel.VerticalScrollbarSize = 10;
            // 
            // FireAspectSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.FireAspectSlider, true);
            this.FireAspectSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FireAspectSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FireAspectSlider.Location = new System.Drawing.Point(97, 33);
            this.FireAspectSlider.Name = "FireAspectSlider";
            this.FireAspectSlider.Size = new System.Drawing.Size(138, 20);
            this.FireAspectSlider.TabIndex = 169;
            this.FireAspectSlider.Tag = "";
            this.ToolTips.SetToolTip(this.FireAspectSlider, "What level of Fire Aspect do we have?");
            this.FireAspectSlider.ValueChanged += new System.EventHandler(this.FireAspectSliderChanged);
            // 
            // EfficiencySlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.EfficiencySlider, true);
            this.EfficiencySlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EfficiencySlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EfficiencySlider.Location = new System.Drawing.Point(97, 7);
            this.EfficiencySlider.Name = "EfficiencySlider";
            this.EfficiencySlider.Size = new System.Drawing.Size(138, 20);
            this.EfficiencySlider.TabIndex = 167;
            this.EfficiencySlider.Tag = "";
            this.ToolTips.SetToolTip(this.EfficiencySlider, "What level of Efficiency do we have?");
            this.EfficiencySlider.ValueChanged += new System.EventHandler(this.EfficiencySliderChanged);
            // 
            // FireAspectLbl
            // 
            this.FireAspectLbl.AutoSize = true;
            this.FireAspectLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.FireAspectLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FireAspectLbl.Location = new System.Drawing.Point(3, 34);
            this.FireAspectLbl.Name = "FireAspectLbl";
            this.FireAspectLbl.Size = new System.Drawing.Size(79, 19);
            this.FireAspectLbl.TabIndex = 168;
            this.FireAspectLbl.Tag = "";
            this.FireAspectLbl.Text = "Fire Aspect:";
            // 
            // EfficiencyLbl
            // 
            this.EfficiencyLbl.AutoSize = true;
            this.EfficiencyLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.EfficiencyLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EfficiencyLbl.Location = new System.Drawing.Point(3, 8);
            this.EfficiencyLbl.Name = "EfficiencyLbl";
            this.EfficiencyLbl.Size = new System.Drawing.Size(67, 19);
            this.EfficiencyLbl.TabIndex = 166;
            this.EfficiencyLbl.Tag = "";
            this.EfficiencyLbl.Text = "Efficiency:";
            // 
            // LuckOfTheSeaSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.LuckOfTheSeaSlider, true);
            this.LuckOfTheSeaSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LuckOfTheSeaSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LuckOfTheSeaSlider.Location = new System.Drawing.Point(119, 59);
            this.LuckOfTheSeaSlider.Name = "LuckOfTheSeaSlider";
            this.LuckOfTheSeaSlider.Size = new System.Drawing.Size(116, 20);
            this.LuckOfTheSeaSlider.TabIndex = 171;
            this.LuckOfTheSeaSlider.Tag = "";
            this.ToolTips.SetToolTip(this.LuckOfTheSeaSlider, "What level of Luck Of The Sea do we have?");
            this.LuckOfTheSeaSlider.ValueChanged += new System.EventHandler(this.LuckOfTheSeaSliderChanged);
            // 
            // LuckOfTheSeaLbl
            // 
            this.LuckOfTheSeaLbl.AutoSize = true;
            this.LuckOfTheSeaLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LuckOfTheSeaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LuckOfTheSeaLbl.Location = new System.Drawing.Point(3, 60);
            this.LuckOfTheSeaLbl.Name = "LuckOfTheSeaLbl";
            this.LuckOfTheSeaLbl.Size = new System.Drawing.Size(110, 19);
            this.LuckOfTheSeaLbl.TabIndex = 170;
            this.LuckOfTheSeaLbl.Tag = "";
            this.LuckOfTheSeaLbl.Text = "Luck Of The Sea:";
            // 
            // LureSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.LureSlider, true);
            this.LureSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LureSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LureSlider.Location = new System.Drawing.Point(97, 85);
            this.LureSlider.Name = "LureSlider";
            this.LureSlider.Size = new System.Drawing.Size(138, 20);
            this.LureSlider.TabIndex = 173;
            this.LureSlider.Tag = "";
            this.ToolTips.SetToolTip(this.LureSlider, "What level of Lure do we have?");
            this.LureSlider.ValueChanged += new System.EventHandler(this.LureSliderChanged);
            // 
            // LureLbl
            // 
            this.LureLbl.AutoSize = true;
            this.LureLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LureLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LureLbl.Location = new System.Drawing.Point(3, 86);
            this.LureLbl.Name = "LureLbl";
            this.LureLbl.Size = new System.Drawing.Size(39, 19);
            this.LureLbl.TabIndex = 172;
            this.LureLbl.Tag = "";
            this.LureLbl.Text = "Lure:";
            // 
            // LootingSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.LootingSlider, true);
            this.LootingSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LootingSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LootingSlider.Location = new System.Drawing.Point(97, 111);
            this.LootingSlider.Name = "LootingSlider";
            this.LootingSlider.Size = new System.Drawing.Size(138, 20);
            this.LootingSlider.TabIndex = 175;
            this.LootingSlider.Tag = "";
            this.ToolTips.SetToolTip(this.LootingSlider, "What level of Looting do we have?");
            this.LootingSlider.ValueChanged += new System.EventHandler(this.LootingSliderChanged);
            // 
            // LootingLbl
            // 
            this.LootingLbl.AutoSize = true;
            this.LootingLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LootingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LootingLbl.Location = new System.Drawing.Point(3, 112);
            this.LootingLbl.Name = "LootingLbl";
            this.LootingLbl.Size = new System.Drawing.Size(59, 19);
            this.LootingLbl.TabIndex = 174;
            this.LootingLbl.Tag = "";
            this.LootingLbl.Text = "Looting:";
            // 
            // KnockbackSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.KnockbackSlider, true);
            this.KnockbackSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.KnockbackSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KnockbackSlider.Location = new System.Drawing.Point(97, 137);
            this.KnockbackSlider.Name = "KnockbackSlider";
            this.KnockbackSlider.Size = new System.Drawing.Size(138, 20);
            this.KnockbackSlider.TabIndex = 177;
            this.KnockbackSlider.Tag = "";
            this.ToolTips.SetToolTip(this.KnockbackSlider, "What level of Knockback do we have?");
            this.KnockbackSlider.ValueChanged += new System.EventHandler(this.KnockbackSliderChanged);
            // 
            // KnockbackLbl
            // 
            this.KnockbackLbl.AutoSize = true;
            this.KnockbackLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.KnockbackLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KnockbackLbl.Location = new System.Drawing.Point(3, 138);
            this.KnockbackLbl.Name = "KnockbackLbl";
            this.KnockbackLbl.Size = new System.Drawing.Size(77, 19);
            this.KnockbackLbl.TabIndex = 176;
            this.KnockbackLbl.Tag = "";
            this.KnockbackLbl.Text = "Knockback:";
            // 
            // RespirationSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.RespirationSlider, true);
            this.RespirationSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RespirationSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RespirationSlider.Location = new System.Drawing.Point(97, 59);
            this.RespirationSlider.Name = "RespirationSlider";
            this.RespirationSlider.Size = new System.Drawing.Size(138, 20);
            this.RespirationSlider.TabIndex = 171;
            this.RespirationSlider.Tag = "";
            this.ToolTips.SetToolTip(this.RespirationSlider, "What level of Respiration do we have?");
            this.RespirationSlider.ValueChanged += new System.EventHandler(this.RespirationSliderChanged);
            // 
            // RespirationLbl
            // 
            this.RespirationLbl.AutoSize = true;
            this.RespirationLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.RespirationLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RespirationLbl.Location = new System.Drawing.Point(3, 60);
            this.RespirationLbl.Name = "RespirationLbl";
            this.RespirationLbl.Size = new System.Drawing.Size(80, 19);
            this.RespirationLbl.TabIndex = 170;
            this.RespirationLbl.Tag = "";
            this.RespirationLbl.Text = "Respiration:";
            // 
            // cursesLbl
            // 
            this.cursesLbl.AutoSize = true;
            this.cursesLbl.BackColor = System.Drawing.Color.Transparent;
            this.cursesLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.cursesLbl.Location = new System.Drawing.Point(287, 53);
            this.cursesLbl.Name = "cursesLbl";
            this.cursesLbl.Size = new System.Drawing.Size(50, 19);
            this.cursesLbl.TabIndex = 175;
            this.cursesLbl.Text = "Curses";
            // 
            // cursesPanel
            // 
            this.cursesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cursesPanel.Controls.Add(this.VanishingCurseBox);
            this.cursesPanel.Controls.Add(this.BindingCurseBox);
            this.cursesPanel.HorizontalScrollbarBarColor = true;
            this.cursesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.cursesPanel.HorizontalScrollbarSize = 10;
            this.cursesPanel.Location = new System.Drawing.Point(283, 63);
            this.cursesPanel.Name = "cursesPanel";
            this.cursesPanel.Size = new System.Drawing.Size(310, 313);
            this.cursesPanel.TabIndex = 174;
            this.cursesPanel.VerticalScrollbarBarColor = true;
            this.cursesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.cursesPanel.VerticalScrollbarSize = 10;
            // 
            // BindingCurseBox
            // 
            this.BindingCurseBox.AutoSize = true;
            this.BindingCurseBox.Location = new System.Drawing.Point(3, 11);
            this.BindingCurseBox.Name = "BindingCurseBox";
            this.BindingCurseBox.Size = new System.Drawing.Size(111, 15);
            this.BindingCurseBox.TabIndex = 176;
            this.BindingCurseBox.Text = "Curse of Binding";
            this.ToolTips.SetToolTip(this.BindingCurseBox, "Whether to always enable Curse of Binding");
            this.BindingCurseBox.UseSelectable = true;
            this.BindingCurseBox.CheckedChanged += new System.EventHandler(this.BindingCurseBoxChecked);
            // 
            // AquaInfinityBox
            // 
            this.AquaInfinityBox.AutoSize = true;
            this.AquaInfinityBox.Location = new System.Drawing.Point(97, 85);
            this.AquaInfinityBox.Name = "AquaInfinityBox";
            this.AquaInfinityBox.Size = new System.Drawing.Size(91, 15);
            this.AquaInfinityBox.TabIndex = 177;
            this.AquaInfinityBox.Text = "Aqua Infinity";
            this.ToolTips.SetToolTip(this.AquaInfinityBox, "Whether to always enable Aqua Infinity");
            this.AquaInfinityBox.UseSelectable = true;
            this.AquaInfinityBox.CheckedChanged += new System.EventHandler(this.AquaInfinityBoxChecked);
            // 
            // VanishingCurseBox
            // 
            this.VanishingCurseBox.AutoSize = true;
            this.VanishingCurseBox.Location = new System.Drawing.Point(3, 32);
            this.VanishingCurseBox.Name = "VanishingCurseBox";
            this.VanishingCurseBox.Size = new System.Drawing.Size(121, 15);
            this.VanishingCurseBox.TabIndex = 177;
            this.VanishingCurseBox.Text = "Curse of Vanishing";
            this.ToolTips.SetToolTip(this.VanishingCurseBox, "Whether to always enable Curse of Vanishing");
            this.VanishingCurseBox.UseSelectable = true;
            this.VanishingCurseBox.CheckedChanged += new System.EventHandler(this.VanishingCurseBoxChecked);
            // 
            // ChannelingBox
            // 
            this.ChannelingBox.AutoSize = true;
            this.ChannelingBox.Location = new System.Drawing.Point(97, 163);
            this.ChannelingBox.Name = "ChannelingBox";
            this.ChannelingBox.Size = new System.Drawing.Size(84, 15);
            this.ChannelingBox.TabIndex = 178;
            this.ChannelingBox.Text = "Channeling";
            this.ToolTips.SetToolTip(this.ChannelingBox, "Whether to always enable Channeling");
            this.ChannelingBox.UseSelectable = true;
            this.ChannelingBox.CheckedChanged += new System.EventHandler(this.ChannelingBoxChecked);
            // 
            // EnchantmentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 383);
            this.Controls.Add(this.cursesLbl);
            this.Controls.Add(this.cursesPanel);
            this.Controls.Add(this.ToolsLbl);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.ArmorLbl);
            this.Controls.Add(this.armorPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EnchantmentEditor";
            this.Resizable = false;
            this.Text = "Minecraft: Wii U Mod Injector - Enchantment Editor";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exiting);
            this.Load += new System.EventHandler(this.Init);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthStriderLvlSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrostWalkerLvlSlider)).EndInit();
            this.armorPanel.ResumeLayout(false);
            this.armorPanel.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireAspectSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfficiencySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuckOfTheSeaSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LureSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LootingSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KnockbackSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RespirationSlider)).EndInit();
            this.cursesPanel.ResumeLayout(false);
            this.cursesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Components.MetroToolTip ToolTips;
        public System.Windows.Forms.NumericUpDown DepthStriderLvlSlider;
        public MetroFramework.Controls.MetroLabel DepthStriderLvl;
        public System.Windows.Forms.NumericUpDown FrostWalkerLvlSlider;
        public MetroFramework.Controls.MetroLabel FrostWalkerLvl;
        private MetroFramework.Controls.MetroLabel ArmorLbl;
        private MetroFramework.Controls.MetroPanel armorPanel;
        private MetroFramework.Controls.MetroLabel ToolsLbl;
        private MetroFramework.Controls.MetroPanel toolsPanel;
        public System.Windows.Forms.NumericUpDown FireAspectSlider;
        public System.Windows.Forms.NumericUpDown EfficiencySlider;
        public MetroFramework.Controls.MetroLabel FireAspectLbl;
        public MetroFramework.Controls.MetroLabel EfficiencyLbl;
        public System.Windows.Forms.NumericUpDown LuckOfTheSeaSlider;
        public MetroFramework.Controls.MetroLabel LuckOfTheSeaLbl;
        public System.Windows.Forms.NumericUpDown LureSlider;
        public MetroFramework.Controls.MetroLabel LureLbl;
        public System.Windows.Forms.NumericUpDown LootingSlider;
        public MetroFramework.Controls.MetroLabel LootingLbl;
        public System.Windows.Forms.NumericUpDown KnockbackSlider;
        public MetroFramework.Controls.MetroLabel KnockbackLbl;
        public System.Windows.Forms.NumericUpDown RespirationSlider;
        public MetroFramework.Controls.MetroLabel RespirationLbl;
        private MetroFramework.Controls.MetroLabel cursesLbl;
        private MetroFramework.Controls.MetroPanel cursesPanel;
        private MetroFramework.Controls.MetroCheckBox VanishingCurseBox;
        private MetroFramework.Controls.MetroCheckBox BindingCurseBox;
        private MetroFramework.Controls.MetroCheckBox ChannelingBox;
        private MetroFramework.Controls.MetroCheckBox AquaInfinityBox;
        private MetroFramework.Components.MetroStyleExtender StyleExtender;
    }
}