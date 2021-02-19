using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shop
{
    public class ShopIdViewModel
    {
        public Shop Shop { get; set; }

        public List<ShopService> ShopServices { get; set; } 

        public Guid? ShopId { get; set; }

        public Guid? UserId { get; set; }
    }
}
