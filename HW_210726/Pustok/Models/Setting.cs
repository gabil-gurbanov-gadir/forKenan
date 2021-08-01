using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Models
{
    public class Setting
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string HeaderLogo { get; set; }

        [MaxLength(100)]
        public string FooterLogo { get; set; }
        [Required]
        [MaxLength(100)]
        public string Phone1 { get; set; }

        [MaxLength(100)]
        public string Phone2 { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
    }
}
