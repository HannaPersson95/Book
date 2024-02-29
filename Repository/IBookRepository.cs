using Eksamen_Emne8.Models.Entity;

namespace Eksamen_Emne8.Repository;

public interface IBookRepository
{
    Task<ICollection<Book>> getBooksAsync();

    Task<Book?> getBookByIdAsync(int id);



}
