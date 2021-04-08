using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.booking
{
    public class BookReviewViewModel
    {
        public User User { get; set; }

        public Booking Booking { get; set; }

        public List<Booking> Bookings { get; set; }

        public decimal TotalPrice => Bookings.Sum(b => b.ShopServicePrice);

         public int CountNumber { get; set; }
    }
}


