using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.calendar
{
    public class TimeTableViewModel
    {
        public String AuditoriumName { get; set; }

        //public String bdate12 { get; set; }

        //public String bfromtime12 { get; set; }

        //public String btotime12 { get; set; }

        public String BookingStartDate { get; set; }

        public String BookingEndDate { get; set; }

        public String BookingStatus { get; set; }


        public TimeTableViewModel(String a, String sd, String ed, String st)

        {
            this.AuditoriumName = a;

            // this.bdate12 = d;

            // this.bfromtime12 = ft;

            // this.btotime12 = tt;

            this.BookingStartDate = sd;

            this.BookingEndDate = ed;

            this.BookingStatus = st;

        }
    }
}