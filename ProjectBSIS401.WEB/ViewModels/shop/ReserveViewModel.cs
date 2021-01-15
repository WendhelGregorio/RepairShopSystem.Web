using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shop
{
    public class ReserveViewModel
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public BusinessType Type { get; set; }

        [Required]
        public string Description { get; set; }

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


      