using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Icon { get; set; }

        [Required]
        [MaxLength(80)]
        public string Title { get; set; }

        [Required]
        [MaxLength(200)]
        public string Desc { get; set; }
    }
}
