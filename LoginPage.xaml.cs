using EDP_Project.Models;
using EDP_Project.Services;
using System.Diagnostics;

namespace EDP_Project;

public partial class LoginPage : ContentPage
{
    private readonly DatabaseService _databaseService;
    
    public LoginPage()
    {
        InitializeComponent();
        _databaseService = new DatabaseService();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Hide previous error message if any
        ErrorMessage.IsVisible = false;
        
        // Get input values
        string username = UsernameEntry.Text?.Trim() ?? string.Empty;
        string password = PasswordEntry.Text ?? string.Empty;
        
        // Basic input validation
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            ShowError("Please enter both username and password");
            return;
        }
        
        // Show loading indicator
        SetLoading(true);
        
        try
        {
            // Attempt to authenticate
            var user = await _databaseService.AuthenticateUserAsync(username, password);
            
            if (user != null)
            {
                // Authentication successful
                UserSession.Login(user);
                
                // Show welcome message
                await DisplayAlert("Login Successful", $"Welcome, {user.FullName}!", "OK");
                
                // Navigate to the main page
                await Navigation.PushAsync(new BooksPage());
                
                // Remove login page from navigation stack
                Navigation.RemovePage(this);
            }
            else
            {
                // Authentication failed
                ShowError("Invalid username or password");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Login error: {ex.Message}");
            ShowError("An error occurred. Please try again.");
        }
        finally
        {
            // Hide loading indicator
            SetLoading(false);
        }
    }
    
    private void ShowError(string message)
    {
        ErrorMessage.Text = message;
        ErrorMessage.IsVisible = true;
    }
    
    private void SetLoading(bool isLoading)
    {
        // Update UI elements based on loading state
        LoginButton.IsEnabled = !isLoading;
        UsernameEntry.IsEnabled = !isLoading;
        PasswordEntry.IsEnabled = !isLoading;
        LoadingIndicator.IsRunning = isLoading;
        LoadingIndicator.IsVisible = isLoading;
    }
}