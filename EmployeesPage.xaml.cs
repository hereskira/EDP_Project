using EDP_Project.Models;
using EDP_Project.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MySqlConnector;

namespace EDP_Project;

public partial class EmployeesPage : ContentPage
{
    private readonly DatabaseService _databaseService;
    private ObservableCollection<Employee> _employees = new();
    
    public EmployeesPage()
    {
        InitializeComponent();
        _databaseService = new DatabaseService();
        LoadEmployeesAsync();
    }

    private async void LoadEmployeesAsync()
    {
        try
        {
            Debug.WriteLine("Loading employees data...");
            
            // Clear existing employees
            _employees.Clear();
            
            // Get employees from database
            var loadedEmployees = await _databaseService.GetEmployeesAsync();
            
            // Add each employee to our collection
            foreach (var employee in loadedEmployees)
            {
                _employees.Add(employee);
            }
            
            Debug.WriteLine($"Employees loaded: {_employees.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                EmployeesListView.ItemsSource = null;
                EmployeesListView.ItemsSource = _employees;
                
                // Update count label if it exists
                if (EmployeeCountLabel != null)
                    EmployeeCountLabel.Text = $"Employees: {_employees.Count}";
            });
            
            if (_employees.Count == 0)
            {
                Debug.WriteLine("No employees returned from database");
                await DisplayAlert("Information", "No employees found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error loading employees: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load employees: {ex.Message}", "OK");
        }
    }
    
    private async Task LoadEmployeesDataAsync()
    {
        try
        {
            Debug.WriteLine("Refreshing employees data...");
            
            // Clear existing employees
            _employees.Clear();
            
            // Get employees from database
            var loadedEmployees = await _databaseService.GetEmployeesAsync();
            
            // Add each employee to our collection
            foreach (var employee in loadedEmployees)
            {
                _employees.Add(employee);
            }
            
            Debug.WriteLine($"Employees loaded: {_employees.Count}");
            
            // Set the ItemsSource on the UI thread
            MainThread.BeginInvokeOnMainThread(() => {
                EmployeesListView.ItemsSource = null;
                EmployeesListView.ItemsSource = _employees;
                
                // Update count label if it exists
                if (EmployeeCountLabel != null)
                    EmployeeCountLabel.Text = $"Employees: {_employees.Count}";
            });
            
            if (_employees.Count == 0)
            {
                Debug.WriteLine("No employees returned from database");
                await DisplayAlert("Information", "No employees found in the database.", "OK");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error refreshing employees: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load employees: {ex.Message}", "OK");
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
                
                // Test if the Employees table exists and has records
                try {
                    using var connection = new MySqlConnection(_databaseService.ConnectionString);
                    await connection.OpenAsync();
                    using var command = new MySqlCommand("SELECT COUNT(*) FROM Employees", connection);
                    var count = Convert.ToInt32(await command.ExecuteScalarAsync());
                    await DisplayAlert("Database Check", $"Employees table has {count} records.", "OK");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Database Check", $"Error querying Employees table: {ex.Message}", "OK");
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
        await DisplayAlert("Loading", "Refreshing employees data...", "OK");
        
        // Call the method to load data
        await LoadEmployeesDataAsync();
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