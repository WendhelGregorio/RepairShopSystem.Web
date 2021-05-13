using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.calendar
{
    public class CalendarViewModel : Booking
    {
        public List<BookingViewModel> BookingItems { get; set; }
        public decimal BookingAve { get; set; }
        public int BookingTotalToday { get; set; }
       
    }
   
    public class BookingViewModel
    {
        public Guid? Id { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string ContactNumber { get; set; }
        public string SName { get; set; }
        public string SDescription { get; set; }
        public decimal SPrice { get; set; }
        public DateTime UpdateAt { get; set; }
        public PaymentType PaymentType { get; set; }
    
    }
}
