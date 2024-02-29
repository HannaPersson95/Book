using Eksamen_Emne8.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Eksamen_Emne8.Data.Migrations;

public class BookDbContext : DbContext
{
    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
    {
        
    }


    public DbSet<Book> Books { get; set; }

}
