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
            this.bullywiiplazaCredits = new MetroFramework.Controls.MetroLabel();
            this.appIco = new MetroFramework.Controls.MetroPanel();
            this.vylrynaCredits = new MetroFramework.Controls.MetroLabel();
            this.nessieHaxCredits = new MetroFramework.Controls.MetroLabel();
            this.slothWiiPlazaCredits = new MetroFramework.Controls.MetroLink();
            this.kashiieraCredits = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            this.StyleMngr.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.bullywiiplazaCredits.Click += new System.EventHandler(this.BullyClicked);
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
            this.appIco.Size = new System.Drawing.Size(255, 379);
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
            this.vylrynaCredits.Click += new System.EventHandler(this.VylrynaClicked);
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
            // slothWiiPlazaCredits
            // 
            this.slothWiiPlazaCredits.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.slothWiiPlazaCredits.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.slothWiiPlazaCredits.Location = new System.Drawing.Point(23, 60);
            this.slothWiiPlazaCredits.Name = "slothWiiPlazaCredits";
            this.slothWiiPlazaCredits.Size = new System.Drawing.Size(353, 57);
            this.slothWiiPlazaCredits.TabIndex = 48;
            this.slothWiiPlazaCredits.Text = "SlothWiiPlaza: \r\n- Creating/Programming the Minecraft Wii U Mod Injector\r\n- Creat" +
    "ing most mods";
            this.slothWiiPlazaCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slothWiiPlazaCredits.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.slothWiiPlazaCredits.UseSelectable = true;
            this.slothWiiPlazaCredits.Click += new System.EventHandler(this.SlothWiiPlazaClicked);
            // 
            // kashiieraCredits
            // 
            this.kashiieraCredits.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.kashiieraCredits.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.kashiieraCredits.Location = new System.Drawing.Point(23, 356);
            this.kashiieraCredits.Name = "kashiieraCredits";
            this.kashiieraCredits.Size = new System.Drawing.Size(353, 57);
            this.kashiieraCredits.TabIndex = 49;
            this.kashiieraCredits.Text = "Kashiiera:\r\n- Help with development\r\n- Support for the Cemu emulator\r\n";
            this.kashiieraCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kashiieraCredits.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.kashiieraCredits.UseSelectable = true;
            this.kashiieraCredits.Click += new System.EventHandler(this.KashiieraClicked);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 437);
            this.Controls.Add(this.kashiieraCredits);
            this.Controls.Add(this.slothWiiPlazaCredits);
            this.Controls.Add(this.nessieHaxCredits);
            this.Controls.Add(this.vylrynaCredits);
            this.Controls.Add(this.bullywiiplazaCredits);
            this.Controls.Add(this.appIco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Credits";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Minecraft: Wii U Mod Injector - Credits";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exiting);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Controls.MetroLabel bullywiiplazaCredits;
        private MetroFramework.Controls.MetroPanel appIco;
        private MetroFramework.Controls.MetroLabel vylrynaCredits;
        private MetroFramework.Controls.MetroLabel nessieHaxCredits;
        private MetroFramework.Controls.MetroLink slothWiiPlazaCredits;
        private MetroFramework.Controls.MetroLink kashiieraCredits;
    }
}