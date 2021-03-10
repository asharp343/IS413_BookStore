// Create Context Class

using System;
using Microsoft.EntityFrameworkCore;

namespace IS413_BookStore.Models
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext()
        {
        }

        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
