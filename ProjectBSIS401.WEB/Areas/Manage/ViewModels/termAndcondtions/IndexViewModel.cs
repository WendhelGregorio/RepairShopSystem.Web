using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.termAndcondtions
{
    public class IndexViewModel
    {

        public Page<TermAndCondition> TermAndConditions { get; set; }
    }
}
