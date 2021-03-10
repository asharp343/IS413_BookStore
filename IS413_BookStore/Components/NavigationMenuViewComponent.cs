using System;
using System.Linq;
using IS413_BookStore.Models;
using Microsoft.AspNetCore.Mvc;

// View component for filtering menu

namespace IS413_BookStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {

        private IBookRepository repository;

        public NavigationMenuViewComponent(IBookRepository repo)
        {
            this.repository = repo;
        }



        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
