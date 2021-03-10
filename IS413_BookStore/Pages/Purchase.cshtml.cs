using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IS413_BookStore.Models;
using IS413_BookStore.Infrastructure;

namespace IS413_BookStore.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookRepository repository;

        public PurchaseModel (IBookRepository repo) // Constructor
        {
            repository = repo;
        }

        // Properties
        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }

        // GET requests
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        // POST request
        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(book, 1);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });

        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            

            Cart.RemoveLine(Cart.Lines.First(b =>
                b.Book.BookId == bookId).Book);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostClear(string returnUrl)
        {
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();


            Cart.Clear();

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
