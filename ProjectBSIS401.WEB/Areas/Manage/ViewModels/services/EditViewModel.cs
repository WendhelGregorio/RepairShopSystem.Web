using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.services
{
    public class EditViewModel
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public ServiceType ServiceType { get; set; }

        

    }
}


