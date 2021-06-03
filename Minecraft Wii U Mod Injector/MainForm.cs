using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using Minecraft_Wii_U_Mod_Injector.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using Minecraft_Wii_U_Mod_Injector.Helpers.Winforms;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using WiiU.GeckoU;

namespace Minecraft_Wii_U_Mod_Injector
{
    public partial class MainForm : MetroForm
    {
        #region base variables

        #region references

        public static GeckoUCore GeckoU;
        public static GeckoUConnect GeckoUConnection;

        #endregion
        
        #region bools
        private bool _isConnected;
        public bool IsConnected
        {
            get => _isConnected;
            set
            {
                _isConnected = value;
                DiscordRP.SetPresence(_isConnected ? "Connected" : "Disconnected", MainTabs.SelectedTab.Text + " tab");
            }
        }

        private bool tooHighWarn;
        #endregion

        #region assembly

        public uint on = 0x38600001;
        public uint off = 0x38600000;
        public uint on2 = 0x3BE00001;
        public uint off2 = 0x3BE00000;
        public uint blr = 0x4E800020;
        public uint mflr = 0x7C0802A6;
        public uint nop = 0x60000000;

        #endregion

        #region commands
        public static uint[] enchantments = {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            16,
            17,
            18,
            19,
            20,
            21,
            32,
            33,
            34,
            35,
            48,
            49,
            50,
            51,
            61,
            62,
            70,
            71,
            80,
            81,
            82,
            83
        };
        #endregion

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void Init(object sender, EventArgs e)
        {
            new States(this);
            new Messaging(this);
            new Setup(this);

            Setup.SetupInjector();

            ValidateEnteredIPAddress();
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            DiscordRP.Deinitialize();
            Settings.Write("TabIndex", MainTabs.SelectedIndex.ToString(), "Display");
        }
        
        private void SwapTab(object sender, EventArgs e)
        {
            var tile = (MetroTile)sender;

            if (MainTabs.SelectedIndex != tile.TileCount)
                MainTabs.SelectedIndex = tile.TileCount;
            else
                return;

            DiscordRP.SetPresence(IsConnected ? "Connected" : "Disconnected", MainTabs.SelectedTab.Text + " tab");
        }

        private void connectBtnClicked(object sender, EventArgs e)
        {
            try
            {
                GeckoU ??= new GeckoUCore(wiiuIpv4Box.Text);

                switch (States.currentState)
                {
                    case States.StatesIds.Disconnected:
                        States.SwapState(States.StatesIds.Connecting);
                        GeckoU.GUC.Connect();
                        States.SwapState(States.StatesIds.Connected);
                        IsConnected = true;
                        break;

                    case States.StatesIds.Connected:
                        GeckoU.GUC.Close();
                        IsConnected = false;
                        States.SwapState(States.StatesIds.Disconnected);
                        break;
                }
            }
            catch (Exception error)
            {
                switch (error)
                {
                    case System.Net.Sockets.SocketException:
                        Messaging.Show(MessageBoxIcon.Error, "Couldn't detect TCPGecko running or IP Address is wrong.\nMake sure you have TCPGecko running and entered the correct IP Address for you Wii U");
                        Exceptions.LogError(error, "Wrong IP Address", false, false);
                        States.SwapState(States.StatesIds.Disconnected);
                        break;

                    case TimeoutException:
                        Messaging.Show(MessageBoxIcon.Error, "Couldn't connect to your Wii U, please check that:\nYou entered the correct IP Address\nTCPGecko is running from the Homebrew Launcher\nYour network connection might not be stable");
                        Exceptions.LogError(error, "Unable to Connect to the Wii U, connection timed-out", false, false);
                        States.SwapState(States.StatesIds.Disconnected);
                        break;
                }

                Exceptions.LogError(error, "Unable to Connect to the Wii U", false, true);
                States.SwapState(States.StatesIds.Disconnected);
            }
        }

        private void capturewiiuIpv4Box(object sender, EventArgs e)
        {
            ValidateEnteredIPAddress();
        }

        private void ValidateEnteredIPAddress()
        {
            switch (StringUtils.ValidateIPv4(wiiuIpv4Box.Text))
            {
                case true:
                    wiiuIpv4Box.Style = MetroColorStyle.Green;
                    connectBtn.Enabled = true;
                    break;
                case false:
                    wiiuIpv4Box.Style = MetroColorStyle.Red;
                    connectBtn.Enabled = false;
                    break;
            }
        }

        private void formThemeSelected(object sender, EventArgs e)
        {
            try
            {
                Theme = (MetroThemeStyle)Enum.Parse(typeof(MetroThemeStyle), themeBox.Text);
                StyleMngr.Theme = (MetroThemeStyle)Enum.Parse(typeof(MetroThemeStyle), themeBox.Text);
                Refresh();
                Settings.Write("Theme", themeBox.Text, "Display");
            }
            catch (Exception Error)
            {
                Exceptions.LogError(Error, "Failed to Change Injector Form Theme", false, true);
            }
        }

        private void formColorSelected(object sender, EventArgs e)
        {
            try
            {
                Style = (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), colorsBox.Text);
                StyleMngr.Style = (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), colorsBox.Text);
                Refresh();
                Settings.Write("Color", colorsBox.Text, "Display");
            }
            catch (Exception Error)
            {
                Exceptions.LogError(Error, "Failed to Change Injector Form Color", false, true);
            }
        }
        
        private void DiscordRpcToggleChecked(object sender, EventArgs e)
        {
            try
            {
                if (discordRpcCheckBox.Checked)
                {
                    Settings.Write("DiscordRPC", "true", "Discord");
                    DiscordRP.Initialize();
                    DiscordRP.SetPresence(IsConnected ? "Connected" : "Disconnected", "Idle");
                }
                else
                {
                    Settings.Write("DiscordRPC", "false", "Discord");
                    DiscordRP.Deinitialize();
                }
            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Failed to Toggle Discord RPC", false, true);
            }
        }
        
        private void ResetConfigClicked(object sender, EventArgs e)
        {
            try
            {
                if (Messaging.Show("Resetting the configuration file will reset all your preferences, continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (System.IO.File.Exists(Application.StartupPath + "/Minecraft Wii U Mod Injector.ini"))
                        System.IO.File.Delete(Application.StartupPath + "/Minecraft Wii U Mod Injector.ini");
                    else
                    {
                        Messaging.Show("Configuration File doesn't exist, nothing to reset.");
                        return;
                    }
                }
                else
                    return;
            }
            catch (Exception Error)
            {
                Exceptions.LogError(Error, "Failed to Reset Config", false, true);
            }
        }

        private void ReleaseNotesToggleClicked(object sender, EventArgs e)
        {
            try
            {
                if (releaseNotesToggle.Checked)
                {
                    buildNotesBox.Text = Properties.Resources.releaseNote;
                    Settings.Write("ReleaseNotes", "current", "Display");
                }
                else
                {
                    buildNotesBox.Text = Properties.Resources.releaseNotes;
                    Settings.Write("ReleaseNotes", "all", "Display");
                }

            }
            catch (Exception Error)
            {
                Exceptions.LogError(Error, "Failed to Toggle Release Notes", false, true);
            }
        }

        private void githubLogoClicked(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Kashiiera/Minecraft-Wii-U-Mod-Injector");
        }

        private void openFaqInfoClicked(object sender, EventArgs e)
        {
            new FAQ(this).ShowDialog();
        }

        private void discordSrvBtnClicked(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/jrzZWaDc7a");
        }

        private void creditsBtnClicked(object sender, EventArgs e)
        {
            new Credits(this).ShowDialog();
        }

        private void MapTextEditorClicked(object sender, EventArgs e)
        {
            new MapTextEditor(this).ShowDialog();
        }

        private void NNIDEditorBtnClicked(object sender, EventArgs e)
        {
            new NNIDEditor(this).ShowDialog();
        }

        private void itemIdHelpBtnClicked(object sender, EventArgs e)
        {
            Messaging.Show(MessageBoxIcon.Information, "Item IDs can be found at https://minecraft-ids.grahamedgecombe.com/ \nData Values are the numbers behind the : in the ID.\nFor example, if you want Birch Wood the ID would be 17 and the data value would be 2");
        }
        public static bool IsPointerLoaded()
        {
            return GeckoU.PeekUInt(GeckoU.PeekUInt(0x10A0A624) + 0x9C) != 0x0;
        }

        #region memory editing

        private void InsaneCriticalHitsToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x106D0D4C, 0x43F00000, 0x3FC00000, InsaneCriticalHits.Checked);
        }

        private void AlwaysSwimmingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteULongToggle(0x023405EC, 0x386000014E800020, 0x3D800233398C69B8, AlwaysSwimming.Checked); //Entity::isSwimming((void))
        }

        private void InfiniteRiptideToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0232C210, on, off, InfiniteRiptide.Checked); //Entity::isInWaterOrRain((void))
        }

        private void FullRotationToggled(object sender, EventArgs e)
        {
            GeckoU.WriteULongToggle(0x105DDAF8, 0xC3B4000043B40000, 0xC2B4000042B40000, FullRotation.Checked);
        }

        private void AlwaysDamagedPlayersToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x027206CC, on, 0x57E3063E, AlwaysDamagedPlayers.Checked); //Player::isInWall((void))
        }

        private void InfiniteItemsToggled(object sender, EventArgs e)
        {
            GeckoU.WriteLongToggle(0x024872AC, 0x600000004E800020, 0x3D800248398C7294, InfiniteItems.Checked); //ItemInstance::shrink((int))
        }

        private void RapidBowToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02162F04, 0x3BE00001, 0x3BE00014, RapidBow.Checked); //GetMaxBowDuration__7BowItemSFv
        }

        private void BloodVisionToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0257E000, off, 0x57E3063E, BloodVision.Checked); //LivingEntity::isAlive((void))
        }

        private void IgnorePotionsToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0258E4BC, off, on, IgnorePotions.Checked); //LivingEntity::isAffectedByPotions((void))
        }

        private void ForeverLastingPotionsToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02576994, blr, 0x9421FF40, ForeverLastingPotions.Checked); //LivingEntity::tickEffects((void))
        }

        private void BypassInvulnerabilityToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0225458C, on, 0x88630009, BypassInvulnerability.Checked); //DamageSource::isBypassInvul(const(void))
        }

        private void PlaceBlocksonHeadToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0207F604, on, 0x7FC3F378, PlaceBlocksonHead.Checked); //ArmorSlot::mayPlace((not_null_ptr__tm__15_12ItemInstance))
        }

        private void WalkonWaterToggled(object sender, EventArgs e)
        {
            GeckoU.WriteULongToggle(0x025A963C, 0x3C60109E80639948, 0x3C6010568063B61C, WalkonWater.Checked); //LiquidBlock::getClipAABB((BlockState const *, LevelSource *, BlockPos const &))
        }

        private void AlwaysElytraToggled(object sender, EventArgs e)
        {
            GeckoU.WriteULongToggle(0x0258DACC, 0x386000014E800020, 0x3D800233398C69B8, AlwaysElytra.Checked); //LivingEntity::isFallFlying((void))
        }

        private void CaveFinderToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x030E4924, 0x38800000, 0x38800001, CaveFinder.Checked); //enableState__14GlStateManagerSFi
        }

        private void WallhackToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x031B2B4C, on, 0x5403063E, Wallhack.Checked); //renderDebug__9MinecraftSFv
        }

        private void LargeXPDropsToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0239A26C, nop, 0x4180000C, LargeXPDrops.Checked); //getExperienceValue__13ExperienceOrbSFi:
            GeckoU.WriteUIntToggle(0x0239A270, 0x38607FFF, 0x386009AD, LargeXPDrops.Checked);
        }

        private void WallClimbingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0257DF90, on, 0x57E3063E, WallClimbing.Checked); //LivingEntity::onLadder((void))
        }

        private void NoCollisionToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x020E7BF4, blr, 0x9421FFE0, NoCollision.Checked); //Block::addCollisionAABBs((BlockState const *, Level *, BlockPos const &, AABB const *, std::vector__tm__39_P4AABBQ2_3std23allocator__tm__7_P4AABB *, boost::shared_ptr__tm__8_6Entity, bool))
        }

        private void InfiniteAirToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02572AA4, blr, mflr, InfiniteAir.Checked); //LivingEntity::decreaseAirSupply((int))
        }

        private void InfiniteDurabilityToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0248909C, nop, 0x4181001C, InfiniteDurability.Checked); //ItemInstance::hurt((int,Random *)) (bgt)
            GeckoU.WriteUIntToggle(0x024889CC, off, on, InfiniteDurability.Checked); //ItemInstance::isDamageableItem((void))
        }

        private void SuperKnockbackToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0257D980, 0xFC00E838, 0xFC006378, SuperKnockback.Checked); //Knockback__12LivingEntityFQ2_5boost25shared_ptr__tm__8_6EntityfdT3
            GeckoU.WriteUIntToggle(0x0257D990, 0xFD20B890, 0xFD290372, SuperKnockback.Checked);
        }

        private void DisabledKnockbackToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0257D85C, blr, 0x9421FFA8, DisabledKnockback.Checked); //Knockback__12LivingEntityFQ2_5boost25shared_ptr__tm__8_6EntityfdT3
        }

        private void SilkTouchAnythingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x020EA77C, on, 0x57C3063E, SilkTouchAnything.Checked); //Block::isSilkTouchable((void))
        }

        private void DeveloperModeToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02F5C874, on, off, DeveloperMode.Checked); //CMinecraftApp::DebugArtToolsOn((void))
        }

        private void PickLiquidBlocksToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x025A98504, on, 0x57C3063E, PickLiquidBlocks.Checked); //LiquidBlock::mayPick((BlockState const *, bool))
        }

        private void DuelWieldanyItemToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x024FD7F4, on, off, DuelWieldanyItem.Checked); //_12ItemInstance::mayPlace__Q2_13InventoryMenu11OffhandSlotF35not_null_ptr__tm(void)
        }

        private void DisableStarvingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0271BA6C, on, 0x7FE3FB78, DisableStarving.Checked); //Player::isAllowedToIgnoreExhaustion((void))
        }

        private void InstantMiningToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x020E75C8, 0xC0230000, 0xC0230040, InstantMining.Checked); //Block::getDestroySpeed((BlockState const *, Level *, BlockPos const &))
        }

        private void FlyingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0271AA74, on, 0x7FE3FB78, Flying.Checked); //Player::isAllowedToFly((void))
        }

        private void DisableSuffocatingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x027206CC, off, 0x57E3063E, DisableSuffocating.Checked); //Player::isInWall((void))
        }

        private void NoFallDamageToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02723540, blr, 0x9421FFB0, NoFallDamage.Checked); //causeFallDamage__6PlayerFfT1
        }

        private void CraftAnythingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02F70970, on, off, CraftAnything.Checked); //IsDebugSettingEnabled__12GameSettingsSF13eDebugSettingi
            GeckoU.WriteUIntToggle(0x032283CC, 0x38800000, 0x38800001, CraftAnything.Checked); //run__15MinecraftServerFLPv
        }

        private void CreativeModeToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02456F4C, on, 0x5403063E, CreativeMode.Checked); //GameType::isCreative(const(void))
        }

        private void NoFogToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x030E4954, 0x38800000, 0x38800001, NoFog.Checked);
        }

        private void StaticLiquidBlocksToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x022B9B8C, blr, 0x9421FF00, StaticLiquidBlocks.Checked); //DynamicLiquidBlock::maintick((Level *, BlockPos const &, BlockState const *, Random *))
        }

        private void FoggyWeatherToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x031C06A4, on, off, FoggyWeather.Checked); //isInCloud__13LevelRendererFdN21f
        }

        private void GenerateAmplifiedWorldToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x106CB93C, 0x4000000, 0x3DCCCCCD, GenerateAmplifiedWorld.Checked);
        }

        private void AcidLiquidBlocksToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x022B8EC4, on, 0x57E3063E, AcidLiquidBlocks.Checked); //DynamicLiquidBlock::canSpreadTo((Level *, BlockPos const &, BlockState const *))
        }

        private void DisableCreativeFlagToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x025BF44C, on, 0x886300A9, DisableCreativeFlag.Checked); // labeled as "delete", so unsure if this still works
        }

        private void GeneratePlainWorldToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0214DB38, blr, 0x9421FD80, GeneratePlainWorld.Checked); //BiomeDecorator::decorate((Biome *, Level *, Random *))
        }

        private void FreezingWorldToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0253C71C, on, off, FreezingWorld.Checked); //Level::shouldFreeze((BlockPos const &, bool))
        }

        private void UncapEntitySpawnLimitToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0256CDFC, on, 0x5403063E, UncapEntitySpawnLimit.Checked); //Level::canCreateMore((eINSTANCEOF,Level::ESPAWN_TYPE))
        }

        private void AllDLCUnlockedToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02AE8B30, on, 0x7FE3FB78, AllDLCUnlocked.Checked); //DLCManager::IsDlcPackTemporarilyFree((int))
            GeckoU.WriteUIntToggle(0x02AEF828, on, 0x7FE3FB78, AllDLCUnlocked.Checked); //DLCManager::IsMiniGameTemporarilyFree((int))
        }

        private void HostOptionsToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02F17714, 0x38807D00, 0x388303F4, HostOptions.Checked); //CMinecraftApp::SetGameHostOption((eGameHostOption, unsigned int))
        }

        private void DisablePermanentKicksToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0340D428, blr, mflr, DisablePermanentKicks.Checked); //CProfile::QuadrantOfflineXUID((int))
        }

        private void EnchantmentLevelSliderChanged(object sender, EventArgs e)
        {
            GeckoU.WriteUInt(0x022F4900, GeckoU.Mix(0x38600000, EnchantmentLevelSlider.Value)); //getenchentmentslevel
        }

        private void JumpHeightSliderChanged(object sender, EventArgs e)
        {
            GeckoU.WriteFloat(0x1066AAD4, (float)JumpHeightSlider.Value);
        }

        private void ReachSliderChanged(object sender, EventArgs e)
        {
            GeckoU.WriteFloat(0x108F5620, Convert.ToSingle(ReachSlider.Value));
            GeckoU.WriteFloat(0x108E0BDC, Convert.ToSingle(ReachSlider.Value));
        }

        private void RiptideFlyingSpeedSliderChanged(object sender, EventArgs e)
        {
            GeckoU.WriteFloat(0x1079C3E0, (float)RiptideFlyingSpeedSlider.Value);
        }

        private void SprintingSpeedScaleSliderChanged(object sender, EventArgs e)
        {
            GeckoU.WriteFloat(0x10692528, (float)SprintingSpeedScaleSlider.Value);
        }

        private void VisibleHitboxesToggled(object sender, EventArgs e)
        {
            uint whiteBoxAddress = GeckoU.PeekUInt(GeckoU.PeekUInt(0x10A72A94) + 0xC0);
            GeckoU.WriteUIntToggle(whiteBoxAddress += 0x90, 0x0001F000, 0x000100000, VisibleHitboxes.Checked);
        }

        private void ExitGameClicked(object sender, EventArgs e)
        {
            DialogResult confirmCG = Messaging.Show("You're about to close the game, continue?", MessageBoxButtons.YesNo);

            if (confirmCG == DialogResult.Yes)
                GeckoU.CallFunction64(0x02F50028, 0x00000000); //CConsoleMinecraftApp::ExitGame((void))
        }

        private void BypassFriendsOnlyToggled(object sender, EventArgs e)
        {
            GeckoU.WriteULongToggle(0x02D5731C, 0x386000014E800020, 0x7C0802A69421FFF0, BypassFriendsOnly.Checked); //CGameNetworkManager::IsInPublicJoinableGame((void))
        }
        private void WalkingSpeedScaleChanged(object sender, EventArgs e)
        {
            GeckoU.WriteFloat(0x1066ACC8, (float)WalkingSpeedScaleSlider.Value);
        }

        private void CraftingTableAnywhereToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02F59534, 0x480002E8, 0x7C0802A6, CraftingTableAnywhere.Checked);
        }

        private void HiddenGameModesUnlockedToggled(object sender, EventArgs e)
        {
            var pointer = GeckoU.PeekUInt(GeckoU.PeekUInt(0x109C4CEC) + 0x4C);
            GeckoU.WriteUIntToggle(pointer, 0x5, 0x2, HiddenGameModesUnlocked.Checked);
        }
        private void FieldOfViewSliderChanged(object sender, EventArgs e)
        {
            GeckoU.WriteFloat(0x108911B8, (float)FieldOfViewSlider.Value);
        }

        private void TakeEverythingAnywhereToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02DEC0B4, on, 0x57E3063E, TakeEverythingAnywhere.Checked);
        }

        private void ArmorHUDToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02E9B1B0, 0x7FE4FB78, 0x7FC4F378, ArmorHUD.Checked);
        }

        private void SlowMotionToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x109473C8, 0x3F700000, 0x3FF00000, SlowMotion.Checked);
        }

        private void DeadMauFiveModeToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02F5D53C, on, off, DeadMauFiveMode.Checked);
        }

        private void playerModelScaleSliderChanged(object sender, EventArgs e)
        {
            GeckoU.WriteFloat(0x1091B90C, Convert.ToSingle(playerModelScaleSlider.Value));
        }

        private void GamepadSplitscreenToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02F6EFFC, off, 0x8863072A, GamepadSplitscreen.Checked); //CConsoleMinecraftApp::IsDrcPreventingSplitscreen((void))
        }

        private void DisableTeleportingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0336367C, blr, 0x9421FED0, DisableTeleporting.Checked); //TeleportCommand::execute
        }

        private void GodModeToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02727824, nop, 0xFC20F890, GodMode.Checked); //Player::getAbsorptionAmount((void))
        }

        private void GodModeAllToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x025795C0, nop, 0xFC20F890, GodMode.Checked); //LivingEntity::setHealth((float))
        }

        private void FieldOfViewSplitSliderChanged(object sender, EventArgs e)
        {
            GeckoU.WriteFloat(0x108C7870, (float)FieldOfViewSplitSlider.Value);
        }

        private void FrictionSliderChanged(object sender, EventArgs e)
        {
            if (!tooHighWarn && FrictionSlider.Value > 2 || !tooHighWarn && FrictionSlider.Value < -2)
            {
                Messaging.Show(MessageBoxIcon.Exclamation, "Setting the friction too high (aswell as too negative) can crash your game, be warned.");
                tooHighWarn = true;
            }

            GeckoU.WriteFloat(0x1066AAE8, (float)FrictionSlider.Value);
        }

        #region commands
        private void giveCommandBtnClicked(object sender, EventArgs e)
        {
            if (!IsPointerLoaded())
            {
                Messaging.Show("Commands only work in-game, please load a world before executing a command");
                return;
            }
            if (string.IsNullOrWhiteSpace(giveIDBox.Text) || string.IsNullOrWhiteSpace(giveAmountBox.Text) || string.IsNullOrWhiteSpace(giveDataBox.Text))
            {
                Messaging.Show("Make sure all fields are filled out before executing a command");
                return;
            }
            if (Convert.ToBoolean(giveIDBox.Tag))
            {
                if (Convert.ToInt32(giveDataBox.Text) < -32768 || Convert.ToInt32(giveDataBox.Text) > 32767)
                {
                    Messaging.Show("Data value must be in between -32768 and 32767.");
                    return;
                }
            }
            else
            {
                if (Convert.ToInt32(giveDataBox.Text) < 0 || Convert.ToInt32(giveDataBox.Text) > 15)
                {
                    Messaging.Show("Data value must be in between 0 and 15.");
                    return;
                }
            }
            GeckoU.WriteUInt(0x10303008, uint.Parse(giveIDBox.Text));
            GeckoU.WriteUInt(0x1030300C, uint.Parse(giveAmountBox.Text));
            GeckoU.WriteUInt(0x10303010, (uint)int.Parse(giveDataBox.Text));
            GeckoU.WriteBytes(0x03B00000, new byte[] { 0x94, 0x21, 0xFF, 0xE8, 0x7C, 0x08, 0x02, 0xA6, 0x3D, 0x00, 0x10, 0x30, 0x3D, 0x40, 0x10, 0x30, 0x93, 0xE1, 0x00, 0x14, 0x3F, 0xE0, 0x03, 0x16, 0x63, 0xFF, 0x68, 0x18, 0x90, 0x01, 0x00, 0x1C, 0x93, 0x81, 0x00, 0x08, 0x7F, 0xE9, 0x03, 0xA6, 0x93, 0xA1, 0x00, 0x0C, 0x3D, 0x20, 0x10, 0x30, 0x93, 0xC1, 0x00, 0x10, 0x61, 0x08, 0x30, 0x08, 0x61, 0x4A, 0x30, 0x0C, 0x61, 0x29, 0x30, 0x10, 0x83, 0xC8, 0x00, 0x00, 0x83, 0xAA, 0x00, 0x00, 0x83, 0x89, 0x00, 0x00, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x83, 0x00, 0x34, 0x2C, 0x04, 0x00, 0x00, 0x41, 0x82, 0x00, 0x6C, 0x3D, 0x20, 0x02, 0x46, 0x3C, 0x60, 0x10, 0x30, 0x61, 0x29, 0x0E, 0x54, 0x39, 0x04, 0x07, 0x40, 0x7D, 0x29, 0x03, 0xA6, 0x7F, 0x87, 0xE3, 0x78, 0x7F, 0xA6, 0xEB, 0x78, 0x7F, 0xC5, 0xF3, 0x78, 0x60, 0x63, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x7F, 0xE9, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x1B, 0x61, 0x29, 0x26, 0x54, 0x38, 0x80, 0x00, 0x00, 0x7D, 0x29, 0x03, 0xA6, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x04, 0x61, 0x29, 0xA5, 0xD8, 0x3C, 0x80, 0x10, 0x30, 0x7D, 0x29, 0x03, 0xA6, 0x60, 0x84, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x01, 0x00, 0x1C, 0x3D, 0x20, 0x01, 0x0F, 0x61, 0x29, 0x6A, 0xE0, 0x83, 0x81, 0x00, 0x08, 0x83, 0xA1, 0x00, 0x0C, 0x7D, 0x29, 0x03, 0xA6, 0x83, 0xC1, 0x00, 0x10, 0x7C, 0x08, 0x03, 0xA6, 0x83, 0xE1, 0x00, 0x14, 0x38, 0x21, 0x00, 0x18, 0x4E, 0x80, 0x00, 0x20, 0x60, 0x00, 0x00, 0x00 });
            GeckoU.CallFunction(0x03B00000, new uint[1]);
        }

        private void enchantCommandBtnClicked(object sender, EventArgs e)
        {
            if (!IsPointerLoaded())
            {
                Messaging.Show("Commands only work in-game, please load a world before executing a command");
                return;
            }
            if (enchantIDBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(enchantLevelBox.Text))
            {
                Messaging.Show("Make sure all fields are filled out before executing a command");
                return;
            }
            if (Convert.ToInt32(enchantLevelBox.Text) < -32768 || Convert.ToInt32(enchantLevelBox.Text) > 32767)
            {
                Messaging.Show("Enchantment level must be in between -32768 and 32767.");
                return;
            }
            GeckoU.WriteUInt(0x10303008, enchantments[enchantIDBox.SelectedIndex]);
            GeckoU.WriteUInt(0x1030300C, (uint)int.Parse(enchantLevelBox.Text));
            GeckoU.WriteUInt(0x10303010, 0x1);
            GeckoU.WriteBytes(0x03B10000, new byte[] { 0x94, 0x21, 0xFF, 0xE8, 0x7C, 0x08, 0x02, 0xA6, 0x3D, 0x00, 0x10, 0x30, 0x3D, 0x40, 0x10, 0x30, 0x93, 0xE1, 0x00, 0x14, 0x3F, 0xE0, 0x03, 0x16, 0x63, 0xFF, 0x68, 0x18, 0x90, 0x01, 0x00, 0x1C, 0x93, 0x81, 0x00, 0x08, 0x7F, 0xE9, 0x03, 0xA6, 0x93, 0xA1, 0x00, 0x0C, 0x3D, 0x20, 0x10, 0x30, 0x93, 0xC1, 0x00, 0x10, 0x61, 0x08, 0x30, 0x08, 0x61, 0x4A, 0x30, 0x0C, 0x61, 0x29, 0x30, 0x10, 0x83, 0xC8, 0x00, 0x00, 0x83, 0xAA, 0x00, 0x00, 0x83, 0x89, 0x00, 0x00, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x83, 0x00, 0x34, 0x2C, 0x04, 0x00, 0x00, 0x41, 0x82, 0x00, 0x6C, 0x3D, 0x20, 0x02, 0x2F, 0x3C, 0x60, 0x10, 0x30, 0x61, 0x29, 0x15, 0x18, 0x39, 0x04, 0x07, 0x40, 0x7D, 0x29, 0x03, 0xA6, 0x7F, 0x87, 0xE3, 0x78, 0x7F, 0xA6, 0xEB, 0x78, 0x7F, 0xC5, 0xF3, 0x78, 0x60, 0x63, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x7F, 0xE9, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x1B, 0x61, 0x29, 0x26, 0x54, 0x38, 0x80, 0x00, 0x00, 0x7D, 0x29, 0x03, 0xA6, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x04, 0x61, 0x29, 0xA5, 0xD8, 0x3C, 0x80, 0x10, 0x30, 0x7D, 0x29, 0x03, 0xA6, 0x60, 0x84, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x01, 0x00, 0x1C, 0x3D, 0x20, 0x01, 0x0F, 0x61, 0x29, 0x6A, 0xE0, 0x83, 0x81, 0x00, 0x08, 0x83, 0xA1, 0x00, 0x0C, 0x7D, 0x29, 0x03, 0xA6, 0x83, 0xC1, 0x00, 0x10, 0x7C, 0x08, 0x03, 0xA6, 0x83, 0xE1, 0x00, 0x14, 0x38, 0x21, 0x00, 0x18, 0x4E, 0x80, 0x00, 0x20, 0x60, 0x00, 0x00, 0x00 });
            GeckoU.CallFunction(0x03B10000, new uint[1]);
        }

        private void timeCommandBtnClicked(object sender, EventArgs e)
        {
            if (!IsPointerLoaded())
            {
                Messaging.Show("Commands only work in-game, please load a world before executing a command");
                return;
            }
            if (string.IsNullOrWhiteSpace(timeAmountBox.Text))
            {
                Messaging.Show("Make sure all fields are filled out before executing a command");
                return;
            }
            byte[] Command = new byte[] { 0x94, 0x21, 0xFF, 0xE8, 0x7C, 0x08, 0x02, 0xA6, 0x3D, 0x00, 0x10, 0x30, 0x3D, 0x40, 0x10, 0x30, 0x93, 0xE1, 0x00, 0x14, 0x3F, 0xE0, 0x03, 0x16, 0x63, 0xFF, 0x68, 0x18, 0x90, 0x01, 0x00, 0x1C, 0x93, 0x81, 0x00, 0x08, 0x7F, 0xE9, 0x03, 0xA6, 0x93, 0xA1, 0x00, 0x0C, 0x3D, 0x20, 0x10, 0x30, 0x93, 0xC1, 0x00, 0x10, 0x61, 0x08, 0x30, 0x08, 0x61, 0x4A, 0x30, 0x0C, 0x61, 0x29, 0x30, 0x10, 0x83, 0xC8, 0x00, 0x00, 0x83, 0xAA, 0x00, 0x00, 0x83, 0x89, 0x00, 0x00, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x83, 0x00, 0x34, 0x2C, 0x04, 0x00, 0x00, 0x41, 0x82, 0x00, 0x6C, 0x3D, 0x20, 0x02, 0x9F, 0x3C, 0x60, 0x10, 0x30, 0x61, 0x29, 0x92, 0xE0, 0x39, 0x04, 0x07, 0x40, 0x7D, 0x29, 0x03, 0xA6, 0x7F, 0x87, 0xE3, 0x78, 0x7F, 0xA6, 0xEB, 0x78, 0x7F, 0xC5, 0xF3, 0x78, 0x60, 0x63, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x7F, 0xE9, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x1B, 0x61, 0x29, 0x26, 0x54, 0x38, 0x80, 0x00, 0x00, 0x7D, 0x29, 0x03, 0xA6, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x04, 0x61, 0x29, 0xA5, 0xD8, 0x3C, 0x80, 0x10, 0x30, 0x7D, 0x29, 0x03, 0xA6, 0x60, 0x84, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x01, 0x00, 0x1C, 0x3D, 0x20, 0x01, 0x0F, 0x61, 0x29, 0x6A, 0xE0, 0x83, 0x81, 0x00, 0x08, 0x83, 0xA1, 0x00, 0x0C, 0x7D, 0x29, 0x03, 0xA6, 0x83, 0xC1, 0x00, 0x10, 0x7C, 0x08, 0x03, 0xA6, 0x83, 0xE1, 0x00, 0x14, 0x38, 0x21, 0x00, 0x18, 0x4E, 0x80, 0x00, 0x20, 0x60, 0x00, 0x00, 0x00 };
            GeckoU.WriteUInt(0x10303008, 0x0);
            GeckoU.WriteUInt(0x1030300C, (uint)int.Parse(timeAmountBox.Text));
            GeckoU.WriteUInt(0x10303010, 0x0);
            GeckoU.WriteBytes(0x03B20000, Command);
            GeckoU.CallFunction(0x03B20000, new uint[1]);
        }

        private void killCommandBtnClicked(object sender, EventArgs e)
        {
            if (!IsPointerLoaded())
            {
                Messaging.Show("Commands only work in-game, please load a world before executing a command");
                return;
            }
            byte[] Command = new byte[] { 0x94, 0x21, 0xFF, 0xE8, 0x7C, 0x08, 0x02, 0xA6, 0x3D, 0x00, 0x10, 0x30, 0x3D, 0x40, 0x10, 0x30, 0x93, 0xE1, 0x00, 0x14, 0x3F, 0xE0, 0x03, 0x16, 0x63, 0xFF, 0x68, 0x18, 0x90, 0x01, 0x00, 0x1C, 0x93, 0x81, 0x00, 0x08, 0x7F, 0xE9, 0x03, 0xA6, 0x93, 0xA1, 0x00, 0x0C, 0x3D, 0x20, 0x10, 0x30, 0x93, 0xC1, 0x00, 0x10, 0x61, 0x08, 0x30, 0x08, 0x61, 0x4A, 0x30, 0x0C, 0x61, 0x29, 0x30, 0x10, 0x83, 0xC8, 0x00, 0x00, 0x83, 0xAA, 0x00, 0x00, 0x83, 0x89, 0x00, 0x00, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x83, 0x00, 0x34, 0x2C, 0x04, 0x00, 0x00, 0x41, 0x82, 0x00, 0x6C, 0x3D, 0x20, 0x02, 0x52, 0x3C, 0x60, 0x10, 0x30, 0x61, 0x29, 0x0B, 0x58, 0x39, 0x04, 0x07, 0x40, 0x7D, 0x29, 0x03, 0xA6, 0x7F, 0x87, 0xE3, 0x78, 0x7F, 0xA6, 0xEB, 0x78, 0x7F, 0xC5, 0xF3, 0x78, 0x60, 0x63, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x7F, 0xE9, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x1B, 0x61, 0x29, 0x26, 0x54, 0x38, 0x80, 0x00, 0x00, 0x7D, 0x29, 0x03, 0xA6, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x04, 0x61, 0x29, 0xA5, 0xD8, 0x3C, 0x80, 0x10, 0x30, 0x7D, 0x29, 0x03, 0xA6, 0x60, 0x84, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x01, 0x00, 0x1C, 0x3D, 0x20, 0x01, 0x0F, 0x61, 0x29, 0x6A, 0xE0, 0x83, 0x81, 0x00, 0x08, 0x83, 0xA1, 0x00, 0x0C, 0x7D, 0x29, 0x03, 0xA6, 0x83, 0xC1, 0x00, 0x10, 0x7C, 0x08, 0x03, 0xA6, 0x83, 0xE1, 0x00, 0x14, 0x38, 0x21, 0x00, 0x18, 0x4E, 0x80, 0x00, 0x20, 0x60, 0x00, 0x00, 0x00 };
            GeckoU.WriteUInt(0x10303008, 0x0);
            GeckoU.WriteUInt(0x1030300C, 0x0);
            GeckoU.WriteUInt(0x10303010, 0x0);
            GeckoU.WriteBytes(0x03B30000, Command);
            GeckoU.CallFunction(0x03B30000, new uint[1]);
        }

        private void downfallCommandBtnClicked(object sender, EventArgs e)
        {
            if (!IsPointerLoaded())
            {
                Messaging.Show("Commands only work in-game, please load a world before executing a command");
                return;
            }
            byte[] Command = new byte[] { 0x94, 0x21, 0xFF, 0xE8, 0x7C, 0x08, 0x02, 0xA6, 0x3D, 0x00, 0x10, 0x30, 0x3D, 0x40, 0x10, 0x30, 0x93, 0xE1, 0x00, 0x14, 0x3F, 0xE0, 0x03, 0x16, 0x63, 0xFF, 0x68, 0x18, 0x90, 0x01, 0x00, 0x1C, 0x93, 0x81, 0x00, 0x08, 0x7F, 0xE9, 0x03, 0xA6, 0x93, 0xA1, 0x00, 0x0C, 0x3D, 0x20, 0x10, 0x30, 0x93, 0xC1, 0x00, 0x10, 0x61, 0x08, 0x30, 0x08, 0x61, 0x4A, 0x30, 0x0C, 0x61, 0x29, 0x30, 0x10, 0x83, 0xC8, 0x00, 0x00, 0x83, 0xAA, 0x00, 0x00, 0x83, 0x89, 0x00, 0x00, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x83, 0x00, 0x34, 0x2C, 0x04, 0x00, 0x00, 0x41, 0x82, 0x00, 0x6C, 0x3D, 0x20, 0x02, 0xA0, 0x3C, 0x60, 0x10, 0x30, 0x61, 0x29, 0x00, 0xA4, 0x39, 0x04, 0x07, 0x40, 0x7D, 0x29, 0x03, 0xA6, 0x7F, 0x87, 0xE3, 0x78, 0x7F, 0xA6, 0xEB, 0x78, 0x7F, 0xC5, 0xF3, 0x78, 0x60, 0x63, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x7F, 0xE9, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x1B, 0x61, 0x29, 0x26, 0x54, 0x38, 0x80, 0x00, 0x00, 0x7D, 0x29, 0x03, 0xA6, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x04, 0x61, 0x29, 0xA5, 0xD8, 0x3C, 0x80, 0x10, 0x30, 0x7D, 0x29, 0x03, 0xA6, 0x60, 0x84, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x01, 0x00, 0x1C, 0x3D, 0x20, 0x01, 0x0F, 0x61, 0x29, 0x6A, 0xE0, 0x83, 0x81, 0x00, 0x08, 0x83, 0xA1, 0x00, 0x0C, 0x7D, 0x29, 0x03, 0xA6, 0x83, 0xC1, 0x00, 0x10, 0x7C, 0x08, 0x03, 0xA6, 0x83, 0xE1, 0x00, 0x14, 0x38, 0x21, 0x00, 0x18, 0x4E, 0x80, 0x00, 0x20, 0x60, 0x00, 0x00, 0x00 };
            GeckoU.WriteUInt(0x10303008, 0x0);
            GeckoU.WriteUInt(0x1030300C, 0x0);
            GeckoU.WriteUInt(0x10303010, 0x0);
            GeckoU.WriteBytes(0x03B30000, Command);
            GeckoU.CallFunction(0x03B30000, new uint[1]);
        }

        private void SetWorldSpawnBtnClicked(object sender, EventArgs e)
        {
            if (!IsPointerLoaded())
            {
                Messaging.Show("Commands only work in-game, please load a world before executing a command");
                return;
            }
            byte[] Command = new byte[] { 0x94, 0x21, 0xFF, 0xE8, 0x7C, 0x08, 0x02, 0xA6, 0x3D, 0x00, 0x10, 0x30, 0x3D, 0x40, 0x10, 0x30, 0x93, 0xE1, 0x00, 0x14, 0x3F, 0xE0, 0x03, 0x16, 0x63, 0xFF, 0x68, 0x18, 0x90, 0x01, 0x00, 0x1C, 0x93, 0x81, 0x00, 0x08, 0x7F, 0xE9, 0x03, 0xA6, 0x93, 0xA1, 0x00, 0x0C, 0x3D, 0x20, 0x10, 0x30, 0x93, 0xC1, 0x00, 0x10, 0x61, 0x08, 0x30, 0x08, 0x61, 0x4A, 0x30, 0x0C, 0x61, 0x29, 0x30, 0x10, 0x83, 0xC8, 0x00, 0x00, 0x83, 0xAA, 0x00, 0x00, 0x83, 0x89, 0x00, 0x00, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x83, 0x00, 0x34, 0x2C, 0x04, 0x00, 0x00, 0x41, 0x82, 0x00, 0x6C, 0x3D, 0x20, 0x02, 0x8B, 0x3C, 0x60, 0x10, 0x30, 0x61, 0x29, 0x51, 0x58, 0x39, 0x04, 0x07, 0x40, 0x7D, 0x29, 0x03, 0xA6, 0x7F, 0x87, 0xE3, 0x78, 0x7F, 0xA6, 0xEB, 0x78, 0x7F, 0xC5, 0xF3, 0x78, 0x60, 0x63, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x7F, 0xE9, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x1B, 0x61, 0x29, 0x26, 0x54, 0x38, 0x80, 0x00, 0x00, 0x7D, 0x29, 0x03, 0xA6, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x04, 0x61, 0x29, 0xA5, 0xD8, 0x3C, 0x80, 0x10, 0x30, 0x7D, 0x29, 0x03, 0xA6, 0x60, 0x84, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x01, 0x00, 0x1C, 0x3D, 0x20, 0x01, 0x0F, 0x61, 0x29, 0x6A, 0xE0, 0x83, 0x81, 0x00, 0x08, 0x83, 0xA1, 0x00, 0x0C, 0x7D, 0x29, 0x03, 0xA6, 0x83, 0xC1, 0x00, 0x10, 0x7C, 0x08, 0x03, 0xA6, 0x83, 0xE1, 0x00, 0x14, 0x38, 0x21, 0x00, 0x18, 0x4E, 0x80, 0x00, 0x20, 0x60, 0x00, 0x00, 0x00 };
            GeckoU.WriteUInt(0x10303008, 0x0);
            GeckoU.WriteUInt(0x1030300C, 0x0);
            GeckoU.WriteUInt(0x10303010, 0x0);
            GeckoU.WriteBytes(0x03B30000, Command);
            GeckoU.CallFunction(0x03B30000, new uint[1]);
        }

        private void GameModeCommandBtnClicked(object sender, EventArgs e)
        {
            if (!IsPointerLoaded())
            {
                Messaging.Show("Commands only work in-game, please load a world before executing a command");
                return;
            }
            byte[] Command = new byte[] { 0x94, 0x21, 0xFF, 0xE8, 0x7C, 0x08, 0x02, 0xA6, 0x3D, 0x00, 0x10, 0x30, 0x3D, 0x40, 0x10, 0x30, 0x93, 0xE1, 0x00, 0x14, 0x3F, 0xE0, 0x03, 0x16, 0x63, 0xFF, 0x68, 0x18, 0x90, 0x01, 0x00, 0x1C, 0x93, 0x81, 0x00, 0x08, 0x7F, 0xE9, 0x03, 0xA6, 0x93, 0xA1, 0x00, 0x0C, 0x3D, 0x20, 0x10, 0x30, 0x93, 0xC1, 0x00, 0x10, 0x61, 0x08, 0x30, 0x08, 0x61, 0x4A, 0x30, 0x0C, 0x61, 0x29, 0x30, 0x10, 0x83, 0xC8, 0x00, 0x00, 0x83, 0xAA, 0x00, 0x00, 0x83, 0x89, 0x00, 0x00, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x83, 0x00, 0x34, 0x2C, 0x04, 0x00, 0x00, 0x41, 0x82, 0x00, 0x6C, 0x3D, 0x20, 0x02, 0x2D, 0x3C, 0x60, 0x10, 0x30, 0x61, 0x29, 0x02, 0xC4, 0x39, 0x04, 0x07, 0x40, 0x7D, 0x29, 0x03, 0xA6, 0x7F, 0x87, 0xE3, 0x78, 0x7F, 0xA6, 0xEB, 0x78, 0x7F, 0xC5, 0xF3, 0x78, 0x60, 0x63, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x7F, 0xE9, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x1B, 0x61, 0x29, 0x26, 0x54, 0x38, 0x80, 0x00, 0x00, 0x7D, 0x29, 0x03, 0xA6, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x04, 0x61, 0x29, 0xA5, 0xD8, 0x3C, 0x80, 0x10, 0x30, 0x7D, 0x29, 0x03, 0xA6, 0x60, 0x84, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x01, 0x00, 0x1C, 0x3D, 0x20, 0x01, 0x0F, 0x61, 0x29, 0x6A, 0xE0, 0x83, 0x81, 0x00, 0x08, 0x83, 0xA1, 0x00, 0x0C, 0x7D, 0x29, 0x03, 0xA6, 0x83, 0xC1, 0x00, 0x10, 0x7C, 0x08, 0x03, 0xA6, 0x83, 0xE1, 0x00, 0x14, 0x38, 0x21, 0x00, 0x18, 0x4E, 0x80, 0x00, 0x20, 0x60, 0x00, 0x00, 0x00 };
            GeckoU.WriteUInt(0x10303008, 0x0);
            GeckoU.WriteUInt(0x1030300C, 0x0);
            GeckoU.WriteUInt(0x10303010, 0x0);
            GeckoU.WriteBytes(0x03B30000, Command);
            GeckoU.CallFunction(0x03B30000, new uint[1]);
        }
        #endregion

        #region minigames
        private void AllPermissionsToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02C57E94, on, 0x57E3063E, AllPermissions.Checked); //MiniGameDef::MayUseBlock(const(int))
            GeckoU.WriteUIntToggle(0x02C57E34, on, 0x57E3063E, AllPermissions.Checked); //MiniGameDef::MayUse(const(int))
            GeckoU.WriteUIntToggle(0x02C51C20, on, 0x57E3063E, AllPermissions.Checked); //MiniGameDef::MayUseBlock(const(int))
            GeckoU.WriteUIntToggle(0x02C5CC84, on, 0X88630124, AllPermissions.Checked); //MiniGameDef::CanCraft(const(void))
            GeckoU.WriteUIntToggle(0x02C57D74, on, 0x57E3063E, AllPermissions.Checked); //MiniGameDef::MayPlace(const(int))
            GeckoU.WriteUIntToggle(0x02C57DD4, on, 0x57E3063E, AllPermissions.Checked); //MiniGameDef::MayDestroy(const(int))
        }

        private void AlwaysDamagedToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02C7DDD0, on, off, AlwaysDamaged.Checked); //MasterGameMode::IsInKillBox((boost::shared_ptr__tm__8_6Entity))
        }

        private void TNTGriefingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02C59E04, on, off, TNTGriefing.Checked); //MiniGameDef::canTntDestroyBlocks(const(void))
        }

        private void DisabledKillBarriersToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02C7DD38, off, on, DisabledKillBarriers.Checked); //MasterGameMode::IsInKillBox((boost::shared_ptr__tm__8_6Entity))
        }

        private void AntiEndGameToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02C9554C, off, on, AntiEndGame.Checked); //MasterGameMode::CanEndPostGame((void))
        }

        private void EndGameClicked(object sender, EventArgs e)
        {
            GeckoU.WriteUInt(0x02C93A90, blr);
            GeckoU.WriteUInt(0x02C93A90, mflr);
        }

        private void TumbleHUDToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02E3A950, off, 0x57E3063E, TumbleHUD.Checked); //UIScene_HUD::HideMainHUD((void))
            GeckoU.WriteUIntToggle(0x02C57EBC, off, 0x8863012A, TumbleHUD.Checked); //MiniGameDef::LockedInventory(const(void))
        }
        private void RequiredPlayersSliderChanged(object sender, EventArgs e)
        {
            GeckoU.WriteUInt(0x02C7C004, GeckoU.Mix(0x38600000, RequiredPlayersSlider.Value)); //MasterGameMode::GetMinimumPlayersToStart
        }

        private void RefillIntervalSliderChanged(object sender, EventArgs e)
        {
            GeckoU.WriteUInt(0x02C5CC74, GeckoU.Mix(0x38600000, RefillIntervalSlider.Value)); //MiniGameDef::GetItemRespawnTime
        }

        private void GlideRingScoreSliderChanged(object sender, EventArgs e)
        {
            GeckoU.WriteUInt(0x02D6EE14, GeckoU.Mix(0x38600000, ringScoreGreen.Value)); //ScoreRingRuleDefinition::getPointValue((void))
            GeckoU.WriteUInt(0x02D6EE1C, GeckoU.Mix(0x38600000, ringScoreBlue.Value));
            GeckoU.WriteUInt(0x02D6EE24, GeckoU.Mix(0x38600000, ringScoreOrange.Value));
        }

        private void SqueakInfinitelyToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x031A2730, blr, mflr, SqueakInfinitely.Checked); //MultiPlayerGameMode::CanMakeSpectateSound((void))
        }
        #endregion

        #region debug
        private void disableVPadInputToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x011293D0, blr, 0x38E00001, disableVPadInput.Checked);
        }
        private void vpadDisplaySwitchToggled(object sender, EventArgs e)
        {
            GeckoU.RpcToggle(0x0112A9E4, 0x0112A9EC, 0x0, 0x0, vpadDisplaySwitch.Checked);
        }
        #endregion

        #endregion memory editing
    }
}
