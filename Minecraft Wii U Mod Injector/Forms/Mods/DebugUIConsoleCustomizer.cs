using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
using Minecraft_Wii_U_Mod_Injector.Helpers.Files;
using Minecraft_Wii_U_Mod_Injector.Wii_U.Gecko_U;
using Minecraft_Wii_U_Mod_Injector.Wii_U.Minecraft;

namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
{
    public partial class DebugUIConsoleCustomizer : MetroFramework.Forms.MetroForm
    {
        public DebugUIConsoleCustomizer(MainForm form)
        {
            InitializeComponent();
            StyleMngr.Style = Style = form.StyleMngr.Style;
            StyleMngr.Theme = Theme = form.StyleMngr.Theme;
        }
        private uint debugRenderNode = 0;
        private uint debugUI_ptr = 0;

        private void OnLoad(object sender, EventArgs e)
        {
            debugUI_ptr = MainForm.GeckoU.PeekUInt(0x109F95E4);
            //if (debugUI_ptr == 0) return;
            DiscordRp.SetPresence("Connected", "Debug UI Customizer");
            var screenSize = MainForm.GeckoU.ReadBytes(MainForm.GeckoU.PeekUInt(0x109F75A8)+0x294,8);
            Array.Reverse(screenSize);
            float screenWidth = BitConverter.ToSingle(screenSize, 4), screenHeight = BitConverter.ToSingle(screenSize, 0);
            ResolutionLabel.Text += $"{screenWidth}x{screenHeight}";
            uint fuiFile_ptr = MainForm.GeckoU.PeekUInt(debugUI_ptr + 0x20);
            debugRenderNode =  MainForm.GeckoU.PeekUInt(fuiFile_ptr + 0xe0);
            var value = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(debugRenderNode + 0x10) + 0x3c);
            AlphaSlider.Value = ((int)value&0xff);
        }

        private void OnExit(object sender, FormClosingEventArgs e)
        {
            DiscordRp.SetPresence("Connected", new MainForm().MainTabs.SelectedTab.Text + " tab");
            Dispose();
        }

        private void setBGColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            var res = color.ShowDialog();
            if (res == DialogResult.OK)
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(debugRenderNode+0x10)+0x3c, (uint)(color.Color.ToArgb() << 8) | (uint)AlphaSlider.Value);
        }

        private void AlphaSlider_ValueChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteBytes(MainForm.GeckoU.PeekUInt(debugRenderNode + 0x10) + 0x3f, new byte[] { (byte)AlphaSlider.Value });
        }

        private string getString(uint wstring_ptr)
        {
            byte[] data = MainForm.GeckoU.ReadBytes(wstring_ptr, 0x20);
            uint length = ByteSwap.Swap(BitConverter.ToUInt32(data, 0x18));
            uint capacity = ByteSwap.Swap(BitConverter.ToUInt32(data, 0x1c));
            if (capacity > 7)
            {
                uint wchar_ptr = ByteSwap.Swap(BitConverter.ToUInt32(data, 0x14));
                return MainForm.GeckoU.PeekString16((int)length, wchar_ptr);
            }
            return Encoding.BigEndianUnicode.GetString(data, 4, (int)length * 2);
        }

        private void ListStringsBtn_Click(object sender, EventArgs e)
        {
            var Btn = (MetroButton)sender;
            try
            {
                Btn.Text = @"Gathering...";
                Btn.Enabled = false;

                DebugUIStringsListView.Clear();
                uint start;
                uint elementCount = MCVectorFunctions.GetVectorSize(debugUI_ptr + 0x8c, 4, out start, out _, out _);
                for (uint i = 0; i < elementCount; i++)
                {
                    uint rendernode_ptr = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(start + i * 4)+0x2c);
                    uint fj_fuinode_ptr = MainForm.GeckoU.PeekUInt(rendernode_ptr + 0xdc);
                    uint textfield_ptr = MainForm.GeckoU.CallFunction(0x02b03708, fj_fuinode_ptr);
                    if (textfield_ptr == 0)
                    {
                        MessageBox.Show("No Text Field returned !!");
                        return;
                    }
                    uint wstr_ptr = textfield_ptr + 0x114;
                    DebugUIStringsListView.Items.Add(getString(wstr_ptr)).SubItems.Add(textfield_ptr.ToString());
                }
                Btn.Text = @"List Strings";
                Btn.Enabled = true;
            }
            catch (Exception exception)
            {
                Exceptions.LogError(exception, "Failed to list Debug UI Strings", true);
                Btn.Text = @"List Strings";
                Btn.Enabled = true;
            }
        }

        private void DebugUIStringsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedStringTextBox.Text = e.Item.Text;
            selectedStringTextBox.Enabled = true;
            setStringBtn.Enabled = true;
        }

        private void setStringBtn_Click(object sender, EventArgs e)
        {
            uint fuiRenderNodeEditText_ptr = uint.Parse(DebugUIStringsListView.SelectedItems[0].SubItems[1].Text);
            DebugUIStringsListView.SelectedItems[0].Text = selectedStringTextBox.Text;
            uint wstr_ptr = fuiRenderNodeEditText_ptr + 0x114;
            string text = selectedStringTextBox.Text + "\x00";
            uint tmp_mem = MainForm.GeckoU.malloc((uint)text.Length * 2 +1);
            MainForm.GeckoU.ClearString(tmp_mem, text.Length*2);
            MainForm.GeckoU.WriteString16(tmp_mem, text);
            MainForm.GeckoU.CallFunction(0x2b5f8b0, wstr_ptr, tmp_mem); // std::wstring::allocator<wchar_t>
            MainForm.GeckoU.CallFunction(0x02bb7cf0, fuiRenderNodeEditText_ptr, wstr_ptr);
            MainForm.GeckoU.free(tmp_mem);
        }
    }
}
