using EDP_Project.Models;
using EDP_Project.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MySqlConnector;

namespace EDP_Project;

public partial class PublishersPage : ContentPage
{
    private readonly DatabaseService _databaseService;
    private ObservableCollection<Publisher> _publishers = new();
    
    public PublishersPage()
    {
        InitializeComponent();
        _databaseService = new DatabaseService();
        LoadPublishersAsync();
    }

    private async void LoadPublishersAsync()
    {
        try
        {
            Debug.WriteLine("Loading publishers data...");
            
            // Clear existing publishers
            _publishers.Clear();
            
            // Get publishers from database
            var loadedPublishers = await _databaseService.GetPublishersAsync();
            
            // Add each publisher to our collection
            foreach (var publisher in loadedPublishers)
            {
                _publishers.Add(publisher);
            }
            
            Debug.WriteLine($"Publishers loaded: {_publishers.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                PublishersListView.ItemsSource = null;
                PublishersListView.ItemsSource = _publishers;
                
                // Update count label if it exists
                if (PublisherCountLabel != null)
                    PublisherCountLabel.Text = $"Publishers: {_publishers.Count}";
            });
            
            if (_publishers.Count == 0)
            {
                Debug.WriteLine("No publishers returned from database");
                await DisplayAlert("Information", "No publishers found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error loading publishers: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load publishers: {ex.Message}", "OK");
        }
    }
    
    private async Task LoadPublishersDataAsync()
    {
        try
        {
            Debug.WriteLine("Refreshing publishers data...");
            
            // Clear existing publishers
            _publishers.Clear();
            
            // Get publishers from database
            var loadedPublishers = await _databaseService.GetPublishersAsync();
            
            // Add each publisher to our collection
            foreach (var publisher in loadedPublishers)
            {
                _publishers.Add(publisher);
            }
            
            Debug.WriteLine($"Publishers loaded: {_publishers.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                PublishersListView.ItemsSource = null;
                PublishersListView.ItemsSource = _publishers;
                
                // Update count label if it exists
                if (PublisherCountLabel != null)
                    PublisherCountLabel.Text = $"Publishers: {_publishers.Count}";
            });
            
            if (_publishers.Count == 0)
            {
                Debug.WriteLine("No publishers returned from database");
                await DisplayAlert("Information", "No publishers found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error refreshing publishers: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load publishers: {ex.Message}", "OK");
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
                
                // Test if the Publishers table exists and has records
                try {
                    using var connection = new MySqlConnection(_databaseService.ConnectionString);
                    await connection.OpenAsync();
                    using var command = new MySqlCommand("SELECT COUNT(*) FROM Publishers", connection);
                    var count = Convert.ToInt32(await command.ExecuteScalarAsync());
                    await DisplayAlert("Database Check", $"Publishers table has {count} records.", "OK");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Database Check", $"Error querying Publishers table: {ex.Message}", "OK");
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
        await DisplayAlert("Loading", "Refreshing publishers data...", "OK");
        
        // Call the method to load data
        await LoadPublishersDataAsync();
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