using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using System;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    public partial class EnchantmentEditor : MetroForm
    {
        public EnchantmentEditor(MainForm injector)
        {
            InitializeComponent();
            StyleMngr.Style = Style = injector.StyleMngr.Style;
            StyleMngr.Theme = Theme = injector.StyleMngr.Theme;
        }

        private void Init(object sender, EventArgs e)
        {
            DiscordRp.SetPresence("Connected", "Enchantment Editor");
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRp.SetPresence("Connected", new MainForm().MainTabs.SelectedTab.Text + " tab");
            Dispose();
        }

        private void FrostWalkerLvlSliderChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(0x022F4758, MainForm.GeckoU.Mix(0x38600000, FrostWalkerLvlSlider.Value));
        }

        private void DepthStriderLvlSliderChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteBytes(0x022F5860,
                new byte[]
                {
                    0x38, 0x60, 0x00, (byte) MainForm.GeckoU.Mix(0x00, DepthStriderLvlSlider.Value), 0x7D, 0x89, 0x03,
                    0xA6, 0x4E, 0x80, 0x00, 0x20
                });
        }

        private void EfficiencySliderChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteBytes(0x022F587C,
                new byte[]
                {
                    0x38, 0x60, 0x00, (byte) MainForm.GeckoU.Mix(0x00, EfficiencySlider.Value), 0x7D, 0x89, 0x03,
                    0xA6, 0x4E, 0x80, 0x00, 0x20
                });
        }

        private void FireAspectSliderChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteBytes(0x022F5828,
                new byte[]
                {
                    0x38, 0x60, 0x00, (byte) MainForm.GeckoU.Mix(0x00, FireAspectSlider.Value), 0x7D, 0x89, 0x03,
                    0xA6, 0x4E, 0x80, 0x00, 0x20
                });
        }

        private void LuckOfTheSeaSliderChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteBytes(0x022F5898,
                new byte[]
                {
                    0x38, 0x60, 0x00, (byte) MainForm.GeckoU.Mix(0x00, LuckOfTheSeaSlider.Value), 0x7D, 0x89, 0x03,
                    0xA6, 0x4E, 0x80, 0x00, 0x20
                });
        }

        private void LureSliderChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteBytes(0x022F58B4,
                new byte[]
                {
                    0x38, 0x60, 0x00, (byte) MainForm.GeckoU.Mix(0x00, LureSlider.Value), 0x7D, 0x89, 0x03,
                    0xA6, 0x4E, 0x80, 0x00, 0x20
                });
        }

        private void LootingSliderChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteBytes(0x022F58D0,
                new byte[]
                {
                    0x38, 0x60, 0x00, (byte) MainForm.GeckoU.Mix(0x00, LootingSlider.Value), 0x7D, 0x89, 0x03,
                    0xA6, 0x4E, 0x80, 0x00, 0x20
                });
        }

        private void KnockbackSliderChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteBytes(0x022F580C,
                new byte[]
                {
                    0x38, 0x60, 0x00, (byte) MainForm.GeckoU.Mix(0x00, KnockbackSlider.Value), 0x7D, 0x89, 0x03,
                    0xA6, 0x4E, 0x80, 0x00, 0x20
                });
        }

        private void RespirationSliderChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteBytes(0x022F5844,
                new byte[]
                {
                    0x38, 0x60, 0x00, (byte) MainForm.GeckoU.Mix(0x00, RespirationSlider.Value), 0x7D, 0x89, 0x03,
                    0xA6, 0x4E, 0x80, 0x00, 0x20
                });
        }

        private void BindingCurseBoxChecked(object sender, EventArgs e)
        {
            if (BindingCurseBox.Checked)
                MainForm.GeckoU.WriteBytes(0x022F5980,
                    new byte[]
                    {
                        0x38, 0x60, 0x00, 0x01, 0x7D, 0x89, 0x03,
                        0xA6, 0x4E, 0x80, 0x00, 0x20
                    });
            else
                MainForm.GeckoU.WriteBytes(0x022F5980,
                    new byte[]
                    {
                        0x38, 0x60, 0x00, 0x00, 0x7D, 0x89, 0x03,
                        0xA6, 0x4E, 0x80, 0x00, 0x20
                    });
        }

        private void VanishingCurseBoxChecked(object sender, EventArgs e)
        {
            if (VanishingCurseBox.Checked)
                MainForm.GeckoU.WriteBytes(0x022F59C4,
                    new byte[]
                    {
                        0x38, 0x60, 0x00, 0x01, 0x7D, 0x89, 0x03,
                        0xA6, 0x4E, 0x80, 0x00, 0x20
                    });
            else
                MainForm.GeckoU.WriteBytes(0x022F59C4,
                    new byte[]
                    {
                        0x38, 0x60, 0x00, 0x00, 0x7D, 0x89, 0x03,
                        0xA6, 0x4E, 0x80, 0x00, 0x20
                    });
        }

        private void AquaInfinityBoxChecked(object sender, EventArgs e)
        {
            if (AquaInfinityBox.Checked)
                MainForm.GeckoU.WriteBytes(0x022F58F8,
                    new byte[]
                    {
                        0x38, 0x60, 0x00, 0x01, 0x7D, 0x89, 0x03,
                        0xA6, 0x4E, 0x80, 0x00, 0x20
                    });
            else
                MainForm.GeckoU.WriteBytes(0x022F58F8,
                    new byte[]
                    {
                        0x38, 0x60, 0x00, 0x00, 0x7D, 0x89, 0x03,
                        0xA6, 0x4E, 0x80, 0x00, 0x20
                    });
        }

        private void ChannelingBoxChecked(object sender, EventArgs e)
        {
            if (ChannelingBox.Checked)
                MainForm.GeckoU.WriteBytes(0x022F5A08,
                    new byte[]
                    {
                        0x38, 0x60, 0x00, 0x01, 0x7D, 0x89, 0x03,
                        0xA6, 0x4E, 0x80, 0x00, 0x20
                    });
            else
                MainForm.GeckoU.WriteBytes(0x022F5A08,
                    new byte[]
                    {
                        0x38, 0x60, 0x00, 0x00, 0x7D, 0x89, 0x03,
                        0xA6, 0x4E, 0x80, 0x00, 0x20
                    });
        }
    }
}
