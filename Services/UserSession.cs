using EDP_Project.Models;

namespace EDP_Project.Services;

public static class UserSession
{
    // Current logged in user
    public static User CurrentUser { get; private set; }
    
    // Check if user is logged in
    public static bool IsLoggedIn => CurrentUser != null;
    
    // Login a user
    public static void Login(User user)
    {
        CurrentUser = user;
    }
    
    // Logout
    public static void Logout()
    {
        CurrentUser = null;
    }
}