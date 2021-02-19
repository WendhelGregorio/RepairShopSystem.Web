using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shop
{
    public class CreateShopViewModel
    {
        [Required]
        public Guid? UserId { get; set; }

        [Required]
        public string OwnerShop { get; set; }

        [Required(ErrorMessage = "Business-Name is required to register shop")]
        public string BusinessName { get; set; }

        [Required(ErrorMessage = "Category is required to register shop")]
        public BusinessType BusinessType { get; set; }

        [Required(ErrorMessage = "Description is required to register shop")]
        public string BusinessDescription { get; set; }



        [Required(ErrorMessage = "Business-Contact-Number is required to register shop")]
        public string BusinessContact { get; set; }

        [Required(ErrorMessage = "Business-Email number is required to register shop")]
        public string BusinessEmailAddress { get; set; }



        [Required(ErrorMessage = "Business-Location is required to register shop")]
        public string BusinessLocation { get; set; }

        [Required]
        public string OpenAt { get; set; }

        [Required]
        public string CloseAt { get; set; }


    }
}
