using Microsoft.AspNetCore.Mvc;
using IS413_BookStore.Models;
using System.Linq;

// View component for cart summary in header

namespace IS413_BookStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}