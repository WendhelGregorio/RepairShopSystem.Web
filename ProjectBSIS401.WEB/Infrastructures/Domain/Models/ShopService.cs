using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class ShopService : BaseModel
    {
        public Guid? ServiceId { get; set; }

        public Guid? ShopId { get; set; }

        public Decimal Price { get; set; }

        public Service Services { get; set; }

        public Shop Shops { get; set; }
    }
}
