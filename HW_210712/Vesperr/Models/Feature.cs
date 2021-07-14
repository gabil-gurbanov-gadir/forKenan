using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class Feature
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Icon { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
