using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using IS413_BookStore.Infrastructure;
using IS413_BookStore.Models;

namespace IS413_BookStore.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("cart")
                ?? new SessionCart();
            cart.Session = session;
            return cart;
        }
        [JsonIgnore]
        public ISession Session { get; set; }

        public virtual void AddItem(Book book, int quantity)
        {
            base.AddItem(book, quantity);
            Session.SetJson("cart", this);
        }
        public virtual void RemoveLine(Book book)
        {
            base.RemoveLine(book);
            Session.SetJson("cart", this);
        }
        public virtual void Clear()
        {
            base.Clear();
            Session.Remove("cart");
        }
    }
}