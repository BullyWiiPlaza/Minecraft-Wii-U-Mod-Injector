using com.slothwiiplaza.geckou;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Minecraft_Wii_U_Mod_Injector.helpers;
using Minecraft_Wii_U_Mod_Injector.forms;
using Minecraft_Wii_U_Mod_Injector.helpers.files;
using Minecraft_Wii_U_Mod_Injector.helpers.winforms;

namespace Minecraft_Wii_U_Mod_Injector
{
    public partial class MainForm : MetroForm
    {
        #region Base Vars

        #region Refs

        public static GeckoUCore GeckoU;
        public static GeckoUConnect GeckoUConnection;
        public States.StatesIds GetStates = States.StatesIds.Disconnected;

        #endregion

        #region Assembly

        public uint on = 0x38600001;
        public uint off = 0x38600000;
        public uint on2 = 0x3BE00001;
        public uint off2 = 0x3BE00000;
        public uint blr = 0x4E800020;
        public uint mflr = 0x7C0802A6;
        public uint nop = 0x60000000;

        #endregion

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void Init(object sender, EventArgs e)
        {
            #region Init

            new States(this);
            new Messaging(this);
            new Setup(this);
            Setup.SetupInjector();

            #endregion

            #region patch notes and news section

            buildApiDescBox.Text = Properties.Resources.releaseNotes;

            #endregion

            ValidateEnteredIPAddress();
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            if (GeckoU != null && GeckoU.GeckoUConnected())
            {
                try
                {
                    GeckoU.CallFunction(0x13377331, 0x73311337);
                }
                catch
                {
                    GeckoU = new GeckoUCore(Configuration.ReadKey("WiiUHost", "Wii U"));
                    GeckoU.CallFunction(0x13377331, 0x73311337);
                }
            }

            DiscordRP.Deinitialize();
        }

        private void swapTab(object sender, EventArgs e)
        {
            var tile = (MetroTile)sender;
            if (tile.TileCount == 6)
                MainTabs.SelectedIndex = tile.TileCount - 1;

            MainTabs.SelectedIndex = tile.TileCount;
            DiscordRP.SetPresence("Modding", "Browsing " + MainTabs.SelectedTab.Text + " tab");
        }

        private void connectBtnClicked(object sender, EventArgs e)
        {
            GeckoU = new GeckoUCore(wiiuIpv4Box.Text);
            try
            {
                switch (GetStates)
                {
                    case States.StatesIds.Disconnected:
                        States.SwapState(States.StatesIds.Connecting);
                        GeckoU.GUC.Connect();
                        States.SwapState(States.StatesIds.Connected);
                        GeckoU.WriteUInt(0x31010100, 0x00000000);
                        break;

                    case States.StatesIds.Connected:
                        GeckoU.GUC.Close();
                        States.SwapState(States.StatesIds.Disconnected);
                        break;
                }
            }
            catch (System.Net.Sockets.SocketException error)
            {
                Messaging.Show(MessageBoxIcon.Error, "Couldn't detect TCPGecko running or IP Address is wrong.\nMake sure you have TCPGecko running and entered the correct IP Address for you Wii U");
                Exceptions.LogError(error, "Wrong IP Address", Exceptions.ExceptionId.ConnectionProblem, false, false);
            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Unable to Connect to the Wii U", Exceptions.ExceptionId.ConnectionProblem, false, true);

                if (GetStates == States.StatesIds.Connecting)
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
                StyleManager.Theme = (MetroThemeStyle)Enum.Parse(typeof(MetroThemeStyle), themeBox.Text);
                Refresh();
                Configuration.WriteKey("StyleTheme", themeBox.Text, "Theming");
            }
            catch (Exception Error)
            {
                Exceptions.LogError(Error, "Failed to Change Injector Form Theme", Exceptions.ExceptionId.UnknownFail, false, true);
            }
        }

        private void formColorSelected(object sender, EventArgs e)
        {
            try
            {
                Style = (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), colorsBox.Text);
                StyleManager.Style = (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), colorsBox.Text);
                Refresh();
                Configuration.WriteKey("ColorTheme", colorsBox.Text, "Theming");
            }
            catch (Exception Error)
            {
                Exceptions.LogError(Error, "Failed to Change Injector Form Color", Exceptions.ExceptionId.UnknownFail, false, true);
            }
        }

        private void discordRpcToggleChecked(object sender, EventArgs e)
        {
            try
            {
                if (discordRpcCheckBox.Checked)
                {
                    Configuration.WriteKey("DiscordRPC", "true", "Discord");
                    DiscordRP.Initialize();
                    DiscordRP.SetPresence("Modding", "Idle");
                }
                else
                {
                    Configuration.WriteKey("DiscordRPC", "false", "Discord");
                    DiscordRP.Deinitialize();
                }
            }
            catch (Exception Error)
            {
                Exceptions.LogError(Error, "Failed to Toggle Discord RPC", Exceptions.ExceptionId.UnknownFail, false, true);
            }
        }

        private void discordSrvBtnClicked(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/jrzZWaDc7a");
        }

        private void creditsBtnClicked(object sender, EventArgs e)
        {
            new Credits(this).Show();
        }

        private void MapTextEditorClicked(object sender, EventArgs e)
        {
            new MapTextEditor(this).Show();
        }

        private void NNIDEditorBtnClicked(object sender, EventArgs e)
        {
            new NNIDEditor(this).Show();
        }

        #region memory editing

        private void InsaneCriticalHitsToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x106D0D4C, 0x43F00000, 0x3FC00000, InsaneCriticalHits.Checked);
        }

        private void HighFieldofViewToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x108911B8, 0x40000000, 0x3FF00000, HighFieldofView.Checked);
        }

        private void AlwaysSwimmingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteULongToggle(0x023405EC, 0x386000014E800020, 0x3D800233398C69B8,
                AlwaysSwimming.Checked); //Entity::isSwimming((void))
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
            GeckoU.WriteLongToggle(0x024872AC, 0x600000004E800020, 0x3D800248398C7294,
                InfiniteItems.Checked); //ItemInstance::shrink((int))
        }

        private void RapidBowToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02162F04, 0x3BE00001, 0x3BE00014,
                RapidBow.Checked); //GetMaxBowDuration__7BowItemSFv
        }

        private void BloodVisionToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0257E000, off, 0x57E3063E, BloodVision.Checked); //LivingEntity::isAlive((void))
        }

        private void IgnorePotionsToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0258E4BC, off, on,
                IgnorePotions.Checked); //LivingEntity::isAffectedByPotions((void))
        }

        private void ForeverLastingPotionsToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02576994, blr, 0x9421FF40,
                ForeverLastingPotions.Checked); //LivingEntity::tickEffects((void))
        }

        private void BypassInvulnerabilityToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0225458C, on, 0x88630009,
                BypassInvulnerability.Checked); //DamageSource::isBypassInvul(const(void))
        }

        private void PlaceBlocksonHeadToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0207F604, on, 0x7FC3F378,
                PlaceBlocksonHead.Checked); //ArmorSlot::mayPlace((not_null_ptr__tm__15_12ItemInstance))
        }

        private void WalkonWaterToggled(object sender, EventArgs e)
        {
            GeckoU.WriteULongToggle(0x025A963C, 0x3C60109E80639948, 0x3C6010568063B61C,
                WalkonWater.Checked); //LiquidBlock::getClipAABB((BlockState const *, LevelSource *, BlockPos const &))
        }

        private void AlwaysElytraToggled(object sender, EventArgs e)
        {
            GeckoU.WriteULongToggle(0x0258DACC, 0x386000014E800020, 0x3D800233398C69B8,
                AlwaysElytra.Checked); //LivingEntity::isFallFlying((void))
        }

        private void CaveFinderToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x030E4924, 0x38800000, 0x38800001,
                CaveFinder.Checked); //enableState__14GlStateManagerSFi
        }

        private void WallhackToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x031B2B4C, on, 0x5403063E, Wallhack.Checked); //renderDebug__9MinecraftSFv
        }

        private void LargeXPDropsToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0239A26C, nop, 0x4180000C,
                LargeXPDrops.Checked); //getExperienceValue__13ExperienceOrbSFi:
            GeckoU.WriteUIntToggle(0x0239A270, 0x38607FFF, 0x386009AD, LargeXPDrops.Checked);
        }

        private void WallClimbingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0257DF90, on, 0x57C3063E, WallClimbing.Checked); //LivingEntity::onLadder((void))
        }

        private void NoCollisionToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x020E7BF4, blr, 0x9421FFE0,
                NoCollision.Checked); //Block::addCollisionAABBs((BlockState const *, Level *, BlockPos const &, AABB const *, std::vector__tm__39_P4AABBQ2_3std23allocator__tm__7_P4AABB *, boost::shared_ptr__tm__8_6Entity, bool))
        }

        private void InfiniteAirToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02572AA4, blr, mflr, InfiniteAir.Checked); //LivingEntity::decreaseAirSupply((int))
        }

        private void InfiniteDurabilityToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0248909C, nop, 0x4181001C,
                InfiniteDurability.Checked); //ItemInstance::hurt((int,Random *)) (bgt)
        }

        private void SuperKnockbackToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0257D980, 0xFC00E838, 0xFC006378,
                SuperKnockback.Checked); //Knockback__12LivingEntityFQ2_5boost25shared_ptr__tm__8_6EntityfdT3
            GeckoU.WriteUIntToggle(0x0257D990, 0xFD20B890, 0xFD290372, SuperKnockback.Checked);
        }

        private void DisabledKnockbackToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0257D85C, blr, 0x9421FFA8,
                DisabledKnockback.Checked); //Knockback__12LivingEntityFQ2_5boost25shared_ptr__tm__8_6EntityfdT3
        }

        private void SilkTouchAnythingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x020EA77C, on, 0x57C3063E,
                SilkTouchAnything.Checked); //Block::isSilkTouchable((void))
        }

        private void DeveloperModeToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02F5C874, on, off, DeveloperMode.Checked); //CMinecraftApp::DebugArtToolsOn((void))
        }

        private void PickLiquidBlocksToggled(object sender, EventArgs e) //rename to "PickAnyBlocks"
        {
            GeckoU.WriteUIntToggle(0x025A98504, on, 0x57C3063E,
                PickLiquidBlocks.Checked); //LiquidBlock::mayPick((BlockState const *, bool))
        }

        private void DuelWieldanyItemToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x024FD7F4, on, off,
                DuelWieldanyItem
                    .Checked); //_12ItemInstance::mayPlace__Q2_13InventoryMenu11OffhandSlotF35not_null_ptr__tm(void)
        }

        private void DisableStarvingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0271BA6C, on, 0x7FE3FB78,
                DisableStarving.Checked); //Player::isAllowedToIgnoreExhaustion((void))
        }

        private void InstantMiningToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x020E75C8, 0xC0230000, 0xC0230040,
                InstantMining.Checked); //Block::getDestroySpeed((BlockState const *, Level *, BlockPos const &))
        }

        private void FlyingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0271AA74, on, 0x7FE3FB78, Flying.Checked); //Player::isAllowedToFly((void))
        }

        private void DisableSuffocatingToggled(object sender, EventArgs e)
        {
            if (!AlwaysDamagedPlayers.Checked || !AlwaysDamaged.Checked)
                GeckoU.WriteUIntToggle(0x027206CC, off, 0x57E3063E, DisableSuffocating.Checked); //Player::isInWall((void))
            else
                DisableSuffocating.Checked = false; //these 2 mods are not compatible with eachother, they use the same function
        }

        private void NoFallDamageToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02723540, blr, 0x9421FFB0, NoFallDamage.Checked); //causeFallDamage__6PlayerFfT1
        }

        private void CraftAnythingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02F70970, on, off,
                CraftAnything.Checked); //IsDebugSettingEnabled__12GameSettingsSF13eDebugSettingi
            GeckoU.WriteUIntToggle(0x032283CC, 0x38800000, 0x38800001,
                CraftAnything.Checked); //run__15MinecraftServerFLPv
        }

        private void CreativeModeToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02456F4C, on, 0x5403063E,
                CreativeMode.Checked); //GameType::isCreative(const(void))
        }

        private void NoFogToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x030DAB7C, 0x38800000, 0x38800001, NoFog.Checked); //remove
        }

        private void StaticLiquidBlocksToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x022B9B8C, blr, 0x9421FF00,
                StaticLiquidBlocks
                    .Checked); //DynamicLiquidBlock::maintick((Level *, BlockPos const &, BlockState const *, Random *))
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
            GeckoU.WriteUIntToggle(0x022B8EC4, on, 0x57E3063E,
                AcidLiquidBlocks
                    .Checked); //DynamicLiquidBlock::canSpreadTo((Level *, BlockPos const &, BlockState const *))
        }

        private void DisableCreativeFlagToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x025BF44C, on, 0x886300A9, DisableCreativeFlag.Checked); // labeled as "delete", so unsure if this still works
        }

        private void GeneratePlainWorldToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0214DB38, blr, 0x9421FD80,
                GeneratePlainWorld.Checked); //BiomeDecorator::decorate((Biome *, Level *, Random *))
        }

        private void FreezingWorldToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0253C71C, on, off,
                FreezingWorld.Checked); //Level::shouldFreeze((BlockPos const &, bool))
        }

        private void UncapEntitySpawnLimitToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0256CDFC, on, 0x5403063E,
                UncapEntitySpawnLimit.Checked); //Level::canCreateMore((eINSTANCEOF,Level::ESPAWN_TYPE))
        }

        private void AllDLCUnlockedToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02AE8B30, on, 0x7FE3FB78,
                AllDLCUnlocked.Checked); //DLCManager::IsDlcPackTemporarilyFree((int))
            GeckoU.WriteUIntToggle(0x02AEF828, on, 0x7FE3FB78,
                AllDLCUnlocked.Checked); //DLCManager::IsMiniGameTemporarilyFree((int))
        }

        private void AllPermissionsToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02C57E94, on, 0x57E3063E,
                AllPermissions.Checked); //MiniGameDef::MayUseBlock(const(int))
            GeckoU.WriteUIntToggle(0x02C57E34, on, 0x57E3063E,
                AllPermissions.Checked); //MiniGameDef::MayUse(const(int))
            GeckoU.WriteUIntToggle(0x02C51C20, on, 0x57E3063E,
                AllPermissions.Checked); //MiniGameDef::MayUseBlock(const(int))
            GeckoU.WriteUIntToggle(0x02C5CC84, on, 0X88630124,
                AllPermissions.Checked); //MiniGameDef::CanCraft(const(void))
            GeckoU.WriteUIntToggle(0x02C57D74, on, 0x57E3063E,
                AllPermissions.Checked); //MiniGameDef::MayPlace(const(int))
            GeckoU.WriteUIntToggle(0x02C57DD4, on, 0x57E3063E,
                AllPermissions.Checked); //MiniGameDef::MayDestroy(const(int))
        }

        private void AlwaysDamagedToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02C7DDD0, on, off,
                AlwaysDamaged.Checked); //MasterGameMode::IsInKillBox((boost::shared_ptr__tm__8_6Entity))
        }

        private void TNTGriefingToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02C59E04, on, off,
                TNTGriefing.Checked); //MiniGameDef::canTntDestroyBlocks(const(void))
        }

        private void DisabledKillBarriersToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02C7DD38, off, on,
                DisabledKillBarriers.Checked); //MasterGameMode::IsInKillBox((boost::shared_ptr__tm__8_6Entity))
        }

        private void AntiEndGameToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02C9554C, off, on, AntiEndGame.Checked); //MasterGameMode::CanEndPostGame((void))
        }

        private void TumbleHUDToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02E3A950, off, 0x57E3063E, TumbleHUD.Checked); //UIScene_HUD::HideMainHUD((void))
            GeckoU.WriteUIntToggle(0x02C57EBC, off, 0x8863012A,
                TumbleHUD.Checked); //MiniGameDef::LockedInventory(const(void))
        }

        private void HostOptionsToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x02F17714, 0x38807D00, 0x388303F4,
                HostOptions.Checked); //CMinecraftApp::SetGameHostOption((eGameHostOption, unsigned int))
        }

        private void DisablePermanentKicksToggled(object sender, EventArgs e)
        {
            GeckoU.WriteUIntToggle(0x0340D428, blr, mflr,
                DisablePermanentKicks.Checked); //CProfile::QuadrantOfflineXUID((int))
        }

        private void EnchantmentLevelSliderChanged(object sender, EventArgs e)
        {
            GeckoU.WriteUInt(0x022F4900, GeckoU.Mix(0x38600000, EnchantmentLevelSlider.Value)); //getenchentmentslevel
        }

        private void JumpHeightSliderChanged(object sender, EventArgs e)
        {
            GeckoU.WriteFloat(0x1066A7CC, (float)JumpHeightSlider.Value);
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
            GeckoU.WriteUInt(0x02D6EE14, GeckoU.Mix(0x38600000, GlideRingScoreSlider.Value)); //ScoreRingRuleDefinition::getPointValue((void))
            GeckoU.WriteUInt(0x02D6EE1C, GeckoU.Mix(0x38600000, GlideRingScoreSlider.Value));
            GeckoU.WriteUInt(0x02D6EE24, GeckoU.Mix(0x38600000, GlideRingScoreSlider.Value));
        }

        private void VisibleHitboxesToggled(object sender, EventArgs e)
        {
            uint whiteBoxAddress = GeckoU.PeekUInt(GeckoU.PeekUInt(0x10A72A94) + 0xC0);
            GeckoU.WriteUIntToggle(whiteBoxAddress += 0x90, 0x0001F000, 0x000100000, VisibleHitboxes.Checked);
        }

        private void EndGameClicked(object sender, EventArgs e)
        {
            GeckoU.WriteUInt(0x02C93A90, blr);
            GeckoU.WriteUInt(0x02C93A90, mflr);
        }

        private void ExitGameClicked(object sender, EventArgs e)
        {
            DialogResult confirmCG =
                Messaging.Show("You're about to close the game, continue?", MessageBoxButtons.YesNo);

            if (confirmCG == DialogResult.Yes)
            {
                GeckoU.CallFunction64(0x02F50028, 0x00000000); //CConsoleMinecraftApp::ExitGame((void))
            }
        }

        #endregion memory editing
    }
}