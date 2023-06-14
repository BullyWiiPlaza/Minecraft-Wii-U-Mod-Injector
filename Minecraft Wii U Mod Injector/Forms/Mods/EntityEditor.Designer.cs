using System.Windows.Forms;

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
            this.ProfessionBox = new MetroFramework.Controls.MetroComboBox();
            this.LlamaVariantBox = new MetroFramework.Controls.MetroComboBox();
            this.ParrotVariantBox = new MetroFramework.Controls.MetroComboBox();
            this.RabbitVariantBox = new MetroFramework.Controls.MetroComboBox();
            this.ReplaceEntityBtn = new MetroFramework.Controls.MetroTile();
            this.WoolMultiplierLbl = new MetroFramework.Controls.MetroLabel();
            this.SheepLbl = new MetroFramework.Controls.MetroLabel();
            this.armorPanel = new MetroFramework.Controls.MetroPanel();
            this.VillagersLbl = new MetroFramework.Controls.MetroLabel();
            this.VillagersPnl = new MetroFramework.Controls.MetroPanel();
            this.ProfessionLbl = new MetroFramework.Controls.MetroLabel();
            this.StyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.LlamaLbl = new MetroFramework.Controls.MetroLabel();
            this.LlamaPnl = new MetroFramework.Controls.MetroPanel();
            this.LlamaVariantLbl = new MetroFramework.Controls.MetroLabel();
            this.ParrotLbl = new MetroFramework.Controls.MetroLabel();
            this.ParrotPnl = new MetroFramework.Controls.MetroPanel();
            this.ParrotVariantLbl = new MetroFramework.Controls.MetroLabel();
            this.RabbitLbl = new MetroFramework.Controls.MetroLabel();
            this.RabbitPnl = new MetroFramework.Controls.MetroPanel();
            this.RabbitVariantLbl = new MetroFramework.Controls.MetroLabel();
            this.ZombieLbl = new MetroFramework.Controls.MetroLabel();
            this.ZombiePnl = new MetroFramework.Controls.MetroPanel();
            this.BabyRateLbl = new MetroFramework.Controls.MetroLabel();
            this.EntityReplacerLbl = new MetroFramework.Controls.MetroLabel();
            this.EntitySwapPnl = new MetroFramework.Controls.MetroPanel();
            this.WithEntity = new MetroFramework.Controls.MetroComboBox();
            this.WithLbl = new MetroFramework.Controls.MetroLabel();
            this.ReplaceEntity = new MetroFramework.Controls.MetroComboBox();
            this.ReplaceLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WoolMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BabyRateSlider)).BeginInit();
            this.armorPanel.SuspendLayout();
            this.VillagersPnl.SuspendLayout();
            this.LlamaPnl.SuspendLayout();
            this.ParrotPnl.SuspendLayout();
            this.RabbitPnl.SuspendLayout();
            this.ZombiePnl.SuspendLayout();
            this.EntitySwapPnl.SuspendLayout();
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
            resources.ApplyResources(this.WoolMultiplier, "WoolMultiplier");
            this.WoolMultiplier.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.WoolMultiplier.Name = "WoolMultiplier";
            this.WoolMultiplier.Tag = "";
            this.ToolTips.SetToolTip(this.WoolMultiplier, resources.GetString("WoolMultiplier.ToolTip"));
            this.WoolMultiplier.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.WoolMultiplier.ValueChanged += new System.EventHandler(this.WoolMultiplierChanged);
            // 
            // DontLoseWoolBox
            // 
            resources.ApplyResources(this.DontLoseWoolBox, "DontLoseWoolBox");
            this.DontLoseWoolBox.Name = "DontLoseWoolBox";
            this.DontLoseWoolBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.DontLoseWoolBox, resources.GetString("DontLoseWoolBox.ToolTip"));
            this.DontLoseWoolBox.UseSelectable = true;
            this.DontLoseWoolBox.CheckedChanged += new System.EventHandler(this.DontLoseWoolBoxChecked);
            // 
            // BabyRateSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.BabyRateSlider, true);
            this.BabyRateSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.BabyRateSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            resources.ApplyResources(this.BabyRateSlider, "BabyRateSlider");
            this.BabyRateSlider.Name = "BabyRateSlider";
            this.BabyRateSlider.Tag = "";
            this.ToolTips.SetToolTip(this.BabyRateSlider, resources.GetString("BabyRateSlider.ToolTip"));
            this.BabyRateSlider.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BabyRateSlider.ValueChanged += new System.EventHandler(this.BabyRateSliderChanged);
            // 
            // ProfessionBox
            // 
            this.ProfessionBox.FormattingEnabled = true;
            resources.ApplyResources(this.ProfessionBox, "ProfessionBox");
            this.ProfessionBox.Items.AddRange(new object[] {
            resources.GetString("ProfessionBox.Items"),
            resources.GetString("ProfessionBox.Items1"),
            resources.GetString("ProfessionBox.Items2"),
            resources.GetString("ProfessionBox.Items3"),
            resources.GetString("ProfessionBox.Items4"),
            resources.GetString("ProfessionBox.Items5")});
            this.ProfessionBox.Name = "ProfessionBox";
            this.ProfessionBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.ProfessionBox, resources.GetString("ProfessionBox.ToolTip"));
            this.ProfessionBox.UseSelectable = true;
            this.ProfessionBox.SelectedIndexChanged += new System.EventHandler(this.ProfessionBoxChanged);
            // 
            // LlamaVariantBox
            // 
            this.LlamaVariantBox.FormattingEnabled = true;
            resources.ApplyResources(this.LlamaVariantBox, "LlamaVariantBox");
            this.LlamaVariantBox.Items.AddRange(new object[] {
            resources.GetString("LlamaVariantBox.Items"),
            resources.GetString("LlamaVariantBox.Items1"),
            resources.GetString("LlamaVariantBox.Items2"),
            resources.GetString("LlamaVariantBox.Items3")});
            this.LlamaVariantBox.Name = "LlamaVariantBox";
            this.LlamaVariantBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.LlamaVariantBox, resources.GetString("LlamaVariantBox.ToolTip"));
            this.LlamaVariantBox.UseSelectable = true;
            this.LlamaVariantBox.SelectedIndexChanged += new System.EventHandler(this.LlamaVariantBoxChanged);
            // 
            // ParrotVariantBox
            // 
            this.ParrotVariantBox.FormattingEnabled = true;
            resources.ApplyResources(this.ParrotVariantBox, "ParrotVariantBox");
            this.ParrotVariantBox.Items.AddRange(new object[] {
            resources.GetString("ParrotVariantBox.Items"),
            resources.GetString("ParrotVariantBox.Items1"),
            resources.GetString("ParrotVariantBox.Items2"),
            resources.GetString("ParrotVariantBox.Items3"),
            resources.GetString("ParrotVariantBox.Items4")});
            this.ParrotVariantBox.Name = "ParrotVariantBox";
            this.ParrotVariantBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.ParrotVariantBox, resources.GetString("ParrotVariantBox.ToolTip"));
            this.ParrotVariantBox.UseSelectable = true;
            this.ParrotVariantBox.SelectedIndexChanged += new System.EventHandler(this.ParrotVariantBoxChanged);
            // 
            // RabbitVariantBox
            // 
            this.RabbitVariantBox.FormattingEnabled = true;
            resources.ApplyResources(this.RabbitVariantBox, "RabbitVariantBox");
            this.RabbitVariantBox.Items.AddRange(new object[] {
            resources.GetString("RabbitVariantBox.Items"),
            resources.GetString("RabbitVariantBox.Items1"),
            resources.GetString("RabbitVariantBox.Items2"),
            resources.GetString("RabbitVariantBox.Items3"),
            resources.GetString("RabbitVariantBox.Items4"),
            resources.GetString("RabbitVariantBox.Items5"),
            resources.GetString("RabbitVariantBox.Items6")});
            this.RabbitVariantBox.Name = "RabbitVariantBox";
            this.RabbitVariantBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.RabbitVariantBox, resources.GetString("RabbitVariantBox.ToolTip"));
            this.RabbitVariantBox.UseSelectable = true;
            this.RabbitVariantBox.SelectedIndexChanged += new System.EventHandler(this.RabbitVariantBoxChanged);
            // 
            // ReplaceEntityBtn
            // 
            this.ReplaceEntityBtn.ActiveControl = null;
            resources.ApplyResources(this.ReplaceEntityBtn, "ReplaceEntityBtn");
            this.ReplaceEntityBtn.Name = "ReplaceEntityBtn";
            this.ToolTips.SetToolTip(this.ReplaceEntityBtn, resources.GetString("ReplaceEntityBtn.ToolTip"));
            this.ReplaceEntityBtn.UseSelectable = true;
            this.ReplaceEntityBtn.Click += new System.EventHandler(this.ReplaceEntityBtn_Clicked);
            // 
            // WoolMultiplierLbl
            // 
            resources.ApplyResources(this.WoolMultiplierLbl, "WoolMultiplierLbl");
            this.WoolMultiplierLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.WoolMultiplierLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WoolMultiplierLbl.Name = "WoolMultiplierLbl";
            this.WoolMultiplierLbl.Tag = "";
            this.WoolMultiplierLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SheepLbl
            // 
            resources.ApplyResources(this.SheepLbl, "SheepLbl");
            this.SheepLbl.BackColor = System.Drawing.Color.Transparent;
            this.SheepLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SheepLbl.Name = "SheepLbl";
            this.SheepLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // armorPanel
            // 
            this.armorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.armorPanel.Controls.Add(this.DontLoseWoolBox);
            this.armorPanel.Controls.Add(this.WoolMultiplier);
            this.armorPanel.Controls.Add(this.WoolMultiplierLbl);
            this.armorPanel.HorizontalScrollbarBarColor = true;
            this.armorPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.armorPanel.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.armorPanel, "armorPanel");
            this.armorPanel.Name = "armorPanel";
            this.armorPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.armorPanel.VerticalScrollbarBarColor = true;
            this.armorPanel.VerticalScrollbarHighlightOnWheel = false;
            this.armorPanel.VerticalScrollbarSize = 10;
            // 
            // VillagersLbl
            // 
            resources.ApplyResources(this.VillagersLbl, "VillagersLbl");
            this.VillagersLbl.BackColor = System.Drawing.Color.Transparent;
            this.VillagersLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.VillagersLbl.Name = "VillagersLbl";
            this.VillagersLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // VillagersPnl
            // 
            this.VillagersPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VillagersPnl.Controls.Add(this.ProfessionBox);
            this.VillagersPnl.Controls.Add(this.ProfessionLbl);
            this.VillagersPnl.HorizontalScrollbarBarColor = true;
            this.VillagersPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.VillagersPnl.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.VillagersPnl, "VillagersPnl");
            this.VillagersPnl.Name = "VillagersPnl";
            this.VillagersPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VillagersPnl.VerticalScrollbarBarColor = true;
            this.VillagersPnl.VerticalScrollbarHighlightOnWheel = false;
            this.VillagersPnl.VerticalScrollbarSize = 10;
            // 
            // ProfessionLbl
            // 
            resources.ApplyResources(this.ProfessionLbl, "ProfessionLbl");
            this.ProfessionLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ProfessionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProfessionLbl.Name = "ProfessionLbl";
            this.ProfessionLbl.Tag = "";
            this.ProfessionLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // StyleExtender
            // 
            this.StyleExtender.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LlamaLbl
            // 
            resources.ApplyResources(this.LlamaLbl, "LlamaLbl");
            this.LlamaLbl.BackColor = System.Drawing.Color.Transparent;
            this.LlamaLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LlamaLbl.Name = "LlamaLbl";
            this.LlamaLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LlamaPnl
            // 
            this.LlamaPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LlamaPnl.Controls.Add(this.LlamaVariantBox);
            this.LlamaPnl.Controls.Add(this.LlamaVariantLbl);
            this.LlamaPnl.HorizontalScrollbarBarColor = true;
            this.LlamaPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.LlamaPnl.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.LlamaPnl, "LlamaPnl");
            this.LlamaPnl.Name = "LlamaPnl";
            this.LlamaPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LlamaPnl.VerticalScrollbarBarColor = true;
            this.LlamaPnl.VerticalScrollbarHighlightOnWheel = false;
            this.LlamaPnl.VerticalScrollbarSize = 10;
            // 
            // LlamaVariantLbl
            // 
            resources.ApplyResources(this.LlamaVariantLbl, "LlamaVariantLbl");
            this.LlamaVariantLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LlamaVariantLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LlamaVariantLbl.Name = "LlamaVariantLbl";
            this.LlamaVariantLbl.Tag = "";
            this.LlamaVariantLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ParrotLbl
            // 
            resources.ApplyResources(this.ParrotLbl, "ParrotLbl");
            this.ParrotLbl.BackColor = System.Drawing.Color.Transparent;
            this.ParrotLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ParrotLbl.Name = "ParrotLbl";
            this.ParrotLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ParrotPnl
            // 
            this.ParrotPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParrotPnl.Controls.Add(this.ParrotVariantBox);
            this.ParrotPnl.Controls.Add(this.ParrotVariantLbl);
            this.ParrotPnl.HorizontalScrollbarBarColor = true;
            this.ParrotPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.ParrotPnl.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.ParrotPnl, "ParrotPnl");
            this.ParrotPnl.Name = "ParrotPnl";
            this.ParrotPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ParrotPnl.VerticalScrollbarBarColor = true;
            this.ParrotPnl.VerticalScrollbarHighlightOnWheel = false;
            this.ParrotPnl.VerticalScrollbarSize = 10;
            // 
            // ParrotVariantLbl
            // 
            resources.ApplyResources(this.ParrotVariantLbl, "ParrotVariantLbl");
            this.ParrotVariantLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ParrotVariantLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ParrotVariantLbl.Name = "ParrotVariantLbl";
            this.ParrotVariantLbl.Tag = "";
            this.ParrotVariantLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RabbitLbl
            // 
            resources.ApplyResources(this.RabbitLbl, "RabbitLbl");
            this.RabbitLbl.BackColor = System.Drawing.Color.Transparent;
            this.RabbitLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.RabbitLbl.Name = "RabbitLbl";
            this.RabbitLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RabbitPnl
            // 
            this.RabbitPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RabbitPnl.Controls.Add(this.RabbitVariantBox);
            this.RabbitPnl.Controls.Add(this.RabbitVariantLbl);
            this.RabbitPnl.HorizontalScrollbarBarColor = true;
            this.RabbitPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.RabbitPnl.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.RabbitPnl, "RabbitPnl");
            this.RabbitPnl.Name = "RabbitPnl";
            this.RabbitPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RabbitPnl.VerticalScrollbarBarColor = true;
            this.RabbitPnl.VerticalScrollbarHighlightOnWheel = false;
            this.RabbitPnl.VerticalScrollbarSize = 10;
            // 
            // RabbitVariantLbl
            // 
            resources.ApplyResources(this.RabbitVariantLbl, "RabbitVariantLbl");
            this.RabbitVariantLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.RabbitVariantLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RabbitVariantLbl.Name = "RabbitVariantLbl";
            this.RabbitVariantLbl.Tag = "";
            this.RabbitVariantLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ZombieLbl
            // 
            resources.ApplyResources(this.ZombieLbl, "ZombieLbl");
            this.ZombieLbl.BackColor = System.Drawing.Color.Transparent;
            this.ZombieLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ZombieLbl.Name = "ZombieLbl";
            this.ZombieLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ZombiePnl
            // 
            this.ZombiePnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZombiePnl.Controls.Add(this.BabyRateSlider);
            this.ZombiePnl.Controls.Add(this.BabyRateLbl);
            this.ZombiePnl.HorizontalScrollbarBarColor = true;
            this.ZombiePnl.HorizontalScrollbarHighlightOnWheel = false;
            this.ZombiePnl.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.ZombiePnl, "ZombiePnl");
            this.ZombiePnl.Name = "ZombiePnl";
            this.ZombiePnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ZombiePnl.VerticalScrollbarBarColor = true;
            this.ZombiePnl.VerticalScrollbarHighlightOnWheel = false;
            this.ZombiePnl.VerticalScrollbarSize = 10;
            // 
            // BabyRateLbl
            // 
            resources.ApplyResources(this.BabyRateLbl, "BabyRateLbl");
            this.BabyRateLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.BabyRateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BabyRateLbl.Name = "BabyRateLbl";
            this.BabyRateLbl.Tag = "";
            this.BabyRateLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // EntityReplacerLbl
            // 
            resources.ApplyResources(this.EntityReplacerLbl, "EntityReplacerLbl");
            this.EntityReplacerLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.EntityReplacerLbl.Name = "EntityReplacerLbl";
            this.EntityReplacerLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // EntitySwapPnl
            // 
            this.EntitySwapPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntitySwapPnl.Controls.Add(this.ReplaceEntityBtn);
            this.EntitySwapPnl.Controls.Add(this.WithEntity);
            this.EntitySwapPnl.Controls.Add(this.WithLbl);
            this.EntitySwapPnl.Controls.Add(this.ReplaceEntity);
            this.EntitySwapPnl.Controls.Add(this.ReplaceLbl);
            this.EntitySwapPnl.HorizontalScrollbarBarColor = true;
            this.EntitySwapPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.EntitySwapPnl.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.EntitySwapPnl, "EntitySwapPnl");
            this.EntitySwapPnl.Name = "EntitySwapPnl";
            this.EntitySwapPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.EntitySwapPnl.VerticalScrollbarBarColor = true;
            this.EntitySwapPnl.VerticalScrollbarHighlightOnWheel = false;
            this.EntitySwapPnl.VerticalScrollbarSize = 10;
            // 
            // WithEntity
            // 
            this.WithEntity.FormattingEnabled = true;
            resources.ApplyResources(this.WithEntity, "WithEntity");
            this.WithEntity.Name = "WithEntity";
            this.WithEntity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WithEntity.UseSelectable = true;
            // 
            // WithLbl
            // 
            resources.ApplyResources(this.WithLbl, "WithLbl");
            this.WithLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.WithLbl.Name = "WithLbl";
            this.WithLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ReplaceEntity
            // 
            this.ReplaceEntity.FormattingEnabled = true;
            resources.ApplyResources(this.ReplaceEntity, "ReplaceEntity");
            this.ReplaceEntity.Name = "ReplaceEntity";
            this.ReplaceEntity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ReplaceEntity.UseSelectable = true;
            // 
            // ReplaceLbl
            // 
            resources.ApplyResources(this.ReplaceLbl, "ReplaceLbl");
            this.ReplaceLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ReplaceLbl.Name = "ReplaceLbl";
            this.ReplaceLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // EntityEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EntityReplacerLbl);
            this.Controls.Add(this.EntitySwapPnl);
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
            this.MaximizeBox = false;
            this.Name = "EntityEditor";
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
            this.EntitySwapPnl.ResumeLayout(false);
            this.EntitySwapPnl.PerformLayout();
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
        private MetroFramework.Controls.MetroLabel EntityReplacerLbl;
        private MetroFramework.Controls.MetroPanel EntitySwapPnl;
        private MetroFramework.Controls.MetroTile ReplaceEntityBtn;
        private MetroFramework.Controls.MetroComboBox WithEntity;
        private MetroFramework.Controls.MetroLabel WithLbl;
        private MetroFramework.Controls.MetroComboBox ReplaceEntity;
        private MetroFramework.Controls.MetroLabel ReplaceLbl;
    }
}