using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.DAL;
using Pustok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            int totalBooks = _context.Books.Count();
            ViewBag.SelectedPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling(totalBooks / 5d);
            ViewBag.TotalBooks = totalBooks;
            List<Book> books = _context.Books
                .Include(b => b.Author)
                .Skip((page - 1) * 5).Take(5).ToList();

            return View(books);
        }

        public IActionResult Detail(int id)
        {

            Book book = _context.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .Include(b => b.Publisher)
                .Include(b => b.Category)
                .Include(b => b.BookImages)
                .Include(b => b.BookTags)
                .ThenInclude(bt => bt.Tag)
                .Include(b => b.CampaignBooks)
                .ThenInclude(cb => cb.Campaign)
                .FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                Response.StatusCode = 404;
                return View("BookNotFound", id);
            }

            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.Books.Add(book);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Update(int id)
        {
            Book book = _context.Books.FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                Response.StatusCode = 404;
                return View("BookNotFound", id);
            }

            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Book book)
        {
            Book existBook = _context.Books.FirstOrDefault(x => x.Id == book.Id);

            if (existBook == null)
            {
                Response.StatusCode = 404;
                return View("BookNotFound", book.Id);
            }

            existBook.Name = book.Name;
            existBook.ProducingPrice = book.ProducingPrice;
            existBook.Price = book.Price;
            existBook.Code = book.Code;
            existBook.PublicationDate = book.PublicationDate;
            existBook.IsAvailable = book.IsAvailable;
            existBook.Desc = book.Desc;

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Book existBook = _context.Books.FirstOrDefault(x => x.Id == id);

            if (existBook == null)
            {
                Response.StatusCode = 404;
                return View("BookNotFound", id);
            }

            return View(existBook);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Book book)
        {
            Book existBook = _context.Books.FirstOrDefault(x => x.Id == book.Id);

            if (existBook == null)
            {
                Response.StatusCode = 404;
                return View("BookNotFound", book.Id);
            }

            _context.Books.Remove(existBook);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
