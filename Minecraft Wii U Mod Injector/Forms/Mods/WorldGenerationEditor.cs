using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    public partial class WorldGenerationEditor : MetroForm
    {
        public WorldGenerationEditor(MainForm injector)
        {
            InitializeComponent();
            StyleMngr.Style = Style = injector.StyleMngr.Style;
            StyleMngr.Theme = Theme = injector.StyleMngr.Theme;
        }

        private void Init(object sender, EventArgs e)
        {
            DiscordRP.SetPresence("Connected", "World Generation Editor");
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRP.SetPresence("Connected", new MainForm().MainTabs.SelectedTab.Text + " tab");
            Dispose();
        }

        private void WorldSizeBtnClicked(object sender, EventArgs e)
        {
            Messaging.Show("Changing the size of the world/nether works as follow:\nThe value you put in is multiplied by that value to determine how many chunks will be generated in your world.\n" +
                           "So if you want a 4 chunk world your value should be 2 as it will be multiplied by 2 which is 4 chunks.\n\nSaving a world with a custom size and reloading it without the " +
                           "Mod Injector will reset the world border to it's\noriginal size and generate/remove new chunks.");
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
           MainForm.GeckoU.WriteUIntToggle(0x106CB93C, 0x4000000, 0x3DCCCCCD, GenerateAmplifiedWorld.Checked);
        }

        private void WorldSizeSliderChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(0x025C2D98, MainForm.GeckoU.Mix(MainForm.Off, WorldSizeSlider.Value));
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
