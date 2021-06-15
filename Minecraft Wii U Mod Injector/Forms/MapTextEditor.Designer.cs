namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    partial class MapTextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapTextEditor));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MapText = new MetroFramework.Controls.MetroTextBox();
            this.SetMapText = new MetroFramework.Controls.MetroButton();
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.variablesBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Map Text:";
            // 
            // MapText
            // 
            // 
            // 
            // 
            this.MapText.CustomButton.Image = null;
            this.MapText.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.MapText.CustomButton.Name = "";
            this.MapText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MapText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MapText.CustomButton.TabIndex = 1;
            this.MapText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MapText.CustomButton.UseSelectable = true;
            this.MapText.CustomButton.Visible = false;
            this.MapText.Lines = new string[0];
            this.MapText.Location = new System.Drawing.Point(92, 70);
            this.MapText.MaxLength = 18;
            this.MapText.Name = "MapText";
            this.MapText.PasswordChar = '\0';
            this.MapText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MapText.SelectedText = "";
            this.MapText.SelectionLength = 0;
            this.MapText.SelectionStart = 0;
            this.MapText.ShortcutsEnabled = true;
            this.MapText.Size = new System.Drawing.Size(459, 23);
            this.MapText.TabIndex = 1;
            this.MapText.UseSelectable = true;
            this.MapText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MapText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SetMapText
            // 
            this.SetMapText.Location = new System.Drawing.Point(92, 99);
            this.SetMapText.Name = "SetMapText";
            this.SetMapText.Size = new System.Drawing.Size(358, 23);
            this.SetMapText.TabIndex = 2;
            this.SetMapText.Text = "Set";
            this.SetMapText.UseSelectable = true;
            this.SetMapText.Click += new System.EventHandler(this.SetMapTextClicked);
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            // 
            // variablesBtn
            // 
            this.variablesBtn.Location = new System.Drawing.Point(456, 99);
            this.variablesBtn.Name = "variablesBtn";
            this.variablesBtn.Size = new System.Drawing.Size(95, 23);
            this.variablesBtn.TabIndex = 3;
            this.variablesBtn.Text = "Variables";
            this.variablesBtn.UseSelectable = true;
            this.variablesBtn.Click += new System.EventHandler(this.VariablesBtnClicked);
            // 
            // MapTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 133);
            this.Controls.Add(this.variablesBtn);
            this.Controls.Add(this.SetMapText);
            this.Controls.Add(this.MapText);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MapTextEditor";
            this.Resizable = false;
            this.Text = "Minecraft: Wii U Mod Injector - Map Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exiting);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox MapText;
        private MetroFramework.Controls.MetroButton SetMapText;
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Controls.MetroButton variablesBtn;
    }
}