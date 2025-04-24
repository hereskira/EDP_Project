using MySqlConnector;
using EDP_Project.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace EDP_Project.Services;

public class DatabaseService
{
    private readonly string connectionString;

    public DatabaseService()
    {
        connectionString = "Server=127.0.0.1;Port=3306;Database=libsys;User=root;Password=mysqlkira;";
    }

        public async Task<ObservableCollection<Book>> GetBooksAsync()
    {
        ObservableCollection<Book> books = new ObservableCollection<Book>();
    
        try
        {
            using MySqlConnection connection = new MySqlConnection(connectionString);
            Debug.WriteLine("Attempting to connect to database...");
            await connection.OpenAsync();
            Debug.WriteLine("Database connection opened successfully");
    
            string query = "SELECT book_id, title, author_id, publisher_id, category_id, publication_year, price, available_copies FROM Books";
            Debug.WriteLine($"Executing query: {query}");
            
            using MySqlCommand command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();
            
            int count = 0;
            while (await reader.ReadAsync())
            {
                count++;
                Book book = new Book
                {
                    BookId = reader.GetInt32(0),
                    Title = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    AuthorId = reader.GetInt32(2),
                    PublisherId = reader.GetInt32(3),
                    CategoryId = reader.GetInt32(4),
                    PublicationYear = reader.GetInt32(5),
                    Price = reader.GetDecimal(6),
                    AvailableCopies = reader.GetInt32(7)
                };
                
                books.Add(book);
                Debug.WriteLine($"Added book: {book.BookId} - {book.Title}");
            }
            
            Debug.WriteLine($"Total books retrieved: {count}");
            return books;
        }
        catch (MySqlException ex)
        {
            Debug.WriteLine($"MySQL error: {ex.Message}");
            Debug.WriteLine($"Error code: {ex.Number}");
            throw;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"General error: {ex.Message}");
            throw;
        }
    }

        public string ConnectionString => connectionString;
    
    public async Task<bool> TestConnectionAsync()
    {
        try
        {
            using MySqlConnection connection = new MySqlConnection(connectionString);
            Debug.WriteLine("Testing database connection...");
            await connection.OpenAsync();
            Debug.WriteLine("Connection test successful");
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Connection test failed: {ex.Message}");
            return false;
        }
    }

        // Add this method to your DatabaseService.cs file
    public async Task<List<Author>> GetAuthorsAsync()
    {
        List<Author> authors = new();
        try
        {
            using var connection = new MySqlConnection(ConnectionString);
            await connection.OpenAsync();
            
            string sql = "SELECT author_id, name, biography FROM Authors";
            using var command = new MySqlCommand(sql, connection);
            using var reader = await command.ExecuteReaderAsync();
            
            while (await reader.ReadAsync())
            {
                authors.Add(new Author
                {
                    AuthorId = reader.GetInt32("author_id"),
                    Name = reader.GetString("name"),
                    Biography = reader.IsDBNull(reader.GetOrdinal("biography")) ? string.Empty : reader.GetString("biography")
                });
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error getting authors: {ex.Message}");
            throw;
        }
        
        return authors;
    }

        // Add this method to your DatabaseService class
    public async Task<ObservableCollection<Category>> GetCategoriesAsync()
    {
        ObservableCollection<Category> categories = new ObservableCollection<Category>();
        
        try
        {
            using MySqlConnection connection = new MySqlConnection(connectionString);
            Debug.WriteLine("Attempting to connect to database for categories...");
            await connection.OpenAsync();
            Debug.WriteLine("Database connection opened successfully");
            
            string query = "SELECT category_id, name, description FROM Categories";
            Debug.WriteLine($"Executing query: {query}");
            
            using MySqlCommand command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();
            
            int count = 0;
            while (await reader.ReadAsync())
            {
                count++;
                Category category = new Category
                {
                    CategoryId = reader.GetInt32("category_id"),
                    Name = reader.IsDBNull(reader.GetOrdinal("name")) ? string.Empty : reader.GetString("name"),
                    Description = reader.IsDBNull(reader.GetOrdinal("description")) ? string.Empty : reader.GetString("description")
                };
                
                categories.Add(category);
                Debug.WriteLine($"Added category: {category.CategoryId} - {category.Name}");
            }
            
            Debug.WriteLine($"Total categories retrieved: {count}");
            return categories;
        }
        catch (MySqlException ex)
        {
            Debug.WriteLine($"MySQL error: {ex.Message}");
            Debug.WriteLine($"Error code: {ex.Number}");
            throw;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"General error: {ex.Message}");
            throw;
        }
    }
}