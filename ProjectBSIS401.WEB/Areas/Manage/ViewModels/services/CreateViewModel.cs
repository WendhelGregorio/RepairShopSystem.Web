using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.services
{
    public class CreateViewModel
    {

     

        public string Name { get; set; }

        public ServiceType ServiceType { get; set; }

    }
}
