using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.calendar
{
    public class EventViewModel
    {
        public Guid? BookingId { get; set; }

        public Guid? ShopServiceId { get; set; }

        public ShopService ShopService { get; set; }

        public Guid? UserId { get; set; }

        public string UserName { get; set; }

        public string Address { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        [Display(Name = "Start Time")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        public string Start { get; set; }
        [Display(Name = "End Time")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        public string End { get; set; }

        

    }
}
