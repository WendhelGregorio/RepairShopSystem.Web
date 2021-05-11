using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class TermAndCondition : BaseModel
    {
        public string Title { get; set; }

        public string Description {get; set;}

        public DateTime DateAndTime { get; set; }

        public Guid? UserId { get; set; }

        public Guid? ShopId { get; set; }

        public Guid? BookingId { get; set; }

        public bool IsPublished { get; set; }
    }
}
