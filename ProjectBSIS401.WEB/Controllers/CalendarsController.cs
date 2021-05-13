using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.ViewModels.calendar;

namespace ProjectBSIS401.WEB.Controllers
{
    public class CalendarsController : Controller
    {
        private readonly DefaultDbContext _context;
        public CalendarsController(DefaultDbContext context)
        {
            _context = context; 
        }

        [HttpGet,Route("/calendars/index")]
        public IActionResult Index()
        {
            return View(new EventViewModel());
        }

        [HttpPost,Route("calendars/test")]
        public static string TestOnWeb()
        {
            string myJsonString = "";

            List<object> myList = new List<object>();

            TimeTableViewModel t_table = new TimeTableViewModel("XYZ", "2018-07-01", "2018-07-02", "Y");    // SINCE EVERYTHING FAILED I AM TRYING WITH STATIC DATA

            myList.Add(t_table);

            myList.Add(new TimeTableViewModel("abc", "2018-07-08", "2018-07-09", "Z"));

            myList.Add(new TimeTableViewModel("cde", "2018-07-11", "2018-07-14", "X"));

            myJsonString = JsonConvert.SerializeObject(myList);

            return myJsonString;
        }

        [HttpGet,Route("calendars/list-events")]
        public IActionResult GetEventData()
        {
            var events = this._context.Bookings.ToList();
            return Json(events);
        }

        [HttpGet,Route("/calendars/get-events")]
        public IActionResult GetEvents()
        {
            var events = new List<EventViewModel>();
            var eventViewModel = new EventViewModel();
            var bookings = this._context.Bookings.ToList().OrderByDescending(b => b.UpdatedAt);

       
            foreach (var item in bookings)
            {

                eventViewModel.BookingId = item.Id;
                eventViewModel.ShopServiceId = item.ShopServiceId;
                eventViewModel.UserId = item.UserId;
                eventViewModel.ShopService = this._context.ShopServices.FirstOrDefault(ss => ss.Id == item.ShopServiceId);
                eventViewModel.UserName = item.UserName;
                eventViewModel.Address = item.Address;
                eventViewModel.Start = item.UpdatedAt.ToString();
                eventViewModel.End = item.DateAndTime.ToString();
                eventViewModel.Title = item.ShopServiceName;
                eventViewModel.Description = item.ShopServiceDescription;

                events.Add(eventViewModel);

            }

            //string json = JsonConvert.SerializeObject(events);
            return new JsonResult(JsonConvert.SerializeObject(events));
           
        }
    }
}