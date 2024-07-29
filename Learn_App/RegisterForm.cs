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

            // Add items to the ComboBox in the constructor
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected gender from the ComboBox
                string selectedGender = comboBox1.SelectedItem?.ToString();

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
    }
}
