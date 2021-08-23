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
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.kashiieraCredits = new MetroFramework.Controls.MetroLabel();
            this.bullywiiplazaCredits = new MetroFramework.Controls.MetroLabel();
            this.appIco = new MetroFramework.Controls.MetroPanel();
            this.vylrynaCredits = new MetroFramework.Controls.MetroLabel();
            this.nessieHaxCredits = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            this.StyleMngr.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.kashiieraCredits.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // bullywiiplazaCredits
            // 
            this.bullywiiplazaCredits.AutoSize = true;
            this.bullywiiplazaCredits.Location = new System.Drawing.Point(23, 132);
            this.bullywiiplazaCredits.Name = "bullywiiplazaCredits";
            this.bullywiiplazaCredits.Size = new System.Drawing.Size(179, 57);
            this.bullywiiplazaCredits.TabIndex = 2;
            this.bullywiiplazaCredits.Text = "Bully@WiiPlaza: \r\n- Help with late development\r\n- Creating some mods";
            this.bullywiiplazaCredits.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // appIco
            // 
            this.appIco.BackColor = System.Drawing.Color.Transparent;
            this.appIco.BackgroundImage = global::Minecraft_Wii_U_Mod_Injector.Properties.Resources.MinecraftWiiUModInjector;
            this.appIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appIco.HorizontalScrollbarBarColor = true;
            this.appIco.HorizontalScrollbarHighlightOnWheel = false;
            this.appIco.HorizontalScrollbarSize = 10;
            this.appIco.Location = new System.Drawing.Point(443, 35);
            this.appIco.Name = "appIco";
            this.appIco.Size = new System.Drawing.Size(255, 311);
            this.appIco.TabIndex = 45;
            this.appIco.VerticalScrollbarBarColor = true;
            this.appIco.VerticalScrollbarHighlightOnWheel = false;
            this.appIco.VerticalScrollbarSize = 10;
            // 
            // vylrynaCredits
            // 
            this.vylrynaCredits.AutoSize = true;
            this.vylrynaCredits.Location = new System.Drawing.Point(23, 210);
            this.vylrynaCredits.Name = "vylrynaCredits";
            this.vylrynaCredits.Size = new System.Drawing.Size(339, 76);
            this.vylrynaCredits.TabIndex = 46;
            this.vylrynaCredits.Text = "vylryna: \r\n- Help with development\r\n- Creating a handful of mods (most notably, c" +
    "ommands)\r\n- Helping me understand how commands work";
            this.vylrynaCredits.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // nessieHaxCredits
            // 
            this.nessieHaxCredits.AutoSize = true;
            this.nessieHaxCredits.Location = new System.Drawing.Point(23, 302);
            this.nessieHaxCredits.Name = "nessieHaxCredits";
            this.nessieHaxCredits.Size = new System.Drawing.Size(154, 38);
            this.nessieHaxCredits.TabIndex = 47;
            this.nessieHaxCredits.Text = "NessieHax: \r\n- Help with development";
            this.nessieHaxCredits.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 369);
            this.Controls.Add(this.nessieHaxCredits);
            this.Controls.Add(this.vylrynaCredits);
            this.Controls.Add(this.bullywiiplazaCredits);
            this.Controls.Add(this.kashiieraCredits);
            this.Controls.Add(this.appIco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Credits";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Minecraft: Wii U Mod Injector - Credits";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Controls.MetroLabel kashiieraCredits;
        private MetroFramework.Controls.MetroLabel bullywiiplazaCredits;
        private MetroFramework.Controls.MetroPanel appIco;
        private MetroFramework.Controls.MetroLabel vylrynaCredits;
        private MetroFramework.Controls.MetroLabel nessieHaxCredits;
    }
}