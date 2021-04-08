using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.pricings
{
    public class IndexViewModel
    {

        public Page<Pricing> Pricings { get; set; }
    }
}
