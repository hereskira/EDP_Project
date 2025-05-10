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
    public partial class LoansPage : Form
    {
        public LoansPage()
        {
            InitializeComponent();
            AddDeleteButtonColumn();
            AddEditButtonColumn();
            LoadLoansData();
            AuthorsButton.Click += AuthorsButton_Click;
            BooksButton.Click += BooksButton_Click;
            CategoriesButton.Click += CategoriesButton_Click;
            EmployeesButton.Click += EmployeesButton_Click;
            MembersButton.Click += MembersButton_Click;
            PublishersButton.Click += PublishersButton_Click;
            AddLoanButton.Click += AddLoanButton_Click;
            RefreshButton.Click += RefreshButton_Click;
        }

        private void LoansData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == LoansData.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                // Handle Delete button click
                int loanId = Convert.ToInt32(LoansData.Rows[e.RowIndex].Cells["loan_id"].Value);
                var confirmResult = MessageBox.Show("Are you sure you want to delete this loan?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteLoan(loanId);
                    LoadLoansData();
                }
            }
            else if (e.ColumnIndex == LoansData.Columns["EditButton"].Index && e.RowIndex >= 0)
            {
                // Handle Edit button click
                int loanId = Convert.ToInt32(LoansData.Rows[e.RowIndex].Cells["loan_id"].Value);

                // Open the edit form and pass the loanId
                using (EditLoansPage editLoansPage = new EditLoansPage(loanId))
                {
                    if (editLoansPage.ShowDialog() == DialogResult.OK)
                    {
                        LoadLoansData(); // Refresh the data after editing
                    }
                }
            }
        }

        private void LoadLoansData()
        {
            string query = @"
            SELECT 
                loans.loan_id, 
                CONCAT(members.first_name, ' ', members.last_name) AS member_name, 
                books.title AS book_title, 
                CONCAT(employees.first_name, ' ', employees.last_name) AS employee_name, 
                loans.loan_date, 
                loans.due_date, 
                loans.is_paid, 
                loans.is_overdue
            FROM loans
            LEFT JOIN members ON loans.member_id = members.member_id
            LEFT JOIN books ON loans.book_id = books.book_id
            LEFT JOIN employees ON loans.employee_id = employees.employee_id";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable loansTable = new DataTable();
                            adapter.Fill(loansTable);

                            // Bind the data to the DataGridView
                            LoansData.DataSource = loansTable;

                            // Ensure is_paid and is_overdue are displayed as checkboxes
                            if (LoansData.Columns["is_paid"] is DataGridViewCheckBoxColumn == false)
                            {
                                DataGridViewCheckBoxColumn isPaidColumn = new DataGridViewCheckBoxColumn
                                {
                                    Name = "is_paid",
                                    HeaderText = "Is Paid",
                                    DataPropertyName = "is_paid",
                                    TrueValue = true,
                                    FalseValue = false
                                };
                                LoansData.Columns.Remove("is_paid");
                                LoansData.Columns.Add(isPaidColumn);
                            }

                            if (LoansData.Columns["is_overdue"] is DataGridViewCheckBoxColumn == false)
                            {
                                DataGridViewCheckBoxColumn isOverdueColumn = new DataGridViewCheckBoxColumn
                                {
                                    Name = "is_overdue",
                                    HeaderText = "Is Overdue",
                                    DataPropertyName = "is_overdue",
                                    TrueValue = true,
                                    FalseValue = false
                                };
                                LoansData.Columns.Remove("is_overdue");
                                LoansData.Columns.Add(isOverdueColumn);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading loans data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AuthorsButton_Click(object sender, EventArgs e)
        {
            // Navigate to AuthorsPage
            AuthorsPage authorsPage = new AuthorsPage();
            authorsPage.Show();
            this.Hide();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            // Navigate to BooksPage
            BooksPage booksPage = new BooksPage();
            booksPage.Show();
            this.Hide();
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            // Navigate to CategoriesPage
            CategoriesPage categoriesPage = new CategoriesPage();
            categoriesPage.Show();
            this.Hide();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            // Navigate to EmployeesPage
            EmployeesPage employeesPage = new EmployeesPage();
            employeesPage.Show();
            this.Hide();
        }

        private void MembersButton_Click(object sender, EventArgs e)
        {
            // Navigate to MembersPage
            MembersPage membersPage = new MembersPage();
            membersPage.Show();
            this.Hide();
        }

        private void PublishersButton_Click(object sender, EventArgs e)
        {
            // Navigate to PublishersPage
            PublishersPage publishersPage = new PublishersPage();
            publishersPage.Show();
            this.Hide();
        }
        private void AddLoanButton_Click(object sender, EventArgs e)
        {
            using (AddLoansPage addLoansPage = new AddLoansPage())
            {
                addLoansPage.ShowDialog(); // Open AddLoansPage as a dialog
            }
        }
        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Action",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            LoansData.Columns.Add(deleteButtonColumn);
        }

        private void DeleteLoan(int loanId)
        {
            string query = "DELETE FROM loans WHERE loan_id = @LoanId";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection()) // Connection is already open
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LoanId", loanId);
                        command.ExecuteNonQuery(); // No need to call connection.Open()
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the loan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddEditButtonColumn()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "EditButton",
                HeaderText = "Action",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            LoansData.Columns.Add(editButtonColumn);
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadLoansData(); // Reload the data from the database
        }

    }
}
