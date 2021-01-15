using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }

        public Guid? ShopId { get; set; }
       
        public BusinessType BusinessType { get; set; }

        public IList<Shop> Shops { get; set; }
    }
}
