namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.kashiieraCredits = new MetroFramework.Controls.MetroLabel();
            this.bullywiiplazaCredits = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.vylrynaCredits = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            // 
            // kashiieraCredits
            // 
            this.kashiieraCredits.AutoSize = true;
            this.kashiieraCredits.Location = new System.Drawing.Point(23, 60);
            this.kashiieraCredits.Name = "kashiieraCredits";
            this.kashiieraCredits.Size = new System.Drawing.Size(353, 57);
            this.kashiieraCredits.TabIndex = 0;
            this.kashiieraCredits.Text = "Kashiiera AKA Sloth@WiiPlaza: \r\n- Creating/Programming the Minecraft Wii U Mod In" +
    "jector\r\n- Creating most mods";
            // 
            // bullywiiplazaCredits
            // 
            this.bullywiiplazaCredits.AutoSize = true;
            this.bullywiiplazaCredits.Location = new System.Drawing.Point(23, 132);
            this.bullywiiplazaCredits.Name = "bullywiiplazaCredits";
            this.bullywiiplazaCredits.Size = new System.Drawing.Size(259, 76);
            this.bullywiiplazaCredits.TabIndex = 2;
            this.bullywiiplazaCredits.Text = "Bully@WiiPlaza: \r\n- Help with late development\r\n- Creating some mods\r\n- Hosting t" +
    "he Minecraft Wii U Mod Injector";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(382, 35);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(255, 245);
            this.metroPanel1.TabIndex = 45;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // vylrynaCredits
            // 
            this.vylrynaCredits.AutoSize = true;
            this.vylrynaCredits.Location = new System.Drawing.Point(23, 223);
            this.vylrynaCredits.Name = "vylrynaCredits";
            this.vylrynaCredits.Size = new System.Drawing.Size(339, 38);
            this.vylrynaCredits.TabIndex = 46;
            this.vylrynaCredits.Text = "vylryna: \r\n- Creating a handful of mods (most notably, commands)";
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 288);
            this.Controls.Add(this.vylrynaCredits);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.bullywiiplazaCredits);
            this.Controls.Add(this.kashiieraCredits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Credits";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Credits";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exiting);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleManager;
        private MetroFramework.Controls.MetroLabel kashiieraCredits;
        private MetroFramework.Controls.MetroLabel bullywiiplazaCredits;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel vylrynaCredits;
    }
}