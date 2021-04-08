using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class Pricing : BaseModel
    {
        public string Title { get; set; }

        public decimal Price { get; set; }

        public string Month { get; set; }

        public List<PricingContent> PricingContents { get; set; }
    }
}
