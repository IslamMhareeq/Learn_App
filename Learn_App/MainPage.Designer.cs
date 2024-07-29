namespace Learn_App
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            labelLibrary = new System.Windows.Forms.Label();
            buttonEnglish = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            Main = new System.Windows.Forms.Label();
            Store = new System.Windows.Forms.Label();
            Prof = new System.Windows.Forms.Label();
            sidebartran = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelLibrary
            // 
            labelLibrary.AutoSize = true;
            labelLibrary.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelLibrary.Location = new System.Drawing.Point(332, 180);
            labelLibrary.Name = "labelLibrary";
            labelLibrary.Size = new System.Drawing.Size(0, 135);
            labelLibrary.TabIndex = 1;
            labelLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelLibrary.Click += labelLibrary_Click;
            // 
            // buttonEnglish
            // 
            buttonEnglish.BackColor = System.Drawing.Color.FromArgb(0, 180, 180);
            buttonEnglish.Location = new System.Drawing.Point(424, 457);
            buttonEnglish.Name = "buttonEnglish";
            buttonEnglish.Size = new System.Drawing.Size(336, 75);
            buttonEnglish.TabIndex = 6;
            buttonEnglish.Text = "English Game";
            buttonEnglish.UseVisualStyleBackColor = false;
            buttonEnglish.Click += buttonEnglish_Click;
            buttonEnglish.MouseEnter += Button_MouseEnter;
            buttonEnglish.MouseLeave += Button_MouseLeave;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(0, 180, 180);
            button1.Location = new System.Drawing.Point(424, 553);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(336, 75);
            button1.TabIndex = 6;
            button1.Text = "Math Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += Button_MouseEnter;
            button1.MouseLeave += Button_MouseLeave;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(0, 180, 180);
            button2.Location = new System.Drawing.Point(424, 650);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(336, 75);
            button2.TabIndex = 7;
            button2.Text = "Hebrew Game";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += Button_MouseEnter;
            button2.MouseLeave += Button_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1258, 76);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(1079, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(167, 44);
            label2.TabIndex = 4;
            label2.Text = "Log Out";
            label2.Click += label2_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Viner Hand ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(534, 11);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(248, 71);
            label6.TabIndex = 3;
            label6.Text = "Learn App";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(70, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 63);
            label1.TabIndex = 1;
            label1.Text = "menu";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(46, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(32, 32);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 76);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(0, 997);
            flowLayoutPanel1.TabIndex = 9;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.DarkGray;
            panel2.Controls.Add(Main);
            panel2.Controls.Add(Store);
            panel2.Controls.Add(Prof);
            panel2.Location = new System.Drawing.Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(357, 459);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // Main
            // 
            Main.AutoSize = true;
            Main.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Main.Location = new System.Drawing.Point(67, 284);
            Main.Name = "Main";
            Main.Size = new System.Drawing.Size(203, 44);
            Main.TabIndex = 12;
            Main.Text = "Main Page";
            Main.Click += label4_Click;
            // 
            // Store
            // 
            Store.AutoSize = true;
            Store.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Store.Location = new System.Drawing.Point(67, 171);
            Store.Name = "Store";
            Store.Size = new System.Drawing.Size(131, 44);
            Store.TabIndex = 11;
            Store.Text = "Store";
            Store.Click += label3_Click;
            // 
            // Prof
            // 
            Prof.AutoSize = true;
            Prof.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Prof.Location = new System.Drawing.Point(67, 59);
            Prof.Name = "Prof";
            Prof.Size = new System.Drawing.Size(165, 44);
            Prof.TabIndex = 10;
            Prof.Text = "Profile";
            Prof.Click += label2_Click;
            // 
            // sidebartran
            // 
            sidebartran.Interval = 10;
            sidebartran.Tick += sidebartran_Tick;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1258, 1073);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(buttonEnglish);
            Controls.Add(labelLibrary);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainPage";
            Text = "Main Page Select";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelLibrary;
        private System.Windows.Forms.Button buttonEnglish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer sidebartran;
        private System.Windows.Forms.Label Main;
        private System.Windows.Forms.Label Store;
        private System.Windows.Forms.Label Prof;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;


    }
}
