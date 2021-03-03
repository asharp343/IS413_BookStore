// Create seed data for db

using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IS413_BookStore.Models
{
    public class SeedData
    {

        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookStoreContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookStoreContext>();


            // Get any pending migrations
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            // If there is no data in the DB, add this seed data
            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorLastName = "Hugo",
                        AuthorFirstName = "Victor",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        NumPages = 1488,
                        Price = 9.95F
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorLastName = "Goodwin",
                        AuthorFirstName = "Doris Kearns",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        NumPages = 944,
                        Price = 14.58F
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthorLastName = "Schroeder",
                        AuthorFirstName = "Alice",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        NumPages = 832,
                        Price = 21.54F
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorLastName = "White",
                        AuthorFirstName = "Ronald C.",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        NumPages = 864,
                        Price = 11.61F
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        AuthorLastName = "Hillenbrand",
                        AuthorFirstName = "Laura",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        NumPages = 528,
                        Price = 13.33F
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorLastName = "Crichton",
                        AuthorFirstName = "Michael",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical-Fiction",
                        NumPages = 288,
                        Price = 15.19F
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        AuthorLastName = "Newport",
                        AuthorFirstName = "Cal",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        NumPages = 304,
                        Price = 14.19F
                    },
                    new Book
                    {
                        Title = "It\'s Your Ship",
                        AuthorLastName = "Abrashoff",
                        AuthorFirstName = "Branson",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        NumPages = 240,
                        Price = 21.66F
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorLastName = "Branson",
                        AuthorFirstName = "Richard",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        NumPages = 400,
                        Price = 29.16F
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorLastName = "Grisham",
                        AuthorFirstName = "John",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        NumPages = 642,
                        Price = 15.03F
                    },
                    new Book
                    {
                        Title = "Mindset",
                        AuthorLastName = "Dweck",
                        AuthorFirstName = "Carol",
                        Publisher = "Random House",
                        ISBN = "978-0345472328",
                        Classification = "Non-Fiction",
                        Category = "Self-help",
                        NumPages = 320,
                        Price = 15.50F
                    },
                    new Book
                    {
                        Title = "How to Win Friends and Influence People",
                        AuthorLastName = "Carnegie",
                        AuthorFirstName = "Dale",
                        Publisher = "Gallery Books",
                        ISBN = "978-0671027032",
                        Classification = "Non-Fiction",
                        Category = "Self-help",
                        NumPages = 288,
                        Price = 13.99F
                    },
                    new Book
                    {
                        Title = "Shoe Dog",
                        AuthorLastName = "Knight",
                        AuthorFirstName = "Phil",
                        Publisher = "Scibner",
                        ISBN = "978-1501135927",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        NumPages = 400,
                        Price = 16.99F
                    }



                ); ;

                context.SaveChanges();
            }
        }
    }
}
