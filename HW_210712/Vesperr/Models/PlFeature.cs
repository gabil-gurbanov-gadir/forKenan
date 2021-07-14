using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class PlFeature
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Text { get; set; }

        public List<PlanFeature> PlanFeatures { get; set; }
    }
}
