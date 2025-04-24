using EDP_Project.Models;
using EDP_Project.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MySqlConnector;

namespace EDP_Project;

public partial class AuthorsPage : ContentPage
{
    private readonly DatabaseService _databaseService;
    private ObservableCollection<Author> _authors = new(); // Initialize collection
    
    public AuthorsPage()
    {
        InitializeComponent();
        _databaseService = new DatabaseService();
        LoadAuthorsAsync();
    }

    private async void LoadAuthorsAsync()
    {
        try
        {
            Debug.WriteLine("Loading authors data...");
            
            // Clear existing authors
            _authors.Clear();
            
            // Get authors from database
            var loadedAuthors = await _databaseService.GetAuthorsAsync();
            
            // Add each author to our collection
            foreach (var author in loadedAuthors)
            {
                _authors.Add(author);
            }
            
            Debug.WriteLine($"Authors loaded: {_authors.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                AuthorsListView.ItemsSource = null;
                AuthorsListView.ItemsSource = _authors;
                
                // Update count label if it exists
                if (AuthorCountLabel != null)
                    AuthorCountLabel.Text = $"Authors: {_authors.Count}";
            });
            
            if (_authors.Count == 0)
            {
                Debug.WriteLine("No authors returned from database");
                await DisplayAlert("Information", "No authors found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error loading authors: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load authors: {ex.Message}", "OK");
        }
    }
    
    private async Task LoadAuthorsDataAsync()
    {
        try
        {
            Debug.WriteLine("Refreshing authors data...");
            
            // Clear existing authors
            _authors.Clear();
            
            // Get authors from database
            var loadedAuthors = await _databaseService.GetAuthorsAsync();
            
            // Add each author to our collection
            foreach (var author in loadedAuthors)
            {
                _authors.Add(author);
            }
            
            Debug.WriteLine($"Authors loaded: {_authors.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                AuthorsListView.ItemsSource = null;
                AuthorsListView.ItemsSource = _authors;
                
                // Update count label if it exists
                if (AuthorCountLabel != null)
                    AuthorCountLabel.Text = $"Authors: {_authors.Count}";
            });
            
            if (_authors.Count == 0)
            {
                Debug.WriteLine("No authors returned from database");
                await DisplayAlert("Information", "No authors found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error refreshing authors: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load authors: {ex.Message}", "OK");
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
                
                // Test if the Authors table exists and has records
                try {
                    using var connection = new MySqlConnection(_databaseService.ConnectionString);
                    await connection.OpenAsync();
                    using var command = new MySqlCommand("SELECT COUNT(*) FROM Authors", connection);
                    var count = Convert.ToInt32(await command.ExecuteScalarAsync());
                    await DisplayAlert("Database Check", $"Authors table has {count} records.", "OK");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Database Check", $"Error querying Authors table: {ex.Message}", "OK");
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
        await DisplayAlert("Loading", "Refreshing authors data...", "OK");
        
        // Call the method to load data
        await LoadAuthorsDataAsync();
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