using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pustok.DAL;
using Pustok.Models;
using Pustok.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LayoutService(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public Setting GetSetting()
        {
            return _context.Settings.FirstOrDefault();
        }

        public List<Partner> GetPartners()
        {
            return _context.Partners.ToList();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public BasketVM GetBasket()
        {
            var basket = _httpContextAccessor.HttpContext.Request.Cookies["Basket"];

            BasketVM basketData = new BasketVM()
            {
                BasketItemVMs = new List<BasketItemVM>(),
                TotalPrice=0
            };

            if (basket != null)
            {
                List<BasketCookieItemVM> basketCookies = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);



                foreach (var item in basketCookies)
                {

                    BasketItemVM basketItem = new BasketItemVM()
                    {
                        Book = _context.Books.Include(x => x.BookImages).FirstOrDefault(x => x.Id == item.Id),
                        Count = item.Count
                    };

                    if (basketItem.Book != null)
                    {
                        if (basketItem.Book.DiscountedPrice == null)
                        {
                            basketData.TotalPrice += basketItem.Book.Price*basketItem.Count;
                        }
                        else
                        {
                            basketData.TotalPrice += (double)basketItem.Book.DiscountedPrice* basketItem.Count;
                        }
                        basketData.BasketItemVMs.Add(basketItem);
                        basketData.Count++;
                    }
                }
            }
           
            return basketData;
        }
    }
}
