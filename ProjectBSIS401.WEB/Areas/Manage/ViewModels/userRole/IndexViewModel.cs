using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.userRole
{
    public class IndexViewModel
    {
        public Guid? UserId { get; set; }

        public string UserName { get; set; }

        public Page<Role> Roles { get; set; }

        public Role Roleles { get; set; }

        public List<Role> roleles
        {
            get
            {
                return Enum.GetValues(typeof(Role)).Cast<Role>().ToList();
            }
        }
    }
}
