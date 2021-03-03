using System;
using System.Linq;

namespace IS413_BookStore.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
