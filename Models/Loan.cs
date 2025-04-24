namespace EDP_Project.Models;

public class Loan
{
    public int LoanId { get; set; }
    public int MemberId { get; set; }
    public int BookId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsPaid { get; set; }
    public bool IsOverdue { get; set; }
    
    // Helper property to display Yes/No for boolean values
    public string IsPaidText => IsPaid ? "Yes" : "No";
    public string IsOverdueText => IsOverdue ? "Yes" : "No";
}