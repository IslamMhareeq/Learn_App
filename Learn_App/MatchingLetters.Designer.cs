using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing; // Ensure this using directive is present
using Guna.UI2.WinForms;

namespace Learn_App
{
    partial class MatchingLetters
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
            label1 = new Label();
            submitButton = new Button();
            button2 = new Button();
            aLetter = new Button();
            bLetter = new Button();
            cLetter = new Button();
            dLetter = new Button();
            questionLetter = new Label();
            panel1 = new Panel();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            guna2MessageDialog2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(146, 64);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(811, 128);
            label1.TabIndex = 25;
            label1.Text = "Match the letter:";
            label1.Click += label1_Click;
            // 
            // submitButton
            // 
            submitButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            submitButton.Location = new Point(40, 887);
            submitButton.Margin = new Padding(9, 10, 9, 10);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(469, 131);
            submitButton.TabIndex = 26;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(562, 887);
            button2.Margin = new Padding(9, 10, 9, 10);
            button2.Name = "button2";
            button2.Size = new Size(395, 131);
            button2.TabIndex = 27;
            button2.Text = "Shuffle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // aLetter
            // 
            aLetter.Font = new System.Drawing.Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            aLetter.Location = new Point(468, 738);
            aLetter.Margin = new Padding(9, 10, 9, 10);
            aLetter.Name = "aLetter";
            aLetter.Size = new Size(195, 111);
            aLetter.TabIndex = 29;
            aLetter.UseVisualStyleBackColor = true;
            aLetter.Click += aLetter_Click;
            // 
            // bLetter
            // 
            bLetter.Font = new System.Drawing.Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bLetter.Location = new Point(681, 738);
            bLetter.Margin = new Padding(9, 10, 9, 10);
            bLetter.Name = "bLetter";
            bLetter.Size = new Size(201, 111);
            bLetter.TabIndex = 30;
            bLetter.UseVisualStyleBackColor = true;
            bLetter.Click += bLetter_Click;
            // 
            // cLetter
            // 
            cLetter.Font = new System.Drawing.Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            cLetter.Location = new Point(259, 738);
            cLetter.Margin = new Padding(9, 10, 9, 10);
            cLetter.Name = "cLetter";
            cLetter.Size = new Size(191, 111);
            cLetter.TabIndex = 31;
            cLetter.UseVisualStyleBackColor = true;
            cLetter.Click += cLetter_Click;
            // 
            // dLetter
            // 
            dLetter.Font = new System.Drawing.Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dLetter.Location = new Point(57, 738);
            dLetter.Margin = new Padding(9, 10, 9, 10);
            dLetter.Name = "dLetter";
            dLetter.Size = new Size(184, 111);
            dLetter.TabIndex = 32;
            dLetter.UseVisualStyleBackColor = true;
            dLetter.Click += dLetter_Click;
            // 
            // questionLetter
            // 
            questionLetter.AutoSize = true;
            questionLetter.Font = new System.Drawing.Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            questionLetter.Location = new Point(229, 106);
            questionLetter.Margin = new Padding(9, 0, 9, 0);
            questionLetter.Name = "questionLetter";
            questionLetter.Size = new Size(0, 96);
            questionLetter.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(questionLetter);
            panel1.Location = new Point(221, 202);
            panel1.Margin = new Padding(9, 10, 9, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 358);
            panel1.TabIndex = 34;
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = "";
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            guna2MessageDialog1.Parent = this;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            guna2MessageDialog1.Text = "Incorrect. Try again.";
            // 
            // guna2MessageDialog2
            // 
            guna2MessageDialog2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog2.Caption = null;
            guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            guna2MessageDialog2.Parent = this;
            guna2MessageDialog2.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            guna2MessageDialog2.Text = "Correct answer, you've earned {x} points!";
            // 
            // MatchingLetters
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1037, 1149);
            Controls.Add(panel1);
            Controls.Add(dLetter);
            Controls.Add(cLetter);
            Controls.Add(bLetter);
            Controls.Add(aLetter);
            Controls.Add(button2);
            Controls.Add(submitButton);
            Controls.Add(label1);
            Margin = new Padding(9, 10, 9, 10);
            Name = "MatchingLetters";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MatchingLetters";
            Load += MatchingLetters_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button submitButton;
        private Button button2;
        private Button aLetter;
        private Button bLetter;
        private Button cLetter;
        private Button dLetter;
        private Label questionLetter;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog2;
    }
}
