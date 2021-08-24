namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    partial class WorldGenerationEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldGenerationEditor));
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ToolTips = new MetroFramework.Components.MetroToolTip();
            this.Structures = new MetroFramework.Controls.MetroLabel();
            this.StructuresPanel = new MetroFramework.Controls.MetroPanel();
            this.IncreasedVillageSpawn = new MetroFramework.Controls.MetroCheckBox();
            this.IncreasedStrongholdSpawn = new MetroFramework.Controls.MetroCheckBox();
            this.IncreasedWoodlandMansionSpawn = new MetroFramework.Controls.MetroCheckBox();
            this.IncreasedBuriedTreasureSpawn = new MetroFramework.Controls.MetroCheckBox();
            this.IncreasedShipwreckSpawn = new MetroFramework.Controls.MetroCheckBox();
            this.IncreasedMineshaftSpawn = new MetroFramework.Controls.MetroCheckBox();
            this.IncreasedStructuresSpawn = new MetroFramework.Controls.MetroCheckBox();
            this.IncreasedOceanMonumentSpawn = new MetroFramework.Controls.MetroCheckBox();
            this.IncreasedOceanRuinsSpawn = new MetroFramework.Controls.MetroCheckBox();
            this.Terrain = new MetroFramework.Controls.MetroLabel();
            this.TerrainPanel = new MetroFramework.Controls.MetroPanel();
            this.NetherSizeSlider = new System.Windows.Forms.NumericUpDown();
            this.NetherSize = new MetroFramework.Controls.MetroLabel();
            this.WorldSizeBtn = new MetroFramework.Controls.MetroButton();
            this.WorldSizeSlider = new System.Windows.Forms.NumericUpDown();
            this.WorldSize = new MetroFramework.Controls.MetroLabel();
            this.GeneratePlainWorld = new MetroFramework.Controls.MetroCheckBox();
            this.FreezingWorld = new MetroFramework.Controls.MetroCheckBox();
            this.GenerateAmplifiedWorld = new MetroFramework.Controls.MetroCheckBox();
            this.StoneWorld = new MetroFramework.Controls.MetroCheckBox();
            this.NoTerrain = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.StructuresPanel.SuspendLayout();
            this.TerrainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NetherSizeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldSizeSlider)).BeginInit();
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
            // Structures
            // 
            this.Structures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Structures.AutoSize = true;
            this.Structures.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Structures.Location = new System.Drawing.Point(27, 53);
            this.Structures.Name = "Structures";
            this.Structures.Size = new System.Drawing.Size(71, 19);
            this.Structures.TabIndex = 143;
            this.Structures.Text = "Structures";
            this.Structures.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // StructuresPanel
            // 
            this.StructuresPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StructuresPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StructuresPanel.Controls.Add(this.IncreasedVillageSpawn);
            this.StructuresPanel.Controls.Add(this.IncreasedStrongholdSpawn);
            this.StructuresPanel.Controls.Add(this.IncreasedWoodlandMansionSpawn);
            this.StructuresPanel.Controls.Add(this.IncreasedBuriedTreasureSpawn);
            this.StructuresPanel.Controls.Add(this.IncreasedShipwreckSpawn);
            this.StructuresPanel.Controls.Add(this.IncreasedMineshaftSpawn);
            this.StructuresPanel.Controls.Add(this.IncreasedStructuresSpawn);
            this.StructuresPanel.Controls.Add(this.IncreasedOceanMonumentSpawn);
            this.StructuresPanel.Controls.Add(this.IncreasedOceanRuinsSpawn);
            this.StructuresPanel.HorizontalScrollbarBarColor = true;
            this.StructuresPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.StructuresPanel.HorizontalScrollbarSize = 10;
            this.StructuresPanel.Location = new System.Drawing.Point(23, 63);
            this.StructuresPanel.Name = "StructuresPanel";
            this.StructuresPanel.Size = new System.Drawing.Size(227, 202);
            this.StructuresPanel.TabIndex = 142;
            this.StructuresPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StructuresPanel.VerticalScrollbarBarColor = true;
            this.StructuresPanel.VerticalScrollbarHighlightOnWheel = false;
            this.StructuresPanel.VerticalScrollbarSize = 10;
            // 
            // IncreasedVillageSpawn
            // 
            this.IncreasedVillageSpawn.AutoSize = true;
            this.IncreasedVillageSpawn.BackColor = System.Drawing.Color.Transparent;
            this.IncreasedVillageSpawn.Location = new System.Drawing.Point(3, 158);
            this.IncreasedVillageSpawn.Name = "IncreasedVillageSpawn";
            this.IncreasedVillageSpawn.Size = new System.Drawing.Size(149, 15);
            this.IncreasedVillageSpawn.TabIndex = 152;
            this.IncreasedVillageSpawn.Tag = "";
            this.IncreasedVillageSpawn.Text = "Increased Village Spawn";
            this.IncreasedVillageSpawn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.IncreasedVillageSpawn, "Whether to increase the spawns of Villages");
            this.IncreasedVillageSpawn.UseSelectable = true;
            this.IncreasedVillageSpawn.CheckedChanged += new System.EventHandler(this.IncreasedVillageSpawnToggled);
            // 
            // IncreasedStrongholdSpawn
            // 
            this.IncreasedStrongholdSpawn.AutoSize = true;
            this.IncreasedStrongholdSpawn.BackColor = System.Drawing.Color.Transparent;
            this.IncreasedStrongholdSpawn.Location = new System.Drawing.Point(3, 137);
            this.IncreasedStrongholdSpawn.Name = "IncreasedStrongholdSpawn";
            this.IncreasedStrongholdSpawn.Size = new System.Drawing.Size(173, 15);
            this.IncreasedStrongholdSpawn.TabIndex = 150;
            this.IncreasedStrongholdSpawn.Tag = "";
            this.IncreasedStrongholdSpawn.Text = "Increased Stronghold Spawn";
            this.IncreasedStrongholdSpawn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.IncreasedStrongholdSpawn, "Whether to increase the spawns of Strongholds");
            this.IncreasedStrongholdSpawn.UseSelectable = true;
            this.IncreasedStrongholdSpawn.CheckedChanged += new System.EventHandler(this.IncreasedStrongholdSpawnToggled);
            // 
            // IncreasedWoodlandMansionSpawn
            // 
            this.IncreasedWoodlandMansionSpawn.AutoSize = true;
            this.IncreasedWoodlandMansionSpawn.BackColor = System.Drawing.Color.Transparent;
            this.IncreasedWoodlandMansionSpawn.Location = new System.Drawing.Point(3, 179);
            this.IncreasedWoodlandMansionSpawn.Name = "IncreasedWoodlandMansionSpawn";
            this.IncreasedWoodlandMansionSpawn.Size = new System.Drawing.Size(218, 15);
            this.IncreasedWoodlandMansionSpawn.TabIndex = 151;
            this.IncreasedWoodlandMansionSpawn.Tag = "";
            this.IncreasedWoodlandMansionSpawn.Text = "Increased Woodland Mansion Spawn";
            this.IncreasedWoodlandMansionSpawn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.IncreasedWoodlandMansionSpawn, "Whether to increase the spawns of Woodland Mansions");
            this.IncreasedWoodlandMansionSpawn.UseSelectable = true;
            this.IncreasedWoodlandMansionSpawn.CheckedChanged += new System.EventHandler(this.IncreasedWoodlandMansionSpawnToggled);
            // 
            // IncreasedBuriedTreasureSpawn
            // 
            this.IncreasedBuriedTreasureSpawn.AutoSize = true;
            this.IncreasedBuriedTreasureSpawn.BackColor = System.Drawing.Color.Transparent;
            this.IncreasedBuriedTreasureSpawn.Location = new System.Drawing.Point(3, 11);
            this.IncreasedBuriedTreasureSpawn.Name = "IncreasedBuriedTreasureSpawn";
            this.IncreasedBuriedTreasureSpawn.Size = new System.Drawing.Size(194, 15);
            this.IncreasedBuriedTreasureSpawn.TabIndex = 144;
            this.IncreasedBuriedTreasureSpawn.Tag = "";
            this.IncreasedBuriedTreasureSpawn.Text = "Increased Buried Treasure Spawn";
            this.IncreasedBuriedTreasureSpawn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.IncreasedBuriedTreasureSpawn, "Whether to increase the spawns of Buried Treasure");
            this.IncreasedBuriedTreasureSpawn.UseSelectable = true;
            this.IncreasedBuriedTreasureSpawn.CheckedChanged += new System.EventHandler(this.IncreasedBuriedTreasureSpawnToggled);
            // 
            // IncreasedShipwreckSpawn
            // 
            this.IncreasedShipwreckSpawn.AutoSize = true;
            this.IncreasedShipwreckSpawn.BackColor = System.Drawing.Color.Transparent;
            this.IncreasedShipwreckSpawn.Location = new System.Drawing.Point(3, 116);
            this.IncreasedShipwreckSpawn.Name = "IncreasedShipwreckSpawn";
            this.IncreasedShipwreckSpawn.Size = new System.Drawing.Size(168, 15);
            this.IncreasedShipwreckSpawn.TabIndex = 149;
            this.IncreasedShipwreckSpawn.Tag = "";
            this.IncreasedShipwreckSpawn.Text = "Increased Shipwreck Spawn";
            this.IncreasedShipwreckSpawn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.IncreasedShipwreckSpawn, "Whether to increase the spawns of Shipwrecks");
            this.IncreasedShipwreckSpawn.UseSelectable = true;
            this.IncreasedShipwreckSpawn.CheckedChanged += new System.EventHandler(this.IncreasedShipwreckSpawnToggled);
            // 
            // IncreasedMineshaftSpawn
            // 
            this.IncreasedMineshaftSpawn.AutoSize = true;
            this.IncreasedMineshaftSpawn.BackColor = System.Drawing.Color.Transparent;
            this.IncreasedMineshaftSpawn.Location = new System.Drawing.Point(3, 32);
            this.IncreasedMineshaftSpawn.Name = "IncreasedMineshaftSpawn";
            this.IncreasedMineshaftSpawn.Size = new System.Drawing.Size(167, 15);
            this.IncreasedMineshaftSpawn.TabIndex = 145;
            this.IncreasedMineshaftSpawn.Tag = "";
            this.IncreasedMineshaftSpawn.Text = "Increased Mineshaft Spawn";
            this.IncreasedMineshaftSpawn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.IncreasedMineshaftSpawn, "Whether to increase the spawns of Mineshafts");
            this.IncreasedMineshaftSpawn.UseSelectable = true;
            this.IncreasedMineshaftSpawn.CheckedChanged += new System.EventHandler(this.IncreasedMineshaftSpawnToggled);
            // 
            // IncreasedStructuresSpawn
            // 
            this.IncreasedStructuresSpawn.AutoSize = true;
            this.IncreasedStructuresSpawn.BackColor = System.Drawing.Color.Transparent;
            this.IncreasedStructuresSpawn.Location = new System.Drawing.Point(3, 95);
            this.IncreasedStructuresSpawn.Name = "IncreasedStructuresSpawn";
            this.IncreasedStructuresSpawn.Size = new System.Drawing.Size(167, 15);
            this.IncreasedStructuresSpawn.TabIndex = 148;
            this.IncreasedStructuresSpawn.Tag = "";
            this.IncreasedStructuresSpawn.Text = "Increased Structures Spawn";
            this.IncreasedStructuresSpawn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.IncreasedStructuresSpawn, "Whether to increase the spawns of Structures (Temples etc)");
            this.IncreasedStructuresSpawn.UseSelectable = true;
            this.IncreasedStructuresSpawn.CheckedChanged += new System.EventHandler(this.IncreasedStructuresSpawnToggled);
            // 
            // IncreasedOceanMonumentSpawn
            // 
            this.IncreasedOceanMonumentSpawn.AutoSize = true;
            this.IncreasedOceanMonumentSpawn.BackColor = System.Drawing.Color.Transparent;
            this.IncreasedOceanMonumentSpawn.Location = new System.Drawing.Point(3, 53);
            this.IncreasedOceanMonumentSpawn.Name = "IncreasedOceanMonumentSpawn";
            this.IncreasedOceanMonumentSpawn.Size = new System.Drawing.Size(211, 15);
            this.IncreasedOceanMonumentSpawn.TabIndex = 146;
            this.IncreasedOceanMonumentSpawn.Tag = "";
            this.IncreasedOceanMonumentSpawn.Text = "Increased Ocean Monument Spawn";
            this.IncreasedOceanMonumentSpawn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.IncreasedOceanMonumentSpawn, "Whether to increase the spawns of Ocean Monuments");
            this.IncreasedOceanMonumentSpawn.UseSelectable = true;
            this.IncreasedOceanMonumentSpawn.CheckedChanged += new System.EventHandler(this.IncreasedOceanMonumentSpawnToggled);
            // 
            // IncreasedOceanRuinsSpawn
            // 
            this.IncreasedOceanRuinsSpawn.AutoSize = true;
            this.IncreasedOceanRuinsSpawn.BackColor = System.Drawing.Color.Transparent;
            this.IncreasedOceanRuinsSpawn.Location = new System.Drawing.Point(3, 74);
            this.IncreasedOceanRuinsSpawn.Name = "IncreasedOceanRuinsSpawn";
            this.IncreasedOceanRuinsSpawn.Size = new System.Drawing.Size(180, 15);
            this.IncreasedOceanRuinsSpawn.TabIndex = 147;
            this.IncreasedOceanRuinsSpawn.Tag = "";
            this.IncreasedOceanRuinsSpawn.Text = "Increased Ocean Ruins Spawn";
            this.IncreasedOceanRuinsSpawn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.IncreasedOceanRuinsSpawn, "Whether to increase the spawns of Ocean Ruins");
            this.IncreasedOceanRuinsSpawn.UseSelectable = true;
            this.IncreasedOceanRuinsSpawn.CheckedChanged += new System.EventHandler(this.IncreasedOceanRuinsSpawnToggled);
            // 
            // Terrain
            // 
            this.Terrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Terrain.AutoSize = true;
            this.Terrain.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Terrain.Location = new System.Drawing.Point(260, 53);
            this.Terrain.Name = "Terrain";
            this.Terrain.Size = new System.Drawing.Size(50, 19);
            this.Terrain.TabIndex = 145;
            this.Terrain.Text = "Terrain";
            this.Terrain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TerrainPanel
            // 
            this.TerrainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TerrainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TerrainPanel.Controls.Add(this.NoTerrain);
            this.TerrainPanel.Controls.Add(this.StoneWorld);
            this.TerrainPanel.Controls.Add(this.NetherSizeSlider);
            this.TerrainPanel.Controls.Add(this.NetherSize);
            this.TerrainPanel.Controls.Add(this.WorldSizeBtn);
            this.TerrainPanel.Controls.Add(this.WorldSizeSlider);
            this.TerrainPanel.Controls.Add(this.WorldSize);
            this.TerrainPanel.Controls.Add(this.GeneratePlainWorld);
            this.TerrainPanel.Controls.Add(this.FreezingWorld);
            this.TerrainPanel.Controls.Add(this.GenerateAmplifiedWorld);
            this.TerrainPanel.HorizontalScrollbarBarColor = true;
            this.TerrainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.TerrainPanel.HorizontalScrollbarSize = 10;
            this.TerrainPanel.Location = new System.Drawing.Point(256, 63);
            this.TerrainPanel.Name = "TerrainPanel";
            this.TerrainPanel.Size = new System.Drawing.Size(363, 202);
            this.TerrainPanel.TabIndex = 144;
            this.TerrainPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TerrainPanel.VerticalScrollbarBarColor = true;
            this.TerrainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.TerrainPanel.VerticalScrollbarSize = 10;
            // 
            // NetherSizeSlider
            // 
            this.NetherSizeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NetherSizeSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.NetherSizeSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.NetherSizeSlider.Location = new System.Drawing.Point(90, 165);
            this.NetherSizeSlider.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NetherSizeSlider.Name = "NetherSizeSlider";
            this.NetherSizeSlider.Size = new System.Drawing.Size(227, 20);
            this.NetherSizeSlider.TabIndex = 130;
            this.NetherSizeSlider.Tag = "";
            this.NetherSizeSlider.Value = new decimal(new int[] {
            176,
            0,
            0,
            0});
            this.NetherSizeSlider.ValueChanged += new System.EventHandler(this.NetherSizeSliderChanged);
            // 
            // NetherSize
            // 
            this.NetherSize.AutoSize = true;
            this.NetherSize.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.NetherSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NetherSize.Location = new System.Drawing.Point(3, 165);
            this.NetherSize.Name = "NetherSize";
            this.NetherSize.Size = new System.Drawing.Size(81, 19);
            this.NetherSize.TabIndex = 129;
            this.NetherSize.Tag = "";
            this.NetherSize.Text = "Nether Size:";
            this.NetherSize.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // WorldSizeBtn
            // 
            this.WorldSizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WorldSizeBtn.Highlight = true;
            this.WorldSizeBtn.Location = new System.Drawing.Point(323, 137);
            this.WorldSizeBtn.Name = "WorldSizeBtn";
            this.WorldSizeBtn.Size = new System.Drawing.Size(35, 47);
            this.WorldSizeBtn.TabIndex = 128;
            this.WorldSizeBtn.Text = "?";
            this.WorldSizeBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WorldSizeBtn.UseSelectable = true;
            this.WorldSizeBtn.Click += new System.EventHandler(this.WorldSizeBtnClicked);
            // 
            // WorldSizeSlider
            // 
            this.WorldSizeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorldSizeSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.WorldSizeSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.WorldSizeSlider.Location = new System.Drawing.Point(84, 139);
            this.WorldSizeSlider.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WorldSizeSlider.Name = "WorldSizeSlider";
            this.WorldSizeSlider.Size = new System.Drawing.Size(233, 20);
            this.WorldSizeSlider.TabIndex = 127;
            this.WorldSizeSlider.Tag = "";
            this.WorldSizeSlider.Value = new decimal(new int[] {
            172,
            0,
            0,
            0});
            this.WorldSizeSlider.ValueChanged += new System.EventHandler(this.WorldSizeSliderChanged);
            // 
            // WorldSize
            // 
            this.WorldSize.AutoSize = true;
            this.WorldSize.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.WorldSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WorldSize.Location = new System.Drawing.Point(3, 139);
            this.WorldSize.Name = "WorldSize";
            this.WorldSize.Size = new System.Drawing.Size(75, 19);
            this.WorldSize.TabIndex = 126;
            this.WorldSize.Tag = "";
            this.WorldSize.Text = "World Size:";
            this.WorldSize.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GeneratePlainWorld
            // 
            this.GeneratePlainWorld.AutoSize = true;
            this.GeneratePlainWorld.BackColor = System.Drawing.Color.Transparent;
            this.GeneratePlainWorld.Location = new System.Drawing.Point(3, 53);
            this.GeneratePlainWorld.Name = "GeneratePlainWorld";
            this.GeneratePlainWorld.Size = new System.Drawing.Size(84, 15);
            this.GeneratePlainWorld.TabIndex = 25;
            this.GeneratePlainWorld.Tag = "";
            this.GeneratePlainWorld.Text = "Plain World";
            this.GeneratePlainWorld.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.GeneratePlainWorld, "Whether to remove any decoration");
            this.GeneratePlainWorld.UseSelectable = true;
            this.GeneratePlainWorld.CheckedChanged += new System.EventHandler(this.GeneratePlainWorldToggled);
            // 
            // FreezingWorld
            // 
            this.FreezingWorld.AutoSize = true;
            this.FreezingWorld.BackColor = System.Drawing.Color.Transparent;
            this.FreezingWorld.Location = new System.Drawing.Point(3, 11);
            this.FreezingWorld.Name = "FreezingWorld";
            this.FreezingWorld.Size = new System.Drawing.Size(102, 15);
            this.FreezingWorld.TabIndex = 24;
            this.FreezingWorld.Tag = "";
            this.FreezingWorld.Text = "Freezing World";
            this.FreezingWorld.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.FreezingWorld, "Whether the world should freeze");
            this.FreezingWorld.UseSelectable = true;
            this.FreezingWorld.CheckedChanged += new System.EventHandler(this.FreezingWorldToggled);
            // 
            // GenerateAmplifiedWorld
            // 
            this.GenerateAmplifiedWorld.AutoSize = true;
            this.GenerateAmplifiedWorld.BackColor = System.Drawing.Color.Transparent;
            this.GenerateAmplifiedWorld.Location = new System.Drawing.Point(3, 32);
            this.GenerateAmplifiedWorld.Name = "GenerateAmplifiedWorld";
            this.GenerateAmplifiedWorld.Size = new System.Drawing.Size(110, 15);
            this.GenerateAmplifiedWorld.TabIndex = 26;
            this.GenerateAmplifiedWorld.Tag = "";
            this.GenerateAmplifiedWorld.Text = "Amplified World";
            this.GenerateAmplifiedWorld.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.GenerateAmplifiedWorld, "Whether to generate an amplified world");
            this.GenerateAmplifiedWorld.UseSelectable = true;
            this.GenerateAmplifiedWorld.CheckedChanged += new System.EventHandler(this.GenerateAmplifiedWorldToggled);
            // 
            // StoneWorld
            // 
            this.StoneWorld.AutoSize = true;
            this.StoneWorld.BackColor = System.Drawing.Color.Transparent;
            this.StoneWorld.Location = new System.Drawing.Point(3, 74);
            this.StoneWorld.Name = "StoneWorld";
            this.StoneWorld.Size = new System.Drawing.Size(88, 15);
            this.StoneWorld.TabIndex = 131;
            this.StoneWorld.Tag = "";
            this.StoneWorld.Text = "Stone World";
            this.StoneWorld.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.StoneWorld, "Whether to generate a world mostly made up of Stone");
            this.StoneWorld.UseSelectable = true;
            this.StoneWorld.CheckedChanged += new System.EventHandler(this.StoneWorldToggled);
            // 
            // NoTerrain
            // 
            this.NoTerrain.AutoSize = true;
            this.NoTerrain.BackColor = System.Drawing.Color.Transparent;
            this.NoTerrain.Location = new System.Drawing.Point(3, 95);
            this.NoTerrain.Name = "NoTerrain";
            this.NoTerrain.Size = new System.Drawing.Size(77, 15);
            this.NoTerrain.TabIndex = 132;
            this.NoTerrain.Tag = "";
            this.NoTerrain.Text = "No Terrain";
            this.NoTerrain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTips.SetToolTip(this.NoTerrain, "Whether to generate a world without any terrain");
            this.NoTerrain.UseSelectable = true;
            this.NoTerrain.CheckedChanged += new System.EventHandler(this.NoTerrainToggled);
            // 
            // WorldGenerationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 280);
            this.Controls.Add(this.Terrain);
            this.Controls.Add(this.TerrainPanel);
            this.Controls.Add(this.Structures);
            this.Controls.Add(this.StructuresPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(3840, 280);
            this.MinimumSize = new System.Drawing.Size(640, 280);
            this.Name = "WorldGenerationEditor";
            this.Text = "Minecraft: Wii U Mod Injector - World Generation Editor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exiting);
            this.Load += new System.EventHandler(this.Init);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            this.StructuresPanel.ResumeLayout(false);
            this.StructuresPanel.PerformLayout();
            this.TerrainPanel.ResumeLayout(false);
            this.TerrainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NetherSizeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldSizeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Components.MetroToolTip ToolTips;
        private MetroFramework.Controls.MetroLabel Structures;
        private MetroFramework.Controls.MetroPanel StructuresPanel;
        public MetroFramework.Controls.MetroCheckBox IncreasedVillageSpawn;
        public MetroFramework.Controls.MetroCheckBox IncreasedStrongholdSpawn;
        public MetroFramework.Controls.MetroCheckBox IncreasedWoodlandMansionSpawn;
        public MetroFramework.Controls.MetroCheckBox IncreasedBuriedTreasureSpawn;
        public MetroFramework.Controls.MetroCheckBox IncreasedShipwreckSpawn;
        public MetroFramework.Controls.MetroCheckBox IncreasedMineshaftSpawn;
        public MetroFramework.Controls.MetroCheckBox IncreasedStructuresSpawn;
        public MetroFramework.Controls.MetroCheckBox IncreasedOceanMonumentSpawn;
        public MetroFramework.Controls.MetroCheckBox IncreasedOceanRuinsSpawn;
        private MetroFramework.Controls.MetroLabel Terrain;
        private MetroFramework.Controls.MetroPanel TerrainPanel;
        public MetroFramework.Controls.MetroCheckBox GeneratePlainWorld;
        public MetroFramework.Controls.MetroCheckBox FreezingWorld;
        public MetroFramework.Controls.MetroCheckBox GenerateAmplifiedWorld;
        public System.Windows.Forms.NumericUpDown WorldSizeSlider;
        public MetroFramework.Controls.MetroLabel WorldSize;
        private MetroFramework.Controls.MetroButton WorldSizeBtn;
        public System.Windows.Forms.NumericUpDown NetherSizeSlider;
        public MetroFramework.Controls.MetroLabel NetherSize;
        public MetroFramework.Controls.MetroCheckBox StoneWorld;
        public MetroFramework.Controls.MetroCheckBox NoTerrain;
    }
}