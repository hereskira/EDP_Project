namespace EDP_Project.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public DateTime HireDate { get; set; }
    
    // Computed property for displaying full name
    public string FullName => $"{FirstName} {LastName}";
}