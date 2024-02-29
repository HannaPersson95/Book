using System.ComponentModel.DataAnnotations;

namespace Eksamen_Emne8.Models.Entity;

public class Book
{

    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Author { get; set; } = string.Empty;

    [Required]
    public int PublishedYear { get; set; }

    [Required]
    public string Isbn { get; set; } = string.Empty;

}
