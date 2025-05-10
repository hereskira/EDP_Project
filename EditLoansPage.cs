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
    public partial class EditLoansPage : Form
    {
        private int LoanId;
        public EditLoansPage(int loanId)
        {
            InitializeComponent();
            LoanId = loanId;
            PopulateComboBoxes();
            LoadLoanDetails();
            AddLoanButton.Click += AddLoanButton_Click;
        }

        private void LoadLoanDetails()
        {
            string query = @"
        SELECT 
            loans.loan_date, 
            loans.due_date, 
            loans.is_paid, 
            loans.is_overdue, 
            loans.member_id, 
            loans.employee_id, 
            loans.book_id
        FROM loans
        WHERE loan_id = @LoanId";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LoanId", LoanId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate form controls with data
                                LoanDate.Value = reader.GetDateTime("loan_date");
                                DueDate.Value = reader.GetDateTime("due_date");
                                YesPaid.Checked = reader.GetBoolean("is_paid");
                                NoPaid.Checked = !reader.GetBoolean("is_paid");
                                YesOverdue.Checked = reader.GetBoolean("is_overdue");
                                NoOverdue.Checked = !reader.GetBoolean("is_overdue");
                                MemberCBox.SelectedValue = reader.GetInt32("member_id");
                                EmployeeCBox.SelectedValue = reader.GetInt32("employee_id");
                                BookCBox.SelectedValue = reader.GetInt32("book_id");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading loan details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveLoanDetails()
        {
            string query = @"
        UPDATE loans
        SET 
            loan_date = @LoanDate, 
            due_date = @DueDate, 
            is_paid = @IsPaid, 
            is_overdue = @IsOverdue, 
            member_id = @MemberId, 
            employee_id = @EmployeeId, 
            book_id = @BookId
        WHERE loan_id = @LoanId";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LoanDate", LoanDate.Value);
                        command.Parameters.AddWithValue("@DueDate", DueDate.Value);
                        command.Parameters.AddWithValue("@IsPaid", YesPaid.Checked);
                        command.Parameters.AddWithValue("@IsOverdue", YesOverdue.Checked);
                        command.Parameters.AddWithValue("@MemberId", MemberCBox.SelectedValue);
                        command.Parameters.AddWithValue("@EmployeeId", EmployeeCBox.SelectedValue);
                        command.Parameters.AddWithValue("@BookId", BookCBox.SelectedValue);
                        command.Parameters.AddWithValue("@LoanId", LoanId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Loan details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; // Close the form with success
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving loan details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddLoanButton_Click(object sender, EventArgs e)
        {
            SaveLoanDetails();
        }
        private void PopulateComboBoxes()
        {
            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    // Populate MemberCBox
                    string memberQuery = "SELECT member_id, CONCAT(first_name, ' ', last_name) AS member_name FROM members";
                    using (MySqlCommand memberCommand = new MySqlCommand(memberQuery, connection))
                    using (MySqlDataAdapter memberAdapter = new MySqlDataAdapter(memberCommand))
                    {
                        DataTable memberTable = new DataTable();
                        memberAdapter.Fill(memberTable);
                        MemberCBox.DataSource = memberTable;
                        MemberCBox.ValueMember = "member_id";
                        MemberCBox.DisplayMember = "member_name";
                    }

                    // Populate EmployeeCBox
                    string employeeQuery = "SELECT employee_id, CONCAT(first_name, ' ', last_name) AS employee_name FROM employees";
                    using (MySqlCommand employeeCommand = new MySqlCommand(employeeQuery, connection))
                    using (MySqlDataAdapter employeeAdapter = new MySqlDataAdapter(employeeCommand))
                    {
                        DataTable employeeTable = new DataTable();
                        employeeAdapter.Fill(employeeTable);
                        EmployeeCBox.DataSource = employeeTable;
                        EmployeeCBox.ValueMember = "employee_id";
                        EmployeeCBox.DisplayMember = "employee_name";
                    }

                    // Populate BookCBox
                    string bookQuery = "SELECT book_id, title FROM books";
                    using (MySqlCommand bookCommand = new MySqlCommand(bookQuery, connection))
                    using (MySqlDataAdapter bookAdapter = new MySqlDataAdapter(bookCommand))
                    {
                        DataTable bookTable = new DataTable();
                        bookAdapter.Fill(bookTable);
                        BookCBox.DataSource = bookTable;
                        BookCBox.ValueMember = "book_id";
                        BookCBox.DisplayMember = "title";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating combo boxes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
