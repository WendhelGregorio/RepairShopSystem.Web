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
        Tablet,

        [Display(Name = "CellPhone")]
        CellPhone,

        [Display(Name = "Desktop")]
        Desktop,

        [Display(Name = "Laptop")]
        Laptop ,

    }
}
