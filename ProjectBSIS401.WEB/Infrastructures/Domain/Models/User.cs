using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class User : BaseModel
    {
        public User()
        {
            this.LoginStatus = LoginStatus.InActive;
            this.UserName = FirstName + LastName;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }

        public LoginStatus LoginStatus { get; set; }

        public int LoginRetries { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                var age = DateTime.Today.Year - DateOfBirth.Year;
                return age;
            }
           
        }
        public string PhoneNumber { get; set; }
        public string RegistrationCode { get; set; }
        public bool Thumbnail { get; set; }
        public Shop Shops { get; set; }

        public List<ChatUser> ChatUsers { get; set; }

      

    }
}