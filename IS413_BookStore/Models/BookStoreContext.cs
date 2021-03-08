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

// Entity Framework Core provides access to the database through a context class.

//The DbContext base class provides access to the Entity Framework Core’s underlying functionality,
//and the Products property will provide access to the Product objects in the database.
//The StoreDbContext class is derived from DbContext and adds the properties that will be used to
//read and write the application’s data. There is only one property for now, which will provide access to Product objects.

// Entity Framework Core must be configured so that it knows the type of database to which it will connect, which
// connection string describes that connection, and which context class will present the data in the database. 