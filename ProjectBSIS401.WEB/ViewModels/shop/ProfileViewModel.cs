using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shop
{
    public class ProfileViewModel
    {
        public User User { get; set; }

        public Shop Shop { get; set; }
    }
}
