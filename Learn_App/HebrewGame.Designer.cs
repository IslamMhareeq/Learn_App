namespace Learn_App
{
    partial class Hebrew
    {
        private void InitializeComponent()
        {
            this.label_word = new System.Windows.Forms.Label();
            this.textBox1_Guess = new System.Windows.Forms.TextBox();
            this.button1_next = new System.Windows.Forms.Button();
            this.button2_start = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_word
            // 
            this.label_word.BackColor = System.Drawing.Color.LightBlue;
            this.label_word.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_word.Location = new System.Drawing.Point(75, 158);
            this.label_word.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_word.Name = "label_word";
            this.label_word.Size = new System.Drawing.Size(928, 158);
            this.label_word.TabIndex = 0;
            this.label_word.Text = "המילה";
            this.label_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_word.Click += new System.EventHandler(this.label_word_Click);
            // 
            // textBox1_Guess
            // 
            this.textBox1_Guess.BackColor = System.Drawing.Color.White;
            this.textBox1_Guess.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1_Guess.Location = new System.Drawing.Point(75, 355);
            this.textBox1_Guess.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1_Guess.Name = "textBox1_Guess";
            this.textBox1_Guess.Size = new System.Drawing.Size(922, 103);
            this.textBox1_Guess.TabIndex = 1;
            this.textBox1_Guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1_Guess.TextChanged += new System.EventHandler(this.textBox1_Guess_TextChanged);
            // 
            // button1_next
            // 
            this.button1_next.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1_next.Enabled = false;
            this.button1_next.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_next.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1_next.Location = new System.Drawing.Point(75, 521);
            this.button1_next.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1_next.Name = "button1_next";
            this.button1_next.Size = new System.Drawing.Size(928, 151);
            this.button1_next.TabIndex = 2;
            this.button1_next.Text = "הבא";
            this.button1_next.UseVisualStyleBackColor = false;
            this.button1_next.Click += new System.EventHandler(this.button1_next_Click);
            // 
            // button2_start
            // 
            this.button2_start.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2_start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_start.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2_start.Location = new System.Drawing.Point(75, 727);
            this.button2_start.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2_start.Name = "button2_start";
            this.button2_start.Size = new System.Drawing.Size(928, 151);
            this.button2_start.TabIndex = 3;
            this.button2_start.Text = "התחלה";
            this.button2_start.UseVisualStyleBackColor = false;
            this.button2_start.Click += new System.EventHandler(this.button2_start_Click);
            // 
            // label_result
            // 
            this.label_result.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_result.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_result.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_result.Location = new System.Drawing.Point(75, 958);
            this.label_result.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(928, 158);
            this.label_result.TabIndex = 4;
            this.label_result.Text = "תוצאה";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_result.Click += new System.EventHandler(this.label_result_Click);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_score.Location = new System.Drawing.Point(500, 1176);
            this.label_score.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(92, 74);
            this.label_score.TabIndex = 5;
            this.label_score.Text = "00";
            this.label_score.Click += new System.EventHandler(this.label_score_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 80);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 71);
            this.label6.TabIndex = 3;
            this.label6.Text = "Go to back";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Hebrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 1413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button2_start);
            this.Controls.Add(this.button1_next);
            this.Controls.Add(this.textBox1_Guess);
            this.Controls.Add(this.label_word);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Hebrew";
            this.Text = "Hebrew Learning Game";
            this.Load += new System.EventHandler(this.Hebrew_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label_word;
        private System.Windows.Forms.TextBox textBox1_Guess;
        private System.Windows.Forms.Button button1_next;
        private System.Windows.Forms.Button button2_start;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}
