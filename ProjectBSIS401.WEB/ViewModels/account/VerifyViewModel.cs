using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.account
{
    public class VerifyViewModel
    {
        [Required(ErrorMessage = "Code is required")]
        public string RegistrationCode { get; set; }
    }
}
