namespace Minecraft_Wii_U_Mod_Injector.Forms
{
    partial class FAQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAQ));
            this.StyleMngr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.kashiieraCredits = new MetroFramework.Controls.MetroLabel();
            this.appIco = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            // 
            // kashiieraCredits
            // 
            this.kashiieraCredits.AutoSize = true;
            this.kashiieraCredits.Location = new System.Drawing.Point(23, 60);
            this.kashiieraCredits.Name = "kashiieraCredits";
            this.kashiieraCredits.Size = new System.Drawing.Size(757, 266);
            this.kashiieraCredits.TabIndex = 0;
            this.kashiieraCredits.Text = resources.GetString("kashiieraCredits.Text");
            // 
            // appIco
            // 
            this.appIco.BackColor = System.Drawing.Color.Transparent;
            this.appIco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("appIco.BackgroundImage")));
            this.appIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.appIco.HorizontalScrollbarBarColor = true;
            this.appIco.HorizontalScrollbarHighlightOnWheel = false;
            this.appIco.HorizontalScrollbarSize = 10;
            this.appIco.Location = new System.Drawing.Point(774, 37);
            this.appIco.Name = "appIco";
            this.appIco.Size = new System.Drawing.Size(255, 289);
            this.appIco.TabIndex = 45;
            this.appIco.VerticalScrollbarBarColor = true;
            this.appIco.VerticalScrollbarHighlightOnWheel = false;
            this.appIco.VerticalScrollbarSize = 10;
            // 
            // FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 338);
            this.Controls.Add(this.appIco);
            this.Controls.Add(this.kashiieraCredits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FAQ";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Frequently Asked Questions";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.StyleMngr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleMngr;
        private MetroFramework.Controls.MetroLabel kashiieraCredits;
        private MetroFramework.Controls.MetroPanel appIco;
    }
}