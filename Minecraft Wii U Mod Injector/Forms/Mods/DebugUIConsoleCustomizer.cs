using System;
using System.Collections.Generic;
using System.Text;
using MetroFramework.Controls;
using System.Windows.Forms;
using Minecraft_Wii_U_Mod_Injector.Helpers;
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
            DiscordRpc.SetPresence("Connected", "Debug UI Customizer");
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
            DiscordRpc.SetPresence("Connected", new MainForm().MainTabs.SelectedTab.Text + " Tab");
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
            MainForm.GeckoU.WriteBytes(MainForm.GeckoU.PeekUInt(debugRenderNode + 0x10) + 0x3f, new[] { (byte)AlphaSlider.Value });
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

        private Dictionary<string,object> getRenderNodedata(uint node_ptr)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            byte[] node_data = MainForm.GeckoU.ReadBytes(node_ptr, 0xe4);
            data["flags"] = ByteSwap.Swap(BitConverter.ToUInt32(node_data, 0)) ;
            data["FuiObjectPointer"] = ByteSwap.Swap(BitConverter.ToUInt32(node_data,0x10));
            // fuiMatrix readonly :/
            Array.Reverse(node_data, 0x30, 0x18);
            data["width"] = BitConverter.ToSingle(node_data, 0x44);
            data["height"] = BitConverter.ToSingle(node_data, 0x38);
            data["X"] = BitConverter.ToSingle(node_data, 0x34);
            data["Y"] = BitConverter.ToSingle(node_data, 0x30);
            data["name"] = Encoding.UTF8.GetString(node_data, 0x7c, 0x40);
            data["fjFuiNodePointer"] = ByteSwap.Swap(BitConverter.ToUInt32(node_data, 0xdc));
            return data;
        }

        private void ListStringsBtn_Click(object sender, EventArgs e)
        {
            var Btn = (MetroButton)sender;
            try
            {
                Btn.Text = @"Gathering...";
                Btn.Enabled = false;

                DebugUIStringsListView.Clear();
                uint start,max;
                int elementCount = MCVectorFunctions.GetVectorSize(debugUI_ptr + 0x8c, 4, out start, out _, out max);
                for (uint i = 0; i < elementCount; i++)
                {
                    uint rendernode_ptr = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(start + i * 4)+0x2c);
                    uint fj_fuinode_ptr = MainForm.GeckoU.PeekUInt(rendernode_ptr + 0xdc);
                    uint textfield_ptr = MainForm.GeckoU.CallFunction(0x02b03708, fj_fuinode_ptr);
                    if (textfield_ptr == 0)
                    {
                        MessageBox.Show("No Text Field returned!");
                        continue;
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
            uint fuiRenderNodeEditText_ptr = uint.Parse(e.Item.SubItems[1].Text);
            var info_data = getRenderNodedata(fuiRenderNodeEditText_ptr);
            UIControl_LabelInfo.Text = $"X: {info_data["X"]}\nY: {info_data["Y"]}";
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
            MainForm.GeckoU.CallFunction(0x02BB7E34, fuiRenderNodeEditText_ptr, wstr_ptr);
            MainForm.GeckoU.free(tmp_mem);
        }

        private void setPosition(object sender, EventArgs e) {
            uint fuiRenderNodeEditText_ptr = uint.Parse(DebugUIStringsListView.SelectedItems[0].SubItems[1].Text);
            uint x = BitConverter.ToUInt32(BitConverter.GetBytes(Convert.ToSingle(numericUpDown1.Value)), 0);
            uint y = BitConverter.ToUInt32(BitConverter.GetBytes(Convert.ToSingle(numericUpDown2.Value)), 0);
            MainForm.GeckoU.CallFunction(0x02BB859C, fuiRenderNodeEditText_ptr, x);
            MainForm.GeckoU.CallFunction(0x02BB8618, fuiRenderNodeEditText_ptr, y);
        }
    }
}
