using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shop
{
    public class ShopUpdateProfileViewModel
    {
        [Required]
        public Guid? ShopId { get; set; }

  
        public string OwnerShop { get; set; }

        [Required]
        public string BusinessName { get; set; }

        [Required]
        public string BusinessDescription { get; set; }

        [Required]
        public BusinessType BusinessType { get; set; }

        [Required]
        public string BusinessContact { get; set; }

        [Required]
        public string BusinessEmailAddress { get; set; }

        [Required]
        public string BusinessLocation { get; set; }

        [Required]
        public string OpenAt { get; set; }

        [Required]
        public string CloseAt { get; set; }

    }
}
