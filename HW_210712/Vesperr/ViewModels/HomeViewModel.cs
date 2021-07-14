using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vesperr.Models;

namespace Vesperr.ViewModels
{
    public class HomeViewModel
    {
        public SettingV SettingV { get; set; }
        public List<Client> Clients { get; set; }
        public List<AboutInfo> AboutInfos { get; set; }
        public List<Service> Services { get; set; }
        public List<ServiceCard> ServiceCards { get; set; }
        public List<Feature> Features { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<PortCategory> PortCategories { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<PortImage> PortImages { get; set; }
        public List<Team> Teams { get; set; }
        public List<Plan> Plans { get; set; }
        public List<PlanFeature> PlanFeatures { get; set; }
        public List<PlFeature> PlFeatures { get; set; }
        public List<Faq> Faqs { get; set; }
    }
}
