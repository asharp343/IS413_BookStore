// Create repository

using System;
using System.Linq;

namespace IS413_BookStore.Models
{
    public class EFBookRepository : IBookRepository
    {
        public EFBookRepository()
        {
        }

        private BookStoreContext _context;

        //Constructor
        public EFBookRepository (BookStoreContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
