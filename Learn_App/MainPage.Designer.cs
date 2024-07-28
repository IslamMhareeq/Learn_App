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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.labelLibrary = new System.Windows.Forms.Label();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Label();
            this.Store = new System.Windows.Forms.Label();
            this.Prof = new System.Windows.Forms.Label();
            this.sidebartran = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLibrary
            // 
            this.labelLibrary.AutoSize = true;
            this.labelLibrary.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLibrary.Location = new System.Drawing.Point(332, 180);
            this.labelLibrary.Name = "labelLibrary";
            this.labelLibrary.Size = new System.Drawing.Size(0, 135);
            this.labelLibrary.TabIndex = 1;
            this.labelLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLibrary.Click += new System.EventHandler(this.labelLibrary_Click);
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonEnglish.Location = new System.Drawing.Point(424, 457);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(336, 75);
            this.buttonEnglish.TabIndex = 6;
            this.buttonEnglish.Text = "English Game";
            this.buttonEnglish.UseVisualStyleBackColor = false;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            this.buttonEnglish.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonEnglish.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button1.Location = new System.Drawing.Point(424, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "Math Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button2.Location = new System.Drawing.Point(424, 650);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(336, 75);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hebrew Game";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 76);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1079, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log Out";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(580, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 71);
            this.label6.TabIndex = 3;
            this.label6.Text = "Learn App";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(46, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 997);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.Main);
            this.panel2.Controls.Add(this.Store);
            this.panel2.Controls.Add(this.Prof);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 459);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Main
            // 
            this.Main.AutoSize = true;
            this.Main.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Main.Location = new System.Drawing.Point(67, 284);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(203, 44);
            this.Main.TabIndex = 12;
            this.Main.Text = "Main Page";
            this.Main.Click += new System.EventHandler(this.label4_Click);
            // 
            // Store
            // 
            this.Store.AutoSize = true;
            this.Store.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Store.Location = new System.Drawing.Point(67, 171);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(131, 44);
            this.Store.TabIndex = 11;
            this.Store.Text = "Store";
            this.Store.Click += new System.EventHandler(this.label3_Click);
            // 
            // Prof
            // 
            this.Prof.AutoSize = true;
            this.Prof.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prof.Location = new System.Drawing.Point(67, 59);
            this.Prof.Name = "Prof";
            this.Prof.Size = new System.Drawing.Size(165, 44);
            this.Prof.TabIndex = 10;
            this.Prof.Text = "Profile";
            this.Prof.Click += new System.EventHandler(this.label2_Click);
            // 
            // sidebartran
            // 
            this.sidebartran.Interval = 10;
            this.sidebartran.Tick += new System.EventHandler(this.sidebartran_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 1073);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEnglish);
            this.Controls.Add(this.labelLibrary);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainPage";
            this.Text = "Main Page Select";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
