using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class FeedBack : BaseModel
    {
        public Guid? ShopId { get; set; }

        public Guid? BookingId { get; set; }
        

        public Guid? CostumerId { get; set; }

        public decimal Rating { get; set; }
     
        [StringLength(500)]
        public string Comment { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(255)]
        public string Email { get; set; }
    }
}
