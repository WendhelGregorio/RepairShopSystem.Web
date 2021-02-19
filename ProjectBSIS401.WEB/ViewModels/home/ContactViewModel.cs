using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.home
{
    public class ContactViewModel
    {
        
        [StringLength(30)]
        [Required(ErrorMessage = "Full-name is required.")]
        public string FullName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(11)]
        [Required(ErrorMessage = "Phone number is required. 11 characters ")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email  is required.")]
        public string EmailAddress { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "Message  is required.")]
        public string Message { get; set; }
    }
}
