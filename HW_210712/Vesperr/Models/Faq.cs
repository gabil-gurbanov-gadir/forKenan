using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class Faq
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Question { get; set; }

        [Required]
        [MaxLength(700)]
        public string Answer { get; set; }
    }
}
