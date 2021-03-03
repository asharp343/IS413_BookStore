using System;
using System.Collections.Generic;

namespace IS413_BookStore.Models.ViewModels
{
    public class BookListViewModel
    {
        public BookListViewModel()
        {
        }

        public IEnumerable<Book> Books { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}
