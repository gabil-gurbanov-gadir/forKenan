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
    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;

        public AuthorController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            int totalAuthors = _context.Authors.Count();
            ViewBag.SelectedPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling(totalAuthors / 2d);
            ViewBag.TotalAuthors = totalAuthors;
            List<Author> authors = _context.Authors.Include(x => x.Books)
                .Skip((page - 1) * 2).Take(2).ToList();

            return View(authors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Author author)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.Authors.Add(author);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Update(int id)
        {
            Author author = _context.Authors.FirstOrDefault(x => x.Id == id);

            if (author == null)
            {
                Response.StatusCode = 404;
                return View("AuthorNotFound", id);
            }

            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Author author)
        {
            Author existAuthor = _context.Authors.FirstOrDefault(x => x.Id == author.Id);

            if (existAuthor == null)
            {
                Response.StatusCode = 404;
                return View("TagNotFound", author.Id);
            }

            existAuthor.FullName = author.FullName;
            existAuthor.BioDesc = author.BioDesc;

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Author existAuthor = _context.Authors.FirstOrDefault(x => x.Id == id);

            if (existAuthor == null)
            {
                Response.StatusCode = 404;
                return View("TagNotFound", id);
            }

            return View(existAuthor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Author author)
        {
            Author existAuthor = _context.Authors.FirstOrDefault(x => x.Id == author.Id);

            if (existAuthor == null)
            {
                Response.StatusCode = 404;
                return View("TagNotFound", author.Id);
            }

            _context.Authors.Remove(existAuthor);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
