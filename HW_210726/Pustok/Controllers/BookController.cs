using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pustok.DAL;
using Pustok.Models;
using Pustok.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? categoryId,int page=1)
        {
            var query = _context.Books.AsQueryable();

            if (categoryId != null)
            {
                query = query.Where(x => x.CategoryId == categoryId);
            }

            var totalPages = query.Count()/3d;
            ViewBag.TotalPages = Math.Ceiling(totalPages);
            ViewBag.SelectedPage = page;
            ViewBag.CategoryId = categoryId;
            List<Book> books = query
                .Include(x => x.Author)
                .Include(x=>x.BookImages)
                .Skip((page-1)*3)
                .Take(3)
                .ToList();
            return View(books);
        }

        public IActionResult Detail(int id)
        {
            Book book = _context.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .Include(b => b.BookImages)
                .Include(b => b.BookTags)
                .ThenInclude(bt => bt.Tag)
                .Include(b => b.CampaignBooks)
                .ThenInclude(cb => cb.Campaign)
                .FirstOrDefault(b => b.Id == id);

            if (book == null) return NotFound();

            List<Book> books = _context.Books
                .Include(b => b.Author)
                .Include(b => b.BookImages)
                .Include(b => b.CampaignBooks)
                .ThenInclude(cb => cb.Campaign)
                .ToList().GetRange(_context.Books.ToList().Count - 5, 5);

            books.Add(book);

            return View(books);
        }

        public IActionResult GetDetaileBook(int id)
        {
            Book book = _context.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .Include(b => b.BookImages)
                .Include(b => b.BookTags)
                .ThenInclude(bt => bt.Tag)
                .Include(b => b.CampaignBooks)
                .ThenInclude(cb => cb.Campaign)
                .FirstOrDefault(b => b.Id == id);

            return PartialView("_BookDetail", book);
        }

        /*
        public IActionResult SetSession(int id)
        {
            Book book = _context.Books.FirstOrDefault(b => b.Id == id);

            var bookStr = JsonConvert.SerializeObject(book);

            HttpContext.Session.SetString("Book", bookStr);

            return RedirectToAction("index", "home");
        }

        public IActionResult ShowSession()
        {
            var sessionValue = HttpContext.Session.GetString("Book");

            Book book = JsonConvert.DeserializeObject<Book>(sessionValue);

            return Content(sessionValue);
        }

        public IActionResult SetCookie(int id)
        {
            Book book = _context.Books.FirstOrDefault(b => b.Id == id);

            var cookieBooks = HttpContext.Request.Cookies["BookList"];

            if (cookieBooks == null)
            {
                List<Book> books = new List<Book>();
                books.Add(book);
                var bookListStr = JsonConvert.SerializeObject(books);
                HttpContext.Response.Cookies.Append("BookList", bookListStr);
            }
            else
            {
                List<Book> books = JsonConvert.DeserializeObject<List<Book>>(cookieBooks);
                books.Add(book);
                var bookListStr = JsonConvert.SerializeObject(books);
                HttpContext.Response.Cookies.Append("BookList", bookListStr);
            }

            return RedirectToAction("index", "home");
        }

        public IActionResult ShowCookie()
        {
            var bookListStr = HttpContext.Request.Cookies["BookList"];

            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(bookListStr);

            return Content(bookListStr);
        }

        public IActionResult DeleteCookie(string key)
        {
            HttpContext.Response.Cookies.Delete(key);
            return RedirectToAction("index", "home");
        }

        */

        public IActionResult AddToBasket(int id)
        {
            Book book = _context.Books.FirstOrDefault(b => b.Id == id);

            var basket = HttpContext.Request.Cookies["Basket"];

            List<BasketCookieItemVM> basketItems;

            if (basket == null)
            {
                basketItems = new List<BasketCookieItemVM>() {
                    new BasketCookieItemVM() {
                    Id = book.Id,
                    Count = 1
                     }
                };
            }
            else
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);
                BasketCookieItemVM basketItem = basketItems.FirstOrDefault(x => x.Id == book.Id);
                if (basketItem == null)
                {
                     basketItem = new BasketCookieItemVM()
                    {
                        Id = book.Id,
                        Count = 1
                    };
                    basketItems.Add(basketItem);
                }
                else
                {
                    basketItem.Count++;
                }
            }

            var basketItemsStr = JsonConvert.SerializeObject(basketItems);
            HttpContext.Response.Cookies.Append("Basket", basketItemsStr);

            BasketVM basketData = new BasketVM()
            {
                BasketItemVMs = new List<BasketItemVM>(),
                TotalPrice = 0
            };

            foreach (var item in basketItems)
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
                        basketData.TotalPrice += basketItem.Book.Price * basketItem.Count;
                    }
                    else
                    {
                        basketData.TotalPrice += (double)basketItem.Book.DiscountedPrice * basketItem.Count;
                    }
                    basketData.BasketItemVMs.Add(basketItem);
                    basketData.Count++;
                }
            }

            return PartialView("_BasketPartial", basketData);
        }

        public IActionResult DeleteFromBasket(int id)
        {
            var basket = HttpContext.Request.Cookies["Basket"];
            List<BasketCookieItemVM> basketItems;

            
            basketItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);

            BasketCookieItemVM basketItemVM = basketItems.FirstOrDefault(x => x.Id == id);

            if (basketItemVM.Count>1)
            {
                basketItems.FirstOrDefault(x => x.Id == id).Count--;
            }
            else
            {
                basketItems.RemoveAll(x=>x.Id == id);
            }

            var basketItemsStr = JsonConvert.SerializeObject(basketItems);
            HttpContext.Response.Cookies.Append("Basket", basketItemsStr);

            BasketVM basketData = new BasketVM()
            {
                BasketItemVMs = new List<BasketItemVM>(),
                TotalPrice = 0
            };

            foreach (var item in basketItems)
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
                        basketData.TotalPrice += basketItem.Book.Price * basketItem.Count;
                    }
                    else
                    {
                        basketData.TotalPrice += (double)basketItem.Book.DiscountedPrice * basketItem.Count;
                    }
                    basketData.BasketItemVMs.Add(basketItem);
                    basketData.Count++;
                }

            }
            
            return PartialView("_BasketPartial", basketData);
        }

        public IActionResult ShowBasket()
        {
             var basket = HttpContext.Request.Cookies["Basket"];
            return Content(basket);
        }
    }
}
