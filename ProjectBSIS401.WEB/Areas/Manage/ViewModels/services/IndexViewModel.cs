using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.services
{
    public class IndexViewModel
    {
        public Page<Service> Services { get; set; }

        public ServiceType ServiceT { get; set; }

        public List<ServiceType> Serviceses
        {
            get
            {
                return Enum.GetValues(typeof(ServiceType)).Cast<ServiceType>().ToList();
            }
        }
    }
}