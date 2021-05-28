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
            this.appIco = new MetroFramework.Controls.MetroPanel();
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
            // appIco
            // 
            this.appIco.BackColor = System.Drawing.Color.Transparent;
            this.appIco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("appIco.BackgroundImage")));
            this.appIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.appIco.HorizontalScrollbarBarColor = true;
            this.appIco.HorizontalScrollbarHighlightOnWheel = false;
            this.appIco.HorizontalScrollbarSize = 10;
            this.appIco.Location = new System.Drawing.Point(382, 35);
            this.appIco.Name = "appIco";
            this.appIco.Size = new System.Drawing.Size(255, 245);
            this.appIco.TabIndex = 45;
            this.appIco.VerticalScrollbarBarColor = true;
            this.appIco.VerticalScrollbarHighlightOnWheel = false;
            this.appIco.VerticalScrollbarSize = 10;
            // 
            // vylrynaCredits
            // 
            this.vylrynaCredits.AutoSize = true;
            this.vylrynaCredits.Location = new System.Drawing.Point(23, 223);
            this.vylrynaCredits.Name = "vylrynaCredits";
            this.vylrynaCredits.Size = new System.Drawing.Size(339, 57);
            this.vylrynaCredits.TabIndex = 46;
            this.vylrynaCredits.Text = "vylryna: \r\n- Creating a handful of mods (most notably, commands)\r\n- Helping me un" +
    "derstand how commands work";
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 288);
            this.Controls.Add(this.vylrynaCredits);
            this.Controls.Add(this.appIco);
            this.Controls.Add(this.bullywiiplazaCredits);
            this.Controls.Add(this.kashiieraCredits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Credits";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Credits";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleManager;
        private MetroFramework.Controls.MetroLabel kashiieraCredits;
        private MetroFramework.Controls.MetroLabel bullywiiplazaCredits;
        private MetroFramework.Controls.MetroPanel appIco;
        private MetroFramework.Controls.MetroLabel vylrynaCredits;
    }
}