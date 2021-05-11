using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.account
{
    public class ChangePasswordViewModel
    {
        public Guid? UserId { get; set; }


        [Required(ErrorMessage = "Old Password is required to change-password")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "New Password is required to change-password")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Confirm New Password is required to change-password")]
        public string ConfirmNewPassword { get; set; }
    }
}
