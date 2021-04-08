using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class PricingContent : BaseModel
    {
        public Guid? PricingId { get; set; }

        public string Content { get; set; }

        public Pricing Pricing { get; set; }
    }
}
