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
            this.WiiUIPv4Box = new MetroFramework.Controls.MetroTextBox();
            this.WiiUIpv4Lbl = new MetroFramework.Controls.MetroLabel();
            this.playersTab = new MetroFramework.Controls.MetroTabPage();
            this.InstantSleep = new MetroFramework.Controls.MetroCheckBox();
            this.NoCooldowns = new MetroFramework.Controls.MetroCheckBox();
            this.defPotionBox = new MetroFramework.Controls.MetroComboBox();
            this.DefaultPotionEffect = new MetroFramework.Controls.MetroLabel();
            this.AlwaysDaylight = new MetroFramework.Controls.MetroCheckBox();
            this.AirborneSpeedSlider = new System.Windows.Forms.NumericUpDown();
            this.AirborneSpeed = new MetroFramework.Controls.MetroLabel();
            this.PunchToRide = new MetroFramework.Controls.MetroCheckBox();
            this.UnlimitedTotemsOfUndying = new MetroFramework.Controls.MetroCheckBox();
            this.SplashLingeringPotions = new MetroFramework.Controls.MetroCheckBox();
            this.EffectsLastForever = new MetroFramework.Controls.MetroCheckBox();
            this.ItemOfUndying = new MetroFramework.Controls.MetroCheckBox();
            this.NoDamage = new MetroFramework.Controls.MetroCheckBox();
            this.WaterDownStrengthSlider = new System.Windows.Forms.NumericUpDown();
            this.WaterDownStrength = new MetroFramework.Controls.MetroLabel();
            this.breatheBox = new MetroFramework.Controls.MetroComboBox();
            this.BreathingModeLbl = new MetroFramework.Controls.MetroLabel();
            this.BreakBedrock = new MetroFramework.Controls.MetroCheckBox();
            this.SwimFast = new MetroFramework.Controls.MetroCheckBox();
            this.BreakAnything = new MetroFramework.Controls.MetroCheckBox();
            this.AirJump = new MetroFramework.Controls.MetroCheckBox();
            this.LeftHanded = new MetroFramework.Controls.MetroCheckBox();
            this.MaxStackSlider = new System.Windows.Forms.NumericUpDown();
            this.MaxStack = new MetroFramework.Controls.MetroLabel();
            this.UnlimitedEnchants = new MetroFramework.Controls.MetroCheckBox();
            this.EnchantmentEditorBtn = new MetroFramework.Controls.MetroButton();
            this.Invisible = new MetroFramework.Controls.MetroCheckBox();
            this.PotionAmplifierSlider = new System.Windows.Forms.NumericUpDown();
            this.FrictionSlider = new System.Windows.Forms.NumericUpDown();
            this.playerModelScaleSlider = new System.Windows.Forms.NumericUpDown();
            this.FieldOfViewSplitSlider = new System.Windows.Forms.NumericUpDown();
            this.RiptideFlyingSpeedSlider = new System.Windows.Forms.NumericUpDown();
            this.SprintingSpeedScaleSlider = new System.Windows.Forms.NumericUpDown();
            this.EnchantmentLevelSlider = new System.Windows.Forms.NumericUpDown();
            this.WalkingSpeedScaleSlider = new System.Windows.Forms.NumericUpDown();
            this.ReachSlider = new System.Windows.Forms.NumericUpDown();
            this.JumpHeightSlider = new System.Windows.Forms.NumericUpDown();
            this.FieldOfViewSlider = new System.Windows.Forms.NumericUpDown();
            this.HitBoxScaleSlider = new System.Windows.Forms.NumericUpDown();
            this.PlayerOptionsBtn = new MetroFramework.Controls.MetroButton();
            this.PotionAmplifier = new MetroFramework.Controls.MetroLabel();
            this.NoSlowDowns = new MetroFramework.Controls.MetroCheckBox();
            this.ESP = new MetroFramework.Controls.MetroCheckBox();
            this.AlwaysInWater = new MetroFramework.Controls.MetroCheckBox();
            this.LevelX = new MetroFramework.Controls.MetroCheckBox();
            this.SeeThroughBlocks = new MetroFramework.Controls.MetroCheckBox();
            this.AlwaysInLava = new MetroFramework.Controls.MetroCheckBox();
            this.HideBlocks = new MetroFramework.Controls.MetroCheckBox();
            this.UnderwaterEffects = new MetroFramework.Controls.MetroCheckBox();
            this.EnchantmentLevel = new MetroFramework.Controls.MetroLabel();
            this.Friction = new MetroFramework.Controls.MetroLabel();
            this.GodModeAll = new MetroFramework.Controls.MetroCheckBox();
            this.FieldofViewSplitscreen = new MetroFramework.Controls.MetroLabel();
            this.RiptideFlyingSpeed = new MetroFramework.Controls.MetroLabel();
            this.PlayerModelScale = new MetroFramework.Controls.MetroLabel();
            this.JumpHeight = new MetroFramework.Controls.MetroLabel();
            this.WalkingSpeedScale = new MetroFramework.Controls.MetroLabel();
            this.GodMode = new MetroFramework.Controls.MetroCheckBox();
            this.Reach = new MetroFramework.Controls.MetroLabel();
            this.SprintingSpeedScale = new MetroFramework.Controls.MetroLabel();
            this.DeadMauFiveMode = new MetroFramework.Controls.MetroCheckBox();
            this.ArmorHUD = new MetroFramework.Controls.MetroCheckBox();
            this.TakeEverythingAnywhere = new MetroFramework.Controls.MetroCheckBox();
            this.FieldOfView = new MetroFramework.Controls.MetroLabel();
            this.HiddenGameModesUnlocked = new MetroFramework.Controls.MetroCheckBox();
            this.HitBoxScale = new MetroFramework.Controls.MetroLabel();
            this.CraftingTableAnywhere = new MetroFramework.Controls.MetroCheckBox();
            this.VisibleHitboxes = new MetroFramework.Controls.MetroCheckBox();
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
            this.BypassInvulnerability = new MetroFramework.Controls.MetroCheckBox();
            this.WearAnything = new MetroFramework.Controls.MetroCheckBox();
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
            this.Flight = new MetroFramework.Controls.MetroCheckBox();
            this.DisableSuffocating = new MetroFramework.Controls.MetroCheckBox();
            this.NoFallDamage = new MetroFramework.Controls.MetroCheckBox();
            this.CraftAnything = new MetroFramework.Controls.MetroCheckBox();
            this.CreativeMode = new MetroFramework.Controls.MetroCheckBox();
            this.worldTab = new MetroFramework.Controls.MetroTabPage();
            this.BubbleColumnAnywhere = new MetroFramework.Controls.MetroCheckBox();
            this.FogDistanceSlider = new System.Windows.Forms.NumericUpDown();
            this.FogDistance = new MetroFramework.Controls.MetroLabel();
            this.EntityEditorBtn = new MetroFramework.Controls.MetroButton();
            this.ThunderMode = new MetroFramework.Controls.MetroCheckBox();
            this.RainMode = new MetroFramework.Controls.MetroCheckBox();
            this.WorldGenerationOptsBtn = new MetroFramework.Controls.MetroButton();
            this.Collision = new MetroFramework.Controls.MetroCheckBox();
            this.DisableFallingBlocks = new MetroFramework.Controls.MetroCheckBox();
            this.LiquidSpreadTimeSlider = new System.Windows.Forms.NumericUpDown();
            this.LiquidSpreadTime = new MetroFramework.Controls.MetroLabel();
            this.InvulnerableEntities = new MetroFramework.Controls.MetroCheckBox();
            this.SleepingDoesntClearWeather = new MetroFramework.Controls.MetroCheckBox();
            this.EntitySpeedSlider = new System.Windows.Forms.NumericUpDown();
            this.EntitySpeed = new MetroFramework.Controls.MetroLabel();
            this.SuperFurnace = new MetroFramework.Controls.MetroCheckBox();
            this.WaterLogAnything = new MetroFramework.Controls.MetroCheckBox();
            this.LootTableEditorBtn = new MetroFramework.Controls.MetroButton();
            this.LeashAnyMobs = new MetroFramework.Controls.MetroCheckBox();
            this.SunProofMobs = new MetroFramework.Controls.MetroCheckBox();
            this.DisableCreativeFlag = new MetroFramework.Controls.MetroCheckBox();
            this.ZombieTower = new MetroFramework.Controls.MetroCheckBox();
            this.Entities = new MetroFramework.Controls.MetroLabel();
            this.IgnitedCreepers = new MetroFramework.Controls.MetroCheckBox();
            this.SuperchargedCreepers = new MetroFramework.Controls.MetroCheckBox();
            this.UncapEntitySpawnLimit = new MetroFramework.Controls.MetroCheckBox();
            this.AcidLiquidBlocks = new MetroFramework.Controls.MetroCheckBox();
            this.World = new MetroFramework.Controls.MetroLabel();
            this.FoggyWeather = new MetroFramework.Controls.MetroCheckBox();
            this.worldPnl = new MetroFramework.Controls.MetroPanel();
            this.StaticLiquidBlocks = new MetroFramework.Controls.MetroCheckBox();
            this.NoFog = new MetroFramework.Controls.MetroCheckBox();
            this.generalTab = new MetroFramework.Controls.MetroTabPage();
            this.KeyboardCustomizerBtn = new MetroFramework.Controls.MetroButton();
            this.DebugConsoleCustomizerBtn = new MetroFramework.Controls.MetroButton();
            this.CursedSlider = new System.Windows.Forms.NumericUpDown();
            this.CursedLbl = new MetroFramework.Controls.MetroLabel();
            this.DLCManagerBtn = new MetroFramework.Controls.MetroButton();
            this.PreventBeingKicked = new MetroFramework.Controls.MetroCheckBox();
            this.Cursed = new MetroFramework.Controls.MetroCheckBox();
            this.FreezeGameWhenPaused = new MetroFramework.Controls.MetroCheckBox();
            this.AchievementsEverywhere = new MetroFramework.Controls.MetroCheckBox();
            this.MuteMicrophone = new MetroFramework.Controls.MetroCheckBox();
            this.AchievementEditor = new MetroFramework.Controls.MetroButton();
            this.UnlockSignKeyboard = new MetroFramework.Controls.MetroCheckBox();
            this.DebugConsole = new MetroFramework.Controls.MetroCheckBox();
            this.Game = new MetroFramework.Controls.MetroLabel();
            this.UIUserInterface = new MetroFramework.Controls.MetroLabel();
            this.generalPanel = new MetroFramework.Controls.MetroPanel();
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
            this.MinigamesTab = new MetroFramework.Controls.MetroTabPage();
            this.MinigamesTabs = new MetroFramework.Controls.MetroTabControl();
            this.GeneralMinigames = new MetroFramework.Controls.MetroTabPage();
            this.Solo = new MetroFramework.Controls.MetroCheckBox();
            this.LiquidsCanConvert = new MetroFramework.Controls.MetroCheckBox();
            this.AllowMobs = new MetroFramework.Controls.MetroCheckBox();
            this.NoPosLock = new MetroFramework.Controls.MetroCheckBox();
            this.SqueakInfinitely = new MetroFramework.Controls.MetroCheckBox();
            this.RequiredPlayersSlider = new System.Windows.Forms.NumericUpDown();
            this.RequiredPlayers = new MetroFramework.Controls.MetroLabel();
            this.AllPermissions = new MetroFramework.Controls.MetroCheckBox();
            this.AlwaysDamaged = new MetroFramework.Controls.MetroCheckBox();
            this.TNTGriefing = new MetroFramework.Controls.MetroCheckBox();
            this.DisabledKillBarriers = new MetroFramework.Controls.MetroCheckBox();
            this.Battle = new MetroFramework.Controls.MetroTabPage();
            this.MapSizeBox = new MetroFramework.Controls.MetroComboBox();
            this.MapSizeLbl = new MetroFramework.Controls.MetroLabel();
            this.EndGame = new MetroFramework.Controls.MetroButton();
            this.RefillInterval = new MetroFramework.Controls.MetroLabel();
            this.RefillIntervalSlider = new System.Windows.Forms.NumericUpDown();
            this.AntiEndGame = new MetroFramework.Controls.MetroCheckBox();
            this.Tumble = new MetroFramework.Controls.MetroTabPage();
            this.DisableCameraAnimation = new MetroFramework.Controls.MetroCheckBox();
            this.UnlockInventoty = new MetroFramework.Controls.MetroCheckBox();
            this.TumbleHUD = new MetroFramework.Controls.MetroCheckBox();
            this.Glide = new MetroFramework.Controls.MetroTabPage();
            this.ringScoreB = new MetroFramework.Controls.MetroLabel();
            this.ringScoreBlue = new System.Windows.Forms.NumericUpDown();
            this.ringScoreO = new MetroFramework.Controls.MetroLabel();
            this.ringScoreOrange = new System.Windows.Forms.NumericUpDown();
            this.ringScoreG = new MetroFramework.Controls.MetroLabel();
            this.ringScoreGreen = new System.Windows.Forms.NumericUpDown();
            this.commandsTab = new MetroFramework.Controls.MetroTabPage();
            this.CommandsWarnLbl = new MetroFramework.Controls.MetroLabel();
            this.CommandsInMinigames = new MetroFramework.Controls.MetroCheckBox();
            this.tellrawLbl = new MetroFramework.Controls.MetroLabel();
            this.tellrawPanel = new MetroFramework.Controls.MetroPanel();
            this.tellStyleLbl = new MetroFramework.Controls.MetroLabel();
            this.customTellBox = new MetroFramework.Controls.MetroRadioButton();
            this.javaTellBox = new MetroFramework.Controls.MetroRadioButton();
            this.bedrockTellBox = new MetroFramework.Controls.MetroRadioButton();
            this.tellMsgBox = new MetroFramework.Controls.MetroTextBox();
            this.tellrawCmdBtn = new MetroFramework.Controls.MetroButton();
            this.tellNameBox = new MetroFramework.Controls.MetroTextBox();
            this.xpCmdLbl = new MetroFramework.Controls.MetroLabel();
            this.xpPanel = new MetroFramework.Controls.MetroPanel();
            this.giveXPLevelsBtn = new MetroFramework.Controls.MetroButton();
            this.giveXPOrbsBtn = new MetroFramework.Controls.MetroButton();
            this.xpAmountBox = new MetroFramework.Controls.MetroTextBox();
            this.gamemodeCmdLbl = new MetroFramework.Controls.MetroLabel();
            this.gamemodePanel = new MetroFramework.Controls.MetroPanel();
            this.SpectatorCommandBtn = new MetroFramework.Controls.MetroButton();
            this.AdventureCommandBtn = new MetroFramework.Controls.MetroButton();
            this.CreativeCommandBtn = new MetroFramework.Controls.MetroButton();
            this.SurvivalCommandBtn = new MetroFramework.Controls.MetroButton();
            this.worldCmdLbl = new MetroFramework.Controls.MetroLabel();
            this.worldPanel = new MetroFramework.Controls.MetroPanel();
            this.setWorldSpawnBtn = new MetroFramework.Controls.MetroButton();
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
            this.TipsBtn = new MetroFramework.Controls.MetroButton();
            this.TutorialBtn = new MetroFramework.Controls.MetroButton();
            this.SeasonalThemes = new MetroFramework.Controls.MetroCheckBox();
            this.TextAllignBox = new MetroFramework.Controls.MetroComboBox();
            this.TextAllignLbl = new MetroFramework.Controls.MetroLabel();
            this.HostIndicators = new MetroFramework.Controls.MetroCheckBox();
            this.CemuPckMngrBtn = new MetroFramework.Controls.MetroButton();
            this.QuickModsManagerBtn = new MetroFramework.Controls.MetroButton();
            this.OpenLangMngrBtn = new MetroFramework.Controls.MetroButton();
            this.CheckForPreRelease = new MetroFramework.Controls.MetroCheckBox();
            this.settingsLogo = new MetroFramework.Controls.MetroPanel();
            this.updateBtn = new MetroFramework.Controls.MetroButton();
            this.discordRpcCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.ColorsBox = new MetroFramework.Controls.MetroComboBox();
            this.ColorLabel = new MetroFramework.Controls.MetroLabel();
            this.GlideTile = new MetroFramework.Controls.MetroTile();
            this.TumbleTile = new MetroFramework.Controls.MetroTile();
            this.BattleTile = new MetroFramework.Controls.MetroTile();
            this.GeneralMgTile = new MetroFramework.Controls.MetroTile();
            this.HomeTile = new MetroFramework.Controls.MetroTile();
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.StyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.ToolTipManager = new MetroFramework.Components.MetroToolTip();
            this.PlayersTile = new MetroFramework.Controls.MetroTile();
            this.CommandsTile = new MetroFramework.Controls.MetroTile();
            this.RightClickMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.IncreaseDecimalPlace = new System.Windows.Forms.ToolStripMenuItem();
            this.DecreaseDecimalPlace = new System.Windows.Forms.ToolStripMenuItem();
            this.NavMenuPnl = new MetroFramework.Controls.MetroPanel();
            this.NavMenuMgPnl = new MetroFramework.Controls.MetroPanel();
            this.MainTabs.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.playersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AirborneSpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterDownStrengthSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxStackSlider)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.FogDistanceSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiquidSpreadTimeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntitySpeedSlider)).BeginInit();
            this.generalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CursedSlider)).BeginInit();
            this.MinigamesTab.SuspendLayout();
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
            this.tellrawPanel.SuspendLayout();
            this.xpPanel.SuspendLayout();
            this.gamemodePanel.SuspendLayout();
            this.worldPanel.SuspendLayout();
            this.playerPanel.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.enchantPanel.SuspendLayout();
            this.giveCommandPanel.SuspendLayout();
            this.settingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.RightClickMenu.SuspendLayout();
            this.NavMenuPnl.SuspendLayout();
            this.NavMenuMgPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorldTile
            // 
            this.WorldTile.ActiveControl = null;
            this.WorldTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorldTile.Location = new System.Drawing.Point(0, 110);
            this.WorldTile.Name = "WorldTile";
            this.WorldTile.PaintTileCount = false;
            this.WorldTile.Size = new System.Drawing.Size(159, 55);
            this.WorldTile.TabIndex = 3;
            this.WorldTile.Tag = "";
            this.WorldTile.Text = "World and Entities";
            this.WorldTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WorldTile.TileCount = 2;
            this.WorldTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.WorldTile.UseSelectable = true;
            this.WorldTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // GeneralTile
            // 
            this.GeneralTile.ActiveControl = null;
            this.GeneralTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneralTile.Location = new System.Drawing.Point(0, 165);
            this.GeneralTile.Name = "GeneralTile";
            this.GeneralTile.PaintTileCount = false;
            this.GeneralTile.Size = new System.Drawing.Size(159, 55);
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
            this.MinigamesTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.MinigamesTile.Location = new System.Drawing.Point(0, 220);
            this.MinigamesTile.Name = "MinigamesTile";
            this.MinigamesTile.PaintTileCount = false;
            this.MinigamesTile.Size = new System.Drawing.Size(159, 55);
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
            this.SettingsTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsTile.Location = new System.Drawing.Point(0, 489);
            this.SettingsTile.Name = "SettingsTile";
            this.SettingsTile.PaintTileCount = false;
            this.SettingsTile.Size = new System.Drawing.Size(159, 55);
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
            this.BuildTile.AutoSize = true;
            this.BuildTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuildTile.Enabled = false;
            this.BuildTile.Location = new System.Drawing.Point(0, 544);
            this.BuildTile.Name = "BuildTile";
            this.BuildTile.PaintTileCount = false;
            this.BuildTile.Size = new System.Drawing.Size(159, 97);
            this.BuildTile.TabIndex = 6;
            this.BuildTile.Text = "v0.0.0.chprq";
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
            this.MainTabs.Controls.Add(this.MinigamesTab);
            this.MainTabs.Controls.Add(this.commandsTab);
            this.MainTabs.Controls.Add(this.settingsTab);
            this.MainTabs.ItemSize = new System.Drawing.Size(160, 5);
            this.MainTabs.Location = new System.Drawing.Point(155, 58);
            this.MainTabs.Multiline = true;
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 1;
            this.MainTabs.Size = new System.Drawing.Size(1130, 643);
            this.MainTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabs.TabIndex = 0;
            this.MainTabs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainTabs.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.MainTab.Controls.Add(this.WiiUIPv4Box);
            this.MainTab.Controls.Add(this.WiiUIpv4Lbl);
            this.MainTab.HorizontalScrollbarBarColor = true;
            this.MainTab.HorizontalScrollbarHighlightOnWheel = false;
            this.MainTab.HorizontalScrollbarSize = 10;
            this.MainTab.Location = new System.Drawing.Point(4, 9);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(1122, 630);
            this.MainTab.TabIndex = 6;
            this.MainTab.Text = "Home";
            this.MainTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainTab.VerticalScrollbarBarColor = true;
            this.MainTab.VerticalScrollbarHighlightOnWheel = false;
            this.MainTab.VerticalScrollbarSize = 10;
            // 
            // SetupTutorialBtn
            // 
            this.SetupTutorialBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetupTutorialBtn.Location = new System.Drawing.Point(541, 594);
            this.SetupTutorialBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SetupTutorialBtn.Name = "SetupTutorialBtn";
            this.SetupTutorialBtn.Size = new System.Drawing.Size(210, 23);
            this.SetupTutorialBtn.TabIndex = 47;
            this.SetupTutorialBtn.Text = "Setup Tutorial";
            this.SetupTutorialBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SetupTutorialBtn, "View the setup tutorial");
            this.SetupTutorialBtn.UseSelectable = true;
            this.SetupTutorialBtn.Click += new System.EventHandler(this.SetupTutorialBtnClicked);
            // 
            // FaqBtn
            // 
            this.FaqBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FaqBtn.Location = new System.Drawing.Point(84, 594);
            this.FaqBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FaqBtn.Name = "FaqBtn";
            this.FaqBtn.Size = new System.Drawing.Size(210, 23);
            this.FaqBtn.TabIndex = 46;
            this.FaqBtn.Text = "FAQ - Information";
            this.FaqBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.BuildNotesBox.CustomButton.Location = new System.Drawing.Point(585, 1);
            this.BuildNotesBox.CustomButton.Name = "";
            this.BuildNotesBox.CustomButton.Size = new System.Drawing.Size(523, 523);
            this.BuildNotesBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BuildNotesBox.CustomButton.TabIndex = 1;
            this.BuildNotesBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BuildNotesBox.CustomButton.UseSelectable = true;
            this.BuildNotesBox.CustomButton.Visible = false;
            this.BuildNotesBox.Lines = new string[] {
        "Fetching patch notes for version v0.0.0.chprq"};
            this.BuildNotesBox.Location = new System.Drawing.Point(6, 31);
            this.BuildNotesBox.MaxLength = 32767;
            this.BuildNotesBox.Multiline = true;
            this.BuildNotesBox.Name = "BuildNotesBox";
            this.BuildNotesBox.PasswordChar = '\0';
            this.BuildNotesBox.ReadOnly = true;
            this.BuildNotesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BuildNotesBox.SelectedText = "";
            this.BuildNotesBox.SelectionLength = 0;
            this.BuildNotesBox.SelectionStart = 0;
            this.BuildNotesBox.ShortcutsEnabled = true;
            this.BuildNotesBox.Size = new System.Drawing.Size(1109, 525);
            this.BuildNotesBox.TabIndex = 8;
            this.BuildNotesBox.Text = "Fetching patch notes for version v0.0.0.chprq";
            this.BuildNotesBox.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.BuildVerTitleLbl.Size = new System.Drawing.Size(236, 25);
            this.BuildVerTitleLbl.TabIndex = 6;
            this.BuildVerTitleLbl.Text = "Patch Notes for v0.0.0.chprq";
            this.BuildVerTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuildVerTitleLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CreditsBtn
            // 
            this.CreditsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreditsBtn.Location = new System.Drawing.Point(302, 594);
            this.CreditsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreditsBtn.Name = "CreditsBtn";
            this.CreditsBtn.Size = new System.Drawing.Size(210, 23);
            this.CreditsBtn.TabIndex = 42;
            this.CreditsBtn.Text = "Credits";
            this.CreditsBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.CreditsBtn, "View the credits for the Mod Injector");
            this.CreditsBtn.UseSelectable = true;
            this.CreditsBtn.Click += new System.EventHandler(this.CreditsBtnClicked);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(975, 562);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(140, 23);
            this.ConnectBtn.TabIndex = 4;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.ConnectBtn, "Connects to your Wii U using the IPv4 provided");
            this.ConnectBtn.UseSelectable = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtnClicked);
            // 
            // DiscordSrvBtn
            // 
            this.DiscordSrvBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DiscordSrvBtn.Location = new System.Drawing.Point(759, 594);
            this.DiscordSrvBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DiscordSrvBtn.Name = "DiscordSrvBtn";
            this.DiscordSrvBtn.Size = new System.Drawing.Size(210, 23);
            this.DiscordSrvBtn.TabIndex = 32;
            this.DiscordSrvBtn.Text = "Discord Server";
            this.DiscordSrvBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DiscordSrvBtn, "Will take you to the official Discord server for the Mod Injector");
            this.DiscordSrvBtn.UseSelectable = true;
            this.DiscordSrvBtn.Click += new System.EventHandler(this.DiscordSrvBtnClicked);
            // 
            // WiiUIPv4Box
            // 
            // 
            // 
            // 
            this.WiiUIPv4Box.CustomButton.Image = null;
            this.WiiUIPv4Box.CustomButton.Location = new System.Drawing.Point(863, 1);
            this.WiiUIPv4Box.CustomButton.Name = "";
            this.WiiUIPv4Box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.WiiUIPv4Box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.WiiUIPv4Box.CustomButton.TabIndex = 1;
            this.WiiUIPv4Box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WiiUIPv4Box.CustomButton.UseSelectable = true;
            this.WiiUIPv4Box.CustomButton.Visible = false;
            this.WiiUIPv4Box.Lines = new string[0];
            this.WiiUIPv4Box.Location = new System.Drawing.Point(84, 562);
            this.WiiUIPv4Box.MaxLength = 32767;
            this.WiiUIPv4Box.Name = "WiiUIPv4Box";
            this.WiiUIPv4Box.PasswordChar = '\0';
            this.WiiUIPv4Box.PromptText = "Your Wii U\'s IPv4 address (Seen in the TCP Gecko Installer)";
            this.WiiUIPv4Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WiiUIPv4Box.SelectedText = "";
            this.WiiUIPv4Box.SelectionLength = 0;
            this.WiiUIPv4Box.SelectionStart = 0;
            this.WiiUIPv4Box.ShortcutsEnabled = true;
            this.WiiUIPv4Box.Size = new System.Drawing.Size(885, 23);
            this.WiiUIPv4Box.TabIndex = 3;
            this.WiiUIPv4Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WiiUIPv4Box.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WiiUIPv4Box.UseSelectable = true;
            this.WiiUIPv4Box.WaterMark = "Your Wii U\'s IPv4 address (Seen in the TCP Gecko Installer)";
            this.WiiUIPv4Box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WiiUIPv4Box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.WiiUIPv4Box.TextChanged += new System.EventHandler(this.CaptureWiiUiPv4Box);
            this.WiiUIPv4Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureWiiUiPv4BoxInput);
            // 
            // WiiUIpv4Lbl
            // 
            this.WiiUIpv4Lbl.AutoSize = true;
            this.WiiUIpv4Lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.WiiUIpv4Lbl.Location = new System.Drawing.Point(6, 562);
            this.WiiUIpv4Lbl.Name = "WiiUIpv4Lbl";
            this.WiiUIpv4Lbl.Size = new System.Drawing.Size(76, 19);
            this.WiiUIpv4Lbl.TabIndex = 2;
            this.WiiUIpv4Lbl.Text = "Wii U IPv4:";
            this.WiiUIpv4Lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // playersTab
            // 
            this.playersTab.Controls.Add(this.InstantSleep);
            this.playersTab.Controls.Add(this.NoCooldowns);
            this.playersTab.Controls.Add(this.defPotionBox);
            this.playersTab.Controls.Add(this.DefaultPotionEffect);
            this.playersTab.Controls.Add(this.AlwaysDaylight);
            this.playersTab.Controls.Add(this.AirborneSpeedSlider);
            this.playersTab.Controls.Add(this.AirborneSpeed);
            this.playersTab.Controls.Add(this.PunchToRide);
            this.playersTab.Controls.Add(this.UnlimitedTotemsOfUndying);
            this.playersTab.Controls.Add(this.SplashLingeringPotions);
            this.playersTab.Controls.Add(this.EffectsLastForever);
            this.playersTab.Controls.Add(this.ItemOfUndying);
            this.playersTab.Controls.Add(this.NoDamage);
            this.playersTab.Controls.Add(this.WaterDownStrengthSlider);
            this.playersTab.Controls.Add(this.WaterDownStrength);
            this.playersTab.Controls.Add(this.breatheBox);
            this.playersTab.Controls.Add(this.BreathingModeLbl);
            this.playersTab.Controls.Add(this.BreakBedrock);
            this.playersTab.Controls.Add(this.SwimFast);
            this.playersTab.Controls.Add(this.BreakAnything);
            this.playersTab.Controls.Add(this.AirJump);
            this.playersTab.Controls.Add(this.LeftHanded);
            this.playersTab.Controls.Add(this.MaxStackSlider);
            this.playersTab.Controls.Add(this.MaxStack);
            this.playersTab.Controls.Add(this.UnlimitedEnchants);
            this.playersTab.Controls.Add(this.EnchantmentEditorBtn);
            this.playersTab.Controls.Add(this.Invisible);
            this.playersTab.Controls.Add(this.PotionAmplifierSlider);
            this.playersTab.Controls.Add(this.FrictionSlider);
            this.playersTab.Controls.Add(this.playerModelScaleSlider);
            this.playersTab.Controls.Add(this.FieldOfViewSplitSlider);
            this.playersTab.Controls.Add(this.RiptideFlyingSpeedSlider);
            this.playersTab.Controls.Add(this.SprintingSpeedScaleSlider);
            this.playersTab.Controls.Add(this.EnchantmentLevelSlider);
            this.playersTab.Controls.Add(this.WalkingSpeedScaleSlider);
            this.playersTab.Controls.Add(this.ReachSlider);
            this.playersTab.Controls.Add(this.JumpHeightSlider);
            this.playersTab.Controls.Add(this.FieldOfViewSlider);
            this.playersTab.Controls.Add(this.HitBoxScaleSlider);
            this.playersTab.Controls.Add(this.PlayerOptionsBtn);
            this.playersTab.Controls.Add(this.PotionAmplifier);
            this.playersTab.Controls.Add(this.NoSlowDowns);
            this.playersTab.Controls.Add(this.ESP);
            this.playersTab.Controls.Add(this.AlwaysInWater);
            this.playersTab.Controls.Add(this.LevelX);
            this.playersTab.Controls.Add(this.SeeThroughBlocks);
            this.playersTab.Controls.Add(this.AlwaysInLava);
            this.playersTab.Controls.Add(this.HideBlocks);
            this.playersTab.Controls.Add(this.UnderwaterEffects);
            this.playersTab.Controls.Add(this.EnchantmentLevel);
            this.playersTab.Controls.Add(this.Friction);
            this.playersTab.Controls.Add(this.GodModeAll);
            this.playersTab.Controls.Add(this.FieldofViewSplitscreen);
            this.playersTab.Controls.Add(this.RiptideFlyingSpeed);
            this.playersTab.Controls.Add(this.PlayerModelScale);
            this.playersTab.Controls.Add(this.JumpHeight);
            this.playersTab.Controls.Add(this.WalkingSpeedScale);
            this.playersTab.Controls.Add(this.GodMode);
            this.playersTab.Controls.Add(this.Reach);
            this.playersTab.Controls.Add(this.SprintingSpeedScale);
            this.playersTab.Controls.Add(this.DeadMauFiveMode);
            this.playersTab.Controls.Add(this.ArmorHUD);
            this.playersTab.Controls.Add(this.TakeEverythingAnywhere);
            this.playersTab.Controls.Add(this.FieldOfView);
            this.playersTab.Controls.Add(this.HiddenGameModesUnlocked);
            this.playersTab.Controls.Add(this.HitBoxScale);
            this.playersTab.Controls.Add(this.CraftingTableAnywhere);
            this.playersTab.Controls.Add(this.VisibleHitboxes);
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
            this.playersTab.Controls.Add(this.BypassInvulnerability);
            this.playersTab.Controls.Add(this.WearAnything);
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
            this.playersTab.Controls.Add(this.Flight);
            this.playersTab.Controls.Add(this.DisableSuffocating);
            this.playersTab.Controls.Add(this.NoFallDamage);
            this.playersTab.Controls.Add(this.CraftAnything);
            this.playersTab.Controls.Add(this.CreativeMode);
            this.playersTab.HorizontalScrollbarBarColor = true;
            this.playersTab.HorizontalScrollbarHighlightOnWheel = false;
            this.playersTab.HorizontalScrollbarSize = 10;
            this.playersTab.Location = new System.Drawing.Point(4, 9);
            this.playersTab.Name = "playersTab";
            this.playersTab.Padding = new System.Windows.Forms.Padding(3);
            this.playersTab.Size = new System.Drawing.Size(1122, 630);
            this.playersTab.TabIndex = 0;
            this.playersTab.Tag = "GeckoURequired";
            this.playersTab.Text = "Player(s) and Item(s)";
            this.playersTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.playersTab.VerticalScrollbarBarColor = true;
            this.playersTab.VerticalScrollbarHighlightOnWheel = false;
            this.playersTab.VerticalScrollbarSize = 10;
            // 
            // InstantSleep
            // 
            this.InstantSleep.AutoSize = true;
            this.InstantSleep.Location = new System.Drawing.Point(565, 89);
            this.InstantSleep.Name = "InstantSleep";
            this.InstantSleep.Size = new System.Drawing.Size(90, 15);
            this.InstantSleep.Style = MetroFramework.MetroColorStyle.Orange;
            this.InstantSleep.TabIndex = 189;
            this.InstantSleep.Tag = "Host";
            this.InstantSleep.Text = "Instant Sleep";
            this.InstantSleep.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.InstantSleep, "Skips the animation for sleeping");
            this.InstantSleep.UseSelectable = true;
            this.InstantSleep.UseStyleColors = true;
            this.InstantSleep.CheckedChanged += new System.EventHandler(this.InstantSleepToggled);
            // 
            // NoCooldowns
            // 
            this.NoCooldowns.AutoSize = true;
            this.NoCooldowns.Location = new System.Drawing.Point(565, 68);
            this.NoCooldowns.Name = "NoCooldowns";
            this.NoCooldowns.Size = new System.Drawing.Size(102, 15);
            this.NoCooldowns.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoCooldowns.TabIndex = 189;
            this.NoCooldowns.Tag = "NonHost";
            this.NoCooldowns.Text = "No Cooldowns";
            this.NoCooldowns.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.NoCooldowns, "Disables the cooldown for items such as Ender Pearls or Chorus Fruit.");
            this.NoCooldowns.UseSelectable = true;
            this.NoCooldowns.UseStyleColors = true;
            this.NoCooldowns.CheckedChanged += new System.EventHandler(this.NoCooldownsToggled);
            // 
            // defPotionBox
            // 
            this.defPotionBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.defPotionBox.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.defPotionBox.FormattingEnabled = true;
            this.defPotionBox.ItemHeight = 19;
            this.defPotionBox.Items.AddRange(new object[] {
            "None",
            "Speed",
            "Slowness",
            "Haste",
            "Mining Fatigue",
            "Strenght",
            "None",
            "None",
            "Jump Boost",
            "Nausea",
            "Regeneration",
            "Resistance",
            "Fire Resistance",
            "Water Breathing",
            "Invisibility",
            "Blindness",
            "Night Vision",
            "Hunger",
            "Weakness",
            "Posion",
            "Wither",
            "Health Boost",
            "Absorption",
            "None",
            "Glowing",
            "Levitation",
            "Luck",
            "Bad Luck",
            "Slow Falling"});
            this.defPotionBox.Location = new System.Drawing.Point(931, 499);
            this.defPotionBox.Name = "defPotionBox";
            this.defPotionBox.Size = new System.Drawing.Size(183, 25);
            this.defPotionBox.TabIndex = 188;
            this.defPotionBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.defPotionBox, "What effect will ALL potions default to?");
            this.defPotionBox.UseSelectable = true;
            this.defPotionBox.SelectedIndexChanged += new System.EventHandler(this.DefPotionBoxChanged);
            // 
            // DefaultPotionEffect
            // 
            this.DefaultPotionEffect.AutoSize = true;
            this.DefaultPotionEffect.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.DefaultPotionEffect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DefaultPotionEffect.Location = new System.Drawing.Point(789, 499);
            this.DefaultPotionEffect.Name = "DefaultPotionEffect";
            this.DefaultPotionEffect.Size = new System.Drawing.Size(136, 19);
            this.DefaultPotionEffect.Style = MetroFramework.MetroColorStyle.Blue;
            this.DefaultPotionEffect.TabIndex = 187;
            this.DefaultPotionEffect.Tag = "NonHost";
            this.DefaultPotionEffect.Text = "Default Potion Effect:";
            this.DefaultPotionEffect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DefaultPotionEffect.UseStyleColors = true;
            // 
            // AlwaysDaylight
            // 
            this.AlwaysDaylight.AutoSize = true;
            this.AlwaysDaylight.BackColor = System.Drawing.Color.Transparent;
            this.AlwaysDaylight.Location = new System.Drawing.Point(565, 47);
            this.AlwaysDaylight.Name = "AlwaysDaylight";
            this.AlwaysDaylight.Size = new System.Drawing.Size(107, 15);
            this.AlwaysDaylight.Style = MetroFramework.MetroColorStyle.Blue;
            this.AlwaysDaylight.TabIndex = 186;
            this.AlwaysDaylight.Tag = "NonHost";
            this.AlwaysDaylight.Text = "Always Daylight";
            this.AlwaysDaylight.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AlwaysDaylight, "Natural lighting will always treated as\r\nif it were daylight");
            this.AlwaysDaylight.UseSelectable = true;
            this.AlwaysDaylight.UseStyleColors = true;
            this.AlwaysDaylight.CheckedChanged += new System.EventHandler(this.AlwaysDaylightToggled);
            // 
            // AirborneSpeedSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.AirborneSpeedSlider, true);
            this.AirborneSpeedSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.AirborneSpeedSlider.DecimalPlaces = 1;
            this.AirborneSpeedSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AirborneSpeedSlider.Location = new System.Drawing.Point(666, 519);
            this.AirborneSpeedSlider.Name = "AirborneSpeedSlider";
            this.AirborneSpeedSlider.Size = new System.Drawing.Size(115, 20);
            this.AirborneSpeedSlider.TabIndex = 185;
            this.AirborneSpeedSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.AirborneSpeedSlider, "How much faster do we go down in water while\r\npressing crouch?");
            this.AirborneSpeedSlider.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.AirborneSpeedSlider.ValueChanged += new System.EventHandler(this.AirborneSpeedSliderChanged);
            // 
            // AirborneSpeed
            // 
            this.AirborneSpeed.AutoSize = true;
            this.AirborneSpeed.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.AirborneSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AirborneSpeed.Location = new System.Drawing.Point(554, 520);
            this.AirborneSpeed.Name = "AirborneSpeed";
            this.AirborneSpeed.Size = new System.Drawing.Size(106, 19);
            this.AirborneSpeed.Style = MetroFramework.MetroColorStyle.Blue;
            this.AirborneSpeed.TabIndex = 184;
            this.AirborneSpeed.Tag = "NonHost";
            this.AirborneSpeed.Text = "Airborne Speed:";
            this.AirborneSpeed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AirborneSpeed.UseStyleColors = true;
            // 
            // PunchToRide
            // 
            this.PunchToRide.AutoSize = true;
            this.PunchToRide.BackColor = System.Drawing.Color.Transparent;
            this.PunchToRide.Location = new System.Drawing.Point(565, 27);
            this.PunchToRide.Name = "PunchToRide";
            this.PunchToRide.Size = new System.Drawing.Size(97, 15);
            this.PunchToRide.Style = MetroFramework.MetroColorStyle.Blue;
            this.PunchToRide.TabIndex = 183;
            this.PunchToRide.Tag = "NonHost";
            this.PunchToRide.Text = "Punch to Ride";
            this.PunchToRide.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.PunchToRide, "Allows you to ride any entity by punching them\r\nWARNING: Can be very buggy");
            this.PunchToRide.UseSelectable = true;
            this.PunchToRide.UseStyleColors = true;
            this.PunchToRide.CheckedChanged += new System.EventHandler(this.PunchToRideToggled);
            // 
            // UnlimitedTotemsOfUndying
            // 
            this.UnlimitedTotemsOfUndying.AutoSize = true;
            this.UnlimitedTotemsOfUndying.Location = new System.Drawing.Point(379, 405);
            this.UnlimitedTotemsOfUndying.Name = "UnlimitedTotemsOfUndying";
            this.UnlimitedTotemsOfUndying.Size = new System.Drawing.Size(178, 15);
            this.UnlimitedTotemsOfUndying.Style = MetroFramework.MetroColorStyle.Orange;
            this.UnlimitedTotemsOfUndying.TabIndex = 182;
            this.UnlimitedTotemsOfUndying.Tag = "Host";
            this.UnlimitedTotemsOfUndying.Text = "Unlimited Totems of Undying";
            this.UnlimitedTotemsOfUndying.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.UnlimitedTotemsOfUndying, "Totems of Undying will not be depleted upon death");
            this.UnlimitedTotemsOfUndying.UseSelectable = true;
            this.UnlimitedTotemsOfUndying.UseStyleColors = true;
            this.UnlimitedTotemsOfUndying.CheckedChanged += new System.EventHandler(this.UnlimitedTotemsOfUndyingToggled);
            // 
            // SplashLingeringPotions
            // 
            this.SplashLingeringPotions.AutoSize = true;
            this.SplashLingeringPotions.BackColor = System.Drawing.Color.Transparent;
            this.SplashLingeringPotions.Location = new System.Drawing.Point(565, 6);
            this.SplashLingeringPotions.Name = "SplashLingeringPotions";
            this.SplashLingeringPotions.Size = new System.Drawing.Size(153, 15);
            this.SplashLingeringPotions.Style = MetroFramework.MetroColorStyle.Orange;
            this.SplashLingeringPotions.TabIndex = 181;
            this.SplashLingeringPotions.Tag = "Host";
            this.SplashLingeringPotions.Text = "Splash Lingering Potions";
            this.SplashLingeringPotions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SplashLingeringPotions, "Splash potions will treated as\r\nlingering potions");
            this.SplashLingeringPotions.UseSelectable = true;
            this.SplashLingeringPotions.UseStyleColors = true;
            this.SplashLingeringPotions.CheckedChanged += new System.EventHandler(this.SplashLingeringPotionsToggled);
            // 
            // EffectsLastForever
            // 
            this.EffectsLastForever.AutoSize = true;
            this.EffectsLastForever.BackColor = System.Drawing.Color.Transparent;
            this.EffectsLastForever.Location = new System.Drawing.Point(192, 111);
            this.EffectsLastForever.Name = "EffectsLastForever";
            this.EffectsLastForever.Size = new System.Drawing.Size(124, 15);
            this.EffectsLastForever.Style = MetroFramework.MetroColorStyle.Orange;
            this.EffectsLastForever.TabIndex = 180;
            this.EffectsLastForever.Tag = "Host";
            this.EffectsLastForever.Text = "Effects Last Forever";
            this.EffectsLastForever.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.EffectsLastForever, "Potion, Beacon and Mob Effects will never run out");
            this.EffectsLastForever.UseSelectable = true;
            this.EffectsLastForever.UseStyleColors = true;
            this.EffectsLastForever.CheckedChanged += new System.EventHandler(this.EffectsLastForeverToggled);
            // 
            // ItemOfUndying
            // 
            this.ItemOfUndying.AutoSize = true;
            this.ItemOfUndying.Location = new System.Drawing.Point(379, 384);
            this.ItemOfUndying.Name = "ItemOfUndying";
            this.ItemOfUndying.Size = new System.Drawing.Size(109, 15);
            this.ItemOfUndying.Style = MetroFramework.MetroColorStyle.Orange;
            this.ItemOfUndying.TabIndex = 179;
            this.ItemOfUndying.Tag = "Host";
            this.ItemOfUndying.Text = "Item of Undying";
            this.ItemOfUndying.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.ItemOfUndying, "Any item you hold will act as a Totem of Undying");
            this.ItemOfUndying.UseSelectable = true;
            this.ItemOfUndying.UseStyleColors = true;
            this.ItemOfUndying.CheckedChanged += new System.EventHandler(this.ItemOfUndyingToggled);
            // 
            // NoDamage
            // 
            this.NoDamage.AutoSize = true;
            this.NoDamage.Location = new System.Drawing.Point(379, 363);
            this.NoDamage.Name = "NoDamage";
            this.NoDamage.Size = new System.Drawing.Size(86, 15);
            this.NoDamage.Style = MetroFramework.MetroColorStyle.Orange;
            this.NoDamage.TabIndex = 178;
            this.NoDamage.Tag = "Host";
            this.NoDamage.Text = "No Damage";
            this.NoDamage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.NoDamage, "Disables all damage");
            this.NoDamage.UseSelectable = true;
            this.NoDamage.UseStyleColors = true;
            this.NoDamage.CheckedChanged += new System.EventHandler(this.NoDamageToggled);
            // 
            // WaterDownStrengthSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.WaterDownStrengthSlider, true);
            this.WaterDownStrengthSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.WaterDownStrengthSlider.DecimalPlaces = 3;
            this.WaterDownStrengthSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.WaterDownStrengthSlider.Location = new System.Drawing.Point(694, 492);
            this.WaterDownStrengthSlider.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.WaterDownStrengthSlider.Name = "WaterDownStrengthSlider";
            this.WaterDownStrengthSlider.Size = new System.Drawing.Size(87, 20);
            this.WaterDownStrengthSlider.TabIndex = 177;
            this.WaterDownStrengthSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.WaterDownStrengthSlider, "How much faster do we go down in water while\r\npressing crouch?");
            this.WaterDownStrengthSlider.Value = new decimal(new int[] {
            1285,
            0,
            0,
            196608});
            this.WaterDownStrengthSlider.ValueChanged += new System.EventHandler(this.WaterDownStrengthSliderChanged);
            this.WaterDownStrengthSlider.Click += new System.EventHandler(this.SliderClicked);
            // 
            // WaterDownStrength
            // 
            this.WaterDownStrength.AutoSize = true;
            this.WaterDownStrength.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.WaterDownStrength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WaterDownStrength.Location = new System.Drawing.Point(554, 493);
            this.WaterDownStrength.Name = "WaterDownStrength";
            this.WaterDownStrength.Size = new System.Drawing.Size(134, 19);
            this.WaterDownStrength.Style = MetroFramework.MetroColorStyle.Blue;
            this.WaterDownStrength.TabIndex = 176;
            this.WaterDownStrength.Tag = "NonHost";
            this.WaterDownStrength.Text = "Water Sink Strength:";
            this.WaterDownStrength.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WaterDownStrength.UseStyleColors = true;
            // 
            // breatheBox
            // 
            this.breatheBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.breatheBox.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.breatheBox.FormattingEnabled = true;
            this.breatheBox.ItemHeight = 19;
            this.breatheBox.Items.AddRange(new object[] {
            "Air",
            "Lava",
            "Blocks",
            "Water",
            "All",
            "None"});
            this.breatheBox.Location = new System.Drawing.Point(904, 468);
            this.breatheBox.Name = "breatheBox";
            this.breatheBox.Size = new System.Drawing.Size(210, 25);
            this.breatheBox.TabIndex = 175;
            this.breatheBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.breatheBox, "What type of blocks do we breathe in?");
            this.breatheBox.UseSelectable = true;
            this.breatheBox.SelectedIndexChanged += new System.EventHandler(this.BreatheBoxChanged);
            // 
            // BreathingModeLbl
            // 
            this.BreathingModeLbl.AutoSize = true;
            this.BreathingModeLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.BreathingModeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BreathingModeLbl.Location = new System.Drawing.Point(787, 468);
            this.BreathingModeLbl.Name = "BreathingModeLbl";
            this.BreathingModeLbl.Size = new System.Drawing.Size(111, 19);
            this.BreathingModeLbl.Style = MetroFramework.MetroColorStyle.Orange;
            this.BreathingModeLbl.TabIndex = 174;
            this.BreathingModeLbl.Tag = "Host";
            this.BreathingModeLbl.Text = "Breathing Mode:";
            this.BreathingModeLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BreathingModeLbl.UseStyleColors = true;
            // 
            // BreakBedrock
            // 
            this.BreakBedrock.AutoSize = true;
            this.BreakBedrock.Location = new System.Drawing.Point(379, 342);
            this.BreakBedrock.Name = "BreakBedrock";
            this.BreakBedrock.Size = new System.Drawing.Size(98, 15);
            this.BreakBedrock.Style = MetroFramework.MetroColorStyle.Blue;
            this.BreakBedrock.TabIndex = 172;
            this.BreakBedrock.Tag = "NonHost";
            this.BreakBedrock.Text = "Break Bedrock";
            this.BreakBedrock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.BreakBedrock, "Allows you to destroy Bedrock in Survival mode.");
            this.BreakBedrock.UseSelectable = true;
            this.BreakBedrock.UseStyleColors = true;
            this.BreakBedrock.CheckedChanged += new System.EventHandler(this.BreakBedrockToggled);
            // 
            // SwimFast
            // 
            this.SwimFast.AutoSize = true;
            this.SwimFast.Location = new System.Drawing.Point(379, 321);
            this.SwimFast.Name = "SwimFast";
            this.SwimFast.Size = new System.Drawing.Size(76, 15);
            this.SwimFast.Style = MetroFramework.MetroColorStyle.Blue;
            this.SwimFast.TabIndex = 172;
            this.SwimFast.Tag = "NonHost";
            this.SwimFast.Text = "Swim Fast";
            this.SwimFast.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SwimFast, "Makes you swim a lot faster.");
            this.SwimFast.UseSelectable = true;
            this.SwimFast.UseStyleColors = true;
            this.SwimFast.CheckedChanged += new System.EventHandler(this.SwimFastToggled);
            // 
            // BreakAnything
            // 
            this.BreakAnything.AutoSize = true;
            this.BreakAnything.Location = new System.Drawing.Point(379, 300);
            this.BreakAnything.Name = "BreakAnything";
            this.BreakAnything.Size = new System.Drawing.Size(104, 15);
            this.BreakAnything.Style = MetroFramework.MetroColorStyle.Blue;
            this.BreakAnything.TabIndex = 172;
            this.BreakAnything.Tag = "NonHost";
            this.BreakAnything.Text = "Break Anything";
            this.BreakAnything.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.BreakAnything, "Allows you to break blocks that where \r\npreviously unbreakable");
            this.BreakAnything.UseSelectable = true;
            this.BreakAnything.UseStyleColors = true;
            this.BreakAnything.CheckedChanged += new System.EventHandler(this.BreakAnythingToggled);
            // 
            // AirJump
            // 
            this.AirJump.AutoSize = true;
            this.AirJump.Location = new System.Drawing.Point(379, 279);
            this.AirJump.Name = "AirJump";
            this.AirJump.Size = new System.Drawing.Size(70, 15);
            this.AirJump.Style = MetroFramework.MetroColorStyle.Blue;
            this.AirJump.TabIndex = 171;
            this.AirJump.Tag = "NonHost";
            this.AirJump.Text = "Air Jump";
            this.AirJump.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AirJump, "Allows you to jump at any time, even while in the air");
            this.AirJump.UseSelectable = true;
            this.AirJump.UseStyleColors = true;
            this.AirJump.CheckedChanged += new System.EventHandler(this.AirJumpToggled);
            // 
            // LeftHanded
            // 
            this.LeftHanded.AutoSize = true;
            this.LeftHanded.Location = new System.Drawing.Point(379, 258);
            this.LeftHanded.Name = "LeftHanded";
            this.LeftHanded.Size = new System.Drawing.Size(88, 15);
            this.LeftHanded.Style = MetroFramework.MetroColorStyle.Blue;
            this.LeftHanded.TabIndex = 170;
            this.LeftHanded.Tag = "NonHost";
            this.LeftHanded.Text = "Left Handed";
            this.LeftHanded.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.LeftHanded, "Swaps your main hand to the left hand");
            this.LeftHanded.UseSelectable = true;
            this.LeftHanded.UseStyleColors = true;
            this.LeftHanded.CheckedChanged += new System.EventHandler(this.LeftHandedToggled);
            // 
            // MaxStackSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.MaxStackSlider, true);
            this.MaxStackSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.MaxStackSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.MaxStackSlider.Location = new System.Drawing.Point(634, 466);
            this.MaxStackSlider.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.MaxStackSlider.Name = "MaxStackSlider";
            this.MaxStackSlider.Size = new System.Drawing.Size(147, 20);
            this.MaxStackSlider.TabIndex = 169;
            this.MaxStackSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.MaxStackSlider, "How many items can we carry at once in a stack?");
            this.MaxStackSlider.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.MaxStackSlider.ValueChanged += new System.EventHandler(this.MaxStackSliderChanged);
            // 
            // MaxStack
            // 
            this.MaxStack.AutoSize = true;
            this.MaxStack.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MaxStack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaxStack.Location = new System.Drawing.Point(554, 467);
            this.MaxStack.Name = "MaxStack";
            this.MaxStack.Size = new System.Drawing.Size(74, 19);
            this.MaxStack.Style = MetroFramework.MetroColorStyle.Orange;
            this.MaxStack.TabIndex = 168;
            this.MaxStack.Tag = "Host";
            this.MaxStack.Text = "Max Stack:";
            this.MaxStack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MaxStack.UseStyleColors = true;
            // 
            // UnlimitedEnchants
            // 
            this.UnlimitedEnchants.AutoSize = true;
            this.UnlimitedEnchants.Location = new System.Drawing.Point(379, 237);
            this.UnlimitedEnchants.Name = "UnlimitedEnchants";
            this.UnlimitedEnchants.Size = new System.Drawing.Size(126, 15);
            this.UnlimitedEnchants.Style = MetroFramework.MetroColorStyle.Orange;
            this.UnlimitedEnchants.TabIndex = 167;
            this.UnlimitedEnchants.Tag = "Host";
            this.UnlimitedEnchants.Text = "Unlimited Enchants";
            this.UnlimitedEnchants.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.UnlimitedEnchants, "Allows you to enchant items that already have been enchanted");
            this.UnlimitedEnchants.UseSelectable = true;
            this.UnlimitedEnchants.UseStyleColors = true;
            this.UnlimitedEnchants.CheckedChanged += new System.EventHandler(this.UnlimitedEnchantsToggled);
            // 
            // EnchantmentEditorBtn
            // 
            this.EnchantmentEditorBtn.Location = new System.Drawing.Point(749, 436);
            this.EnchantmentEditorBtn.Name = "EnchantmentEditorBtn";
            this.EnchantmentEditorBtn.Size = new System.Drawing.Size(365, 25);
            this.EnchantmentEditorBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.EnchantmentEditorBtn.TabIndex = 166;
            this.EnchantmentEditorBtn.Tag = "NonHost";
            this.EnchantmentEditorBtn.Text = "Enchantment Editor";
            this.EnchantmentEditorBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.EnchantmentEditorBtn, "Opens the Enchantment Editor");
            this.EnchantmentEditorBtn.UseSelectable = true;
            this.EnchantmentEditorBtn.UseStyleColors = true;
            this.EnchantmentEditorBtn.Click += new System.EventHandler(this.EnchantmentEditorBtnClicked);
            // 
            // Invisible
            // 
            this.Invisible.AutoSize = true;
            this.Invisible.Location = new System.Drawing.Point(379, 216);
            this.Invisible.Name = "Invisible";
            this.Invisible.Size = new System.Drawing.Size(66, 15);
            this.Invisible.Style = MetroFramework.MetroColorStyle.Orange;
            this.Invisible.TabIndex = 161;
            this.Invisible.Tag = "Host";
            this.Invisible.Text = "Invisible";
            this.Invisible.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.Invisible, "Turns yourself invisible");
            this.Invisible.UseSelectable = true;
            this.Invisible.UseStyleColors = true;
            this.Invisible.CheckedChanged += new System.EventHandler(this.InvisibleToggled);
            // 
            // PotionAmplifierSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.PotionAmplifierSlider, true);
            this.PotionAmplifierSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.PotionAmplifierSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.PotionAmplifierSlider.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PotionAmplifierSlider.Location = new System.Drawing.Point(407, 597);
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
            // FrictionSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.FrictionSlider, true);
            this.FrictionSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.FrictionSlider.DecimalPlaces = 8;
            this.FrictionSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.FrictionSlider.Increment = new decimal(new int[] {
            10000000,
            0,
            0,
            524288});
            this.FrictionSlider.Location = new System.Drawing.Point(355, 571);
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
            // playerModelScaleSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.playerModelScaleSlider, true);
            this.playerModelScaleSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.playerModelScaleSlider.DecimalPlaces = 4;
            this.playerModelScaleSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.playerModelScaleSlider.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            262144});
            this.playerModelScaleSlider.Location = new System.Drawing.Point(424, 545);
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
            // FieldOfViewSplitSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.FieldOfViewSplitSlider, true);
            this.FieldOfViewSplitSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.FieldOfViewSplitSlider.DecimalPlaces = 3;
            this.FieldOfViewSplitSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.FieldOfViewSplitSlider.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.FieldOfViewSplitSlider.Location = new System.Drawing.Point(176, 597);
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
            this.RiptideFlyingSpeedSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.RiptideFlyingSpeedSlider.DecimalPlaces = 4;
            this.RiptideFlyingSpeedSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.RiptideFlyingSpeedSlider.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            262144});
            this.RiptideFlyingSpeedSlider.Location = new System.Drawing.Point(438, 467);
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
            // SprintingSpeedScaleSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.SprintingSpeedScaleSlider, true);
            this.SprintingSpeedScaleSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.SprintingSpeedScaleSlider.DecimalPlaces = 3;
            this.SprintingSpeedScaleSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SprintingSpeedScaleSlider.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            262144});
            this.SprintingSpeedScaleSlider.Location = new System.Drawing.Point(433, 519);
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
            // EnchantmentLevelSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.EnchantmentLevelSlider, true);
            this.EnchantmentLevelSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.EnchantmentLevelSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.EnchantmentLevelSlider.Location = new System.Drawing.Point(139, 467);
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
            this.WalkingSpeedScaleSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.WalkingSpeedScaleSlider.DecimalPlaces = 3;
            this.WalkingSpeedScaleSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.WalkingSpeedScaleSlider.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            262144});
            this.WalkingSpeedScaleSlider.Location = new System.Drawing.Point(440, 493);
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
            this.ReachSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ReachSlider.DecimalPlaces = 1;
            this.ReachSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ReachSlider.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ReachSlider.Location = new System.Drawing.Point(58, 519);
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
            this.JumpHeightSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.JumpHeightSlider.DecimalPlaces = 3;
            this.JumpHeightSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.JumpHeightSlider.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.JumpHeightSlider.Location = new System.Drawing.Point(100, 493);
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
            // FieldOfViewSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.FieldOfViewSlider, true);
            this.FieldOfViewSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.FieldOfViewSlider.DecimalPlaces = 3;
            this.FieldOfViewSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.FieldOfViewSlider.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.FieldOfViewSlider.Location = new System.Drawing.Point(99, 571);
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
            // HitBoxScaleSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.HitBoxScaleSlider, true);
            this.HitBoxScaleSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.HitBoxScaleSlider.DecimalPlaces = 1;
            this.HitBoxScaleSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.HitBoxScaleSlider.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.HitBoxScaleSlider.Location = new System.Drawing.Point(96, 545);
            this.HitBoxScaleSlider.Name = "HitBoxScaleSlider";
            this.HitBoxScaleSlider.Size = new System.Drawing.Size(190, 20);
            this.HitBoxScaleSlider.TabIndex = 134;
            this.HitBoxScaleSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.HitBoxScaleSlider, "How big should entity hitboxes be?\r\n\r\nCTRL + Click = Increase Decimal Places\r\nALT" +
        " + Click = Decrease Decimal Places");
            this.HitBoxScaleSlider.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.HitBoxScaleSlider.ValueChanged += new System.EventHandler(this.HitboxSliderChanged);
            this.HitBoxScaleSlider.Click += new System.EventHandler(this.SliderClicked);
            // 
            // PlayerOptionsBtn
            // 
            this.PlayerOptionsBtn.Location = new System.Drawing.Point(378, 436);
            this.PlayerOptionsBtn.Name = "PlayerOptionsBtn";
            this.PlayerOptionsBtn.Size = new System.Drawing.Size(365, 25);
            this.PlayerOptionsBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.PlayerOptionsBtn.TabIndex = 158;
            this.PlayerOptionsBtn.Tag = "NonHost";
            this.PlayerOptionsBtn.Text = "Player Options";
            this.PlayerOptionsBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.PlayerOptionsBtn, "Opens the Player Options window where you can modify Player Options");
            this.PlayerOptionsBtn.UseSelectable = true;
            this.PlayerOptionsBtn.UseStyleColors = true;
            this.PlayerOptionsBtn.Click += new System.EventHandler(this.PlayerOptionsBtnClicked);
            // 
            // PotionAmplifier
            // 
            this.PotionAmplifier.AutoSize = true;
            this.PotionAmplifier.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PotionAmplifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PotionAmplifier.Location = new System.Drawing.Point(292, 597);
            this.PotionAmplifier.Name = "PotionAmplifier";
            this.PotionAmplifier.Size = new System.Drawing.Size(109, 19);
            this.PotionAmplifier.Style = MetroFramework.MetroColorStyle.Orange;
            this.PotionAmplifier.TabIndex = 156;
            this.PotionAmplifier.Tag = "Host";
            this.PotionAmplifier.Text = "Potion Amplifier:";
            this.PotionAmplifier.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PotionAmplifier.UseStyleColors = true;
            // 
            // NoSlowDowns
            // 
            this.NoSlowDowns.AutoSize = true;
            this.NoSlowDowns.Location = new System.Drawing.Point(379, 195);
            this.NoSlowDowns.Name = "NoSlowDowns";
            this.NoSlowDowns.Size = new System.Drawing.Size(97, 15);
            this.NoSlowDowns.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoSlowDowns.TabIndex = 155;
            this.NoSlowDowns.Tag = "NonHost";
            this.NoSlowDowns.Text = "No Slowdown";
            this.NoSlowDowns.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.NoSlowDowns, "Disables movement penalties, such as:\r\n\r\nEating\r\nDrinking\r\nDrawing Bow\r\nDrawing T" +
        "rident\r\nSoul Sand");
            this.NoSlowDowns.UseSelectable = true;
            this.NoSlowDowns.UseStyleColors = true;
            this.NoSlowDowns.CheckedChanged += new System.EventHandler(this.NoSlowDownsToggled);
            // 
            // ESP
            // 
            this.ESP.AutoSize = true;
            this.ESP.Location = new System.Drawing.Point(379, 174);
            this.ESP.Name = "ESP";
            this.ESP.Size = new System.Drawing.Size(42, 15);
            this.ESP.Style = MetroFramework.MetroColorStyle.Blue;
            this.ESP.TabIndex = 154;
            this.ESP.Tag = "NonHost";
            this.ESP.Text = "ESP";
            this.ESP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.ESP, "Extends the player name borders beyond the character model\r\nNote: This also anble" +
        "s Wallhack");
            this.ESP.UseSelectable = true;
            this.ESP.UseStyleColors = true;
            this.ESP.CheckedChanged += new System.EventHandler(this.EspToggled);
            // 
            // AlwaysInWater
            // 
            this.AlwaysInWater.AutoSize = true;
            this.AlwaysInWater.Location = new System.Drawing.Point(379, 153);
            this.AlwaysInWater.Name = "AlwaysInWater";
            this.AlwaysInWater.Size = new System.Drawing.Size(107, 15);
            this.AlwaysInWater.Style = MetroFramework.MetroColorStyle.Blue;
            this.AlwaysInWater.TabIndex = 153;
            this.AlwaysInWater.Tag = "NonHost";
            this.AlwaysInWater.Text = "Always in Water";
            this.AlwaysInWater.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AlwaysInWater, "You\'ll always be treated as if you\'re in the water");
            this.AlwaysInWater.UseSelectable = true;
            this.AlwaysInWater.UseStyleColors = true;
            this.AlwaysInWater.CheckedChanged += new System.EventHandler(this.AlwaysInWaterToggled);
            // 
            // LevelX
            // 
            this.LevelX.AutoSize = true;
            this.LevelX.Location = new System.Drawing.Point(379, 132);
            this.LevelX.Name = "LevelX";
            this.LevelX.Size = new System.Drawing.Size(60, 15);
            this.LevelX.Style = MetroFramework.MetroColorStyle.Orange;
            this.LevelX.TabIndex = 152;
            this.LevelX.Tag = "Host";
            this.LevelX.Text = "Level X";
            this.LevelX.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.LevelX, "Displays your XP Level as \"X\"");
            this.LevelX.UseSelectable = true;
            this.LevelX.UseStyleColors = true;
            this.LevelX.CheckedChanged += new System.EventHandler(this.LevelXToggled);
            // 
            // SeeThroughBlocks
            // 
            this.SeeThroughBlocks.AutoSize = true;
            this.SeeThroughBlocks.Location = new System.Drawing.Point(379, 111);
            this.SeeThroughBlocks.Name = "SeeThroughBlocks";
            this.SeeThroughBlocks.Size = new System.Drawing.Size(126, 15);
            this.SeeThroughBlocks.Style = MetroFramework.MetroColorStyle.Blue;
            this.SeeThroughBlocks.TabIndex = 151;
            this.SeeThroughBlocks.Tag = "NonHost";
            this.SeeThroughBlocks.Text = "See Through Blocks";
            this.SeeThroughBlocks.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SeeThroughBlocks, "Removes the fullscreen texture of the block you\'re stuck in");
            this.SeeThroughBlocks.UseSelectable = true;
            this.SeeThroughBlocks.UseStyleColors = true;
            this.SeeThroughBlocks.CheckedChanged += new System.EventHandler(this.SeeThroughBlocksToggled);
            // 
            // AlwaysInLava
            // 
            this.AlwaysInLava.AutoSize = true;
            this.AlwaysInLava.Location = new System.Drawing.Point(379, 90);
            this.AlwaysInLava.Name = "AlwaysInLava";
            this.AlwaysInLava.Size = new System.Drawing.Size(100, 15);
            this.AlwaysInLava.Style = MetroFramework.MetroColorStyle.Blue;
            this.AlwaysInLava.TabIndex = 27;
            this.AlwaysInLava.Tag = "NonHost";
            this.AlwaysInLava.Text = "Always in Lava";
            this.AlwaysInLava.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AlwaysInLava, "Whether you\'ll always be considered\r\nin lava");
            this.AlwaysInLava.UseSelectable = true;
            this.AlwaysInLava.UseStyleColors = true;
            this.AlwaysInLava.CheckedChanged += new System.EventHandler(this.AlwaysInLavaToggled);
            // 
            // HideBlocks
            // 
            this.HideBlocks.AutoSize = true;
            this.HideBlocks.Location = new System.Drawing.Point(379, 69);
            this.HideBlocks.Name = "HideBlocks";
            this.HideBlocks.Size = new System.Drawing.Size(85, 15);
            this.HideBlocks.Style = MetroFramework.MetroColorStyle.Blue;
            this.HideBlocks.TabIndex = 150;
            this.HideBlocks.Tag = "NonHost";
            this.HideBlocks.Text = "Hide Blocks";
            this.HideBlocks.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.HideBlocks, "Hides the majority of blocks, excluding entities and liquids");
            this.HideBlocks.UseSelectable = true;
            this.HideBlocks.UseStyleColors = true;
            this.HideBlocks.CheckedChanged += new System.EventHandler(this.HideBlocksToggled);
            // 
            // UnderwaterEffects
            // 
            this.UnderwaterEffects.AutoSize = true;
            this.UnderwaterEffects.Location = new System.Drawing.Point(380, 48);
            this.UnderwaterEffects.Name = "UnderwaterEffects";
            this.UnderwaterEffects.Size = new System.Drawing.Size(171, 15);
            this.UnderwaterEffects.Style = MetroFramework.MetroColorStyle.Blue;
            this.UnderwaterEffects.TabIndex = 149;
            this.UnderwaterEffects.Tag = "NonHost";
            this.UnderwaterEffects.Text = "Underwater Effects (Default)";
            this.UnderwaterEffects.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UnderwaterEffects.ThreeState = true;
            this.ToolTipManager.SetToolTip(this.UnderwaterEffects, "Turns on/off Underwater Screen Effects");
            this.UnderwaterEffects.UseSelectable = true;
            this.UnderwaterEffects.UseStyleColors = true;
            this.UnderwaterEffects.CheckStateChanged += new System.EventHandler(this.UnderwaterEffectsToggled);
            // 
            // EnchantmentLevel
            // 
            this.EnchantmentLevel.AutoSize = true;
            this.EnchantmentLevel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.EnchantmentLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EnchantmentLevel.Location = new System.Drawing.Point(5, 467);
            this.EnchantmentLevel.Name = "EnchantmentLevel";
            this.EnchantmentLevel.Size = new System.Drawing.Size(128, 19);
            this.EnchantmentLevel.Style = MetroFramework.MetroColorStyle.Orange;
            this.EnchantmentLevel.TabIndex = 116;
            this.EnchantmentLevel.Tag = "Host";
            this.EnchantmentLevel.Text = "Enchantment Level:";
            this.EnchantmentLevel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.EnchantmentLevel.UseStyleColors = true;
            // 
            // Friction
            // 
            this.Friction.AutoSize = true;
            this.Friction.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Friction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Friction.Location = new System.Drawing.Point(292, 571);
            this.Friction.Name = "Friction";
            this.Friction.Size = new System.Drawing.Size(57, 19);
            this.Friction.Style = MetroFramework.MetroColorStyle.Blue;
            this.Friction.TabIndex = 146;
            this.Friction.Tag = "NonHost";
            this.Friction.Text = "Friction:";
            this.Friction.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Friction.UseStyleColors = true;
            // 
            // GodModeAll
            // 
            this.GodModeAll.AutoSize = true;
            this.GodModeAll.Location = new System.Drawing.Point(379, 27);
            this.GodModeAll.Name = "GodModeAll";
            this.GodModeAll.Size = new System.Drawing.Size(104, 15);
            this.GodModeAll.Style = MetroFramework.MetroColorStyle.Orange;
            this.GodModeAll.TabIndex = 148;
            this.GodModeAll.Tag = "Host";
            this.GodModeAll.Text = "God Mode (All)";
            this.GodModeAll.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.GodModeAll, "Enables God Mode for all entities");
            this.GodModeAll.UseSelectable = true;
            this.GodModeAll.UseStyleColors = true;
            this.GodModeAll.CheckedChanged += new System.EventHandler(this.GodModeAllToggled);
            // 
            // FieldofViewSplitscreen
            // 
            this.FieldofViewSplitscreen.AutoSize = true;
            this.FieldofViewSplitscreen.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.FieldofViewSplitscreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FieldofViewSplitscreen.Location = new System.Drawing.Point(4, 597);
            this.FieldofViewSplitscreen.Name = "FieldofViewSplitscreen";
            this.FieldofViewSplitscreen.Size = new System.Drawing.Size(166, 19);
            this.FieldofViewSplitscreen.Style = MetroFramework.MetroColorStyle.Blue;
            this.FieldofViewSplitscreen.TabIndex = 144;
            this.FieldofViewSplitscreen.Tag = "NonHost";
            this.FieldofViewSplitscreen.Text = "Field of View (Splitscreen):";
            this.FieldofViewSplitscreen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FieldofViewSplitscreen.UseStyleColors = true;
            // 
            // RiptideFlyingSpeed
            // 
            this.RiptideFlyingSpeed.AutoSize = true;
            this.RiptideFlyingSpeed.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.RiptideFlyingSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RiptideFlyingSpeed.Location = new System.Drawing.Point(292, 467);
            this.RiptideFlyingSpeed.Name = "RiptideFlyingSpeed";
            this.RiptideFlyingSpeed.Size = new System.Drawing.Size(140, 19);
            this.RiptideFlyingSpeed.Style = MetroFramework.MetroColorStyle.Blue;
            this.RiptideFlyingSpeed.TabIndex = 124;
            this.RiptideFlyingSpeed.Tag = "NonHost";
            this.RiptideFlyingSpeed.Text = "Riptide (flying) Speed:";
            this.RiptideFlyingSpeed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RiptideFlyingSpeed.UseStyleColors = true;
            // 
            // PlayerModelScale
            // 
            this.PlayerModelScale.AutoSize = true;
            this.PlayerModelScale.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PlayerModelScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PlayerModelScale.Location = new System.Drawing.Point(292, 545);
            this.PlayerModelScale.Name = "PlayerModelScale";
            this.PlayerModelScale.Size = new System.Drawing.Size(126, 19);
            this.PlayerModelScale.Style = MetroFramework.MetroColorStyle.Blue;
            this.PlayerModelScale.TabIndex = 141;
            this.PlayerModelScale.Tag = "NonHost";
            this.PlayerModelScale.Text = "Player Model Scale:";
            this.PlayerModelScale.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PlayerModelScale.UseStyleColors = true;
            // 
            // JumpHeight
            // 
            this.JumpHeight.AutoSize = true;
            this.JumpHeight.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.JumpHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.JumpHeight.Location = new System.Drawing.Point(4, 493);
            this.JumpHeight.Name = "JumpHeight";
            this.JumpHeight.Size = new System.Drawing.Size(90, 19);
            this.JumpHeight.Style = MetroFramework.MetroColorStyle.Blue;
            this.JumpHeight.TabIndex = 118;
            this.JumpHeight.Tag = "NonHost";
            this.JumpHeight.Text = "Jump Height:";
            this.JumpHeight.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.JumpHeight.UseStyleColors = true;
            // 
            // WalkingSpeedScale
            // 
            this.WalkingSpeedScale.AutoSize = true;
            this.WalkingSpeedScale.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.WalkingSpeedScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WalkingSpeedScale.Location = new System.Drawing.Point(292, 493);
            this.WalkingSpeedScale.Name = "WalkingSpeedScale";
            this.WalkingSpeedScale.Size = new System.Drawing.Size(135, 19);
            this.WalkingSpeedScale.Style = MetroFramework.MetroColorStyle.Blue;
            this.WalkingSpeedScale.TabIndex = 127;
            this.WalkingSpeedScale.Tag = "NonHost";
            this.WalkingSpeedScale.Text = "Walking Speed Scale:";
            this.WalkingSpeedScale.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WalkingSpeedScale.UseStyleColors = true;
            // 
            // GodMode
            // 
            this.GodMode.AutoSize = true;
            this.GodMode.Location = new System.Drawing.Point(379, 6);
            this.GodMode.Name = "GodMode";
            this.GodMode.Size = new System.Drawing.Size(109, 15);
            this.GodMode.Style = MetroFramework.MetroColorStyle.Orange;
            this.GodMode.TabIndex = 143;
            this.GodMode.Tag = "Host";
            this.GodMode.Text = "God Mode (Self)";
            this.GodMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.GodMode, "Enables God Mode for local players only");
            this.GodMode.UseSelectable = true;
            this.GodMode.UseStyleColors = true;
            this.GodMode.CheckedChanged += new System.EventHandler(this.GodModeToggled);
            // 
            // Reach
            // 
            this.Reach.AutoSize = true;
            this.Reach.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Reach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Reach.Location = new System.Drawing.Point(4, 519);
            this.Reach.Name = "Reach";
            this.Reach.Size = new System.Drawing.Size(48, 19);
            this.Reach.Style = MetroFramework.MetroColorStyle.Blue;
            this.Reach.TabIndex = 120;
            this.Reach.Tag = "NonHost";
            this.Reach.Text = "Reach:";
            this.Reach.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Reach.UseStyleColors = true;
            // 
            // SprintingSpeedScale
            // 
            this.SprintingSpeedScale.AutoSize = true;
            this.SprintingSpeedScale.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SprintingSpeedScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SprintingSpeedScale.Location = new System.Drawing.Point(292, 519);
            this.SprintingSpeedScale.Name = "SprintingSpeedScale";
            this.SprintingSpeedScale.Size = new System.Drawing.Size(142, 19);
            this.SprintingSpeedScale.Style = MetroFramework.MetroColorStyle.Blue;
            this.SprintingSpeedScale.TabIndex = 130;
            this.SprintingSpeedScale.Tag = "NonHost";
            this.SprintingSpeedScale.Text = "Sprinting Speed Scale:";
            this.SprintingSpeedScale.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SprintingSpeedScale.UseStyleColors = true;
            // 
            // DeadMauFiveMode
            // 
            this.DeadMauFiveMode.AutoSize = true;
            this.DeadMauFiveMode.Location = new System.Drawing.Point(192, 405);
            this.DeadMauFiveMode.Name = "DeadMauFiveMode";
            this.DeadMauFiveMode.Size = new System.Drawing.Size(83, 15);
            this.DeadMauFiveMode.Style = MetroFramework.MetroColorStyle.Orange;
            this.DeadMauFiveMode.TabIndex = 140;
            this.DeadMauFiveMode.Tag = "Host";
            this.DeadMauFiveMode.Text = "Mouse Ears";
            this.DeadMauFiveMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DeadMauFiveMode, "Apply deadmau5 ears to your player when holding an item");
            this.DeadMauFiveMode.UseSelectable = true;
            this.DeadMauFiveMode.UseStyleColors = true;
            this.DeadMauFiveMode.CheckedChanged += new System.EventHandler(this.DeadMauFiveModeToggled);
            // 
            // ArmorHUD
            // 
            this.ArmorHUD.AutoSize = true;
            this.ArmorHUD.Location = new System.Drawing.Point(192, 384);
            this.ArmorHUD.Name = "ArmorHUD";
            this.ArmorHUD.Size = new System.Drawing.Size(85, 15);
            this.ArmorHUD.Style = MetroFramework.MetroColorStyle.Blue;
            this.ArmorHUD.TabIndex = 138;
            this.ArmorHUD.Tag = "NonHost";
            this.ArmorHUD.Text = "Armor HUD";
            this.ArmorHUD.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.ArmorHUD, "Displays a HUD Element of your currently equipped armour on the \r\nleft side");
            this.ArmorHUD.UseSelectable = true;
            this.ArmorHUD.UseStyleColors = true;
            this.ArmorHUD.CheckedChanged += new System.EventHandler(this.ArmorHudToggled);
            // 
            // TakeEverythingAnywhere
            // 
            this.TakeEverythingAnywhere.AutoSize = true;
            this.TakeEverythingAnywhere.Location = new System.Drawing.Point(192, 363);
            this.TakeEverythingAnywhere.Name = "TakeEverythingAnywhere";
            this.TakeEverythingAnywhere.Size = new System.Drawing.Size(161, 15);
            this.TakeEverythingAnywhere.Style = MetroFramework.MetroColorStyle.Blue;
            this.TakeEverythingAnywhere.TabIndex = 25;
            this.TakeEverythingAnywhere.Tag = "NonHost";
            this.TakeEverythingAnywhere.Text = "Take Everything Anywhere";
            this.TakeEverythingAnywhere.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.TakeEverythingAnywhere, "Permanently enables the \'Take Everything\' option in containers, \r\neven if it is d" +
        "isabled");
            this.TakeEverythingAnywhere.UseSelectable = true;
            this.TakeEverythingAnywhere.UseStyleColors = true;
            this.TakeEverythingAnywhere.CheckedChanged += new System.EventHandler(this.TakeEverythingAnywhereToggled);
            // 
            // FieldOfView
            // 
            this.FieldOfView.AutoSize = true;
            this.FieldOfView.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.FieldOfView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FieldOfView.Location = new System.Drawing.Point(4, 571);
            this.FieldOfView.Name = "FieldOfView";
            this.FieldOfView.Size = new System.Drawing.Size(89, 19);
            this.FieldOfView.Style = MetroFramework.MetroColorStyle.Blue;
            this.FieldOfView.TabIndex = 136;
            this.FieldOfView.Tag = "NonHost";
            this.FieldOfView.Text = "Field of View:";
            this.FieldOfView.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FieldOfView.UseStyleColors = true;
            // 
            // HiddenGameModesUnlocked
            // 
            this.HiddenGameModesUnlocked.AutoSize = true;
            this.HiddenGameModesUnlocked.Location = new System.Drawing.Point(192, 342);
            this.HiddenGameModesUnlocked.Name = "HiddenGameModesUnlocked";
            this.HiddenGameModesUnlocked.Size = new System.Drawing.Size(185, 15);
            this.HiddenGameModesUnlocked.Style = MetroFramework.MetroColorStyle.Blue;
            this.HiddenGameModesUnlocked.TabIndex = 135;
            this.HiddenGameModesUnlocked.Tag = "NonHost";
            this.HiddenGameModesUnlocked.Text = "Hidden Gamemodes Unlocked";
            this.HiddenGameModesUnlocked.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.HiddenGameModesUnlocked, "Unlocks hidden gamemodes (such as Lobby or Spectator).\r\nThey can be switched in-g" +
        "ame using Host Privileges.");
            this.HiddenGameModesUnlocked.UseSelectable = true;
            this.HiddenGameModesUnlocked.UseStyleColors = true;
            this.HiddenGameModesUnlocked.CheckedChanged += new System.EventHandler(this.HiddenGameModesUnlockedToggled);
            // 
            // HitBoxScale
            // 
            this.HitBoxScale.AutoSize = true;
            this.HitBoxScale.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.HitBoxScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HitBoxScale.Location = new System.Drawing.Point(4, 545);
            this.HitBoxScale.Name = "HitBoxScale";
            this.HitBoxScale.Size = new System.Drawing.Size(86, 19);
            this.HitBoxScale.Style = MetroFramework.MetroColorStyle.Blue;
            this.HitBoxScale.TabIndex = 133;
            this.HitBoxScale.Tag = "NonHost";
            this.HitBoxScale.Text = "Hitbox Scale:";
            this.HitBoxScale.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.HitBoxScale.UseStyleColors = true;
            // 
            // CraftingTableAnywhere
            // 
            this.CraftingTableAnywhere.AutoSize = true;
            this.CraftingTableAnywhere.Location = new System.Drawing.Point(192, 321);
            this.CraftingTableAnywhere.Name = "CraftingTableAnywhere";
            this.CraftingTableAnywhere.Size = new System.Drawing.Size(152, 15);
            this.CraftingTableAnywhere.Style = MetroFramework.MetroColorStyle.Blue;
            this.CraftingTableAnywhere.TabIndex = 132;
            this.CraftingTableAnywhere.Tag = "NonHost";
            this.CraftingTableAnywhere.Text = "Crafting Table Anywhere";
            this.CraftingTableAnywhere.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.CraftingTableAnywhere, "Allows you to use the full crafting table functionally in your inventory");
            this.CraftingTableAnywhere.UseSelectable = true;
            this.CraftingTableAnywhere.UseStyleColors = true;
            this.CraftingTableAnywhere.CheckedChanged += new System.EventHandler(this.CraftingTableAnywhereToggled);
            // 
            // VisibleHitboxes
            // 
            this.VisibleHitboxes.AutoSize = true;
            this.VisibleHitboxes.Location = new System.Drawing.Point(192, 300);
            this.VisibleHitboxes.Name = "VisibleHitboxes";
            this.VisibleHitboxes.Size = new System.Drawing.Size(107, 15);
            this.VisibleHitboxes.Style = MetroFramework.MetroColorStyle.Blue;
            this.VisibleHitboxes.TabIndex = 129;
            this.VisibleHitboxes.Tag = "NonHost";
            this.VisibleHitboxes.Text = "Visible Hitboxes";
            this.VisibleHitboxes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.VisibleHitboxes, "Hitboxes on entities will be visible.");
            this.VisibleHitboxes.UseSelectable = true;
            this.VisibleHitboxes.UseStyleColors = true;
            this.VisibleHitboxes.CheckedChanged += new System.EventHandler(this.VisibleHitboxesToggled);
            // 
            // NnidEditorBtn
            // 
            this.NnidEditorBtn.Location = new System.Drawing.Point(7, 436);
            this.NnidEditorBtn.Name = "NnidEditorBtn";
            this.NnidEditorBtn.Size = new System.Drawing.Size(365, 25);
            this.NnidEditorBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.NnidEditorBtn.TabIndex = 126;
            this.NnidEditorBtn.Tag = "NonHost";
            this.NnidEditorBtn.Text = "NNID Editor";
            this.NnidEditorBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.NnidEditorBtn, "Opens the NNID Editor.");
            this.NnidEditorBtn.UseSelectable = true;
            this.NnidEditorBtn.UseStyleColors = true;
            this.NnidEditorBtn.Click += new System.EventHandler(this.NnidEditorBtnClicked);
            // 
            // InsaneCriticalHits
            // 
            this.InsaneCriticalHits.AutoSize = true;
            this.InsaneCriticalHits.BackColor = System.Drawing.Color.Transparent;
            this.InsaneCriticalHits.Location = new System.Drawing.Point(192, 216);
            this.InsaneCriticalHits.Name = "InsaneCriticalHits";
            this.InsaneCriticalHits.Size = new System.Drawing.Size(121, 15);
            this.InsaneCriticalHits.Style = MetroFramework.MetroColorStyle.Orange;
            this.InsaneCriticalHits.TabIndex = 112;
            this.InsaneCriticalHits.Tag = "Host";
            this.InsaneCriticalHits.Text = "Insane Critical Hits";
            this.InsaneCriticalHits.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.InsaneCriticalHits, "Critical hits will deal massive amounts of damage");
            this.InsaneCriticalHits.UseSelectable = true;
            this.InsaneCriticalHits.UseStyleColors = true;
            this.InsaneCriticalHits.CheckedChanged += new System.EventHandler(this.InsaneCriticalHitsToggled);
            // 
            // AlwaysSwimming
            // 
            this.AlwaysSwimming.AutoSize = true;
            this.AlwaysSwimming.Location = new System.Drawing.Point(192, 236);
            this.AlwaysSwimming.Name = "AlwaysSwimming";
            this.AlwaysSwimming.Size = new System.Drawing.Size(120, 15);
            this.AlwaysSwimming.Style = MetroFramework.MetroColorStyle.Orange;
            this.AlwaysSwimming.TabIndex = 109;
            this.AlwaysSwimming.Tag = "Host";
            this.AlwaysSwimming.Text = "Always Swimming";
            this.AlwaysSwimming.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AlwaysSwimming, "Always acts like you\'re swimming underwater");
            this.AlwaysSwimming.UseSelectable = true;
            this.AlwaysSwimming.UseStyleColors = true;
            this.AlwaysSwimming.CheckedChanged += new System.EventHandler(this.AlwaysSwimmingToggled);
            // 
            // InfiniteRiptide
            // 
            this.InfiniteRiptide.AutoSize = true;
            this.InfiniteRiptide.Location = new System.Drawing.Point(192, 279);
            this.InfiniteRiptide.Name = "InfiniteRiptide";
            this.InfiniteRiptide.Size = new System.Drawing.Size(116, 15);
            this.InfiniteRiptide.Style = MetroFramework.MetroColorStyle.Blue;
            this.InfiniteRiptide.TabIndex = 108;
            this.InfiniteRiptide.Tag = "NonHost";
            this.InfiniteRiptide.Text = "Riptide Anywhere";
            this.InfiniteRiptide.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.InfiniteRiptide, "Allows you to use the Riptide Enchantment regardless of \r\nwhether you\'re in the r" +
        "ain or water");
            this.InfiniteRiptide.UseSelectable = true;
            this.InfiniteRiptide.UseStyleColors = true;
            this.InfiniteRiptide.CheckedChanged += new System.EventHandler(this.InfiniteRiptideToggled);
            // 
            // FullRotation
            // 
            this.FullRotation.AutoSize = true;
            this.FullRotation.Location = new System.Drawing.Point(7, 342);
            this.FullRotation.Name = "FullRotation";
            this.FullRotation.Size = new System.Drawing.Size(90, 15);
            this.FullRotation.Style = MetroFramework.MetroColorStyle.Blue;
            this.FullRotation.TabIndex = 107;
            this.FullRotation.Tag = "NonHost";
            this.FullRotation.Text = "Full Rotation";
            this.FullRotation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.FullRotation, "Allows you to look vertically further than just up and down");
            this.FullRotation.UseSelectable = true;
            this.FullRotation.UseStyleColors = true;
            this.FullRotation.CheckedChanged += new System.EventHandler(this.FullRotationToggled);
            // 
            // AlwaysDamagedPlayers
            // 
            this.AlwaysDamagedPlayers.AutoSize = true;
            this.AlwaysDamagedPlayers.Location = new System.Drawing.Point(192, 258);
            this.AlwaysDamagedPlayers.Name = "AlwaysDamagedPlayers";
            this.AlwaysDamagedPlayers.Size = new System.Drawing.Size(114, 15);
            this.AlwaysDamagedPlayers.Style = MetroFramework.MetroColorStyle.Orange;
            this.AlwaysDamagedPlayers.TabIndex = 106;
            this.AlwaysDamagedPlayers.Tag = "Host";
            this.AlwaysDamagedPlayers.Text = "Always Damaged";
            this.AlwaysDamagedPlayers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AlwaysDamagedPlayers, "All entities will get damaged");
            this.AlwaysDamagedPlayers.UseSelectable = true;
            this.AlwaysDamagedPlayers.UseStyleColors = true;
            this.AlwaysDamagedPlayers.CheckedChanged += new System.EventHandler(this.AlwaysDamagedPlayersToggled);
            // 
            // InfiniteItems
            // 
            this.InfiniteItems.AutoSize = true;
            this.InfiniteItems.Location = new System.Drawing.Point(192, 195);
            this.InfiniteItems.Name = "InfiniteItems";
            this.InfiniteItems.Size = new System.Drawing.Size(92, 15);
            this.InfiniteItems.Style = MetroFramework.MetroColorStyle.Orange;
            this.InfiniteItems.TabIndex = 104;
            this.InfiniteItems.Tag = "Host";
            this.InfiniteItems.Text = "Infinite Items";
            this.InfiniteItems.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.InfiniteItems, "Dropping any items will not decrease it\'s count");
            this.InfiniteItems.UseSelectable = true;
            this.InfiniteItems.UseStyleColors = true;
            this.InfiniteItems.CheckedChanged += new System.EventHandler(this.InfiniteItemsToggled);
            // 
            // RapidBow
            // 
            this.RapidBow.AutoSize = true;
            this.RapidBow.Location = new System.Drawing.Point(192, 174);
            this.RapidBow.Name = "RapidBow";
            this.RapidBow.Size = new System.Drawing.Size(79, 15);
            this.RapidBow.Style = MetroFramework.MetroColorStyle.Orange;
            this.RapidBow.TabIndex = 76;
            this.RapidBow.Tag = "Host";
            this.RapidBow.Text = "Rapid Bow";
            this.RapidBow.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.RapidBow, "Allows you to fire the bow rapdily");
            this.RapidBow.UseSelectable = true;
            this.RapidBow.UseStyleColors = true;
            this.RapidBow.CheckedChanged += new System.EventHandler(this.RapidBowToggled);
            // 
            // BloodVision
            // 
            this.BloodVision.AutoSize = true;
            this.BloodVision.BackColor = System.Drawing.Color.Transparent;
            this.BloodVision.Location = new System.Drawing.Point(192, 153);
            this.BloodVision.Name = "BloodVision";
            this.BloodVision.Size = new System.Drawing.Size(89, 15);
            this.BloodVision.Style = MetroFramework.MetroColorStyle.Blue;
            this.BloodVision.TabIndex = 103;
            this.BloodVision.Tag = "NonHost";
            this.BloodVision.Text = "Blood Vision";
            this.BloodVision.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.BloodVision, "The screen will have a red overlay as if you were dead");
            this.BloodVision.UseSelectable = true;
            this.BloodVision.UseStyleColors = true;
            this.BloodVision.CheckedChanged += new System.EventHandler(this.BloodVisionToggled);
            // 
            // IgnorePotions
            // 
            this.IgnorePotions.AutoSize = true;
            this.IgnorePotions.BackColor = System.Drawing.Color.Transparent;
            this.IgnorePotions.Location = new System.Drawing.Point(192, 132);
            this.IgnorePotions.Name = "IgnorePotions";
            this.IgnorePotions.Size = new System.Drawing.Size(100, 15);
            this.IgnorePotions.Style = MetroFramework.MetroColorStyle.Orange;
            this.IgnorePotions.TabIndex = 102;
            this.IgnorePotions.Tag = "Host";
            this.IgnorePotions.Text = "Ignore Potions";
            this.IgnorePotions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.IgnorePotions, "Ignores all potion effects");
            this.IgnorePotions.UseSelectable = true;
            this.IgnorePotions.UseStyleColors = true;
            this.IgnorePotions.CheckedChanged += new System.EventHandler(this.IgnorePotionsToggled);
            // 
            // BypassInvulnerability
            // 
            this.BypassInvulnerability.AutoSize = true;
            this.BypassInvulnerability.BackColor = System.Drawing.Color.Transparent;
            this.BypassInvulnerability.Location = new System.Drawing.Point(192, 90);
            this.BypassInvulnerability.Name = "BypassInvulnerability";
            this.BypassInvulnerability.Size = new System.Drawing.Size(137, 15);
            this.BypassInvulnerability.Style = MetroFramework.MetroColorStyle.Orange;
            this.BypassInvulnerability.TabIndex = 100;
            this.BypassInvulnerability.Tag = "Host";
            this.BypassInvulnerability.Text = "Bypass Invulnerability";
            this.BypassInvulnerability.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.BypassInvulnerability, "Disables invulnerability for all Entities");
            this.BypassInvulnerability.UseSelectable = true;
            this.BypassInvulnerability.UseStyleColors = true;
            this.BypassInvulnerability.CheckedChanged += new System.EventHandler(this.BypassInvulnerabilityToggled);
            // 
            // WearAnything
            // 
            this.WearAnything.AutoSize = true;
            this.WearAnything.BackColor = System.Drawing.Color.Transparent;
            this.WearAnything.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WearAnything.Location = new System.Drawing.Point(193, 69);
            this.WearAnything.Name = "WearAnything";
            this.WearAnything.Size = new System.Drawing.Size(102, 15);
            this.WearAnything.Style = MetroFramework.MetroColorStyle.Blue;
            this.WearAnything.TabIndex = 99;
            this.WearAnything.Tag = "NonHost";
            this.WearAnything.Text = "Wear Anything";
            this.WearAnything.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.WearAnything, "Allows you to place anything on any of your armour slots.");
            this.WearAnything.UseSelectable = true;
            this.WearAnything.UseStyleColors = true;
            this.WearAnything.CheckedChanged += new System.EventHandler(this.WearAnythingToggled);
            // 
            // WalkonWater
            // 
            this.WalkonWater.AutoSize = true;
            this.WalkonWater.BackColor = System.Drawing.Color.Transparent;
            this.WalkonWater.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WalkonWater.Location = new System.Drawing.Point(193, 48);
            this.WalkonWater.Name = "WalkonWater";
            this.WalkonWater.Size = new System.Drawing.Size(100, 15);
            this.WalkonWater.Style = MetroFramework.MetroColorStyle.Blue;
            this.WalkonWater.TabIndex = 98;
            this.WalkonWater.Tag = "NonHost";
            this.WalkonWater.Text = "Walk on Water";
            this.WalkonWater.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.WalkonWater, "Allows you to walk on top of water.");
            this.WalkonWater.UseSelectable = true;
            this.WalkonWater.UseStyleColors = true;
            this.WalkonWater.CheckedChanged += new System.EventHandler(this.WalkonWaterToggled);
            // 
            // AlwaysElytra
            // 
            this.AlwaysElytra.AutoSize = true;
            this.AlwaysElytra.BackColor = System.Drawing.Color.Transparent;
            this.AlwaysElytra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AlwaysElytra.Location = new System.Drawing.Point(193, 27);
            this.AlwaysElytra.Name = "AlwaysElytra";
            this.AlwaysElytra.Size = new System.Drawing.Size(92, 15);
            this.AlwaysElytra.Style = MetroFramework.MetroColorStyle.Blue;
            this.AlwaysElytra.TabIndex = 97;
            this.AlwaysElytra.Tag = "NonHost";
            this.AlwaysElytra.Text = "Always Elytra";
            this.AlwaysElytra.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AlwaysElytra, "Allows you to fly as if you had an Elytra equipped");
            this.AlwaysElytra.UseSelectable = true;
            this.AlwaysElytra.UseStyleColors = true;
            this.AlwaysElytra.CheckedChanged += new System.EventHandler(this.AlwaysElytraToggled);
            // 
            // CaveFinder
            // 
            this.CaveFinder.AutoSize = true;
            this.CaveFinder.BackColor = System.Drawing.Color.Transparent;
            this.CaveFinder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaveFinder.Location = new System.Drawing.Point(193, 6);
            this.CaveFinder.Name = "CaveFinder";
            this.CaveFinder.Size = new System.Drawing.Size(85, 15);
            this.CaveFinder.Style = MetroFramework.MetroColorStyle.Blue;
            this.CaveFinder.TabIndex = 96;
            this.CaveFinder.Tag = "NonHost";
            this.CaveFinder.Text = "Cave Finder";
            this.CaveFinder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.CaveFinder, "Highlights Caves through blocks");
            this.CaveFinder.UseSelectable = true;
            this.CaveFinder.UseStyleColors = true;
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
            this.Wallhack.Style = MetroFramework.MetroColorStyle.Blue;
            this.Wallhack.TabIndex = 95;
            this.Wallhack.Tag = "NonHost";
            this.Wallhack.Text = "Wallhack";
            this.Wallhack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.Wallhack, "Nametags will be visible at any time");
            this.Wallhack.UseSelectable = true;
            this.Wallhack.UseStyleColors = true;
            this.Wallhack.CheckedChanged += new System.EventHandler(this.WallhackToggled);
            // 
            // LargeXPDrops
            // 
            this.LargeXPDrops.AutoSize = true;
            this.LargeXPDrops.BackColor = System.Drawing.Color.Transparent;
            this.LargeXPDrops.Location = new System.Drawing.Point(7, 384);
            this.LargeXPDrops.Name = "LargeXPDrops";
            this.LargeXPDrops.Size = new System.Drawing.Size(103, 15);
            this.LargeXPDrops.Style = MetroFramework.MetroColorStyle.Orange;
            this.LargeXPDrops.TabIndex = 94;
            this.LargeXPDrops.Tag = "Host";
            this.LargeXPDrops.Text = "Large XP Drops";
            this.LargeXPDrops.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.LargeXPDrops, "Increased XP Drops from Entities");
            this.LargeXPDrops.UseSelectable = true;
            this.LargeXPDrops.UseStyleColors = true;
            this.LargeXPDrops.CheckedChanged += new System.EventHandler(this.LargeXpDropsToggled);
            // 
            // WallClimbing
            // 
            this.WallClimbing.AutoSize = true;
            this.WallClimbing.BackColor = System.Drawing.Color.Transparent;
            this.WallClimbing.Location = new System.Drawing.Point(7, 363);
            this.WallClimbing.Name = "WallClimbing";
            this.WallClimbing.Size = new System.Drawing.Size(98, 15);
            this.WallClimbing.Style = MetroFramework.MetroColorStyle.Blue;
            this.WallClimbing.TabIndex = 93;
            this.WallClimbing.Tag = "NonHost";
            this.WallClimbing.Text = "Wall Climbing";
            this.WallClimbing.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.WallClimbing, "Any block will act as if they\'re ladders");
            this.WallClimbing.UseSelectable = true;
            this.WallClimbing.UseStyleColors = true;
            this.WallClimbing.CheckedChanged += new System.EventHandler(this.WallClimbingToggled);
            // 
            // NoCollision
            // 
            this.NoCollision.AutoSize = true;
            this.NoCollision.BackColor = System.Drawing.Color.Transparent;
            this.NoCollision.Location = new System.Drawing.Point(7, 321);
            this.NoCollision.Name = "NoCollision";
            this.NoCollision.Size = new System.Drawing.Size(88, 15);
            this.NoCollision.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoCollision.TabIndex = 92;
            this.NoCollision.Tag = "NonHost";
            this.NoCollision.Text = "No Collision";
            this.NoCollision.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.NoCollision, "Disables any block collision");
            this.NoCollision.UseSelectable = true;
            this.NoCollision.UseStyleColors = true;
            this.NoCollision.CheckedChanged += new System.EventHandler(this.NoCollisionToggled);
            // 
            // InfiniteAir
            // 
            this.InfiniteAir.AutoSize = true;
            this.InfiniteAir.BackColor = System.Drawing.Color.Transparent;
            this.InfiniteAir.Location = new System.Drawing.Point(7, 279);
            this.InfiniteAir.Name = "InfiniteAir";
            this.InfiniteAir.Size = new System.Drawing.Size(78, 15);
            this.InfiniteAir.Style = MetroFramework.MetroColorStyle.Orange;
            this.InfiniteAir.TabIndex = 91;
            this.InfiniteAir.Tag = "Host";
            this.InfiniteAir.Text = "Infinite Air";
            this.InfiniteAir.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.InfiniteAir, "Allows you to breathe underwater (or lava, or blocks).");
            this.InfiniteAir.UseSelectable = true;
            this.InfiniteAir.UseStyleColors = true;
            this.InfiniteAir.CheckedChanged += new System.EventHandler(this.InfiniteAirToggled);
            // 
            // InfiniteDurability
            // 
            this.InfiniteDurability.AutoSize = true;
            this.InfiniteDurability.BackColor = System.Drawing.Color.Transparent;
            this.InfiniteDurability.Location = new System.Drawing.Point(7, 300);
            this.InfiniteDurability.Name = "InfiniteDurability";
            this.InfiniteDurability.Size = new System.Drawing.Size(114, 15);
            this.InfiniteDurability.Style = MetroFramework.MetroColorStyle.Orange;
            this.InfiniteDurability.TabIndex = 90;
            this.InfiniteDurability.Tag = "Host";
            this.InfiniteDurability.Text = "Infinite Durability";
            this.InfiniteDurability.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.InfiniteDurability, "The durability of items will never decrease");
            this.InfiniteDurability.UseSelectable = true;
            this.InfiniteDurability.UseStyleColors = true;
            this.InfiniteDurability.CheckedChanged += new System.EventHandler(this.InfiniteDurabilityToggled);
            // 
            // SuperKnockback
            // 
            this.SuperKnockback.AutoSize = true;
            this.SuperKnockback.BackColor = System.Drawing.Color.Transparent;
            this.SuperKnockback.Location = new System.Drawing.Point(7, 258);
            this.SuperKnockback.Name = "SuperKnockback";
            this.SuperKnockback.Size = new System.Drawing.Size(114, 15);
            this.SuperKnockback.Style = MetroFramework.MetroColorStyle.Orange;
            this.SuperKnockback.TabIndex = 89;
            this.SuperKnockback.Tag = "Host";
            this.SuperKnockback.Text = "Super Knockback";
            this.SuperKnockback.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SuperKnockback, "Makes any form of knockback a lot stronger than before.");
            this.SuperKnockback.UseSelectable = true;
            this.SuperKnockback.UseStyleColors = true;
            this.SuperKnockback.CheckedChanged += new System.EventHandler(this.SuperKnockbackToggled);
            // 
            // DisabledKnockback
            // 
            this.DisabledKnockback.AutoSize = true;
            this.DisabledKnockback.BackColor = System.Drawing.Color.Transparent;
            this.DisabledKnockback.Location = new System.Drawing.Point(7, 237);
            this.DisabledKnockback.Name = "DisabledKnockback";
            this.DisabledKnockback.Size = new System.Drawing.Size(129, 15);
            this.DisabledKnockback.Style = MetroFramework.MetroColorStyle.Orange;
            this.DisabledKnockback.TabIndex = 88;
            this.DisabledKnockback.Tag = "Host";
            this.DisabledKnockback.Text = "Disabled Knockback";
            this.DisabledKnockback.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DisabledKnockback, "Any knockback will be disabled");
            this.DisabledKnockback.UseSelectable = true;
            this.DisabledKnockback.UseStyleColors = true;
            this.DisabledKnockback.CheckedChanged += new System.EventHandler(this.DisabledKnockbackToggled);
            // 
            // SilkTouchAnything
            // 
            this.SilkTouchAnything.AutoSize = true;
            this.SilkTouchAnything.BackColor = System.Drawing.Color.Transparent;
            this.SilkTouchAnything.Location = new System.Drawing.Point(7, 216);
            this.SilkTouchAnything.Name = "SilkTouchAnything";
            this.SilkTouchAnything.Size = new System.Drawing.Size(128, 15);
            this.SilkTouchAnything.Style = MetroFramework.MetroColorStyle.Orange;
            this.SilkTouchAnything.TabIndex = 87;
            this.SilkTouchAnything.Tag = "Host";
            this.SilkTouchAnything.Text = "Silk Touch Anything";
            this.SilkTouchAnything.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SilkTouchAnything, "Any block you break will act like Silk Touch was used on it");
            this.SilkTouchAnything.UseSelectable = true;
            this.SilkTouchAnything.UseStyleColors = true;
            this.SilkTouchAnything.CheckedChanged += new System.EventHandler(this.SilkTouchAnythingToggled);
            // 
            // DeveloperMode
            // 
            this.DeveloperMode.AutoSize = true;
            this.DeveloperMode.Location = new System.Drawing.Point(7, 195);
            this.DeveloperMode.Name = "DeveloperMode";
            this.DeveloperMode.Size = new System.Drawing.Size(110, 15);
            this.DeveloperMode.Style = MetroFramework.MetroColorStyle.Blue;
            this.DeveloperMode.TabIndex = 86;
            this.DeveloperMode.Tag = "NonHost";
            this.DeveloperMode.Text = "Developer Mode";
            this.DeveloperMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DeveloperMode, resources.GetString("DeveloperMode.ToolTip"));
            this.DeveloperMode.UseSelectable = true;
            this.DeveloperMode.UseStyleColors = true;
            this.DeveloperMode.CheckedChanged += new System.EventHandler(this.DeveloperModeToggled);
            // 
            // PickLiquidBlocks
            // 
            this.PickLiquidBlocks.AutoSize = true;
            this.PickLiquidBlocks.Location = new System.Drawing.Point(7, 174);
            this.PickLiquidBlocks.Name = "PickLiquidBlocks";
            this.PickLiquidBlocks.Size = new System.Drawing.Size(118, 15);
            this.PickLiquidBlocks.Style = MetroFramework.MetroColorStyle.Blue;
            this.PickLiquidBlocks.TabIndex = 85;
            this.PickLiquidBlocks.Tag = "NonHost";
            this.PickLiquidBlocks.Text = "Pick Liquid Blocks";
            this.PickLiquidBlocks.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.PickLiquidBlocks, "Allows you to use \"Pick Block\" on liquids");
            this.PickLiquidBlocks.UseSelectable = true;
            this.PickLiquidBlocks.UseStyleColors = true;
            this.PickLiquidBlocks.CheckedChanged += new System.EventHandler(this.PickLiquidBlocksToggled);
            // 
            // DuelWieldanyItem
            // 
            this.DuelWieldanyItem.AutoSize = true;
            this.DuelWieldanyItem.Location = new System.Drawing.Point(7, 153);
            this.DuelWieldanyItem.Name = "DuelWieldanyItem";
            this.DuelWieldanyItem.Size = new System.Drawing.Size(129, 15);
            this.DuelWieldanyItem.Style = MetroFramework.MetroColorStyle.Orange;
            this.DuelWieldanyItem.TabIndex = 84;
            this.DuelWieldanyItem.Tag = "Host";
            this.DuelWieldanyItem.Text = "Duel Wield any Item";
            this.DuelWieldanyItem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DuelWieldanyItem, "Allows you to place any item in your off-hand slot\r\nNOTE: This is purely visual, " +
        "the off-hand cannot be used");
            this.DuelWieldanyItem.UseSelectable = true;
            this.DuelWieldanyItem.UseStyleColors = true;
            this.DuelWieldanyItem.CheckedChanged += new System.EventHandler(this.DuelWieldAnyItemToggled);
            // 
            // DisableStarving
            // 
            this.DisableStarving.AutoSize = true;
            this.DisableStarving.Location = new System.Drawing.Point(7, 132);
            this.DisableStarving.Name = "DisableStarving";
            this.DisableStarving.Size = new System.Drawing.Size(107, 15);
            this.DisableStarving.Style = MetroFramework.MetroColorStyle.Orange;
            this.DisableStarving.TabIndex = 83;
            this.DisableStarving.Tag = "Host";
            this.DisableStarving.Text = "Disable Starving";
            this.DisableStarving.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DisableStarving, "You will no longer take damage when starving");
            this.DisableStarving.UseSelectable = true;
            this.DisableStarving.UseStyleColors = true;
            this.DisableStarving.CheckedChanged += new System.EventHandler(this.DisableStarvingToggled);
            // 
            // InstantMining
            // 
            this.InstantMining.AutoSize = true;
            this.InstantMining.Location = new System.Drawing.Point(7, 111);
            this.InstantMining.Name = "InstantMining";
            this.InstantMining.Size = new System.Drawing.Size(100, 15);
            this.InstantMining.Style = MetroFramework.MetroColorStyle.Orange;
            this.InstantMining.TabIndex = 82;
            this.InstantMining.Tag = "Host";
            this.InstantMining.Text = "Instant Mining";
            this.InstantMining.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.InstantMining, "Allows you to break any blocks instantly");
            this.InstantMining.UseSelectable = true;
            this.InstantMining.UseStyleColors = true;
            this.InstantMining.CheckedChanged += new System.EventHandler(this.InstantMiningToggled);
            // 
            // Flight
            // 
            this.Flight.AutoSize = true;
            this.Flight.Location = new System.Drawing.Point(7, 90);
            this.Flight.Name = "Flight";
            this.Flight.Size = new System.Drawing.Size(53, 15);
            this.Flight.Style = MetroFramework.MetroColorStyle.Blue;
            this.Flight.TabIndex = 81;
            this.Flight.Tag = "NonHost";
            this.Flight.Text = "Flight";
            this.Flight.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.Flight, "Allows you to fly regardless of what gametype, gamemode \r\nand permissions");
            this.Flight.UseSelectable = true;
            this.Flight.UseStyleColors = true;
            this.Flight.CheckedChanged += new System.EventHandler(this.FlightToggled);
            // 
            // DisableSuffocating
            // 
            this.DisableSuffocating.AutoSize = true;
            this.DisableSuffocating.Location = new System.Drawing.Point(7, 69);
            this.DisableSuffocating.Name = "DisableSuffocating";
            this.DisableSuffocating.Size = new System.Drawing.Size(125, 15);
            this.DisableSuffocating.Style = MetroFramework.MetroColorStyle.Orange;
            this.DisableSuffocating.TabIndex = 80;
            this.DisableSuffocating.Tag = "Host";
            this.DisableSuffocating.Text = "Disable Suffocating";
            this.DisableSuffocating.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DisableSuffocating, "Entities will no longer suffocate");
            this.DisableSuffocating.UseSelectable = true;
            this.DisableSuffocating.UseStyleColors = true;
            this.DisableSuffocating.CheckedChanged += new System.EventHandler(this.DisableSuffocatingToggled);
            // 
            // NoFallDamage
            // 
            this.NoFallDamage.AutoSize = true;
            this.NoFallDamage.Location = new System.Drawing.Point(7, 48);
            this.NoFallDamage.Name = "NoFallDamage";
            this.NoFallDamage.Size = new System.Drawing.Size(107, 15);
            this.NoFallDamage.Style = MetroFramework.MetroColorStyle.Orange;
            this.NoFallDamage.TabIndex = 79;
            this.NoFallDamage.Tag = "Host";
            this.NoFallDamage.Text = "No Fall Damage";
            this.NoFallDamage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.NoFallDamage, "You won\'t take damage when falling");
            this.NoFallDamage.UseSelectable = true;
            this.NoFallDamage.UseStyleColors = true;
            this.NoFallDamage.CheckedChanged += new System.EventHandler(this.NoFallDamageToggled);
            // 
            // CraftAnything
            // 
            this.CraftAnything.AutoSize = true;
            this.CraftAnything.Location = new System.Drawing.Point(7, 27);
            this.CraftAnything.Name = "CraftAnything";
            this.CraftAnything.Size = new System.Drawing.Size(101, 15);
            this.CraftAnything.Style = MetroFramework.MetroColorStyle.Blue;
            this.CraftAnything.TabIndex = 78;
            this.CraftAnything.Tag = "NonHost";
            this.CraftAnything.Text = "Craft Anything";
            this.CraftAnything.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.CraftAnything, "Allows you to craft anything without needing the required resources\r\nNOTE: This m" +
        "od has a side effect of making thunder go \r\ncrazy if it is storming");
            this.CraftAnything.UseSelectable = true;
            this.CraftAnything.UseStyleColors = true;
            this.CraftAnything.CheckedChanged += new System.EventHandler(this.CraftAnythingToggled);
            // 
            // CreativeMode
            // 
            this.CreativeMode.AutoSize = true;
            this.CreativeMode.BackColor = System.Drawing.Color.Transparent;
            this.CreativeMode.Location = new System.Drawing.Point(7, 6);
            this.CreativeMode.Name = "CreativeMode";
            this.CreativeMode.Size = new System.Drawing.Size(66, 15);
            this.CreativeMode.Style = MetroFramework.MetroColorStyle.Orange;
            this.CreativeMode.TabIndex = 77;
            this.CreativeMode.Tag = "Host";
            this.CreativeMode.Text = "Creative";
            this.CreativeMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.CreativeMode, "Allows the Creative Menu to be used regardless of \r\nwhat gametype and gamemode");
            this.CreativeMode.UseSelectable = true;
            this.CreativeMode.UseStyleColors = true;
            this.CreativeMode.CheckedChanged += new System.EventHandler(this.CreativeModeToggled);
            // 
            // worldTab
            // 
            this.worldTab.Controls.Add(this.BubbleColumnAnywhere);
            this.worldTab.Controls.Add(this.FogDistanceSlider);
            this.worldTab.Controls.Add(this.FogDistance);
            this.worldTab.Controls.Add(this.EntityEditorBtn);
            this.worldTab.Controls.Add(this.ThunderMode);
            this.worldTab.Controls.Add(this.RainMode);
            this.worldTab.Controls.Add(this.WorldGenerationOptsBtn);
            this.worldTab.Controls.Add(this.Collision);
            this.worldTab.Controls.Add(this.DisableFallingBlocks);
            this.worldTab.Controls.Add(this.LiquidSpreadTimeSlider);
            this.worldTab.Controls.Add(this.LiquidSpreadTime);
            this.worldTab.Controls.Add(this.InvulnerableEntities);
            this.worldTab.Controls.Add(this.SleepingDoesntClearWeather);
            this.worldTab.Controls.Add(this.EntitySpeedSlider);
            this.worldTab.Controls.Add(this.EntitySpeed);
            this.worldTab.Controls.Add(this.SuperFurnace);
            this.worldTab.Controls.Add(this.WaterLogAnything);
            this.worldTab.Controls.Add(this.LootTableEditorBtn);
            this.worldTab.Controls.Add(this.LeashAnyMobs);
            this.worldTab.Controls.Add(this.SunProofMobs);
            this.worldTab.Controls.Add(this.DisableCreativeFlag);
            this.worldTab.Controls.Add(this.ZombieTower);
            this.worldTab.Controls.Add(this.Entities);
            this.worldTab.Controls.Add(this.IgnitedCreepers);
            this.worldTab.Controls.Add(this.SuperchargedCreepers);
            this.worldTab.Controls.Add(this.UncapEntitySpawnLimit);
            this.worldTab.Controls.Add(this.AcidLiquidBlocks);
            this.worldTab.Controls.Add(this.World);
            this.worldTab.Controls.Add(this.FoggyWeather);
            this.worldTab.Controls.Add(this.worldPnl);
            this.worldTab.Controls.Add(this.StaticLiquidBlocks);
            this.worldTab.Controls.Add(this.NoFog);
            this.worldTab.HorizontalScrollbarBarColor = true;
            this.worldTab.HorizontalScrollbarHighlightOnWheel = false;
            this.worldTab.HorizontalScrollbarSize = 10;
            this.worldTab.Location = new System.Drawing.Point(4, 9);
            this.worldTab.Name = "worldTab";
            this.worldTab.Padding = new System.Windows.Forms.Padding(3);
            this.worldTab.Size = new System.Drawing.Size(1122, 630);
            this.worldTab.TabIndex = 1;
            this.worldTab.Tag = "GeckoURequired";
            this.worldTab.Text = "World and Entities";
            this.worldTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.worldTab.VerticalScrollbarBarColor = true;
            this.worldTab.VerticalScrollbarHighlightOnWheel = false;
            this.worldTab.VerticalScrollbarSize = 10;
            // 
            // BubbleColumnAnywhere
            // 
            this.BubbleColumnAnywhere.AutoSize = true;
            this.BubbleColumnAnywhere.BackColor = System.Drawing.Color.Transparent;
            this.BubbleColumnAnywhere.Location = new System.Drawing.Point(7, 256);
            this.BubbleColumnAnywhere.Name = "BubbleColumnAnywhere";
            this.BubbleColumnAnywhere.Size = new System.Drawing.Size(162, 15);
            this.BubbleColumnAnywhere.Style = MetroFramework.MetroColorStyle.Orange;
            this.BubbleColumnAnywhere.TabIndex = 149;
            this.BubbleColumnAnywhere.Tag = "Host";
            this.BubbleColumnAnywhere.Text = "Bubble Column Anywhere";
            this.BubbleColumnAnywhere.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.BubbleColumnAnywhere, "Bubble Columns can be created regardless\r\nof whether the water is a source block");
            this.BubbleColumnAnywhere.UseSelectable = true;
            this.BubbleColumnAnywhere.UseStyleColors = true;
            this.BubbleColumnAnywhere.CheckedChanged += new System.EventHandler(this.BubbleColumnAnywhereToggled);
            // 
            // FogDistanceSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.FogDistanceSlider, true);
            this.FogDistanceSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.FogDistanceSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.FogDistanceSlider.Location = new System.Drawing.Point(102, 604);
            this.FogDistanceSlider.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.FogDistanceSlider.Name = "FogDistanceSlider";
            this.FogDistanceSlider.Size = new System.Drawing.Size(1015, 20);
            this.FogDistanceSlider.TabIndex = 148;
            this.FogDistanceSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.FogDistanceSlider, "How far away is the fog?");
            this.FogDistanceSlider.ValueChanged += new System.EventHandler(this.FogDistanceSliderChanged);
            // 
            // FogDistance
            // 
            this.FogDistance.AutoSize = true;
            this.FogDistance.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.FogDistance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FogDistance.Location = new System.Drawing.Point(5, 604);
            this.FogDistance.Name = "FogDistance";
            this.FogDistance.Size = new System.Drawing.Size(91, 19);
            this.FogDistance.Style = MetroFramework.MetroColorStyle.Orange;
            this.FogDistance.TabIndex = 147;
            this.FogDistance.Tag = "Host";
            this.FogDistance.Text = "Fog Distance:";
            this.FogDistance.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FogDistance.UseStyleColors = true;
            // 
            // EntityEditorBtn
            // 
            this.EntityEditorBtn.Location = new System.Drawing.Point(8, 494);
            this.EntityEditorBtn.Name = "EntityEditorBtn";
            this.EntityEditorBtn.Size = new System.Drawing.Size(1109, 23);
            this.EntityEditorBtn.Style = MetroFramework.MetroColorStyle.Orange;
            this.EntityEditorBtn.TabIndex = 146;
            this.EntityEditorBtn.Tag = "Host";
            this.EntityEditorBtn.Text = "Entity Editor";
            this.EntityEditorBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.EntityEditorBtn, "Opens the Entity Editor, a mod which allows you to edit Entity data");
            this.EntityEditorBtn.UseSelectable = true;
            this.EntityEditorBtn.UseStyleColors = true;
            this.EntityEditorBtn.Click += new System.EventHandler(this.EntityEditorBtnClicked);
            // 
            // ThunderMode
            // 
            this.ThunderMode.AutoSize = true;
            this.ThunderMode.BackColor = System.Drawing.Color.Transparent;
            this.ThunderMode.Location = new System.Drawing.Point(7, 235);
            this.ThunderMode.Name = "ThunderMode";
            this.ThunderMode.Size = new System.Drawing.Size(150, 15);
            this.ThunderMode.Style = MetroFramework.MetroColorStyle.Orange;
            this.ThunderMode.TabIndex = 145;
            this.ThunderMode.Tag = "Host";
            this.ThunderMode.Text = "Thunder Mode (Default)";
            this.ThunderMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ThunderMode.ThreeState = true;
            this.ToolTipManager.SetToolTip(this.ThunderMode, "Whether it thunders or not");
            this.ThunderMode.UseSelectable = true;
            this.ThunderMode.UseStyleColors = true;
            this.ThunderMode.CheckStateChanged += new System.EventHandler(this.ThunderModeToggled);
            // 
            // RainMode
            // 
            this.RainMode.AutoSize = true;
            this.RainMode.BackColor = System.Drawing.Color.Transparent;
            this.RainMode.Location = new System.Drawing.Point(7, 214);
            this.RainMode.Name = "RainMode";
            this.RainMode.Size = new System.Drawing.Size(129, 15);
            this.RainMode.Style = MetroFramework.MetroColorStyle.Orange;
            this.RainMode.TabIndex = 144;
            this.RainMode.Tag = "Host";
            this.RainMode.Text = "Rain Mode (Default)";
            this.RainMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RainMode.ThreeState = true;
            this.ToolTipManager.SetToolTip(this.RainMode, "Whether it rains or not");
            this.RainMode.UseSelectable = true;
            this.RainMode.UseStyleColors = true;
            this.RainMode.CheckStateChanged += new System.EventHandler(this.RainModeToggled);
            // 
            // WorldGenerationOptsBtn
            // 
            this.WorldGenerationOptsBtn.Location = new System.Drawing.Point(567, 523);
            this.WorldGenerationOptsBtn.Name = "WorldGenerationOptsBtn";
            this.WorldGenerationOptsBtn.Size = new System.Drawing.Size(550, 23);
            this.WorldGenerationOptsBtn.Style = MetroFramework.MetroColorStyle.Orange;
            this.WorldGenerationOptsBtn.TabIndex = 143;
            this.WorldGenerationOptsBtn.Tag = "Host";
            this.WorldGenerationOptsBtn.Text = "World Generation Editor";
            this.WorldGenerationOptsBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.WorldGenerationOptsBtn, "Opens the World Generation Editor");
            this.WorldGenerationOptsBtn.UseSelectable = true;
            this.WorldGenerationOptsBtn.UseStyleColors = true;
            this.WorldGenerationOptsBtn.Click += new System.EventHandler(this.WorldGenerationOptsBtnClicked);
            // 
            // Collision
            // 
            this.Collision.AutoSize = true;
            this.Collision.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Collision.Location = new System.Drawing.Point(475, 172);
            this.Collision.Name = "Collision";
            this.Collision.Size = new System.Drawing.Size(69, 15);
            this.Collision.Style = MetroFramework.MetroColorStyle.Blue;
            this.Collision.TabIndex = 142;
            this.Collision.Tag = "NonHost";
            this.Collision.Text = "Collision";
            this.Collision.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.Collision, "Collision for entities are disabled");
            this.Collision.UseSelectable = true;
            this.Collision.UseStyleColors = true;
            this.Collision.CheckedChanged += new System.EventHandler(this.CollisionToggled);
            // 
            // DisableFallingBlocks
            // 
            this.DisableFallingBlocks.AutoSize = true;
            this.DisableFallingBlocks.BackColor = System.Drawing.Color.Transparent;
            this.DisableFallingBlocks.Location = new System.Drawing.Point(7, 193);
            this.DisableFallingBlocks.Name = "DisableFallingBlocks";
            this.DisableFallingBlocks.Size = new System.Drawing.Size(136, 15);
            this.DisableFallingBlocks.Style = MetroFramework.MetroColorStyle.Orange;
            this.DisableFallingBlocks.TabIndex = 132;
            this.DisableFallingBlocks.Tag = "Host";
            this.DisableFallingBlocks.Text = "Disable Falling Blocks";
            this.DisableFallingBlocks.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DisableFallingBlocks, "Disables gravity on blocks that are affected by it");
            this.DisableFallingBlocks.UseSelectable = true;
            this.DisableFallingBlocks.UseStyleColors = true;
            this.DisableFallingBlocks.CheckedChanged += new System.EventHandler(this.DisableFallingBlocksToggled);
            // 
            // LiquidSpreadTimeSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.LiquidSpreadTimeSlider, true);
            this.LiquidSpreadTimeSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.LiquidSpreadTimeSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.LiquidSpreadTimeSlider.Location = new System.Drawing.Point(140, 578);
            this.LiquidSpreadTimeSlider.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.LiquidSpreadTimeSlider.Name = "LiquidSpreadTimeSlider";
            this.LiquidSpreadTimeSlider.Size = new System.Drawing.Size(977, 20);
            this.LiquidSpreadTimeSlider.TabIndex = 131;
            this.LiquidSpreadTimeSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.LiquidSpreadTimeSlider, "How fast should liquid blocks (water, lava) spread in ticks?");
            this.LiquidSpreadTimeSlider.ValueChanged += new System.EventHandler(this.LiquidSpreadTimeSliderChanged);
            // 
            // LiquidSpreadTime
            // 
            this.LiquidSpreadTime.AutoSize = true;
            this.LiquidSpreadTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LiquidSpreadTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LiquidSpreadTime.Location = new System.Drawing.Point(5, 578);
            this.LiquidSpreadTime.Name = "LiquidSpreadTime";
            this.LiquidSpreadTime.Size = new System.Drawing.Size(128, 19);
            this.LiquidSpreadTime.Style = MetroFramework.MetroColorStyle.Orange;
            this.LiquidSpreadTime.TabIndex = 130;
            this.LiquidSpreadTime.Tag = "Host";
            this.LiquidSpreadTime.Text = "Liquid Spread Time:";
            this.LiquidSpreadTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LiquidSpreadTime.UseStyleColors = true;
            // 
            // InvulnerableEntities
            // 
            this.InvulnerableEntities.AutoSize = true;
            this.InvulnerableEntities.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InvulnerableEntities.Location = new System.Drawing.Point(475, 151);
            this.InvulnerableEntities.Name = "InvulnerableEntities";
            this.InvulnerableEntities.Size = new System.Drawing.Size(129, 15);
            this.InvulnerableEntities.Style = MetroFramework.MetroColorStyle.Orange;
            this.InvulnerableEntities.TabIndex = 129;
            this.InvulnerableEntities.Tag = "Host";
            this.InvulnerableEntities.Text = "Invulnerable Entities";
            this.InvulnerableEntities.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.InvulnerableEntities, "Entities will not take any damage");
            this.InvulnerableEntities.UseSelectable = true;
            this.InvulnerableEntities.UseStyleColors = true;
            this.InvulnerableEntities.CheckedChanged += new System.EventHandler(this.InvulnerableEntitiesToggled);
            // 
            // SleepingDoesntClearWeather
            // 
            this.SleepingDoesntClearWeather.AutoSize = true;
            this.SleepingDoesntClearWeather.BackColor = System.Drawing.Color.Transparent;
            this.SleepingDoesntClearWeather.Location = new System.Drawing.Point(7, 172);
            this.SleepingDoesntClearWeather.Name = "SleepingDoesntClearWeather";
            this.SleepingDoesntClearWeather.Size = new System.Drawing.Size(183, 15);
            this.SleepingDoesntClearWeather.Style = MetroFramework.MetroColorStyle.Orange;
            this.SleepingDoesntClearWeather.TabIndex = 128;
            this.SleepingDoesntClearWeather.Tag = "Host";
            this.SleepingDoesntClearWeather.Text = "Sleeping doesn\'t clear weather";
            this.SleepingDoesntClearWeather.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SleepingDoesntClearWeather, "Sleeping doesn\'t clear the weather");
            this.SleepingDoesntClearWeather.UseSelectable = true;
            this.SleepingDoesntClearWeather.UseStyleColors = true;
            this.SleepingDoesntClearWeather.CheckedChanged += new System.EventHandler(this.SleepingDoesntClearWeatherToggled);
            // 
            // EntitySpeedSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.EntitySpeedSlider, true);
            this.EntitySpeedSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.EntitySpeedSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.EntitySpeedSlider.Location = new System.Drawing.Point(108, 552);
            this.EntitySpeedSlider.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.EntitySpeedSlider.Name = "EntitySpeedSlider";
            this.EntitySpeedSlider.Size = new System.Drawing.Size(1009, 20);
            this.EntitySpeedSlider.TabIndex = 127;
            this.EntitySpeedSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.EntitySpeedSlider, "How fast should entities be? (Includes tile entities)");
            this.EntitySpeedSlider.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.EntitySpeedSlider.ValueChanged += new System.EventHandler(this.EntitySpeedSliderChanged);
            // 
            // EntitySpeed
            // 
            this.EntitySpeed.AutoSize = true;
            this.EntitySpeed.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.EntitySpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EntitySpeed.Location = new System.Drawing.Point(5, 552);
            this.EntitySpeed.Name = "EntitySpeed";
            this.EntitySpeed.Size = new System.Drawing.Size(97, 19);
            this.EntitySpeed.Style = MetroFramework.MetroColorStyle.Blue;
            this.EntitySpeed.TabIndex = 126;
            this.EntitySpeed.Tag = "NonHost";
            this.EntitySpeed.Text = "Entities Speed:";
            this.EntitySpeed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.EntitySpeed.UseStyleColors = true;
            // 
            // SuperFurnace
            // 
            this.SuperFurnace.AutoSize = true;
            this.SuperFurnace.BackColor = System.Drawing.Color.Transparent;
            this.SuperFurnace.Location = new System.Drawing.Point(7, 151);
            this.SuperFurnace.Name = "SuperFurnace";
            this.SuperFurnace.Size = new System.Drawing.Size(98, 15);
            this.SuperFurnace.Style = MetroFramework.MetroColorStyle.Orange;
            this.SuperFurnace.TabIndex = 50;
            this.SuperFurnace.Tag = "Host";
            this.SuperFurnace.Text = "Super Furnace";
            this.SuperFurnace.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SuperFurnace, "Items in a furnace will smell instantly");
            this.SuperFurnace.UseSelectable = true;
            this.SuperFurnace.UseStyleColors = true;
            this.SuperFurnace.CheckedChanged += new System.EventHandler(this.SuperFurnaceToggled);
            // 
            // WaterLogAnything
            // 
            this.WaterLogAnything.AutoSize = true;
            this.WaterLogAnything.BackColor = System.Drawing.Color.Transparent;
            this.WaterLogAnything.Location = new System.Drawing.Point(8, 130);
            this.WaterLogAnything.Name = "WaterLogAnything";
            this.WaterLogAnything.Size = new System.Drawing.Size(129, 15);
            this.WaterLogAnything.Style = MetroFramework.MetroColorStyle.Orange;
            this.WaterLogAnything.TabIndex = 49;
            this.WaterLogAnything.Tag = "Host";
            this.WaterLogAnything.Text = "Water Log Anything";
            this.WaterLogAnything.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.WaterLogAnything, "Allows you to water log any blocks");
            this.WaterLogAnything.UseSelectable = true;
            this.WaterLogAnything.UseStyleColors = true;
            this.WaterLogAnything.CheckedChanged += new System.EventHandler(this.WaterLogAnythingToggled);
            // 
            // LootTableEditorBtn
            // 
            this.LootTableEditorBtn.Location = new System.Drawing.Point(8, 523);
            this.LootTableEditorBtn.Name = "LootTableEditorBtn";
            this.LootTableEditorBtn.Size = new System.Drawing.Size(550, 23);
            this.LootTableEditorBtn.Style = MetroFramework.MetroColorStyle.Orange;
            this.LootTableEditorBtn.TabIndex = 48;
            this.LootTableEditorBtn.Tag = "Host";
            this.LootTableEditorBtn.Text = "Loot Table Editor";
            this.LootTableEditorBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.LootTableEditorBtn, "Opens the Loot Table Editor, a mod which allows you to swap entity loot tables");
            this.LootTableEditorBtn.UseSelectable = true;
            this.LootTableEditorBtn.UseStyleColors = true;
            this.LootTableEditorBtn.Click += new System.EventHandler(this.LootTableEditorBtnClicked);
            // 
            // LeashAnyMobs
            // 
            this.LeashAnyMobs.AutoSize = true;
            this.LeashAnyMobs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LeashAnyMobs.Location = new System.Drawing.Point(475, 130);
            this.LeashAnyMobs.Name = "LeashAnyMobs";
            this.LeashAnyMobs.Size = new System.Drawing.Size(108, 15);
            this.LeashAnyMobs.Style = MetroFramework.MetroColorStyle.Orange;
            this.LeashAnyMobs.TabIndex = 47;
            this.LeashAnyMobs.Tag = "Host";
            this.LeashAnyMobs.Text = "Leash any mobs";
            this.LeashAnyMobs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.LeashAnyMobs, "Allows you to leash any mobs");
            this.LeashAnyMobs.UseSelectable = true;
            this.LeashAnyMobs.UseStyleColors = true;
            this.LeashAnyMobs.CheckedChanged += new System.EventHandler(this.LeashAnyMobsToggled);
            // 
            // SunProofMobs
            // 
            this.SunProofMobs.AutoSize = true;
            this.SunProofMobs.Location = new System.Drawing.Point(475, 109);
            this.SunProofMobs.Name = "SunProofMobs";
            this.SunProofMobs.Size = new System.Drawing.Size(108, 15);
            this.SunProofMobs.Style = MetroFramework.MetroColorStyle.Orange;
            this.SunProofMobs.TabIndex = 21;
            this.SunProofMobs.Tag = "Host";
            this.SunProofMobs.Text = "Sun Proof Mobs";
            this.SunProofMobs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SunProofMobs, "Entities which are harmed by sunlight\r\ncan now survive during the day");
            this.SunProofMobs.UseSelectable = true;
            this.SunProofMobs.UseStyleColors = true;
            this.SunProofMobs.CheckedChanged += new System.EventHandler(this.SunProofMobsToggled);
            // 
            // DisableCreativeFlag
            // 
            this.DisableCreativeFlag.AutoSize = true;
            this.DisableCreativeFlag.BackColor = System.Drawing.Color.Transparent;
            this.DisableCreativeFlag.Location = new System.Drawing.Point(7, 67);
            this.DisableCreativeFlag.Name = "DisableCreativeFlag";
            this.DisableCreativeFlag.Size = new System.Drawing.Size(132, 15);
            this.DisableCreativeFlag.Style = MetroFramework.MetroColorStyle.Orange;
            this.DisableCreativeFlag.TabIndex = 21;
            this.DisableCreativeFlag.Tag = "Host";
            this.DisableCreativeFlag.Text = "Disable Creative Flag";
            this.DisableCreativeFlag.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DisableCreativeFlag, "Disables the \"Played in Creative\" notification");
            this.DisableCreativeFlag.UseSelectable = true;
            this.DisableCreativeFlag.UseStyleColors = true;
            this.DisableCreativeFlag.CheckedChanged += new System.EventHandler(this.DisableCreativeFlagToggled);
            // 
            // ZombieTower
            // 
            this.ZombieTower.AutoSize = true;
            this.ZombieTower.Location = new System.Drawing.Point(475, 88);
            this.ZombieTower.Name = "ZombieTower";
            this.ZombieTower.Size = new System.Drawing.Size(98, 15);
            this.ZombieTower.Style = MetroFramework.MetroColorStyle.Orange;
            this.ZombieTower.TabIndex = 20;
            this.ZombieTower.Tag = "Host";
            this.ZombieTower.Text = "Zombie Tower";
            this.ZombieTower.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.ZombieTower, "Zombies will sit attempt to sit on nearby\r\nentities");
            this.ZombieTower.UseSelectable = true;
            this.ZombieTower.UseStyleColors = true;
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
            this.Entities.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // IgnitedCreepers
            // 
            this.IgnitedCreepers.AutoSize = true;
            this.IgnitedCreepers.Location = new System.Drawing.Point(475, 67);
            this.IgnitedCreepers.Name = "IgnitedCreepers";
            this.IgnitedCreepers.Size = new System.Drawing.Size(109, 15);
            this.IgnitedCreepers.Style = MetroFramework.MetroColorStyle.Orange;
            this.IgnitedCreepers.TabIndex = 19;
            this.IgnitedCreepers.Tag = "Host";
            this.IgnitedCreepers.Text = "Ignited Creepers";
            this.IgnitedCreepers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.IgnitedCreepers, "Creepers will always be ignited");
            this.IgnitedCreepers.UseSelectable = true;
            this.IgnitedCreepers.UseStyleColors = true;
            this.IgnitedCreepers.CheckedChanged += new System.EventHandler(this.IgnitedCreepersToggled);
            // 
            // SuperchargedCreepers
            // 
            this.SuperchargedCreepers.AutoSize = true;
            this.SuperchargedCreepers.Location = new System.Drawing.Point(475, 46);
            this.SuperchargedCreepers.Name = "SuperchargedCreepers";
            this.SuperchargedCreepers.Size = new System.Drawing.Size(145, 15);
            this.SuperchargedCreepers.Style = MetroFramework.MetroColorStyle.Orange;
            this.SuperchargedCreepers.TabIndex = 18;
            this.SuperchargedCreepers.Tag = "Host";
            this.SuperchargedCreepers.Text = "Supercharged Creepers";
            this.SuperchargedCreepers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SuperchargedCreepers, "Creepers will always be supercharged");
            this.SuperchargedCreepers.UseSelectable = true;
            this.SuperchargedCreepers.UseStyleColors = true;
            this.SuperchargedCreepers.CheckedChanged += new System.EventHandler(this.SuperchargedCreepersToggled);
            // 
            // UncapEntitySpawnLimit
            // 
            this.UncapEntitySpawnLimit.AutoSize = true;
            this.UncapEntitySpawnLimit.Location = new System.Drawing.Point(475, 25);
            this.UncapEntitySpawnLimit.Name = "UncapEntitySpawnLimit";
            this.UncapEntitySpawnLimit.Size = new System.Drawing.Size(158, 15);
            this.UncapEntitySpawnLimit.Style = MetroFramework.MetroColorStyle.Orange;
            this.UncapEntitySpawnLimit.TabIndex = 17;
            this.UncapEntitySpawnLimit.Tag = "Host";
            this.UncapEntitySpawnLimit.Text = "Uncap Entity Spawn Limit";
            this.UncapEntitySpawnLimit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.UncapEntitySpawnLimit, "Removes the spawn limit for entities");
            this.UncapEntitySpawnLimit.UseSelectable = true;
            this.UncapEntitySpawnLimit.UseStyleColors = true;
            this.UncapEntitySpawnLimit.CheckedChanged += new System.EventHandler(this.UncapEntitySpawnLimitToggled);
            // 
            // AcidLiquidBlocks
            // 
            this.AcidLiquidBlocks.AutoSize = true;
            this.AcidLiquidBlocks.BackColor = System.Drawing.Color.Transparent;
            this.AcidLiquidBlocks.Location = new System.Drawing.Point(7, 88);
            this.AcidLiquidBlocks.Name = "AcidLiquidBlocks";
            this.AcidLiquidBlocks.Size = new System.Drawing.Size(120, 15);
            this.AcidLiquidBlocks.Style = MetroFramework.MetroColorStyle.Orange;
            this.AcidLiquidBlocks.TabIndex = 22;
            this.AcidLiquidBlocks.Tag = "Host";
            this.AcidLiquidBlocks.Text = "Acid Liquid Blocks";
            this.AcidLiquidBlocks.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AcidLiquidBlocks, "Liquid Blocks will destroy any blocks they touch");
            this.AcidLiquidBlocks.UseSelectable = true;
            this.AcidLiquidBlocks.UseStyleColors = true;
            this.AcidLiquidBlocks.CheckedChanged += new System.EventHandler(this.AcidLiquidBlocksToggled);
            // 
            // World
            // 
            this.World.AutoSize = true;
            this.World.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.World.Location = new System.Drawing.Point(3, 3);
            this.World.Name = "World";
            this.World.Size = new System.Drawing.Size(96, 19);
            this.World.TabIndex = 44;
            this.World.Text = "World / Blocks";
            this.World.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FoggyWeather
            // 
            this.FoggyWeather.AutoSize = true;
            this.FoggyWeather.Location = new System.Drawing.Point(7, 25);
            this.FoggyWeather.Name = "FoggyWeather";
            this.FoggyWeather.Size = new System.Drawing.Size(103, 15);
            this.FoggyWeather.Style = MetroFramework.MetroColorStyle.Blue;
            this.FoggyWeather.TabIndex = 24;
            this.FoggyWeather.Tag = "NonHost";
            this.FoggyWeather.Text = "Foggy Weather";
            this.FoggyWeather.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.FoggyWeather, "Your screen will be covered in fog");
            this.FoggyWeather.UseSelectable = true;
            this.FoggyWeather.UseStyleColors = true;
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
            this.worldPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.worldPnl.VerticalScrollbarBarColor = true;
            this.worldPnl.VerticalScrollbarHighlightOnWheel = false;
            this.worldPnl.VerticalScrollbarSize = 10;
            // 
            // StaticLiquidBlocks
            // 
            this.StaticLiquidBlocks.AutoSize = true;
            this.StaticLiquidBlocks.BackColor = System.Drawing.Color.Transparent;
            this.StaticLiquidBlocks.Location = new System.Drawing.Point(7, 109);
            this.StaticLiquidBlocks.Name = "StaticLiquidBlocks";
            this.StaticLiquidBlocks.Size = new System.Drawing.Size(125, 15);
            this.StaticLiquidBlocks.Style = MetroFramework.MetroColorStyle.Orange;
            this.StaticLiquidBlocks.TabIndex = 25;
            this.StaticLiquidBlocks.Tag = "Host";
            this.StaticLiquidBlocks.Text = "Static Liquid Blocks";
            this.StaticLiquidBlocks.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.StaticLiquidBlocks, "Liquids will be contained");
            this.StaticLiquidBlocks.UseSelectable = true;
            this.StaticLiquidBlocks.UseStyleColors = true;
            this.StaticLiquidBlocks.CheckedChanged += new System.EventHandler(this.StaticLiquidBlocksToggled);
            // 
            // NoFog
            // 
            this.NoFog.AutoSize = true;
            this.NoFog.BackColor = System.Drawing.Color.Transparent;
            this.NoFog.Location = new System.Drawing.Point(7, 46);
            this.NoFog.Name = "NoFog";
            this.NoFog.Size = new System.Drawing.Size(62, 15);
            this.NoFog.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoFog.TabIndex = 26;
            this.NoFog.Tag = "NonHost";
            this.NoFog.Text = "No Fog";
            this.NoFog.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.NoFog, "Removes any fog");
            this.NoFog.UseSelectable = true;
            this.NoFog.UseStyleColors = true;
            this.NoFog.CheckedChanged += new System.EventHandler(this.NoFogToggled);
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.KeyboardCustomizerBtn);
            this.generalTab.Controls.Add(this.DebugConsoleCustomizerBtn);
            this.generalTab.Controls.Add(this.CursedSlider);
            this.generalTab.Controls.Add(this.CursedLbl);
            this.generalTab.Controls.Add(this.DLCManagerBtn);
            this.generalTab.Controls.Add(this.PreventBeingKicked);
            this.generalTab.Controls.Add(this.Cursed);
            this.generalTab.Controls.Add(this.FreezeGameWhenPaused);
            this.generalTab.Controls.Add(this.AchievementsEverywhere);
            this.generalTab.Controls.Add(this.MuteMicrophone);
            this.generalTab.Controls.Add(this.AchievementEditor);
            this.generalTab.Controls.Add(this.UnlockSignKeyboard);
            this.generalTab.Controls.Add(this.DebugConsole);
            this.generalTab.Controls.Add(this.Game);
            this.generalTab.Controls.Add(this.UIUserInterface);
            this.generalTab.Controls.Add(this.generalPanel);
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
            this.generalTab.Location = new System.Drawing.Point(4, 9);
            this.generalTab.Name = "generalTab";
            this.generalTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalTab.Size = new System.Drawing.Size(1122, 630);
            this.generalTab.TabIndex = 2;
            this.generalTab.Tag = "GeckoURequired";
            this.generalTab.Text = "General Game";
            this.generalTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.generalTab.VerticalScrollbarBarColor = true;
            this.generalTab.VerticalScrollbarHighlightOnWheel = false;
            this.generalTab.VerticalScrollbarSize = 10;
            // 
            // KeyboardCustomizerBtn
            // 
            this.KeyboardCustomizerBtn.Enabled = false;
            this.KeyboardCustomizerBtn.Location = new System.Drawing.Point(286, 481);
            this.KeyboardCustomizerBtn.Name = "KeyboardCustomizerBtn";
            this.KeyboardCustomizerBtn.Size = new System.Drawing.Size(550, 23);
            this.KeyboardCustomizerBtn.TabIndex = 154;
            this.KeyboardCustomizerBtn.Tag = "NonHost";
            this.KeyboardCustomizerBtn.Text = "Keyboard Customizer";
            this.KeyboardCustomizerBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.KeyboardCustomizerBtn.UseSelectable = true;
            this.KeyboardCustomizerBtn.UseStyleColors = true;
            this.KeyboardCustomizerBtn.Click += new System.EventHandler(this.KeyboardCustomizerBtn_Click);
            // 
            // DebugConsoleCustomizerBtn
            // 
            this.DebugConsoleCustomizerBtn.Enabled = false;
            this.DebugConsoleCustomizerBtn.Location = new System.Drawing.Point(7, 510);
            this.DebugConsoleCustomizerBtn.Name = "DebugConsoleCustomizerBtn";
            this.DebugConsoleCustomizerBtn.Size = new System.Drawing.Size(550, 23);
            this.DebugConsoleCustomizerBtn.TabIndex = 154;
            this.DebugConsoleCustomizerBtn.Tag = "NonHost";
            this.DebugConsoleCustomizerBtn.Text = "Debug Console Customizer";
            this.DebugConsoleCustomizerBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DebugConsoleCustomizerBtn.UseSelectable = true;
            this.DebugConsoleCustomizerBtn.UseStyleColors = true;
            this.DebugConsoleCustomizerBtn.Click += new System.EventHandler(this.DebugConsoleCustomizerBtn_Click);
            // 
            // CursedSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.CursedSlider, true);
            this.CursedSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.CursedSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CursedSlider.Location = new System.Drawing.Point(66, 604);
            this.CursedSlider.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.CursedSlider.Name = "CursedSlider";
            this.CursedSlider.Size = new System.Drawing.Size(1051, 20);
            this.CursedSlider.TabIndex = 153;
            this.CursedSlider.Tag = "";
            this.ToolTipManager.SetToolTip(this.CursedSlider, "How cursed should our game get?");
            this.CursedSlider.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CursedSlider.ValueChanged += new System.EventHandler(this.CursedSliderChanged);
            // 
            // CursedLbl
            // 
            this.CursedLbl.AutoSize = true;
            this.CursedLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.CursedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CursedLbl.Location = new System.Drawing.Point(5, 604);
            this.CursedLbl.Name = "CursedLbl";
            this.CursedLbl.Size = new System.Drawing.Size(55, 19);
            this.CursedLbl.Style = MetroFramework.MetroColorStyle.Blue;
            this.CursedLbl.TabIndex = 152;
            this.CursedLbl.Tag = "NonHost";
            this.CursedLbl.Text = "Cursed:";
            this.CursedLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CursedLbl.UseStyleColors = true;
            // 
            // DLCManagerBtn
            // 
            this.DLCManagerBtn.Location = new System.Drawing.Point(566, 510);
            this.DLCManagerBtn.Name = "DLCManagerBtn";
            this.DLCManagerBtn.Size = new System.Drawing.Size(549, 23);
            this.DLCManagerBtn.TabIndex = 150;
            this.DLCManagerBtn.Tag = "NonHost";
            this.DLCManagerBtn.Text = "DLC Manager";
            this.DLCManagerBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DLCManagerBtn, "Opens the DLC Manager");
            this.DLCManagerBtn.UseSelectable = true;
            this.DLCManagerBtn.UseStyleColors = true;
            this.DLCManagerBtn.Click += new System.EventHandler(this.DLCManagerBtn_Click);
            // 
            // PreventBeingKicked
            // 
            this.PreventBeingKicked.AutoSize = true;
            this.PreventBeingKicked.Location = new System.Drawing.Point(475, 298);
            this.PreventBeingKicked.Name = "PreventBeingKicked";
            this.PreventBeingKicked.Size = new System.Drawing.Size(134, 15);
            this.PreventBeingKicked.Style = MetroFramework.MetroColorStyle.Blue;
            this.PreventBeingKicked.TabIndex = 149;
            this.PreventBeingKicked.Tag = "NonHost";
            this.PreventBeingKicked.Text = "Prevent Being Kicked";
            this.PreventBeingKicked.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.PreventBeingKicked, "You will not be able to get kicked from games");
            this.PreventBeingKicked.UseSelectable = true;
            this.PreventBeingKicked.UseStyleColors = true;
            this.PreventBeingKicked.CheckedChanged += new System.EventHandler(this.PreventBeingKickedToggled);
            // 
            // Cursed
            // 
            this.Cursed.AutoSize = true;
            this.Cursed.Location = new System.Drawing.Point(475, 277);
            this.Cursed.Name = "Cursed";
            this.Cursed.Size = new System.Drawing.Size(60, 15);
            this.Cursed.Style = MetroFramework.MetroColorStyle.Blue;
            this.Cursed.TabIndex = 149;
            this.Cursed.Tag = "NonHost";
            this.Cursed.Text = "Cursed";
            this.Cursed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.Cursed, "Cursed");
            this.Cursed.UseSelectable = true;
            this.Cursed.UseStyleColors = true;
            this.Cursed.CheckedChanged += new System.EventHandler(this.CursedToggled);
            // 
            // FreezeGameWhenPaused
            // 
            this.FreezeGameWhenPaused.AutoSize = true;
            this.FreezeGameWhenPaused.BackColor = System.Drawing.Color.Transparent;
            this.FreezeGameWhenPaused.Location = new System.Drawing.Point(475, 256);
            this.FreezeGameWhenPaused.Name = "FreezeGameWhenPaused";
            this.FreezeGameWhenPaused.Size = new System.Drawing.Size(211, 15);
            this.FreezeGameWhenPaused.Style = MetroFramework.MetroColorStyle.Blue;
            this.FreezeGameWhenPaused.TabIndex = 148;
            this.FreezeGameWhenPaused.Tag = "NonHost";
            this.FreezeGameWhenPaused.Text = "Freeze game when paused (Default)";
            this.FreezeGameWhenPaused.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FreezeGameWhenPaused.ThreeState = true;
            this.ToolTipManager.SetToolTip(this.FreezeGameWhenPaused, "Whether it thunders or not");
            this.FreezeGameWhenPaused.UseSelectable = true;
            this.FreezeGameWhenPaused.UseStyleColors = true;
            this.FreezeGameWhenPaused.CheckedChanged += new System.EventHandler(this.FreezeGameWhenPausedToggled);
            // 
            // AchievementsEverywhere
            // 
            this.AchievementsEverywhere.AutoSize = true;
            this.AchievementsEverywhere.Location = new System.Drawing.Point(475, 235);
            this.AchievementsEverywhere.Name = "AchievementsEverywhere";
            this.AchievementsEverywhere.Size = new System.Drawing.Size(161, 15);
            this.AchievementsEverywhere.Style = MetroFramework.MetroColorStyle.Orange;
            this.AchievementsEverywhere.TabIndex = 147;
            this.AchievementsEverywhere.Tag = "Host";
            this.AchievementsEverywhere.Text = "Achievements Everywhere";
            this.AchievementsEverywhere.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AchievementsEverywhere, "Allows you to unlock Achievements\r\nregardless of gamemode and gametype");
            this.AchievementsEverywhere.UseSelectable = true;
            this.AchievementsEverywhere.UseStyleColors = true;
            this.AchievementsEverywhere.CheckedChanged += new System.EventHandler(this.AchievementsEverywhereToggled);
            // 
            // MuteMicrophone
            // 
            this.MuteMicrophone.AutoSize = true;
            this.MuteMicrophone.Location = new System.Drawing.Point(475, 214);
            this.MuteMicrophone.Name = "MuteMicrophone";
            this.MuteMicrophone.Size = new System.Drawing.Size(119, 15);
            this.MuteMicrophone.Style = MetroFramework.MetroColorStyle.Blue;
            this.MuteMicrophone.TabIndex = 146;
            this.MuteMicrophone.Tag = "NonHost";
            this.MuteMicrophone.Text = "Mute Microphone";
            this.MuteMicrophone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.MuteMicrophone, "Mutes your microphone");
            this.MuteMicrophone.UseSelectable = true;
            this.MuteMicrophone.UseStyleColors = true;
            this.MuteMicrophone.CheckedChanged += new System.EventHandler(this.MuteMicrophoneToggled);
            // 
            // AchievementEditor
            // 
            this.AchievementEditor.Location = new System.Drawing.Point(7, 539);
            this.AchievementEditor.Name = "AchievementEditor";
            this.AchievementEditor.Size = new System.Drawing.Size(550, 25);
            this.AchievementEditor.Style = MetroFramework.MetroColorStyle.Blue;
            this.AchievementEditor.TabIndex = 145;
            this.AchievementEditor.Tag = "NonHost";
            this.AchievementEditor.Text = "Achievement Editor";
            this.AchievementEditor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AchievementEditor, "Opens the Achievement Editor, allowing you to swap achievements.");
            this.AchievementEditor.UseSelectable = true;
            this.AchievementEditor.UseStyleColors = true;
            this.AchievementEditor.Click += new System.EventHandler(this.AchievementEditorClicked);
            // 
            // UnlockSignKeyboard
            // 
            this.UnlockSignKeyboard.AutoSize = true;
            this.UnlockSignKeyboard.Location = new System.Drawing.Point(475, 193);
            this.UnlockSignKeyboard.Name = "UnlockSignKeyboard";
            this.UnlockSignKeyboard.Size = new System.Drawing.Size(139, 15);
            this.UnlockSignKeyboard.Style = MetroFramework.MetroColorStyle.Blue;
            this.UnlockSignKeyboard.TabIndex = 144;
            this.UnlockSignKeyboard.Tag = "NonHost";
            this.UnlockSignKeyboard.Text = "Unlock Sign Keyboard";
            this.UnlockSignKeyboard.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.UnlockSignKeyboard, "Unlocks the full Wii U Keyboard when editing signs");
            this.UnlockSignKeyboard.UseSelectable = true;
            this.UnlockSignKeyboard.UseStyleColors = true;
            this.UnlockSignKeyboard.CheckedChanged += new System.EventHandler(this.UnlockSignKeyboardToggled);
            // 
            // DebugConsole
            // 
            this.DebugConsole.AutoSize = true;
            this.DebugConsole.BackColor = System.Drawing.Color.Transparent;
            this.DebugConsole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DebugConsole.Location = new System.Drawing.Point(7, 46);
            this.DebugConsole.Name = "DebugConsole";
            this.DebugConsole.Size = new System.Drawing.Size(104, 15);
            this.DebugConsole.Style = MetroFramework.MetroColorStyle.Blue;
            this.DebugConsole.TabIndex = 143;
            this.DebugConsole.Tag = "NonHost";
            this.DebugConsole.Text = "Debug Console";
            this.DebugConsole.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DebugConsole, "Whether to show the Debug Console");
            this.DebugConsole.UseSelectable = true;
            this.DebugConsole.UseStyleColors = true;
            this.DebugConsole.CheckedChanged += new System.EventHandler(this.DebugConsoleToggled);
            // 
            // Game
            // 
            this.Game.AutoSize = true;
            this.Game.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Game.Location = new System.Drawing.Point(475, 3);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(45, 19);
            this.Game.TabIndex = 142;
            this.Game.Text = "Game";
            this.Game.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UIUserInterface
            // 
            this.UIUserInterface.AutoSize = true;
            this.UIUserInterface.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.UIUserInterface.Location = new System.Drawing.Point(3, 3);
            this.UIUserInterface.Name = "UIUserInterface";
            this.UIUserInterface.Size = new System.Drawing.Size(120, 19);
            this.UIUserInterface.TabIndex = 141;
            this.UIUserInterface.Text = "UI (User Interface)";
            this.UIUserInterface.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // generalPanel
            // 
            this.generalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generalPanel.HorizontalScrollbarBarColor = true;
            this.generalPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.generalPanel.HorizontalScrollbarSize = 10;
            this.generalPanel.Location = new System.Drawing.Point(0, 15);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(1116, 1);
            this.generalPanel.TabIndex = 140;
            this.generalPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.generalPanel.VerticalScrollbarBarColor = true;
            this.generalPanel.VerticalScrollbarHighlightOnWheel = false;
            this.generalPanel.VerticalScrollbarSize = 10;
            // 
            // vpadDisplaySwitch
            // 
            this.vpadDisplaySwitch.AutoSize = true;
            this.vpadDisplaySwitch.Location = new System.Drawing.Point(475, 172);
            this.vpadDisplaySwitch.Name = "vpadDisplaySwitch";
            this.vpadDisplaySwitch.Size = new System.Drawing.Size(183, 15);
            this.vpadDisplaySwitch.Style = MetroFramework.MetroColorStyle.Blue;
            this.vpadDisplaySwitch.TabIndex = 3;
            this.vpadDisplaySwitch.Tag = "NonHost";
            this.vpadDisplaySwitch.Text = "Power Button turns off display";
            this.vpadDisplaySwitch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.vpadDisplaySwitch, "Holding down the power button on the gamepad will turn off the screen, not consol" +
        "e");
            this.vpadDisplaySwitch.UseSelectable = true;
            this.vpadDisplaySwitch.UseStyleColors = true;
            this.vpadDisplaySwitch.CheckedChanged += new System.EventHandler(this.VpadDisplaySwitchToggled);
            // 
            // UIColorPickerBtn
            // 
            this.UIColorPickerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UIColorPickerBtn.Location = new System.Drawing.Point(566, 570);
            this.UIColorPickerBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UIColorPickerBtn.Name = "UIColorPickerBtn";
            this.UIColorPickerBtn.Size = new System.Drawing.Size(550, 25);
            this.UIColorPickerBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.UIColorPickerBtn.TabIndex = 32;
            this.UIColorPickerBtn.Tag = "NonHost";
            this.UIColorPickerBtn.Text = "UI Color Picker";
            this.UIColorPickerBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.UIColorPickerBtn, "Here you can change the game\'s UI colors \r\nto match your preferences");
            this.UIColorPickerBtn.UseSelectable = true;
            this.UIColorPickerBtn.UseStyleColors = true;
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
            this.DisableTeleporting.Style = MetroFramework.MetroColorStyle.Orange;
            this.DisableTeleporting.TabIndex = 31;
            this.DisableTeleporting.Tag = "Host";
            this.DisableTeleporting.Text = "Disable Teleporting";
            this.DisableTeleporting.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DisableTeleporting, "Disables the teleport command");
            this.DisableTeleporting.UseSelectable = true;
            this.DisableTeleporting.UseStyleColors = true;
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
            this.GamepadSplitscreen.Style = MetroFramework.MetroColorStyle.Blue;
            this.GamepadSplitscreen.TabIndex = 30;
            this.GamepadSplitscreen.Tag = "NonHost";
            this.GamepadSplitscreen.Text = "Gamepad Splitscreen";
            this.GamepadSplitscreen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.GamepadSplitscreen, "Allows you to use splitscreen on the Gamepad");
            this.GamepadSplitscreen.UseSelectable = true;
            this.GamepadSplitscreen.UseStyleColors = true;
            this.GamepadSplitscreen.CheckedChanged += new System.EventHandler(this.GamepadSplitscreenToggled);
            // 
            // disableVPadInput
            // 
            this.disableVPadInput.AutoSize = true;
            this.disableVPadInput.Location = new System.Drawing.Point(475, 151);
            this.disableVPadInput.Name = "disableVPadInput";
            this.disableVPadInput.Size = new System.Drawing.Size(146, 15);
            this.disableVPadInput.Style = MetroFramework.MetroColorStyle.Blue;
            this.disableVPadInput.TabIndex = 2;
            this.disableVPadInput.Tag = "NonHost";
            this.disableVPadInput.Text = "Disable Gamepad Input";
            this.disableVPadInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.disableVPadInput, "Disables all input from the Gamepad including the touch screen but excluding the " +
        "home button");
            this.disableVPadInput.UseSelectable = true;
            this.disableVPadInput.UseStyleColors = true;
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
            this.BypassFriendsOnly.Style = MetroFramework.MetroColorStyle.Blue;
            this.BypassFriendsOnly.TabIndex = 29;
            this.BypassFriendsOnly.Tag = "NonHost";
            this.BypassFriendsOnly.Text = "Bypass Friends Only";
            this.BypassFriendsOnly.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.BypassFriendsOnly, "Bypasses the \"Friends Only\" privacy setting");
            this.BypassFriendsOnly.UseSelectable = true;
            this.BypassFriendsOnly.UseStyleColors = true;
            this.BypassFriendsOnly.CheckedChanged += new System.EventHandler(this.BypassFriendsOnlyToggled);
            // 
            // DisablePermanentKicks
            // 
            this.DisablePermanentKicks.AutoSize = true;
            this.DisablePermanentKicks.BackColor = System.Drawing.Color.Transparent;
            this.DisablePermanentKicks.Location = new System.Drawing.Point(475, 46);
            this.DisablePermanentKicks.Name = "DisablePermanentKicks";
            this.DisablePermanentKicks.Size = new System.Drawing.Size(152, 15);
            this.DisablePermanentKicks.Style = MetroFramework.MetroColorStyle.Blue;
            this.DisablePermanentKicks.TabIndex = 25;
            this.DisablePermanentKicks.Tag = "NonHost";
            this.DisablePermanentKicks.Text = "Disable Permanent Kicks";
            this.DisablePermanentKicks.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DisablePermanentKicks, "Disables the \"You have been previously kicked by the host\" \r\nmessage and join any" +
        "way");
            this.DisablePermanentKicks.UseSelectable = true;
            this.DisablePermanentKicks.UseStyleColors = true;
            this.DisablePermanentKicks.CheckedChanged += new System.EventHandler(this.DisablePermanentKicksToggled);
            // 
            // MapTextEditor
            // 
            this.MapTextEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MapTextEditor.Location = new System.Drawing.Point(7, 570);
            this.MapTextEditor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MapTextEditor.Name = "MapTextEditor";
            this.MapTextEditor.Size = new System.Drawing.Size(550, 25);
            this.MapTextEditor.Style = MetroFramework.MetroColorStyle.Blue;
            this.MapTextEditor.TabIndex = 20;
            this.MapTextEditor.Tag = "NonHost";
            this.MapTextEditor.Text = "Map Text Editor";
            this.MapTextEditor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MapTextEditor.UseSelectable = true;
            this.MapTextEditor.UseStyleColors = true;
            this.MapTextEditor.Click += new System.EventHandler(this.MapTextEditorClicked);
            // 
            // HostOptions
            // 
            this.HostOptions.AutoSize = true;
            this.HostOptions.Location = new System.Drawing.Point(475, 25);
            this.HostOptions.Name = "HostOptions";
            this.HostOptions.Size = new System.Drawing.Size(93, 15);
            this.HostOptions.Style = MetroFramework.MetroColorStyle.Orange;
            this.HostOptions.TabIndex = 28;
            this.HostOptions.Tag = "Host";
            this.HostOptions.Text = "Host Options";
            this.HostOptions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.HostOptions, "Enables host privileges\r\nNOTE: Crashes others when enabled in Minigames");
            this.HostOptions.UseSelectable = true;
            this.HostOptions.UseStyleColors = true;
            this.HostOptions.CheckedChanged += new System.EventHandler(this.HostOptionsToggled);
            // 
            // SlowMotion
            // 
            this.SlowMotion.AutoSize = true;
            this.SlowMotion.Location = new System.Drawing.Point(475, 109);
            this.SlowMotion.Name = "SlowMotion";
            this.SlowMotion.Size = new System.Drawing.Size(90, 15);
            this.SlowMotion.Style = MetroFramework.MetroColorStyle.Blue;
            this.SlowMotion.TabIndex = 139;
            this.SlowMotion.Tag = "NonHost";
            this.SlowMotion.Text = "Slow Motion";
            this.SlowMotion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SlowMotion, "Whether the game will be slowed down");
            this.SlowMotion.UseSelectable = true;
            this.SlowMotion.UseStyleColors = true;
            this.SlowMotion.CheckedChanged += new System.EventHandler(this.SlowMotionToggled);
            // 
            // AllDLCUnlocked
            // 
            this.AllDLCUnlocked.AutoSize = true;
            this.AllDLCUnlocked.Location = new System.Drawing.Point(475, 88);
            this.AllDLCUnlocked.Name = "AllDLCUnlocked";
            this.AllDLCUnlocked.Size = new System.Drawing.Size(115, 15);
            this.AllDLCUnlocked.Style = MetroFramework.MetroColorStyle.Blue;
            this.AllDLCUnlocked.TabIndex = 16;
            this.AllDLCUnlocked.Tag = "NonHost";
            this.AllDLCUnlocked.Text = "All DLC Unlocked";
            this.AllDLCUnlocked.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AllDLCUnlocked, "Unlocks all DLC");
            this.AllDLCUnlocked.UseSelectable = true;
            this.AllDLCUnlocked.UseStyleColors = true;
            this.AllDLCUnlocked.CheckedChanged += new System.EventHandler(this.AllDlcUnlockedToggled);
            // 
            // ExitGame
            // 
            this.ExitGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitGame.Location = new System.Drawing.Point(566, 539);
            this.ExitGame.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(550, 25);
            this.ExitGame.Style = MetroFramework.MetroColorStyle.Blue;
            this.ExitGame.TabIndex = 15;
            this.ExitGame.Tag = "NonHost";
            this.ExitGame.Text = "Exit Game";
            this.ExitGame.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ExitGame.UseSelectable = true;
            this.ExitGame.UseStyleColors = true;
            this.ExitGame.Click += new System.EventHandler(this.ExitGameClicked);
            // 
            // MinigamesTab
            // 
            this.MinigamesTab.Controls.Add(this.MinigamesTabs);
            this.MinigamesTab.HorizontalScrollbarBarColor = true;
            this.MinigamesTab.HorizontalScrollbarHighlightOnWheel = false;
            this.MinigamesTab.HorizontalScrollbarSize = 10;
            this.MinigamesTab.Location = new System.Drawing.Point(4, 9);
            this.MinigamesTab.Name = "MinigamesTab";
            this.MinigamesTab.Padding = new System.Windows.Forms.Padding(3);
            this.MinigamesTab.Size = new System.Drawing.Size(1122, 630);
            this.MinigamesTab.TabIndex = 3;
            this.MinigamesTab.Tag = "GeckoUNeeded";
            this.MinigamesTab.Text = "Minigames";
            this.MinigamesTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MinigamesTab.VerticalScrollbarBarColor = true;
            this.MinigamesTab.VerticalScrollbarHighlightOnWheel = false;
            this.MinigamesTab.VerticalScrollbarSize = 10;
            // 
            // MinigamesTabs
            // 
            this.MinigamesTabs.Controls.Add(this.GeneralMinigames);
            this.MinigamesTabs.Controls.Add(this.Battle);
            this.MinigamesTabs.Controls.Add(this.Tumble);
            this.MinigamesTabs.Controls.Add(this.Glide);
            this.MinigamesTabs.ItemSize = new System.Drawing.Size(280, 1);
            this.MinigamesTabs.Location = new System.Drawing.Point(-3, 0);
            this.MinigamesTabs.Multiline = true;
            this.MinigamesTabs.Name = "MinigamesTabs";
            this.MinigamesTabs.SelectedIndex = 3;
            this.MinigamesTabs.Size = new System.Drawing.Size(1129, 633);
            this.MinigamesTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MinigamesTabs.TabIndex = 2;
            this.MinigamesTabs.Tag = "GeckoURequired";
            this.MinigamesTabs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinigamesTabs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MinigamesTabs.UseSelectable = true;
            // 
            // GeneralMinigames
            // 
            this.GeneralMinigames.BackColor = System.Drawing.Color.White;
            this.GeneralMinigames.Controls.Add(this.Solo);
            this.GeneralMinigames.Controls.Add(this.LiquidsCanConvert);
            this.GeneralMinigames.Controls.Add(this.AllowMobs);
            this.GeneralMinigames.Controls.Add(this.NoPosLock);
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
            this.GeneralMinigames.Location = new System.Drawing.Point(4, 5);
            this.GeneralMinigames.Name = "GeneralMinigames";
            this.GeneralMinigames.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralMinigames.Size = new System.Drawing.Size(1121, 624);
            this.GeneralMinigames.TabIndex = 0;
            this.GeneralMinigames.Text = "General";
            this.GeneralMinigames.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.GeneralMinigames.VerticalScrollbarBarColor = true;
            this.GeneralMinigames.VerticalScrollbarHighlightOnWheel = false;
            this.GeneralMinigames.VerticalScrollbarSize = 10;
            // 
            // Solo
            // 
            this.Solo.AutoSize = true;
            this.Solo.Location = new System.Drawing.Point(7, 175);
            this.Solo.Name = "Solo";
            this.Solo.Size = new System.Drawing.Size(46, 15);
            this.Solo.Style = MetroFramework.MetroColorStyle.Orange;
            this.Solo.TabIndex = 28;
            this.Solo.Tag = "Host";
            this.Solo.Text = "Solo";
            this.Solo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.Solo, "Allows you to play Battle and Tumnle alone");
            this.Solo.UseSelectable = true;
            this.Solo.UseStyleColors = true;
            this.Solo.CheckedChanged += new System.EventHandler(this.SoloToggled);
            // 
            // LiquidsCanConvert
            // 
            this.LiquidsCanConvert.AutoSize = true;
            this.LiquidsCanConvert.Location = new System.Drawing.Point(7, 154);
            this.LiquidsCanConvert.Name = "LiquidsCanConvert";
            this.LiquidsCanConvert.Size = new System.Drawing.Size(126, 15);
            this.LiquidsCanConvert.Style = MetroFramework.MetroColorStyle.Orange;
            this.LiquidsCanConvert.TabIndex = 27;
            this.LiquidsCanConvert.Tag = "Host";
            this.LiquidsCanConvert.Text = "Liquids can convert";
            this.LiquidsCanConvert.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.LiquidsCanConvert, "Lava and Water can collide and generate\r\nCobblestone, Stone and Obsidian");
            this.LiquidsCanConvert.UseSelectable = true;
            this.LiquidsCanConvert.UseStyleColors = true;
            this.LiquidsCanConvert.CheckedChanged += new System.EventHandler(this.LiquidsCanConvertToggled);
            // 
            // AllowMobs
            // 
            this.AllowMobs.AutoSize = true;
            this.AllowMobs.Location = new System.Drawing.Point(7, 133);
            this.AllowMobs.Name = "AllowMobs";
            this.AllowMobs.Size = new System.Drawing.Size(86, 15);
            this.AllowMobs.Style = MetroFramework.MetroColorStyle.Orange;
            this.AllowMobs.TabIndex = 26;
            this.AllowMobs.Tag = "Host";
            this.AllowMobs.Text = "Allow Mobs";
            this.AllowMobs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AllowMobs, "Mobs can spawn during Minigames");
            this.AllowMobs.UseSelectable = true;
            this.AllowMobs.UseStyleColors = true;
            this.AllowMobs.CheckedChanged += new System.EventHandler(this.AllowMobsToggled);
            // 
            // NoPosLock
            // 
            this.NoPosLock.AutoSize = true;
            this.NoPosLock.Location = new System.Drawing.Point(7, 112);
            this.NoPosLock.Name = "NoPosLock";
            this.NoPosLock.Size = new System.Drawing.Size(113, 15);
            this.NoPosLock.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoPosLock.TabIndex = 25;
            this.NoPosLock.Tag = "NonHost";
            this.NoPosLock.Text = "No Position Lock";
            this.NoPosLock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.NoPosLock, "Allows you to move during the round\r\nstart countdown");
            this.NoPosLock.UseSelectable = true;
            this.NoPosLock.UseStyleColors = true;
            this.NoPosLock.CheckedChanged += new System.EventHandler(this.NoPositionLockToggled);
            // 
            // SqueakInfinitely
            // 
            this.SqueakInfinitely.AutoSize = true;
            this.SqueakInfinitely.Location = new System.Drawing.Point(7, 90);
            this.SqueakInfinitely.Name = "SqueakInfinitely";
            this.SqueakInfinitely.Size = new System.Drawing.Size(110, 15);
            this.SqueakInfinitely.Style = MetroFramework.MetroColorStyle.Blue;
            this.SqueakInfinitely.TabIndex = 24;
            this.SqueakInfinitely.Tag = "NonHost";
            this.SqueakInfinitely.Text = "Squeak Infinitely";
            this.SqueakInfinitely.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SqueakInfinitely, "Removes the cooldown for Squeaking when\r\nspectating as a Bat");
            this.SqueakInfinitely.UseSelectable = true;
            this.SqueakInfinitely.UseStyleColors = true;
            this.SqueakInfinitely.CheckedChanged += new System.EventHandler(this.SqueakInfinitelyToggled);
            // 
            // RequiredPlayersSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.RequiredPlayersSlider, true);
            this.RequiredPlayersSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.RequiredPlayersSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.RequiredPlayersSlider.Location = new System.Drawing.Point(124, 594);
            this.RequiredPlayersSlider.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.RequiredPlayersSlider.Name = "RequiredPlayersSlider";
            this.RequiredPlayersSlider.Size = new System.Drawing.Size(981, 20);
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
            this.RequiredPlayers.Location = new System.Drawing.Point(5, 594);
            this.RequiredPlayers.Name = "RequiredPlayers";
            this.RequiredPlayers.Size = new System.Drawing.Size(113, 19);
            this.RequiredPlayers.Style = MetroFramework.MetroColorStyle.Orange;
            this.RequiredPlayers.TabIndex = 22;
            this.RequiredPlayers.Tag = "Host";
            this.RequiredPlayers.Text = "Required Players:";
            this.RequiredPlayers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RequiredPlayers.UseStyleColors = true;
            // 
            // AllPermissions
            // 
            this.AllPermissions.AutoSize = true;
            this.AllPermissions.Location = new System.Drawing.Point(7, 6);
            this.AllPermissions.Name = "AllPermissions";
            this.AllPermissions.Size = new System.Drawing.Size(98, 15);
            this.AllPermissions.Style = MetroFramework.MetroColorStyle.Blue;
            this.AllPermissions.TabIndex = 2;
            this.AllPermissions.Tag = "NonHost";
            this.AllPermissions.Text = "All Permisions";
            this.AllPermissions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AllPermissions, "You\'ll have all permissions such as breaking,\r\nplacing, using blocks and crafting" +
        "");
            this.AllPermissions.UseSelectable = true;
            this.AllPermissions.UseStyleColors = true;
            this.AllPermissions.CheckedChanged += new System.EventHandler(this.AllPermissionsToggled);
            // 
            // AlwaysDamaged
            // 
            this.AlwaysDamaged.AutoSize = true;
            this.AlwaysDamaged.Location = new System.Drawing.Point(7, 48);
            this.AlwaysDamaged.Name = "AlwaysDamaged";
            this.AlwaysDamaged.Size = new System.Drawing.Size(114, 15);
            this.AlwaysDamaged.Style = MetroFramework.MetroColorStyle.Orange;
            this.AlwaysDamaged.TabIndex = 4;
            this.AlwaysDamaged.Tag = "Host";
            this.AlwaysDamaged.Text = "Always Damaged";
            this.AlwaysDamaged.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AlwaysDamaged, "Everyone will be damaged as if they were\r\ninside of a kill barrier");
            this.AlwaysDamaged.UseSelectable = true;
            this.AlwaysDamaged.UseStyleColors = true;
            this.AlwaysDamaged.CheckedChanged += new System.EventHandler(this.AlwaysDamagedToggled);
            // 
            // TNTGriefing
            // 
            this.TNTGriefing.AutoSize = true;
            this.TNTGriefing.Location = new System.Drawing.Point(7, 27);
            this.TNTGriefing.Name = "TNTGriefing";
            this.TNTGriefing.Size = new System.Drawing.Size(89, 15);
            this.TNTGriefing.Style = MetroFramework.MetroColorStyle.Orange;
            this.TNTGriefing.TabIndex = 7;
            this.TNTGriefing.Tag = "Host";
            this.TNTGriefing.Text = "TNT Griefing";
            this.TNTGriefing.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.TNTGriefing, "TNT will destroy surrounding blocks");
            this.TNTGriefing.UseSelectable = true;
            this.TNTGriefing.UseStyleColors = true;
            this.TNTGriefing.CheckedChanged += new System.EventHandler(this.TntGriefingToggled);
            // 
            // DisabledKillBarriers
            // 
            this.DisabledKillBarriers.AutoSize = true;
            this.DisabledKillBarriers.Location = new System.Drawing.Point(7, 69);
            this.DisabledKillBarriers.Name = "DisabledKillBarriers";
            this.DisabledKillBarriers.Size = new System.Drawing.Size(129, 15);
            this.DisabledKillBarriers.Style = MetroFramework.MetroColorStyle.Orange;
            this.DisabledKillBarriers.TabIndex = 8;
            this.DisabledKillBarriers.Tag = "Host";
            this.DisabledKillBarriers.Text = "Disabled Kill Barriers";
            this.DisabledKillBarriers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DisabledKillBarriers, "Kill barriers will be disabled");
            this.DisabledKillBarriers.UseSelectable = true;
            this.DisabledKillBarriers.UseStyleColors = true;
            this.DisabledKillBarriers.CheckedChanged += new System.EventHandler(this.DisabledKillBarriersToggled);
            // 
            // Battle
            // 
            this.Battle.BackColor = System.Drawing.Color.White;
            this.Battle.Controls.Add(this.MapSizeBox);
            this.Battle.Controls.Add(this.MapSizeLbl);
            this.Battle.Controls.Add(this.EndGame);
            this.Battle.Controls.Add(this.RefillInterval);
            this.Battle.Controls.Add(this.RefillIntervalSlider);
            this.Battle.Controls.Add(this.AntiEndGame);
            this.Battle.HorizontalScrollbarBarColor = true;
            this.Battle.HorizontalScrollbarHighlightOnWheel = false;
            this.Battle.HorizontalScrollbarSize = 10;
            this.Battle.Location = new System.Drawing.Point(4, 5);
            this.Battle.Name = "Battle";
            this.Battle.Padding = new System.Windows.Forms.Padding(3);
            this.Battle.Size = new System.Drawing.Size(1121, 624);
            this.Battle.TabIndex = 1;
            this.Battle.Text = "Battle";
            this.Battle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Battle.VerticalScrollbarBarColor = true;
            this.Battle.VerticalScrollbarHighlightOnWheel = false;
            this.Battle.VerticalScrollbarSize = 10;
            // 
            // MapSizeBox
            // 
            this.MapSizeBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.MapSizeBox.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.MapSizeBox.FormattingEnabled = true;
            this.MapSizeBox.ItemHeight = 19;
            this.MapSizeBox.Items.AddRange(new object[] {
            "Small",
            "Large"});
            this.MapSizeBox.Location = new System.Drawing.Point(79, 543);
            this.MapSizeBox.Name = "MapSizeBox";
            this.MapSizeBox.Size = new System.Drawing.Size(1036, 25);
            this.MapSizeBox.TabIndex = 177;
            this.MapSizeBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.MapSizeBox, "What size map should we play on?");
            this.MapSizeBox.UseSelectable = true;
            this.MapSizeBox.SelectedIndexChanged += new System.EventHandler(this.MapSizeBoxChanged);
            // 
            // MapSizeLbl
            // 
            this.MapSizeLbl.AutoSize = true;
            this.MapSizeLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MapSizeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MapSizeLbl.Location = new System.Drawing.Point(6, 543);
            this.MapSizeLbl.Name = "MapSizeLbl";
            this.MapSizeLbl.Size = new System.Drawing.Size(67, 19);
            this.MapSizeLbl.Style = MetroFramework.MetroColorStyle.Orange;
            this.MapSizeLbl.TabIndex = 176;
            this.MapSizeLbl.Tag = "Host";
            this.MapSizeLbl.Text = "Map Size:";
            this.MapSizeLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MapSizeLbl.UseStyleColors = true;
            // 
            // EndGame
            // 
            this.EndGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EndGame.BackColor = System.Drawing.SystemColors.Control;
            this.EndGame.Location = new System.Drawing.Point(7, 507);
            this.EndGame.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(1108, 27);
            this.EndGame.Style = MetroFramework.MetroColorStyle.Orange;
            this.EndGame.TabIndex = 9;
            this.EndGame.Tag = "Host";
            this.EndGame.Text = "End Game";
            this.EndGame.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.EndGame, "Ends the current Battle Match");
            this.EndGame.UseSelectable = true;
            this.EndGame.UseStyleColors = true;
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
            this.RefillInterval.Style = MetroFramework.MetroColorStyle.Orange;
            this.RefillInterval.TabIndex = 28;
            this.RefillInterval.Tag = "Host";
            this.RefillInterval.Text = "Chest Refill Interval:";
            this.RefillInterval.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RefillInterval.UseStyleColors = true;
            // 
            // RefillIntervalSlider
            // 
            this.StyleExtender.SetApplyMetroTheme(this.RefillIntervalSlider, true);
            this.RefillIntervalSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.RefillIntervalSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.RefillIntervalSlider.Location = new System.Drawing.Point(140, 574);
            this.RefillIntervalSlider.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.RefillIntervalSlider.Name = "RefillIntervalSlider";
            this.RefillIntervalSlider.Size = new System.Drawing.Size(975, 20);
            this.RefillIntervalSlider.TabIndex = 29;
            this.ToolTipManager.SetToolTip(this.RefillIntervalSlider, "How many seconds does it take for\r\nchests to refill?");
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
            this.AntiEndGame.Style = MetroFramework.MetroColorStyle.Orange;
            this.AntiEndGame.TabIndex = 5;
            this.AntiEndGame.Tag = "Host";
            this.AntiEndGame.Text = "Anti End Game";
            this.AntiEndGame.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AntiEndGame, "Disallows the round to end");
            this.AntiEndGame.UseSelectable = true;
            this.AntiEndGame.UseStyleColors = true;
            this.AntiEndGame.CheckedChanged += new System.EventHandler(this.AntiEndGameToggled);
            // 
            // Tumble
            // 
            this.Tumble.BackColor = System.Drawing.Color.White;
            this.Tumble.Controls.Add(this.DisableCameraAnimation);
            this.Tumble.Controls.Add(this.UnlockInventoty);
            this.Tumble.Controls.Add(this.TumbleHUD);
            this.Tumble.HorizontalScrollbarBarColor = true;
            this.Tumble.HorizontalScrollbarHighlightOnWheel = false;
            this.Tumble.HorizontalScrollbarSize = 10;
            this.Tumble.Location = new System.Drawing.Point(4, 5);
            this.Tumble.Name = "Tumble";
            this.Tumble.Padding = new System.Windows.Forms.Padding(3);
            this.Tumble.Size = new System.Drawing.Size(1121, 624);
            this.Tumble.TabIndex = 2;
            this.Tumble.Text = "Tumble";
            this.Tumble.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tumble.VerticalScrollbarBarColor = true;
            this.Tumble.VerticalScrollbarHighlightOnWheel = false;
            this.Tumble.VerticalScrollbarSize = 10;
            // 
            // DisableCameraAnimation
            // 
            this.DisableCameraAnimation.AutoSize = true;
            this.DisableCameraAnimation.Location = new System.Drawing.Point(7, 50);
            this.DisableCameraAnimation.Name = "DisableCameraAnimation";
            this.DisableCameraAnimation.Size = new System.Drawing.Size(164, 15);
            this.DisableCameraAnimation.Style = MetroFramework.MetroColorStyle.Blue;
            this.DisableCameraAnimation.TabIndex = 5;
            this.DisableCameraAnimation.Tag = "NonHost";
            this.DisableCameraAnimation.Text = "Disable Camera Animation";
            this.DisableCameraAnimation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DisableCameraAnimation, "Disables the Tumble round start animation");
            this.DisableCameraAnimation.UseSelectable = true;
            this.DisableCameraAnimation.UseStyleColors = true;
            this.DisableCameraAnimation.CheckedChanged += new System.EventHandler(this.DisableCameraAnimationToggled);
            // 
            // UnlockInventoty
            // 
            this.UnlockInventoty.AutoSize = true;
            this.UnlockInventoty.Location = new System.Drawing.Point(7, 28);
            this.UnlockInventoty.Name = "UnlockInventoty";
            this.UnlockInventoty.Size = new System.Drawing.Size(113, 15);
            this.UnlockInventoty.Style = MetroFramework.MetroColorStyle.Blue;
            this.UnlockInventoty.TabIndex = 4;
            this.UnlockInventoty.Tag = "NonHost";
            this.UnlockInventoty.Text = "Unlock Inventory";
            this.UnlockInventoty.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.UnlockInventoty, "Allows you to open the Inventory in\r\nTumble");
            this.UnlockInventoty.UseSelectable = true;
            this.UnlockInventoty.UseStyleColors = true;
            this.UnlockInventoty.CheckedChanged += new System.EventHandler(this.UnlockInventoryToggled);
            // 
            // TumbleHUD
            // 
            this.TumbleHUD.AutoSize = true;
            this.TumbleHUD.Location = new System.Drawing.Point(7, 6);
            this.TumbleHUD.Name = "TumbleHUD";
            this.TumbleHUD.Size = new System.Drawing.Size(91, 15);
            this.TumbleHUD.Style = MetroFramework.MetroColorStyle.Blue;
            this.TumbleHUD.TabIndex = 3;
            this.TumbleHUD.Tag = "NonHost";
            this.TumbleHUD.Text = "Tumble HUD";
            this.TumbleHUD.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.TumbleHUD, "Overwrites the Tumble HUD with the default");
            this.TumbleHUD.UseSelectable = true;
            this.TumbleHUD.UseStyleColors = true;
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
            this.Glide.Location = new System.Drawing.Point(4, 5);
            this.Glide.Name = "Glide";
            this.Glide.Padding = new System.Windows.Forms.Padding(3);
            this.Glide.Size = new System.Drawing.Size(1121, 624);
            this.Glide.TabIndex = 3;
            this.Glide.Text = "Glide";
            this.Glide.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.ringScoreB.Style = MetroFramework.MetroColorStyle.Orange;
            this.ringScoreB.TabIndex = 35;
            this.ringScoreB.Tag = "Host";
            this.ringScoreB.Text = "Ring Score (Blue):";
            this.ringScoreB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ringScoreB.UseStyleColors = true;
            // 
            // ringScoreBlue
            // 
            this.StyleExtender.SetApplyMetroTheme(this.ringScoreBlue, true);
            this.ringScoreBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ringScoreBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
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
            this.ToolTipManager.SetToolTip(this.ringScoreBlue, "How much score do Blue rings give?");
            // 
            // ringScoreO
            // 
            this.ringScoreO.AutoSize = true;
            this.ringScoreO.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ringScoreO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ringScoreO.Location = new System.Drawing.Point(7, 29);
            this.ringScoreO.Name = "ringScoreO";
            this.ringScoreO.Size = new System.Drawing.Size(134, 19);
            this.ringScoreO.Style = MetroFramework.MetroColorStyle.Orange;
            this.ringScoreO.TabIndex = 33;
            this.ringScoreO.Tag = "Host";
            this.ringScoreO.Text = "Ring Score (Orange):";
            this.ringScoreO.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ringScoreO.UseStyleColors = true;
            // 
            // ringScoreOrange
            // 
            this.StyleExtender.SetApplyMetroTheme(this.ringScoreOrange, true);
            this.ringScoreOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ringScoreOrange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
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
            this.ToolTipManager.SetToolTip(this.ringScoreOrange, "How much score do Orange rings give?\r\n");
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
            this.ringScoreG.Style = MetroFramework.MetroColorStyle.Orange;
            this.ringScoreG.TabIndex = 31;
            this.ringScoreG.Tag = "Host";
            this.ringScoreG.Text = "Ring Score (Green):";
            this.ringScoreG.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ringScoreG.UseStyleColors = true;
            // 
            // ringScoreGreen
            // 
            this.StyleExtender.SetApplyMetroTheme(this.ringScoreGreen, true);
            this.ringScoreGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ringScoreGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
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
            this.ToolTipManager.SetToolTip(this.ringScoreGreen, "How much score do Green rings give?");
            this.ringScoreGreen.ValueChanged += new System.EventHandler(this.GlideRingScoreSliderChanged);
            // 
            // commandsTab
            // 
            this.commandsTab.Controls.Add(this.CommandsWarnLbl);
            this.commandsTab.Controls.Add(this.CommandsInMinigames);
            this.commandsTab.Controls.Add(this.tellrawLbl);
            this.commandsTab.Controls.Add(this.tellrawPanel);
            this.commandsTab.Controls.Add(this.xpCmdLbl);
            this.commandsTab.Controls.Add(this.xpPanel);
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
            this.commandsTab.Location = new System.Drawing.Point(4, 9);
            this.commandsTab.Name = "commandsTab";
            this.commandsTab.Size = new System.Drawing.Size(1122, 630);
            this.commandsTab.TabIndex = 7;
            this.commandsTab.Tag = "GeckoURequired";
            this.commandsTab.Text = "Commands";
            this.commandsTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.commandsTab.VerticalScrollbarBarColor = true;
            this.commandsTab.VerticalScrollbarHighlightOnWheel = false;
            this.commandsTab.VerticalScrollbarSize = 10;
            // 
            // CommandsWarnLbl
            // 
            this.CommandsWarnLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CommandsWarnLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.CommandsWarnLbl.Location = new System.Drawing.Point(106, 353);
            this.CommandsWarnLbl.Name = "CommandsWarnLbl";
            this.CommandsWarnLbl.Size = new System.Drawing.Size(912, 230);
            this.CommandsWarnLbl.TabIndex = 52;
            this.CommandsWarnLbl.Text = "Commands require you to be the host or a moderator. If you want to use commands i" +
    "n minigames make sure to \r\nselect the \"Commands in Minigames\" option";
            this.CommandsWarnLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CommandsWarnLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CommandsInMinigames
            // 
            this.CommandsInMinigames.AutoSize = true;
            this.CommandsInMinigames.Location = new System.Drawing.Point(95, 335);
            this.CommandsInMinigames.Name = "CommandsInMinigames";
            this.CommandsInMinigames.Size = new System.Drawing.Size(160, 15);
            this.CommandsInMinigames.Style = MetroFramework.MetroColorStyle.Orange;
            this.CommandsInMinigames.TabIndex = 51;
            this.CommandsInMinigames.Tag = "Host";
            this.CommandsInMinigames.Text = "Commands in Minigames";
            this.CommandsInMinigames.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.CommandsInMinigames, "Allows commands to be executed within minigame worlds.");
            this.CommandsInMinigames.UseSelectable = true;
            this.CommandsInMinigames.UseStyleColors = true;
            this.CommandsInMinigames.CheckedChanged += new System.EventHandler(this.CommandsInMinigamesToggled);
            // 
            // tellrawLbl
            // 
            this.tellrawLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tellrawLbl.AutoSize = true;
            this.tellrawLbl.BackColor = System.Drawing.Color.Transparent;
            this.tellrawLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.tellrawLbl.Location = new System.Drawing.Point(475, 174);
            this.tellrawLbl.Name = "tellrawLbl";
            this.tellrawLbl.Size = new System.Drawing.Size(54, 19);
            this.tellrawLbl.Style = MetroFramework.MetroColorStyle.Orange;
            this.tellrawLbl.TabIndex = 50;
            this.tellrawLbl.Tag = "Host";
            this.tellrawLbl.Text = "/tellraw";
            this.tellrawLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tellrawLbl.UseStyleColors = true;
            // 
            // tellrawPanel
            // 
            this.tellrawPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tellrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tellrawPanel.Controls.Add(this.tellStyleLbl);
            this.tellrawPanel.Controls.Add(this.customTellBox);
            this.tellrawPanel.Controls.Add(this.javaTellBox);
            this.tellrawPanel.Controls.Add(this.bedrockTellBox);
            this.tellrawPanel.Controls.Add(this.tellMsgBox);
            this.tellrawPanel.Controls.Add(this.tellrawCmdBtn);
            this.tellrawPanel.Controls.Add(this.tellNameBox);
            this.tellrawPanel.HorizontalScrollbarBarColor = true;
            this.tellrawPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.tellrawPanel.HorizontalScrollbarSize = 10;
            this.tellrawPanel.Location = new System.Drawing.Point(471, 184);
            this.tellrawPanel.Name = "tellrawPanel";
            this.tellrawPanel.Size = new System.Drawing.Size(548, 145);
            this.tellrawPanel.TabIndex = 49;
            this.tellrawPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tellrawPanel.VerticalScrollbarBarColor = true;
            this.tellrawPanel.VerticalScrollbarHighlightOnWheel = false;
            this.tellrawPanel.VerticalScrollbarSize = 10;
            // 
            // tellStyleLbl
            // 
            this.tellStyleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tellStyleLbl.AutoSize = true;
            this.tellStyleLbl.BackColor = System.Drawing.Color.Transparent;
            this.tellStyleLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.tellStyleLbl.Location = new System.Drawing.Point(3, 66);
            this.tellStyleLbl.Name = "tellStyleLbl";
            this.tellStyleLbl.Size = new System.Drawing.Size(81, 19);
            this.tellStyleLbl.TabIndex = 51;
            this.tellStyleLbl.Text = "Name Style:";
            this.tellStyleLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // customTellBox
            // 
            this.customTellBox.AutoSize = true;
            this.customTellBox.Location = new System.Drawing.Point(339, 70);
            this.customTellBox.Name = "customTellBox";
            this.customTellBox.Size = new System.Drawing.Size(129, 15);
            this.customTellBox.TabIndex = 23;
            this.customTellBox.Text = "Custom ( no prefix )";
            this.customTellBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.customTellBox.UseSelectable = true;
            // 
            // javaTellBox
            // 
            this.javaTellBox.AutoSize = true;
            this.javaTellBox.Location = new System.Drawing.Point(229, 70);
            this.javaTellBox.Name = "javaTellBox";
            this.javaTellBox.Size = new System.Drawing.Size(104, 15);
            this.javaTellBox.TabIndex = 23;
            this.javaTellBox.Text = "Java ( [NAME] )";
            this.javaTellBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.javaTellBox, "Whether to use Java style chat messages");
            this.javaTellBox.UseSelectable = true;
            // 
            // bedrockTellBox
            // 
            this.bedrockTellBox.AutoSize = true;
            this.bedrockTellBox.Checked = true;
            this.bedrockTellBox.Location = new System.Drawing.Point(90, 70);
            this.bedrockTellBox.Name = "bedrockTellBox";
            this.bedrockTellBox.Size = new System.Drawing.Size(133, 15);
            this.bedrockTellBox.TabIndex = 22;
            this.bedrockTellBox.TabStop = true;
            this.bedrockTellBox.Text = "Bedrock ( <NAME> )";
            this.bedrockTellBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.bedrockTellBox, "Whether to use Bedrock style chat messages");
            this.bedrockTellBox.UseSelectable = true;
            // 
            // tellMsgBox
            // 
            // 
            // 
            // 
            this.tellMsgBox.CustomButton.Image = null;
            this.tellMsgBox.CustomButton.Location = new System.Drawing.Point(518, 1);
            this.tellMsgBox.CustomButton.Name = "";
            this.tellMsgBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tellMsgBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tellMsgBox.CustomButton.TabIndex = 1;
            this.tellMsgBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tellMsgBox.CustomButton.UseSelectable = true;
            this.tellMsgBox.CustomButton.Visible = false;
            this.tellMsgBox.Lines = new string[0];
            this.tellMsgBox.Location = new System.Drawing.Point(3, 40);
            this.tellMsgBox.MaxLength = 140;
            this.tellMsgBox.Name = "tellMsgBox";
            this.tellMsgBox.PasswordChar = '\0';
            this.tellMsgBox.PromptText = "Enter message... (Pressing ENTER also sends the message)";
            this.tellMsgBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tellMsgBox.SelectedText = "";
            this.tellMsgBox.SelectionLength = 0;
            this.tellMsgBox.SelectionStart = 0;
            this.tellMsgBox.ShortcutsEnabled = true;
            this.tellMsgBox.Size = new System.Drawing.Size(540, 23);
            this.tellMsgBox.TabIndex = 21;
            this.tellMsgBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tellMsgBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.tellMsgBox, "The message you want to send");
            this.tellMsgBox.UseSelectable = true;
            this.tellMsgBox.WaterMark = "Enter message... (Pressing ENTER also sends the message)";
            this.tellMsgBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tellMsgBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tellMsgBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DetectEnterPress);
            // 
            // tellrawCmdBtn
            // 
            this.tellrawCmdBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.tellrawCmdBtn.Location = new System.Drawing.Point(3, 115);
            this.tellrawCmdBtn.Name = "tellrawCmdBtn";
            this.tellrawCmdBtn.Size = new System.Drawing.Size(540, 23);
            this.tellrawCmdBtn.TabIndex = 19;
            this.tellrawCmdBtn.Text = "/tellraw";
            this.tellrawCmdBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.tellrawCmdBtn, "Sends the chat message to everyone.");
            this.tellrawCmdBtn.UseSelectable = true;
            this.tellrawCmdBtn.Click += new System.EventHandler(this.TellrawCmdBtnClicked);
            // 
            // tellNameBox
            // 
            // 
            // 
            // 
            this.tellNameBox.CustomButton.Image = null;
            this.tellNameBox.CustomButton.Location = new System.Drawing.Point(518, 1);
            this.tellNameBox.CustomButton.Name = "";
            this.tellNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tellNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tellNameBox.CustomButton.TabIndex = 1;
            this.tellNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tellNameBox.CustomButton.UseSelectable = true;
            this.tellNameBox.CustomButton.Visible = false;
            this.tellNameBox.Lines = new string[0];
            this.tellNameBox.Location = new System.Drawing.Point(3, 11);
            this.tellNameBox.MaxLength = 32;
            this.tellNameBox.Name = "tellNameBox";
            this.tellNameBox.PasswordChar = '\0';
            this.tellNameBox.PromptText = "Enter name... (not required)";
            this.tellNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tellNameBox.SelectedText = "";
            this.tellNameBox.SelectionLength = 0;
            this.tellNameBox.SelectionStart = 0;
            this.tellNameBox.ShortcutsEnabled = true;
            this.tellNameBox.Size = new System.Drawing.Size(540, 23);
            this.tellNameBox.TabIndex = 20;
            this.tellNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tellNameBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.tellNameBox, "The name of who sent this message");
            this.tellNameBox.UseSelectable = true;
            this.tellNameBox.WaterMark = "Enter name... (not required)";
            this.tellNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tellNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // xpCmdLbl
            // 
            this.xpCmdLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.xpCmdLbl.AutoSize = true;
            this.xpCmdLbl.BackColor = System.Drawing.Color.Transparent;
            this.xpCmdLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.xpCmdLbl.Location = new System.Drawing.Point(289, 174);
            this.xpCmdLbl.Name = "xpCmdLbl";
            this.xpCmdLbl.Size = new System.Drawing.Size(28, 19);
            this.xpCmdLbl.Style = MetroFramework.MetroColorStyle.Blue;
            this.xpCmdLbl.TabIndex = 48;
            this.xpCmdLbl.Tag = "NonHost";
            this.xpCmdLbl.Text = "/xp";
            this.xpCmdLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.xpCmdLbl.UseStyleColors = true;
            // 
            // xpPanel
            // 
            this.xpPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.xpPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpPanel.Controls.Add(this.giveXPLevelsBtn);
            this.xpPanel.Controls.Add(this.giveXPOrbsBtn);
            this.xpPanel.Controls.Add(this.xpAmountBox);
            this.xpPanel.HorizontalScrollbarBarColor = true;
            this.xpPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.xpPanel.HorizontalScrollbarSize = 10;
            this.xpPanel.Location = new System.Drawing.Point(285, 184);
            this.xpPanel.Name = "xpPanel";
            this.xpPanel.Size = new System.Drawing.Size(180, 145);
            this.xpPanel.TabIndex = 47;
            this.xpPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.xpPanel.VerticalScrollbarBarColor = true;
            this.xpPanel.VerticalScrollbarHighlightOnWheel = false;
            this.xpPanel.VerticalScrollbarSize = 10;
            // 
            // giveXPLevelsBtn
            // 
            this.giveXPLevelsBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.giveXPLevelsBtn.Location = new System.Drawing.Point(3, 67);
            this.giveXPLevelsBtn.Name = "giveXPLevelsBtn";
            this.giveXPLevelsBtn.Size = new System.Drawing.Size(171, 23);
            this.giveXPLevelsBtn.TabIndex = 18;
            this.giveXPLevelsBtn.Text = "Give Levels";
            this.giveXPLevelsBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.giveXPLevelsBtn, "Gives you the amount of XP specified above in levels.");
            this.giveXPLevelsBtn.UseSelectable = true;
            this.giveXPLevelsBtn.Click += new System.EventHandler(this.GiveXpLevelsBtnClicked);
            // 
            // giveXPOrbsBtn
            // 
            this.giveXPOrbsBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.giveXPOrbsBtn.Location = new System.Drawing.Point(3, 39);
            this.giveXPOrbsBtn.Name = "giveXPOrbsBtn";
            this.giveXPOrbsBtn.Size = new System.Drawing.Size(171, 23);
            this.giveXPOrbsBtn.TabIndex = 19;
            this.giveXPOrbsBtn.Text = "Give XP";
            this.giveXPOrbsBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.giveXPOrbsBtn, "Gives you the raw amount of XP specified above.");
            this.giveXPOrbsBtn.UseSelectable = true;
            this.giveXPOrbsBtn.Click += new System.EventHandler(this.GiveXpOrbsBtnClicked);
            // 
            // xpAmountBox
            // 
            // 
            // 
            // 
            this.xpAmountBox.CustomButton.Image = null;
            this.xpAmountBox.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.xpAmountBox.CustomButton.Name = "";
            this.xpAmountBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.xpAmountBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.xpAmountBox.CustomButton.TabIndex = 1;
            this.xpAmountBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.xpAmountBox.CustomButton.UseSelectable = true;
            this.xpAmountBox.CustomButton.Visible = false;
            this.xpAmountBox.Lines = new string[0];
            this.xpAmountBox.Location = new System.Drawing.Point(3, 11);
            this.xpAmountBox.MaxLength = 11;
            this.xpAmountBox.Name = "xpAmountBox";
            this.xpAmountBox.PasswordChar = '\0';
            this.xpAmountBox.PromptText = "Enter Amount...";
            this.xpAmountBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.xpAmountBox.SelectedText = "";
            this.xpAmountBox.SelectionLength = 0;
            this.xpAmountBox.SelectionStart = 0;
            this.xpAmountBox.ShortcutsEnabled = true;
            this.xpAmountBox.Size = new System.Drawing.Size(172, 23);
            this.xpAmountBox.TabIndex = 20;
            this.xpAmountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.xpAmountBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.xpAmountBox.UseSelectable = true;
            this.xpAmountBox.WaterMark = "Enter Amount...";
            this.xpAmountBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.xpAmountBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gamemodeCmdLbl
            // 
            this.gamemodeCmdLbl.AutoSize = true;
            this.gamemodeCmdLbl.BackColor = System.Drawing.Color.Transparent;
            this.gamemodeCmdLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.gamemodeCmdLbl.Location = new System.Drawing.Point(99, 174);
            this.gamemodeCmdLbl.Name = "gamemodeCmdLbl";
            this.gamemodeCmdLbl.Size = new System.Drawing.Size(125, 19);
            this.gamemodeCmdLbl.Style = MetroFramework.MetroColorStyle.Blue;
            this.gamemodeCmdLbl.TabIndex = 46;
            this.gamemodeCmdLbl.Tag = "NonHost";
            this.gamemodeCmdLbl.Text = "/defaultgamemode";
            this.gamemodeCmdLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gamemodeCmdLbl.UseStyleColors = true;
            // 
            // gamemodePanel
            // 
            this.gamemodePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamemodePanel.Controls.Add(this.SpectatorCommandBtn);
            this.gamemodePanel.Controls.Add(this.AdventureCommandBtn);
            this.gamemodePanel.Controls.Add(this.CreativeCommandBtn);
            this.gamemodePanel.Controls.Add(this.SurvivalCommandBtn);
            this.gamemodePanel.HorizontalScrollbarBarColor = true;
            this.gamemodePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.gamemodePanel.HorizontalScrollbarSize = 10;
            this.gamemodePanel.Location = new System.Drawing.Point(95, 184);
            this.gamemodePanel.Name = "gamemodePanel";
            this.gamemodePanel.Size = new System.Drawing.Size(180, 145);
            this.gamemodePanel.TabIndex = 45;
            this.gamemodePanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gamemodePanel.VerticalScrollbarBarColor = true;
            this.gamemodePanel.VerticalScrollbarHighlightOnWheel = false;
            this.gamemodePanel.VerticalScrollbarSize = 10;
            // 
            // SpectatorCommandBtn
            // 
            this.SpectatorCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.SpectatorCommandBtn.Location = new System.Drawing.Point(3, 98);
            this.SpectatorCommandBtn.Name = "SpectatorCommandBtn";
            this.SpectatorCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.SpectatorCommandBtn.TabIndex = 17;
            this.SpectatorCommandBtn.Text = "Spectator";
            this.SpectatorCommandBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SpectatorCommandBtn.UseSelectable = true;
            this.SpectatorCommandBtn.Click += new System.EventHandler(this.SpectatorCommandBtnClicked);
            // 
            // AdventureCommandBtn
            // 
            this.AdventureCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.AdventureCommandBtn.Location = new System.Drawing.Point(3, 69);
            this.AdventureCommandBtn.Name = "AdventureCommandBtn";
            this.AdventureCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.AdventureCommandBtn.TabIndex = 17;
            this.AdventureCommandBtn.Text = "Adventure";
            this.AdventureCommandBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AdventureCommandBtn.UseSelectable = true;
            this.AdventureCommandBtn.Click += new System.EventHandler(this.AdventureCommandBtnClicked);
            // 
            // CreativeCommandBtn
            // 
            this.CreativeCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.CreativeCommandBtn.Location = new System.Drawing.Point(3, 40);
            this.CreativeCommandBtn.Name = "CreativeCommandBtn";
            this.CreativeCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.CreativeCommandBtn.TabIndex = 17;
            this.CreativeCommandBtn.Text = "Creative";
            this.CreativeCommandBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CreativeCommandBtn.UseSelectable = true;
            this.CreativeCommandBtn.Click += new System.EventHandler(this.CreativeCommandBtnClicked);
            // 
            // SurvivalCommandBtn
            // 
            this.SurvivalCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.SurvivalCommandBtn.Location = new System.Drawing.Point(3, 11);
            this.SurvivalCommandBtn.Name = "SurvivalCommandBtn";
            this.SurvivalCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.SurvivalCommandBtn.TabIndex = 17;
            this.SurvivalCommandBtn.Text = "Survival";
            this.SurvivalCommandBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SurvivalCommandBtn, "Sets your gamemode to Survival mode.");
            this.SurvivalCommandBtn.UseSelectable = true;
            this.SurvivalCommandBtn.Click += new System.EventHandler(this.SurvivalCommandBtnClicked);
            // 
            // worldCmdLbl
            // 
            this.worldCmdLbl.AutoSize = true;
            this.worldCmdLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.worldCmdLbl.Location = new System.Drawing.Point(843, 9);
            this.worldCmdLbl.Name = "worldCmdLbl";
            this.worldCmdLbl.Size = new System.Drawing.Size(45, 19);
            this.worldCmdLbl.Style = MetroFramework.MetroColorStyle.Blue;
            this.worldCmdLbl.TabIndex = 44;
            this.worldCmdLbl.Tag = "NonHost";
            this.worldCmdLbl.Text = "World";
            this.worldCmdLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.worldCmdLbl.UseStyleColors = true;
            // 
            // worldPanel
            // 
            this.worldPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.worldPanel.Controls.Add(this.setWorldSpawnBtn);
            this.worldPanel.Controls.Add(this.downfallCommandBtn);
            this.worldPanel.HorizontalScrollbarBarColor = true;
            this.worldPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.worldPanel.HorizontalScrollbarSize = 10;
            this.worldPanel.Location = new System.Drawing.Point(839, 19);
            this.worldPanel.Name = "worldPanel";
            this.worldPanel.Size = new System.Drawing.Size(180, 145);
            this.worldPanel.TabIndex = 43;
            this.worldPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.worldPanel.VerticalScrollbarBarColor = true;
            this.worldPanel.VerticalScrollbarHighlightOnWheel = false;
            this.worldPanel.VerticalScrollbarSize = 10;
            // 
            // setWorldSpawnBtn
            // 
            this.setWorldSpawnBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.setWorldSpawnBtn.Location = new System.Drawing.Point(3, 38);
            this.setWorldSpawnBtn.Name = "setWorldSpawnBtn";
            this.setWorldSpawnBtn.Size = new System.Drawing.Size(172, 23);
            this.setWorldSpawnBtn.TabIndex = 18;
            this.setWorldSpawnBtn.Text = "/setworldspawn";
            this.setWorldSpawnBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.setWorldSpawnBtn, "Sets the world\'s spawn point to your current location.");
            this.setWorldSpawnBtn.UseSelectable = true;
            this.setWorldSpawnBtn.Click += new System.EventHandler(this.SetWorldSpawnBtnClicked);
            // 
            // downfallCommandBtn
            // 
            this.downfallCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.downfallCommandBtn.Location = new System.Drawing.Point(3, 11);
            this.downfallCommandBtn.Name = "downfallCommandBtn";
            this.downfallCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.downfallCommandBtn.TabIndex = 17;
            this.downfallCommandBtn.Text = "/toggledownfall";
            this.downfallCommandBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.downfallCommandBtn, "Executes the /toggledownfall command (doesn\'t appear to do anything)");
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
            this.playerCmdLbl.Style = MetroFramework.MetroColorStyle.Blue;
            this.playerCmdLbl.TabIndex = 42;
            this.playerCmdLbl.Tag = "NonHost";
            this.playerCmdLbl.Text = "Player";
            this.playerCmdLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.playerCmdLbl.UseStyleColors = true;
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
            this.playerPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.playerPanel.VerticalScrollbarBarColor = true;
            this.playerPanel.VerticalScrollbarHighlightOnWheel = false;
            this.playerPanel.VerticalScrollbarSize = 10;
            // 
            // killCommandBtn
            // 
            this.killCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.killCommandBtn.Location = new System.Drawing.Point(3, 11);
            this.killCommandBtn.Name = "killCommandBtn";
            this.killCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.killCommandBtn.TabIndex = 17;
            this.killCommandBtn.Text = "/kill";
            this.killCommandBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.killCommandBtn, "Kills yourself, literally. That\'s all it does.");
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
            this.timeCmdLbl.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeCmdLbl.TabIndex = 40;
            this.timeCmdLbl.Tag = "NonHost";
            this.timeCmdLbl.Text = "/time";
            this.timeCmdLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timeCmdLbl.UseStyleColors = true;
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
            this.timePanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timePanel.VerticalScrollbarBarColor = true;
            this.timePanel.VerticalScrollbarHighlightOnWheel = false;
            this.timePanel.VerticalScrollbarSize = 10;
            // 
            // timeCommandBtn
            // 
            this.timeCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.timeCommandBtn.Location = new System.Drawing.Point(3, 117);
            this.timeCommandBtn.Name = "timeCommandBtn";
            this.timeCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.timeCommandBtn.TabIndex = 17;
            this.timeCommandBtn.Text = " /time";
            this.timeCommandBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.timeCommandBtn, "Sets the time to whatever you specified.");
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
            this.timeAmountBox.Location = new System.Drawing.Point(3, 11);
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
            this.timeAmountBox.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.enchantCmdLbl.Style = MetroFramework.MetroColorStyle.Blue;
            this.enchantCmdLbl.TabIndex = 38;
            this.enchantCmdLbl.Tag = "NonHost";
            this.enchantCmdLbl.Text = "/enchant";
            this.enchantCmdLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.enchantCmdLbl.UseStyleColors = true;
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
            this.enchantPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.enchantIDBox.Location = new System.Drawing.Point(3, 11);
            this.enchantIDBox.Name = "enchantIDBox";
            this.enchantIDBox.Size = new System.Drawing.Size(172, 25);
            this.enchantIDBox.TabIndex = 17;
            this.enchantIDBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.enchantIDBox.UseSelectable = true;
            // 
            // enchantCommandBtn
            // 
            this.enchantCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.enchantCommandBtn.Location = new System.Drawing.Point(3, 117);
            this.enchantCommandBtn.Name = "enchantCommandBtn";
            this.enchantCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.enchantCommandBtn.TabIndex = 17;
            this.enchantCommandBtn.Text = "/enchant";
            this.enchantCommandBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.enchantCommandBtn, "Enchants your current held item using the parameters above.");
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
            this.enchantLevelBox.Location = new System.Drawing.Point(3, 40);
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
            this.enchantLevelBox.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.giveCmdLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.giveCmdLabel.TabIndex = 36;
            this.giveCmdLabel.Tag = "NonHost";
            this.giveCmdLabel.Text = "/give";
            this.giveCmdLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.giveCmdLabel.UseStyleColors = true;
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
            this.giveCommandPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.giveCommandPanel.VerticalScrollbarBarColor = true;
            this.giveCommandPanel.VerticalScrollbarHighlightOnWheel = false;
            this.giveCommandPanel.VerticalScrollbarSize = 10;
            // 
            // itemIdHelpBtn
            // 
            this.itemIdHelpBtn.Highlight = true;
            this.itemIdHelpBtn.Location = new System.Drawing.Point(143, 11);
            this.itemIdHelpBtn.Name = "itemIdHelpBtn";
            this.itemIdHelpBtn.Size = new System.Drawing.Size(32, 23);
            this.itemIdHelpBtn.TabIndex = 45;
            this.itemIdHelpBtn.Text = "?";
            this.itemIdHelpBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.itemIdHelpBtn, "Helpful information on how to use the /give command.");
            this.itemIdHelpBtn.UseSelectable = true;
            this.itemIdHelpBtn.Click += new System.EventHandler(this.ItemIdHelpBtnClicked);
            // 
            // giveCommandBtn
            // 
            this.giveCommandBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.giveCommandBtn.Location = new System.Drawing.Point(3, 117);
            this.giveCommandBtn.Name = "giveCommandBtn";
            this.giveCommandBtn.Size = new System.Drawing.Size(172, 23);
            this.giveCommandBtn.TabIndex = 17;
            this.giveCommandBtn.Text = "/give";
            this.giveCommandBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.giveCommandBtn, "Gives you the item using the parameters specified above.");
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
            this.giveDataBox.Location = new System.Drawing.Point(3, 69);
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
            this.giveDataBox.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.giveAmountBox.Location = new System.Drawing.Point(4, 40);
            this.giveAmountBox.MaxLength = 5;
            this.giveAmountBox.Name = "giveAmountBox";
            this.giveAmountBox.PasswordChar = '\0';
            this.giveAmountBox.PromptText = "Item Amount (Max 32767)";
            this.giveAmountBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.giveAmountBox.SelectedText = "";
            this.giveAmountBox.SelectionLength = 0;
            this.giveAmountBox.SelectionStart = 0;
            this.giveAmountBox.ShortcutsEnabled = true;
            this.giveAmountBox.Size = new System.Drawing.Size(172, 23);
            this.giveAmountBox.TabIndex = 17;
            this.giveAmountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.giveAmountBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.giveAmountBox, "How many of the items you want");
            this.giveAmountBox.UseSelectable = true;
            this.giveAmountBox.WaterMark = "Item Amount (Max 32767)";
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
            this.giveIDBox.Location = new System.Drawing.Point(3, 11);
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
            this.giveIDBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.giveIDBox, "The ID of the item you want");
            this.giveIDBox.UseSelectable = true;
            this.giveIDBox.WaterMark = "Item ID";
            this.giveIDBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.giveIDBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.giveIDBox.TextChanged += new System.EventHandler(this.CheckItemId);
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.TipsBtn);
            this.settingsTab.Controls.Add(this.TutorialBtn);
            this.settingsTab.Controls.Add(this.SeasonalThemes);
            this.settingsTab.Controls.Add(this.TextAllignBox);
            this.settingsTab.Controls.Add(this.TextAllignLbl);
            this.settingsTab.Controls.Add(this.HostIndicators);
            this.settingsTab.Controls.Add(this.CemuPckMngrBtn);
            this.settingsTab.Controls.Add(this.QuickModsManagerBtn);
            this.settingsTab.Controls.Add(this.OpenLangMngrBtn);
            this.settingsTab.Controls.Add(this.CheckForPreRelease);
            this.settingsTab.Controls.Add(this.settingsLogo);
            this.settingsTab.Controls.Add(this.updateBtn);
            this.settingsTab.Controls.Add(this.discordRpcCheckBox);
            this.settingsTab.Controls.Add(this.ColorsBox);
            this.settingsTab.Controls.Add(this.ColorLabel);
            this.settingsTab.HorizontalScrollbarBarColor = true;
            this.settingsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsTab.HorizontalScrollbarSize = 10;
            this.settingsTab.Location = new System.Drawing.Point(4, 9);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(1122, 630);
            this.settingsTab.TabIndex = 5;
            this.settingsTab.Tag = "";
            this.settingsTab.Text = "Settings";
            this.settingsTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.settingsTab.VerticalScrollbarBarColor = true;
            this.settingsTab.VerticalScrollbarHighlightOnWheel = false;
            this.settingsTab.VerticalScrollbarSize = 10;
            // 
            // TipsBtn
            // 
            this.TipsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TipsBtn.Location = new System.Drawing.Point(87, 241);
            this.TipsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TipsBtn.Name = "TipsBtn";
            this.TipsBtn.Size = new System.Drawing.Size(1021, 36);
            this.TipsBtn.TabIndex = 56;
            this.TipsBtn.Text = "Tips";
            this.TipsBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.TipsBtn, "Shows a random tip relating to the Mod Injector");
            this.TipsBtn.UseSelectable = true;
            this.TipsBtn.Click += new System.EventHandler(this.TipsBtnClicked);
            // 
            // TutorialBtn
            // 
            this.TutorialBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TutorialBtn.Location = new System.Drawing.Point(87, 193);
            this.TutorialBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TutorialBtn.Name = "TutorialBtn";
            this.TutorialBtn.Size = new System.Drawing.Size(1021, 36);
            this.TutorialBtn.TabIndex = 55;
            this.TutorialBtn.Text = "Tutorial";
            this.TutorialBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.TutorialBtn, "Launches the Mod Injector Tutorial");
            this.TutorialBtn.UseSelectable = true;
            this.TutorialBtn.Click += new System.EventHandler(this.TutorialBtnClicked);
            // 
            // SeasonalThemes
            // 
            this.SeasonalThemes.AutoSize = true;
            this.SeasonalThemes.Location = new System.Drawing.Point(592, 73);
            this.SeasonalThemes.Name = "SeasonalThemes";
            this.SeasonalThemes.Size = new System.Drawing.Size(113, 15);
            this.SeasonalThemes.TabIndex = 54;
            this.SeasonalThemes.Text = "Seasonal Themes";
            this.SeasonalThemes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SeasonalThemes, "Whether to use themes based on certain holidays");
            this.SeasonalThemes.UseSelectable = true;
            this.SeasonalThemes.CheckedChanged += new System.EventHandler(this.SeasonalThemesToggled);
            // 
            // TextAllignBox
            // 
            this.TextAllignBox.FormattingEnabled = true;
            this.TextAllignBox.ItemHeight = 23;
            this.TextAllignBox.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.TextAllignBox.Location = new System.Drawing.Point(87, 38);
            this.TextAllignBox.Name = "TextAllignBox";
            this.TextAllignBox.Size = new System.Drawing.Size(1028, 29);
            this.TextAllignBox.TabIndex = 53;
            this.TextAllignBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextAllignBox.UseSelectable = true;
            this.TextAllignBox.SelectedIndexChanged += new System.EventHandler(this.FormTxtAlgnSelected);
            // 
            // TextAllignLbl
            // 
            this.TextAllignLbl.AutoSize = true;
            this.TextAllignLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TextAllignLbl.Location = new System.Drawing.Point(7, 38);
            this.TextAllignLbl.Name = "TextAllignLbl";
            this.TextAllignLbl.Size = new System.Drawing.Size(74, 19);
            this.TextAllignLbl.TabIndex = 52;
            this.TextAllignLbl.Text = "Text Allign:";
            this.TextAllignLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // HostIndicators
            // 
            this.HostIndicators.AutoSize = true;
            this.HostIndicators.Location = new System.Drawing.Point(419, 73);
            this.HostIndicators.Name = "HostIndicators";
            this.HostIndicators.Size = new System.Drawing.Size(167, 15);
            this.HostIndicators.TabIndex = 51;
            this.HostIndicators.Text = "Host / Non-Host Indicators";
            this.HostIndicators.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.HostIndicators, "Whether to highlight host/non host mods\r\n\r\nNon Host: Blue\r\nHost: Orange");
            this.HostIndicators.UseSelectable = true;
            this.HostIndicators.CheckedChanged += new System.EventHandler(this.HostIndicatorsToggled);
            // 
            // CemuPckMngrBtn
            // 
            this.CemuPckMngrBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CemuPckMngrBtn.Location = new System.Drawing.Point(773, 97);
            this.CemuPckMngrBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CemuPckMngrBtn.Name = "CemuPckMngrBtn";
            this.CemuPckMngrBtn.Size = new System.Drawing.Size(335, 36);
            this.CemuPckMngrBtn.TabIndex = 50;
            this.CemuPckMngrBtn.Text = "Cemu Graphics Pack Manager";
            this.CemuPckMngrBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.CemuPckMngrBtn, "Opens the Cemu Graphics Pack Manager");
            this.CemuPckMngrBtn.UseSelectable = true;
            this.CemuPckMngrBtn.Click += new System.EventHandler(this.CemuPckMngrBtnClicked);
            // 
            // QuickModsManagerBtn
            // 
            this.QuickModsManagerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuickModsManagerBtn.Location = new System.Drawing.Point(430, 97);
            this.QuickModsManagerBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.QuickModsManagerBtn.Name = "QuickModsManagerBtn";
            this.QuickModsManagerBtn.Size = new System.Drawing.Size(335, 36);
            this.QuickModsManagerBtn.TabIndex = 49;
            this.QuickModsManagerBtn.Text = "Quick Mods Manager";
            this.QuickModsManagerBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.QuickModsManagerBtn, "Opens the Quick Mods Manager");
            this.QuickModsManagerBtn.UseSelectable = true;
            this.QuickModsManagerBtn.Click += new System.EventHandler(this.QuickModsManagerBtnClicked);
            // 
            // OpenLangMngrBtn
            // 
            this.OpenLangMngrBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenLangMngrBtn.Location = new System.Drawing.Point(87, 97);
            this.OpenLangMngrBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenLangMngrBtn.Name = "OpenLangMngrBtn";
            this.OpenLangMngrBtn.Size = new System.Drawing.Size(335, 36);
            this.OpenLangMngrBtn.TabIndex = 48;
            this.OpenLangMngrBtn.Text = "Languages Manager";
            this.OpenLangMngrBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.OpenLangMngrBtn, "Opens the Language Manager");
            this.OpenLangMngrBtn.UseSelectable = true;
            this.OpenLangMngrBtn.Click += new System.EventHandler(this.OpenLangMngrBtnClicked);
            // 
            // CheckForPreRelease
            // 
            this.CheckForPreRelease.AutoSize = true;
            this.CheckForPreRelease.Location = new System.Drawing.Point(232, 73);
            this.CheckForPreRelease.Name = "CheckForPreRelease";
            this.CheckForPreRelease.Size = new System.Drawing.Size(181, 15);
            this.CheckForPreRelease.TabIndex = 47;
            this.CheckForPreRelease.Text = "Check for pre-release versions";
            this.CheckForPreRelease.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.CheckForPreRelease, "Whether to check for pre-release updates\r\nNote: these may not work correctly");
            this.CheckForPreRelease.UseSelectable = true;
            this.CheckForPreRelease.CheckedChanged += new System.EventHandler(this.CheckForPreReleaseToggled);
            // 
            // settingsLogo
            // 
            this.settingsLogo.BackColor = System.Drawing.Color.Transparent;
            this.settingsLogo.BackgroundImage = global::Minecraft_Wii_U_Mod_Injector.Properties.Resources.MinecraftWiiUModInjector;
            this.settingsLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsLogo.HorizontalScrollbarBarColor = true;
            this.settingsLogo.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsLogo.HorizontalScrollbarSize = 10;
            this.settingsLogo.Location = new System.Drawing.Point(87, 286);
            this.settingsLogo.Name = "settingsLogo";
            this.settingsLogo.Size = new System.Drawing.Size(1028, 334);
            this.settingsLogo.TabIndex = 44;
            this.settingsLogo.VerticalScrollbarBarColor = true;
            this.settingsLogo.VerticalScrollbarHighlightOnWheel = false;
            this.settingsLogo.VerticalScrollbarSize = 10;
            // 
            // updateBtn
            // 
            this.updateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateBtn.Location = new System.Drawing.Point(87, 145);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(1021, 36);
            this.updateBtn.TabIndex = 45;
            this.updateBtn.Text = "Check for Updates";
            this.updateBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.updateBtn, "Checks for a new update");
            this.updateBtn.UseSelectable = true;
            this.updateBtn.Click += new System.EventHandler(this.CheckUpdatesClicked);
            // 
            // discordRpcCheckBox
            // 
            this.discordRpcCheckBox.AutoSize = true;
            this.discordRpcCheckBox.Checked = true;
            this.discordRpcCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.discordRpcCheckBox.Location = new System.Drawing.Point(87, 73);
            this.discordRpcCheckBox.Name = "discordRpcCheckBox";
            this.discordRpcCheckBox.Size = new System.Drawing.Size(139, 15);
            this.discordRpcCheckBox.TabIndex = 43;
            this.discordRpcCheckBox.Text = "Discord Rich Presence";
            this.discordRpcCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.discordRpcCheckBox.UseSelectable = true;
            this.discordRpcCheckBox.CheckedChanged += new System.EventHandler(this.DiscordRpcToggleChecked);
            // 
            // ColorsBox
            // 
            this.ColorsBox.FormattingEnabled = true;
            this.ColorsBox.ItemHeight = 23;
            this.ColorsBox.Items.AddRange(new object[] {
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
            this.ColorsBox.Location = new System.Drawing.Point(65, 3);
            this.ColorsBox.Name = "ColorsBox";
            this.ColorsBox.Size = new System.Drawing.Size(1050, 29);
            this.ColorsBox.TabIndex = 37;
            this.ColorsBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ColorsBox.UseSelectable = true;
            this.ColorsBox.SelectedIndexChanged += new System.EventHandler(this.FormColorSelected);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ColorLabel.Location = new System.Drawing.Point(7, 3);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(45, 19);
            this.ColorLabel.TabIndex = 36;
            this.ColorLabel.Text = "Color:";
            this.ColorLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GlideTile
            // 
            this.GlideTile.ActiveControl = null;
            this.GlideTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.GlideTile.Location = new System.Drawing.Point(0, 120);
            this.GlideTile.Name = "GlideTile";
            this.GlideTile.PaintTileCount = false;
            this.GlideTile.Size = new System.Drawing.Size(159, 40);
            this.GlideTile.TabIndex = 8;
            this.GlideTile.Tag = "MgTile";
            this.GlideTile.Text = "Glide";
            this.GlideTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GlideTile.TileCount = 3;
            this.GlideTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.GlideTile.UseSelectable = true;
            this.GlideTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // TumbleTile
            // 
            this.TumbleTile.ActiveControl = null;
            this.TumbleTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.TumbleTile.Location = new System.Drawing.Point(0, 80);
            this.TumbleTile.Name = "TumbleTile";
            this.TumbleTile.PaintTileCount = false;
            this.TumbleTile.Size = new System.Drawing.Size(159, 40);
            this.TumbleTile.TabIndex = 7;
            this.TumbleTile.Tag = "MgTile";
            this.TumbleTile.Text = "Tumble";
            this.TumbleTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TumbleTile.TileCount = 2;
            this.TumbleTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TumbleTile.UseSelectable = true;
            this.TumbleTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // BattleTile
            // 
            this.BattleTile.ActiveControl = null;
            this.BattleTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.BattleTile.Location = new System.Drawing.Point(0, 40);
            this.BattleTile.Name = "BattleTile";
            this.BattleTile.PaintTileCount = false;
            this.BattleTile.Size = new System.Drawing.Size(159, 40);
            this.BattleTile.TabIndex = 6;
            this.BattleTile.Tag = "MgTile";
            this.BattleTile.Text = "Battle";
            this.BattleTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BattleTile.TileCount = 1;
            this.BattleTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.BattleTile.UseSelectable = true;
            this.BattleTile.UseTileImage = true;
            this.BattleTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // GeneralMgTile
            // 
            this.GeneralMgTile.ActiveControl = null;
            this.GeneralMgTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneralMgTile.Location = new System.Drawing.Point(0, 0);
            this.GeneralMgTile.Name = "GeneralMgTile";
            this.GeneralMgTile.PaintTileCount = false;
            this.GeneralMgTile.Size = new System.Drawing.Size(159, 40);
            this.GeneralMgTile.TabIndex = 5;
            this.GeneralMgTile.Tag = "MgTile";
            this.GeneralMgTile.Text = "General";
            this.GeneralMgTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GeneralMgTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.GeneralMgTile.UseSelectable = true;
            this.GeneralMgTile.UseTileImage = true;
            this.GeneralMgTile.Click += new System.EventHandler(this.SwapTab);
            // 
            // HomeTile
            // 
            this.HomeTile.ActiveControl = null;
            this.HomeTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeTile.Location = new System.Drawing.Point(0, 0);
            this.HomeTile.Name = "HomeTile";
            this.HomeTile.PaintTileCount = false;
            this.HomeTile.Size = new System.Drawing.Size(159, 55);
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
            this.StyleMngr.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // StyleExtender
            // 
            this.StyleExtender.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ToolTipManager
            // 
            this.ToolTipManager.Style = MetroFramework.MetroColorStyle.Default;
            this.ToolTipManager.StyleManager = null;
            this.ToolTipManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PlayersTile
            // 
            this.PlayersTile.ActiveControl = null;
            this.PlayersTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayersTile.Location = new System.Drawing.Point(0, 55);
            this.PlayersTile.Name = "PlayersTile";
            this.PlayersTile.PaintTileCount = false;
            this.PlayersTile.Size = new System.Drawing.Size(159, 55);
            this.PlayersTile.TabIndex = 2;
            this.PlayersTile.Tag = "";
            this.PlayersTile.Text = "Player(s) / Item(s)";
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
            this.CommandsTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.CommandsTile.Location = new System.Drawing.Point(0, 434);
            this.CommandsTile.Name = "CommandsTile";
            this.CommandsTile.PaintTileCount = false;
            this.CommandsTile.Size = new System.Drawing.Size(159, 55);
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
            this.RightClickMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // NavMenuPnl
            // 
            this.NavMenuPnl.Controls.Add(this.BuildTile);
            this.NavMenuPnl.Controls.Add(this.SettingsTile);
            this.NavMenuPnl.Controls.Add(this.CommandsTile);
            this.NavMenuPnl.Controls.Add(this.NavMenuMgPnl);
            this.NavMenuPnl.Controls.Add(this.MinigamesTile);
            this.NavMenuPnl.Controls.Add(this.GeneralTile);
            this.NavMenuPnl.Controls.Add(this.WorldTile);
            this.NavMenuPnl.Controls.Add(this.PlayersTile);
            this.NavMenuPnl.Controls.Add(this.HomeTile);
            this.NavMenuPnl.HorizontalScrollbarBarColor = true;
            this.NavMenuPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.NavMenuPnl.HorizontalScrollbarSize = 10;
            this.NavMenuPnl.Location = new System.Drawing.Point(1, 60);
            this.NavMenuPnl.Name = "NavMenuPnl";
            this.NavMenuPnl.Size = new System.Drawing.Size(159, 641);
            this.NavMenuPnl.TabIndex = 0;
            this.NavMenuPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NavMenuPnl.VerticalScrollbarBarColor = true;
            this.NavMenuPnl.VerticalScrollbarHighlightOnWheel = false;
            this.NavMenuPnl.VerticalScrollbarSize = 10;
            // 
            // NavMenuMgPnl
            // 
            this.NavMenuMgPnl.Controls.Add(this.GlideTile);
            this.NavMenuMgPnl.Controls.Add(this.TumbleTile);
            this.NavMenuMgPnl.Controls.Add(this.BattleTile);
            this.NavMenuMgPnl.Controls.Add(this.GeneralMgTile);
            this.NavMenuMgPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavMenuMgPnl.HorizontalScrollbarBarColor = true;
            this.NavMenuMgPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.NavMenuMgPnl.HorizontalScrollbarSize = 10;
            this.NavMenuMgPnl.Location = new System.Drawing.Point(0, 275);
            this.NavMenuMgPnl.Name = "NavMenuMgPnl";
            this.NavMenuMgPnl.Size = new System.Drawing.Size(159, 159);
            this.NavMenuMgPnl.TabIndex = 8;
            this.NavMenuMgPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NavMenuMgPnl.VerticalScrollbarBarColor = true;
            this.NavMenuMgPnl.VerticalScrollbarHighlightOnWheel = false;
            this.NavMenuMgPnl.VerticalScrollbarSize = 10;
            this.NavMenuMgPnl.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.NavMenuPnl);
            this.Controls.Add(this.MainTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 700);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Minecraft: Wii U Mod Injector";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit);
            this.Load += new System.EventHandler(this.Init);
            this.Shown += new System.EventHandler(this.InitShown);
            this.MainTabs.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.playersTab.ResumeLayout(false);
            this.playersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AirborneSpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterDownStrengthSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxStackSlider)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.FogDistanceSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiquidSpreadTimeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntitySpeedSlider)).EndInit();
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CursedSlider)).EndInit();
            this.MinigamesTab.ResumeLayout(false);
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
            this.tellrawPanel.ResumeLayout(false);
            this.tellrawPanel.PerformLayout();
            this.xpPanel.ResumeLayout(false);
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
            this.NavMenuPnl.ResumeLayout(false);
            this.NavMenuPnl.PerformLayout();
            this.NavMenuMgPnl.ResumeLayout(false);
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
        public MetroFramework.Controls.MetroTabPage MinigamesTab;
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
        public MetroFramework.Controls.MetroCheckBox BypassInvulnerability;
        public MetroFramework.Controls.MetroCheckBox WearAnything;
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
        public MetroFramework.Controls.MetroCheckBox Flight;
        public MetroFramework.Controls.MetroCheckBox DisableSuffocating;
        public MetroFramework.Controls.MetroCheckBox NoFallDamage;
        public MetroFramework.Controls.MetroCheckBox CraftAnything;
        public MetroFramework.Controls.MetroCheckBox CreativeMode;
        public System.Windows.Forms.NumericUpDown SprintingSpeedScaleSlider;
        public MetroFramework.Controls.MetroLabel WalkingSpeedScale;
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
        public MetroFramework.Controls.MetroCheckBox AcidLiquidBlocks;
        public MetroFramework.Controls.MetroCheckBox DisableCreativeFlag;
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
        public MetroFramework.Controls.MetroComboBox ColorsBox;
        public MetroFramework.Controls.MetroLabel ColorLabel;
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
        public MetroFramework.Controls.MetroLabel SprintingSpeedScale;
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
        private MetroFramework.Controls.MetroButton setWorldSpawnBtn;
        private MetroFramework.Controls.MetroLabel gamemodeCmdLbl;
        private MetroFramework.Controls.MetroPanel gamemodePanel;
        private MetroFramework.Controls.MetroButton SurvivalCommandBtn;
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
        public MetroTextBox WiiUIPv4Box;
        public MetroTextBox BuildNotesBox;
        public MetroButton OpenLangMngrBtn;
        public MetroButton SetupTutorialBtn;
        private MetroLabel Game;
        private MetroLabel UIUserInterface;
        private MetroPanel generalPanel;
        public MetroCheckBox DebugConsole;
        private MetroCheckBox UnlockSignKeyboard;
        private MetroLabel xpCmdLbl;
        private MetroPanel xpPanel;
        private MetroButton giveXPLevelsBtn;
        private MetroButton giveXPOrbsBtn;
        private MetroTextBox xpAmountBox;
        public MetroButton QuickModsManagerBtn;
        public MetroCheckBox Invisible;
        public MetroCheckBox LeashAnyMobs;
        private MetroButton LootTableEditorBtn;
        public MetroButton EnchantmentEditorBtn;
        public MetroCheckBox WaterLogAnything;
        public MetroCheckBox UnlimitedEnchants;
        public MetroCheckBox SuperFurnace;
        public System.Windows.Forms.NumericUpDown MaxStackSlider;
        public MetroLabel MaxStack;
        public MetroCheckBox LeftHanded;
        public MetroCheckBox AirJump;
        public System.Windows.Forms.NumericUpDown EntitySpeedSlider;
        public MetroLabel EntitySpeed;
        public MetroCheckBox SleepingDoesntClearWeather;
        public MetroCheckBox InvulnerableEntities;
        public MetroCheckBox BreakAnything;
        private MetroLabel tellrawLbl;
        private MetroPanel tellrawPanel;
        private MetroRadioButton bedrockTellBox;
        private MetroTextBox tellMsgBox;
        private MetroButton tellrawCmdBtn;
        private MetroTextBox tellNameBox;
        private MetroRadioButton javaTellBox;
        private MetroLabel tellStyleLbl;
        public System.Windows.Forms.NumericUpDown LiquidSpreadTimeSlider;
        public MetroLabel LiquidSpreadTime;
        public MetroCheckBox DisableFallingBlocks;
        private MetroCheckBox CommandsInMinigames;
        private MetroLabel CommandsWarnLbl;
        private MetroButton AchievementEditor;
        public MetroCheckBox SwimFast;
        public MetroCheckBox BreakBedrock;
        public MetroButton updateBtn;
        public MetroLabel BreathingModeLbl;
        private MetroComboBox breatheBox;
        private MetroCheckBox MuteMicrophone;
        public MetroCheckBox Collision;
        public System.Windows.Forms.NumericUpDown WaterDownStrengthSlider;
        public MetroLabel WaterDownStrength;
        private MetroButton WorldGenerationOptsBtn;
        public MetroCheckBox RainMode;
        public MetroCheckBox ThunderMode;
        private MetroCheckBox AchievementsEverywhere;
        public MetroCheckBox NoDamage;
        private MetroCheckBox NoPosLock;
        private MetroCheckBox UnlockInventoty;
        private MetroCheckBox DisableCameraAnimation;
        public MetroButton CemuPckMngrBtn;
        public MetroCheckBox FreezeGameWhenPaused;
        private MetroCheckBox AllowMobs;
        private MetroCheckBox LiquidsCanConvert;
        private MetroComboBox MapSizeBox;
        public MetroLabel MapSizeLbl;
        public MetroCheckBox ItemOfUndying;
        public MetroCheckBox UnlimitedTotemsOfUndying;
        public MetroCheckBox SplashLingeringPotions;
        public MetroCheckBox EffectsLastForever;
        private MetroButton EntityEditorBtn;
        public MetroCheckBox PunchToRide;
        private MetroCheckBox Solo;
        private MetroCheckBox Cursed;
        public MetroCheckBox HostIndicators;
        public MetroTile GlideTile;
        public MetroTile TumbleTile;
        public MetroTile BattleTile;
        public MetroTile GeneralMgTile;
        public MetroComboBox TextAllignBox;
        public MetroLabel TextAllignLbl;
        public System.Windows.Forms.NumericUpDown AirborneSpeedSlider;
        public MetroLabel AirborneSpeed;
        public MetroCheckBox AlwaysDaylight;
        private MetroButton DLCManagerBtn;
        private MetroComboBox defPotionBox;
        public MetroLabel DefaultPotionEffect;
        public MetroCheckBox NoCooldowns;
        public System.Windows.Forms.NumericUpDown FogDistanceSlider;
        public MetroLabel FogDistance;
        public System.Windows.Forms.NumericUpDown CursedSlider;
        public MetroLabel CursedLbl;
        public MetroCheckBox InstantSleep;
        private MetroButton DebugConsoleCustomizerBtn;
        public MetroCheckBox SeasonalThemes;
        public MetroButton TutorialBtn;
        public MetroButton TipsBtn;
        public MetroPanel NavMenuPnl;
        public MetroPanel NavMenuMgPnl;
        private MetroButton KeyboardCustomizerBtn;
        private MetroButton CreativeCommandBtn;
        private MetroButton SpectatorCommandBtn;
        private MetroButton AdventureCommandBtn;
        private MetroRadioButton customTellBox;
        private MetroCheckBox PreventBeingKicked;
        public MetroCheckBox BubbleColumnAnywhere;
    }
}