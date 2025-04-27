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
    public partial class FPassPage2 : Form
    {
        private string _email;

        public FPassPage2(string email)
        {
            InitializeComponent();
            _email = email; // Store the email address

            // Attach event handlers
            ResetPassButton.Click += ResetPassButton_Click;
            BackButton.LinkClicked += BackButton_LinkClicked; // Attach BackButton event
        }

        private void ResetPassButton_Click(object sender, EventArgs e)
        {
            string newPassword = NewPassInput.Text.Trim();
            string confirmPassword = ConfirmPassInput.Text.Trim();

            // Validate that the inputs are not empty
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in both password fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that the passwords match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the password in the database
            if (ResetPassword(_email, newPassword))
            {
                MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to LoginPage
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Close(); // Close the current form
            }
            else
            {
                MessageBox.Show("An error occurred while resetting the password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate back to FPassPage1
            FPassPage1 fPassPage1 = new FPassPage1(_email); // Pass the email back to FPassPage1
            fPassPage1.Show();
            this.Close(); // Close the current form
        }
        private bool ResetPassword(string email, string newPassword)
        {
            bool isSuccess = false;
            string query = "UPDATE users SET password = @NewPassword WHERE email = @Email";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewPassword", newPassword);
                        command.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = command.ExecuteNonQuery();
                        isSuccess = rowsAffected > 0; // Check if any rows were updated
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isSuccess;
        }
    }
}