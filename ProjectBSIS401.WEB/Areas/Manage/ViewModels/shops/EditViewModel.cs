using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.shops
{
    public class EditViewModel
    {
       
        public Guid? Id { get; set; }

        public string OwnerShop { get; set; }

        public string BusinessName { get; set; }

        public BusinessType BusinessType { get; set; }

        public string BusinessContact { get; set; }

        public string BusinessDescription { get; set; }

        public string BusinessEmailAddress { get; set; }




        public string BusinessLocation { get; set; }


        public string OpenAt { get; set; }

        public string CloseAt { get; set; }

       

    }
}
