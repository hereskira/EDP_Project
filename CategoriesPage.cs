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
    public partial class CategoriesPage : Form
    {
        public CategoriesPage()
        {
            InitializeComponent();
            Load += CategoriesPage_Load;
            AuthorsButton.Click += AuthorsButton_Click;
            BooksButton.Click += BooksButton_Click;
            EmployeesButton.Click += EmployeesButton_Click;
            LoansButton.Click += LoansButton_Click;
            MembersButton.Click += MembersButton_Click;
            PublishersButton.Click += PublishersButton_Click;
        }

        private void CategoriesPage_Load(object sender, EventArgs e)
        {
            LoadCategoriesData();
        }

        private void LoadCategoriesData()
        {
            string query = "SELECT category_id, name, description FROM categories";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable categoriesTable = new DataTable();
                            adapter.Fill(categoriesTable);
                            CategoriesData.DataSource = categoriesTable; // Bind the data to the DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading categories data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
