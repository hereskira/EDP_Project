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
    public partial class FPassPage1 : Form
    {
        private string _email;

        public FPassPage1(string email)
        {
            InitializeComponent();
            _email = email; // Store the email address

            // Attach event handlers
            LoadSecButton.Click += LoadSecButton_Click;
            VerifyButton.Click += VerifyButton_Click;
            BackButton.LinkClicked += BackButton_LinkClicked; // Attach BackButton event
        }

        private void FPassPage1_Load(object sender, EventArgs e)
        {
            LoadSecurityQuestion(); // Load the security question when the form loads
        }

        private void LoadSecButton_Click(object sender, EventArgs e)
        {
            LoadSecurityQuestion(); // Reload the security question when the button is clicked
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            string answer = SecQuesAnswer.Text.Trim();

            if (string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Please enter an answer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the answer matches the security_answer in the database
            if (IsAnswerCorrect(_email, answer))
            {
                MessageBox.Show("Answer is correct!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Pass the email to FPassPage2 and navigate to it
                FPassPage2 fPassPage2 = new FPassPage2(_email);
                fPassPage2.Show();
                this.Close(); // Close the current form
            }
            else
            {
                MessageBox.Show("Incorrect answer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate back to the previous page (FPassPage)
            FPassPage fPassPage = new FPassPage();
            fPassPage.Show();
            this.Close(); // Close the current form
        }

        private void LoadSecurityQuestion()
        {
            string securityQuestion = GetSecurityQuestion(_email);
            if (!string.IsNullOrEmpty(securityQuestion))
            {
                SecQuesDisplay.Text = securityQuestion; // Display the security question
            }
            else
            {
                MessageBox.Show("No security question found for the provided email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetSecurityQuestion(string email)
        {
            string securityQuestion = null;
            string query = @"
                SELECT sq.question_text 
                FROM users u
                INNER JOIN security_questions sq ON u.security_question = sq.question_id
                WHERE u.email = @Email";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                securityQuestion = reader["question_text"].ToString();
                                Console.WriteLine($"Security Question Retrieved: {securityQuestion}"); // Debug message
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching the security question: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return securityQuestion;
        }
        private bool IsAnswerCorrect(string email, string answer)
        {
            bool isCorrect = false;
            string query = "SELECT COUNT(*) FROM users WHERE email = @Email AND security_answer = @Answer";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Answer", answer);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        isCorrect = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while verifying the answer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isCorrect;
        }
    }
}