namespace EDP_Project.Models;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; } = string.Empty; // Initialize to empty string
    public int AuthorId { get; set; }
    public int PublisherId { get; set; }
    public int CategoryId { get; set; }
    public int PublicationYear { get; set; }
    public decimal Price { get; set; }
    public int AvailableCopies { get; set; }
}