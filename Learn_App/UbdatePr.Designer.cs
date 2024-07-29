
namespace Learn_App
{
    partial class UbdatePr
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
            this.changeN = new System.Windows.Forms.Label();
            this.ChangeP = new System.Windows.Forms.Label();
            this.ChangeE = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.BN = new System.Windows.Forms.Button();
            this.BP = new System.Windows.Forms.Button();
            this.BE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeN
            // 
            this.changeN.AutoSize = true;
            this.changeN.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeN.Location = new System.Drawing.Point(108, 80);
            this.changeN.Name = "changeN";
            this.changeN.Size = new System.Drawing.Size(303, 50);
            this.changeN.TabIndex = 0;
            this.changeN.Text = "Change Name:";
            // 
            // ChangeP
            // 
            this.ChangeP.AutoSize = true;
            this.ChangeP.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeP.Location = new System.Drawing.Point(108, 307);
            this.ChangeP.Name = "ChangeP";
            this.ChangeP.Size = new System.Drawing.Size(417, 50);
            this.ChangeP.TabIndex = 1;
            this.ChangeP.Text = "Change Password:";
            this.ChangeP.Click += new System.EventHandler(this.label2_Click);
            // 
            // ChangeE
            // 
            this.ChangeE.AutoSize = true;
            this.ChangeE.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeE.Location = new System.Drawing.Point(108, 544);
            this.ChangeE.Name = "ChangeE";
            this.ChangeE.Size = new System.Drawing.Size(313, 50);
            this.ChangeE.TabIndex = 2;
            this.ChangeE.Text = "Change Email:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(108, 183);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(300, 55);
            this.txtN.TabIndex = 3;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(108, 430);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(300, 55);
            this.txtP.TabIndex = 4;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(108, 631);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(300, 55);
            this.txtE.TabIndex = 5;
            // 
            // BN
            // 
            this.BN.Location = new System.Drawing.Point(523, 168);
            this.BN.Name = "BN";
            this.BN.Size = new System.Drawing.Size(225, 69);
            this.BN.TabIndex = 6;
            this.BN.Text = "Confirm";
            this.BN.UseVisualStyleBackColor = true;
            this.BN.Click += new System.EventHandler(this.BN_Click);
            // 
            // BP
            // 
            this.BP.Location = new System.Drawing.Point(523, 415);
            this.BP.Name = "BP";
            this.BP.Size = new System.Drawing.Size(225, 69);
            this.BP.TabIndex = 7;
            this.BP.Text = "Confirm";
            this.BP.UseVisualStyleBackColor = true;
            this.BP.Click += new System.EventHandler(this.BP_Click);
            // 
            // BE
            // 
            this.BE.Location = new System.Drawing.Point(523, 616);
            this.BE.Name = "BE";
            this.BE.Size = new System.Drawing.Size(225, 69);
            this.BE.TabIndex = 8;
            this.BE.Text = "Confirm";
            this.BE.UseVisualStyleBackColor = true;
            this.BE.Click += new System.EventHandler(this.BE_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 77);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 71);
            this.label6.TabIndex = 3;
            this.label6.Text = "Go Back";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // UbdatePr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BE);
            this.Controls.Add(this.BP);
            this.Controls.Add(this.BN);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.ChangeE);
            this.Controls.Add(this.ChangeP);
            this.Controls.Add(this.changeN);
            this.Name = "UbdatePr";
            this.Text = "UbdatePr";
            this.Load += new System.EventHandler(this.UbdatePr_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label changeN;
        private System.Windows.Forms.Label ChangeP;
        private System.Windows.Forms.Label ChangeE;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Button BN;
        private System.Windows.Forms.Button BP;
        private System.Windows.Forms.Button BE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}