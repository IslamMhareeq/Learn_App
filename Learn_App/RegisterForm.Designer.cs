namespace Learn_App
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblPassword = new Label();
            lblID = new Label();
            lblEmail = new Label();
            lblGender = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtID = new TextBox();
            txtEmail = new TextBox();
            btnRegister = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(125, 90);
            lblUsername.Margin = new Padding(8, 0, 8, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(180, 48);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(125, 210);
            lblPassword.Margin = new Padding(8, 0, 8, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(168, 48);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(125, 330);
            lblID.Margin = new Padding(8, 0, 8, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(55, 48);
            lblID.TabIndex = 2;
            lblID.Text = "ID";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(125, 450);
            lblEmail.Margin = new Padding(8, 0, 8, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(105, 48);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(125, 570);
            lblGender.Margin = new Padding(8, 0, 8, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(137, 48);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(375, 90);
            txtUsername.Margin = new Padding(8, 9, 8, 9);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(494, 55);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(375, 210);
            txtPassword.Margin = new Padding(8, 9, 8, 9);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(494, 55);
            txtPassword.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(375, 330);
            txtID.Margin = new Padding(8, 9, 8, 9);
            txtID.Name = "txtID";
            txtID.Size = new Size(494, 55);
            txtID.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(375, 450);
            txtEmail.Margin = new Padding(8, 9, 8, 9);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(494, 55);
            txtEmail.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(375, 690);
            btnRegister.Margin = new Padding(8, 9, 8, 9);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(225, 90);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(321, 570);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(178, 52);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(548, 566);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(142, 52);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 900);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btnRegister);
            Controls.Add(txtEmail);
            Controls.Add(txtID);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblGender);
            Controls.Add(lblEmail);
            Controls.Add(lblID);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Margin = new Padding(8, 9, 8, 9);
            Name = "RegisterForm";
            Text = "Register";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnRegister;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
