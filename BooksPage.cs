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
    public partial class BooksPage : Form
    {
        public BooksPage()
        {
            InitializeComponent();
            Load += BooksPage_Load;
            AuthorsButton.Click += AuthorsButton_Click;
            CategoriesButton.Click += CategoriesButton_Click;
            EmployeesButton.Click += EmployeesButton_Click;
            LoansButton.Click += LoansButton_Click;
            MembersButton.Click += MembersButton_Click;
            PublishersButton.Click += PublishersButton_Click;
        }

        private void BooksPage_Load(object sender, EventArgs e)
        {
            LoadBooksData();
        }
        private void LoadBooksData()
        {
            string query = @"
        SELECT 
            books.book_id, 
            books.title, 
            authors.name AS author_name, 
            publishers.name AS publisher_name, 
            categories.name AS category_name, 
            books.publication_year, 
            books.price, 
            books.available_copies
        FROM books
        LEFT JOIN authors ON books.author_id = authors.author_id
        LEFT JOIN publishers ON books.publisher_id = publishers.publisher_id
        LEFT JOIN categories ON books.category_id = categories.category_id";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable booksTable = new DataTable();
                            adapter.Fill(booksTable);
                            BooksData.DataSource = booksTable; // Bind the data to the DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading books data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BooksData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events if needed
        }

        private void AuthorsButton_Click(object sender, EventArgs e)
        {
            // Navigate to AuthorsPage
            AuthorsPage authorsPage = new AuthorsPage();
            authorsPage.Show();
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
