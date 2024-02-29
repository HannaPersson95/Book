using Eksamen_Emne8.Mappers;
using Eksamen_Emne8.Models.DTO;
using Eksamen_Emne8.Models.Entity;
using Eksamen_Emne8.Repository;

namespace Eksamen_Emne8.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IBookMapper<Book, BookDTO> _bookMapper;

        public BookService(IBookRepository bookRepository, IBookMapper<Book, BookDTO> bookMapper)
        {
            _bookRepository = bookRepository;
            _bookMapper = bookMapper;
        }

        public async Task<IEnumerable<BookDTO>> GetBooksAsync()
        {
            var books = await _bookRepository.getBooksAsync();

            var dto = books.Select(Book => _bookMapper.MapToDTO(Book)).ToList();
            return dto;
        }

        public async Task<BookDTO?> GetBookByIdAsync(int id)
        {
            var book = await _bookRepository.getBookByIdAsync(id);
            return book != null ? _bookMapper.MapToDTO(book) : null;
        }
    }
}
