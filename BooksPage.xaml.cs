using EDP_Project.Models;
using EDP_Project.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MySqlConnector;
// Add this at the top with your other using statements
using Microsoft.Maui.Controls;

namespace EDP_Project;

public partial class BooksPage : ContentPage
{
    private readonly DatabaseService _databaseService;
    private ObservableCollection<Book> _books = new(); // Initialize collection
    
    public BooksPage()
    {
        InitializeComponent();
        _databaseService = new DatabaseService();
        LoadBooksAsync();
    }

        private async void LoadBooksAsync()
    {
        try
        {
            Debug.WriteLine("Loading books data...");
            
            // Clear existing books
            _books.Clear();
            
            // Get books from database
            var loadedBooks = await _databaseService.GetBooksAsync();
            
            // Add each book to our collection
            foreach (var book in loadedBooks)
            {
                _books.Add(book);
            }
            
            Debug.WriteLine($"Books loaded: {_books.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                BooksListView.ItemsSource = null;
                BooksListView.ItemsSource = _books;
                
                // Update count label if it exists
                if (BookCountLabel != null)
                    BookCountLabel.Text = $"Books: {_books.Count}";
            });
            
            if (_books.Count == 0)
            {
                Debug.WriteLine("No books returned from database");
                await DisplayAlert("Information", "No books found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error loading books: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load books: {ex.Message}", "OK");
        }
    }
    
    private async Task LoadBooksDataAsync()
    {
        try
        {
            Debug.WriteLine("Refreshing books data...");
            
            // Clear existing books
            _books.Clear();
            
            // Get books from database
            var loadedBooks = await _databaseService.GetBooksAsync();
            
            // Add each book to our collection
            foreach (var book in loadedBooks)
            {
                _books.Add(book);
            }
            
            Debug.WriteLine($"Books loaded: {_books.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                BooksListView.ItemsSource = null;
                BooksListView.ItemsSource = _books;
                
                // Update count label if it exists
                if (BookCountLabel != null)
                    BookCountLabel.Text = $"Books: {_books.Count}";
            });
            
            if (_books.Count == 0)
            {
                Debug.WriteLine("No books returned from database");
                await DisplayAlert("Information", "No books found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error refreshing books: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load books: {ex.Message}", "OK");
        }
    }

        private async void OnTestConnectionClicked(object sender, EventArgs e)
    {
        try
        {
            bool isConnected = await _databaseService.TestConnectionAsync();
            if (isConnected)
            {
                await DisplayAlert("Connection Test", "Successfully connected to the database!", "OK");
                
                // Test if the Books table exists and has records
                try {
                    using var connection = new MySqlConnection(_databaseService.ConnectionString);
                    await connection.OpenAsync();
                    using var command = new MySqlCommand("SELECT COUNT(*) FROM Books", connection);
                    var count = Convert.ToInt32(await command.ExecuteScalarAsync());
                    await DisplayAlert("Database Check", $"Books table has {count} records.", "OK");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Database Check", $"Error querying Books table: {ex.Message}", "OK");
                }
            }
            else
            {
                await DisplayAlert("Connection Test", "Failed to connect to the database. Check your connection settings.", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Connection Error", $"An error occurred: {ex.Message}", "OK");
        }
    }

        private async void OnRefreshClicked(object sender, EventArgs e)
    {
        // Show loading indicator
        await DisplayAlert("Loading", "Refreshing books data...", "OK");
        
        // Call the method to load data
        await LoadBooksDataAsync();
    }

        // Add this method to your BooksPage class
    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        // Ask for confirmation
        bool confirmed = await DisplayAlert(
            "Logout Confirmation", 
            "Are you sure you want to log out?", 
            "Yes", 
            "No");
        
        if (confirmed)
        {
            // Clear the current user session
            UserSession.Logout();
            
            // Navigate back to login page
            Application.Current.MainPage = new NavigationPage(new LoginPage());
            
            // Optionally show a toast or message
            Debug.WriteLine("User logged out successfully");
        }
    }

    private async void OnAuthorsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AuthorsPage());
    }

    private async void OnBooksClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BooksPage());
    }

    private async void OnCategoriesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoriesPage());
    }

    private async void OnEmployeesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EmployeesPage());
    }

    private async void OnLoansClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoansPage());
    }

    private async void OnMembersClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MembersPage());
    }

    private async void OnPublishersClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PublishersPage());
    }
}