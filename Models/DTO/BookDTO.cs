using System.ComponentModel.DataAnnotations;

namespace Eksamen_Emne8.Models.DTO;

public class BookDTO
{
    public BookDTO(int id, string title, string author, int publishedYear, string isbn)
    {
        Id = id;
        Title = title;
        Author = author;
        PublishedYear = publishedYear;
        Isbn = isbn;
    }

    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;

    public int PublishedYear { get; set; }

    public string Isbn { get; set; } = string.Empty;


}
