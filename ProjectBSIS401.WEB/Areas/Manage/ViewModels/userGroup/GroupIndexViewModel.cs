using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.userGroup
{
    public class GroupIndexViewModel
    {
        public Guid? UserId { get; set; }

        public string UserName { get; set; }

        public Page<Group> Groups { get; set; }
        

    }
}