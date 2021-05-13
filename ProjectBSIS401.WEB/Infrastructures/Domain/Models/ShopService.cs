using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public partial class ShopService : BaseModel
    {
    

        public Guid? ServiceId { get; set; }

        public Guid? ShopId { get; set; }

        public string Service { get; set; }

        public string Description { get; set; }

        [Range(1, 10000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public List<Service> Services { get; set; }

        public virtual Shop Shop { get; set; }

    }



}
