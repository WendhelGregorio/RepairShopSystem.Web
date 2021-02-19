using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shopServices
{
    public class IndexViewModel
    {
        public Guid? ShopId { get; set; }

        public List<Service> Services { get; set; }

    }
}
