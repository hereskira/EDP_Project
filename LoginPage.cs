using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP_Project
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            SubmitButton.Click += SubmitButton_Click;
            FPassButton.LinkClicked += FPassButton_LinkClicked;
            HomeButton.Click += HomeButton_Click;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // Add your logic here for when the form loads
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string username = Username_Input.Text;
            string password = Password_Input.Text;

            if (ValidateCredentials(username, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Navigate to HomePage instead of BooksPage
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Use parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FPassButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Redirect to FPassPage
            FPassPage fPassPage = new FPassPage();
            fPassPage.Show();
            this.Hide();
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
        }
    }
}
