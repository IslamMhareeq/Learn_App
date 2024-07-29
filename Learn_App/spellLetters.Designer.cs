using static Guna.UI2.WinForms.Suite.Descriptions;
// Remove or comment out the following line to avoid conflict with System.Drawing.Font
// using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Learn_App
{
    partial class spellLetters
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button2 = new Button();
            userInputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            questionLetter = new Label();
            submitButton = new Button();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            guna2MessageDialog2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(436, 790);
            button2.Margin = new Padding(9, 10, 9, 10);
            button2.Name = "button2";
            button2.Size = new Size(238, 77);
            button2.TabIndex = 36;
            button2.Text = "Shuffle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // userInputTextBox
            // 
            userInputTextBox.Animated = true;
            userInputTextBox.CustomizableEdges = customizableEdges1;
            userInputTextBox.DefaultText = "";
            userInputTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            userInputTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            userInputTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            userInputTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            userInputTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            userInputTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userInputTextBox.ForeColor = Color.Black;
            userInputTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            userInputTextBox.Location = new Point(230, 489);
            userInputTextBox.Margin = new Padding(40, 42, 40, 42);
            userInputTextBox.Name = "userInputTextBox";
            userInputTextBox.PasswordChar = '\0';
            userInputTextBox.PlaceholderText = "abcde , ABCDE , abCdE (A-E)";
            userInputTextBox.SelectedText = "";
            userInputTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            userInputTextBox.Size = new Size(611, 109);
            userInputTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            userInputTextBox.TabIndex = 39;
            userInputTextBox.TextChanged += userInputTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(81, 512);
            label2.Margin = new Padding(9, 0, 9, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 40);
            label2.TabIndex = 40;
            label2.Text = "Answer:";
            label2.Click += label2_Click;
            // 
            // questionLetter
            // 
            questionLetter.AutoSize = true;
            questionLetter.BackColor = Color.Transparent;
            questionLetter.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            questionLetter.ForeColor = SystemColors.Control;
            questionLetter.Location = new Point(468, 235);
            questionLetter.Margin = new Padding(9, 0, 9, 0);
            questionLetter.Name = "questionLetter";
            questionLetter.Size = new Size(136, 73);
            questionLetter.TabIndex = 33;
            questionLetter.Text = "test";
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            submitButton.Location = new Point(142, 790);
            submitButton.Margin = new Padding(9, 10, 9, 10);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(235, 77);
            submitButton.TabIndex = 41;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = null;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            guna2MessageDialog1.Parent = this;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            guna2MessageDialog1.Text = "Correct answer, you've earned {x} points!";
            // 
            // guna2MessageDialog2
            // 
            guna2MessageDialog2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog2.Caption = null;
            guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            guna2MessageDialog2.Parent = this;
            guna2MessageDialog2.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            guna2MessageDialog2.Text = "Invalid, try again.";
            // 
            // spellLetters
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1806, 1297);
            Controls.Add(submitButton);
            Controls.Add(questionLetter);
            Controls.Add(label2);
            Controls.Add(userInputTextBox);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(9, 10, 9, 10);
            Name = "spellLetters";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "spellLetters";
            Load += spellLetters_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Guna.UI2.WinForms.Guna2TextBox userInputTextBox;
        private Label label2;
        private Label questionLetter;
        private Button submitButton;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog2;
    }
}
