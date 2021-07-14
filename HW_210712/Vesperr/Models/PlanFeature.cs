using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class PlanFeature
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public Plan Plan { get; set; }

        public int PlFeatureId { get; set; }
        public PlFeature PlFeature { get; set; }

    }
}
