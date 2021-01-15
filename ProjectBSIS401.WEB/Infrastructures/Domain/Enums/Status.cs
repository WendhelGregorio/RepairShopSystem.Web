using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Enums
{
    public enum Status
    {

        [Display(Name = "Active")]
        Active,

        [Display(Name = "Inactive")]
        Inactive
    }
}
