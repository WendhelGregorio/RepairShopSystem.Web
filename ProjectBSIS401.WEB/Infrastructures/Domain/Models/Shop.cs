using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class Shop : BaseModel
    {
     
        public Guid? UserId { get; set; }

        public string OwnerShop { get; set; }

        public string BusinessName { get; set; }

        public BusinessType BusinessType { get; set; }

        public string BusinessContact { get; set; }

        public string BusinessDescription { get; set; }

        public string BusinessEmailAddress { get; set; }

        public Status Status { get; set; }

        public string BusinessLocation { get; set; }

        public string OpenAt { get; set; }

        public string CloseAt { get; set; }

        public bool IsPublished { get; set; }


        public Booking Bookings { get; set; }
        public ShopService ShopServices { get; set; }
        public Guid? CategoryId { get; set; }
        public Category category { get; set; }


    }
}
