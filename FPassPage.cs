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
    public partial class FPassPage : Form
    {
        public FPassPage()
        {
            InitializeComponent();
            // Attach event handlers
            ContinueButton.Click += ContinueButton_Click;
            BackButton.LinkClicked += BackButton_LinkClicked;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            string email = EmailInput.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the email exists in the database
            if (IsEmailExisting(email))
            {
                MessageBox.Show("Email exists in the system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Pass the email to FPassPage1 and navigate to it
                FPassPage1 fPassPage1 = new FPassPage1(email);
                fPassPage1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email does not exist in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsEmailExisting(string email)
        {
            bool exists = false;
            string query = "SELECT COUNT(*) FROM users WHERE email = @Email";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        exists = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking the email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return exists;
        }

        private void BackButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Redirect to LoginPage
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }
    }
}
