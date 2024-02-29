using Eksamen_Emne8.Models.DTO;
using Eksamen_Emne8.Models.Entity;

namespace Eksamen_Emne8.Mappers;

public class BookMapper : IBookMapper<Book, BookDTO>
{
    public BookDTO MapToDTO(Book model)
    {
        return new BookDTO(model.Id, model.Title, model.Author, model.PublishedYear, model.Isbn);
    }

    public Book MapToModel(BookDTO dto)
    {
        return new Book()
        {
            Id = dto.Id,
            Title = dto.Title,
            Author = dto.Author,
            PublishedYear = dto.PublishedYear,
            Isbn = dto.Isbn


        };
    }
}
