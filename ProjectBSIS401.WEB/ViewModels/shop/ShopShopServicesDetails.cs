using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shop
{
    public class ShopShopServicesDetails
    {
        public Guid? ShopId { get; set; }

        public ShopService ShopServices { get; set; }
    }
}
