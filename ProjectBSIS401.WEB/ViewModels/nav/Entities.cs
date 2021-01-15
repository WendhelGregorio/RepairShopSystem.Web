using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.nav
{
    public class Entities
    {
        public List<Shop> Shops { get; set; }

        public List<Booking> Bookings{ get; set; }

        public List<User> Users { get; set; }

        public List<Service> Services { get; set; }

        public List<Category> Categories { get; set; }


    }
}
