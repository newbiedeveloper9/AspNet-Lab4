using AspNet_Lab4.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNet_Lab4
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
