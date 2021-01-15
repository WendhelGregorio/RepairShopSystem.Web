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
        public string BusinessName { get; set; }

        [Required]
        public BusinessType BusinessType { get; set; }

        [Required]
        public string BusinessDescription { get; set; }



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
