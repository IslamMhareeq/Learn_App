using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_App
{
    public partial class English : Form
    {
        private User currentUser;
        private UserManager userManager;

        public English(User user, UserManager userManager)
        {
            currentUser = user;
            this.userManager = userManager;
            InitializeComponent();
        }

        private void EnglishGame_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            var form = new MainPage(currentUser, userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new MatchingLetters(currentUser,userManager);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new spellLetters(currentUser, userManager);
            form.Show();

        }
    }
}
