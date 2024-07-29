using System;
using System.Windows.Forms;
using Learn_App;

namespace Learn_App
{
    public partial class LoginForm : Form
    {
        private UserManager userManager = new UserManager();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                User user = userManager.AuthenticateUser(txtUsername.Text, txtPassword.Text);
                var form = new MainPage(user,userManager);
                this.Hide();
                form.Show();
                form.FormClosed += (s, args) => this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(userManager);
            registerForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
