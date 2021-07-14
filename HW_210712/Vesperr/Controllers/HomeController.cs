using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vesperr.Models;
using Vesperr.ViewModels;

namespace Vesperr.Controllers
{
    public class HomeController : Controller
    {
        private readonly VesperrContext _context;

        public HomeController(VesperrContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel HomeVM = new HomeViewModel()
            {
                SettingV = _context.SettingVs.ToList().FirstOrDefault(),
                Clients = _context.Clients.ToList(),
                AboutInfos = _context.AboutInfos.ToList(),
                Services = _context.Services.ToList(),
                ServiceCards = _context.ServiceCards.ToList(),
                Features = _context.Features.ToList(),
                Testimonials = _context.Testimonials.ToList(),
                PortCategories = _context.PortCategories.ToList(),
                Portfolios = _context.Portfolios.ToList(),
                PortImages = _context.PortImages.ToList(),
                Teams = _context.Teams.ToList(),
                Plans = _context.Plans.Include(p=>p.PlanFeatures).ThenInclude(pf=>pf.PlFeature).ToList(),
                PlFeatures = _context.PlFeatures.ToList(),
                PlanFeatures = _context.PlanFeatures.ToList(),
                Faqs = _context.Faqs.ToList()
            };
            return View(HomeVM);
        }
        public IActionResult Portfolio(int id)
        {
            Portfolio portfolio = _context.Portfolios.Include(p=>p.Category).Include(p => p.PortImages).ToList().FirstOrDefault(p => p.Id == id);

            if (portfolio == null)
                return NotFound();

            return View(portfolio);
        }
    }
}
