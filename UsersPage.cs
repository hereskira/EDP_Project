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
    public partial class UsersPage : Form
    {
        public UsersPage()
        {
            InitializeComponent();

            // Attach event handlers
            LoadButton.Click += LoadButton_Click;
            SaveButton.Click += SaveButton_Click;
            SearchUsername.KeyDown += SearchUsername_KeyDown;
            UpdateButton.Click += UpdateButton_Click;
            DeleteButton.Click += DeleteButton_Click;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    string query = "SELECT question_id, question_text FROM security_questions";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            SecQuesInput.Items.Clear(); // Clear existing items
                            while (reader.Read())
                            {
                                // Add security questions to the ComboBox
                                SecQuesInput.Items.Add(new ComboBoxItem
                                {
                                    Text = reader["question_text"].ToString(),
                                    Value = reader["question_id"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading security questions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string username = UserInput.Text.Trim();
            string fullName = NameInput.Text.Trim();
            string email = EmailInput.Text.Trim();
            string password = PassInput.Text.Trim();
            string securityAnswer = SecAnsInput.Text.Trim();
            ComboBoxItem selectedQuestion = SecQuesInput.SelectedItem as ComboBoxItem;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || selectedQuestion == null || string.IsNullOrEmpty(securityAnswer))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    // Check if username or email already exists
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @Username OR email = @Email";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Username", username);
                        checkCommand.Parameters.AddWithValue("@Email", email);

                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("The username or email is already in use. Please choose a different one.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert the new user
                    string insertQuery = @"
                        INSERT INTO users (username, full_name, email, password, security_question, security_answer)
                        VALUES (@Username, @FullName, @Email, @Password, @SecurityQuestion, @SecurityAnswer)";
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Username", username);
                        insertCommand.Parameters.AddWithValue("@FullName", fullName);
                        insertCommand.Parameters.AddWithValue("@Email", email);
                        insertCommand.Parameters.AddWithValue("@Password", password);
                        insertCommand.Parameters.AddWithValue("@SecurityQuestion", selectedQuestion.Value);
                        insertCommand.Parameters.AddWithValue("@SecurityAnswer", securityAnswer);

                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("User record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear all fields after successful save
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the user record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            UserInput.Text = string.Empty;
            NameInput.Text = string.Empty;
            EmailInput.Text = string.Empty;
            PassInput.Text = string.Empty;
            SecAnsInput.Text = string.Empty;
            SecQuesInput.SelectedIndex = -1; // Reset ComboBox selection
        }

        // Helper class for ComboBox items
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text; // Display the question text in the ComboBox
            }
        }
        private void SearchUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = SearchUsername.Text.Trim();

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter a username to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (MySqlConnection connection = DatabaseService.GetConnection())
                    {
                        string query = "SELECT full_name, email, password FROM users WHERE username = @Username";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Populate the fields with the user's credentials
                                    UpdateName.Text = reader["full_name"].ToString();
                                    UpdateEmail.Text = reader["email"].ToString();
                                    UpdatePass.Text = reader["password"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Username not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while searching for the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string username = SearchUsername.Text.Trim();
            string fullName = UpdateName.Text.Trim();
            string email = UpdateEmail.Text.Trim();
            string password = UpdatePass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    string updateQuery = @"
                    UPDATE users
                    SET full_name = @FullName, email = @Email, password = @Password
                    WHERE username = @Username";
                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No changes were made or the username does not exist.", "Update Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the user record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string username = DeleteUser.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    // Check if the username exists
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @Username";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Username", username);

                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (count == 0)
                        {
                            MessageBox.Show("The username does not exist.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Delete the user
                    string deleteQuery = "DELETE FROM users WHERE username = @Username";
                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@Username", username);

                        deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the DeleteUser TextBox after successful deletion
                        DeleteUser.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
