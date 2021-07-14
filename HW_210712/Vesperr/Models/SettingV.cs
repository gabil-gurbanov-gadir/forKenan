using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class SettingV
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string LogoName { get; set; }

        [Required]
        [MaxLength(80)]
        public string Title { get; set; }

        [Required]
        [MaxLength(150)]
        public string Subtitle { get; set; }

        [Required]
        [MaxLength(100)]
        public string Img { get; set; }

        [Required]
        [MaxLength(5000)]
        public string AboutDesc { get; set; }

        [Required]
        [MaxLength(100)]
        public string AboutImg { get; set; }

        [Required]
        [MaxLength(150)]
        public string ServicesSubtitle { get; set; }

        [Required]
        [MaxLength(150)]
        public string FeaturesSubtitle { get; set; }

        [Required]
        [MaxLength(150)]
        public string TestimonialsSubtitle { get; set; }

        [Required]
        [MaxLength(150)]
        public string PortfolioSubtitle { get; set; }

        [Required]
        [MaxLength(150)]
        public string TeamSubtitle { get; set; }

        [Required]
        [MaxLength(200)]
        public string PricingSubtitle { get; set; }

        [Required]
        [MaxLength(500)]
        public string Newsletter { get; set; }

        [Required]
        [MaxLength(50)]
        public string Street { get; set; }

        [Required]
        [MaxLength(25)]
        public string City { get; set; }

        [Required]
        [MaxLength(10)]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(25)]
        public string Phone { get; set; }
    }
}
