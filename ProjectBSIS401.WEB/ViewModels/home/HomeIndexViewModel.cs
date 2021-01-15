
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.home
{
    public class HomeIndexViewModel
    {

        public List<Shop> Shops { get; set; }


        public List<Category> PublicCategories { get; set; }

        public List<Service> PublicServices { get; set; }


    }
}
