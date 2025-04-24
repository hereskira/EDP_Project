using EDP_Project.Models;
using EDP_Project.Services;
using System.Diagnostics;

namespace EDP_Project;

public partial class ForgotPasswordPage : ContentPage
{
    private readonly DatabaseService _databaseService;
    private string _userEmail;
    private User _currentUser;
    
    public ForgotPasswordPage()
    {
        InitializeComponent();
        _databaseService = new DatabaseService();
    }
    
    // Email verification step
    private async void OnVerifyEmailClicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text?.Trim();
        
        if (string.IsNullOrEmpty(email))
        {
            ShowEmailError("Please enter your email address");
            return;
        }
        
        SetEmailLoading(true);
        
        try
        {
            bool isValidEmail = await _databaseService.ValidateUserEmailAsync(email);
            
            if (isValidEmail)
            {
                // Email is valid, get user details
                _currentUser = await _databaseService.GetUserByEmailAsync(email);
                _userEmail = email;
                
                if (_currentUser != null)
                {
                    // If security question is available, show security question step
                    if (!string.IsNullOrEmpty(_currentUser.SecurityQuestion))
                    {
                        SecurityQuestionLabel.Text = _currentUser.SecurityQuestion;
                        ShowSecurityStep();
                    }
                    else
                    {
                        // If no security question is set, go directly to password reset
                        ShowNewPasswordStep();
                    }
                }
                else
                {
                    ShowEmailError("Account not found");
                }
            }
            else
            {
                ShowEmailError("Email address not found");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Email verification error: {ex.Message}");
            ShowEmailError("An error occurred. Please try again.");
        }
        finally
        {
            SetEmailLoading(false);
        }
    }
    
    // Security question verification
    private void OnVerifyAnswerClicked(object sender, EventArgs e)
    {
        string answer = SecurityAnswerEntry.Text?.Trim();
        
        if (string.IsNullOrEmpty(answer))
        {
            ShowSecurityError("Please enter your answer");
            return;
        }
        
        // Simple case-insensitive comparison
        if (answer.Equals(_currentUser.SecurityAnswer, StringComparison.OrdinalIgnoreCase))
        {
            ShowNewPasswordStep();
        }
        else
        {
            ShowSecurityError("Incorrect answer");
        }
    }
    
    // Password reset
    private async void OnResetPasswordClicked(object sender, EventArgs e)
    {
        string newPassword = NewPasswordEntry.Text;
        string confirmPassword = ConfirmPasswordEntry.Text;
        
        if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
        {
            ShowPasswordError("Please enter and confirm your new password");
            return;
        }
        
        if (newPassword.Length < 6)
        {
            ShowPasswordError("Password must be at least 6 characters long");
            return;
        }
        
        if (newPassword != confirmPassword)
        {
            ShowPasswordError("Passwords do not match");
            return;
        }
        
        SetPasswordLoading(true);
        
        try
        {
            bool success = await _databaseService.ResetPasswordAsync(_userEmail, newPassword);
            
            if (success)
            {
                await DisplayAlert("Success", "Your password has been reset successfully!", "OK");
                await Navigation.PopAsync(); // Return to login page
            }
            else
            {
                ShowPasswordError("Password reset failed. Please try again.");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Password reset error: {ex.Message}");
            ShowPasswordError("An error occurred. Please try again.");
        }
        finally
        {
            SetPasswordLoading(false);
        }
    }
    
    // Navigation methods
    private void OnBackToLoginClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
    
    private void OnBackToEmailClicked(object sender, EventArgs e)
    {
        ShowEmailStep();
    }
    
    // UI state management
    private void ShowEmailStep()
    {
        StepInfoLabel.Text = "Please enter your email address to recover your account";
        EmailFrame.IsVisible = true;
        SecurityFrame.IsVisible = false;
        NewPasswordFrame.IsVisible = false;
    }
    
    private void ShowSecurityStep()
    {
        StepInfoLabel.Text = "Please answer your security question";
        EmailFrame.IsVisible = false;
        SecurityFrame.IsVisible = true;
        NewPasswordFrame.IsVisible = false;
    }
    
    private void ShowNewPasswordStep()
    {
        StepInfoLabel.Text = "Create a new password";
        EmailFrame.IsVisible = false;
        SecurityFrame.IsVisible = false;
        NewPasswordFrame.IsVisible = true;
    }
    
    // Error display
    private void ShowEmailError(string message)
    {
        EmailErrorMessage.Text = message;
        EmailErrorMessage.IsVisible = true;
    }
    
    private void ShowSecurityError(string message)
    {
        SecurityErrorMessage.Text = message;
        SecurityErrorMessage.IsVisible = true;
    }
    
    private void ShowPasswordError(string message)
    {
        PasswordErrorMessage.Text = message;
        PasswordErrorMessage.IsVisible = true;
    }
    
    // Loading indicators
    private void SetEmailLoading(bool isLoading)
    {
        EmailLoadingIndicator.IsRunning = isLoading;
        EmailLoadingIndicator.IsVisible = isLoading;
        VerifyEmailButton.IsEnabled = !isLoading;
        EmailEntry.IsEnabled = !isLoading;
    }
    
    private void SetSecurityLoading(bool isLoading)
    {
        SecurityLoadingIndicator.IsRunning = isLoading;
        SecurityLoadingIndicator.IsVisible = isLoading;
        VerifyAnswerButton.IsEnabled = !isLoading;
        SecurityAnswerEntry.IsEnabled = !isLoading;
    }
    
    private void SetPasswordLoading(bool isLoading)
    {
        PasswordLoadingIndicator.IsRunning = isLoading;
        PasswordLoadingIndicator.IsVisible = isLoading;
        ResetPasswordButton.IsEnabled = !isLoading;
        NewPasswordEntry.IsEnabled = !isLoading;
        ConfirmPasswordEntry.IsEnabled = !isLoading;
    }
}