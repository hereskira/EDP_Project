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
    public partial class AddLoansPage : Form
    {
        public AddLoansPage()
        {
            InitializeComponent();
            LoadButton.Click += LoadButton_Click;
            AddLoanButton.Click += AddLoanButton_Click;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = DatabaseService.GetConnection())
                {
                    // Fetch book titles and IDs
                    string booksQuery = "SELECT book_id, title FROM books";
                    using (var booksCommand = new MySqlCommand(booksQuery, connection))
                    {
                        using (var booksReader = booksCommand.ExecuteReader())
                        {
                            BookCBox.Items.Clear(); // Clear existing items
                            while (booksReader.Read())
                            {
                                string title = booksReader["title"].ToString();
                                string bookId = booksReader["book_id"].ToString();
                                BookCBox.Items.Add(new ComboBoxItem(title, bookId)); // Add book title and ID
                            }
                        }
                    }

                    // Fetch employee names and IDs using the fullname function
                    string employeesQuery = "SELECT employee_id, fullname(first_name, last_name) AS full_name FROM employees";
                    using (var employeesCommand = new MySqlCommand(employeesQuery, connection))
                    {
                        using (var employeesReader = employeesCommand.ExecuteReader())
                        {
                            EmployeeCBox.Items.Clear(); // Clear existing items
                            while (employeesReader.Read())
                            {
                                string fullName = employeesReader["full_name"].ToString();
                                string employeeId = employeesReader["employee_id"].ToString();
                                EmployeeCBox.Items.Add(new ComboBoxItem(fullName, employeeId)); // Add employee name and ID
                            }
                        }
                    }

                    // Fetch member names and IDs using the fullname function
                    string membersQuery = "SELECT member_id, fullname(first_name, last_name) AS full_name FROM members";
                    using (var membersCommand = new MySqlCommand(membersQuery, connection))
                    {
                        using (var membersReader = membersCommand.ExecuteReader())
                        {
                            MemberCBox.Items.Clear(); // Clear existing items
                            while (membersReader.Read())
                            {
                                string fullName = membersReader["full_name"].ToString();
                                string memberId = membersReader["member_id"].ToString();
                                MemberCBox.Items.Add(new ComboBoxItem(fullName, memberId)); // Add member name and ID
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddLoanButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = DatabaseService.GetConnection())
                {
                    // Determine the values for is_paid and is_overdue based on the selected RadioButtons
                    bool isPaid = YesPaid.Checked; // YesPaid = true, NoPaid = false
                    bool isOverdue = YesOverdue.Checked; // YesOverdue = true, NoOverdue = false

                    // Get the selected member's ID, book's ID, and employee's ID
                    if (MemberCBox.SelectedItem is ComboBoxItem selectedMember &&
                        BookCBox.SelectedItem is ComboBoxItem selectedBook &&
                        EmployeeCBox.SelectedItem is ComboBoxItem selectedEmployee)
                    {
                        string memberId = selectedMember.Value;
                        string bookId = selectedBook.Value;
                        string employeeId = selectedEmployee.Value;

                        // Get the selected dates from the DateTimePicker controls
                        string loanDate = LoanDate.Value.ToString("yyyy-MM-dd");
                        string dueDate = DueDate.Value.ToString("yyyy-MM-dd");

                        // Insert a new record into the loans table
                        string insertQuery = @"
                            INSERT INTO loans (member_id, book_id, employee_id, loan_date, due_date, is_paid, is_overdue)
                            VALUES (@memberId, @bookId, @employeeId, @loanDate, @dueDate, @isPaid, @isOverdue)";

                        using (var command = new MySqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@memberId", memberId);
                            command.Parameters.AddWithValue("@bookId", bookId);
                            command.Parameters.AddWithValue("@employeeId", employeeId);
                            command.Parameters.AddWithValue("@loanDate", loanDate);
                            command.Parameters.AddWithValue("@dueDate", dueDate);
                            command.Parameters.AddWithValue("@isPaid", isPaid);
                            command.Parameters.AddWithValue("@isOverdue", isOverdue);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Loan record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close(); // Close the form after successful insertion
                            }
                            else
                            {
                                MessageBox.Show("Failed to add loan record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a member, a book, and an employee.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    // Helper class to store member name and ID in ComboBox
    public class ComboBoxItem
    {
        public string Text { get; }
        public string Value { get; }

        public ComboBoxItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text; // Display the member name in the ComboBox
        }
    }
}