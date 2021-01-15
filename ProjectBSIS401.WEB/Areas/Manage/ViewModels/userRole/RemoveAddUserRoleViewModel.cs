using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.userRole
{
    public class RemoveAddUserRoleViewModel
    {
        public Guid? UserId { get; set; }

        public string Role { get; set; }
    }
}