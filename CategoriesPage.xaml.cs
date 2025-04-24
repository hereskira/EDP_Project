using EDP_Project.Models;
using EDP_Project.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MySqlConnector;

namespace EDP_Project;

public partial class CategoriesPage : ContentPage
{
    private readonly DatabaseService _databaseService;
    private ObservableCollection<Category> _categories = new(); // Initialize collection
    
    public CategoriesPage()
    {
        InitializeComponent();
        _databaseService = new DatabaseService();
        LoadCategoriesAsync();
    }

    private async void LoadCategoriesAsync()
    {
        try
        {
            Debug.WriteLine("Loading categories data...");
            
            // Clear existing categories
            _categories.Clear();
            
            // Get categories from database
            var loadedCategories = await _databaseService.GetCategoriesAsync();
            
            // Add each category to our collection
            foreach (var category in loadedCategories)
            {
                _categories.Add(category);
            }
            
            Debug.WriteLine($"Categories loaded: {_categories.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                CategoriesListView.ItemsSource = null;
                CategoriesListView.ItemsSource = _categories;
                
                // Update count label if it exists
                if (CategoryCountLabel != null)
                    CategoryCountLabel.Text = $"Categories: {_categories.Count}";
            });
            
            if (_categories.Count == 0)
            {
                Debug.WriteLine("No categories returned from database");
                await DisplayAlert("Information", "No categories found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error loading categories: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load categories: {ex.Message}", "OK");
        }
    }
    
    private async Task LoadCategoriesDataAsync()
    {
        try
        {
            Debug.WriteLine("Refreshing categories data...");
            
            // Clear existing categories
            _categories.Clear();
            
            // Get categories from database
            var loadedCategories = await _databaseService.GetCategoriesAsync();
            
            // Add each category to our collection
            foreach (var category in loadedCategories)
            {
                _categories.Add(category);
            }
            
            Debug.WriteLine($"Categories loaded: {_categories.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                CategoriesListView.ItemsSource = null;
                CategoriesListView.ItemsSource = _categories;
                
                // Update count label if it exists
                if (CategoryCountLabel != null)
                    CategoryCountLabel.Text = $"Categories: {_categories.Count}";
            });
            
            if (_categories.Count == 0)
            {
                Debug.WriteLine("No categories returned from database");
                await DisplayAlert("Information", "No categories found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error refreshing categories: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load categories: {ex.Message}", "OK");
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
                
                // Test if the Categories table exists and has records
                try {
                    using var connection = new MySqlConnection(_databaseService.ConnectionString);
                    await connection.OpenAsync();
                    using var command = new MySqlCommand("SELECT COUNT(*) FROM Categories", connection);
                    var count = Convert.ToInt32(await command.ExecuteScalarAsync());
                    await DisplayAlert("Database Check", $"Categories table has {count} records.", "OK");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Database Check", $"Error querying Categories table: {ex.Message}", "OK");
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
        await DisplayAlert("Loading", "Refreshing categories data...", "OK");
        
        // Call the method to load data
        await LoadCategoriesDataAsync();
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        await this.LogoutAsync(); // Use extension method on "this" page
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