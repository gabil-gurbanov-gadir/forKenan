using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class PortImage
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Path { get; set; }

        public int PortfolioId { get; set; }

        public Portfolio Portfolio { get; set; }
    }
}
