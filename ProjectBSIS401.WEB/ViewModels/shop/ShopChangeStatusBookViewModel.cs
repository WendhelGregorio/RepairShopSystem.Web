using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shop
{
    public class ShopChangeStatusBookViewModel
    {

        public Guid? BookingId { get; set; }

        public string Status { get; set; }

        public ReserveStatus reserveStatus { get; set; }

        public List<ReserveStatus> reserveStatuses
        {
            get
            {
                return Enum.GetValues(typeof(ReserveStatus)).Cast<ReserveStatus>().ToList();
            }
        }

      
    }
}
