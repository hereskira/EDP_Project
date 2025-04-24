using EDP_Project.Models;
using EDP_Project.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MySqlConnector;

namespace EDP_Project;

public partial class LoansPage : ContentPage
{
    private readonly DatabaseService _databaseService;
    private ObservableCollection<Loan> _loans = new();
    
    public LoansPage()
    {
        InitializeComponent();
        _databaseService = new DatabaseService();
        LoadLoansAsync();
    }

    private async void LoadLoansAsync()
    {
        try
        {
            Debug.WriteLine("Loading loans data...");
            
            // Clear existing loans
            _loans.Clear();
            
            // Get loans from database
            var loadedLoans = await _databaseService.GetLoansAsync();
            
            // Add each loan to our collection
            foreach (var loan in loadedLoans)
            {
                _loans.Add(loan);
            }
            
            Debug.WriteLine($"Loans loaded: {_loans.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                LoansListView.ItemsSource = null;
                LoansListView.ItemsSource = _loans;
                
                // Update count label if it exists
                if (LoanCountLabel != null)
                    LoanCountLabel.Text = $"Loans: {_loans.Count}";
            });
            
            if (_loans.Count == 0)
            {
                Debug.WriteLine("No loans returned from database");
                await DisplayAlert("Information", "No loans found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error loading loans: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load loans: {ex.Message}", "OK");
        }
    }
    
    private async Task LoadLoansDataAsync()
    {
        try
        {
            Debug.WriteLine("Refreshing loans data...");
            
            // Clear existing loans
            _loans.Clear();
            
            // Get loans from database
            var loadedLoans = await _databaseService.GetLoansAsync();
            
            // Add each loan to our collection
            foreach (var loan in loadedLoans)
            {
                _loans.Add(loan);
            }
            
            Debug.WriteLine($"Loans loaded: {_loans.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                LoansListView.ItemsSource = null;
                LoansListView.ItemsSource = _loans;
                
                // Update count label if it exists
                if (LoanCountLabel != null)
                    LoanCountLabel.Text = $"Loans: {_loans.Count}";
            });
            
            if (_loans.Count == 0)
            {
                Debug.WriteLine("No loans returned from database");
                await DisplayAlert("Information", "No loans found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error refreshing loans: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load loans: {ex.Message}", "OK");
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
                
                // Test if the Loans table exists and has records
                try {
                    using var connection = new MySqlConnection(_databaseService.ConnectionString);
                    await connection.OpenAsync();
                    using var command = new MySqlCommand("SELECT COUNT(*) FROM Loans", connection);
                    var count = Convert.ToInt32(await command.ExecuteScalarAsync());
                    await DisplayAlert("Database Check", $"Loans table has {count} records.", "OK");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Database Check", $"Error querying Loans table: {ex.Message}", "OK");
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
        await DisplayAlert("Loading", "Refreshing loans data...", "OK");
        
        // Call the method to load data
        await LoadLoansDataAsync();
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