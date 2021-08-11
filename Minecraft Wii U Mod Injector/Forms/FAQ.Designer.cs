namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    partial class Faq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faq));
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.faqText = new MetroFramework.Controls.MetroLabel();
            this.appIco = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            // 
            // faqText
            // 
            this.faqText.AutoSize = true;
            this.faqText.Location = new System.Drawing.Point(23, 60);
            this.faqText.Name = "faqText";
            this.faqText.Size = new System.Drawing.Size(757, 323);
            this.faqText.TabIndex = 0;
            this.faqText.Text = resources.GetString("faqText.Text");
            // 
            // appIco
            // 
            this.appIco.BackColor = System.Drawing.Color.Transparent;
            this.appIco.BackgroundImage = global::Minecraft_Wii_U_Mod_Injector.Properties.Resources.MinecraftWiiUModInjector;
            this.appIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appIco.HorizontalScrollbarBarColor = true;
            this.appIco.HorizontalScrollbarHighlightOnWheel = false;
            this.appIco.HorizontalScrollbarSize = 10;
            this.appIco.Location = new System.Drawing.Point(786, 37);
            this.appIco.Name = "appIco";
            this.appIco.Size = new System.Drawing.Size(255, 338);
            this.appIco.TabIndex = 45;
            this.appIco.VerticalScrollbarBarColor = true;
            this.appIco.VerticalScrollbarHighlightOnWheel = false;
            this.appIco.VerticalScrollbarSize = 10;
            // 
            // Faq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 400);
            this.Controls.Add(this.appIco);
            this.Controls.Add(this.faqText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Faq";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Minecraft: Wii U Mod Injector - Frequently Asked Questions";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Controls.MetroLabel faqText;
        private MetroFramework.Controls.MetroPanel appIco;
    }
}