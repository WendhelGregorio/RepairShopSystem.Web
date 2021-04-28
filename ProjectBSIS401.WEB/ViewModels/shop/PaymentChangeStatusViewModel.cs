using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shop
{
    public class PaymentChangeStatusViewModel
    {
        public Guid? BookingId { get; set; }
        public PaymentType PaymentType { get; set; }

        public Guid? UserId { get; set; }
    }
}
