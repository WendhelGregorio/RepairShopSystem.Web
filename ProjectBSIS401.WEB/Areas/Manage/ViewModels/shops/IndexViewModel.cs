using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.shops
{
    public class IndexViewModel
    {
        public Page<Shop> Shops { get; set; }

        public Status status { get; set; }

        public List<Status> Statuses
        {
            get
            {
                return Enum.GetValues(typeof(Status)).Cast<Status>().ToList();
            }
        }
    }
}