namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    partial class SessionManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionManager));
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ToolTipManager = new MetroFramework.Components.MetroToolTip();
            this.RefreshPlayersTile = new MetroFramework.Controls.MetroTile();
            this.PauseSessionTile = new MetroFramework.Controls.MetroTile();
            this.PlayerGamemodeBox = new MetroFramework.Controls.MetroComboBox();
            this.XpLevelSlider = new System.Windows.Forms.NumericUpDown();
            this.ReturnToListBtn = new MetroFramework.Controls.MetroTile();
            this.RemoveCapeBtn = new MetroFramework.Controls.MetroButton();
            this.AddCapeBtn = new MetroFramework.Controls.MetroButton();
            this.DeleteSkinBtn = new MetroFramework.Controls.MetroButton();
            this.LoopSkins = new MetroFramework.Controls.MetroCheckBox();
            this.SkinList = new MetroFramework.Controls.MetroComboBox();
            this.AddSkinBtn = new MetroFramework.Controls.MetroButton();
            this.CapeList = new MetroFramework.Controls.MetroComboBox();
            this.MaximumPlrCountLbl = new MetroFramework.Controls.MetroLabel();
            this.SetVulnerableTile = new MetroFramework.Controls.MetroTile();
            this.SetInvulnerableTile = new MetroFramework.Controls.MetroTile();
            this.LockPositionTile = new MetroFramework.Controls.MetroTile();
            this.UnlockPositionTile = new MetroFramework.Controls.MetroTile();
            this.LoopCapes = new MetroFramework.Controls.MetroCheckBox();
            this.CloseContainerTile = new MetroFramework.Controls.MetroTile();
            this.MaxPlayerBar = new MetroFramework.Controls.MetroTrackBar();
            this.DisconnectSessionTile = new MetroFramework.Controls.MetroTile();
            this.RemoveFromGameBtn = new MetroFramework.Controls.MetroTile();
            this.PlayerListPnl = new MetroFramework.Controls.MetroPanel();
            this.PlayerListFlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayersLbl = new MetroFramework.Controls.MetroLabel();
            this.PlayersTabControl = new MetroFramework.Controls.MetroTabControl();
            this.PlayerListTab = new MetroFramework.Controls.MetroTabPage();
            this.SelectedPlayerTab = new MetroFramework.Controls.MetroTabPage();
            this.OptionsForLbl = new MetroFramework.Controls.MetroLabel();
            this.PlrOptionsPnl = new MetroFramework.Controls.MetroPanel();
            this.WarningLbl = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.xpLbl = new MetroFramework.Controls.MetroLabel();
            this.GamemodeLbl = new MetroFramework.Controls.MetroLabel();
            this.CapeLbl = new MetroFramework.Controls.MetroLabel();
            this.SkinLbl = new MetroFramework.Controls.MetroLabel();
            this.CurrentSessionLbl = new MetroFramework.Controls.MetroLabel();
            this.SessionOptionsPnl = new MetroFramework.Controls.MetroPanel();
            this.SessionOptsLbl = new MetroFramework.Controls.MetroLabel();
            this.SkinLoopTimer = new System.Windows.Forms.Timer(this.components);
            this.TrackbarToolTips = new MetroFramework.Components.MetroToolTip();
            this.CapeLoopTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XpLevelSlider)).BeginInit();
            this.PlayerListPnl.SuspendLayout();
            this.PlayersTabControl.SuspendLayout();
            this.PlayerListTab.SuspendLayout();
            this.SelectedPlayerTab.SuspendLayout();
            this.PlrOptionsPnl.SuspendLayout();
            this.SessionOptionsPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ToolTipManager
            // 
            this.ToolTipManager.Style = MetroFramework.MetroColorStyle.Default;
            this.ToolTipManager.StyleManager = null;
            this.ToolTipManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RefreshPlayersTile
            // 
            this.RefreshPlayersTile.ActiveControl = null;
            resources.ApplyResources(this.RefreshPlayersTile, "RefreshPlayersTile");
            this.RefreshPlayersTile.Name = "RefreshPlayersTile";
            this.RefreshPlayersTile.PaintTileCount = false;
            this.ToolTipManager.SetToolTip(this.RefreshPlayersTile, resources.GetString("RefreshPlayersTile.ToolTip"));
            this.RefreshPlayersTile.UseSelectable = true;
            this.RefreshPlayersTile.Click += new System.EventHandler(this.RefreshPlayersTileClicked);
            // 
            // PauseSessionTile
            // 
            this.PauseSessionTile.ActiveControl = null;
            resources.ApplyResources(this.PauseSessionTile, "PauseSessionTile");
            this.PauseSessionTile.Name = "PauseSessionTile";
            this.PauseSessionTile.PaintTileCount = false;
            this.ToolTipManager.SetToolTip(this.PauseSessionTile, resources.GetString("PauseSessionTile.ToolTip"));
            this.PauseSessionTile.UseSelectable = true;
            this.PauseSessionTile.Click += new System.EventHandler(this.PauseSessionTile_Clicked);
            // 
            // PlayerGamemodeBox
            // 
            resources.ApplyResources(this.PlayerGamemodeBox, "PlayerGamemodeBox");
            this.PlayerGamemodeBox.DisplayMember = "1";
            this.PlayerGamemodeBox.FormattingEnabled = true;
            this.PlayerGamemodeBox.Items.AddRange(new object[] {
            resources.GetString("PlayerGamemodeBox.Items"),
            resources.GetString("PlayerGamemodeBox.Items1"),
            resources.GetString("PlayerGamemodeBox.Items2")});
            this.PlayerGamemodeBox.Name = "PlayerGamemodeBox";
            this.PlayerGamemodeBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.PlayerGamemodeBox, resources.GetString("PlayerGamemodeBox.ToolTip"));
            this.PlayerGamemodeBox.UseSelectable = true;
            this.PlayerGamemodeBox.ValueMember = "0";
            this.PlayerGamemodeBox.SelectedIndexChanged += new System.EventHandler(this.PlayerGamemodeBoxChanged);
            // 
            // XpLevelSlider
            // 
            resources.ApplyResources(this.XpLevelSlider, "XpLevelSlider");
            this.XpLevelSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.XpLevelSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.XpLevelSlider.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.XpLevelSlider.Name = "XpLevelSlider";
            this.ToolTipManager.SetToolTip(this.XpLevelSlider, resources.GetString("XpLevelSlider.ToolTip"));
            this.XpLevelSlider.ValueChanged += new System.EventHandler(this.XpLevelSliderChanged);
            // 
            // ReturnToListBtn
            // 
            this.ReturnToListBtn.ActiveControl = null;
            resources.ApplyResources(this.ReturnToListBtn, "ReturnToListBtn");
            this.ReturnToListBtn.Name = "ReturnToListBtn";
            this.ReturnToListBtn.PaintTileCount = false;
            this.ReturnToListBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ReturnToListBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReturnToListBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ToolTipManager.SetToolTip(this.ReturnToListBtn, resources.GetString("ReturnToListBtn.ToolTip"));
            this.ReturnToListBtn.UseSelectable = true;
            this.ReturnToListBtn.Click += new System.EventHandler(this.ReturnToListBtn_Clicked);
            // 
            // RemoveCapeBtn
            // 
            resources.ApplyResources(this.RemoveCapeBtn, "RemoveCapeBtn");
            this.RemoveCapeBtn.Name = "RemoveCapeBtn";
            this.RemoveCapeBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.RemoveCapeBtn, resources.GetString("RemoveCapeBtn.ToolTip"));
            this.RemoveCapeBtn.UseSelectable = true;
            this.RemoveCapeBtn.Click += new System.EventHandler(this.DeleteCapeBtnClicked);
            // 
            // AddCapeBtn
            // 
            resources.ApplyResources(this.AddCapeBtn, "AddCapeBtn");
            this.AddCapeBtn.Name = "AddCapeBtn";
            this.AddCapeBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AddCapeBtn, resources.GetString("AddCapeBtn.ToolTip"));
            this.AddCapeBtn.UseSelectable = true;
            this.AddCapeBtn.Click += new System.EventHandler(this.AddCapeBtnClicked);
            // 
            // DeleteSkinBtn
            // 
            resources.ApplyResources(this.DeleteSkinBtn, "DeleteSkinBtn");
            this.DeleteSkinBtn.Name = "DeleteSkinBtn";
            this.DeleteSkinBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.DeleteSkinBtn, resources.GetString("DeleteSkinBtn.ToolTip"));
            this.DeleteSkinBtn.UseSelectable = true;
            this.DeleteSkinBtn.Click += new System.EventHandler(this.DeleteSkinBtnClicked);
            // 
            // LoopSkins
            // 
            resources.ApplyResources(this.LoopSkins, "LoopSkins");
            this.LoopSkins.Name = "LoopSkins";
            this.LoopSkins.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.LoopSkins, resources.GetString("LoopSkins.ToolTip"));
            this.LoopSkins.UseSelectable = true;
            this.LoopSkins.CheckedChanged += new System.EventHandler(this.LoopSkinsToggled);
            // 
            // SkinList
            // 
            this.SkinList.DisplayMember = "1";
            this.SkinList.FormattingEnabled = true;
            resources.ApplyResources(this.SkinList, "SkinList");
            this.SkinList.Name = "SkinList";
            this.SkinList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.SkinList, resources.GetString("SkinList.ToolTip"));
            this.SkinList.UseSelectable = true;
            this.SkinList.ValueMember = "1";
            this.SkinList.SelectedIndexChanged += new System.EventHandler(this.SkinListChanged);
            // 
            // AddSkinBtn
            // 
            resources.ApplyResources(this.AddSkinBtn, "AddSkinBtn");
            this.AddSkinBtn.Name = "AddSkinBtn";
            this.AddSkinBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.AddSkinBtn, resources.GetString("AddSkinBtn.ToolTip"));
            this.AddSkinBtn.UseSelectable = true;
            this.AddSkinBtn.Click += new System.EventHandler(this.AddSkinBtnClicked);
            // 
            // CapeList
            // 
            this.CapeList.DisplayMember = "1";
            this.CapeList.FormattingEnabled = true;
            resources.ApplyResources(this.CapeList, "CapeList");
            this.CapeList.Name = "CapeList";
            this.CapeList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.CapeList, resources.GetString("CapeList.ToolTip"));
            this.CapeList.UseSelectable = true;
            this.CapeList.ValueMember = "1";
            this.CapeList.SelectedIndexChanged += new System.EventHandler(this.CapeListChanged);
            // 
            // MaximumPlrCountLbl
            // 
            resources.ApplyResources(this.MaximumPlrCountLbl, "MaximumPlrCountLbl");
            this.MaximumPlrCountLbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.MaximumPlrCountLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MaximumPlrCountLbl.Name = "MaximumPlrCountLbl";
            this.MaximumPlrCountLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.MaximumPlrCountLbl, resources.GetString("MaximumPlrCountLbl.ToolTip"));
            // 
            // SetVulnerableTile
            // 
            this.SetVulnerableTile.ActiveControl = null;
            resources.ApplyResources(this.SetVulnerableTile, "SetVulnerableTile");
            this.SetVulnerableTile.Name = "SetVulnerableTile";
            this.SetVulnerableTile.PaintTileCount = false;
            this.SetVulnerableTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SetVulnerableTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ToolTipManager.SetToolTip(this.SetVulnerableTile, resources.GetString("SetVulnerableTile.ToolTip"));
            this.SetVulnerableTile.UseSelectable = true;
            this.SetVulnerableTile.Click += new System.EventHandler(this.VulnerabilityTileClicked);
            // 
            // SetInvulnerableTile
            // 
            this.SetInvulnerableTile.ActiveControl = null;
            resources.ApplyResources(this.SetInvulnerableTile, "SetInvulnerableTile");
            this.SetInvulnerableTile.Name = "SetInvulnerableTile";
            this.SetInvulnerableTile.PaintTileCount = false;
            this.SetInvulnerableTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SetInvulnerableTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ToolTipManager.SetToolTip(this.SetInvulnerableTile, resources.GetString("SetInvulnerableTile.ToolTip"));
            this.SetInvulnerableTile.UseSelectable = true;
            this.SetInvulnerableTile.Click += new System.EventHandler(this.PositionTilesClicked);
            // 
            // LockPositionTile
            // 
            this.LockPositionTile.ActiveControl = null;
            resources.ApplyResources(this.LockPositionTile, "LockPositionTile");
            this.LockPositionTile.Name = "LockPositionTile";
            this.LockPositionTile.PaintTileCount = false;
            this.LockPositionTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LockPositionTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ToolTipManager.SetToolTip(this.LockPositionTile, resources.GetString("LockPositionTile.ToolTip"));
            this.LockPositionTile.UseSelectable = true;
            this.LockPositionTile.Click += new System.EventHandler(this.PositionTilesClicked);
            // 
            // UnlockPositionTile
            // 
            this.UnlockPositionTile.ActiveControl = null;
            resources.ApplyResources(this.UnlockPositionTile, "UnlockPositionTile");
            this.UnlockPositionTile.Name = "UnlockPositionTile";
            this.UnlockPositionTile.PaintTileCount = false;
            this.UnlockPositionTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UnlockPositionTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ToolTipManager.SetToolTip(this.UnlockPositionTile, resources.GetString("UnlockPositionTile.ToolTip"));
            this.UnlockPositionTile.UseSelectable = true;
            this.UnlockPositionTile.Click += new System.EventHandler(this.PositionTilesClicked);
            // 
            // LoopCapes
            // 
            resources.ApplyResources(this.LoopCapes, "LoopCapes");
            this.LoopCapes.Name = "LoopCapes";
            this.LoopCapes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.LoopCapes, resources.GetString("LoopCapes.ToolTip"));
            this.LoopCapes.UseSelectable = true;
            this.LoopCapes.CheckedChanged += new System.EventHandler(this.LoopCavesToggled);
            // 
            // CloseContainerTile
            // 
            this.CloseContainerTile.ActiveControl = null;
            resources.ApplyResources(this.CloseContainerTile, "CloseContainerTile");
            this.CloseContainerTile.Name = "CloseContainerTile";
            this.CloseContainerTile.PaintTileCount = false;
            this.CloseContainerTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CloseContainerTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ToolTipManager.SetToolTip(this.CloseContainerTile, resources.GetString("CloseContainerTile.ToolTip"));
            this.CloseContainerTile.UseSelectable = true;
            this.CloseContainerTile.Click += new System.EventHandler(this.CloseContainerTileClicked);
            // 
            // MaxPlayerBar
            // 
            this.MaxPlayerBar.BackColor = System.Drawing.Color.Transparent;
            this.MaxPlayerBar.LargeChange = 1;
            resources.ApplyResources(this.MaxPlayerBar, "MaxPlayerBar");
            this.MaxPlayerBar.Maximum = 8;
            this.MaxPlayerBar.MouseWheelBarPartitions = 1;
            this.MaxPlayerBar.Name = "MaxPlayerBar";
            this.MaxPlayerBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolTipManager.SetToolTip(this.MaxPlayerBar, resources.GetString("MaxPlayerBar.ToolTip"));
            this.TrackbarToolTips.SetToolTip(this.MaxPlayerBar, resources.GetString("MaxPlayerBar.ToolTip1"));
            this.MaxPlayerBar.Value = 8;
            this.MaxPlayerBar.ValueChanged += new System.EventHandler(this.MaxPlayerBarChanged);
            // 
            // DisconnectSessionTile
            // 
            this.DisconnectSessionTile.ActiveControl = null;
            resources.ApplyResources(this.DisconnectSessionTile, "DisconnectSessionTile");
            this.DisconnectSessionTile.Name = "DisconnectSessionTile";
            this.DisconnectSessionTile.PaintTileCount = false;
            this.ToolTipManager.SetToolTip(this.DisconnectSessionTile, resources.GetString("DisconnectSessionTile.ToolTip"));
            this.DisconnectSessionTile.UseSelectable = true;
            this.DisconnectSessionTile.Click += new System.EventHandler(this.DisconnectSessionTileClicked);
            // 
            // RemoveFromGameBtn
            // 
            this.RemoveFromGameBtn.ActiveControl = null;
            resources.ApplyResources(this.RemoveFromGameBtn, "RemoveFromGameBtn");
            this.RemoveFromGameBtn.Name = "RemoveFromGameBtn";
            this.RemoveFromGameBtn.PaintTileCount = false;
            this.RemoveFromGameBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RemoveFromGameBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ToolTipManager.SetToolTip(this.RemoveFromGameBtn, resources.GetString("RemoveFromGameBtn.ToolTip"));
            this.RemoveFromGameBtn.UseSelectable = true;
            this.RemoveFromGameBtn.Click += new System.EventHandler(this.RemoveFromGameBtn_Clicked);
            // 
            // PlayerListPnl
            // 
            this.PlayerListPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerListPnl.Controls.Add(this.PlayerListFlowPnl);
            this.PlayerListPnl.HorizontalScrollbarBarColor = true;
            this.PlayerListPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.PlayerListPnl.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PlayerListPnl, "PlayerListPnl");
            this.PlayerListPnl.Name = "PlayerListPnl";
            this.PlayerListPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PlayerListPnl.VerticalScrollbarBarColor = true;
            this.PlayerListPnl.VerticalScrollbarHighlightOnWheel = false;
            this.PlayerListPnl.VerticalScrollbarSize = 10;
            // 
            // PlayerListFlowPnl
            // 
            resources.ApplyResources(this.PlayerListFlowPnl, "PlayerListFlowPnl");
            this.PlayerListFlowPnl.BackColor = System.Drawing.Color.Transparent;
            this.PlayerListFlowPnl.Name = "PlayerListFlowPnl";
            // 
            // PlayersLbl
            // 
            resources.ApplyResources(this.PlayersLbl, "PlayersLbl");
            this.PlayersLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PlayersLbl.Name = "PlayersLbl";
            this.PlayersLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PlayersTabControl
            // 
            this.PlayersTabControl.Controls.Add(this.PlayerListTab);
            this.PlayersTabControl.Controls.Add(this.SelectedPlayerTab);
            this.PlayersTabControl.HotTrack = true;
            resources.ApplyResources(this.PlayersTabControl, "PlayersTabControl");
            this.PlayersTabControl.Name = "PlayersTabControl";
            this.PlayersTabControl.SelectedIndex = 0;
            this.PlayersTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.PlayersTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PlayersTabControl.UseSelectable = true;
            // 
            // PlayerListTab
            // 
            this.PlayerListTab.Controls.Add(this.PlayersLbl);
            this.PlayerListTab.Controls.Add(this.PlayerListPnl);
            this.PlayerListTab.HorizontalScrollbarBarColor = true;
            this.PlayerListTab.HorizontalScrollbarHighlightOnWheel = false;
            this.PlayerListTab.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PlayerListTab, "PlayerListTab");
            this.PlayerListTab.Name = "PlayerListTab";
            this.PlayerListTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PlayerListTab.VerticalScrollbarBarColor = true;
            this.PlayerListTab.VerticalScrollbarHighlightOnWheel = false;
            this.PlayerListTab.VerticalScrollbarSize = 10;
            // 
            // SelectedPlayerTab
            // 
            this.SelectedPlayerTab.Controls.Add(this.OptionsForLbl);
            this.SelectedPlayerTab.Controls.Add(this.PlrOptionsPnl);
            this.SelectedPlayerTab.HorizontalScrollbarBarColor = true;
            this.SelectedPlayerTab.HorizontalScrollbarHighlightOnWheel = false;
            this.SelectedPlayerTab.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.SelectedPlayerTab, "SelectedPlayerTab");
            this.SelectedPlayerTab.Name = "SelectedPlayerTab";
            this.SelectedPlayerTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SelectedPlayerTab.VerticalScrollbarBarColor = true;
            this.SelectedPlayerTab.VerticalScrollbarHighlightOnWheel = false;
            this.SelectedPlayerTab.VerticalScrollbarSize = 10;
            // 
            // OptionsForLbl
            // 
            resources.ApplyResources(this.OptionsForLbl, "OptionsForLbl");
            this.OptionsForLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.OptionsForLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.OptionsForLbl.Name = "OptionsForLbl";
            this.OptionsForLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PlrOptionsPnl
            // 
            this.PlrOptionsPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlrOptionsPnl.Controls.Add(this.WarningLbl);
            this.PlrOptionsPnl.Controls.Add(this.CloseContainerTile);
            this.PlrOptionsPnl.Controls.Add(this.LoopCapes);
            this.PlrOptionsPnl.Controls.Add(this.metroPanel1);
            this.PlrOptionsPnl.Controls.Add(this.LockPositionTile);
            this.PlrOptionsPnl.Controls.Add(this.UnlockPositionTile);
            this.PlrOptionsPnl.Controls.Add(this.SetInvulnerableTile);
            this.PlrOptionsPnl.Controls.Add(this.SetVulnerableTile);
            this.PlrOptionsPnl.Controls.Add(this.metroLabel2);
            this.PlrOptionsPnl.Controls.Add(this.ReturnToListBtn);
            this.PlrOptionsPnl.Controls.Add(this.XpLevelSlider);
            this.PlrOptionsPnl.Controls.Add(this.DeleteSkinBtn);
            this.PlrOptionsPnl.Controls.Add(this.LoopSkins);
            this.PlrOptionsPnl.Controls.Add(this.RemoveCapeBtn);
            this.PlrOptionsPnl.Controls.Add(this.xpLbl);
            this.PlrOptionsPnl.Controls.Add(this.AddCapeBtn);
            this.PlrOptionsPnl.Controls.Add(this.AddSkinBtn);
            this.PlrOptionsPnl.Controls.Add(this.GamemodeLbl);
            this.PlrOptionsPnl.Controls.Add(this.PlayerGamemodeBox);
            this.PlrOptionsPnl.Controls.Add(this.SkinList);
            this.PlrOptionsPnl.Controls.Add(this.CapeList);
            this.PlrOptionsPnl.Controls.Add(this.CapeLbl);
            this.PlrOptionsPnl.Controls.Add(this.SkinLbl);
            this.PlrOptionsPnl.Controls.Add(this.RemoveFromGameBtn);
            this.PlrOptionsPnl.HorizontalScrollbarBarColor = true;
            this.PlrOptionsPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.PlrOptionsPnl.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PlrOptionsPnl, "PlrOptionsPnl");
            this.PlrOptionsPnl.Name = "PlrOptionsPnl";
            this.PlrOptionsPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PlrOptionsPnl.VerticalScrollbarBarColor = true;
            this.PlrOptionsPnl.VerticalScrollbarHighlightOnWheel = false;
            this.PlrOptionsPnl.VerticalScrollbarSize = 10;
            // 
            // WarningLbl
            // 
            resources.ApplyResources(this.WarningLbl, "WarningLbl");
            this.WarningLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.WarningLbl.Name = "WarningLbl";
            this.WarningLbl.Style = MetroFramework.MetroColorStyle.Red;
            this.WarningLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WarningLbl.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // xpLbl
            // 
            resources.ApplyResources(this.xpLbl, "xpLbl");
            this.xpLbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.xpLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.xpLbl.Name = "xpLbl";
            this.xpLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GamemodeLbl
            // 
            resources.ApplyResources(this.GamemodeLbl, "GamemodeLbl");
            this.GamemodeLbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.GamemodeLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.GamemodeLbl.Name = "GamemodeLbl";
            this.GamemodeLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CapeLbl
            // 
            resources.ApplyResources(this.CapeLbl, "CapeLbl");
            this.CapeLbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.CapeLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.CapeLbl.Name = "CapeLbl";
            this.CapeLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SkinLbl
            // 
            resources.ApplyResources(this.SkinLbl, "SkinLbl");
            this.SkinLbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.SkinLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SkinLbl.Name = "SkinLbl";
            this.SkinLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CurrentSessionLbl
            // 
            resources.ApplyResources(this.CurrentSessionLbl, "CurrentSessionLbl");
            this.CurrentSessionLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CurrentSessionLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CurrentSessionLbl.Name = "CurrentSessionLbl";
            this.CurrentSessionLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SessionOptionsPnl
            // 
            this.SessionOptionsPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SessionOptionsPnl.Controls.Add(this.MaxPlayerBar);
            this.SessionOptionsPnl.Controls.Add(this.SessionOptsLbl);
            this.SessionOptionsPnl.Controls.Add(this.MaximumPlrCountLbl);
            this.SessionOptionsPnl.Controls.Add(this.PauseSessionTile);
            this.SessionOptionsPnl.Controls.Add(this.DisconnectSessionTile);
            this.SessionOptionsPnl.HorizontalScrollbarBarColor = true;
            this.SessionOptionsPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.SessionOptionsPnl.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.SessionOptionsPnl, "SessionOptionsPnl");
            this.SessionOptionsPnl.Name = "SessionOptionsPnl";
            this.SessionOptionsPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SessionOptionsPnl.VerticalScrollbarBarColor = true;
            this.SessionOptionsPnl.VerticalScrollbarHighlightOnWheel = false;
            this.SessionOptionsPnl.VerticalScrollbarSize = 10;
            // 
            // SessionOptsLbl
            // 
            resources.ApplyResources(this.SessionOptsLbl, "SessionOptsLbl");
            this.SessionOptsLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.SessionOptsLbl.Name = "SessionOptsLbl";
            this.SessionOptsLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SkinLoopTimer
            // 
            this.SkinLoopTimer.Interval = 500;
            this.SkinLoopTimer.Tick += new System.EventHandler(this.SkinLooper);
            // 
            // TrackbarToolTips
            // 
            this.TrackbarToolTips.AutomaticDelay = 50;
            this.TrackbarToolTips.AutoPopDelay = 10000;
            this.TrackbarToolTips.InitialDelay = 200;
            this.TrackbarToolTips.ReshowDelay = 200;
            this.TrackbarToolTips.Style = MetroFramework.MetroColorStyle.Default;
            this.TrackbarToolTips.StyleManager = null;
            this.TrackbarToolTips.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CapeLoopTimer
            // 
            this.CapeLoopTimer.Interval = 500;
            this.CapeLoopTimer.Tick += new System.EventHandler(this.CapeLooper);
            // 
            // SessionManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CurrentSessionLbl);
            this.Controls.Add(this.RefreshPlayersTile);
            this.Controls.Add(this.SessionOptionsPnl);
            this.Controls.Add(this.PlayersTabControl);
            this.Name = "SessionManager";
            this.Resizable = false;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Deinitialize);
            this.Load += new System.EventHandler(this.Init);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XpLevelSlider)).EndInit();
            this.PlayerListPnl.ResumeLayout(false);
            this.PlayersTabControl.ResumeLayout(false);
            this.PlayerListTab.ResumeLayout(false);
            this.PlayerListTab.PerformLayout();
            this.SelectedPlayerTab.ResumeLayout(false);
            this.SelectedPlayerTab.PerformLayout();
            this.PlrOptionsPnl.ResumeLayout(false);
            this.PlrOptionsPnl.PerformLayout();
            this.SessionOptionsPnl.ResumeLayout(false);
            this.SessionOptionsPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Components.MetroStyleManager StyleManager;
        private MetroFramework.Components.MetroToolTip ToolTipManager;
        private MetroFramework.Controls.MetroPanel PlayerListPnl;
        private MetroFramework.Controls.MetroLabel PlayersLbl;
        private MetroFramework.Controls.MetroTabControl PlayersTabControl;
        private MetroFramework.Controls.MetroTabPage PlayerListTab;
        private MetroFramework.Controls.MetroTabPage SelectedPlayerTab;
        private MetroFramework.Controls.MetroLabel OptionsForLbl;
        private MetroFramework.Controls.MetroPanel PlrOptionsPnl;
        private MetroFramework.Controls.MetroTile ReturnToListBtn;
        private System.Windows.Forms.FlowLayoutPanel PlayerListFlowPnl;
        private MetroFramework.Controls.MetroLabel CurrentSessionLbl;
        private MetroFramework.Controls.MetroPanel SessionOptionsPnl;
        private MetroFramework.Controls.MetroTile RefreshPlayersTile;
        private MetroFramework.Controls.MetroTile PauseSessionTile;
        private MetroFramework.Controls.MetroComboBox PlayerGamemodeBox;
        private MetroFramework.Controls.MetroLabel GamemodeLbl;
        private MetroFramework.Controls.MetroButton RemoveCapeBtn;
        private MetroFramework.Controls.MetroButton AddCapeBtn;
        private MetroFramework.Controls.MetroButton DeleteSkinBtn;
        private MetroFramework.Controls.MetroCheckBox LoopSkins;
        private MetroFramework.Controls.MetroComboBox SkinList;
        private MetroFramework.Controls.MetroLabel SkinLbl;
        private MetroFramework.Controls.MetroButton AddSkinBtn;
        private MetroFramework.Controls.MetroComboBox CapeList;
        private MetroFramework.Controls.MetroLabel CapeLbl;
        private System.Windows.Forms.Timer SkinLoopTimer;
        private System.Windows.Forms.NumericUpDown XpLevelSlider;
        private MetroFramework.Controls.MetroLabel xpLbl;
        private MetroFramework.Controls.MetroLabel MaximumPlrCountLbl;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel SessionOptsLbl;
        private MetroFramework.Controls.MetroTrackBar MaxPlayerBar;
        private MetroFramework.Components.MetroToolTip TrackbarToolTips;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile LockPositionTile;
        private MetroFramework.Controls.MetroTile UnlockPositionTile;
        private MetroFramework.Controls.MetroTile SetInvulnerableTile;
        private MetroFramework.Controls.MetroTile SetVulnerableTile;
        private MetroFramework.Controls.MetroCheckBox LoopCapes;
        private MetroFramework.Controls.MetroTile CloseContainerTile;
        private System.Windows.Forms.Timer CapeLoopTimer;
        private MetroFramework.Controls.MetroLabel WarningLbl;
        private MetroFramework.Controls.MetroTile DisconnectSessionTile;
        private MetroFramework.Controls.MetroTile RemoveFromGameBtn;
    }
}