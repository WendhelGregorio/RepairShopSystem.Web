using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.userGroup
{
    public class UsersIndexViewModel
    {
        public Guid? GroupId { get; set; }

        public string GroupName { get; set; }

        public Page<User> Users { get; set; }
    }
}
