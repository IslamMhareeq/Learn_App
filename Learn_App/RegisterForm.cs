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
                // Validate that all required fields are filled out
                if (string.IsNullOrEmpty(txtUsername.Text) ||
                    string.IsNullOrEmpty(txtPassword.Text) ||
                    string.IsNullOrEmpty(txtID.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    (!radioButton2.Checked && !radioButton1.Checked))
                {
                    MessageBox.Show("Please fill out all fields.");
                    return;
                }

                // Get the selected gender from the RadioButtons
                string selectedGender = null;
                if (radioButton2.Checked)
                {
                    selectedGender = "Male";
                }
                else if (radioButton1.Checked)
                {
                    selectedGender = "Female";
                }

                // Register the user with the selected gender
                userManager.RegisterUser(txtUsername.Text, txtPassword.Text, txtID.Text, txtEmail.Text, selectedGender);
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
            // Additional initialization code if needed
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Handle radio button checked change if needed
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Handle radio button checked change if needed
        }
    }
}
