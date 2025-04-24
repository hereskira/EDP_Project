using EDP_Project.Services;

namespace EDP_Project.Services;

public static class LogoutHelper
{
    public static async Task LogoutAsync(this Page page)
    {
        // Ask for confirmation
        bool confirmed = await page.DisplayAlert(
            "Logout Confirmation", 
            "Are you sure you want to log out?", 
            "Yes", 
            "No");
        
        if (confirmed)
        {
            // Clear the current user session
            UserSession.Logout();
            
            // Navigate back to login page
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}