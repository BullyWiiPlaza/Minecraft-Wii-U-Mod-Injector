using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    public partial class WorldGenerationEditor : MetroForm
    {
        private bool _pastWrldLimit;
        private bool _changedWrldLimit;
        public WorldGenerationEditor(MainForm injector)
        {
            InitializeComponent();
            StyleMngr.Style = Style = injector.StyleMngr.Style;
            StyleMngr.Theme = Theme = injector.StyleMngr.Theme;
        }

        private void Init(object sender, EventArgs e)
        {
            DiscordRpc.SetPresence("Connected", "World Generation Editor");
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRpc.SetPresence("Connected", new MainForm().MainTabs.SelectedTab.Text + " Tab");
            Dispose();
        }

        private void IncreasedBuriedTreasureSpawnToggled(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02190808, MainForm.On, 0x7FE3FB78, IncreasedBuriedTreasureSpawn.Checked);
        }

        private void IncreasedMineshaftSpawnToggled(object sender, EventArgs e)
        {
           MainForm.GeckoU.WriteUIntToggle(0x02190808, 0x3B600001, 0x3B600000, IncreasedMineshaftSpawn.Checked);
        }

        private void IncreasedOceanMonumentSpawnToggled(object sender, EventArgs e)
        {
           MainForm.GeckoU.WriteUIntToggle(0x026DF2F4,MainForm.On, 0x7FE3FB78, IncreasedOceanMonumentSpawn.Checked);
           MainForm.GeckoU.WriteUIntToggle(0x026DF30C,MainForm.On,MainForm.Off, IncreasedOceanMonumentSpawn.Checked);
        }

        private void IncreasedOceanRuinsSpawnToggled(object sender, EventArgs e)
        {
           MainForm.GeckoU.WriteUIntToggle(0x0274EEC4,MainForm.On,MainForm.Off, IncreasedOceanRuinsSpawn.Checked);
        }

        private void IncreasedStructuresSpawnToggled(object sender, EventArgs e)
        {
           MainForm.GeckoU.WriteUIntToggle(0x02832C84,MainForm.On,MainForm.Off, IncreasedStructuresSpawn.Checked);
        }

        private void IncreasedShipwreckSpawnToggled(object sender, EventArgs e)
        {
           MainForm.GeckoU.WriteUIntToggle(0x02896394, MainForm.On, 0x7FE3FB78, IncreasedShipwreckSpawn.Checked);
           MainForm.GeckoU.WriteUIntToggle(0x02895824, MainForm.On,MainForm.Off, IncreasedShipwreckSpawn.Checked);
        }

        private void IncreasedStrongholdSpawnToggled(object sender, EventArgs e)
        {
           MainForm.GeckoU.WriteUIntToggle(0x029651E0, MainForm.On,MainForm.Off, IncreasedStrongholdSpawn.Checked);
        }

        private void IncreasedVillageSpawnToggled(object sender, EventArgs e)
        {
           MainForm.GeckoU.WriteUIntToggle(0x02A8CD34, MainForm.On,MainForm.Off, IncreasedVillageSpawn.Checked);
        }

        private void IncreasedWoodlandMansionSpawnToggled(object sender, EventArgs e)
        {
           MainForm.GeckoU.WriteUIntToggle(0x02AB9CB4, MainForm.On, 0x7FC3F378, IncreasedWoodlandMansionSpawn.Checked);
           MainForm.GeckoU.WriteUIntToggle(0x02AB9CCC, MainForm.On, MainForm.Off, IncreasedWoodlandMansionSpawn.Checked);
        }

        private void GeneratePlainWorldToggled(object sender, EventArgs e)
        {
           MainForm.GeckoU.WriteUIntToggle(0x0214DB38, MainForm.Blr, 0x9421FD80,
                GeneratePlainWorld.Checked);
        }

        private void FreezingWorldToggled(object sender, EventArgs e)
        {
           MainForm.GeckoU.WriteUIntToggle(0x0253C71C, MainForm.On,MainForm.Off,
                FreezingWorld.Checked);
        }

        private void GenerateAmplifiedWorldToggled(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x11020000, 0x40000000, 0x00000000, GenerateAmplifiedWorld.Checked); // Write the float to a unused address
            MainForm.GeckoU.WriteUIntToggle(0x026D3E08, 0x3D001102, 0x3D001066, GenerateAmplifiedWorld.Checked);  // lis r8,0x1102 Loads the address into memory
            MainForm.GeckoU.WriteUIntToggle(0x026D3E10, 0xC0C80000, 0xC3E85EF4, GenerateAmplifiedWorld.Checked); // lfs f6,0x0(r8) Overwrites the float with our address
        }

        private void WorldSizeSliderChanged(object sender, EventArgs e)
        {
            if (!_changedWrldLimit)
            {
                _changedWrldLimit = true;
                Messaging.Show("Going below/above the default 54x54 chunks will remove/generate chunks and will be saved but you will need to use this mod (with the same size set) to keep newly generated" +
                               "chunks which were previously not accessible. Otherwise, they'll be overwritten by empty chunks and you'll lose everything you've done in them.");

                return;
            }

            if (WorldSizeSlider.Value > 64 && !_pastWrldLimit)
            {
                _pastWrldLimit = true;
                Messaging.Show("Going beyond 64x64 chunks (Small World Size on Xbox One and Playstation 4) can cause instability, visual issues, large file sizes and extremely long loading times. " +
                               "Consider staying at 64x64 chunks if you intend to play on this world for extended periods of time.");

                return;
            }

            MainForm.GeckoU.WriteUInt(0x025C2D98, MainForm.GeckoU.Mix(MainForm.Off, WorldSizeSlider.Value)); // Turns out I completely misunderstood this function.
                                                                                                                          // The actual world size is 0x36 (54x54 chunks), I want to look deeper into this
                                                                                                                          // and get world sizes working correctly on Wii U as it SHOULD be able to handle it.
                                                                                                                          // Increasing the size by 2 chunks up until 64 chunks seems to work fine but anything 
                                                                                                                          // beyond that and the world just seems to give up, chunks (old and new) won't load in
                                                                                                                          // and the world will take forever to load into to the point it'll disconnect you from
                                                                                                                          // the Nintendo Network. This might just be a limitation or there's a few functions that
                                                                                                                          // need changing to accomodate for dealing with bigger chunk counts.
                                                                                                                          // This would be a dream come true.
        }

        private void NetherSizeSliderChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(0x025C2DA0, MainForm.GeckoU.Mix(MainForm.Off, NetherSizeSlider.Value));
        }

        private void StoneWorldToggled(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02779F34, MainForm.Blr, 0x9421FF40, StoneWorld.Checked);
        }

        private void NoTerrainToggled(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x026D36DC, MainForm.Blr, 0x9421FDD0, NoTerrain.Checked);
        }
    }
}
