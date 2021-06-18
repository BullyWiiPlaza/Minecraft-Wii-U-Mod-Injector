using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Minecraft_Wii_U_Mod_Injector.Helpers.Win_Forms
{
    public class FlexibleMessageBox
    {
        #region Public statics

        /// <summary>
        /// Defines the maximum width for all FlexibleMessageBox instances in percent of the working area.
        /// 
        /// Allowed values are 0.2 - 1.0 where: 
        /// 0.2 means:  The FlexibleMessageBox can be at most half as wide as the working area.
        /// 1.0 means:  The FlexibleMessageBox can be as wide as the working area.
        /// 
        /// Default is: 70% of the working area width.
        /// </summary>
        public static double MaxWidthFactor = 0.7;

        /// <summary>
        /// Defines the maximum height for all FlexibleMessageBox instances in percent of the working area.
        /// 
        /// Allowed values are 0.2 - 1.0 where: 
        /// 0.2 means:  The FlexibleMessageBox can be at most half as high as the working area.
        /// 1.0 means:  The FlexibleMessageBox can be as high as the working area.
        /// 
        /// Default is: 90% of the working area height.
        /// </summary>
        public static double MaxHeightFactor = 0.9;

        /// <summary>
        /// Defines the font for all FlexibleMessageBox instances.
        /// 
        /// Default is: SystemFonts.MessageBoxFont
        /// </summary>
        public static Font Font = SystemFonts.MessageBoxFont;

        #endregion

        #region Public show functions

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(string text)
        {
            return FlexibleMessageBoxForm.Show(null, text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text)
        {
            return FlexibleMessageBoxForm.Show(owner, text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(string text, string caption)
        {
            return FlexibleMessageBoxForm.Show(null, text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption)
        {
            return FlexibleMessageBoxForm.Show(owner, text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return FlexibleMessageBoxForm.Show(null, text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            return FlexibleMessageBoxForm.Show(owner, text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <returns></returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return FlexibleMessageBoxForm.Show(null, text, caption, buttons, icon, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return FlexibleMessageBoxForm.Show(owner, text, caption, buttons, icon, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="defaultButton">The default button.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            return FlexibleMessageBoxForm.Show(null, text, caption, buttons, icon, defaultButton);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="defaultButton">The default button.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            return FlexibleMessageBoxForm.Show(owner, text, caption, buttons, icon, defaultButton);
        }

        #endregion

        #region Internal form class

        /// <summary>
        /// The form to show the customized message box.
        /// It is defined as an internal class to keep the public interface of the FlexibleMessageBox clean.
        /// </summary>
        class FlexibleMessageBoxForm : Form
        {
            #region Form-Designer generated code

            /// <summary>
            /// Erforderliche Designervariable.
            /// </summary>
            private System.ComponentModel.IContainer components;

            /// <summary>
            /// Verwendete Ressourcen bereinigen.
            /// </summary>
            /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            /// <summary>
            /// Erforderliche Methode für die Designerunterstützung.
            /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
            /// </summary>
            private void InitializeComponent()
            {
                components = new System.ComponentModel.Container();
                _button1 = new MetroButton();
                _button2 = new MetroButton();
                _button3 = new MetroButton();
                _panel1 = new MetroPanel();
                _pictureBoxForIcon = new PictureBox();
                _richTextBoxMessage = new RichTextBox();
                _flexibleMessageBoxFormBindingSource = new BindingSource(components);
                ((System.ComponentModel.ISupportInitialize)(_flexibleMessageBoxFormBindingSource)).BeginInit();
                _panel1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(_pictureBoxForIcon)).BeginInit();
                SuspendLayout();
                // 
                // button1
                // 
                _button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                _button1.AutoSize = true;
                _button1.DialogResult = DialogResult.OK;
                _button1.Location = new Point(11, 67);
                _button1.MinimumSize = new Size(0, 24);
                _button1.Name = "_button1";
                _button1.Size = new Size(75, 24);
                _button1.TabIndex = 2;
                _button1.Text = "OK";
                _button1.UseVisualStyleBackColor = true;
                _button1.Visible = false;
                // 
                // richTextBoxMessage
                // 
                _richTextBoxMessage.Anchor = ((AnchorStyles.Top | AnchorStyles.Bottom)
                                              | AnchorStyles.Left)
                                             | AnchorStyles.Right;
                _richTextBoxMessage.BackColor = Color.White;
                _richTextBoxMessage.BorderStyle = BorderStyle.None;
                _richTextBoxMessage.DataBindings.Add(new Binding("Text", _flexibleMessageBoxFormBindingSource, "MessageText", true, DataSourceUpdateMode.OnPropertyChanged));
                _richTextBoxMessage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                _richTextBoxMessage.Location = new Point(50, 26);
                _richTextBoxMessage.Margin = new Padding(0);
                _richTextBoxMessage.Name = "_richTextBoxMessage";
                _richTextBoxMessage.ReadOnly = true;
                _richTextBoxMessage.ScrollBars = RichTextBoxScrollBars.Vertical;
                _richTextBoxMessage.Size = new Size(200, 20);
                _richTextBoxMessage.TabIndex = 0;
                _richTextBoxMessage.TabStop = false;
                _richTextBoxMessage.Text = "<Message>";
                _richTextBoxMessage.LinkClicked += richTextBoxMessage_LinkClicked;
                // 
                // panel1
                // 
                _panel1.Anchor = ((AnchorStyles.Top | AnchorStyles.Bottom)
                                  | AnchorStyles.Left)
                                 | AnchorStyles.Right;
                _panel1.BackColor = Color.White;
                _panel1.Controls.Add(_pictureBoxForIcon);
                _panel1.Controls.Add(_richTextBoxMessage);
                _panel1.Location = new Point(-3, -4);
                _panel1.Name = "_panel1";
                _panel1.Size = new Size(268, 59);
                _panel1.TabIndex = 1;
                // 
                // pictureBoxForIcon
                // 
                _pictureBoxForIcon.BackColor = Color.Transparent;
                _pictureBoxForIcon.Location = new Point(15, 19);
                _pictureBoxForIcon.Name = "_pictureBoxForIcon";
                _pictureBoxForIcon.Size = new Size(32, 32);
                _pictureBoxForIcon.TabIndex = 8;
                _pictureBoxForIcon.TabStop = false;
                // 
                // button2
                // 
                _button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                _button2.DialogResult = DialogResult.OK;
                _button2.Location = new Point(92, 67);
                _button2.MinimumSize = new Size(0, 24);
                _button2.Name = "_button2";
                _button2.Size = new Size(75, 24);
                _button2.TabIndex = 3;
                _button2.Text = "OK";
                _button2.UseVisualStyleBackColor = true;
                _button2.Visible = false;
                // 
                // button3
                // 
                _button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                _button3.AutoSize = true;
                _button3.DialogResult = DialogResult.OK;
                _button3.Location = new Point(173, 67);
                _button3.MinimumSize = new Size(0, 24);
                _button3.Name = "_button3";
                _button3.Size = new Size(75, 24);
                _button3.TabIndex = 0;
                _button3.Text = "OK";
                _button3.UseVisualStyleBackColor = true;
                _button3.Visible = false;
                // 
                // FlexibleMessageBoxForm
                // 
                AutoScaleDimensions = new SizeF(6F, 13F);
                AutoScaleMode = AutoScaleMode.Font;
                ClientSize = new Size(260, 102);
                Controls.Add(_button3);
                Controls.Add(_button2);
                Controls.Add(_panel1);
                Controls.Add(_button1);
                DataBindings.Add(new Binding("Text", _flexibleMessageBoxFormBindingSource, "CaptionText", true));
                MaximizeBox = false;
                MinimizeBox = false;
                MinimumSize = new Size(276, 140);
                Name = "FlexibleMessageBoxForm";
                ShowIcon = false;
                SizeGripStyle = SizeGripStyle.Show;
                StartPosition = FormStartPosition.CenterParent;
                Text = "<Caption>";
                Shown += FlexibleMessageBoxForm_Shown;
                ((System.ComponentModel.ISupportInitialize)(_flexibleMessageBoxFormBindingSource)).EndInit();
                _panel1.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(_pictureBoxForIcon)).EndInit();
                ResumeLayout(false);
                PerformLayout();
            }

            private Button _button1;
            private BindingSource _flexibleMessageBoxFormBindingSource;
            private RichTextBox _richTextBoxMessage;
            private Panel _panel1;
            private PictureBox _pictureBoxForIcon;
            private Button _button2;
            private Button _button3;

            #endregion

            #region Private constants

            //These separators are used for the "copy to clipboard" standard operation, triggered by Ctrl + C (behavior and clipboard format is like in a standard MessageBox)
            private static readonly String StandardMessageboxSeparatorLines = "---------------------------\n";
            private static readonly String StandardMessageboxSeparatorSpaces = "   ";

            //These are the possible buttons (in a standard MessageBox)
            private enum ButtonId { Ok = 0, Cancel, Yes, No, Abort, Retry, Ignore };

            //These are the buttons texts for different languages. 
            //If you want to add a new language, add it here and in the GetButtonText-Function
            private enum TwoLetterIsoLanguageId { En, De, Es, It };
            private static readonly String[] ButtonTextsEnglishEn = { "OK", "Cancel", "&Yes", "&No", "&Abort", "&Retry", "&Ignore" }; //Note: This is also the fallback language
            private static readonly String[] ButtonTextsGermanDe = { "OK", "Abbrechen", "&Ja", "&Nein", "&Abbrechen", "&Wiederholen", "&Ignorieren" };
            private static readonly String[] ButtonTextsSpanishEs = { "Aceptar", "Cancelar", "&Sí", "&No", "&Abortar", "&Reintentar", "&Ignorar" };
            private static readonly String[] ButtonTextsItalianIt = { "OK", "Annulla", "&Sì", "&No", "&Interrompi", "&Riprova", "&Ignora" };

            #endregion

            #region Private members

            private MessageBoxDefaultButton _defaultButton;
            private int _visibleButtonsCount;
            private TwoLetterIsoLanguageId _languageId = TwoLetterIsoLanguageId.En;

            #endregion

            #region Private constructor

            /// <summary>
            /// Initializes a new instance of the <see cref="FlexibleMessageBoxForm"/> class.
            /// </summary>
            private FlexibleMessageBoxForm()
            {
                InitializeComponent();

                //Try to evaluate the language. If this fails, the fallback language English will be used
                Enum.TryParse(CultureInfo.CurrentUICulture.TwoLetterISOLanguageName, out _languageId);

                KeyPreview = true;
                KeyUp += FlexibleMessageBoxForm_KeyUp;
            }

            #endregion

            #region Private helper functions

            /// <summary>
            /// Gets the string rows.
            /// </summary>
            /// <param name="message">The message.</param>
            /// <returns>The string rows as 1-dimensional array</returns>
            private static string[] GetStringRows(string message)
            {
                if (string.IsNullOrEmpty(message)) return null;

                var messageRows = message.Split(new[] { '\n' }, StringSplitOptions.None);
                return messageRows;
            }

            /// <summary>
            /// Gets the button text for the CurrentUICulture language.
            /// Note: The fallback language is English
            /// </summary>
            /// <param name="buttonId">The ID of the button.</param>
            /// <returns>The button text</returns>
            private string GetButtonText(ButtonId buttonId)
            {
                var buttonTextArrayIndex = Convert.ToInt32(buttonId);

                switch (_languageId)
                {
                    case TwoLetterIsoLanguageId.De: return ButtonTextsGermanDe[buttonTextArrayIndex];
                    case TwoLetterIsoLanguageId.Es: return ButtonTextsSpanishEs[buttonTextArrayIndex];
                    case TwoLetterIsoLanguageId.It: return ButtonTextsItalianIt[buttonTextArrayIndex];

                    default: return ButtonTextsEnglishEn[buttonTextArrayIndex];
                }
            }

            /// <summary>
            /// Ensure the given working area factor in the range of  0.2 - 1.0 where: 
            /// 
            /// 0.2 means:  20 percent of the working area height or width.
            /// 1.0 means:  100 percent of the working area height or width.
            /// </summary>
            /// <param name="workingAreaFactor">The given working area factor.</param>
            /// <returns>The corrected given working area factor.</returns>
            private static double GetCorrectedWorkingAreaFactor(double workingAreaFactor)
            {
                const double minFactor = 0.2;
                const double maxFactor = 1.0;

                if (workingAreaFactor < minFactor) return minFactor;
                if (workingAreaFactor > maxFactor) return maxFactor;

                return workingAreaFactor;
            }

            /// <summary>
            /// Set the dialogs start position when given. 
            /// Otherwise center the dialog on the current screen.
            /// </summary>
            /// <param name="flexibleMessageBoxForm">The FlexibleMessageBox dialog.</param>
            /// <param name="owner">The owner.</param>
            private static void SetDialogStartPosition(FlexibleMessageBoxForm flexibleMessageBoxForm, IWin32Window owner)
            {
                //If no owner given: Center on current screen
                if (owner == null)
                {
                    var screen = Screen.FromPoint(Cursor.Position);
                    flexibleMessageBoxForm.StartPosition = FormStartPosition.Manual;
                    flexibleMessageBoxForm.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - flexibleMessageBoxForm.Width / 2;
                    flexibleMessageBoxForm.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - flexibleMessageBoxForm.Height / 2;
                }
            }

            /// <summary>
            /// Calculate the dialogs start size (Try to auto-size width to show longest text row).
            /// Also set the maximum dialog size. 
            /// </summary>
            /// <param name="flexibleMessageBoxForm">The FlexibleMessageBox dialog.</param>
            /// <param name="text">The text (the longest text row is used to calculate the dialog width).</param>
            /// <param name="text">The caption (this can also affect the dialog width).</param>
            private static void SetDialogSizes(FlexibleMessageBoxForm flexibleMessageBoxForm, string text, string caption)
            {
                //First set the bounds for the maximum dialog size
                flexibleMessageBoxForm.MaximumSize = new Size(Convert.ToInt32(SystemInformation.WorkingArea.Width * GetCorrectedWorkingAreaFactor(MaxWidthFactor)),
                                                              Convert.ToInt32(SystemInformation.WorkingArea.Height * GetCorrectedWorkingAreaFactor(MaxHeightFactor)));

                //Get rows. Exit if there are no rows to render...
                var stringRows = GetStringRows(text);
                if (stringRows == null) return;

                //Calculate whole text height
                var textHeight = TextRenderer.MeasureText(text, FlexibleMessageBox.Font).Height;

                //Calculate width for longest text line
                const int scrollbarWidthOffset = 15;
                var longestTextRowWidth = stringRows.Max(textForRow => TextRenderer.MeasureText(textForRow, FlexibleMessageBox.Font).Width);
                var captionWidth = TextRenderer.MeasureText(caption, SystemFonts.CaptionFont).Width;
                var textWidth = Math.Max(longestTextRowWidth + scrollbarWidthOffset, captionWidth);

                //Calculate margins
                var marginWidth = flexibleMessageBoxForm.Width - flexibleMessageBoxForm._richTextBoxMessage.Width;
                var marginHeight = flexibleMessageBoxForm.Height - flexibleMessageBoxForm._richTextBoxMessage.Height;

                //Set calculated dialog size (if the calculated values exceed the maximums, they were cut by windows forms automatically)
                flexibleMessageBoxForm.Size = new Size(textWidth + marginWidth,
                                                       textHeight + marginHeight);
            }

            /// <summary>
            /// Set the dialogs icon. 
            /// When no icon is used: Correct placement and width of rich text box.
            /// </summary>
            /// <param name="flexibleMessageBoxForm">The FlexibleMessageBox dialog.</param>
            /// <param name="icon">The MessageBoxIcon.</param>
            private static void SetDialogIcon(FlexibleMessageBoxForm flexibleMessageBoxForm, MessageBoxIcon icon)
            {
                switch (icon)
                {
                    case MessageBoxIcon.Information:
                        flexibleMessageBoxForm._pictureBoxForIcon.Image = SystemIcons.Information.ToBitmap();
                        break;
                    case MessageBoxIcon.Warning:
                        flexibleMessageBoxForm._pictureBoxForIcon.Image = SystemIcons.Warning.ToBitmap();
                        break;
                    case MessageBoxIcon.Error:
                        flexibleMessageBoxForm._pictureBoxForIcon.Image = SystemIcons.Error.ToBitmap();
                        break;
                    case MessageBoxIcon.Question:
                        flexibleMessageBoxForm._pictureBoxForIcon.Image = SystemIcons.Question.ToBitmap();
                        break;
                    default:
                        //When no icon is used: Correct placement and width of rich text box.
                        flexibleMessageBoxForm._pictureBoxForIcon.Visible = false;
                        flexibleMessageBoxForm._richTextBoxMessage.Left -= flexibleMessageBoxForm._pictureBoxForIcon.Width;
                        flexibleMessageBoxForm._richTextBoxMessage.Width += flexibleMessageBoxForm._pictureBoxForIcon.Width;
                        break;
                }
            }

            /// <summary>
            /// Set dialog buttons visibilities and texts. 
            /// Also set a default button.
            /// </summary>
            /// <param name="flexibleMessageBoxForm">The FlexibleMessageBox dialog.</param>
            /// <param name="buttons">The buttons.</param>
            /// <param name="defaultButton">The default button.</param>
            private static void SetDialogButtons(FlexibleMessageBoxForm flexibleMessageBoxForm, MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
            {
                //Set the buttons visibilities and texts
                switch (buttons)
                {
                    case MessageBoxButtons.AbortRetryIgnore:
                        flexibleMessageBoxForm._visibleButtonsCount = 3;

                        flexibleMessageBoxForm._button1.Visible = true;
                        flexibleMessageBoxForm._button1.Text = flexibleMessageBoxForm.GetButtonText(ButtonId.Abort);
                        flexibleMessageBoxForm._button1.DialogResult = DialogResult.Abort;

                        flexibleMessageBoxForm._button2.Visible = true;
                        flexibleMessageBoxForm._button2.Text = flexibleMessageBoxForm.GetButtonText(ButtonId.Retry);
                        flexibleMessageBoxForm._button2.DialogResult = DialogResult.Retry;

                        flexibleMessageBoxForm._button3.Visible = true;
                        flexibleMessageBoxForm._button3.Text = flexibleMessageBoxForm.GetButtonText(ButtonId.Ignore);
                        flexibleMessageBoxForm._button3.DialogResult = DialogResult.Ignore;

                        flexibleMessageBoxForm.ControlBox = false;
                        break;

                    case MessageBoxButtons.OKCancel:
                        flexibleMessageBoxForm._visibleButtonsCount = 2;

                        flexibleMessageBoxForm._button2.Visible = true;
                        flexibleMessageBoxForm._button2.Text = flexibleMessageBoxForm.GetButtonText(ButtonId.Ok);
                        flexibleMessageBoxForm._button2.DialogResult = DialogResult.OK;

                        flexibleMessageBoxForm._button3.Visible = true;
                        flexibleMessageBoxForm._button3.Text = flexibleMessageBoxForm.GetButtonText(ButtonId.Cancel);
                        flexibleMessageBoxForm._button3.DialogResult = DialogResult.Cancel;

                        flexibleMessageBoxForm.CancelButton = flexibleMessageBoxForm._button3;
                        break;

                    case MessageBoxButtons.RetryCancel:
                        flexibleMessageBoxForm._visibleButtonsCount = 2;

                        flexibleMessageBoxForm._button2.Visible = true;
                        flexibleMessageBoxForm._button2.Text = flexibleMessageBoxForm.GetButtonText(ButtonId.Retry);
                        flexibleMessageBoxForm._button2.DialogResult = DialogResult.Retry;

                        flexibleMessageBoxForm._button3.Visible = true;
                        flexibleMessageBoxForm._button3.Text = flexibleMessageBoxForm.GetButtonText(ButtonId.Cancel);
                        flexibleMessageBoxForm._button3.DialogResult = DialogResult.Cancel;

                        flexibleMessageBoxForm.CancelButton = flexibleMessageBoxForm._button3;
                        break;

                    case MessageBoxButtons.YesNo:
                        flexibleMessageBoxForm._visibleButtonsCount = 2;

                        flexibleMessageBoxForm._button2.Visible = true;
                        flexibleMessageBoxForm._button2.Text = flexibleMessageBoxForm.GetButtonText(ButtonId.Yes);
                        flexibleMessageBoxForm._button2.DialogResult = DialogResult.Yes;

                        flexibleMessageBoxForm._button3.Visible = true;
                        flexibleMessageBoxForm._button3.Text = flexibleMessageBoxForm.GetButtonText(ButtonId.No);
                        flexibleMessageBoxForm._button3.DialogResult = DialogResult.No;

                        flexibleMessageBoxForm.ControlBox = false;
                        break;

                    case MessageBoxButtons.YesNoCancel:
                        flexibleMessageBoxForm._visibleButtonsCount = 3;

                        flexibleMessageBoxForm._button1.Visible = true;
                        flexibleMessageBoxForm._button1.Text = flexibleMessageBoxForm.GetButtonText(ButtonId.Yes);
                        flexibleMessageBoxForm._button1.DialogResult = DialogResult.Yes;

                        flexibleMessageBoxForm._button2.Visible = true;
                        flexibleMessageBoxForm._button2.Text = flexibleMessageBoxForm.GetButtonText(ButtonId.No);
                        flexibleMessageBoxForm._button2.DialogResult = DialogResult.No;

                        flexibleMessageBoxForm._button3.Visible = true;
                        flexibleMessageBoxForm._button3.Text = flexibleMessageBoxForm.GetButtonText(ButtonId.Cancel);
                        flexibleMessageBoxForm._button3.DialogResult = DialogResult.Cancel;

                        flexibleMessageBoxForm.CancelButton = flexibleMessageBoxForm._button3;
                        break;

                    case MessageBoxButtons.OK:
                    default:
                        flexibleMessageBoxForm._visibleButtonsCount = 1;
                        flexibleMessageBoxForm._button3.Visible = true;
                        flexibleMessageBoxForm._button3.Text = flexibleMessageBoxForm.GetButtonText(ButtonId.Ok);
                        flexibleMessageBoxForm._button3.DialogResult = DialogResult.OK;

                        flexibleMessageBoxForm.CancelButton = flexibleMessageBoxForm._button3;
                        break;
                }

                //Set default button (used in FlexibleMessageBoxForm_Shown)
                flexibleMessageBoxForm._defaultButton = defaultButton;
            }

            #endregion

            #region Private event handlers

            /// <summary>
            /// Handles the Shown event of the FlexibleMessageBoxForm control.
            /// </summary>
            /// <param name="sender">The source of the event.</param>
            /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
            private void FlexibleMessageBoxForm_Shown(object sender, EventArgs e)
            {
                int buttonIndexToFocus;
                Button buttonToFocus;

                //Set the default button...
                switch (_defaultButton)
                {
                    default:
                        buttonIndexToFocus = 1;
                        break;
                    case MessageBoxDefaultButton.Button2:
                        buttonIndexToFocus = 2;
                        break;
                    case MessageBoxDefaultButton.Button3:
                        buttonIndexToFocus = 3;
                        break;
                }

                if (buttonIndexToFocus > _visibleButtonsCount) buttonIndexToFocus = _visibleButtonsCount;

                if (buttonIndexToFocus == 3)
                {
                    buttonToFocus = _button3;
                }
                else if (buttonIndexToFocus == 2)
                {
                    buttonToFocus = _button2;
                }
                else
                {
                    buttonToFocus = _button1;
                }

                buttonToFocus.Focus();
            }

            /// <summary>
            /// Handles the LinkClicked event of the richTextBoxMessage control.
            /// </summary>
            /// <param name="sender">The source of the event.</param>
            /// <param name="e">The <see cref="System.Windows.Forms.LinkClickedEventArgs"/> instance containing the event data.</param>
            private void richTextBoxMessage_LinkClicked(object sender, LinkClickedEventArgs e)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Process.Start(e.LinkText);
                }
                catch (Exception)
                {
                    //Let the caller of FlexibleMessageBoxForm decide what to do with this exception...
                    throw;
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }

            }

            /// <summary>
            /// Handles the KeyUp event of the richTextBoxMessage control.
            /// </summary>
            /// <param name="sender">The source of the event.</param>
            /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
            void FlexibleMessageBoxForm_KeyUp(object sender, KeyEventArgs e)
            {
                //Handle standard key strikes for clipboard copy: "Ctrl + C" and "Ctrl + Insert"
                if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.Insert))
                {
                    var buttonsTextLine = (_button1.Visible ? _button1.Text + StandardMessageboxSeparatorSpaces : string.Empty)
                                        + (_button2.Visible ? _button2.Text + StandardMessageboxSeparatorSpaces : string.Empty)
                                        + (_button3.Visible ? _button3.Text + StandardMessageboxSeparatorSpaces : string.Empty);

                    //Build same clipboard text like the standard .Net MessageBox
                    var textForClipboard = StandardMessageboxSeparatorLines
                                         + Text + Environment.NewLine
                                         + StandardMessageboxSeparatorLines
                                         + _richTextBoxMessage.Text + Environment.NewLine
                                         + StandardMessageboxSeparatorLines
                                         + buttonsTextLine.Replace("&", string.Empty) + Environment.NewLine
                                         + StandardMessageboxSeparatorLines;

                    //Set text in clipboard
                    Clipboard.SetText(textForClipboard);
                }
            }

            #endregion

            #region Properties (only used for binding)

            /// <summary>
            /// The text that is been used for the heading.
            /// </summary>
            public string CaptionText { get; set; }

            /// <summary>
            /// The text that is been used in the FlexibleMessageBoxForm.
            /// </summary>
            public string MessageText { get; set; }

            #endregion

            #region Public show function

            /// <summary>
            /// Shows the specified message box.
            /// </summary>
            /// <param name="owner">The owner.</param>
            /// <param name="text">The text.</param>
            /// <param name="caption">The caption.</param>
            /// <param name="buttons">The buttons.</param>
            /// <param name="icon">The icon.</param>
            /// <param name="defaultButton">The default button.</param>
            /// <returns>The dialog result.</returns>
            public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
            {
                //Create a new instance of the FlexibleMessageBox form
                var flexibleMessageBoxForm = new FlexibleMessageBoxForm();
                flexibleMessageBoxForm.ShowInTaskbar = false;

                //Bind the caption and the message text
                flexibleMessageBoxForm.CaptionText = caption;
                flexibleMessageBoxForm.MessageText = text;
                flexibleMessageBoxForm._flexibleMessageBoxFormBindingSource.DataSource = flexibleMessageBoxForm;

                //Set the buttons visibilities and texts. Also set a default button.
                SetDialogButtons(flexibleMessageBoxForm, buttons, defaultButton);

                //Set the dialogs icon. When no icon is used: Correct placement and width of rich text box.
                SetDialogIcon(flexibleMessageBoxForm, icon);

                //Set the font for all controls
                flexibleMessageBoxForm.Font = FlexibleMessageBox.Font;
                flexibleMessageBoxForm._richTextBoxMessage.Font = FlexibleMessageBox.Font;

                //Calculate the dialogs start size (Try to auto-size width to show longest text row). Also set the maximum dialog size. 
                SetDialogSizes(flexibleMessageBoxForm, text, caption);

                //Set the dialogs start position when given. Otherwise center the dialog on the current screen.
                SetDialogStartPosition(flexibleMessageBoxForm, owner);

                //Show the dialog
                return flexibleMessageBoxForm.ShowDialog(owner);
            }

            #endregion
        } //class FlexibleMessageBoxForm

        #endregion
    }
}
