using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Enums
{
    public enum BusinessType
    {

        [Display(Name = "Tablet")]
        Tablet = 1,

        [Display(Name = "CellPhone")]
        CellPhone = 2,

        [Display(Name = "Desktop")]
        Desktop = 3,

        [Display(Name = "Laptop")]
        Laptop = 4 ,

    }
}
