using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Enums
{
    public enum RatingNumber
    {
        [Description("One")]
        [Display(Name = "One")]
        One = 1,

        [Description("Two")]
        [Display(Name = "Two")]
        Two = 2,

        [Description("Three")]
        [Display(Name = "Three")]
        Three = 3,

        [Description("Four")]
        [Display(Name = "Four")]
        Four = 4,

        [Description("Five")]
        [Display(Name = "Five")]
        Five = 5,

    }
}
