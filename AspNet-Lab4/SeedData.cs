using System;
using System.Linq;
using AspNet_Lab4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AspNet_Lab4
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider sp)
        {
            using (var context = new BooksContext(sp.GetRequiredService<DbContextOptions<BooksContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }

                context.Books.AddRange(new Book()
                    {
                        Author = "Author 1",
                        Genre = "Genre 1",
                        Name = "Book 1",
                        Price = 3.14M
                    },
                    new Book()
                    {
                        Author = "Author 2",
                        Genre = "Genre 2",
                        Name = "Book 2",
                        Price = 6.24M
                    },
                    new Book()
                    {
                        Author = "Author 3",
                        Genre = "Genre 3",
                        Name = "Book 3",
                        Price = 1.05M
                    },
                    new Book()
                    {
                        Author = "Author 4",
                        Genre = "Genre 4",
                        Name = "Book 4",
                        Price = 25M
                    });

                context.SaveChanges();
            }
        }
    }
}
