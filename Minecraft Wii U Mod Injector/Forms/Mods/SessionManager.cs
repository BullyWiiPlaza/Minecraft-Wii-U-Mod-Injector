using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using Minecraft_Wii_U_Mod_Injector.Properties;
using Minecraft_Wii_U_Mod_Injector.Wii_U.Minecraft;

namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods;

// TODO:
// Clean Up the whole skins & cape switcher bullshit, I hate everything about it with a burning passion :3c
// Clear out all controls when switching player indexes
public partial class SessionManager : MetroForm
{
    private readonly MainForm _iw;

    private readonly IniFile _savedData =
        new(Application.StartupPath + @"\Saved\Data\Minecraft.Wii.U.Mod.Injector.Data.ini");

    internal readonly Dictionary<uint, string> _Players = new();
    internal readonly Dictionary<string, uint> _PlayersDataPtrs = new();

    internal Dictionary<string, string> _Skins = new();

    internal Dictionary<string, string> _Capes = new()
    {
        { "Minecon 2011", "2147489052" },
        { "Minecon 2012", "2147489049" },
        { "Minecon 2013", "2147489050" },
        { "Minecon 2015", "2147489051" },
        { "Minecon 2016", "2147489052" },
        { "Jeb Ponytail", "2147486648" },
        { "The Grim Reaper", "2147486849" },
        { "Devil", "2147486850" },
        { "Dracula", "2147486851" },
        { "Evil Wizard", "2147486852" },
        { "Bride of Frankenstein", "2147486853" },
        { "Wicked Witch", "2147486866" },
        { "Senator Padmé Amidala", "2147484953" },
        { "Senator Palpatine", "2147484956" },
        { "Count Dooku", "2147484957" },
        { "General Grievous", "2147484958" },
        { "Erinyes", "2147486490" },
        { "Dryad", "2147486491" },
        { "Spartoi", "2147486487" },
        { "Hephaestus", "2147486494" },
        { "Prometheus", "2147486495" },
        { "Heracles", "2147486471" },
        { "Zeus", "2147486477" },
        { "Hades", "2147486478" },
        { "Poseidon", "2147486480" },
        { "Apollo", "2147486488" },
        { "Artemis", "2147486483" },
        { "Athena", "2147486484" },
        { "Perseus/Trojan Warrior", "2147486475" },
        { "Atlanta", "2147486492" },
        { "Cadmus", "2147486493" },
        { "Drone", "2147485274" }
    };

    private uint _currentPlayerIndex;
    private uint _currentPlayerPtr;
    private uint _playerListPtr;
    private uint _masterGameModePtr;

    public SessionManager(MainForm iw)
    {
        InitializeComponent();

        StyleManager.Style = Style = iw.StyleMngr.Style;
        StyleManager.Theme = Theme = iw.StyleMngr.Theme;

        _iw = iw;

        // Incase we forget to set the index back to 0 in the designer
        PlayersTabControl.SelectedIndex = 0;

        // Set the ItemSize height on the TabControl small enough so it's difficult to hit, ideally we should just be able to disable navigating via them
        PlayersTabControl.ItemSize = PlayersTabControl.ItemSize with { Height = 1 };

        // Populate the player list upon entering the window
        RefreshPlayersTileClicked(null, null);
    }

    private void Init(object sender, EventArgs e)
    {
        DiscordRpc.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected",
            "Session Manager");
    }

    private void Deinitialize(object sender, FormClosingEventArgs e)
    {
        DiscordRpc.SetPresence(_iw.IsConnected ? "Connected" : "Disconnected",
            _iw.MainTabs.SelectedTab.Text + " Tab");

        Dispose();
    }

    protected override CreateParams CreateParams
    {
        get
        {
            var cp = base.CreateParams;
            cp.ExStyle |= 0x02000000;
            return cp;
        }
    }

    private void RefreshPlayersTileClicked(object sender, EventArgs e)
    {
        if(!MainForm.IsPointerLoaded())
        {
            Close();
            return;
        }

        var playerCount = MinecraftFunctions.GetNQRNetworkManager_PlayerCount();

        _playerListPtr = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8FC) + 0x14);

        // Clear out the players dictionary and panels
        _Players.Clear();
        _PlayersDataPtrs.Clear();
        PlayerListFlowPnl.Controls.Clear();

        // Player Count
        PlayersLbl.Text = @"Players " + playerCount + @"/8";

        // List out all players
        SuspendLayout();

        Debug.WriteLine(@"Player List Pointer: 0x" + _playerListPtr.ToString("X8"), "Session Manager");

        for (uint i = 0x0; i < playerCount; i++)
        {
            var nqrPtr = MinecraftFunctions.GetNQRNetworkPlayer_WiiU(i);
            var dataServerPtr = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(_playerListPtr + 0x04) + 8 * i);

            // Don't attempt to display invalid player indexes their names as this crashes the Wii U
            if (nqrPtr == 0x0)
            {
                CreatePlayerPanel(-1, 0x0, "Empty", string.Empty);
                continue;
            }

            var plr_name = MinecraftFunctions.GetPlayerNetworkName(i);

            Debug.WriteLine(@"Server Player Index " + i + @" data pointer: 0x" + dataServerPtr.ToString("X8"), "Session Manager");

            _Players.Add(nqrPtr, plr_name);
            CreatePlayerPanel((int)i, dataServerPtr, _Players[nqrPtr], MinecraftFunctions.GetPlayerMiiName(i));
        }

        ResumeLayout();
    }

    // Removes everyone (including the current player) from the session
    private void DisconnectSessionTileClicked(object sender, EventArgs e)
    {
        if (MinecraftFunctions.IsClientSide())
            return;

        _playerListPtr = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8FC) + 0x14);

        MainForm.GeckoU.CallFunction(0x0328989C, _playerListPtr);
    }

    // I am losing my mind
    private void CreatePlayerPanel(int index, uint data, string name, string mii)
    {
        // Player Panel
        var PlayerPanel = new MetroPanel();

        PlayerPanel.Name = "p" + index + "Panel";
        PlayerPanel.Size = new Size(165, 250);
        PlayerPanel.BorderStyle = (BorderStyle)MetroFormBorderStyle.FixedSingle;
        PlayerPanel.Theme = MetroThemeStyle.Dark;

        // Player Icon
        var PlayerIcon = new PictureBox();

        PlayerIcon.Name = "p" + index + "Icon";
        PlayerIcon.Location = new Point(64, 3);
        PlayerIcon.SizeMode = PictureBoxSizeMode.AutoSize;
        PlayerIcon.Tag = index + "&" + data;
        PlayerIcon.Cursor = Cursors.Hand;

        if (index != -1)
            ToolTipManager.SetToolTip(PlayerIcon, "Open the Options Menu for Player " + index);

        switch (index)
        {
            case 0:
                PlayerIcon.Image = Resources.p0;
                break;

            case 1:
                PlayerIcon.Image = Resources.p1;
                break;

            case 2:
                PlayerIcon.Image = Resources.p2;
                break;

            case 3:
                PlayerIcon.Image = Resources.p3;
                break;

            case 4:
                PlayerIcon.Image = Resources.p4;
                break;

            case 5:
                PlayerIcon.Image = Resources.p5;
                break;

            case 6:
                PlayerIcon.Image = Resources.p6;
                break;

            case 7:
                PlayerIcon.Image = Resources.p7;
                break;

            case -1:
                PlayerIcon.Image = Resources.pInvalid;
                break;
        }

        PlayerIcon.Click += PlayerIcon_Clicked;

        // Player Name
        var PlayerName = new MetroLabel();

        PlayerName.Text = name;
        PlayerName.Size = new Size(122, PlayerName.Height);
        PlayerName.Location = new Point((PlayerPanel.Width - PlayerName.Width) / 2, 55);
        PlayerName.Dock = DockStyle.None;
        PlayerName.TextAlign = ContentAlignment.MiddleCenter;
        PlayerName.Theme = MetroThemeStyle.Dark;

        // Mii Name
        var MiiName = new MetroLabel();

        MiiName.Text = mii;
        MiiName.Size = new Size(122, MiiName.Height);
        MiiName.Location = new Point((PlayerPanel.Width - MiiName.Width) / 2, 74);
        MiiName.Dock = DockStyle.None;
        MiiName.TextAlign = ContentAlignment.MiddleCenter;
        MiiName.Theme = MetroThemeStyle.Dark;

        // Finally, add all controls
        PlayerPanel.Controls.Add(PlayerIcon);
        PlayerPanel.Controls.Add(PlayerName);
        PlayerPanel.Controls.Add(MiiName);

        PlayerListFlowPnl.Controls.Add(PlayerPanel);
    }

    private void PlayerIcon_Clicked(object sender, EventArgs e)
    {
        var selectedPlayerIcon = (PictureBox)sender;

        if (selectedPlayerIcon.Tag.ToString().Contains("-1"))
            return;

        var playerData = selectedPlayerIcon.Tag.ToString().Split('&');

        RefreshPlayersTile.Hide();

        _currentPlayerIndex = Convert.ToUInt32(playerData[0]);
        _currentPlayerPtr = Convert.ToUInt32(playerData[1]);

        PlayersTabControl.SelectedIndex = 1;

        OptionsForLbl.Text = @"OPTIONS FOR " + _Players.ElementAt((int)_currentPlayerIndex).Value.ToUpper();

        //TODO: Skip this next section is the selected player isn't local

        // Skin and Cape bullshit.. :(
        if (_Skins.Count <= 0)
            foreach (var key in _savedData.GetKeys("Skins").Where(key => !_Skins.ContainsKey(key)))
                _Skins.Add(key, _savedData.Read(key, "Skins"));

        foreach (var key in _savedData.GetKeys("Capes").Where(key => !_Capes.ContainsKey(key)))
            _Capes.Add(key, _savedData.Read(key, "Capes"));

        RefreshList(SkinList, _Skins);
        RefreshList(CapeList, _Capes);
    }

    private void RemoveFromGameBtn_Clicked(object sender, EventArgs e)
    {
        if (MinecraftFunctions.IsClientSide())
            return;

        MainForm.GeckoU.WriteBytes(0x107A097C, new byte[0x100]);
        MainForm.GeckoU.WriteString(0x107A097C,
            OptionsForLbl.Text.Replace("Options for", string.Empty) + " has been kicked.", Encoding.BigEndianUnicode,
            true);

        MainForm.GeckoU.WriteBytes(0x12000000, new byte[0x1000]);
        MainForm.GeckoU.CallFunction64(0x02A000A4, 0x12000000);
        MainForm.GeckoU.CallFunction64(0x0304A5D8, MainForm.GeckoU.PeekUInt(MainForm.GetSelfPlayerPointer() + 0x878),
            0x12000000);

        MinecraftFunctions.NQRNetworkManager_RemoveConnectedPlayer(_currentPlayerIndex);
    }

    private void ReturnToListBtn_Clicked(object sender, EventArgs e)
    {
        RefreshPlayersTile.Show();
        PlayersTabControl.SelectedIndex = 0;
    }

    private void PauseSessionTile_Clicked(object sender, EventArgs e)
    {
        if (MinecraftFunctions.IsClientSide())
            return;

        var paused = MinecraftFunctions.IsServerPaused();

        MinecraftFunctions.FjSetServerPaused(!paused);
    }

    #region skin & cape bullshit

    private void AddSkinBtnClicked(object sender, EventArgs e)
    {
        var skinName = MinecraftFunctions.GetPlayerSkinName(_currentPlayerIndex);
        var skinId = MainForm.GeckoU.CallFunction(0x02F70178, _currentPlayerIndex).ToString();

        if (_Skins.ContainsKey(skinName))
            return;

        _Skins.Add(skinName, skinId);
        _savedData.Write(skinName, skinId, "Skins");
        RefreshList(SkinList, _Skins);
    }

    private void DeleteSkinBtnClicked(object sender, EventArgs e)
    {
        _Skins.Remove(SkinList.Text);
        _savedData.DeleteKey(SkinList.Text, "Skins");

        RefreshList(SkinList, _Skins);
    }

    private void SkinListChanged(object sender, EventArgs e)
    {
        // Prevent the event from running when the ComboBox isn't clicked, this is to prevent it from changing when populating
        var cb = (MetroComboBox)sender;
        if (!cb.Focused && !LoopSkins.Checked) return;

        MainForm.GeckoU.CallFunction(0x02F70028, _currentPlayerIndex, uint.Parse(_Skins[SkinList.Text]), 0);
    }

    private void LoopSkinsToggled(object sender, EventArgs e)
    {
        SkinLoopTimer.Enabled = LoopSkins.Checked;
    }

    private void LoopCavesToggled(object sender, EventArgs e)
    {
        CapeLoopTimer.Enabled = LoopCapes.Checked;
    }

    private void SkinLooper(object sender, EventArgs e)
    {
        SkinList.Select();
        SkinList.SelectedIndex = new Random().Next(0, SkinList.Items.Count);
    }

    private void CapeLooper(object sender, EventArgs e)
    {
        CapeList.Select();
        CapeList.SelectedIndex = new Random().Next(0, CapeList.Items.Count);
    }

    private void AddCapeBtnClicked(object sender, EventArgs e)
    {
        var capeName = MinecraftFunctions.GetPlayerCapeName(_currentPlayerIndex);
        var capeId = MainForm.GeckoU.CallFunction(0x02F6FFC4, _currentPlayerIndex).ToString();

        if (_Skins.ContainsKey(capeName)) return;

        _Capes.Add(capeName, capeId);
        _savedData.Write(capeName, capeId, "Capes");
        RefreshList(CapeList, _Capes);
    }

    private void DeleteCapeBtnClicked(object sender, EventArgs e)
    {
        _Capes.Remove(CapeList.Text);
        _savedData.DeleteKey(CapeList.Text, "Capes");

        RefreshList(CapeList, _Capes);
    }

    private void CapeListChanged(object sender, EventArgs e)
    {
        // Prevent the event from running when the ComboBox isn't clicked, this is to prevent it from changing when populating
        var cb = (MetroComboBox)sender;
        if (!cb.Focused) return;

        MainForm.GeckoU.CallFunction(0x02F6FC2C, _currentPlayerIndex, uint.Parse(_Capes[CapeList.Text]), 0);
    }

    private void RefreshList(MetroComboBox cb, Dictionary<string, string> dic)
    {
        cb.DataSource = null;
        cb.DataSource = new BindingSource(dic, null);
        cb.DisplayMember = "Key";
        cb.Update();
    }

    #endregion skin & cape bullshit

    private void PlayerGamemodeBoxChanged(object sender, EventArgs e)
    {
        // TODO: Check if the player is local, if not then use the ServerPlayer function for this
        // LocalPlayer::SetGameType(GameType const *): 0x031F40A0
        // ServerPlayer::setGameMode(GameType const *): 0x032D7F3C

        var gametype = MainForm.GeckoU.PeekUInt(0x109C4D24 + (uint)PlayerGamemodeBox.SelectedIndex * 4);
        MainForm.GeckoU.CallFunction(0x032D7F3C, _currentPlayerPtr, gametype);
    }

    private void XpLevelSliderChanged(object sender, EventArgs e)
    {
        var level = (uint)XpLevelSlider.Value;

        MainForm.GeckoU.CallFunction(0x031EA12C, _currentPlayerPtr, level, level, level);
    }

    private void MaxPlayerBarChanged(object sender, EventArgs e)
    {
        TrackbarToolTips.SetToolTip(MaxPlayerBar,
            MaxPlayerBar.Value.ToString()); // TODO: Make this smoother, currently it flashes when changing :(
        MainForm.GeckoU.WriteUInt(0x02D5B30C, MainForm.GeckoU.Mix(MainForm.Off, MaxPlayerBar.Value));
    }

    private void PositionTilesClicked(object sender, EventArgs e)
    {
        var posTile = (MetroTile)sender;

        _masterGameModePtr = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8FC) + 0x14C);

        MainForm.GeckoU.CallFunction(0x02C9CB40, _masterGameModePtr, _currentPlayerPtr,
            posTile == UnlockPositionTile ? 0x0 : (uint)0x1);
    }

    private void VulnerabilityTileClicked(object sender, EventArgs e)
    {
        var vulTile = (MetroTile)sender;

        _masterGameModePtr = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8FC) + 0x14C);

        MainForm.GeckoU.CallFunction(0x02C8DDDC, _masterGameModePtr, _currentPlayerPtr,
            vulTile == UnlockPositionTile ? 0x0 : (uint)0x1);
    }

    private void CloseContainerTileClicked(object sender, EventArgs e)
    {
        MainForm.GeckoU.CallFunction64(0x032D0800, _currentPlayerPtr); //25A7C8F8
    }
}