using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shop
{
    public class ShopHomeViewModel
    {
        public Page<Booking> BookingsPage { get; set; }
        public ReserveStatus ReserveStatus { get; set; }
        public List<ReserveStatus> reserveStatuses
        {
            get
            {
                return Enum.GetValues(typeof(ReserveStatus)).Cast<ReserveStatus>().ToList();
            }
        }
     
        public List<ShopService> ShopServices { get; set; }

        public Shop Shop { get; set; }
    
    }
}
