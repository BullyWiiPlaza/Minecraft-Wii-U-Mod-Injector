namespace Minecraft_Wii_U_Mod_Injector.Forms.Mods
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
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MapText
            // 
            resources.ApplyResources(this.MapText, "MapText");
            this.MapText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MapText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.MapText.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.MapText.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.MapText.CustomButton.Name = "";
            this.MapText.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.MapText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MapText.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.MapText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MapText.CustomButton.UseSelectable = true;
            this.MapText.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.MapText.Lines = new string[0];
            this.MapText.MaxLength = 19;
            this.MapText.Name = "MapText";
            this.MapText.PasswordChar = '\0';
            this.MapText.PromptText = "X: %d, Y: %d, Z: %d";
            this.MapText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MapText.SelectedText = "";
            this.MapText.SelectionLength = 0;
            this.MapText.SelectionStart = 0;
            this.MapText.ShortcutsEnabled = true;
            this.MapText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MapText.UseSelectable = true;
            this.MapText.WaterMark = "X: %d, Y: %d, Z: %d";
            this.MapText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MapText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SetMapText
            // 
            resources.ApplyResources(this.SetMapText, "SetMapText");
            this.SetMapText.Name = "SetMapText";
            this.SetMapText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SetMapText.UseSelectable = true;
            this.SetMapText.Click += new System.EventHandler(this.SetMapTextClicked);
            // 
            // StyleMngr
            // 
            this.StyleMngr.Owner = this;
            this.StyleMngr.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // variablesBtn
            // 
            resources.ApplyResources(this.variablesBtn, "variablesBtn");
            this.variablesBtn.Name = "variablesBtn";
            this.variablesBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.variablesBtn.UseSelectable = true;
            this.variablesBtn.Click += new System.EventHandler(this.VariablesBtnClicked);
            // 
            // MapTextEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.variablesBtn);
            this.Controls.Add(this.SetMapText);
            this.Controls.Add(this.MapText);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "MapTextEditor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
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