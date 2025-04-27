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
    public partial class AddBooksPage : Form
    {
        public AddBooksPage()
        {
            InitializeComponent();
            LoadButton.Click += LoadButton_Click;
            AddBookButton.Click += AddBookButton_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            string authorQuery = "SELECT author_id, name FROM authors";
            string categoryQuery = "SELECT category_id, name FROM categories";
            string publisherQuery = "SELECT publisher_id, name FROM publishers";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    // Fetch authors
                    using (MySqlCommand authorCommand = new MySqlCommand(authorQuery, connection))
                    {
                        using (MySqlDataReader reader = authorCommand.ExecuteReader())
                        {
                            DataTable authorTable = new DataTable();
                            authorTable.Load(reader);

                            AuthorCBox.DataSource = authorTable;
                            AuthorCBox.DisplayMember = "name"; // Display author name
                            AuthorCBox.ValueMember = "author_id"; // Use author_id as the value
                        }
                    }

                    // Fetch categories
                    using (MySqlCommand categoryCommand = new MySqlCommand(categoryQuery, connection))
                    {
                        using (MySqlDataReader reader = categoryCommand.ExecuteReader())
                        {
                            DataTable categoryTable = new DataTable();
                            categoryTable.Load(reader);

                            CategoryCBox.DataSource = categoryTable;
                            CategoryCBox.DisplayMember = "name"; // Display category name
                            CategoryCBox.ValueMember = "category_id"; // Use category_id as the value
                        }
                    }

                    // Fetch publishers
                    using (MySqlCommand publisherCommand = new MySqlCommand(publisherQuery, connection))
                    {
                        using (MySqlDataReader reader = publisherCommand.ExecuteReader())
                        {
                            DataTable publisherTable = new DataTable();
                            publisherTable.Load(reader);

                            PublisherCBox.DataSource = publisherTable;
                            PublisherCBox.DisplayMember = "name"; // Display publisher name
                            PublisherCBox.ValueMember = "publisher_id"; // Use publisher_id as the value
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            // Collect input values
            string title = TitleInput.Text;
            string publicationYear = YearInput.Text;
            string price = PriceInput.Text;
            string availableCopies = AvailCopiesInput.Text;

            // Get selected values from combo boxes
            object selectedAuthor = AuthorCBox.SelectedValue;
            object selectedPublisher = PublisherCBox.SelectedValue;
            object selectedCategory = CategoryCBox.SelectedValue;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(publicationYear) ||
                string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(availableCopies) ||
                selectedAuthor == null || selectedPublisher == null || selectedCategory == null)
            {
                MessageBox.Show("Please fill in all fields and select valid options.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertQuery = @"
        INSERT INTO books (title, author_id, publisher_id, category_id, publication_year, price, available_copies)
        VALUES (@title, @AuthorId, @PublisherId, @CategoryId, @PublicationYear, @Price, @AvailableCopies)";

            try
            {
                using (MySqlConnection connection = DatabaseService.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@AuthorId", selectedAuthor);
                        command.Parameters.AddWithValue("@PublisherId", selectedPublisher);
                        command.Parameters.AddWithValue("@CategoryId", selectedCategory);
                        command.Parameters.AddWithValue("@PublicationYear", publicationYear);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@AvailableCopies", availableCopies);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the AddBooksPage window
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the book. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
