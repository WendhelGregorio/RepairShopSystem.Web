using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.user
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }

        public LoginStatus Status { get; set; }

        public List<LoginStatus> Statuses
        {
            get
            {
                return Enum.GetValues(typeof(LoginStatus)).Cast<LoginStatus>().ToList();
            }
        }
    }
}