using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class Portfolio
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public PortCategory Category { get; set; }

        public List<PortImage> PortImages { get; set; }
    }
}
