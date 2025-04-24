using EDP_Project.Models;
using EDP_Project.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MySqlConnector;

namespace EDP_Project;

public partial class MembersPage : ContentPage
{
    private readonly DatabaseService _databaseService;
    private ObservableCollection<Member> _members = new();
    
    public MembersPage()
    {
        InitializeComponent();
        _databaseService = new DatabaseService();
        LoadMembersAsync();
    }

    private async void LoadMembersAsync()
    {
        try
        {
            Debug.WriteLine("Loading members data...");
            
            // Clear existing members
            _members.Clear();
            
            // Get members from database
            var loadedMembers = await _databaseService.GetMembersAsync();
            
            // Add each member to our collection
            foreach (var member in loadedMembers)
            {
                _members.Add(member);
            }
            
            Debug.WriteLine($"Members loaded: {_members.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                MembersListView.ItemsSource = null;
                MembersListView.ItemsSource = _members;
                
                // Update count label if it exists
                if (MemberCountLabel != null)
                    MemberCountLabel.Text = $"Members: {_members.Count}";
            });
            
            if (_members.Count == 0)
            {
                Debug.WriteLine("No members returned from database");
                await DisplayAlert("Information", "No members found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error loading members: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load members: {ex.Message}", "OK");
        }
    }
    
    private async Task LoadMembersDataAsync()
    {
        try
        {
            Debug.WriteLine("Refreshing members data...");
            
            // Clear existing members
            _members.Clear();
            
            // Get members from database
            var loadedMembers = await _databaseService.GetMembersAsync();
            
            // Add each member to our collection
            foreach (var member in loadedMembers)
            {
                _members.Add(member);
            }
            
            Debug.WriteLine($"Members loaded: {_members.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                MembersListView.ItemsSource = null;
                MembersListView.ItemsSource = _members;
                
                // Update count label if it exists
                if (MemberCountLabel != null)
                    MemberCountLabel.Text = $"Members: {_members.Count}";
            });
            
            if (_members.Count == 0)
            {
                Debug.WriteLine("No members returned from database");
                await DisplayAlert("Information", "No members found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error refreshing members: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load members: {ex.Message}", "OK");
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
                
                // Test if the Members table exists and has records
                try {
                    using var connection = new MySqlConnection(_databaseService.ConnectionString);
                    await connection.OpenAsync();
                    using var command = new MySqlCommand("SELECT COUNT(*) FROM Members", connection);
                    var count = Convert.ToInt32(await command.ExecuteScalarAsync());
                    await DisplayAlert("Database Check", $"Members table has {count} records.", "OK");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Database Check", $"Error querying Members table: {ex.Message}", "OK");
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
        await DisplayAlert("Loading", "Refreshing members data...", "OK");
        
        // Call the method to load data
        await LoadMembersDataAsync();
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