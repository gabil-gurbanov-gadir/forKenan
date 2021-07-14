using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Img { get; set; }
    }
}
