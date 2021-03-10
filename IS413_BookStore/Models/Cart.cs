using System;
using System.Collections.Generic;
using System.Linq;
using IS413_BookStore.Components;

namespace IS413_BookStore.Models
{
    public class Cart
    {
     
        // Create a list of cart items
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem(Book book, int quantity)
        {
            CartLine line = Lines.Where(b => b.Book.BookId == book.BookId).FirstOrDefault();

            if(line == null) // If the book isn't in the cart, add it and the quantity
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });                
            }

            else // If the book is already in the cart, add another one 
            {
                line.Quantity += quantity;
            }

        }

        // Methods to perform actions on the Lines list
        public void RemoveLine(Book book) => Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        public void Clear() => Lines.Clear();

        public decimal ComputeTotalSum() => Lines.Sum(e => e.Book.Price * e.Quantity);

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
