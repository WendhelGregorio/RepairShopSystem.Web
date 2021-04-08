using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.pricings
{
    public class EditViewModel
    {
        public Guid? Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string Month { get; set; }


    }
}
