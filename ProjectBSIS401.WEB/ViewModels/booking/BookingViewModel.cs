using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.booking
{
    public class BookingViewModel
    {
        public Guid? UserId { get; set; }

        public Guid? ShopId { get; set; }

        public Guid? ShopServiceId { get; set; }

        public string UserName { get; set; }


        public string TitleShopService { get; set; }

        public string DescriptionShopService { get; set; }

        public decimal PriceShopService { get; set; }


        [Required]
        public string AdditionalDescription { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy hh:mm tt}")]
        public DateTime DateAndTime { get; set; }
    }
}
