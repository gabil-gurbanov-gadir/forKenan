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
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            int totalSliders = _context.Sliders.Count();
            ViewBag.SelectedPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling(totalSliders / 2d);
            ViewBag.TotalSliders = totalSliders;
            List<Slider> sliders = _context.Sliders
                .Skip((page - 1) * 2).Take(2).ToList();

            return View(sliders);
        }

        public IActionResult Detail(int id)
        {

            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (slider == null)
            {
                Response.StatusCode = 404;
                return View("SliderNotFound", id);
            }

            return View(slider);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.Sliders.Add(slider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Update(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (slider == null)
            {
                Response.StatusCode = 404;
                return View("SliderNotFound", id);
            }

            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Slider slider)
        {
            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);

            if (existSlider == null)
            {
                Response.StatusCode = 404;
                return View("SliderNotFound", slider.Id);
            }

            existSlider.Title = slider.Title;
            existSlider.Subtitle = slider.Subtitle;
            existSlider.Image = slider.Image;
            existSlider.RedirectUrl = slider.RedirectUrl;
            existSlider.Order = slider.Order;
            existSlider.BtnText = slider.BtnText;
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (existSlider == null)
            {
                Response.StatusCode = 404;
                return View("SliderNotFound", id);
            }

            return View(existSlider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Slider slider)
        {
            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);

            if (existSlider == null)
            {
                Response.StatusCode = 404;
                return View("SliderNotFound", slider.Id);
            }

            _context.Sliders.Remove(existSlider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
