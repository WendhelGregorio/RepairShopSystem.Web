using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Enums
{
    public enum ReserveStatus
    {

        [Display(Name = "Pending")]
        Pending = 1,

        [Display(Name = "Confirm")]
        Confirm = 2,

        [Display(Name = "Cancel")]
        Cancel = 3,

        [Display(Name = "Completed")]
        Completed = 4,

    }
}
