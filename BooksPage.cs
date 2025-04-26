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
            Load += BooksPage_Load; // Attach the event handler for form load
        }

        private void BooksPage_Load(object sender, EventArgs e)
        {
            LoadBooksData();
        }

        private void LoadBooksData()
        {
            string connectionString = "Server=localhost;Database=libsys;Uid=root;Pwd=mysqlkira;";
            string query = "SELECT book_id, title, author_id, publisher_id, category_id, publication_year, price, available_copies FROM books";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
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
    }
}
