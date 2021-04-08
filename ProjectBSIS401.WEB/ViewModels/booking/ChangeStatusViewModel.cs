using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.booking
{
    public class ChangeStatusViewModel
    {
        public Guid? BookingId { get; set; }

        public ReserveStatus Status { get; set; }

        public Guid? UserId { get; set; }
    }
}
