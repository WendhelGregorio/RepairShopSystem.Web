using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class Like : BaseModel
    {
        [Required]
        public Guid? ShopId { get; set; }
        public Shop Shop { get; set; }
        public Guid? UserId { get; set; }
        public User User { get; set; }
    }
}
