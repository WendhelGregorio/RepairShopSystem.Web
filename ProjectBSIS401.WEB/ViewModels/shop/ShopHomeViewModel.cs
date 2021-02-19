using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shop
{
    public class ShopHomeViewModel
    {
        public List<ShopService> ShopServices { get; set; }

        public List<Booking> Bookings { get; set; }

        public Shop Shops { get; set; }

        public ReserveStatus ReserveStatus { get; set; }

        public List<ReserveStatus> reserveStatuses
        {
            get
            {
                return Enum.GetValues(typeof(ReserveStatus)).Cast<ReserveStatus>().ToList();
            }
        }
        
        public int Count { get; set; }

        public int serviceCount { get; set; }

        public int costumerCount { get; set; }
    }
}
