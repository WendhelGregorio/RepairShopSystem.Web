using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class ReservationService : BaseModel
    {
        public Guid? ShopId { get; set; }

        public Guid? UserId { get; set; }

        public Guid? ReserveId { get; set; }

        public Guid? ServiceId { get; set; }
    }
}
