using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class VesperrContext:DbContext
    {
        public VesperrContext(DbContextOptions<VesperrContext> opt):base(opt)
        {

        }

        public DbSet<SettingV> SettingVs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<AboutInfo> AboutInfos { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceCard> ServiceCards { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<PortCategory> PortCategories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortImage> PortImages { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanFeature> PlanFeatures { get; set; }
        public DbSet<PlFeature> PlFeatures { get; set; }
        public DbSet<Faq> Faqs { get; set; }
    }
}
