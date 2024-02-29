using Eksamen_Emne8.Data.Migrations;
using Eksamen_Emne8.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Eksamen_Emne8.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _context;

        public BookRepository(BookDbContext context)
        {
            _context = context;
            
        }


        public async Task<Book?> getBookByIdAsync(int id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);
            if (book == null) return null;
            return book;
        }

        public async Task<ICollection<Book>> getBooksAsync()
        {
            return await _context.Books.ToListAsync();
            
        }
    }
}
