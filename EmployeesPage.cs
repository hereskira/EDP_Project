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
    public partial class EmployeesPage : Form
    {
        public EmployeesPage()
        {
            InitializeComponent();
            LoadEmployeesData();
            AuthorsButton.Click += AuthorsButton_Click;
            BooksButton.Click += BooksButton_Click;
            CategoriesButton.Click += CategoriesButton_Click;
            LoansButton.Click += LoansButton_Click;
            MembersButton.Click += MembersButton_Click;
            PublishersButton.Click += PublishersButton_Click;
        }
        private void LoadEmployeesData()
        {
            string query = "SELECT employee_id, first_name, last_name, role, hire_date FROM employees";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable employeesTable = new DataTable();
                            adapter.Fill(employeesTable);
                            EmployeesData.DataSource = employeesTable; // Bind the data to the DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading employees data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LoansButton_Click(object sender, EventArgs e)
        {
            // Navigate to LoansPage
            LoansPage loansPage = new LoansPage();
            loansPage.Show();
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
