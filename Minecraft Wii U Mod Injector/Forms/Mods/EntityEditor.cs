using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;

namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    public partial class EntityEditor : MetroForm
    {
        public EntityEditor(MainForm injector)
        {
            InitializeComponent();
            StyleMngr.Style = Style = injector.StyleMngr.Style;
            StyleMngr.Theme = Theme = injector.StyleMngr.Theme;
        }

        private void Init(object sender, EventArgs e)
        {
            DiscordRP.SetPresence("Connected", "Entity Editor");
        }
        
        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRP.SetPresence("Connected", new MainForm().MainTabs.SelectedTab.Text + " Tab");
            Dispose();
        }

        private void WoolMultiplierChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(0x02881168, MainForm.GeckoU.Mix(0x38800000, WoolMultiplier.Value));
        }

        private void DontLoseWoolBoxChecked(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02881154, 0x38800000, 0x38800001, DontLoseWoolBox.Checked);
        }

        private void ProfessionBoxChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(0x02A4BB10, MainForm.GeckoU.Mix(0x38800000, ProfessionBox.SelectedIndex));
        }

        private void LlamaVariantBoxChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(0x025E2F0C, MainForm.GeckoU.Mix(0x38800000, LlamaVariantBox.SelectedIndex));
        }

        private void ParrotVariantBoxChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(0x02787E28, MainForm.GeckoU.Mix(0x38800000, ParrotVariantBox.SelectedIndex));
        }

        private void RabbitVariantBoxChanged(object sender, EventArgs e)
        {
            if (RabbitVariantBox.SelectedIndex == 6)
            {
                MainForm.GeckoU.WriteUInt(0x0282DA34, 0x38800063);
                return;
            }

            MainForm.GeckoU.WriteUInt(0x0282DA34, MainForm.GeckoU.Mix(0x38800000, RabbitVariantBox.SelectedIndex));
        }

        private void BabyRateSliderChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(0x02A3F88C, MainForm.GeckoU.Mix(0x38800000, BabyRateSlider.Value));
        }
    }
}
