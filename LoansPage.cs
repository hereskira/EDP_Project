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
            LoadLoansData();
            AuthorsButton.Click += AuthorsButton_Click;
            BooksButton.Click += BooksButton_Click;
            CategoriesButton.Click += CategoriesButton_Click;
            EmployeesButton.Click += EmployeesButton_Click;
            MembersButton.Click += MembersButton_Click;
            PublishersButton.Click += PublishersButton_Click;
        }

        private void LoansData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                            LoansData.DataSource = loansTable; // Bind the data to the DataGridView
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
    }
}
