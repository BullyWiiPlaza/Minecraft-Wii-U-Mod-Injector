using MetroFramework.Controls;
using Minecraft_Wii_U_Mod_Injector.Helpers;

namespace Minecraft_Wii_U_Mod_Injector
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.WorldTile = new MetroFramework.Controls.MetroTile();
            this.GeneralTile = new MetroFramework.Controls.MetroTile();
            this.MinigamesTile = new MetroFramework.Controls.MetroTile();
            this.SettingsTile = new MetroFramework.Controls.MetroTile();
            this.BuildTile = new MetroFramework.Controls.MetroTile();
            this.MainTabs = new MetroFramework.Controls.MetroTabControl();
            this.MainTab = new MetroFramework.Controls.MetroTabPage();
            this.SetupTutorialBtn = new MetroFramework.Controls.MetroButton();
            this.FaqBtn = new MetroFramework.Controls.MetroButton();
            this.BuildNotesBox = new MetroFramework.Controls.MetroTextBox();
            this.BuildVerTitleLbl = new MetroFramework.Controls.MetroLabel();
            this.CreditsBtn = new MetroFramework.Controls.MetroButton();
            this.ConnectBtn = new MetroFramework.Controls.MetroButton();
            this.DiscordSrvBtn = new MetroFramework.Controls.MetroButton();
            this.WiiUIpv4Box = new MetroFramework.Controls.MetroTextBox();
            this.WiiUIpv4Lbl = new MetroFramework.Controls.MetroLabel();
            this.playersTab = new MetroFramework.Controls.MetroTabPage();
            this.XPLevel = new MetroFramework.Controls.MetroLabel();
            this.XPLevelSlider = new System.Windows.Forms.NumericUpDown();
            this.PlayerOptionsBtn = new MetroFramework.Controls.MetroButton();
            this.PotionAmplifierSlider = new System.Windows.Forms.NumericUpDown();
            this.PotionAmplifier = new MetroFramework.Controls.MetroLabel();
            this.NoSlowDowns = new MetroFramework.Controls.MetroCheckBox();
            this.ESP = new MetroFramework.Controls.MetroCheckBox();
            this.AlwaysInWater = new MetroFramework.Controls.MetroCheckBox();
            this.LevelX = new MetroFramework.Controls.MetroCheckBox();
            this.SeeThroughBlocks = new MetroFramework.Controls.MetroCheckBox();
            this.AlwaysInLava = new MetroFramework.Controls.MetroCheckBox();
            this.HideBlocks = new MetroFramework.Controls.MetroCheckBox();
            this.UnderwaterEffects = new MetroFramework.Controls.MetroCheckBox();
            this.FrictionSlider = new System.Windows.Forms.NumericUpDown();
            this.EnchantmentLevel = new MetroFramework.Controls.MetroLabel();
            this.Friction = new MetroFramework.Controls.MetroLabel();
            this.GodModeAll = new MetroFramework.Controls.MetroCheckBox();
            this.playerModelScaleSlider = new System.Windows.Forms.NumericUpDown();
            this.FieldofViewSplitscreen = new MetroFramework.Controls.MetroLabel();
            this.RiptideFlyingSpeed = new MetroFramework.Controls.MetroLabel();
            this.PlayerModelScale = new MetroFramework.Controls.MetroLabel();
            this.FieldOfViewSplitSlider = new System.Windows.Forms.NumericUpDown();
            this.RiptideFlyingSpeedSlider = new System.Windows.Forms.NumericUpDown();
            this.JumpHeight = new MetroFramework.Controls.MetroLabel();
            this.SprintingSpeedScale = new MetroFramework.Controls.MetroLabel();
            this.GodMode = new MetroFramework.Controls.MetroCheckBox();
            this.SprintingSpeedScaleSlider = new System.Windows.Forms.NumericUpDown();
            this.Reach = new MetroFramework.Controls.MetroLabel();
            this.WalkingSpeedScale = new MetroFramework.Controls.MetroLabel();
            this.EnchantmentLevelSlider = new System.Windows.Forms.NumericUpDown();
            this.WalkingSpeedScaleSlider = new System.Windows.Forms.NumericUpDown();
            this.ReachSlider = new System.Windows.Forms.NumericUpDown();
            this.JumpHeightSlider = new System.Windows.Forms.NumericUpDown();
            this.DeadMauFiveMode = new MetroFramework.Controls.MetroCheckBox();
            this.ArmorHUD = new MetroFramework.Controls.MetroCheckBox();
            this.TakeEverythingAnywhere = new MetroFramework.Controls.MetroCheckBox();
            this.FieldOfView = new MetroFramework.Controls.MetroLabel();
            this.FieldOfViewSlider = new System.Windows.Forms.NumericUpDown();
            this.HiddenGameModesUnlocked = new MetroFramework.Controls.MetroCheckBox();
            this.HitBoxScale = new MetroFramework.Controls.MetroLabel();
            this.CraftingTableAnywhere = new MetroFramework.Controls.MetroCheckBox();
            this.VisibleHitboxes = new MetroFramework.Controls.MetroCheckBox();
            this.HitBoxScaleSlider = new System.Windows.Forms.NumericUpDown();
            this.NnidEditorBtn = new MetroFramework.Controls.MetroButton();
            this.InsaneCriticalHits = new MetroFramework.Controls.MetroCheckBox();
            this.AlwaysSwimming = new MetroFramework.Controls.MetroCheckBox();
            this.InfiniteRiptide = new MetroFramework.Controls.MetroCheckBox();
            this.FullRotation = new MetroFramework.Controls.MetroCheckBox();
            this.AlwaysDamagedPlayers = new MetroFramework.Controls.MetroCheckBox();
            this.InfiniteItems = new MetroFramework.Controls.MetroCheckBox();
            this.RapidBow = new MetroFramework.Controls.MetroCheckBox();
            this.BloodVision = new MetroFramework.Controls.MetroCheckBox();
            this.IgnorePotions = new MetroFramework.Controls.MetroCheckBox();
            this.ForeverLastingPotions = new MetroFramework.Controls.MetroCheckBox();
            this.BypassInvulnerability = new MetroFramework.Controls.MetroCheckBox();
            this.PlaceBlocksonHead = new MetroFramework.Controls.MetroCheckBox();
            this.WalkonWater = new MetroFramework.Controls.MetroCheckBox();
            this.AlwaysElytra = new MetroFramework.Controls.MetroCheckBox();
            this.CaveFinder = new MetroFramework.Controls.MetroCheckBox();
            this.Wallhack = new MetroFramework.Controls.MetroCheckBox();
            this.LargeXPDrops = new MetroFramework.Controls.MetroCheckBox();
            this.WallClimbing = new MetroFramework.Controls.MetroCheckBox();
            this.NoCollision = new MetroFramework.Controls.MetroCheckBox();
            this.InfiniteAir = new MetroFramework.Controls.MetroCheckBox();
            this.InfiniteDurability = new MetroFramework.Controls.MetroCheckBox();
            this.SuperKnockback = new MetroFramework.Controls.MetroCheckBox();
            this.DisabledKnockback = new MetroFramework.Controls.MetroCheckBox();
            this.SilkTouchAnything = new MetroFramework.Controls.MetroCheckBox();
            this.DeveloperMode = new MetroFramework.Controls.MetroCheckBox();
            this.PickLiquidBlocks = new MetroFramework.Controls.MetroCheckBox();
            this.DuelWieldanyItem = new MetroFramework.Controls.MetroCheckBox();
            this.DisableStarving = new MetroFramework.Controls.MetroCheckBox();
            this.InstantMining = new MetroFramework.Controls.MetroCheckBox();
            this.Flying = new MetroFramework.Controls.MetroCheckBox();
            this.DisableSuffocating = new MetroFramework.Controls.MetroCheckBox();
            this.NoFallDamage = new MetroFramework.Controls.MetroCheckBox();
            this.CraftAnything = new MetroFramework.Controls.MetroCheckBox();
            this.CreativeMode = new MetroFramework.Controls.MetroCheckBox();
            this.worldTab = new MetroFramework.Controls.MetroTabPage();
            this.SunProofMobs = new MetroFramework.Controls.MetroCheckBox();
            this.DisableCreativeFlag = new MetroFramework.Controls.MetroCheckBox();
            this.ZombieTower = new MetroFramework.Controls.MetroCheckBox();
            this.Entities = new MetroFramework.Controls.MetroLabel();
            this.IgnitedCreepers = new MetroFramework.Controls.MetroCheckBox();
            this.GeneratePlainWorld = new MetroFramework.Controls.MetroCheckBox();
            this.SuperchargedCreepers = new MetroFramework.Controls.MetroCheckBox();
            this.UncapEntitySpawnLimit = new MetroFramework.Controls.MetroCheckBox();
            this.FreezingWorld = new MetroFramework.Controls.MetroCheckBox();
            this.AcidLiquidBlocks = new MetroFramework.Controls.MetroCheckBox();
            this.World = new MetroFramework.Controls.MetroLabel();
            this.FoggyWeather = new MetroFramework.Controls.MetroCheckBox();
            this.worldPnl = new MetroFramework.Controls.MetroPanel();
            this.GenerateAmplifiedWorld = new MetroFramework.Controls.MetroCheckBox();
            this.StaticLiquidBlocks = new MetroFramework.Controls.MetroCheckBox();
            this.NoFog = new MetroFramework.Controls.MetroCheckBox();
            this.generalTab = new MetroFramework.Controls.MetroTabPage();
            this.DebugConsole = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.vpadDisplaySwitch = new MetroFramework.Controls.MetroCheckBox();
            this.UIColorPickerBtn = new MetroFramework.Controls.MetroButton();
            this.DisableTeleporting = new MetroFramework.Controls.MetroCheckBox();
            this.GamepadSplitscreen = new MetroFramework.Controls.MetroCheckBox();
            this.disableVPadInput = new MetroFramework.Controls.MetroCheckBox();
            this.BypassFriendsOnly = new MetroFramework.Controls.MetroCheckBox();
            this.DisablePermanentKicks = new MetroFramework.Controls.MetroCheckBox();
            this.MapTextEditor = new MetroFramework.Controls.MetroButton();
            this.HostOptions = new MetroFramework.Controls.MetroCheckBox();
            this.SlowMotion = new MetroFramework.Controls.MetroCheckBox();
            this.AllDLCUnlocked = new MetroFramework.Controls.MetroCheckBox();
            this.ExitGame = new MetroFramework.Controls.MetroButton();
            this.minigamesTab = new MetroFramework.Controls.MetroTabPage();
            this.MinigamesTabs = new MetroFramework.Controls.MetroTabControl();
            this.GeneralMinigames = new MetroFramework.Controls.MetroTabPage();
            this.SqueakInfinitely = new MetroFramework.Controls.MetroCheckBox();
            this.RequiredPlayersSlider = new System.Windows.Forms.NumericUpDown();
            this.RequiredPlayers = new MetroFramework.Controls.MetroLabel();
            this.AllPermissions = new MetroFramework.Controls.MetroCheckBox();
            this.AlwaysDamaged = new MetroFramework.Controls.MetroCheckBox();
            this.TNTGriefing = new MetroFramework.Controls.MetroCheckBox();
            this.DisabledKillBarriers = new MetroFramework.Controls.MetroCheckBox();
            this.Battle = new MetroFramework.Controls.MetroTabPage();
            this.EndGame = new MetroFramework.Controls.MetroButton();
            this.RefillInterval = new MetroFramework.Controls.MetroLabel();
            this.RefillIntervalSlider = new System.Windows.Forms.NumericUpDown();
            this.AntiEndGame = new MetroFramework.Controls.MetroCheckBox();
            this.Tumble = new MetroFramework.Controls.MetroTabPage();
            this.TumbleHUD = new MetroFramework.Controls.MetroCheckBox();
            this.Glide = new MetroFramework.Controls.MetroTabPage();
            this.ringScoreB = new MetroFramework.Controls.MetroLabel();
            this.ringScoreBlue = new System.Windows.Forms.NumericUpDown();
            this.ringScoreO = new MetroFramework.Controls.MetroLabel();
            this.ringScoreOrange = new System.Windows.Forms.NumericUpDown();
            this.ringScoreG = new MetroFramework.Controls.MetroLabel();
            this.ringScoreGreen = new System.Windows.Forms.NumericUpDown();
            this.commandsTab = new MetroFramework.Controls.MetroTabPage();
            this.gamemodeCmdLbl = new MetroFramework.Controls.MetroLabel();
            this.gamemodePanel = new MetroFramework.Controls.MetroPanel();
            this.GameModeCommandBtn = new MetroFramework.Controls.MetroButton();
            this.worldCmdLbl = new MetroFramework.Controls.MetroLabel();
            this.worldPanel = new MetroFramework.Controls.MetroPanel();
            this.SetWorldSpawnBtn = new MetroFramework.Controls.MetroButton();
            this.downfallCommandBtn = new MetroFramework.Controls.MetroButton();
            this.playerCmdLbl = new MetroFramework.Controls.MetroLabel();
            this.playerPanel = new MetroFramework.Controls.MetroPanel();
            this.killCommandBtn = new MetroFramework.Controls.MetroButton();
            this.timeCmdLbl = new MetroFramework.Controls.MetroLabel();
            this.timePanel = new MetroFramework.Controls.MetroPanel();
            this.timeCommandBtn = new MetroFramework.Controls.MetroButton();
            this.timeAmountBox = new MetroFramework.Controls.MetroTextBox();
            this.enchantCmdLbl = new MetroFramework.Controls.MetroLabel();
            this.enchantPanel = new MetroFramework.Controls.MetroPanel();
            this.enchantIDBox = new MetroFramework.Controls.MetroComboBox();
            this.enchantCommandBtn = new MetroFramework.Controls.MetroButton();
            this.enchantLevelBox = new MetroFramework.Controls.MetroTextBox();
            this.giveCmdLabel = new MetroFramework.Controls.MetroLabel();
            this.giveCommandPanel = new MetroFramework.Controls.MetroPanel();
            this.itemIdHelpBtn = new MetroFramework.Controls.MetroButton();
            this.giveCommandBtn = new MetroFramework.Controls.MetroButton();
            this.giveDataBox = new MetroFramework.Controls.MetroTextBox();
            this.giveAmountBox = new MetroFramework.Controls.MetroTextBox();
            this.giveIDBox = new MetroFramework.Controls.MetroTextBox();
            this.settingsTab = new MetroFramework.Controls.MetroTabPage();
            this.OpenLangMngrBtn = new MetroFramework.Controls.MetroButton();
            this.CheckForPreRelease = new MetroFramework.Controls.MetroCheckBox();
            this.settingsLogo = new MetroFramework.Controls.MetroPanel();
            this.releaseNotesToggle = new MetroFramework.Controls.MetroCheckBox();
            this.resetConfigBtn = new MetroFramework.Controls.MetroButton();
            this.discordRpcCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.colorsBox = new MetroFramework.Controls.MetroComboBox();
            this.ThemeLabel = new MetroFramework.Controls.MetroLabel();
            this.ColorLabel = new MetroFramework.Controls.MetroLabel();
            this.themeBox = new MetroFramework.Controls.MetroComboBox();
            this.HomeTile = new MetroFramework.Controls.MetroTile();
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.StyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.ToolTipManager = new MetroFramework.Components.MetroToolTip();
            this.PlayersTile = new MetroFramework.Controls.MetroTile();
            this.CommandsTile = new MetroFramework.Controls.MetroTile();
            this.RightClickMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.IncreaseDecimalPlace = new System.Windows.Forms.ToolStripMenuItem();
            this.DecreaseDecimalPlace = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabs.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.playersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XPLevelSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotionAmplifierSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrictionSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerModelScaleSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldOfViewSplitSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RiptideFlyingSpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SprintingSpeedScaleSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnchantmentLevelSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkingSpeedScaleSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReachSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpHeightSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldOfViewSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitBoxScaleSlider)).BeginInit();
            this.worldTab.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.minigamesTab.SuspendLayout();
            this.MinigamesTabs.SuspendLayout();
            this.GeneralMinigames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequiredPlayersSlider)).BeginInit();
            this.Battle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefillIntervalSlider)).BeginInit();
            this.Tumble.SuspendLayout();
            this.Glide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ringScoreBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringScoreOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringScoreGreen)).BeginInit();
            this.commandsTab.SuspendLayout();
            this.gamemodePanel.SuspendLayout();
            this.worldPanel.SuspendLayout();
            this.playerPanel.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.enchantPanel.SuspendLayout();
            this.giveCommandPanel.SuspendLayout();
            this.settingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.RightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorldTile
            // 
            this.WorldTile.ActiveControl = null;
            this.WorldTile.Location = new System.Drawing.Point(0, 172);
            this.WorldTile.Name = "WorldTile";
            this.WorldTile.PaintTileCount = false;
            this.WorldTile.Size = new System.Drawing.Size(160, 55);
            this.WorldTile.TabIndex = 3;
            this.WorldTile.Tag = "";
            this.WorldTile.Text = "Entities / World";
            this.WorldTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WorldTile.TileCount = 2;
            this.WorldTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.WorldTile.UseSelectable = true;
            this.WorldTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // GeneralTile
            // 
            this.GeneralTile.ActiveControl = null;
            this.GeneralTile.Location = new System.Drawing.Point(0, 227);
            this.GeneralTile.Name = "GeneralTile";
            this.GeneralTile.PaintTileCount = false;
            this.GeneralTile.Size = new System.Drawing.Size(160, 55);
            this.GeneralTile.TabIndex = 4;
            this.GeneralTile.Tag = "";
            this.GeneralTile.Text = "General Game";
            this.GeneralTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GeneralTile.TileCount = 3;
            this.GeneralTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.GeneralTile.UseSelectable = true;
            this.GeneralTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // MinigamesTile
            // 
            this.MinigamesTile.ActiveControl = null;
            this.MinigamesTile.Location = new System.Drawing.Point(0, 282);
            this.MinigamesTile.Name = "MinigamesTile";
            this.MinigamesTile.PaintTileCount = false;
            this.MinigamesTile.Size = new System.Drawing.Size(160, 55);
            this.MinigamesTile.TabIndex = 5;
            this.MinigamesTile.Tag = "";
            this.MinigamesTile.Text = "Minigames";
            this.MinigamesTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinigamesTile.TileCount = 4;
            this.MinigamesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.MinigamesTile.UseSelectable = true;
            this.MinigamesTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // SettingsTile
            // 
            this.SettingsTile.ActiveControl = null;
            this.SettingsTile.Location = new System.Drawing.Point(0, 392);
            this.SettingsTile.Name = "SettingsTile";
            this.SettingsTile.PaintTileCount = false;
            this.SettingsTile.Size = new System.Drawing.Size(160, 69);
            this.SettingsTile.TabIndex = 7;
            this.SettingsTile.Tag = "";
            this.SettingsTile.Text = "Settings";
            this.SettingsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsTile.TileCount = 6;
            this.SettingsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.SettingsTile.UseSelectable = true;
            this.SettingsTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // BuildTile
            // 
            this.BuildTile.ActiveControl = null;
            this.BuildTile.Enabled = false;
            this.BuildTile.Location = new System.Drawing.Point(0, 453);
            this.BuildTile.Name = "BuildTile";
            this.BuildTile.PaintTileCount = false;
            this.BuildTile.Size = new System.Drawing.Size(160, 247);
            this.BuildTile.TabIndex = 6;
            this.BuildTile.Text = "VERSION";
            this.BuildTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuildTile.TileCount = 8;
            this.BuildTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.BuildTile.UseSelectable = true;
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.MainTab);
            this.MainTabs.Controls.Add(this.playersTab);
            this.MainTabs.Controls.Add(this.worldTab);
            this.MainTabs.Controls.Add(this.generalTab);
            this.MainTabs.Controls.Add(this.minigamesTab);
            this.MainTabs.Controls.Add(this.commandsTab);
            this.MainTabs.Controls.Add(this.settingsTab);
            this.MainTabs.ItemSize = new System.Drawing.Size(160, 1);
            this.MainTabs.Location = new System.Drawing.Point(155, 61);
            this.MainTabs.Multiline = true;
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 6;
            this.MainTabs.Size = new System.Drawing.Size(1130, 639);
            this.MainTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabs.TabIndex = 0;
            this.MainTabs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainTabs.UseSelectable = true;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.SetupTutorialBtn);
            this.MainTab.Controls.Add(this.FaqBtn);
            this.MainTab.Controls.Add(this.BuildNotesBox);
            this.MainTab.Controls.Add(this.BuildVerTitleLbl);
            this.MainTab.Controls.Add(this.CreditsBtn);
            this.MainTab.Controls.Add(this.ConnectBtn);
            this.MainTab.Controls.Add(this.DiscordSrvBtn);
            this.MainTab.Controls.Add(this.WiiUIpv4Box);
            this.MainTab.Controls.Add(this.WiiUIpv4Lbl);
            this.MainTab.HorizontalScrollbarBarColor = true;
            this.MainTab.HorizontalScrollbarHighlightOnWheel = false;
            this.MainTab.HorizontalScrollbarSize = 10;
            this.MainTab.Location = new System.Drawing.Point(4, 5);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(1122, 630);
            this.MainTab.TabIndex = 6;
            this.MainTab.Text = "Home";
            this.MainTab.VerticalScrollbarBarColor = true;
            this.MainTab.VerticalScrollbarHighlightOnWheel = false;
            this.MainTab.VerticalScrollbarSize = 10;
            // 
            // SetupTutorialBtn
            // 
            this.SetupTutorialBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetupTutorialBtn.Location = new System.Drawing.Point(976, 101);
            this.SetupTutorialBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SetupTutorialBtn.Name = "SetupTutorialBtn";
            this.SetupTutorialBtn.Size = new System.Drawing.Size(139, 23);
            this.SetupTutorialBtn.TabIndex = 47;
            this.SetupTutorialBtn.Text = "Setup Tutorial";
            this.ToolTipManager.SetToolTip(this.SetupTutorialBtn, "View the setup tutorial");
            this.SetupTutorialBtn.UseSelectable = true;
            this.SetupTutorialBtn.Click += new System.EventHandler(this.SetupTutorialBtnClicked);
            // 
            // FaqBtn
            // 
            this.FaqBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FaqBtn.Location = new System.Drawing.Point(976, 31);
            this.FaqBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FaqBtn.Name = "FaqBtn";
            this.FaqBtn.Size = new System.Drawing.Size(139, 23);
            this.FaqBtn.TabIndex = 46;
            this.FaqBtn.Text = "FAQ - Information";
            this.ToolTipManager.SetToolTip(this.FaqBtn, "View the frequently asked questions");
            this.FaqBtn.UseSelectable = true;
            this.FaqBtn.Click += new System.EventHandler(this.OpenFaqInfoClicked);
            // 
            // BuildNotesBox
            // 
            // 
            // 
            // 
            this.BuildNotesBox.CustomButton.Image = null;
            this.BuildNotesBox.CustomButton.Location = new System.Drawing.Point(401, 2);
            this.BuildNotesBox.CustomButton.Name = "";
            this.BuildNotesBox.CustomButton.Size = new System.Drawing.Size(559, 559);
            this.BuildNotesBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BuildNotesBox.CustomButton.TabIndex = 1;
            this.BuildNotesBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BuildNotesBox.CustomButton.UseSelectable = true;
            this.BuildNotesBox.CustomButton.Visible = false;
            this.BuildNotesBox.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.BuildNotesBox.Lines = new string[] {
        "FETCHING PATCH NOTES FOR VERSION"};
            this.BuildNotesBox.Location = new System.Drawing.Point(6, 31);
            this.BuildNotesBox.MaxLength = 32767;
            this.BuildNotesBox.Multiline = true;
            this.BuildNotesBox.Name = "BuildNotesBox";
            this.BuildNotesBox.PasswordChar = '\0';
            this.BuildNotesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BuildNotesBox.SelectedText = "";
            this.BuildNotesBox.SelectionLength = 0;
            this.BuildNotesBox.SelectionStart = 0;
            this.BuildNotesBox.ShortcutsEnabled = true;
            this.BuildNotesBox.Size = new System.Drawing.Size(963, 564);
            this.BuildNotesBox.TabIndex = 8;
            this.BuildNotesBox.Text = "FETCHING PATCH NOTES FOR VERSION";
            this.BuildNotesBox.UseSelectable = true;
            this.BuildNotesBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BuildNotesBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BuildVerTitleLbl
            // 
            this.BuildVerTitleLbl.AutoSize = true;
            this.BuildVerTitleLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.BuildVerTitleLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.BuildVerTitleLbl.Location = new System.Drawing.Point(3, 3);
            this.BuildVerTitleLbl.Name = "BuildVerTitleLbl";
            this.BuildVerTitleLbl.Size = new System.Drawing.Size(212, 25);
            this.BuildVerTitleLbl.TabIndex = 6;
            this.BuildVerTitleLbl.Text = "Patch Notes for VERSION";
            this.BuildVerTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreditsBtn
            // 
            this.CreditsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreditsBtn.Location = new System.Drawing.Point(976, 66);
            this.CreditsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreditsBtn.Name = "CreditsBtn";
            this.CreditsBtn.Size = new System.Drawing.Size(139, 23);
            this.CreditsBtn.TabIndex = 42;
            this.CreditsBtn.Text = "Credits";
            this.ToolTipManager.SetToolTip(this.CreditsBtn, "View the credits for the Mod Injector");
            this.CreditsBtn.UseSelectable = true;
            this.CreditsBtn.Click += new System.EventHandler(this.CreditsBtnClicked);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(975, 601);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(140, 23);
            this.ConnectBtn.TabIndex = 4;
            this.ConnectBtn.Text = "Connect";
            this.ToolTipManager.SetToolTip(this.ConnectBtn, "Connects to your Wii U using the IPv4 provided");
            this.ConnectBtn.UseSelectable = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtnClicked);
            // 
            // DiscordSrvBtn
            // 
            this.DiscordSrvBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DiscordSrvBtn.Location = new System.Drawing.Point(976, 136);
            this.DiscordSrvBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DiscordSrvBtn.Name = "DiscordSrvBtn";
            this.DiscordSrvBtn.Size = new System.Drawing.Size(139, 23);
            this.DiscordSrvBtn.TabIndex = 32;
            this.DiscordSrvBtn.Text = "Discord Server";
            this.ToolTipManager.SetToolTip(this.DiscordSrvBtn, "Will take you to the official Discord server for the Mod Injector");
            this.DiscordSrvBtn.UseSelectable = true;
            this.DiscordSrvBtn.Click += new System.EventHandler(this.DiscordSrvBtnClicked);
            // 
            // WiiUIpv4Box
            // 
            // 
            // 
            // 
            this.WiiUIpv4Box.CustomButton.Image = null;
            this.WiiUIpv4Box.CustomButton.Location = new System.Drawing.Point(863, 1);
            this.WiiUIpv4Box.CustomButton.Name = "";
            this.WiiUIpv4Box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.WiiUIpv4Box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.WiiUIpv4Box.CustomButton.TabIndex = 1;
            this.WiiUIpv4Box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WiiUIpv4Box.CustomButton.UseSelectable = true;
            this.WiiUIpv4Box.CustomButton.Visible = false;
            this.WiiUIpv4Box.Lines = new string[0];
            this.WiiUIpv4Box.Location = new System.Drawing.Point(84, 601);
            this.WiiUIpv4Box.MaxLength = 32767;
            this.WiiUIpv4Box.Name = "WiiUIpv4Box";
            this.WiiUIpv4Box.PasswordChar = '\0';
            this.WiiUIpv4Box.PromptText = "Your Wii U\'s IPv4 address (Seen in the TCP Gecko Installer)";
            this.WiiUIpv4Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WiiUIpv4Box.SelectedText = "";
            this.WiiUIpv4Box.SelectionLength = 0;
            this.WiiUIpv4Box.SelectionStart = 0;
            this.WiiUIpv4Box.ShortcutsEnabled = true;
            this.WiiUIpv4Box.Size = new System.Drawing.Size(885, 23);
            this.WiiUIpv4Box.TabIndex = 3;
            this.WiiUIpv4Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WiiUIpv4Box.UseSelectable = true;
            this.WiiUIpv4Box.WaterMark = "Your Wii U\'s IPv4 address (Seen in the TCP Gecko Installer)";
            this.WiiUIpv4Box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WiiUIpv4Box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.WiiUIpv4Box.TextChanged += new System.EventHandler(this.CapturewiiuIpv4Box);
            // 
            // WiiUIpv4Lbl
            // 
            this.WiiUIpv4Lbl.AutoSize = true;
            this.WiiUIpv4Lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.WiiUIpv4Lbl.Location = new System.Drawing.Point(6, 601);
            this.WiiUIpv4Lbl.Name = "WiiUIpv4Lbl";
            this.WiiUIpv4Lbl.Size = new System.Drawing.Size(76, 19);
            this.WiiUIpv4Lbl.TabIndex = 2;
            this.WiiUIpv4Lbl.Text = "Wii U IPv4:";
            // 
            // playersTab
            // 
            this.playersTab.Controls.Add(this.XPLevel);
            this.playersTab.Controls.Add(this.XPLevelSlider);
            this.playersTab.Controls.Add(this.PlayerOptionsBtn);
            this.playersTab.Controls.Add(this.PotionAmplifierSlider);
            this.playersTab.Controls.Add(this.PotionAmplifier);
            this.playersTab.Controls.Add(this.NoSlowDowns);
            this.playersTab.Controls.Add(this.ESP);
            this.playersTab.Controls.Add(this.AlwaysInWater);
            this.playersTab.Controls.Add(this.LevelX);
            this.playersTab.Controls.Add(this.SeeThroughBlocks);
            this.playersTab.Controls.Add(this.AlwaysInLava);
            this.playersTab.Controls.Add(this.HideBlocks);
            this.playersTab.Controls.Add(this.UnderwaterEffects);
            this.playersTab.Controls.Add(this.FrictionSlider);
            this.playersTab.Controls.Add(this.EnchantmentLevel);
            this.playersTab.Controls.Add(this.Friction);
            this.playersTab.Controls.Add(this.GodModeAll);
            this.playersTab.Controls.Add(this.playerModelScaleSlider);
            this.playersTab.Controls.Add(this.FieldofViewSplitscreen);
            this.playersTab.Controls.Add(this.RiptideFlyingSpeed);
            this.playersTab.Controls.Add(this.PlayerModelScale);
            this.playersTab.Controls.Add(this.FieldOfViewSplitSlider);
            this.playersTab.Controls.Add(this.RiptideFlyingSpeedSlider);
            this.playersTab.Controls.Add(this.JumpHeight);
            this.playersTab.Controls.Add(this.SprintingSpeedScale);
            this.playersTab.Controls.Add(this.GodMode);
            this.playersTab.Controls.Add(this.SprintingSpeedScaleSlider);
            this.playersTab.Controls.Add(this.Reach);
            this.playersTab.Controls.Add(this.WalkingSpeedScale);
            this.playersTab.Controls.Add(this.EnchantmentLevelSlider);
            this.playersTab.Controls.Add(this.WalkingSpeedScaleSlider);
            this.playersTab.Controls.Add(this.ReachSlider);
            this.playersTab.Controls.Add(this.JumpHeightSlider);
            this.playersTab.Controls.Add(this.DeadMauFiveMode);
            this.playersTab.Controls.Add(this.ArmorHUD);
            this.playersTab.Controls.Add(this.TakeEverythingAnywhere);
            this.playersTab.Controls.Add(this.FieldOfView);
            this.playersTab.Controls.Add(this.FieldOfViewSlider);
            this.playersTab.Controls.Add(this.HiddenGameModesUnlocked);
            this.playersTab.Controls.Add(this.HitBoxScale);
            this.playersTab.Controls.Add(this.CraftingTableAnywhere);
            this.playersTab.Controls.Add(this.VisibleHitboxes);
            this.playersTab.Controls.Add(this.HitBoxScaleSlider);
            this.playersTab.Controls.Add(this.NnidEditorBtn);
            this.playersTab.Controls.Add(this.InsaneCriticalHits);
            this.playersTab.Controls.Add(this.AlwaysSwimming);
            this.playersTab.Controls.Add(this.InfiniteRiptide);
            this.playersTab.Controls.Add(this.FullRotation);
            this.playersTab.Controls.Add(this.AlwaysDamagedPlayers);
            this.playersTab.Controls.Add(this.InfiniteItems);
            this.playersTab.Controls.Add(this.RapidBow);
            this.playersTab.Controls.Add(this.BloodVision);
            this.playersTab.Controls.Add(this.IgnorePotions);
            this.playersTab.Controls.Add(this.ForeverLastingPotions);
            this.playersTab.Controls.Add(this.BypassInvulnerability);
            this.playersTab.Controls.Add(this.PlaceBlocksonHead);
            this.playersTab.Controls.Add(this.WalkonWater);
            this.playersTab.Controls.Add(this.AlwaysElytra);
            this.playersTab.Controls.Add(this.CaveFinder);
            this.playersTab.Controls.Add(this.Wallhack);
            this.playersTab.Controls.Add(this.LargeXPDrops);
            this.playersTab.Controls.Add(this.WallClimbing);
            this.playersTab.Controls.Add(this.NoCollision);
            this.playersTab.Controls.Add(this.InfiniteAir);
            this.playersTab.Controls.Add(this.InfiniteDurability);
            this.playersTab.Controls.Add(this.SuperKnockback);
            this.playersTab.Controls.Add(this.DisabledKnockback);
            this.playersTab.Controls.Add(this.SilkTouchAnything);
            this.playersTab.Controls.Add(this.DeveloperMode);
            this.playersTab.Controls.Add(this.PickLiquidBlocks);
            this.playersTab.Controls.Add(this.DuelWieldanyItem);
            this.playersTab.Controls.Add(this.DisableStarving);
            this.playersTab.Controls.Add(this.InstantMining);
            this.playersTab.Controls.Add(this.Flying);
            this.playersTab.Controls.Add(this.DisableSuffocating);
            this.playersTab.Controls.Add(this.NoFallDamage);
            this.playersTab.Controls.Add(this.CraftAnything);
            this.playersTab.Controls.Add(this.CreativeMode);
            this.playersTab.HorizontalScrollbarBarColor = true;
            this.playersTab.HorizontalScrollbarHighlightOnWheel = false;
            this.playersTab.HorizontalScrollbarSize = 10;
            this.playersTab.Location = new System.Drawing.Point(4, 5);
            this.playersTab.Name = "playersTab";
            this.playersTab.Padding = new System.Windows.Forms.Padding(3);
            this.playersTab.Size = new System.Drawing.Size(1122, 630);
            this.playersTab.TabIndex = 0;
            this.playersTab.Tag = "needsGeckoU";
            this.playersTab.Text = "Player(s)";
            this.playersTab.VerticalScrollbarBarColor = true;
            this.playersTab.VerticalScrollbarHighlightOnWheel = false;
            this.playersTab.VerticalScrollbarSize = 10;
            // 
            // XPLevel
            // 
            this.XPLevel.AutoSize = true;
            this.XPLevel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.XPLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XPLevel.Location = new System.Drawing.Point(554, 480);
            this.XPLevel.Name = "XPLevel";
            this.XPLevel.Size = new System.Drawing.Size(63, 19);
            this.XPLevel.TabIndex = 159;
            this.XPLevel.Tag = "";
            this.XPLevel.Text = "XP Level:";
            // 
            // XPLevelSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.XPLevelSlider, true);
            this.XPLevelSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.XPLevelSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XPLevelSlider.Location = new System.Drawing.Point(623, 479);
            this.XPLevelSlider.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.XPLevelSlider.Name = "XPLevelSlider";
            this.XPLevelSlider.Size = new System.Drawing.Size(116, 20);
            this.XPLevelSlider.TabIndex = 160;
            this.XPLevelSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.XPLevelSlider, "What Level should we be?\r\n\r\n(Affects newest player in splitscreen)");
            this.XPLevelSlider.ValueChanged += new System.EventHandler(this.XpLevelSliderChanged);
            // 
            // PlayerOptionsBtn
            // 
            this.PlayerOptionsBtn.Location = new System.Drawing.Point(566, 451);
            this.PlayerOptionsBtn.Name = "PlayerOptionsBtn";
            this.PlayerOptionsBtn.Size = new System.Drawing.Size(550, 25);
            this.PlayerOptionsBtn.TabIndex = 158;
            this.PlayerOptionsBtn.Tag = "";
            this.PlayerOptionsBtn.Text = "Player Options";
            this.ToolTipManager.SetToolTip(this.PlayerOptionsBtn, "Opens the Player Options window \r\nwhere you can modify Player Options");
            this.PlayerOptionsBtn.UseSelectable = true;
            this.PlayerOptionsBtn.Click += new System.EventHandler(this.PlayerOptionsBtnClicked);
            // 
            // PotionAmplifierSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.PotionAmplifierSlider, true);
            this.PotionAmplifierSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PotionAmplifierSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PotionAmplifierSlider.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PotionAmplifierSlider.Location = new System.Drawing.Point(407, 610);
            this.PotionAmplifierSlider.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PotionAmplifierSlider.Name = "PotionAmplifierSlider";
            this.PotionAmplifierSlider.Size = new System.Drawing.Size(141, 20);
            this.PotionAmplifierSlider.TabIndex = 157;
            this.PotionAmplifierSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.PotionAmplifierSlider, "How much should potion effects be amplified by?");
            this.PotionAmplifierSlider.ValueChanged += new System.EventHandler(this.PotionAmplifierSliderChanged);
            // 
            // PotionAmplifier
            // 
            this.PotionAmplifier.AutoSize = true;
            this.PotionAmplifier.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PotionAmplifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PotionAmplifier.Location = new System.Drawing.Point(292, 610);
            this.PotionAmplifier.Name = "PotionAmplifier";
            this.PotionAmplifier.Size = new System.Drawing.Size(109, 19);
            this.PotionAmplifier.TabIndex = 156;
            this.PotionAmplifier.Tag = "";
            this.PotionAmplifier.Text = "Potion Amplifier:";
            // 
            // NoSlowDowns
            // 
            this.NoSlowDowns.AutoSize = true;
            this.NoSlowDowns.Location = new System.Drawing.Point(383, 153);
            this.NoSlowDowns.Name = "NoSlowDowns";
            this.NoSlowDowns.Size = new System.Drawing.Size(101, 15);
            this.NoSlowDowns.TabIndex = 155;
            this.NoSlowDowns.Tag = "";
            this.NoSlowDowns.Text = "No slowdowns";
            this.ToolTipManager.SetToolTip(this.NoSlowDowns, "Whether no movement penaltities \r\nare applied such as:\r\n\r\nEating\r\nDrinking\r\nDrawi" +
        "ng Bow\r\nDrawing Trident");
            this.NoSlowDowns.UseSelectable = true;
            this.NoSlowDowns.CheckedChanged += new System.EventHandler(this.NoSlowDownsToggled);
            // 
            // ESP
            // 
            this.ESP.AutoSize = true;
            this.ESP.Location = new System.Drawing.Point(383, 132);
            this.ESP.Name = "ESP";
            this.ESP.Size = new System.Drawing.Size(42, 15);
            this.ESP.TabIndex = 154;
            this.ESP.Tag = "";
            this.ESP.Text = "ESP";
            this.ToolTipManager.SetToolTip(this.ESP, "Whether player name tags are\r\ncovering player models");
            this.ESP.UseSelectable = true;
            this.ESP.CheckedChanged += new System.EventHandler(this.EspToggled);
            // 
            // AlwaysInWater
            // 
            this.AlwaysInWater.AutoSize = true;
            this.AlwaysInWater.Location = new System.Drawing.Point(383, 111);
            this.AlwaysInWater.Name = "AlwaysInWater";
            this.AlwaysInWater.Size = new System.Drawing.Size(107, 15);
            this.AlwaysInWater.TabIndex = 153;
            this.AlwaysInWater.Tag = "";
            this.AlwaysInWater.Text = "Always in Water";
            this.ToolTipManager.SetToolTip(this.AlwaysInWater, "Whether you\'ll always be considered\r\nin water");
            this.AlwaysInWater.UseSelectable = true;
            this.AlwaysInWater.CheckedChanged += new System.EventHandler(this.AlwaysInWaterToggled);
            // 
            // LevelX
            // 
            this.LevelX.AutoSize = true;
            this.LevelX.Location = new System.Drawing.Point(383, 90);
            this.LevelX.Name = "LevelX";
            this.LevelX.Size = new System.Drawing.Size(60, 15);
            this.LevelX.TabIndex = 152;
            this.LevelX.Tag = "";
            this.LevelX.Text = "Level X";
            this.ToolTipManager.SetToolTip(this.LevelX, "Whether your XP Level will show\r\nas Level X");
            this.LevelX.UseSelectable = true;
            this.LevelX.CheckedChanged += new System.EventHandler(this.LevelXToggled);
            // 
            // SeeThroughBlocks
            // 
            this.SeeThroughBlocks.AutoSize = true;
            this.SeeThroughBlocks.Location = new System.Drawing.Point(383, 69);
            this.SeeThroughBlocks.Name = "SeeThroughBlocks";
            this.SeeThroughBlocks.Size = new System.Drawing.Size(124, 15);
            this.SeeThroughBlocks.TabIndex = 151;
            this.SeeThroughBlocks.Tag = "";
            this.SeeThroughBlocks.Text = "See through blocks";
            this.ToolTipManager.SetToolTip(this.SeeThroughBlocks, "Whether you can see through blocks\r\n(instead of a fullscreen, 2d texure)");
            this.SeeThroughBlocks.UseSelectable = true;
            this.SeeThroughBlocks.CheckedChanged += new System.EventHandler(this.SeeThroughBlocksToggled);
            // 
            // AlwaysInLava
            // 
            this.AlwaysInLava.AutoSize = true;
            this.AlwaysInLava.Location = new System.Drawing.Point(383, 48);
            this.AlwaysInLava.Name = "AlwaysInLava";
            this.AlwaysInLava.Size = new System.Drawing.Size(100, 15);
            this.AlwaysInLava.TabIndex = 27;
            this.AlwaysInLava.Tag = "";
            this.AlwaysInLava.Text = "Always in Lava";
            this.ToolTipManager.SetToolTip(this.AlwaysInLava, "Whether you\'ll always be considered\r\nin lava");
            this.AlwaysInLava.UseSelectable = true;
            this.AlwaysInLava.CheckedChanged += new System.EventHandler(this.AlwaysInLavaToggled);
            // 
            // HideBlocks
            // 
            this.HideBlocks.AutoSize = true;
            this.HideBlocks.Location = new System.Drawing.Point(383, 27);
            this.HideBlocks.Name = "HideBlocks";
            this.HideBlocks.Size = new System.Drawing.Size(85, 15);
            this.HideBlocks.TabIndex = 150;
            this.HideBlocks.Tag = "";
            this.HideBlocks.Text = "Hide Blocks";
            this.ToolTipManager.SetToolTip(this.HideBlocks, "Whether to hide the majority of blocks \r\nexcluding chests, liquid and more");
            this.HideBlocks.UseSelectable = true;
            this.HideBlocks.CheckedChanged += new System.EventHandler(this.HideBlocksToggled);
            // 
            // UnderwaterEffects
            // 
            this.UnderwaterEffects.AutoSize = true;
            this.UnderwaterEffects.Location = new System.Drawing.Point(383, 6);
            this.UnderwaterEffects.Name = "UnderwaterEffects";
            this.UnderwaterEffects.Size = new System.Drawing.Size(171, 15);
            this.UnderwaterEffects.TabIndex = 149;
            this.UnderwaterEffects.Tag = "";
            this.UnderwaterEffects.Text = "Underwater Effects (Default)";
            this.UnderwaterEffects.ThreeState = true;
            this.ToolTipManager.SetToolTip(this.UnderwaterEffects, "Whether to enable or disable\r\nUnderwater Effects (or force them)");
            this.UnderwaterEffects.UseSelectable = true;
            this.UnderwaterEffects.CheckStateChanged += new System.EventHandler(this.UnderwaterEffectsToggled);
            // 
            // FrictionSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.FrictionSlider, true);
            this.FrictionSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FrictionSlider.DecimalPlaces = 8;
            this.FrictionSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FrictionSlider.Increment = new decimal(new int[] {
            10000000,
            0,
            0,
            524288});
            this.FrictionSlider.Location = new System.Drawing.Point(355, 584);
            this.FrictionSlider.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.FrictionSlider.Name = "FrictionSlider";
            this.FrictionSlider.Size = new System.Drawing.Size(193, 20);
            this.FrictionSlider.TabIndex = 147;
            this.FrictionSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.FrictionSlider, "How much friction do we have?\r\n\r\nCTRL + Click = Increase Decimal Places\r\nALT + Cl" +
        "ick = Decrease Decimal Places");
            this.FrictionSlider.Value = new decimal(new int[] {
            91000003,
            0,
            0,
            524288});
            this.FrictionSlider.ValueChanged += new System.EventHandler(this.FrictionSliderChanged);
            this.FrictionSlider.Click += new System.EventHandler(this.SliderClicked);
            // 
            // EnchantmentLevel
            // 
            this.EnchantmentLevel.AutoSize = true;
            this.EnchantmentLevel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.EnchantmentLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EnchantmentLevel.Location = new System.Drawing.Point(5, 480);
            this.EnchantmentLevel.Name = "EnchantmentLevel";
            this.EnchantmentLevel.Size = new System.Drawing.Size(128, 19);
            this.EnchantmentLevel.TabIndex = 116;
            this.EnchantmentLevel.Tag = "";
            this.EnchantmentLevel.Text = "Enchantment Level:";
            // 
            // Friction
            // 
            this.Friction.AutoSize = true;
            this.Friction.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Friction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Friction.Location = new System.Drawing.Point(292, 584);
            this.Friction.Name = "Friction";
            this.Friction.Size = new System.Drawing.Size(57, 19);
            this.Friction.TabIndex = 146;
            this.Friction.Tag = "";
            this.Friction.Text = "Friction:";
            // 
            // GodModeAll
            // 
            this.GodModeAll.AutoSize = true;
            this.GodModeAll.Location = new System.Drawing.Point(192, 425);
            this.GodModeAll.Name = "GodModeAll";
            this.GodModeAll.Size = new System.Drawing.Size(104, 15);
            this.GodModeAll.TabIndex = 148;
            this.GodModeAll.Tag = "";
            this.GodModeAll.Text = "God Mode (All)";
            this.ToolTipManager.SetToolTip(this.GodModeAll, "Whether to enable God Mode for everyone");
            this.GodModeAll.UseSelectable = true;
            this.GodModeAll.CheckedChanged += new System.EventHandler(this.GodModeAllToggled);
            // 
            // playerModelScaleSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.playerModelScaleSlider, true);
            this.playerModelScaleSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.playerModelScaleSlider.DecimalPlaces = 4;
            this.playerModelScaleSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playerModelScaleSlider.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            262144});
            this.playerModelScaleSlider.Location = new System.Drawing.Point(424, 558);
            this.playerModelScaleSlider.Name = "playerModelScaleSlider";
            this.playerModelScaleSlider.Size = new System.Drawing.Size(124, 20);
            this.playerModelScaleSlider.TabIndex = 142;
            this.playerModelScaleSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.playerModelScaleSlider, "How big (or small) should our player be?\r\n\r\nCTRL + Click = Increase Decimal Place" +
        "s\r\nALT + Click = Decrease Decimal Places");
            this.playerModelScaleSlider.Value = new decimal(new int[] {
            9375,
            0,
            0,
            262144});
            this.playerModelScaleSlider.ValueChanged += new System.EventHandler(this.PlayerModelScaleSliderChanged);
            this.playerModelScaleSlider.Click += new System.EventHandler(this.SliderClicked);
            // 
            // FieldofViewSplitscreen
            // 
            this.FieldofViewSplitscreen.AutoSize = true;
            this.FieldofViewSplitscreen.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.FieldofViewSplitscreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FieldofViewSplitscreen.Location = new System.Drawing.Point(4, 610);
            this.FieldofViewSplitscreen.Name = "FieldofViewSplitscreen";
            this.FieldofViewSplitscreen.Size = new System.Drawing.Size(166, 19);
            this.FieldofViewSplitscreen.TabIndex = 144;
            this.FieldofViewSplitscreen.Tag = "";
            this.FieldofViewSplitscreen.Text = "Field of View (Splitscreen):";
            // 
            // RiptideFlyingSpeed
            // 
            this.RiptideFlyingSpeed.AutoSize = true;
            this.RiptideFlyingSpeed.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.RiptideFlyingSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RiptideFlyingSpeed.Location = new System.Drawing.Point(292, 480);
            this.RiptideFlyingSpeed.Name = "RiptideFlyingSpeed";
            this.RiptideFlyingSpeed.Size = new System.Drawing.Size(140, 19);
            this.RiptideFlyingSpeed.TabIndex = 124;
            this.RiptideFlyingSpeed.Tag = "";
            this.RiptideFlyingSpeed.Text = "Riptide (flying) Speed:";
            // 
            // PlayerModelScale
            // 
            this.PlayerModelScale.AutoSize = true;
            this.PlayerModelScale.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PlayerModelScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PlayerModelScale.Location = new System.Drawing.Point(292, 558);
            this.PlayerModelScale.Name = "PlayerModelScale";
            this.PlayerModelScale.Size = new System.Drawing.Size(126, 19);
            this.PlayerModelScale.TabIndex = 141;
            this.PlayerModelScale.Tag = "";
            this.PlayerModelScale.Text = "Player Model Scale:";
            // 
            // FieldOfViewSplitSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.FieldOfViewSplitSlider, true);
            this.FieldOfViewSplitSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FieldOfViewSplitSlider.DecimalPlaces = 3;
            this.FieldOfViewSplitSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FieldOfViewSplitSlider.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.FieldOfViewSplitSlider.Location = new System.Drawing.Point(176, 610);
            this.FieldOfViewSplitSlider.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.FieldOfViewSplitSlider.Name = "FieldOfViewSplitSlider";
            this.FieldOfViewSplitSlider.Size = new System.Drawing.Size(110, 20);
            this.FieldOfViewSplitSlider.TabIndex = 145;
            this.FieldOfViewSplitSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.FieldOfViewSplitSlider, "How high should our FOV in splitscreen be?\r\n\r\nCTRL + Click = Increase Decimal Pla" +
        "ces\r\nALT + Click = Decrease Decimal Places");
            this.FieldOfViewSplitSlider.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.FieldOfViewSplitSlider.ValueChanged += new System.EventHandler(this.FieldOfViewSplitSliderChanged);
            this.FieldOfViewSplitSlider.Click += new System.EventHandler(this.SliderClicked);
            // 
            // RiptideFlyingSpeedSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.RiptideFlyingSpeedSlider, true);
            this.RiptideFlyingSpeedSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RiptideFlyingSpeedSlider.DecimalPlaces = 4;
            this.RiptideFlyingSpeedSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RiptideFlyingSpeedSlider.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            262144});
            this.RiptideFlyingSpeedSlider.Location = new System.Drawing.Point(438, 480);
            this.RiptideFlyingSpeedSlider.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RiptideFlyingSpeedSlider.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.RiptideFlyingSpeedSlider.Name = "RiptideFlyingSpeedSlider";
            this.RiptideFlyingSpeedSlider.Size = new System.Drawing.Size(110, 20);
            this.RiptideFlyingSpeedSlider.TabIndex = 125;
            this.RiptideFlyingSpeedSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.RiptideFlyingSpeedSlider, "How fast should the Riptide Enchentment go?\r\n\r\nCTRL + Click = Increase Decimal Pl" +
        "aces\r\nALT + Click = Decrease Decimal Places");
            this.RiptideFlyingSpeedSlider.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.RiptideFlyingSpeedSlider.ValueChanged += new System.EventHandler(this.RiptideFlyingSpeedSliderChanged);
            this.RiptideFlyingSpeedSlider.Click += new System.EventHandler(this.SliderClicked);
            // 
            // JumpHeight
            // 
            this.JumpHeight.AutoSize = true;
            this.JumpHeight.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.JumpHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.JumpHeight.Location = new System.Drawing.Point(4, 506);
            this.JumpHeight.Name = "JumpHeight";
            this.JumpHeight.Size = new System.Drawing.Size(90, 19);
            this.JumpHeight.TabIndex = 118;
            this.JumpHeight.Tag = "";
            this.JumpHeight.Text = "Jump Height:";
            // 
            // SprintingSpeedScale
            // 
            this.SprintingSpeedScale.AutoSize = true;
            this.SprintingSpeedScale.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SprintingSpeedScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SprintingSpeedScale.Location = new System.Drawing.Point(292, 506);
            this.SprintingSpeedScale.Name = "SprintingSpeedScale";
            this.SprintingSpeedScale.Size = new System.Drawing.Size(142, 19);
            this.SprintingSpeedScale.TabIndex = 127;
            this.SprintingSpeedScale.Tag = "";
            this.SprintingSpeedScale.Text = "Sprinting Speed Scale:";
            // 
            // GodMode
            // 
            this.GodMode.AutoSize = true;
            this.GodMode.Location = new System.Drawing.Point(192, 405);
            this.GodMode.Name = "GodMode";
            this.GodMode.Size = new System.Drawing.Size(109, 15);
            this.GodMode.TabIndex = 143;
            this.GodMode.Tag = "";
            this.GodMode.Text = "God Mode (Self)";
            this.ToolTipManager.SetToolTip(this.GodMode, "Whether to enable God Mode for local players only");
            this.GodMode.UseSelectable = true;
            this.GodMode.CheckedChanged += new System.EventHandler(this.GodModeToggled);
            // 
            // SprintingSpeedScaleSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.SprintingSpeedScaleSlider, true);
            this.SprintingSpeedScaleSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SprintingSpeedScaleSlider.DecimalPlaces = 3;
            this.SprintingSpeedScaleSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SprintingSpeedScaleSlider.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            262144});
            this.SprintingSpeedScaleSlider.Location = new System.Drawing.Point(433, 532);
            this.SprintingSpeedScaleSlider.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.SprintingSpeedScaleSlider.Name = "SprintingSpeedScaleSlider";
            this.SprintingSpeedScaleSlider.Size = new System.Drawing.Size(115, 20);
            this.SprintingSpeedScaleSlider.TabIndex = 128;
            this.SprintingSpeedScaleSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.SprintingSpeedScaleSlider, "How fast can the player sprint?\r\n\r\nCTRL + Click = Increase Decimal Places\r\nALT + " +
        "Click = Decrease Decimal Places");
            this.SprintingSpeedScaleSlider.Value = new decimal(new int[] {
            1875,
            0,
            0,
            196608});
            this.SprintingSpeedScaleSlider.ValueChanged += new System.EventHandler(this.SprintingSpeedScaleSliderChanged);
            this.SprintingSpeedScaleSlider.Click += new System.EventHandler(this.SliderClicked);
            // 
            // Reach
            // 
            this.Reach.AutoSize = true;
            this.Reach.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Reach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Reach.Location = new System.Drawing.Point(4, 532);
            this.Reach.Name = "Reach";
            this.Reach.Size = new System.Drawing.Size(48, 19);
            this.Reach.TabIndex = 120;
            this.Reach.Tag = "";
            this.Reach.Text = "Reach:";
            // 
            // WalkingSpeedScale
            // 
            this.WalkingSpeedScale.AutoSize = true;
            this.WalkingSpeedScale.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.WalkingSpeedScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WalkingSpeedScale.Location = new System.Drawing.Point(292, 532);
            this.WalkingSpeedScale.Name = "WalkingSpeedScale";
            this.WalkingSpeedScale.Size = new System.Drawing.Size(135, 19);
            this.WalkingSpeedScale.TabIndex = 130;
            this.WalkingSpeedScale.Tag = "";
            this.WalkingSpeedScale.Text = "Walking Speed Scale:";
            // 
            // EnchantmentLevelSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.EnchantmentLevelSlider, true);
            this.EnchantmentLevelSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EnchantmentLevelSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EnchantmentLevelSlider.Location = new System.Drawing.Point(139, 480);
            this.EnchantmentLevelSlider.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.EnchantmentLevelSlider.Name = "EnchantmentLevelSlider";
            this.EnchantmentLevelSlider.Size = new System.Drawing.Size(147, 20);
            this.EnchantmentLevelSlider.TabIndex = 117;
            this.EnchantmentLevelSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.EnchantmentLevelSlider, "What enchantment level should the currently held item have?\r\n\r\nCTRL + Click = Inc" +
        "rease Decimal Places\r\nALT + Click = Decrease Decimal Places");
            this.EnchantmentLevelSlider.ValueChanged += new System.EventHandler(this.EnchantmentLevelSliderChanged);
            // 
            // WalkingSpeedScaleSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.WalkingSpeedScaleSlider, true);
            this.WalkingSpeedScaleSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WalkingSpeedScaleSlider.DecimalPlaces = 3;
            this.WalkingSpeedScaleSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WalkingSpeedScaleSlider.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            262144});
            this.WalkingSpeedScaleSlider.Location = new System.Drawing.Point(440, 506);
            this.WalkingSpeedScaleSlider.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.WalkingSpeedScaleSlider.Name = "WalkingSpeedScaleSlider";
            this.WalkingSpeedScaleSlider.Size = new System.Drawing.Size(108, 20);
            this.WalkingSpeedScaleSlider.TabIndex = 131;
            this.WalkingSpeedScaleSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.WalkingSpeedScaleSlider, "How fast can the player walk?\r\n\r\nCTRL + Click = Increase Decimal Places\r\nALT + Cl" +
        "ick = Decrease Decimal Places");
            this.WalkingSpeedScaleSlider.Value = new decimal(new int[] {
            163,
            0,
            0,
            196608});
            this.WalkingSpeedScaleSlider.ValueChanged += new System.EventHandler(this.WalkingSpeedScaleChanged);
            this.WalkingSpeedScaleSlider.Click += new System.EventHandler(this.SliderClicked);
            // 
            // ReachSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.ReachSlider, true);
            this.ReachSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ReachSlider.DecimalPlaces = 1;
            this.ReachSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReachSlider.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ReachSlider.Location = new System.Drawing.Point(58, 532);
            this.ReachSlider.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.ReachSlider.Minimum = new decimal(new int[] {
            512,
            0,
            0,
            -2147483648});
            this.ReachSlider.Name = "ReachSlider";
            this.ReachSlider.Size = new System.Drawing.Size(228, 20);
            this.ReachSlider.TabIndex = 121;
            this.ReachSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.ReachSlider, "How far can the player reach?\r\n\r\nCTRL + Click = Increase Decimal Places\r\nALT + Cl" +
        "ick = Decrease Decimal Places");
            this.ReachSlider.Value = new decimal(new int[] {
            45,
            0,
            0,
            65536});
            this.ReachSlider.ValueChanged += new System.EventHandler(this.ReachSliderChanged);
            this.ReachSlider.Click += new System.EventHandler(this.SliderClicked);
            // 
            // JumpHeightSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.JumpHeightSlider, true);
            this.JumpHeightSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.JumpHeightSlider.DecimalPlaces = 3;
            this.JumpHeightSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.JumpHeightSlider.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.JumpHeightSlider.Location = new System.Drawing.Point(100, 506);
            this.JumpHeightSlider.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.JumpHeightSlider.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.JumpHeightSlider.Name = "JumpHeightSlider";
            this.JumpHeightSlider.Size = new System.Drawing.Size(186, 20);
            this.JumpHeightSlider.TabIndex = 119;
            this.JumpHeightSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.JumpHeightSlider, "How high should the player jump?\r\n\r\nCTRL + Click = Increase Decimal Places\r\nALT +" +
        " Click = Decrease Decimal Places");
            this.JumpHeightSlider.Value = new decimal(new int[] {
            420,
            0,
            0,
            196608});
            this.JumpHeightSlider.ValueChanged += new System.EventHandler(this.JumpHeightSliderChanged);
            this.JumpHeightSlider.Click += new System.EventHandler(this.SliderClicked);
            // 
            // DeadMauFiveMode
            // 
            this.DeadMauFiveMode.AutoSize = true;
            this.DeadMauFiveMode.Location = new System.Drawing.Point(192, 384);
            this.DeadMauFiveMode.Name = "DeadMauFiveMode";
            this.DeadMauFiveMode.Size = new System.Drawing.Size(83, 15);
            this.DeadMauFiveMode.TabIndex = 140;
            this.DeadMauFiveMode.Tag = "";
            this.DeadMauFiveMode.Text = "Mouse Ears";
            this.ToolTipManager.SetToolTip(this.DeadMauFiveMode, "Whether the game will apply mouse ears to your player when holding an item");
            this.DeadMauFiveMode.UseSelectable = true;
            this.DeadMauFiveMode.CheckedChanged += new System.EventHandler(this.DeadMauFiveModeToggled);
            // 
            // ArmorHUD
            // 
            this.ArmorHUD.AutoSize = true;
            this.ArmorHUD.Location = new System.Drawing.Point(192, 363);
            this.ArmorHUD.Name = "ArmorHUD";
            this.ArmorHUD.Size = new System.Drawing.Size(85, 15);
            this.ArmorHUD.TabIndex = 138;
            this.ArmorHUD.Tag = "";
            this.ArmorHUD.Text = "Armor HUD";
            this.ToolTipManager.SetToolTip(this.ArmorHUD, "Whether to display a HUD Element which displays your currently equipped armor");
            this.ArmorHUD.UseSelectable = true;
            this.ArmorHUD.CheckedChanged += new System.EventHandler(this.ArmorHudToggled);
            // 
            // TakeEverythingAnywhere
            // 
            this.TakeEverythingAnywhere.AutoSize = true;
            this.TakeEverythingAnywhere.Location = new System.Drawing.Point(192, 342);
            this.TakeEverythingAnywhere.Name = "TakeEverythingAnywhere";
            this.TakeEverythingAnywhere.Size = new System.Drawing.Size(161, 15);
            this.TakeEverythingAnywhere.TabIndex = 25;
            this.TakeEverythingAnywhere.Tag = "";
            this.TakeEverythingAnywhere.Text = "Take Everything Anywhere";
            this.ToolTipManager.SetToolTip(this.TakeEverythingAnywhere, "Whether the \"Take Everything\" option is usable in any world and minigame regardle" +
        "ss of settings");
            this.TakeEverythingAnywhere.UseSelectable = true;
            this.TakeEverythingAnywhere.CheckedChanged += new System.EventHandler(this.TakeEverythingAnywhereToggled);
            // 
            // FieldOfView
            // 
            this.FieldOfView.AutoSize = true;
            this.FieldOfView.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.FieldOfView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FieldOfView.Location = new System.Drawing.Point(4, 584);
            this.FieldOfView.Name = "FieldOfView";
            this.FieldOfView.Size = new System.Drawing.Size(89, 19);
            this.FieldOfView.TabIndex = 136;
            this.FieldOfView.Tag = "";
            this.FieldOfView.Text = "Field of View:";
            // 
            // FieldOfViewSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.FieldOfViewSlider, true);
            this.FieldOfViewSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FieldOfViewSlider.DecimalPlaces = 3;
            this.FieldOfViewSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FieldOfViewSlider.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.FieldOfViewSlider.Location = new System.Drawing.Point(99, 584);
            this.FieldOfViewSlider.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.FieldOfViewSlider.Name = "FieldOfViewSlider";
            this.FieldOfViewSlider.Size = new System.Drawing.Size(187, 20);
            this.FieldOfViewSlider.TabIndex = 137;
            this.FieldOfViewSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.FieldOfViewSlider, "How high should our FOV be?\r\n\r\nCTRL + Click = Increase Decimal Places\r\nALT + Clic" +
        "k = Decrease Decimal Places\r\n");
            this.FieldOfViewSlider.Value = new decimal(new int[] {
            1875,
            0,
            0,
            196608});
            this.FieldOfViewSlider.ValueChanged += new System.EventHandler(this.FieldOfViewSliderChanged);
            this.FieldOfViewSlider.Click += new System.EventHandler(this.SliderClicked);
            // 
            // HiddenGameModesUnlocked
            // 
            this.HiddenGameModesUnlocked.AutoSize = true;
            this.HiddenGameModesUnlocked.Location = new System.Drawing.Point(192, 321);
            this.HiddenGameModesUnlocked.Name = "HiddenGameModesUnlocked";
            this.HiddenGameModesUnlocked.Size = new System.Drawing.Size(185, 15);
            this.HiddenGameModesUnlocked.TabIndex = 135;
            this.HiddenGameModesUnlocked.Tag = "";
            this.HiddenGameModesUnlocked.Text = "Hidden Gamemodes Unlocked";
            this.ToolTipManager.SetToolTip(this.HiddenGameModesUnlocked, "Whether to unlock hidden gamemodes \r\nThey can be switched in-game using host priv" +
        "ileges\r\n");
            this.HiddenGameModesUnlocked.UseSelectable = true;
            this.HiddenGameModesUnlocked.CheckedChanged += new System.EventHandler(this.HiddenGameModesUnlockedToggled);
            // 
            // HitBoxScale
            // 
            this.HitBoxScale.AutoSize = true;
            this.HitBoxScale.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.HitBoxScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HitBoxScale.Location = new System.Drawing.Point(4, 558);
            this.HitBoxScale.Name = "HitBoxScale";
            this.HitBoxScale.Size = new System.Drawing.Size(86, 19);
            this.HitBoxScale.TabIndex = 133;
            this.HitBoxScale.Tag = "";
            this.HitBoxScale.Text = "Hitbox Scale:";
            // 
            // CraftingTableAnywhere
            // 
            this.CraftingTableAnywhere.AutoSize = true;
            this.CraftingTableAnywhere.Location = new System.Drawing.Point(192, 300);
            this.CraftingTableAnywhere.Name = "CraftingTableAnywhere";
            this.CraftingTableAnywhere.Size = new System.Drawing.Size(152, 15);
            this.CraftingTableAnywhere.TabIndex = 132;
            this.CraftingTableAnywhere.Tag = "";
            this.CraftingTableAnywhere.Text = "Crafting Table Anywhere";
            this.ToolTipManager.SetToolTip(this.CraftingTableAnywhere, "Whether you can have the crafting table UI anywhere");
            this.CraftingTableAnywhere.UseSelectable = true;
            this.CraftingTableAnywhere.CheckedChanged += new System.EventHandler(this.CraftingTableAnywhereToggled);
            // 
            // VisibleHitboxes
            // 
            this.VisibleHitboxes.AutoSize = true;
            this.VisibleHitboxes.Location = new System.Drawing.Point(192, 279);
            this.VisibleHitboxes.Name = "VisibleHitboxes";
            this.VisibleHitboxes.Size = new System.Drawing.Size(107, 15);
            this.VisibleHitboxes.TabIndex = 129;
            this.VisibleHitboxes.Tag = "";
            this.VisibleHitboxes.Text = "Visible Hitboxes";
            this.ToolTipManager.SetToolTip(this.VisibleHitboxes, "Whether to show the hitboxes on Players and Mobs");
            this.VisibleHitboxes.UseSelectable = true;
            this.VisibleHitboxes.CheckedChanged += new System.EventHandler(this.VisibleHitboxesToggled);
            // 
            // HitBoxScaleSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.HitBoxScaleSlider, true);
            this.HitBoxScaleSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HitBoxScaleSlider.DecimalPlaces = 1;
            this.HitBoxScaleSlider.Enabled = false;
            this.HitBoxScaleSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HitBoxScaleSlider.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.HitBoxScaleSlider.Location = new System.Drawing.Point(96, 558);
            this.HitBoxScaleSlider.Name = "HitBoxScaleSlider";
            this.HitBoxScaleSlider.Size = new System.Drawing.Size(190, 20);
            this.HitBoxScaleSlider.TabIndex = 134;
            this.HitBoxScaleSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.HitBoxScaleSlider, "How big should entity hitboxes be? (disabled until fixed)\r\n\r\nCTRL + Click = Incre" +
        "ase Decimal Places\r\nALT + Click = Decrease Decimal Places");
            this.HitBoxScaleSlider.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.HitBoxScaleSlider.Click += new System.EventHandler(this.SliderClicked);
            // 
            // NnidEditorBtn
            // 
            this.NnidEditorBtn.Location = new System.Drawing.Point(7, 451);
            this.NnidEditorBtn.Name = "NnidEditorBtn";
            this.NnidEditorBtn.Size = new System.Drawing.Size(550, 25);
            this.NnidEditorBtn.TabIndex = 126;
            this.NnidEditorBtn.Tag = "";
            this.NnidEditorBtn.Text = "Nintendo Network Editor";
            this.NnidEditorBtn.UseSelectable = true;
            this.NnidEditorBtn.Click += new System.EventHandler(this.NnidEditorBtnClicked);
            // 
            // InsaneCriticalHits
            // 
            this.InsaneCriticalHits.AutoSize = true;
            this.InsaneCriticalHits.BackColor = System.Drawing.Color.Transparent;
            this.InsaneCriticalHits.Location = new System.Drawing.Point(192, 195);
            this.InsaneCriticalHits.Name = "InsaneCriticalHits";
            this.InsaneCriticalHits.Size = new System.Drawing.Size(121, 15);
            this.InsaneCriticalHits.TabIndex = 112;
            this.InsaneCriticalHits.Tag = "";
            this.InsaneCriticalHits.Text = "Insane Critical Hits";
            this.ToolTipManager.SetToolTip(this.InsaneCriticalHits, "Whether critical hits deal insane damage");
            this.InsaneCriticalHits.UseSelectable = true;
            this.InsaneCriticalHits.CheckedChanged += new System.EventHandler(this.InsaneCriticalHitsToggled);
            // 
            // AlwaysSwimming
            // 
            this.AlwaysSwimming.AutoSize = true;
            this.AlwaysSwimming.Location = new System.Drawing.Point(192, 215);
            this.AlwaysSwimming.Name = "AlwaysSwimming";
            this.AlwaysSwimming.Size = new System.Drawing.Size(120, 15);
            this.AlwaysSwimming.TabIndex = 109;
            this.AlwaysSwimming.Tag = "";
            this.AlwaysSwimming.Text = "Always Swimming";
            this.ToolTipManager.SetToolTip(this.AlwaysSwimming, "Whether you\'ll always be in a swimming state");
            this.AlwaysSwimming.UseSelectable = true;
            this.AlwaysSwimming.CheckedChanged += new System.EventHandler(this.AlwaysSwimmingToggled);
            // 
            // InfiniteRiptide
            // 
            this.InfiniteRiptide.AutoSize = true;
            this.InfiniteRiptide.Location = new System.Drawing.Point(192, 258);
            this.InfiniteRiptide.Name = "InfiniteRiptide";
            this.InfiniteRiptide.Size = new System.Drawing.Size(100, 15);
            this.InfiniteRiptide.TabIndex = 108;
            this.InfiniteRiptide.Tag = "";
            this.InfiniteRiptide.Text = "Infinite Riptide";
            this.ToolTipManager.SetToolTip(this.InfiniteRiptide, "Whether you can use Riptide anywhere");
            this.InfiniteRiptide.UseSelectable = true;
            this.InfiniteRiptide.CheckedChanged += new System.EventHandler(this.InfiniteRiptideToggled);
            // 
            // FullRotation
            // 
            this.FullRotation.AutoSize = true;
            this.FullRotation.Location = new System.Drawing.Point(7, 342);
            this.FullRotation.Name = "FullRotation";
            this.FullRotation.Size = new System.Drawing.Size(90, 15);
            this.FullRotation.TabIndex = 107;
            this.FullRotation.Tag = "";
            this.FullRotation.Text = "Full Rotation";
            this.ToolTipManager.SetToolTip(this.FullRotation, "Whether to enable full player rotation");
            this.FullRotation.UseSelectable = true;
            this.FullRotation.CheckedChanged += new System.EventHandler(this.FullRotationToggled);
            // 
            // AlwaysDamagedPlayers
            // 
            this.AlwaysDamagedPlayers.AutoSize = true;
            this.AlwaysDamagedPlayers.Location = new System.Drawing.Point(192, 237);
            this.AlwaysDamagedPlayers.Name = "AlwaysDamagedPlayers";
            this.AlwaysDamagedPlayers.Size = new System.Drawing.Size(114, 15);
            this.AlwaysDamagedPlayers.TabIndex = 106;
            this.AlwaysDamagedPlayers.Tag = "";
            this.AlwaysDamagedPlayers.Text = "Always Damaged";
            this.ToolTipManager.SetToolTip(this.AlwaysDamagedPlayers, "Whether you always receive damage");
            this.AlwaysDamagedPlayers.UseSelectable = true;
            this.AlwaysDamagedPlayers.CheckedChanged += new System.EventHandler(this.AlwaysDamagedPlayersToggled);
            // 
            // InfiniteItems
            // 
            this.InfiniteItems.AutoSize = true;
            this.InfiniteItems.Location = new System.Drawing.Point(192, 174);
            this.InfiniteItems.Name = "InfiniteItems";
            this.InfiniteItems.Size = new System.Drawing.Size(92, 15);
            this.InfiniteItems.TabIndex = 104;
            this.InfiniteItems.Tag = "";
            this.InfiniteItems.Text = "Infinite Items";
            this.ToolTipManager.SetToolTip(this.InfiniteItems, "Whether all items in your inventory are infinite");
            this.InfiniteItems.UseSelectable = true;
            this.InfiniteItems.CheckedChanged += new System.EventHandler(this.InfiniteItemsToggled);
            // 
            // RapidBow
            // 
            this.RapidBow.AutoSize = true;
            this.RapidBow.Location = new System.Drawing.Point(192, 153);
            this.RapidBow.Name = "RapidBow";
            this.RapidBow.Size = new System.Drawing.Size(79, 15);
            this.RapidBow.TabIndex = 76;
            this.RapidBow.Tag = "";
            this.RapidBow.Text = "Rapid Bow";
            this.ToolTipManager.SetToolTip(this.RapidBow, "Whether the bow can be rapid fired");
            this.RapidBow.UseSelectable = true;
            this.RapidBow.CheckedChanged += new System.EventHandler(this.RapidBowToggled);
            // 
            // BloodVision
            // 
            this.BloodVision.AutoSize = true;
            this.BloodVision.BackColor = System.Drawing.Color.Transparent;
            this.BloodVision.Location = new System.Drawing.Point(192, 132);
            this.BloodVision.Name = "BloodVision";
            this.BloodVision.Size = new System.Drawing.Size(89, 15);
            this.BloodVision.TabIndex = 103;
            this.BloodVision.Tag = "";
            this.BloodVision.Text = "Blood Vision";
            this.ToolTipManager.SetToolTip(this.BloodVision, "Whether you\'ll have a red vision");
            this.BloodVision.UseSelectable = true;
            this.BloodVision.CheckedChanged += new System.EventHandler(this.BloodVisionToggled);
            // 
            // IgnorePotions
            // 
            this.IgnorePotions.AutoSize = true;
            this.IgnorePotions.BackColor = System.Drawing.Color.Transparent;
            this.IgnorePotions.Location = new System.Drawing.Point(192, 111);
            this.IgnorePotions.Name = "IgnorePotions";
            this.IgnorePotions.Size = new System.Drawing.Size(100, 15);
            this.IgnorePotions.TabIndex = 102;
            this.IgnorePotions.Tag = "";
            this.IgnorePotions.Text = "Ignore Potions";
            this.ToolTipManager.SetToolTip(this.IgnorePotions, "Whether to ignore all potion effects");
            this.IgnorePotions.UseSelectable = true;
            this.IgnorePotions.CheckedChanged += new System.EventHandler(this.IgnorePotionsToggled);
            // 
            // ForeverLastingPotions
            // 
            this.ForeverLastingPotions.AutoSize = true;
            this.ForeverLastingPotions.BackColor = System.Drawing.Color.Transparent;
            this.ForeverLastingPotions.Location = new System.Drawing.Point(192, 90);
            this.ForeverLastingPotions.Name = "ForeverLastingPotions";
            this.ForeverLastingPotions.Size = new System.Drawing.Size(146, 15);
            this.ForeverLastingPotions.TabIndex = 101;
            this.ForeverLastingPotions.Tag = "";
            this.ForeverLastingPotions.Text = "Forever Lasting Potions";
            this.ToolTipManager.SetToolTip(this.ForeverLastingPotions, "Whether potions will last forever");
            this.ForeverLastingPotions.UseSelectable = true;
            this.ForeverLastingPotions.CheckedChanged += new System.EventHandler(this.ForeverLastingPotionsToggled);
            // 
            // BypassInvulnerability
            // 
            this.BypassInvulnerability.AutoSize = true;
            this.BypassInvulnerability.BackColor = System.Drawing.Color.Transparent;
            this.BypassInvulnerability.Location = new System.Drawing.Point(192, 69);
            this.BypassInvulnerability.Name = "BypassInvulnerability";
            this.BypassInvulnerability.Size = new System.Drawing.Size(137, 15);
            this.BypassInvulnerability.TabIndex = 100;
            this.BypassInvulnerability.Tag = "";
            this.BypassInvulnerability.Text = "Bypass Invulnerability";
            this.ToolTipManager.SetToolTip(this.BypassInvulnerability, "Whether you can bypass invulnerability");
            this.BypassInvulnerability.UseSelectable = true;
            this.BypassInvulnerability.CheckedChanged += new System.EventHandler(this.BypassInvulnerabilityToggled);
            // 
            // PlaceBlocksonHead
            // 
            this.PlaceBlocksonHead.AutoSize = true;
            this.PlaceBlocksonHead.BackColor = System.Drawing.Color.Transparent;
            this.PlaceBlocksonHead.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlaceBlocksonHead.Location = new System.Drawing.Point(193, 48);
            this.PlaceBlocksonHead.Name = "PlaceBlocksonHead";
            this.PlaceBlocksonHead.Size = new System.Drawing.Size(136, 15);
            this.PlaceBlocksonHead.TabIndex = 99;
            this.PlaceBlocksonHead.Tag = "";
            this.PlaceBlocksonHead.Text = "Place Blocks on Head";
            this.ToolTipManager.SetToolTip(this.PlaceBlocksonHead, "Whether you can place blocks on your top armor slot");
            this.PlaceBlocksonHead.UseSelectable = true;
            this.PlaceBlocksonHead.CheckedChanged += new System.EventHandler(this.PlaceBlocksonHeadToggled);
            // 
            // WalkonWater
            // 
            this.WalkonWater.AutoSize = true;
            this.WalkonWater.BackColor = System.Drawing.Color.Transparent;
            this.WalkonWater.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WalkonWater.Location = new System.Drawing.Point(193, 27);
            this.WalkonWater.Name = "WalkonWater";
            this.WalkonWater.Size = new System.Drawing.Size(100, 15);
            this.WalkonWater.TabIndex = 98;
            this.WalkonWater.Tag = "";
            this.WalkonWater.Text = "Walk on Water";
            this.ToolTipManager.SetToolTip(this.WalkonWater, "Whether you can walk on water");
            this.WalkonWater.UseSelectable = true;
            this.WalkonWater.CheckedChanged += new System.EventHandler(this.WalkonWaterToggled);
            // 
            // AlwaysElytra
            // 
            this.AlwaysElytra.AutoSize = true;
            this.AlwaysElytra.BackColor = System.Drawing.Color.Transparent;
            this.AlwaysElytra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AlwaysElytra.Location = new System.Drawing.Point(193, 6);
            this.AlwaysElytra.Name = "AlwaysElytra";
            this.AlwaysElytra.Size = new System.Drawing.Size(92, 15);
            this.AlwaysElytra.TabIndex = 97;
            this.AlwaysElytra.Tag = "";
            this.AlwaysElytra.Text = "Always Elytra";
            this.ToolTipManager.SetToolTip(this.AlwaysElytra, "Whether you\'ll always be in an elyra state");
            this.AlwaysElytra.UseSelectable = true;
            this.AlwaysElytra.CheckedChanged += new System.EventHandler(this.AlwaysElytraToggled);
            // 
            // CaveFinder
            // 
            this.CaveFinder.AutoSize = true;
            this.CaveFinder.BackColor = System.Drawing.Color.Transparent;
            this.CaveFinder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaveFinder.Location = new System.Drawing.Point(7, 426);
            this.CaveFinder.Name = "CaveFinder";
            this.CaveFinder.Size = new System.Drawing.Size(85, 15);
            this.CaveFinder.TabIndex = 96;
            this.CaveFinder.Tag = "";
            this.CaveFinder.Text = "Cave Finder";
            this.ToolTipManager.SetToolTip(this.CaveFinder, "Whether to make caves visible through the ground");
            this.CaveFinder.UseSelectable = true;
            this.CaveFinder.CheckedChanged += new System.EventHandler(this.CaveFinderToggled);
            // 
            // Wallhack
            // 
            this.Wallhack.AutoSize = true;
            this.Wallhack.BackColor = System.Drawing.Color.Transparent;
            this.Wallhack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Wallhack.Location = new System.Drawing.Point(7, 405);
            this.Wallhack.Name = "Wallhack";
            this.Wallhack.Size = new System.Drawing.Size(71, 15);
            this.Wallhack.TabIndex = 95;
            this.Wallhack.Tag = "";
            this.Wallhack.Text = "Wallhack";
            this.ToolTipManager.SetToolTip(this.Wallhack, "Whether to have the ability to see through walls");
            this.Wallhack.UseSelectable = true;
            this.Wallhack.CheckedChanged += new System.EventHandler(this.WallhackToggled);
            // 
            // LargeXPDrops
            // 
            this.LargeXPDrops.AutoSize = true;
            this.LargeXPDrops.BackColor = System.Drawing.Color.Transparent;
            this.LargeXPDrops.Location = new System.Drawing.Point(7, 384);
            this.LargeXPDrops.Name = "LargeXPDrops";
            this.LargeXPDrops.Size = new System.Drawing.Size(103, 15);
            this.LargeXPDrops.TabIndex = 94;
            this.LargeXPDrops.Tag = "";
            this.LargeXPDrops.Text = "Large XP Drops";
            this.ToolTipManager.SetToolTip(this.LargeXPDrops, "Whether XP dropped by Entities are insane");
            this.LargeXPDrops.UseSelectable = true;
            this.LargeXPDrops.CheckedChanged += new System.EventHandler(this.LargeXpDropsToggled);
            // 
            // WallClimbing
            // 
            this.WallClimbing.AutoSize = true;
            this.WallClimbing.BackColor = System.Drawing.Color.Transparent;
            this.WallClimbing.Location = new System.Drawing.Point(7, 363);
            this.WallClimbing.Name = "WallClimbing";
            this.WallClimbing.Size = new System.Drawing.Size(98, 15);
            this.WallClimbing.TabIndex = 93;
            this.WallClimbing.Tag = "";
            this.WallClimbing.Text = "Wall Climbing";
            this.ToolTipManager.SetToolTip(this.WallClimbing, "Whether to make any surface climbable");
            this.WallClimbing.UseSelectable = true;
            this.WallClimbing.CheckedChanged += new System.EventHandler(this.WallClimbingToggled);
            // 
            // NoCollision
            // 
            this.NoCollision.AutoSize = true;
            this.NoCollision.BackColor = System.Drawing.Color.Transparent;
            this.NoCollision.Location = new System.Drawing.Point(7, 321);
            this.NoCollision.Name = "NoCollision";
            this.NoCollision.Size = new System.Drawing.Size(88, 15);
            this.NoCollision.TabIndex = 92;
            this.NoCollision.Tag = "";
            this.NoCollision.Text = "No Collision";
            this.ToolTipManager.SetToolTip(this.NoCollision, "Whether to disable collision ");
            this.NoCollision.UseSelectable = true;
            this.NoCollision.CheckedChanged += new System.EventHandler(this.NoCollisionToggled);
            // 
            // InfiniteAir
            // 
            this.InfiniteAir.AutoSize = true;
            this.InfiniteAir.BackColor = System.Drawing.Color.Transparent;
            this.InfiniteAir.Location = new System.Drawing.Point(7, 279);
            this.InfiniteAir.Name = "InfiniteAir";
            this.InfiniteAir.Size = new System.Drawing.Size(78, 15);
            this.InfiniteAir.TabIndex = 91;
            this.InfiniteAir.Tag = "";
            this.InfiniteAir.Text = "Infinite Air";
            this.ToolTipManager.SetToolTip(this.InfiniteAir, "Whether you\'ll never run out of air underwater");
            this.InfiniteAir.UseSelectable = true;
            this.InfiniteAir.CheckedChanged += new System.EventHandler(this.InfiniteAirToggled);
            // 
            // InfiniteDurability
            // 
            this.InfiniteDurability.AutoSize = true;
            this.InfiniteDurability.BackColor = System.Drawing.Color.Transparent;
            this.InfiniteDurability.Location = new System.Drawing.Point(7, 300);
            this.InfiniteDurability.Name = "InfiniteDurability";
            this.InfiniteDurability.Size = new System.Drawing.Size(114, 15);
            this.InfiniteDurability.TabIndex = 90;
            this.InfiniteDurability.Tag = "";
            this.InfiniteDurability.Text = "Infinite Durability";
            this.ToolTipManager.SetToolTip(this.InfiniteDurability, "Whether items their durability will never go down");
            this.InfiniteDurability.UseSelectable = true;
            this.InfiniteDurability.CheckedChanged += new System.EventHandler(this.InfiniteDurabilityToggled);
            // 
            // SuperKnockback
            // 
            this.SuperKnockback.AutoSize = true;
            this.SuperKnockback.BackColor = System.Drawing.Color.Transparent;
            this.SuperKnockback.Location = new System.Drawing.Point(7, 258);
            this.SuperKnockback.Name = "SuperKnockback";
            this.SuperKnockback.Size = new System.Drawing.Size(114, 15);
            this.SuperKnockback.TabIndex = 89;
            this.SuperKnockback.Tag = "";
            this.SuperKnockback.Text = "Super Knockback";
            this.ToolTipManager.SetToolTip(this.SuperKnockback, "Whether knockbacks are stronger than before");
            this.SuperKnockback.UseSelectable = true;
            this.SuperKnockback.CheckedChanged += new System.EventHandler(this.SuperKnockbackToggled);
            // 
            // DisabledKnockback
            // 
            this.DisabledKnockback.AutoSize = true;
            this.DisabledKnockback.BackColor = System.Drawing.Color.Transparent;
            this.DisabledKnockback.Location = new System.Drawing.Point(7, 237);
            this.DisabledKnockback.Name = "DisabledKnockback";
            this.DisabledKnockback.Size = new System.Drawing.Size(129, 15);
            this.DisabledKnockback.TabIndex = 88;
            this.DisabledKnockback.Tag = "";
            this.DisabledKnockback.Text = "Disabled Knockback";
            this.ToolTipManager.SetToolTip(this.DisabledKnockback, "Whether to disable all sorts of knockbacks");
            this.DisabledKnockback.UseSelectable = true;
            this.DisabledKnockback.CheckedChanged += new System.EventHandler(this.DisabledKnockbackToggled);
            // 
            // SilkTouchAnything
            // 
            this.SilkTouchAnything.AutoSize = true;
            this.SilkTouchAnything.BackColor = System.Drawing.Color.Transparent;
            this.SilkTouchAnything.Location = new System.Drawing.Point(7, 216);
            this.SilkTouchAnything.Name = "SilkTouchAnything";
            this.SilkTouchAnything.Size = new System.Drawing.Size(128, 15);
            this.SilkTouchAnything.TabIndex = 87;
            this.SilkTouchAnything.Tag = "";
            this.SilkTouchAnything.Text = "Silk Touch Anything";
            this.ToolTipManager.SetToolTip(this.SilkTouchAnything, "Whether you\'ll be able to Silk Touch any block");
            this.SilkTouchAnything.UseSelectable = true;
            this.SilkTouchAnything.CheckedChanged += new System.EventHandler(this.SilkTouchAnythingToggled);
            // 
            // DeveloperMode
            // 
            this.DeveloperMode.AutoSize = true;
            this.DeveloperMode.Location = new System.Drawing.Point(7, 195);
            this.DeveloperMode.Name = "DeveloperMode";
            this.DeveloperMode.Size = new System.Drawing.Size(110, 15);
            this.DeveloperMode.TabIndex = 86;
            this.DeveloperMode.Tag = "";
            this.DeveloperMode.Text = "Developer Mode";
            this.ToolTipManager.SetToolTip(this.DeveloperMode, "Whether you can view detailed item information and change your skin in Minigames");
            this.DeveloperMode.UseSelectable = true;
            this.DeveloperMode.CheckedChanged += new System.EventHandler(this.DeveloperModeToggled);
            // 
            // PickLiquidBlocks
            // 
            this.PickLiquidBlocks.AutoSize = true;
            this.PickLiquidBlocks.Location = new System.Drawing.Point(7, 174);
            this.PickLiquidBlocks.Name = "PickLiquidBlocks";
            this.PickLiquidBlocks.Size = new System.Drawing.Size(118, 15);
            this.PickLiquidBlocks.TabIndex = 85;
            this.PickLiquidBlocks.Tag = "";
            this.PickLiquidBlocks.Text = "Pick Liquid Blocks";
            this.ToolTipManager.SetToolTip(this.PickLiquidBlocks, "Whether you can pick Liquid Blocks in Creative");
            this.PickLiquidBlocks.UseSelectable = true;
            this.PickLiquidBlocks.CheckedChanged += new System.EventHandler(this.PickLiquidBlocksToggled);
            // 
            // DuelWieldanyItem
            // 
            this.DuelWieldanyItem.AutoSize = true;
            this.DuelWieldanyItem.Location = new System.Drawing.Point(7, 153);
            this.DuelWieldanyItem.Name = "DuelWieldanyItem";
            this.DuelWieldanyItem.Size = new System.Drawing.Size(129, 15);
            this.DuelWieldanyItem.TabIndex = 84;
            this.DuelWieldanyItem.Tag = "";
            this.DuelWieldanyItem.Text = "Duel Wield any Item";
            this.ToolTipManager.SetToolTip(this.DuelWieldanyItem, "Whether you can dual wield any item (but not use it)");
            this.DuelWieldanyItem.UseSelectable = true;
            this.DuelWieldanyItem.CheckedChanged += new System.EventHandler(this.DuelWieldanyItemToggled);
            // 
            // DisableStarving
            // 
            this.DisableStarving.AutoSize = true;
            this.DisableStarving.Location = new System.Drawing.Point(7, 132);
            this.DisableStarving.Name = "DisableStarving";
            this.DisableStarving.Size = new System.Drawing.Size(107, 15);
            this.DisableStarving.TabIndex = 83;
            this.DisableStarving.Tag = "";
            this.DisableStarving.Text = "Disable Starving";
            this.ToolTipManager.SetToolTip(this.DisableStarving, "Whether you\'ll not take damage when starving");
            this.DisableStarving.UseSelectable = true;
            this.DisableStarving.CheckedChanged += new System.EventHandler(this.DisableStarvingToggled);
            // 
            // InstantMining
            // 
            this.InstantMining.AutoSize = true;
            this.InstantMining.Location = new System.Drawing.Point(7, 111);
            this.InstantMining.Name = "InstantMining";
            this.InstantMining.Size = new System.Drawing.Size(100, 15);
            this.InstantMining.TabIndex = 82;
            this.InstantMining.Tag = "";
            this.InstantMining.Text = "Instant Mining";
            this.ToolTipManager.SetToolTip(this.InstantMining, "Whether you\'ll mine at insane speeds");
            this.InstantMining.UseSelectable = true;
            this.InstantMining.CheckedChanged += new System.EventHandler(this.InstantMiningToggled);
            // 
            // Flying
            // 
            this.Flying.AutoSize = true;
            this.Flying.Location = new System.Drawing.Point(7, 90);
            this.Flying.Name = "Flying";
            this.Flying.Size = new System.Drawing.Size(55, 15);
            this.Flying.TabIndex = 81;
            this.Flying.Tag = "";
            this.Flying.Text = "Flying";
            this.ToolTipManager.SetToolTip(this.Flying, "Whether you can fly without being in Creative");
            this.Flying.UseSelectable = true;
            this.Flying.CheckedChanged += new System.EventHandler(this.FlyingToggled);
            // 
            // DisableSuffocating
            // 
            this.DisableSuffocating.AutoSize = true;
            this.DisableSuffocating.Location = new System.Drawing.Point(7, 69);
            this.DisableSuffocating.Name = "DisableSuffocating";
            this.DisableSuffocating.Size = new System.Drawing.Size(125, 15);
            this.DisableSuffocating.TabIndex = 80;
            this.DisableSuffocating.Tag = "";
            this.DisableSuffocating.Text = "Disable Suffocating";
            this.ToolTipManager.SetToolTip(this.DisableSuffocating, "Whether you won\'t suffocate when stuck in a block");
            this.DisableSuffocating.UseSelectable = true;
            this.DisableSuffocating.CheckedChanged += new System.EventHandler(this.DisableSuffocatingToggled);
            // 
            // NoFallDamage
            // 
            this.NoFallDamage.AutoSize = true;
            this.NoFallDamage.Location = new System.Drawing.Point(7, 48);
            this.NoFallDamage.Name = "NoFallDamage";
            this.NoFallDamage.Size = new System.Drawing.Size(107, 15);
            this.NoFallDamage.TabIndex = 79;
            this.NoFallDamage.Tag = "";
            this.NoFallDamage.Text = "No Fall Damage";
            this.ToolTipManager.SetToolTip(this.NoFallDamage, "Whether you\'ll take no damage from falling");
            this.NoFallDamage.UseSelectable = true;
            this.NoFallDamage.CheckedChanged += new System.EventHandler(this.NoFallDamageToggled);
            // 
            // CraftAnything
            // 
            this.CraftAnything.AutoSize = true;
            this.CraftAnything.Location = new System.Drawing.Point(7, 27);
            this.CraftAnything.Name = "CraftAnything";
            this.CraftAnything.Size = new System.Drawing.Size(101, 15);
            this.CraftAnything.TabIndex = 78;
            this.CraftAnything.Tag = "";
            this.CraftAnything.Text = "Craft Anything";
            this.ToolTipManager.SetToolTip(this.CraftAnything, "Whether you can craft anything without needing the resources");
            this.CraftAnything.UseSelectable = true;
            this.CraftAnything.CheckedChanged += new System.EventHandler(this.CraftAnythingToggled);
            // 
            // CreativeMode
            // 
            this.CreativeMode.AutoSize = true;
            this.CreativeMode.BackColor = System.Drawing.Color.Transparent;
            this.CreativeMode.Location = new System.Drawing.Point(7, 6);
            this.CreativeMode.Name = "CreativeMode";
            this.CreativeMode.Size = new System.Drawing.Size(66, 15);
            this.CreativeMode.TabIndex = 77;
            this.CreativeMode.Tag = "";
            this.CreativeMode.Text = "Creative";
            this.ToolTipManager.SetToolTip(this.CreativeMode, "Whether to enable creative options while not being in Creative");
            this.CreativeMode.UseSelectable = true;
            this.CreativeMode.CheckedChanged += new System.EventHandler(this.CreativeModeToggled);
            // 
            // worldTab
            // 
            this.worldTab.Controls.Add(this.SunProofMobs);
            this.worldTab.Controls.Add(this.DisableCreativeFlag);
            this.worldTab.Controls.Add(this.ZombieTower);
            this.worldTab.Controls.Add(this.Entities);
            this.worldTab.Controls.Add(this.IgnitedCreepers);
            this.worldTab.Controls.Add(this.GeneratePlainWorld);
            this.worldTab.Controls.Add(this.SuperchargedCreepers);
            this.worldTab.Controls.Add(this.UncapEntitySpawnLimit);
            this.worldTab.Controls.Add(this.FreezingWorld);
            this.worldTab.Controls.Add(this.AcidLiquidBlocks);
            this.worldTab.Controls.Add(this.World);
            this.worldTab.Controls.Add(this.FoggyWeather);
            this.worldTab.Controls.Add(this.worldPnl);
            this.worldTab.Controls.Add(this.GenerateAmplifiedWorld);
            this.worldTab.Controls.Add(this.StaticLiquidBlocks);
            this.worldTab.Controls.Add(this.NoFog);
            this.worldTab.HorizontalScrollbarBarColor = true;
            this.worldTab.HorizontalScrollbarHighlightOnWheel = false;
            this.worldTab.HorizontalScrollbarSize = 10;
            this.worldTab.Location = new System.Drawing.Point(4, 5);
            this.worldTab.Name = "worldTab";
            this.worldTab.Padding = new System.Windows.Forms.Padding(3);
            this.worldTab.Size = new System.Drawing.Size(1122, 630);
            this.worldTab.TabIndex = 1;
            this.worldTab.Tag = "needsGeckoU";
            this.worldTab.Text = "Entities / World";
            this.worldTab.VerticalScrollbarBarColor = true;
            this.worldTab.VerticalScrollbarHighlightOnWheel = false;
            this.worldTab.VerticalScrollbarSize = 10;
            // 
            // SunProofMobs
            // 
            this.SunProofMobs.AutoSize = true;
            this.SunProofMobs.Location = new System.Drawing.Point(475, 109);
            this.SunProofMobs.Name = "SunProofMobs";
            this.SunProofMobs.Size = new System.Drawing.Size(108, 15);
            this.SunProofMobs.TabIndex = 21;
            this.SunProofMobs.Tag = "";
            this.SunProofMobs.Text = "Sun Proof Mobs";
            this.ToolTipManager.SetToolTip(this.SunProofMobs, "Whether mobs that burn during daylight \r\nare immune to the sun");
            this.SunProofMobs.UseSelectable = true;
            this.SunProofMobs.CheckedChanged += new System.EventHandler(this.SunProofMobsToggled);
            // 
            // DisableCreativeFlag
            // 
            this.DisableCreativeFlag.AutoSize = true;
            this.DisableCreativeFlag.BackColor = System.Drawing.Color.Transparent;
            this.DisableCreativeFlag.Location = new System.Drawing.Point(6, 130);
            this.DisableCreativeFlag.Name = "DisableCreativeFlag";
            this.DisableCreativeFlag.Size = new System.Drawing.Size(132, 15);
            this.DisableCreativeFlag.TabIndex = 21;
            this.DisableCreativeFlag.Tag = "";
            this.DisableCreativeFlag.Text = "Disable Creative Flag";
            this.ToolTipManager.SetToolTip(this.DisableCreativeFlag, "Whether to disable the \"Played in Creative\" notification");
            this.DisableCreativeFlag.UseSelectable = true;
            this.DisableCreativeFlag.CheckedChanged += new System.EventHandler(this.DisableCreativeFlagToggled);
            // 
            // ZombieTower
            // 
            this.ZombieTower.AutoSize = true;
            this.ZombieTower.Location = new System.Drawing.Point(475, 88);
            this.ZombieTower.Name = "ZombieTower";
            this.ZombieTower.Size = new System.Drawing.Size(98, 15);
            this.ZombieTower.TabIndex = 20;
            this.ZombieTower.Tag = "";
            this.ZombieTower.Text = "Zombie Tower";
            this.ToolTipManager.SetToolTip(this.ZombieTower, "Whether Zombies will sit on the nearest entity");
            this.ZombieTower.UseSelectable = true;
            this.ZombieTower.CheckedChanged += new System.EventHandler(this.ZombieTowerToggled);
            // 
            // Entities
            // 
            this.Entities.AutoSize = true;
            this.Entities.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Entities.Location = new System.Drawing.Point(475, 3);
            this.Entities.Name = "Entities";
            this.Entities.Size = new System.Drawing.Size(53, 19);
            this.Entities.TabIndex = 46;
            this.Entities.Text = "Entities";
            // 
            // IgnitedCreepers
            // 
            this.IgnitedCreepers.AutoSize = true;
            this.IgnitedCreepers.Location = new System.Drawing.Point(475, 67);
            this.IgnitedCreepers.Name = "IgnitedCreepers";
            this.IgnitedCreepers.Size = new System.Drawing.Size(109, 15);
            this.IgnitedCreepers.TabIndex = 19;
            this.IgnitedCreepers.Tag = "";
            this.IgnitedCreepers.Text = "Ignited Creepers";
            this.ToolTipManager.SetToolTip(this.IgnitedCreepers, "Whether creepers will always be ignited when spawned");
            this.IgnitedCreepers.UseSelectable = true;
            this.IgnitedCreepers.CheckedChanged += new System.EventHandler(this.IgnitedCreepersToggled);
            // 
            // GeneratePlainWorld
            // 
            this.GeneratePlainWorld.AutoSize = true;
            this.GeneratePlainWorld.BackColor = System.Drawing.Color.Transparent;
            this.GeneratePlainWorld.Location = new System.Drawing.Point(6, 109);
            this.GeneratePlainWorld.Name = "GeneratePlainWorld";
            this.GeneratePlainWorld.Size = new System.Drawing.Size(134, 15);
            this.GeneratePlainWorld.TabIndex = 20;
            this.GeneratePlainWorld.Tag = "";
            this.GeneratePlainWorld.Text = "Generate Plain World";
            this.ToolTipManager.SetToolTip(this.GeneratePlainWorld, "Whether worlds will generate with no trees or foliage");
            this.GeneratePlainWorld.UseSelectable = true;
            this.GeneratePlainWorld.CheckedChanged += new System.EventHandler(this.GeneratePlainWorldToggled);
            // 
            // SuperchargedCreepers
            // 
            this.SuperchargedCreepers.AutoSize = true;
            this.SuperchargedCreepers.Location = new System.Drawing.Point(475, 46);
            this.SuperchargedCreepers.Name = "SuperchargedCreepers";
            this.SuperchargedCreepers.Size = new System.Drawing.Size(145, 15);
            this.SuperchargedCreepers.TabIndex = 18;
            this.SuperchargedCreepers.Tag = "";
            this.SuperchargedCreepers.Text = "Supercharged Creepers";
            this.ToolTipManager.SetToolTip(this.SuperchargedCreepers, "Whether creepers will always be supercharged");
            this.SuperchargedCreepers.UseSelectable = true;
            this.SuperchargedCreepers.CheckedChanged += new System.EventHandler(this.SuperchargedCreepersToggled);
            // 
            // UncapEntitySpawnLimit
            // 
            this.UncapEntitySpawnLimit.AutoSize = true;
            this.UncapEntitySpawnLimit.Location = new System.Drawing.Point(475, 25);
            this.UncapEntitySpawnLimit.Name = "UncapEntitySpawnLimit";
            this.UncapEntitySpawnLimit.Size = new System.Drawing.Size(158, 15);
            this.UncapEntitySpawnLimit.TabIndex = 17;
            this.UncapEntitySpawnLimit.Tag = "";
            this.UncapEntitySpawnLimit.Text = "Uncap Entity Spawn Limit";
            this.ToolTipManager.SetToolTip(this.UncapEntitySpawnLimit, "Whether to uncap the entity spawn limit");
            this.UncapEntitySpawnLimit.UseSelectable = true;
            this.UncapEntitySpawnLimit.CheckedChanged += new System.EventHandler(this.UncapEntitySpawnLimitToggled);
            // 
            // FreezingWorld
            // 
            this.FreezingWorld.AutoSize = true;
            this.FreezingWorld.BackColor = System.Drawing.Color.Transparent;
            this.FreezingWorld.Location = new System.Drawing.Point(7, 25);
            this.FreezingWorld.Name = "FreezingWorld";
            this.FreezingWorld.Size = new System.Drawing.Size(102, 15);
            this.FreezingWorld.TabIndex = 19;
            this.FreezingWorld.Tag = "";
            this.FreezingWorld.Text = "Freezing World";
            this.ToolTipManager.SetToolTip(this.FreezingWorld, "Whether the world should freeze or not");
            this.FreezingWorld.UseSelectable = true;
            this.FreezingWorld.CheckedChanged += new System.EventHandler(this.FreezingWorldToggled);
            // 
            // AcidLiquidBlocks
            // 
            this.AcidLiquidBlocks.AutoSize = true;
            this.AcidLiquidBlocks.BackColor = System.Drawing.Color.Transparent;
            this.AcidLiquidBlocks.Location = new System.Drawing.Point(6, 151);
            this.AcidLiquidBlocks.Name = "AcidLiquidBlocks";
            this.AcidLiquidBlocks.Size = new System.Drawing.Size(120, 15);
            this.AcidLiquidBlocks.TabIndex = 22;
            this.AcidLiquidBlocks.Tag = "";
            this.AcidLiquidBlocks.Text = "Acid Liquid Blocks";
            this.ToolTipManager.SetToolTip(this.AcidLiquidBlocks, "Whether Liquid Blocks will destroy surrounding blocks");
            this.AcidLiquidBlocks.UseSelectable = true;
            this.AcidLiquidBlocks.CheckedChanged += new System.EventHandler(this.AcidLiquidBlocksToggled);
            // 
            // World
            // 
            this.World.AutoSize = true;
            this.World.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.World.Location = new System.Drawing.Point(3, 3);
            this.World.Name = "World";
            this.World.Size = new System.Drawing.Size(45, 19);
            this.World.TabIndex = 44;
            this.World.Text = "World";
            // 
            // FoggyWeather
            // 
            this.FoggyWeather.AutoSize = true;
            this.FoggyWeather.Location = new System.Drawing.Point(7, 46);
            this.FoggyWeather.Name = "FoggyWeather";
            this.FoggyWeather.Size = new System.Drawing.Size(103, 15);
            this.FoggyWeather.TabIndex = 24;
            this.FoggyWeather.Tag = "";
            this.FoggyWeather.Text = "Foggy Weather";
            this.ToolTipManager.SetToolTip(this.FoggyWeather, "Whether to have a foggy view");
            this.FoggyWeather.UseSelectable = true;
            this.FoggyWeather.CheckedChanged += new System.EventHandler(this.FoggyWeatherToggled);
            // 
            // worldPnl
            // 
            this.worldPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.worldPnl.HorizontalScrollbarBarColor = true;
            this.worldPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.worldPnl.HorizontalScrollbarSize = 10;
            this.worldPnl.Location = new System.Drawing.Point(0, 15);
            this.worldPnl.Name = "worldPnl";
            this.worldPnl.Size = new System.Drawing.Size(1116, 1);
            this.worldPnl.TabIndex = 43;
            this.worldPnl.VerticalScrollbarBarColor = true;
            this.worldPnl.VerticalScrollbarHighlightOnWheel = false;
            this.worldPnl.VerticalScrollbarSize = 10;
            // 
            // GenerateAmplifiedWorld
            // 
            this.GenerateAmplifiedWorld.AutoSize = true;
            this.GenerateAmplifiedWorld.BackColor = System.Drawing.Color.Transparent;
            this.GenerateAmplifiedWorld.Location = new System.Drawing.Point(6, 88);
            this.GenerateAmplifiedWorld.Name = "GenerateAmplifiedWorld";
            this.GenerateAmplifiedWorld.Size = new System.Drawing.Size(160, 15);
            this.GenerateAmplifiedWorld.TabIndex = 23;
            this.GenerateAmplifiedWorld.Tag = "";
            this.GenerateAmplifiedWorld.Text = "Generate Amplified World";
            this.ToolTipManager.SetToolTip(this.GenerateAmplifiedWorld, "Whether the world generation will be amplified");
            this.GenerateAmplifiedWorld.UseSelectable = true;
            this.GenerateAmplifiedWorld.CheckedChanged += new System.EventHandler(this.GenerateAmplifiedWorldToggled);
            // 
            // StaticLiquidBlocks
            // 
            this.StaticLiquidBlocks.AutoSize = true;
            this.StaticLiquidBlocks.BackColor = System.Drawing.Color.Transparent;
            this.StaticLiquidBlocks.Location = new System.Drawing.Point(6, 172);
            this.StaticLiquidBlocks.Name = "StaticLiquidBlocks";
            this.StaticLiquidBlocks.Size = new System.Drawing.Size(125, 15);
            this.StaticLiquidBlocks.TabIndex = 25;
            this.StaticLiquidBlocks.Tag = "";
            this.StaticLiquidBlocks.Text = "Static Liquid Blocks";
            this.ToolTipManager.SetToolTip(this.StaticLiquidBlocks, "Whether Liquid Blocks will not spread");
            this.StaticLiquidBlocks.UseSelectable = true;
            this.StaticLiquidBlocks.CheckedChanged += new System.EventHandler(this.StaticLiquidBlocksToggled);
            // 
            // NoFog
            // 
            this.NoFog.AutoSize = true;
            this.NoFog.BackColor = System.Drawing.Color.Transparent;
            this.NoFog.Location = new System.Drawing.Point(7, 67);
            this.NoFog.Name = "NoFog";
            this.NoFog.Size = new System.Drawing.Size(62, 15);
            this.NoFog.TabIndex = 26;
            this.NoFog.Tag = "";
            this.NoFog.Text = "No Fog";
            this.ToolTipManager.SetToolTip(this.NoFog, "Whether to remove the fog in-game");
            this.NoFog.UseSelectable = true;
            this.NoFog.CheckedChanged += new System.EventHandler(this.NoFogToggled);
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.DebugConsole);
            this.generalTab.Controls.Add(this.metroLabel1);
            this.generalTab.Controls.Add(this.metroLabel2);
            this.generalTab.Controls.Add(this.metroPanel1);
            this.generalTab.Controls.Add(this.vpadDisplaySwitch);
            this.generalTab.Controls.Add(this.UIColorPickerBtn);
            this.generalTab.Controls.Add(this.DisableTeleporting);
            this.generalTab.Controls.Add(this.GamepadSplitscreen);
            this.generalTab.Controls.Add(this.disableVPadInput);
            this.generalTab.Controls.Add(this.BypassFriendsOnly);
            this.generalTab.Controls.Add(this.DisablePermanentKicks);
            this.generalTab.Controls.Add(this.MapTextEditor);
            this.generalTab.Controls.Add(this.HostOptions);
            this.generalTab.Controls.Add(this.SlowMotion);
            this.generalTab.Controls.Add(this.AllDLCUnlocked);
            this.generalTab.Controls.Add(this.ExitGame);
            this.generalTab.HorizontalScrollbarBarColor = true;
            this.generalTab.HorizontalScrollbarHighlightOnWheel = false;
            this.generalTab.HorizontalScrollbarSize = 10;
            this.generalTab.Location = new System.Drawing.Point(4, 5);
            this.generalTab.Name = "generalTab";
            this.generalTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalTab.Size = new System.Drawing.Size(1122, 630);
            this.generalTab.TabIndex = 2;
            this.generalTab.Tag = "needsGeckoU";
            this.generalTab.Text = "General Game";
            this.generalTab.VerticalScrollbarBarColor = true;
            this.generalTab.VerticalScrollbarHighlightOnWheel = false;
            this.generalTab.VerticalScrollbarSize = 10;
            // 
            // DebugConsole
            // 
            this.DebugConsole.AutoSize = true;
            this.DebugConsole.BackColor = System.Drawing.Color.Transparent;
            this.DebugConsole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DebugConsole.Location = new System.Drawing.Point(7, 46);
            this.DebugConsole.Name = "DebugConsole";
            this.DebugConsole.Size = new System.Drawing.Size(104, 15);
            this.DebugConsole.TabIndex = 143;
            this.DebugConsole.Tag = "";
            this.DebugConsole.Text = "Debug Console";
            this.ToolTipManager.SetToolTip(this.DebugConsole, "Whether to show the Debug Console");
            this.DebugConsole.UseSelectable = true;
            this.DebugConsole.CheckedChanged += new System.EventHandler(this.DebugConsoleToggled);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(475, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 142;
            this.metroLabel1.Text = "Game";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(3, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(120, 19);
            this.metroLabel2.TabIndex = 141;
            this.metroLabel2.Text = "UI (User Interface)";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 15);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1116, 1);
            this.metroPanel1.TabIndex = 140;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // vpadDisplaySwitch
            // 
            this.vpadDisplaySwitch.AutoSize = true;
            this.vpadDisplaySwitch.Location = new System.Drawing.Point(475, 172);
            this.vpadDisplaySwitch.Name = "vpadDisplaySwitch";
            this.vpadDisplaySwitch.Size = new System.Drawing.Size(183, 15);
            this.vpadDisplaySwitch.TabIndex = 3;
            this.vpadDisplaySwitch.Text = "Power Button turns off display";
            this.ToolTipManager.SetToolTip(this.vpadDisplaySwitch, "Holding down the power button on the gamepad will turn off the screen, not consol" +
        "e");
            this.vpadDisplaySwitch.UseSelectable = true;
            this.vpadDisplaySwitch.CheckedChanged += new System.EventHandler(this.VpadDisplaySwitchToggled);
            // 
            // UIColorPickerBtn
            // 
            this.UIColorPickerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UIColorPickerBtn.Location = new System.Drawing.Point(8, 596);
            this.UIColorPickerBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UIColorPickerBtn.Name = "UIColorPickerBtn";
            this.UIColorPickerBtn.Size = new System.Drawing.Size(1107, 25);
            this.UIColorPickerBtn.TabIndex = 32;
            this.UIColorPickerBtn.Tag = "";
            this.UIColorPickerBtn.Text = "UI Color Picker";
            this.ToolTipManager.SetToolTip(this.UIColorPickerBtn, "Here you can change the game\'s UI colors \r\nto match your preferences");
            this.UIColorPickerBtn.UseSelectable = true;
            this.UIColorPickerBtn.Click += new System.EventHandler(this.UiColorPickerBtnClicked);
            // 
            // DisableTeleporting
            // 
            this.DisableTeleporting.AutoSize = true;
            this.DisableTeleporting.BackColor = System.Drawing.Color.Transparent;
            this.DisableTeleporting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DisableTeleporting.Location = new System.Drawing.Point(475, 130);
            this.DisableTeleporting.Name = "DisableTeleporting";
            this.DisableTeleporting.Size = new System.Drawing.Size(123, 15);
            this.DisableTeleporting.TabIndex = 31;
            this.DisableTeleporting.Tag = "";
            this.DisableTeleporting.Text = "Disable Teleporting";
            this.ToolTipManager.SetToolTip(this.DisableTeleporting, "Whether to disable the teleport command (untested online)");
            this.DisableTeleporting.UseSelectable = true;
            this.DisableTeleporting.CheckedChanged += new System.EventHandler(this.DisableTeleportingToggled);
            // 
            // GamepadSplitscreen
            // 
            this.GamepadSplitscreen.AutoSize = true;
            this.GamepadSplitscreen.BackColor = System.Drawing.Color.Transparent;
            this.GamepadSplitscreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GamepadSplitscreen.Location = new System.Drawing.Point(7, 25);
            this.GamepadSplitscreen.Name = "GamepadSplitscreen";
            this.GamepadSplitscreen.Size = new System.Drawing.Size(134, 15);
            this.GamepadSplitscreen.TabIndex = 30;
            this.GamepadSplitscreen.Tag = "";
            this.GamepadSplitscreen.Text = "Gamepad Splitscreen";
            this.ToolTipManager.SetToolTip(this.GamepadSplitscreen, "Whether you can use splitscreen mode on the Gamepad");
            this.GamepadSplitscreen.UseSelectable = true;
            this.GamepadSplitscreen.CheckedChanged += new System.EventHandler(this.GamepadSplitscreenToggled);
            // 
            // disableVPadInput
            // 
            this.disableVPadInput.AutoSize = true;
            this.disableVPadInput.Location = new System.Drawing.Point(475, 151);
            this.disableVPadInput.Name = "disableVPadInput";
            this.disableVPadInput.Size = new System.Drawing.Size(146, 15);
            this.disableVPadInput.TabIndex = 2;
            this.disableVPadInput.Text = "Disable Gamepad Input";
            this.ToolTipManager.SetToolTip(this.disableVPadInput, "Disables all input from the Gamepad including the touch screen but excluding the " +
        "home button");
            this.disableVPadInput.UseSelectable = true;
            this.disableVPadInput.CheckedChanged += new System.EventHandler(this.DisableVPadInputToggled);
            // 
            // BypassFriendsOnly
            // 
            this.BypassFriendsOnly.AutoSize = true;
            this.BypassFriendsOnly.BackColor = System.Drawing.Color.Transparent;
            this.BypassFriendsOnly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BypassFriendsOnly.Location = new System.Drawing.Point(475, 67);
            this.BypassFriendsOnly.Name = "BypassFriendsOnly";
            this.BypassFriendsOnly.Size = new System.Drawing.Size(128, 15);
            this.BypassFriendsOnly.TabIndex = 29;
            this.BypassFriendsOnly.Tag = "";
            this.BypassFriendsOnly.Text = "Bypass Friends Only";
            this.ToolTipManager.SetToolTip(this.BypassFriendsOnly, "Whether to bypass the \"Friends Only\" privacy setting");
            this.BypassFriendsOnly.UseSelectable = true;
            this.BypassFriendsOnly.CheckedChanged += new System.EventHandler(this.BypassFriendsOnlyToggled);
            // 
            // DisablePermanentKicks
            // 
            this.DisablePermanentKicks.AutoSize = true;
            this.DisablePermanentKicks.BackColor = System.Drawing.Color.Transparent;
            this.DisablePermanentKicks.Location = new System.Drawing.Point(475, 46);
            this.DisablePermanentKicks.Name = "DisablePermanentKicks";
            this.DisablePermanentKicks.Size = new System.Drawing.Size(152, 15);
            this.DisablePermanentKicks.TabIndex = 25;
            this.DisablePermanentKicks.Tag = "";
            this.DisablePermanentKicks.Text = "Disable Permanent Kicks";
            this.ToolTipManager.SetToolTip(this.DisablePermanentKicks, "Whether to disable the \"You have been previously kicked by the host\" message and " +
        "join anyway");
            this.DisablePermanentKicks.UseSelectable = true;
            this.DisablePermanentKicks.CheckedChanged += new System.EventHandler(this.DisablePermanentKicksToggled);
            // 
            // MapTextEditor
            // 
            this.MapTextEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MapTextEditor.Location = new System.Drawing.Point(8, 559);
            this.MapTextEditor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MapTextEditor.Name = "MapTextEditor";
            this.MapTextEditor.Size = new System.Drawing.Size(1107, 25);
            this.MapTextEditor.TabIndex = 20;
            this.MapTextEditor.Tag = "";
            this.MapTextEditor.Text = "Map Text Editor";
            this.MapTextEditor.UseSelectable = true;
            this.MapTextEditor.Click += new System.EventHandler(this.MapTextEditorClicked);
            // 
            // HostOptions
            // 
            this.HostOptions.AutoSize = true;
            this.HostOptions.Location = new System.Drawing.Point(475, 25);
            this.HostOptions.Name = "HostOptions";
            this.HostOptions.Size = new System.Drawing.Size(93, 15);
            this.HostOptions.TabIndex = 28;
            this.HostOptions.Tag = "";
            this.HostOptions.Text = "Host Options";
            this.ToolTipManager.SetToolTip(this.HostOptions, "Whether to enable host options in host only minigames (Crashes other people when " +
        "the game starts)");
            this.HostOptions.UseSelectable = true;
            this.HostOptions.CheckedChanged += new System.EventHandler(this.HostOptionsToggled);
            // 
            // SlowMotion
            // 
            this.SlowMotion.AutoSize = true;
            this.SlowMotion.Location = new System.Drawing.Point(475, 109);
            this.SlowMotion.Name = "SlowMotion";
            this.SlowMotion.Size = new System.Drawing.Size(90, 15);
            this.SlowMotion.TabIndex = 139;
            this.SlowMotion.Tag = "";
            this.SlowMotion.Text = "Slow Motion";
            this.ToolTipManager.SetToolTip(this.SlowMotion, "Whether the game will be slowed down");
            this.SlowMotion.UseSelectable = true;
            this.SlowMotion.CheckedChanged += new System.EventHandler(this.SlowMotionToggled);
            // 
            // AllDLCUnlocked
            // 
            this.AllDLCUnlocked.AutoSize = true;
            this.AllDLCUnlocked.Location = new System.Drawing.Point(475, 88);
            this.AllDLCUnlocked.Name = "AllDLCUnlocked";
            this.AllDLCUnlocked.Size = new System.Drawing.Size(115, 15);
            this.AllDLCUnlocked.TabIndex = 16;
            this.AllDLCUnlocked.Tag = "";
            this.AllDLCUnlocked.Text = "All DLC Unlocked";
            this.ToolTipManager.SetToolTip(this.AllDLCUnlocked, "Whether to have all DLC unlocked without needing to pay");
            this.AllDLCUnlocked.UseSelectable = true;
            this.AllDLCUnlocked.CheckedChanged += new System.EventHandler(this.AllDlcUnlockedToggled);
            // 
            // ExitGame
            // 
            this.ExitGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitGame.Location = new System.Drawing.Point(8, 522);
            this.ExitGame.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(1107, 25);
            this.ExitGame.TabIndex = 15;
            this.ExitGame.Tag = "";
            this.ExitGame.Text = "Exit Game";
            this.ExitGame.UseSelectable = true;
            this.ExitGame.Click += new System.EventHandler(this.ExitGameClicked);
            // 
            // minigamesTab
            // 
            this.minigamesTab.Controls.Add(this.MinigamesTabs);
            this.minigamesTab.HorizontalScrollbarBarColor = true;
            this.minigamesTab.HorizontalScrollbarHighlightOnWheel = false;
            this.minigamesTab.HorizontalScrollbarSize = 10;
            this.minigamesTab.Location = new System.Drawing.Point(4, 5);
            this.minigamesTab.Name = "minigamesTab";
            this.minigamesTab.Padding = new System.Windows.Forms.Padding(3);
            this.minigamesTab.Size = new System.Drawing.Size(1122, 630);
            this.minigamesTab.TabIndex = 3;
            this.minigamesTab.Tag = "GeckoUNeeded";
            this.minigamesTab.Text = "Minigames";
            this.minigamesTab.VerticalScrollbarBarColor = true;
            this.minigamesTab.VerticalScrollbarHighlightOnWheel = false;
            this.minigamesTab.VerticalScrollbarSize = 10;
            // 
            // MinigamesTabs
            // 
            this.MinigamesTabs.Controls.Add(this.GeneralMinigames);
            this.MinigamesTabs.Controls.Add(this.Battle);
            this.MinigamesTabs.Controls.Add(this.Tumble);
            this.MinigamesTabs.Controls.Add(this.Glide);
            this.MinigamesTabs.ItemSize = new System.Drawing.Size(280, 25);
            this.MinigamesTabs.Location = new System.Drawing.Point(-3, 2);
            this.MinigamesTabs.Name = "MinigamesTabs";
            this.MinigamesTabs.SelectedIndex = 0;
            this.MinigamesTabs.Size = new System.Drawing.Size(1129, 633);
            this.MinigamesTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MinigamesTabs.TabIndex = 2;
            this.MinigamesTabs.Tag = "needsGeckoU";
            this.MinigamesTabs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinigamesTabs.UseSelectable = true;
            // 
            // GeneralMinigames
            // 
            this.GeneralMinigames.BackColor = System.Drawing.Color.White;
            this.GeneralMinigames.Controls.Add(this.SqueakInfinitely);
            this.GeneralMinigames.Controls.Add(this.RequiredPlayersSlider);
            this.GeneralMinigames.Controls.Add(this.RequiredPlayers);
            this.GeneralMinigames.Controls.Add(this.AllPermissions);
            this.GeneralMinigames.Controls.Add(this.AlwaysDamaged);
            this.GeneralMinigames.Controls.Add(this.TNTGriefing);
            this.GeneralMinigames.Controls.Add(this.DisabledKillBarriers);
            this.GeneralMinigames.HorizontalScrollbarBarColor = true;
            this.GeneralMinigames.HorizontalScrollbarHighlightOnWheel = false;
            this.GeneralMinigames.HorizontalScrollbarSize = 10;
            this.GeneralMinigames.Location = new System.Drawing.Point(4, 29);
            this.GeneralMinigames.Name = "GeneralMinigames";
            this.GeneralMinigames.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralMinigames.Size = new System.Drawing.Size(1121, 600);
            this.GeneralMinigames.TabIndex = 0;
            this.GeneralMinigames.Text = "General";
            this.GeneralMinigames.VerticalScrollbarBarColor = true;
            this.GeneralMinigames.VerticalScrollbarHighlightOnWheel = false;
            this.GeneralMinigames.VerticalScrollbarSize = 10;
            // 
            // SqueakInfinitely
            // 
            this.SqueakInfinitely.AutoSize = true;
            this.SqueakInfinitely.Location = new System.Drawing.Point(7, 90);
            this.SqueakInfinitely.Name = "SqueakInfinitely";
            this.SqueakInfinitely.Size = new System.Drawing.Size(110, 15);
            this.SqueakInfinitely.TabIndex = 24;
            this.SqueakInfinitely.Tag = "";
            this.SqueakInfinitely.Text = "Squeak Infinitely";
            this.ToolTipManager.SetToolTip(this.SqueakInfinitely, "Whether you will be able to squeak infinitely as a bat");
            this.SqueakInfinitely.UseSelectable = true;
            this.SqueakInfinitely.CheckedChanged += new System.EventHandler(this.SqueakInfinitelyToggled);
            // 
            // RequiredPlayersSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.RequiredPlayersSlider, true);
            this.RequiredPlayersSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RequiredPlayersSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RequiredPlayersSlider.Location = new System.Drawing.Point(124, 574);
            this.RequiredPlayersSlider.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.RequiredPlayersSlider.Name = "RequiredPlayersSlider";
            this.RequiredPlayersSlider.Size = new System.Drawing.Size(991, 20);
            this.RequiredPlayersSlider.TabIndex = 23;
            this.ToolTipManager.SetToolTip(this.RequiredPlayersSlider, "How many players do we need to start a match?");
            this.RequiredPlayersSlider.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RequiredPlayersSlider.ValueChanged += new System.EventHandler(this.RequiredPlayersSliderChanged);
            // 
            // RequiredPlayers
            // 
            this.RequiredPlayers.AutoSize = true;
            this.RequiredPlayers.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.RequiredPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RequiredPlayers.Location = new System.Drawing.Point(5, 574);
            this.RequiredPlayers.Name = "RequiredPlayers";
            this.RequiredPlayers.Size = new System.Drawing.Size(113, 19);
            this.RequiredPlayers.TabIndex = 22;
            this.RequiredPlayers.Tag = "";
            this.RequiredPlayers.Text = "Required Players:";
            // 
            // AllPermissions
            // 
            this.AllPermissions.AutoSize = true;
            this.AllPermissions.Location = new System.Drawing.Point(7, 6);
            this.AllPermissions.Name = "AllPermissions";
            this.AllPermissions.Size = new System.Drawing.Size(98, 15);
            this.AllPermissions.TabIndex = 2;
            this.AllPermissions.Tag = "";
            this.AllPermissions.Text = "All Permisions";
            this.ToolTipManager.SetToolTip(this.AllPermissions, "Whether you\'ll be granted all permissions (placing, breaking, using)");
            this.AllPermissions.UseSelectable = true;
            this.AllPermissions.CheckedChanged += new System.EventHandler(this.AllPermissionsToggled);
            // 
            // AlwaysDamaged
            // 
            this.AlwaysDamaged.AutoSize = true;
            this.AlwaysDamaged.Location = new System.Drawing.Point(7, 48);
            this.AlwaysDamaged.Name = "AlwaysDamaged";
            this.AlwaysDamaged.Size = new System.Drawing.Size(114, 15);
            this.AlwaysDamaged.TabIndex = 4;
            this.AlwaysDamaged.Tag = "";
            this.AlwaysDamaged.Text = "Always Damaged";
            this.ToolTipManager.SetToolTip(this.AlwaysDamaged, "Whether you will repeatedly be damaged");
            this.AlwaysDamaged.UseSelectable = true;
            this.AlwaysDamaged.CheckedChanged += new System.EventHandler(this.AlwaysDamagedToggled);
            // 
            // TNTGriefing
            // 
            this.TNTGriefing.AutoSize = true;
            this.TNTGriefing.Location = new System.Drawing.Point(7, 27);
            this.TNTGriefing.Name = "TNTGriefing";
            this.TNTGriefing.Size = new System.Drawing.Size(89, 15);
            this.TNTGriefing.TabIndex = 7;
            this.TNTGriefing.Tag = "";
            this.TNTGriefing.Text = "TNT Griefing";
            this.ToolTipManager.SetToolTip(this.TNTGriefing, "Whether TNT is able to destroy blocks or not");
            this.TNTGriefing.UseSelectable = true;
            this.TNTGriefing.CheckedChanged += new System.EventHandler(this.TntGriefingToggled);
            // 
            // DisabledKillBarriers
            // 
            this.DisabledKillBarriers.AutoSize = true;
            this.DisabledKillBarriers.Location = new System.Drawing.Point(7, 69);
            this.DisabledKillBarriers.Name = "DisabledKillBarriers";
            this.DisabledKillBarriers.Size = new System.Drawing.Size(129, 15);
            this.DisabledKillBarriers.TabIndex = 8;
            this.DisabledKillBarriers.Tag = "";
            this.DisabledKillBarriers.Text = "Disabled Kill Barriers";
            this.ToolTipManager.SetToolTip(this.DisabledKillBarriers, "Whether Kill Barriers will be disabled");
            this.DisabledKillBarriers.UseSelectable = true;
            this.DisabledKillBarriers.CheckedChanged += new System.EventHandler(this.DisabledKillBarriersToggled);
            // 
            // Battle
            // 
            this.Battle.BackColor = System.Drawing.Color.White;
            this.Battle.Controls.Add(this.EndGame);
            this.Battle.Controls.Add(this.RefillInterval);
            this.Battle.Controls.Add(this.RefillIntervalSlider);
            this.Battle.Controls.Add(this.AntiEndGame);
            this.Battle.HorizontalScrollbarBarColor = true;
            this.Battle.HorizontalScrollbarHighlightOnWheel = false;
            this.Battle.HorizontalScrollbarSize = 10;
            this.Battle.Location = new System.Drawing.Point(4, 29);
            this.Battle.Name = "Battle";
            this.Battle.Padding = new System.Windows.Forms.Padding(3);
            this.Battle.Size = new System.Drawing.Size(1121, 600);
            this.Battle.TabIndex = 1;
            this.Battle.Text = "Battle";
            this.Battle.VerticalScrollbarBarColor = true;
            this.Battle.VerticalScrollbarHighlightOnWheel = false;
            this.Battle.VerticalScrollbarSize = 10;
            // 
            // EndGame
            // 
            this.EndGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EndGame.BackColor = System.Drawing.SystemColors.Control;
            this.EndGame.Location = new System.Drawing.Point(7, 538);
            this.EndGame.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(1107, 27);
            this.EndGame.TabIndex = 9;
            this.EndGame.Tag = "";
            this.EndGame.Text = "End Game";
            this.ToolTipManager.SetToolTip(this.EndGame, "Ends the current Battle Match");
            this.EndGame.UseSelectable = true;
            this.EndGame.Click += new System.EventHandler(this.EndGameClicked);
            // 
            // RefillInterval
            // 
            this.RefillInterval.AutoSize = true;
            this.RefillInterval.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.RefillInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RefillInterval.Location = new System.Drawing.Point(5, 574);
            this.RefillInterval.Name = "RefillInterval";
            this.RefillInterval.Size = new System.Drawing.Size(129, 19);
            this.RefillInterval.TabIndex = 28;
            this.RefillInterval.Tag = "";
            this.RefillInterval.Text = "Chest Refill Interval:";
            // 
            // RefillIntervalSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.RefillIntervalSlider, true);
            this.RefillIntervalSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RefillIntervalSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RefillIntervalSlider.Location = new System.Drawing.Point(140, 574);
            this.RefillIntervalSlider.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.RefillIntervalSlider.Name = "RefillIntervalSlider";
            this.RefillIntervalSlider.Size = new System.Drawing.Size(975, 20);
            this.RefillIntervalSlider.TabIndex = 29;
            this.ToolTipManager.SetToolTip(this.RefillIntervalSlider, "How long should chests take to refill? (in seconds)");
            this.RefillIntervalSlider.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.RefillIntervalSlider.ValueChanged += new System.EventHandler(this.RefillIntervalSliderChanged);
            // 
            // AntiEndGame
            // 
            this.AntiEndGame.AutoSize = true;
            this.AntiEndGame.Location = new System.Drawing.Point(7, 6);
            this.AntiEndGame.Name = "AntiEndGame";
            this.AntiEndGame.Size = new System.Drawing.Size(102, 15);
            this.AntiEndGame.TabIndex = 5;
            this.AntiEndGame.Tag = "";
            this.AntiEndGame.Text = "Anti End Game";
            this.ToolTipManager.SetToolTip(this.AntiEndGame, "Whether the game will end");
            this.AntiEndGame.UseSelectable = true;
            this.AntiEndGame.CheckedChanged += new System.EventHandler(this.AntiEndGameToggled);
            // 
            // Tumble
            // 
            this.Tumble.BackColor = System.Drawing.Color.White;
            this.Tumble.Controls.Add(this.TumbleHUD);
            this.Tumble.HorizontalScrollbarBarColor = true;
            this.Tumble.HorizontalScrollbarHighlightOnWheel = false;
            this.Tumble.HorizontalScrollbarSize = 10;
            this.Tumble.Location = new System.Drawing.Point(4, 29);
            this.Tumble.Name = "Tumble";
            this.Tumble.Padding = new System.Windows.Forms.Padding(3);
            this.Tumble.Size = new System.Drawing.Size(1121, 600);
            this.Tumble.TabIndex = 2;
            this.Tumble.Text = "Tumble";
            this.Tumble.VerticalScrollbarBarColor = true;
            this.Tumble.VerticalScrollbarHighlightOnWheel = false;
            this.Tumble.VerticalScrollbarSize = 10;
            // 
            // TumbleHUD
            // 
            this.TumbleHUD.AutoSize = true;
            this.TumbleHUD.Location = new System.Drawing.Point(7, 6);
            this.TumbleHUD.Name = "TumbleHUD";
            this.TumbleHUD.Size = new System.Drawing.Size(91, 15);
            this.TumbleHUD.TabIndex = 3;
            this.TumbleHUD.Tag = "";
            this.TumbleHUD.Text = "Tumble HUD";
            this.ToolTipManager.SetToolTip(this.TumbleHUD, "Whether to disable the HUD in Tumble");
            this.TumbleHUD.UseSelectable = true;
            this.TumbleHUD.CheckedChanged += new System.EventHandler(this.TumbleHudToggled);
            // 
            // Glide
            // 
            this.Glide.BackColor = System.Drawing.Color.White;
            this.Glide.Controls.Add(this.ringScoreB);
            this.Glide.Controls.Add(this.ringScoreBlue);
            this.Glide.Controls.Add(this.ringScoreO);
            this.Glide.Controls.Add(this.ringScoreOrange);
            this.Glide.Controls.Add(this.ringScoreG);
            this.Glide.Controls.Add(this.ringScoreGreen);
            this.Glide.HorizontalScrollbarBarColor = true;
            this.Glide.HorizontalScrollbarHighlightOnWheel = false;
            this.Glide.HorizontalScrollbarSize = 10;
            this.Glide.Location = new System.Drawing.Point(4, 29);
            this.Glide.Name = "Glide";
            this.Glide.Padding = new System.Windows.Forms.Padding(3);
            this.Glide.Size = new System.Drawing.Size(1121, 600);
            this.Glide.TabIndex = 3;
            this.Glide.Text = "Glide";
            this.Glide.VerticalScrollbarBarColor = true;
            this.Glide.VerticalScrollbarHighlightOnWheel = false;
            this.Glide.VerticalScrollbarSize = 10;
            // 
            // ringScoreB
            // 
            this.ringScoreB.AutoSize = true;
            this.ringScoreB.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ringScoreB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ringScoreB.Location = new System.Drawing.Point(7, 55);
            this.ringScoreB.Name = "ringScoreB";
            this.ringScoreB.Size = new System.Drawing.Size(114, 19);
            this.ringScoreB.TabIndex = 35;
            this.ringScoreB.Tag = "";
            this.ringScoreB.Text = "Ring Score (Blue):";
            // 
            // ringScoreBlue
            // 
            this.StyleExtender.SetApplyMetroTheme(this.ringScoreBlue, true);
            this.ringScoreBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ringScoreBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ringScoreBlue.Location = new System.Drawing.Point(145, 55);
            this.ringScoreBlue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ringScoreBlue.Name = "ringScoreBlue";
            this.ringScoreBlue.Size = new System.Drawing.Size(970, 20);
            this.ringScoreBlue.TabIndex = 36;
            this.ringScoreBlue.Tag = "";
            this.ToolTipManager.SetToolTip(this.ringScoreBlue, "How many score does this type of ring give?");
            // 
            // ringScoreO
            // 
            this.ringScoreO.AutoSize = true;
            this.ringScoreO.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ringScoreO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ringScoreO.Location = new System.Drawing.Point(7, 29);
            this.ringScoreO.Name = "ringScoreO";
            this.ringScoreO.Size = new System.Drawing.Size(134, 19);
            this.ringScoreO.TabIndex = 33;
            this.ringScoreO.Tag = "";
            this.ringScoreO.Text = "Ring Score (Orange):";
            // 
            // ringScoreOrange
            // 
            this.StyleExtender.SetApplyMetroTheme(this.ringScoreOrange, true);
            this.ringScoreOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ringScoreOrange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ringScoreOrange.Location = new System.Drawing.Point(145, 29);
            this.ringScoreOrange.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ringScoreOrange.Name = "ringScoreOrange";
            this.ringScoreOrange.Size = new System.Drawing.Size(970, 20);
            this.ringScoreOrange.TabIndex = 34;
            this.ringScoreOrange.Tag = "";
            this.ToolTipManager.SetToolTip(this.ringScoreOrange, "How many score does this type of ring give?");
            this.ringScoreOrange.ValueChanged += new System.EventHandler(this.GlideRingScoreSliderChanged);
            // 
            // ringScoreG
            // 
            this.ringScoreG.AutoSize = true;
            this.ringScoreG.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ringScoreG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ringScoreG.Location = new System.Drawing.Point(7, 3);
            this.ringScoreG.Name = "ringScoreG";
            this.ringScoreG.Size = new System.Drawing.Size(125, 19);
            this.ringScoreG.TabIndex = 31;
            this.ringScoreG.Tag = "";
            this.ringScoreG.Text = "Ring Score (Green):";
            // 
            // ringScoreGreen
            // 
            this.StyleExtender.SetApplyMetroTheme(this.ringScoreGreen, true);
            this.ringScoreGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ringScoreGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ringScoreGreen.Location = new System.Drawing.Point(145, 3);
            this.ringScoreGreen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ringScoreGreen.Name = "ringScoreGreen";
            this.ringScoreGreen.Size = new System.Drawing.Size(970, 20);
            this.ringScoreGreen.TabIndex = 32;
            this.ringScoreGreen.Tag = "";
            this.ToolTipManager.SetToolTip(this.ringScoreGreen, "How many score does this type of ring give?");
            this.ringScoreGreen.ValueChanged += new System.EventHandler(this.GlideRingScoreSliderChanged);
            // 
            // commandsTab
            // 
            this.commandsTab.Controls.Add(this.gamemodeCmdLbl);
            this.commandsTab.Controls.Add(this.gamemodePanel);
            this.commandsTab.Controls.Add(this.worldCmdLbl);
            this.commandsTab.Controls.Add(this.worldPanel);
            this.commandsTab.Controls.Add(this.playerCmdLbl);
            this.commandsTab.Controls.Add(this.playerPanel);
            this.commandsTab.Controls.Add(this.timeCmdLbl);
            this.commandsTab.Controls.Add(this.timePanel);
            this.commandsTab.Controls.Add(this.enchantCmdLbl);
            this.commandsTab.Controls.Add(this.enchantPanel);
            this.commandsTab.Controls.Add(this.giveCmdLabel);
            this.commandsTab.Controls.Add(this.giveCommandPanel);
            this.commandsTab.HorizontalScrollbarBarColor = true;
            this.commandsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.commandsTab.HorizontalScrollbarSize = 10;
            this.commandsTab.Location = new System.Drawing.Point(4, 5);
            this.commandsTab.Name = "commandsTab";
            this.commandsTab.Size = new System.Drawing.Size(1122, 630);
            this.commandsTab.TabIndex = 7;
            this.commandsTab.Tag = "needsGeckoU";
            this.commandsTab.Text = "Commands";
            this.commandsTab.VerticalScrollbarBarColor = true;
            this.commandsTab.VerticalScrollbarHighlightOnWheel = false;
            this.commandsTab.VerticalScrollbarSize = 10;
            // 
            // gamemodeCmdLbl
            // 
            this.gamemodeCmdLbl.AutoSize = true;
            this.gamemodeCmdLbl.BackColor = System.Drawing.Color.Transparent;
            this.gamemodeCmdLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.gamemodeCmdLbl.Location = new System.Drawing.Point(99, 174);
            this.gamemodeCmdLbl.Name = "gamemodeCmdLbl";
            this.gamemodeCmdLbl.Size = new System.Drawing.Size(83, 19);
            this.gamemodeCmdLbl.TabIndex = 46;
            this.gamemodeCmdLbl.Text = "/gamemode";
            // 
            // gamemodePanel
            // 
            this.gamemodePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamemodePanel.Controls.Add(this.GameModeCommandBtn);
            this.gamemodePanel.HorizontalScrollbarBarColor = true;
            this.gamemodePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.gamemodePanel.HorizontalScrollbarSize = 10;
            this.gamemodePanel.Location = new System.Drawing.Point(95, 184);
            this.gamemodePanel.Name = "gamemodePanel";
            this.gamemodePanel.Size = new System.Drawing.Size(180, 145);
            this.gamemodePanel.TabIndex = 45;
            this.gamemodePanel.VerticalScrollbarBarColor = true;
            this.gamemodePanel.VerticalScrollbarHighlightOnWheel = false;
            this.gamemodePanel.VerticalScrollbarSize = 10;
            // 
            // GameModeCommandBtn
            // 
            this.GameModeCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.GameModeCommandBtn.Location = new System.Drawing.Point(3, 11);
            this.GameModeCommandBtn.Name = "GameModeCommandBtn";
            this.GameModeCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.GameModeCommandBtn.TabIndex = 17;
            this.GameModeCommandBtn.Text = "Survival";
            this.ToolTipManager.SetToolTip(this.GameModeCommandBtn, "Executes the /give command using the parameters entered above");
            this.GameModeCommandBtn.UseSelectable = true;
            this.GameModeCommandBtn.Click += new System.EventHandler(this.GameModeCommandBtnClicked);
            // 
            // worldCmdLbl
            // 
            this.worldCmdLbl.AutoSize = true;
            this.worldCmdLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.worldCmdLbl.Location = new System.Drawing.Point(843, 9);
            this.worldCmdLbl.Name = "worldCmdLbl";
            this.worldCmdLbl.Size = new System.Drawing.Size(45, 19);
            this.worldCmdLbl.TabIndex = 44;
            this.worldCmdLbl.Text = "World";
            // 
            // worldPanel
            // 
            this.worldPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.worldPanel.Controls.Add(this.SetWorldSpawnBtn);
            this.worldPanel.Controls.Add(this.downfallCommandBtn);
            this.worldPanel.HorizontalScrollbarBarColor = true;
            this.worldPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.worldPanel.HorizontalScrollbarSize = 10;
            this.worldPanel.Location = new System.Drawing.Point(839, 19);
            this.worldPanel.Name = "worldPanel";
            this.worldPanel.Size = new System.Drawing.Size(180, 145);
            this.worldPanel.TabIndex = 43;
            this.worldPanel.VerticalScrollbarBarColor = true;
            this.worldPanel.VerticalScrollbarHighlightOnWheel = false;
            this.worldPanel.VerticalScrollbarSize = 10;
            // 
            // SetWorldSpawnBtn
            // 
            this.SetWorldSpawnBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.SetWorldSpawnBtn.Location = new System.Drawing.Point(3, 49);
            this.SetWorldSpawnBtn.Name = "SetWorldSpawnBtn";
            this.SetWorldSpawnBtn.Size = new System.Drawing.Size(172, 23);
            this.SetWorldSpawnBtn.TabIndex = 18;
            this.SetWorldSpawnBtn.Text = "/setworldspawn";
            this.ToolTipManager.SetToolTip(this.SetWorldSpawnBtn, "Executes the /toggledownfall command");
            this.SetWorldSpawnBtn.UseSelectable = true;
            this.SetWorldSpawnBtn.Click += new System.EventHandler(this.SetWorldSpawnBtnClicked);
            // 
            // downfallCommandBtn
            // 
            this.downfallCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.downfallCommandBtn.Location = new System.Drawing.Point(3, 22);
            this.downfallCommandBtn.Name = "downfallCommandBtn";
            this.downfallCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.downfallCommandBtn.TabIndex = 17;
            this.downfallCommandBtn.Text = "/toggledownfall";
            this.ToolTipManager.SetToolTip(this.downfallCommandBtn, "Executes the /toggledownfall command");
            this.downfallCommandBtn.UseSelectable = true;
            this.downfallCommandBtn.Click += new System.EventHandler(this.DownfallCommandBtnClicked);
            // 
            // playerCmdLbl
            // 
            this.playerCmdLbl.AutoSize = true;
            this.playerCmdLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.playerCmdLbl.Location = new System.Drawing.Point(657, 9);
            this.playerCmdLbl.Name = "playerCmdLbl";
            this.playerCmdLbl.Size = new System.Drawing.Size(46, 19);
            this.playerCmdLbl.TabIndex = 42;
            this.playerCmdLbl.Text = "Player";
            // 
            // playerPanel
            // 
            this.playerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerPanel.Controls.Add(this.killCommandBtn);
            this.playerPanel.HorizontalScrollbarBarColor = true;
            this.playerPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.playerPanel.HorizontalScrollbarSize = 10;
            this.playerPanel.Location = new System.Drawing.Point(653, 19);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(180, 145);
            this.playerPanel.TabIndex = 41;
            this.playerPanel.VerticalScrollbarBarColor = true;
            this.playerPanel.VerticalScrollbarHighlightOnWheel = false;
            this.playerPanel.VerticalScrollbarSize = 10;
            // 
            // killCommandBtn
            // 
            this.killCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.killCommandBtn.Location = new System.Drawing.Point(3, 22);
            this.killCommandBtn.Name = "killCommandBtn";
            this.killCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.killCommandBtn.TabIndex = 17;
            this.killCommandBtn.Text = "/kill";
            this.ToolTipManager.SetToolTip(this.killCommandBtn, "Executes the /kill command, which kills you.");
            this.killCommandBtn.UseSelectable = true;
            this.killCommandBtn.Click += new System.EventHandler(this.KillCommandBtnClicked);
            // 
            // timeCmdLbl
            // 
            this.timeCmdLbl.AutoSize = true;
            this.timeCmdLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.timeCmdLbl.Location = new System.Drawing.Point(471, 9);
            this.timeCmdLbl.Name = "timeCmdLbl";
            this.timeCmdLbl.Size = new System.Drawing.Size(41, 19);
            this.timeCmdLbl.TabIndex = 40;
            this.timeCmdLbl.Text = "/time";
            // 
            // timePanel
            // 
            this.timePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timePanel.Controls.Add(this.timeCommandBtn);
            this.timePanel.Controls.Add(this.timeAmountBox);
            this.timePanel.HorizontalScrollbarBarColor = true;
            this.timePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.timePanel.HorizontalScrollbarSize = 10;
            this.timePanel.Location = new System.Drawing.Point(467, 19);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(180, 145);
            this.timePanel.TabIndex = 39;
            this.timePanel.VerticalScrollbarBarColor = true;
            this.timePanel.VerticalScrollbarHighlightOnWheel = false;
            this.timePanel.VerticalScrollbarSize = 10;
            // 
            // timeCommandBtn
            // 
            this.timeCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.timeCommandBtn.Location = new System.Drawing.Point(3, 107);
            this.timeCommandBtn.Name = "timeCommandBtn";
            this.timeCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.timeCommandBtn.TabIndex = 17;
            this.timeCommandBtn.Text = " /time";
            this.ToolTipManager.SetToolTip(this.timeCommandBtn, "Executes the /time command using the parameters entered above");
            this.timeCommandBtn.UseSelectable = true;
            this.timeCommandBtn.Click += new System.EventHandler(this.TimeCommandBtnClicked);
            // 
            // timeAmountBox
            // 
            // 
            // 
            // 
            this.timeAmountBox.CustomButton.Image = null;
            this.timeAmountBox.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.timeAmountBox.CustomButton.Name = "";
            this.timeAmountBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.timeAmountBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeAmountBox.CustomButton.TabIndex = 1;
            this.timeAmountBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timeAmountBox.CustomButton.UseSelectable = true;
            this.timeAmountBox.CustomButton.Visible = false;
            this.timeAmountBox.Lines = new string[0];
            this.timeAmountBox.Location = new System.Drawing.Point(3, 20);
            this.timeAmountBox.MaxLength = 999;
            this.timeAmountBox.Name = "timeAmountBox";
            this.timeAmountBox.PasswordChar = '\0';
            this.timeAmountBox.PromptText = "Enter Time...";
            this.timeAmountBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeAmountBox.SelectedText = "";
            this.timeAmountBox.SelectionLength = 0;
            this.timeAmountBox.SelectionStart = 0;
            this.timeAmountBox.ShortcutsEnabled = true;
            this.timeAmountBox.Size = new System.Drawing.Size(172, 23);
            this.timeAmountBox.TabIndex = 17;
            this.timeAmountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeAmountBox.UseSelectable = true;
            this.timeAmountBox.WaterMark = "Enter Time...";
            this.timeAmountBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.timeAmountBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // enchantCmdLbl
            // 
            this.enchantCmdLbl.AutoSize = true;
            this.enchantCmdLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.enchantCmdLbl.Location = new System.Drawing.Point(285, 9);
            this.enchantCmdLbl.Name = "enchantCmdLbl";
            this.enchantCmdLbl.Size = new System.Drawing.Size(63, 19);
            this.enchantCmdLbl.TabIndex = 38;
            this.enchantCmdLbl.Text = "/enchant";
            // 
            // enchantPanel
            // 
            this.enchantPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enchantPanel.Controls.Add(this.enchantIDBox);
            this.enchantPanel.Controls.Add(this.enchantCommandBtn);
            this.enchantPanel.Controls.Add(this.enchantLevelBox);
            this.enchantPanel.HorizontalScrollbarBarColor = true;
            this.enchantPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.enchantPanel.HorizontalScrollbarSize = 10;
            this.enchantPanel.Location = new System.Drawing.Point(281, 19);
            this.enchantPanel.Name = "enchantPanel";
            this.enchantPanel.Size = new System.Drawing.Size(180, 145);
            this.enchantPanel.TabIndex = 37;
            this.enchantPanel.VerticalScrollbarBarColor = true;
            this.enchantPanel.VerticalScrollbarHighlightOnWheel = false;
            this.enchantPanel.VerticalScrollbarSize = 10;
            // 
            // enchantIDBox
            // 
            this.enchantIDBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.enchantIDBox.FormattingEnabled = true;
            this.enchantIDBox.ItemHeight = 19;
            this.enchantIDBox.Items.AddRange(new object[] {
            "Protection",
            "Fire Protection",
            "Feather Falling",
            "Blast Protection",
            "Projectile Protection",
            "Respiration",
            "Aqua Affinity",
            "Thorns",
            "Depth Strider",
            "Frost Walker",
            "Curse of Binding",
            "Sharpness",
            "Smite",
            "Bane of Arthropods",
            "Knockback",
            "Fire Aspect",
            "Looting",
            "Efficiency",
            "Silk Touch",
            "Unbreaking",
            "Fortune",
            "Power",
            "Punch",
            "Flame",
            "Infinity",
            "Luck of the Sea",
            "Lure",
            "Mending",
            "Curse of Vanishing",
            "Impaling",
            "Riptide",
            "Loyalty",
            "Channeling"});
            this.enchantIDBox.Location = new System.Drawing.Point(3, 20);
            this.enchantIDBox.Name = "enchantIDBox";
            this.enchantIDBox.Size = new System.Drawing.Size(172, 25);
            this.enchantIDBox.TabIndex = 17;
            this.enchantIDBox.UseSelectable = true;
            // 
            // enchantCommandBtn
            // 
            this.enchantCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.enchantCommandBtn.Location = new System.Drawing.Point(3, 107);
            this.enchantCommandBtn.Name = "enchantCommandBtn";
            this.enchantCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.enchantCommandBtn.TabIndex = 17;
            this.enchantCommandBtn.Text = "/enchant";
            this.ToolTipManager.SetToolTip(this.enchantCommandBtn, "Executes the /enchant command using the parameters entered above");
            this.enchantCommandBtn.UseSelectable = true;
            this.enchantCommandBtn.Click += new System.EventHandler(this.EnchantCommandBtnClicked);
            // 
            // enchantLevelBox
            // 
            // 
            // 
            // 
            this.enchantLevelBox.CustomButton.Image = null;
            this.enchantLevelBox.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.enchantLevelBox.CustomButton.Name = "";
            this.enchantLevelBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.enchantLevelBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.enchantLevelBox.CustomButton.TabIndex = 1;
            this.enchantLevelBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.enchantLevelBox.CustomButton.UseSelectable = true;
            this.enchantLevelBox.CustomButton.Visible = false;
            this.enchantLevelBox.Lines = new string[0];
            this.enchantLevelBox.Location = new System.Drawing.Point(3, 49);
            this.enchantLevelBox.MaxLength = 5;
            this.enchantLevelBox.Name = "enchantLevelBox";
            this.enchantLevelBox.PasswordChar = '\0';
            this.enchantLevelBox.PromptText = "Enchantment Level";
            this.enchantLevelBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.enchantLevelBox.SelectedText = "";
            this.enchantLevelBox.SelectionLength = 0;
            this.enchantLevelBox.SelectionStart = 0;
            this.enchantLevelBox.ShortcutsEnabled = true;
            this.enchantLevelBox.Size = new System.Drawing.Size(172, 23);
            this.enchantLevelBox.TabIndex = 17;
            this.enchantLevelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enchantLevelBox.UseSelectable = true;
            this.enchantLevelBox.WaterMark = "Enchantment Level";
            this.enchantLevelBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.enchantLevelBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // giveCmdLabel
            // 
            this.giveCmdLabel.AutoSize = true;
            this.giveCmdLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.giveCmdLabel.Location = new System.Drawing.Point(99, 9);
            this.giveCmdLabel.Name = "giveCmdLabel";
            this.giveCmdLabel.Size = new System.Drawing.Size(39, 19);
            this.giveCmdLabel.TabIndex = 36;
            this.giveCmdLabel.Text = "/give";
            // 
            // giveCommandPanel
            // 
            this.giveCommandPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.giveCommandPanel.Controls.Add(this.itemIdHelpBtn);
            this.giveCommandPanel.Controls.Add(this.giveCommandBtn);
            this.giveCommandPanel.Controls.Add(this.giveDataBox);
            this.giveCommandPanel.Controls.Add(this.giveAmountBox);
            this.giveCommandPanel.Controls.Add(this.giveIDBox);
            this.giveCommandPanel.HorizontalScrollbarBarColor = true;
            this.giveCommandPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.giveCommandPanel.HorizontalScrollbarSize = 10;
            this.giveCommandPanel.Location = new System.Drawing.Point(95, 19);
            this.giveCommandPanel.Name = "giveCommandPanel";
            this.giveCommandPanel.Size = new System.Drawing.Size(180, 145);
            this.giveCommandPanel.TabIndex = 35;
            this.giveCommandPanel.VerticalScrollbarBarColor = true;
            this.giveCommandPanel.VerticalScrollbarHighlightOnWheel = false;
            this.giveCommandPanel.VerticalScrollbarSize = 10;
            // 
            // itemIdHelpBtn
            // 
            this.itemIdHelpBtn.Highlight = true;
            this.itemIdHelpBtn.Location = new System.Drawing.Point(143, 20);
            this.itemIdHelpBtn.Name = "itemIdHelpBtn";
            this.itemIdHelpBtn.Size = new System.Drawing.Size(32, 23);
            this.itemIdHelpBtn.TabIndex = 45;
            this.itemIdHelpBtn.Text = "?";
            this.ToolTipManager.SetToolTip(this.itemIdHelpBtn, "Executes the /give command using the parameters entered above");
            this.itemIdHelpBtn.UseSelectable = true;
            this.itemIdHelpBtn.Click += new System.EventHandler(this.ItemIdHelpBtnClicked);
            // 
            // giveCommandBtn
            // 
            this.giveCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.giveCommandBtn.Location = new System.Drawing.Point(3, 107);
            this.giveCommandBtn.Name = "giveCommandBtn";
            this.giveCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.giveCommandBtn.TabIndex = 17;
            this.giveCommandBtn.Text = "/give";
            this.ToolTipManager.SetToolTip(this.giveCommandBtn, "Executes the /give command using the parameters entered above");
            this.giveCommandBtn.UseSelectable = true;
            this.giveCommandBtn.Click += new System.EventHandler(this.GiveCommandBtnClicked);
            // 
            // giveDataBox
            // 
            // 
            // 
            // 
            this.giveDataBox.CustomButton.Image = null;
            this.giveDataBox.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.giveDataBox.CustomButton.Name = "";
            this.giveDataBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.giveDataBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.giveDataBox.CustomButton.TabIndex = 1;
            this.giveDataBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.giveDataBox.CustomButton.UseSelectable = true;
            this.giveDataBox.CustomButton.Visible = false;
            this.giveDataBox.Lines = new string[0];
            this.giveDataBox.Location = new System.Drawing.Point(3, 78);
            this.giveDataBox.MaxLength = 2;
            this.giveDataBox.Name = "giveDataBox";
            this.giveDataBox.PasswordChar = '\0';
            this.giveDataBox.PromptText = "Data Value";
            this.giveDataBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.giveDataBox.SelectedText = "";
            this.giveDataBox.SelectionLength = 0;
            this.giveDataBox.SelectionStart = 0;
            this.giveDataBox.ShortcutsEnabled = true;
            this.giveDataBox.Size = new System.Drawing.Size(172, 23);
            this.giveDataBox.TabIndex = 17;
            this.giveDataBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipManager.SetToolTip(this.giveDataBox, "The data value of the Item");
            this.giveDataBox.UseSelectable = true;
            this.giveDataBox.WaterMark = "Data Value";
            this.giveDataBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.giveDataBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // giveAmountBox
            // 
            // 
            // 
            // 
            this.giveAmountBox.CustomButton.Image = null;
            this.giveAmountBox.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.giveAmountBox.CustomButton.Name = "";
            this.giveAmountBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.giveAmountBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.giveAmountBox.CustomButton.TabIndex = 1;
            this.giveAmountBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.giveAmountBox.CustomButton.UseSelectable = true;
            this.giveAmountBox.CustomButton.Visible = false;
            this.giveAmountBox.Lines = new string[0];
            this.giveAmountBox.Location = new System.Drawing.Point(4, 49);
            this.giveAmountBox.MaxLength = 5;
            this.giveAmountBox.Name = "giveAmountBox";
            this.giveAmountBox.PasswordChar = '\0';
            this.giveAmountBox.PromptText = "Item Amount (Max 255)";
            this.giveAmountBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.giveAmountBox.SelectedText = "";
            this.giveAmountBox.SelectionLength = 0;
            this.giveAmountBox.SelectionStart = 0;
            this.giveAmountBox.ShortcutsEnabled = true;
            this.giveAmountBox.Size = new System.Drawing.Size(172, 23);
            this.giveAmountBox.TabIndex = 17;
            this.giveAmountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipManager.SetToolTip(this.giveAmountBox, "How many of the items you want");
            this.giveAmountBox.UseSelectable = true;
            this.giveAmountBox.WaterMark = "Item Amount (Max 255)";
            this.giveAmountBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.giveAmountBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // giveIDBox
            // 
            // 
            // 
            // 
            this.giveIDBox.CustomButton.Image = null;
            this.giveIDBox.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.giveIDBox.CustomButton.Name = "";
            this.giveIDBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.giveIDBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.giveIDBox.CustomButton.TabIndex = 1;
            this.giveIDBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.giveIDBox.CustomButton.UseSelectable = true;
            this.giveIDBox.CustomButton.Visible = false;
            this.giveIDBox.Lines = new string[0];
            this.giveIDBox.Location = new System.Drawing.Point(3, 20);
            this.giveIDBox.MaxLength = 5;
            this.giveIDBox.Name = "giveIDBox";
            this.giveIDBox.PasswordChar = '\0';
            this.giveIDBox.PromptText = "Item ID";
            this.giveIDBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.giveIDBox.SelectedText = "";
            this.giveIDBox.SelectionLength = 0;
            this.giveIDBox.SelectionStart = 0;
            this.giveIDBox.ShortcutsEnabled = true;
            this.giveIDBox.Size = new System.Drawing.Size(135, 23);
            this.giveIDBox.TabIndex = 17;
            this.giveIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipManager.SetToolTip(this.giveIDBox, "The ID of the item you want");
            this.giveIDBox.UseSelectable = true;
            this.giveIDBox.WaterMark = "Item ID";
            this.giveIDBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.giveIDBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.OpenLangMngrBtn);
            this.settingsTab.Controls.Add(this.CheckForPreRelease);
            this.settingsTab.Controls.Add(this.settingsLogo);
            this.settingsTab.Controls.Add(this.releaseNotesToggle);
            this.settingsTab.Controls.Add(this.resetConfigBtn);
            this.settingsTab.Controls.Add(this.discordRpcCheckBox);
            this.settingsTab.Controls.Add(this.colorsBox);
            this.settingsTab.Controls.Add(this.ThemeLabel);
            this.settingsTab.Controls.Add(this.ColorLabel);
            this.settingsTab.Controls.Add(this.themeBox);
            this.settingsTab.HorizontalScrollbarBarColor = true;
            this.settingsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsTab.HorizontalScrollbarSize = 10;
            this.settingsTab.Location = new System.Drawing.Point(4, 5);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(1122, 630);
            this.settingsTab.TabIndex = 5;
            this.settingsTab.Tag = "";
            this.settingsTab.Text = "Settings";
            this.settingsTab.VerticalScrollbarBarColor = true;
            this.settingsTab.VerticalScrollbarHighlightOnWheel = false;
            this.settingsTab.VerticalScrollbarSize = 10;
            // 
            // OpenLangMngrBtn
            // 
            this.OpenLangMngrBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenLangMngrBtn.Location = new System.Drawing.Point(65, 100);
            this.OpenLangMngrBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenLangMngrBtn.Name = "OpenLangMngrBtn";
            this.OpenLangMngrBtn.Size = new System.Drawing.Size(1050, 36);
            this.OpenLangMngrBtn.TabIndex = 48;
            this.OpenLangMngrBtn.Text = "Languages";
            this.ToolTipManager.SetToolTip(this.OpenLangMngrBtn, "Opens the Language Manager");
            this.OpenLangMngrBtn.UseSelectable = true;
            this.OpenLangMngrBtn.Click += new System.EventHandler(this.OpenLangMngrBtnClicked);
            // 
            // CheckForPreRelease
            // 
            this.CheckForPreRelease.AutoSize = true;
            this.CheckForPreRelease.Location = new System.Drawing.Point(421, 76);
            this.CheckForPreRelease.Name = "CheckForPreRelease";
            this.CheckForPreRelease.Size = new System.Drawing.Size(181, 15);
            this.CheckForPreRelease.TabIndex = 47;
            this.CheckForPreRelease.Text = "Check for pre-release versions";
            this.ToolTipManager.SetToolTip(this.CheckForPreRelease, "Whether to only view the current release notes or all previous release notes");
            this.CheckForPreRelease.UseSelectable = true;
            this.CheckForPreRelease.CheckedChanged += new System.EventHandler(this.CheckForPreReleaseToggled);
            // 
            // settingsLogo
            // 
            this.settingsLogo.BackColor = System.Drawing.Color.Transparent;
            this.settingsLogo.BackgroundImage = global::Minecraft_Wii_U_Mod_Injector.Properties.Resources.Icon;
            this.settingsLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsLogo.HorizontalScrollbarBarColor = true;
            this.settingsLogo.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsLogo.HorizontalScrollbarSize = 10;
            this.settingsLogo.Location = new System.Drawing.Point(65, 193);
            this.settingsLogo.Name = "settingsLogo";
            this.settingsLogo.Size = new System.Drawing.Size(1050, 431);
            this.settingsLogo.TabIndex = 44;
            this.settingsLogo.VerticalScrollbarBarColor = true;
            this.settingsLogo.VerticalScrollbarHighlightOnWheel = false;
            this.settingsLogo.VerticalScrollbarSize = 10;
            // 
            // releaseNotesToggle
            // 
            this.releaseNotesToggle.AutoSize = true;
            this.releaseNotesToggle.Location = new System.Drawing.Point(215, 76);
            this.releaseNotesToggle.Name = "releaseNotesToggle";
            this.releaseNotesToggle.Size = new System.Drawing.Size(200, 15);
            this.releaseNotesToggle.TabIndex = 46;
            this.releaseNotesToggle.Text = "Only display current release notes";
            this.ToolTipManager.SetToolTip(this.releaseNotesToggle, "Whether to only view the current release notes or all previous release notes");
            this.releaseNotesToggle.UseSelectable = true;
            this.releaseNotesToggle.CheckedChanged += new System.EventHandler(this.ReleaseNotesToggleClicked);
            // 
            // resetConfigBtn
            // 
            this.resetConfigBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetConfigBtn.Location = new System.Drawing.Point(65, 148);
            this.resetConfigBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resetConfigBtn.Name = "resetConfigBtn";
            this.resetConfigBtn.Size = new System.Drawing.Size(1050, 36);
            this.resetConfigBtn.TabIndex = 45;
            this.resetConfigBtn.Text = "Reset Configuration";
            this.ToolTipManager.SetToolTip(this.resetConfigBtn, "Resets the configuration file");
            this.resetConfigBtn.UseSelectable = true;
            this.resetConfigBtn.Click += new System.EventHandler(this.ResetConfigClicked);
            // 
            // discordRpcCheckBox
            // 
            this.discordRpcCheckBox.AutoSize = true;
            this.discordRpcCheckBox.Checked = true;
            this.discordRpcCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.discordRpcCheckBox.Location = new System.Drawing.Point(65, 76);
            this.discordRpcCheckBox.Name = "discordRpcCheckBox";
            this.discordRpcCheckBox.Size = new System.Drawing.Size(139, 15);
            this.discordRpcCheckBox.TabIndex = 43;
            this.discordRpcCheckBox.Text = "Discord Rich Presence";
            this.ToolTipManager.SetToolTip(this.discordRpcCheckBox, resources.GetString("discordRpcCheckBox.ToolTip"));
            this.discordRpcCheckBox.UseSelectable = true;
            this.discordRpcCheckBox.CheckedChanged += new System.EventHandler(this.DiscordRpcToggleChecked);
            // 
            // colorsBox
            // 
            this.colorsBox.FormattingEnabled = true;
            this.colorsBox.ItemHeight = 23;
            this.colorsBox.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Green",
            "Lime",
            "Magenta",
            "Orange",
            "Pink",
            "Purple",
            "Red",
            "Silver",
            "Teal",
            "White",
            "Yellow"});
            this.colorsBox.Location = new System.Drawing.Point(65, 41);
            this.colorsBox.Name = "colorsBox";
            this.colorsBox.Size = new System.Drawing.Size(1050, 29);
            this.colorsBox.TabIndex = 37;
            this.colorsBox.UseSelectable = true;
            this.colorsBox.SelectedIndexChanged += new System.EventHandler(this.FormColorSelected);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ThemeLabel.Location = new System.Drawing.Point(6, 6);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(53, 19);
            this.ThemeLabel.TabIndex = 30;
            this.ThemeLabel.Text = "Theme:";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ColorLabel.Location = new System.Drawing.Point(7, 41);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(45, 19);
            this.ColorLabel.TabIndex = 36;
            this.ColorLabel.Text = "Color:";
            // 
            // themeBox
            // 
            this.themeBox.FormattingEnabled = true;
            this.themeBox.ItemHeight = 23;
            this.themeBox.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.themeBox.Location = new System.Drawing.Point(65, 6);
            this.themeBox.Name = "themeBox";
            this.themeBox.Size = new System.Drawing.Size(1050, 29);
            this.themeBox.TabIndex = 35;
            this.themeBox.UseSelectable = true;
            this.themeBox.SelectedIndexChanged += new System.EventHandler(this.FormThemeSelected);
            // 
            // HomeTile
            // 
            this.HomeTile.ActiveControl = null;
            this.HomeTile.Location = new System.Drawing.Point(0, 63);
            this.HomeTile.Name = "HomeTile";
            this.HomeTile.PaintTileCount = false;
            this.HomeTile.Size = new System.Drawing.Size(160, 55);
            this.HomeTile.TabIndex = 1;
            this.HomeTile.Tag = "";
            this.HomeTile.Text = "Home";
            this.HomeTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.HomeTile.UseSelectable = true;
            this.HomeTile.UseTileImage = true;
            this.HomeTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            // 
            // ToolTipManager
            // 
            this.ToolTipManager.Style = MetroFramework.MetroColorStyle.Default;
            this.ToolTipManager.StyleManager = null;
            this.ToolTipManager.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // PlayersTile
            // 
            this.PlayersTile.ActiveControl = null;
            this.PlayersTile.Location = new System.Drawing.Point(0, 117);
            this.PlayersTile.Name = "PlayersTile";
            this.PlayersTile.PaintTileCount = false;
            this.PlayersTile.Size = new System.Drawing.Size(160, 55);
            this.PlayersTile.TabIndex = 2;
            this.PlayersTile.Tag = "";
            this.PlayersTile.Text = "Player(s)";
            this.PlayersTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayersTile.TileCount = 1;
            this.PlayersTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.PlayersTile.UseSelectable = true;
            this.PlayersTile.UseTileImage = true;
            this.PlayersTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // CommandsTile
            // 
            this.CommandsTile.ActiveControl = null;
            this.CommandsTile.Location = new System.Drawing.Point(0, 337);
            this.CommandsTile.Name = "CommandsTile";
            this.CommandsTile.PaintTileCount = false;
            this.CommandsTile.Size = new System.Drawing.Size(160, 55);
            this.CommandsTile.TabIndex = 6;
            this.CommandsTile.Tag = "";
            this.CommandsTile.Text = "Commands";
            this.CommandsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CommandsTile.TileCount = 5;
            this.CommandsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.CommandsTile.UseSelectable = true;
            this.CommandsTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // RightClickMenu
            // 
            this.RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IncreaseDecimalPlace,
            this.DecreaseDecimalPlace});
            this.RightClickMenu.Name = "RightClickMenu";
            this.RightClickMenu.Size = new System.Drawing.Size(323, 48);
            // 
            // IncreaseDecimalPlace
            // 
            this.IncreaseDecimalPlace.Name = "IncreaseDecimalPlace";
            this.IncreaseDecimalPlace.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Oemplus)));
            this.IncreaseDecimalPlace.Size = new System.Drawing.Size(322, 22);
            this.IncreaseDecimalPlace.Text = "Increase decimal place";
            // 
            // DecreaseDecimalPlace
            // 
            this.DecreaseDecimalPlace.Name = "DecreaseDecimalPlace";
            this.DecreaseDecimalPlace.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.OemMinus)));
            this.DecreaseDecimalPlace.Size = new System.Drawing.Size(322, 22);
            this.DecreaseDecimalPlace.Text = "Decrease decimal place";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.SettingsTile);
            this.Controls.Add(this.MinigamesTile);
            this.Controls.Add(this.GeneralTile);
            this.Controls.Add(this.WorldTile);
            this.Controls.Add(this.CommandsTile);
            this.Controls.Add(this.PlayersTile);
            this.Controls.Add(this.HomeTile);
            this.Controls.Add(this.BuildTile);
            this.Controls.Add(this.MainTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1141, 608);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Minecraft: Wii U Mod Injector";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit);
            this.Load += new System.EventHandler(this.Init);
            this.MainTabs.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.playersTab.ResumeLayout(false);
            this.playersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XPLevelSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotionAmplifierSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrictionSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerModelScaleSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldOfViewSplitSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RiptideFlyingSpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SprintingSpeedScaleSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnchantmentLevelSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkingSpeedScaleSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReachSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpHeightSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldOfViewSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitBoxScaleSlider)).EndInit();
            this.worldTab.ResumeLayout(false);
            this.worldTab.PerformLayout();
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            this.minigamesTab.ResumeLayout(false);
            this.MinigamesTabs.ResumeLayout(false);
            this.GeneralMinigames.ResumeLayout(false);
            this.GeneralMinigames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequiredPlayersSlider)).EndInit();
            this.Battle.ResumeLayout(false);
            this.Battle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefillIntervalSlider)).EndInit();
            this.Tumble.ResumeLayout(false);
            this.Tumble.PerformLayout();
            this.Glide.ResumeLayout(false);
            this.Glide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ringScoreBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringScoreOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringScoreGreen)).EndInit();
            this.commandsTab.ResumeLayout(false);
            this.commandsTab.PerformLayout();
            this.gamemodePanel.ResumeLayout(false);
            this.worldPanel.ResumeLayout(false);
            this.playerPanel.ResumeLayout(false);
            this.timePanel.ResumeLayout(false);
            this.enchantPanel.ResumeLayout(false);
            this.giveCommandPanel.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            this.RightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTile WorldTile;
        public MetroFramework.Controls.MetroTile GeneralTile;
        public MetroFramework.Controls.MetroTile MinigamesTile;
        public MetroFramework.Controls.MetroTile SettingsTile;
        public MetroFramework.Controls.MetroTile BuildTile;
        public MetroFramework.Controls.MetroTabControl MainTabs;
        public MetroFramework.Controls.MetroTabPage playersTab;
        public MetroFramework.Controls.MetroTabPage worldTab;
        public MetroFramework.Controls.MetroTabPage generalTab;
        public MetroFramework.Controls.MetroTabPage minigamesTab;
        public MetroFramework.Controls.MetroTabPage settingsTab;
        public MetroFramework.Controls.MetroTile HomeTile;
        public MetroFramework.Controls.MetroTabPage MainTab;
        public MetroFramework.Controls.MetroLabel WiiUIpv4Lbl;
        public MetroFramework.Controls.MetroTile PlayersTile;
        public MetroFramework.Controls.MetroButton ConnectBtn;
        public MetroFramework.Controls.MetroCheckBox InsaneCriticalHits;
        public MetroFramework.Controls.MetroCheckBox AlwaysSwimming;
        public MetroFramework.Controls.MetroCheckBox InfiniteRiptide;
        public MetroFramework.Controls.MetroCheckBox FullRotation;
        public MetroFramework.Controls.MetroCheckBox AlwaysDamagedPlayers;
        public MetroFramework.Controls.MetroCheckBox InfiniteItems;
        public MetroFramework.Controls.MetroCheckBox RapidBow;
        public MetroFramework.Controls.MetroCheckBox BloodVision;
        public MetroFramework.Controls.MetroCheckBox IgnorePotions;
        public MetroFramework.Controls.MetroCheckBox ForeverLastingPotions;
        public MetroFramework.Controls.MetroCheckBox BypassInvulnerability;
        public MetroFramework.Controls.MetroCheckBox PlaceBlocksonHead;
        public MetroFramework.Controls.MetroCheckBox WalkonWater;
        public MetroFramework.Controls.MetroCheckBox AlwaysElytra;
        public MetroFramework.Controls.MetroCheckBox CaveFinder;
        public MetroFramework.Controls.MetroCheckBox Wallhack;
        public MetroFramework.Controls.MetroCheckBox LargeXPDrops;
        public MetroFramework.Controls.MetroCheckBox WallClimbing;
        public MetroFramework.Controls.MetroCheckBox NoCollision;
        public MetroFramework.Controls.MetroCheckBox InfiniteAir;
        public MetroFramework.Controls.MetroCheckBox InfiniteDurability;
        public MetroFramework.Controls.MetroCheckBox SuperKnockback;
        public MetroFramework.Controls.MetroCheckBox DisabledKnockback;
        public MetroFramework.Controls.MetroCheckBox SilkTouchAnything;
        public MetroFramework.Controls.MetroCheckBox DeveloperMode;
        public MetroFramework.Controls.MetroCheckBox PickLiquidBlocks;
        public MetroFramework.Controls.MetroCheckBox DuelWieldanyItem;
        public MetroFramework.Controls.MetroCheckBox DisableStarving;
        public MetroFramework.Controls.MetroCheckBox InstantMining;
        public MetroFramework.Controls.MetroCheckBox Flying;
        public MetroFramework.Controls.MetroCheckBox DisableSuffocating;
        public MetroFramework.Controls.MetroCheckBox NoFallDamage;
        public MetroFramework.Controls.MetroCheckBox CraftAnything;
        public MetroFramework.Controls.MetroCheckBox CreativeMode;
        public System.Windows.Forms.NumericUpDown SprintingSpeedScaleSlider;
        public MetroFramework.Controls.MetroLabel SprintingSpeedScale;
        public System.Windows.Forms.NumericUpDown RiptideFlyingSpeedSlider;
        public MetroFramework.Controls.MetroLabel RiptideFlyingSpeed;
        public System.Windows.Forms.NumericUpDown ReachSlider;
        public MetroFramework.Controls.MetroLabel Reach;
        public System.Windows.Forms.NumericUpDown JumpHeightSlider;
        public MetroFramework.Controls.MetroLabel JumpHeight;
        public System.Windows.Forms.NumericUpDown EnchantmentLevelSlider;
        public MetroFramework.Controls.MetroLabel EnchantmentLevel;
        public MetroFramework.Controls.MetroCheckBox NoFog;
        public MetroFramework.Controls.MetroCheckBox StaticLiquidBlocks;
        public MetroFramework.Controls.MetroCheckBox FoggyWeather;
        public MetroFramework.Controls.MetroCheckBox GenerateAmplifiedWorld;
        public MetroFramework.Controls.MetroCheckBox AcidLiquidBlocks;
        public MetroFramework.Controls.MetroCheckBox DisableCreativeFlag;
        public MetroFramework.Controls.MetroCheckBox GeneratePlainWorld;
        public MetroFramework.Controls.MetroCheckBox FreezingWorld;
        public MetroFramework.Controls.MetroButton MapTextEditor;
        public MetroFramework.Controls.MetroCheckBox UncapEntitySpawnLimit;
        public MetroFramework.Controls.MetroCheckBox AllDLCUnlocked;
        public MetroFramework.Controls.MetroButton ExitGame;
        public MetroFramework.Controls.MetroTabControl MinigamesTabs;
        public MetroFramework.Controls.MetroTabPage GeneralMinigames;
        public MetroFramework.Controls.MetroCheckBox AllPermissions;
        public MetroFramework.Controls.MetroCheckBox AlwaysDamaged;
        public MetroFramework.Controls.MetroCheckBox TNTGriefing;
        public MetroFramework.Controls.MetroCheckBox DisabledKillBarriers;
        public MetroFramework.Controls.MetroLabel RequiredPlayers;
        public System.Windows.Forms.NumericUpDown RequiredPlayersSlider;
        public MetroFramework.Controls.MetroTabPage Battle;
        public MetroFramework.Controls.MetroButton EndGame;
        public MetroFramework.Controls.MetroLabel RefillInterval;
        public System.Windows.Forms.NumericUpDown RefillIntervalSlider;
        public MetroFramework.Controls.MetroCheckBox AntiEndGame;
        public MetroFramework.Controls.MetroTabPage Tumble;
        public MetroFramework.Controls.MetroCheckBox TumbleHUD;
        public MetroFramework.Controls.MetroTabPage Glide;
        public MetroFramework.Controls.MetroLabel ringScoreG;
        public System.Windows.Forms.NumericUpDown ringScoreGreen;
        public MetroFramework.Controls.MetroCheckBox HostOptions;
        public MetroFramework.Controls.MetroCheckBox DisablePermanentKicks;
        public MetroFramework.Controls.MetroButton DiscordSrvBtn;
        public MetroFramework.Components.MetroStyleManager StyleMngr;
        public MetroFramework.Controls.MetroButton NnidEditorBtn;
        public MetroFramework.Controls.MetroComboBox colorsBox;
        public MetroFramework.Controls.MetroLabel ThemeLabel;
        public MetroFramework.Controls.MetroLabel ColorLabel;
        public MetroFramework.Controls.MetroComboBox themeBox;
        public MetroFramework.Controls.MetroButton CreditsBtn;
        private MetroFramework.Components.MetroStyleExtender StyleExtender;
        public MetroFramework.Controls.MetroLabel BuildVerTitleLbl;
        private MetroFramework.Components.MetroToolTip ToolTipManager;
        public MetroFramework.Controls.MetroCheckBox VisibleHitboxes;
        public MetroFramework.Controls.MetroCheckBox discordRpcCheckBox;
        private MetroFramework.Controls.MetroPanel settingsLogo;
        public MetroFramework.Controls.MetroCheckBox SqueakInfinitely;
        public MetroFramework.Controls.MetroLabel ringScoreB;
        public System.Windows.Forms.NumericUpDown ringScoreBlue;
        public MetroFramework.Controls.MetroLabel ringScoreO;
        public System.Windows.Forms.NumericUpDown ringScoreOrange;
        private MetroFramework.Controls.MetroTabPage commandsTab;
        public MetroFramework.Controls.MetroTile CommandsTile;
        public MetroFramework.Controls.MetroButton resetConfigBtn;
        private MetroFramework.Controls.MetroLabel worldCmdLbl;
        private MetroFramework.Controls.MetroPanel worldPanel;
        private MetroFramework.Controls.MetroButton downfallCommandBtn;
        private MetroFramework.Controls.MetroLabel playerCmdLbl;
        private MetroFramework.Controls.MetroPanel playerPanel;
        private MetroFramework.Controls.MetroButton killCommandBtn;
        private MetroFramework.Controls.MetroLabel timeCmdLbl;
        private MetroFramework.Controls.MetroPanel timePanel;
        private MetroFramework.Controls.MetroButton timeCommandBtn;
        private MetroFramework.Controls.MetroTextBox timeAmountBox;
        private MetroFramework.Controls.MetroLabel enchantCmdLbl;
        private MetroFramework.Controls.MetroPanel enchantPanel;
        private MetroFramework.Controls.MetroComboBox enchantIDBox;
        private MetroFramework.Controls.MetroButton enchantCommandBtn;
        private MetroFramework.Controls.MetroTextBox enchantLevelBox;
        private MetroFramework.Controls.MetroLabel giveCmdLabel;
        private MetroFramework.Controls.MetroPanel giveCommandPanel;
        private MetroFramework.Controls.MetroButton giveCommandBtn;
        private MetroFramework.Controls.MetroTextBox giveDataBox;
        private MetroFramework.Controls.MetroTextBox giveAmountBox;
        private MetroFramework.Controls.MetroTextBox giveIDBox;
        public MetroFramework.Controls.MetroCheckBox BypassFriendsOnly;
        public System.Windows.Forms.NumericUpDown WalkingSpeedScaleSlider;
        public MetroFramework.Controls.MetroLabel WalkingSpeedScale;
        public MetroFramework.Controls.MetroCheckBox CraftingTableAnywhere;
        public System.Windows.Forms.NumericUpDown HitBoxScaleSlider;
        public MetroFramework.Controls.MetroLabel HitBoxScale;
        public MetroFramework.Controls.MetroCheckBox HiddenGameModesUnlocked;
        public System.Windows.Forms.NumericUpDown FieldOfViewSlider;
        public MetroFramework.Controls.MetroLabel FieldOfView;
        public MetroFramework.Controls.MetroCheckBox TakeEverythingAnywhere;
        public MetroFramework.Controls.MetroCheckBox ArmorHUD;
        public MetroFramework.Controls.MetroCheckBox SlowMotion;
        private MetroFramework.Controls.MetroButton itemIdHelpBtn;
        public MetroFramework.Controls.MetroCheckBox DeadMauFiveMode;
        private MetroFramework.Controls.MetroButton SetWorldSpawnBtn;
        private MetroFramework.Controls.MetroLabel gamemodeCmdLbl;
        private MetroFramework.Controls.MetroPanel gamemodePanel;
        private MetroFramework.Controls.MetroButton GameModeCommandBtn;
        public MetroFramework.Controls.MetroCheckBox releaseNotesToggle;
        public System.Windows.Forms.NumericUpDown playerModelScaleSlider;
        public MetroFramework.Controls.MetroLabel PlayerModelScale;
        public MetroFramework.Controls.MetroButton FaqBtn;
        private MetroFramework.Controls.MetroCheckBox disableVPadInput;
        private MetroFramework.Controls.MetroCheckBox vpadDisplaySwitch;
        public MetroFramework.Controls.MetroCheckBox GamepadSplitscreen;
        public MetroFramework.Controls.MetroCheckBox DisableTeleporting;
        public MetroFramework.Controls.MetroCheckBox GodMode;
        public System.Windows.Forms.NumericUpDown FieldOfViewSplitSlider;
        public MetroFramework.Controls.MetroLabel FieldofViewSplitscreen;
        public System.Windows.Forms.NumericUpDown FrictionSlider;
        public MetroFramework.Controls.MetroLabel Friction;
        public MetroFramework.Controls.MetroCheckBox GodModeAll;
        public MetroFramework.Controls.MetroCheckBox CheckForPreRelease;
        public MetroFramework.Controls.MetroCheckBox UnderwaterEffects;
        public MetroFramework.Controls.MetroCheckBox HideBlocks;
        public MetroFramework.Controls.MetroCheckBox AlwaysInLava;
        public MetroFramework.Controls.MetroCheckBox SeeThroughBlocks;
        public MetroFramework.Controls.MetroCheckBox LevelX;
        public MetroFramework.Controls.MetroCheckBox AlwaysInWater;
        public MetroFramework.Controls.MetroCheckBox ESP;
        public MetroFramework.Controls.MetroCheckBox NoSlowDowns;
        public MetroFramework.Controls.MetroButton UIColorPickerBtn;
        private MetroFramework.Controls.MetroLabel Entities;
        public MetroFramework.Controls.MetroCheckBox SuperchargedCreepers;
        private MetroFramework.Controls.MetroLabel World;
        private MetroFramework.Controls.MetroPanel worldPnl;
        public MetroFramework.Controls.MetroCheckBox IgnitedCreepers;
        public MetroFramework.Controls.MetroCheckBox ZombieTower;
        public MetroFramework.Controls.MetroCheckBox SunProofMobs;
        private MetroFramework.Controls.MetroContextMenu RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem IncreaseDecimalPlace;
        private System.Windows.Forms.ToolStripMenuItem DecreaseDecimalPlace;
        public System.Windows.Forms.NumericUpDown PotionAmplifierSlider;
        public MetroFramework.Controls.MetroLabel PotionAmplifier;
        public MetroFramework.Controls.MetroButton PlayerOptionsBtn;
        public MetroFramework.Controls.MetroLabel XPLevel;
        public System.Windows.Forms.NumericUpDown XPLevelSlider;
        public MetroTextBox WiiUIpv4Box;
        public MetroTextBox BuildNotesBox;
        public MetroButton OpenLangMngrBtn;
        public MetroButton SetupTutorialBtn;
        private MetroLabel metroLabel1;
        private MetroLabel metroLabel2;
        private MetroPanel metroPanel1;
        public MetroCheckBox DebugConsole;
    }
}