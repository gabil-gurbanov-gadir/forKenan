using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class ServiceCard
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string BgImg { get; set; }

        [Required]
        [MaxLength(80)]
        public string Title { get; set; }

        [Required]
        [MaxLength(300)]
        public string Text { get; set; }
    }
}
