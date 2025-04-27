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
    public partial class MembersPage : Form
    {
        public MembersPage()
        {
            InitializeComponent();
            LoadMembersData();
            AuthorsButton.Click += AuthorsButton_Click;
            BooksButton.Click += BooksButton_Click;
            CategoriesButton.Click += CategoriesButton_Click;
            EmployeesButton.Click += EmployeesButton_Click;
            LoansButton.Click += LoansButton_Click;
            PublishersButton.Click += PublishersButton_Click;
        }

        private void MembersData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadMembersData()
        {
            string query = "SELECT member_id, first_name, last_name, date_of_birth, email FROM members";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable membersTable = new DataTable();
                            adapter.Fill(membersTable);
                            MembersData.DataSource = membersTable; // Bind the data to the DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading members data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LoansButton_Click(object sender, EventArgs e)
        {
            // Navigate to LoansPage
            LoansPage loansPage = new LoansPage();
            loansPage.Show();
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
