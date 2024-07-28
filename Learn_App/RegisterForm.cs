using System;
using System.Windows.Forms;

namespace Learn_App
{
    public partial class RegisterForm : Form
    {
        private UserManager userManager;

        public RegisterForm(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                userManager.RegisterUser(txtUsername.Text, txtPassword.Text, txtID.Text, txtEmail.Text, txtGender.Text);
                MessageBox.Show("User registered successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
