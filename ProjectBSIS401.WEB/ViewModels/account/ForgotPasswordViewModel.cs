using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.account
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Please type-in a valid email address")]
        [EmailAddress(ErrorMessage = "Please type-in a valid email address")]
        public string EmailAddress { get; set; }
    }
}
