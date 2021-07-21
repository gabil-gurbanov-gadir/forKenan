using Pustok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.ViewModels
{
    public class LayoutViewModel
    {
        public Setting Setting { get; set; }

        public List<Partner> Partners { get; set; }
    }
}
