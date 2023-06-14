using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms;

namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    public partial class EntityEditor : MetroForm
    {
        private readonly Dictionary<string, uint> _Entities = new()
        {
            {"Cave Spider", 0x021CA3d0},
            {"Pufferfish", 0x028286B0},
            {"Silverfish", 0x02946C30},
            {"Wither", 0x02AACBD0},
            {"Enderdragon", 0x0238EB8C},
            {"Mooshroom", 0x0265E680},
            {"Zombie Horse", 0x02A4CD60},
            {"Tropical Fish", 0x02A55674},
            {"Elder Guardian", 0x022DE384},
            {"Skeleton Horse", 0x0294AB84},
            {"Iron Golem", 0x02A646C4},
            {"Wither Skeleton", 0x02A485DC},
            {"Zombie Villager", 0x02A3E070},
            {"Illusioner", 0x025108B4},
            {"Evoker", 0x023AB9A0},
            {"Vindicator", 0x02A475D0},
            {"Bat", 0x020A091C},
            {"Cow", 0x02276048},
            {"Mob", 0x02645104},
            {"Pig", 0x027598F0},
            {"Vex", 0x02A4454C},
            {"Boat", 0x021379DC},
            {"Fish", 0x023ABD18},
            {"Husk", 0x024E5ECC},
            {"Mule", 0x02667A30},
            {"Wolf", 0x02A81418},
            {"Arrow", 0x02061DF8},
            {"Blaze", 0x0214A8B8},
            {"Ghast", 0x02457BA0},
            {"Giant", 0x0245AC30},
            {"Golem", 0x024480DC},
            {"Horse", 0x02505A5C},
            {"Llama", 0x025E0818},
            {"Sheep", 0x0287F8B8},
            {"Slime", 0x02940310},
            {"Squid", 0x0294F858},
            {"Stray", 0x029450DC},
            {"Witch", 0x02A420B4},
            {"Animal", 0x02013DF4},
            {"Donkey", 0x022D0C18},
            {"Entity", 0x02329E64},
            {"Ocelot", 0x0275E38C},
            {"Parrot", 0x02787C14},
            {"Rabbit", 0x0282A398},
            {"Salmon", 0x028534C0},
            {"Spider", 0x02944714},
            {"Turtle", 0x02A31108},
            {"Zombie", 0x02A3A914},
            {"Chicken", 0x021BA8F4},
            {"Creeper", 0x022728B0},
            {"Dolphin", 0x022D27C4},
            {"Drowned", 0x022DEEB0},
            {"Monster", 0x02696154},
            {"Phantom", 0x0278CF38},
            {"Shulker", 0x028bC7B8},
            {"Snow Golem", 0x02951478},
            {"Enderman", 0x023ABAA4},
            {"Guardian", 0x0245AF70},
            {"Skeleton", 0x0293F4A8},
            {"Villager", 0x02A4B90C},
            {"Endermite", 0x023ABBA0},
            {"Magma Cube", 0x025F06FC},
            {"Zombie Pigmen", 0x0275BD4C},
            {"Polar Bear", 0x0279482C},
        };

        public EntityEditor(MainForm injector)
        {
            InitializeComponent();
            StyleMngr.Style = Style = injector.StyleMngr.Style;
            StyleMngr.Theme = Theme = injector.StyleMngr.Theme;
        }

        private void Init(object sender, EventArgs e)
        {
            DiscordRpc.SetPresence("Connected", "Entity Editor");

            ReplaceEntity.DataSource = new BindingSource(_Entities, null);
            ReplaceEntity.DisplayMember = "Key";
            ReplaceEntity.ValueMember = "Value";

            WithEntity.DataSource = new BindingSource(_Entities, null);
            WithEntity.DisplayMember = "Key";
            WithEntity.ValueMember = "Value";
        }
        
        private void Exiting(object sender, FormClosingEventArgs e)
        {
            DiscordRpc.SetPresence("Connected", new MainForm().MainTabs.SelectedTab.Text + " Tab");
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

        // TODO: Revert Option
        private void ReplaceEntityBtn_Clicked(object sender, EventArgs e)
        {
            var offset = _Entities[ReplaceEntity.Text] - _Entities[WithEntity.Text];

            if (WithEntity.SelectedText == "Giant")
            {
                var giantFix = Messaging.Show("Would you also like to enable a fix which restores the \"Giant\" it's texture?", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (giantFix == DialogResult.Yes)
                {
                    // Replaces the Giant's texture location to the Zombie
                    MainForm.GeckoU.WriteLong(0x033CF6A0, 0x482B8C104E800020);
                }
            }

            if (_Entities[ReplaceEntity.Text] > _Entities[WithEntity.Text])
            {
                var offset_substracted = 0x1000000 - offset;
                MainForm.GeckoU.WriteUInt(_Entities[ReplaceEntity.Text], MainForm.GeckoU.Mix(0x4B000000, offset_substracted));
            }

            if (_Entities[ReplaceEntity.Text] < _Entities[WithEntity.Text])
            {
                offset = _Entities[WithEntity.Text] - _Entities[ReplaceEntity.Text];
                MainForm.GeckoU.WriteUInt(_Entities[ReplaceEntity.Text],
                    MainForm.GeckoU.Mix(0x48000000, offset));
            }

            MainForm.GeckoU.WriteUInt(_Entities[ReplaceEntity.Text] + 0x04, MainForm.Blr);
        }
    }
}
