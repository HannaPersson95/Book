using Eksamen_Emne8.Models.DTO;

namespace Eksamen_Emne8.Service;

public interface IBookService
{
    Task<IEnumerable<BookDTO>> GetBooksAsync();

    Task<BookDTO?> GetBookByIdAsync(int id); 


}
