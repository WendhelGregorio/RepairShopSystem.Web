using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.ViewModels.booking;

namespace ProjectBSIS401.WEB.Controllers
{
    public class BookingController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private IHostingEnvironment _env;

        public BookingController(DefaultDbContext context, IConfiguration config, IHostingEnvironment env)
        {
            _context = context;
            _config = config;
            _env = env;
        }


        public IActionResult Index()
        {
            return View();
        }


        //foreach shop can access this action.
        [HttpGet, Route("booking/book-costumer/{shopId}")]
        public IActionResult BookUser(Guid? shopId)
        {
            var shop = this._context.Shops.FirstOrDefault(u => u.Id == shopId);

            if (shop == null)
            {
                return BadRequest();
            }


            return View(shop);
        }

        [HttpPost, Route("booking/book-costumer")]
        public IActionResult BookUser(BookingViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var shop = this._context.Shops.FirstOrDefault(s => s.Id == model.ShopId);
            var user = this._context.Users.FirstOrDefault(u => u.Id == WebUser.UserId);
            var booking = this._context.Bookings.FirstOrDefault(b => b.ShopId == shop.Id && b.UserId == user.Id);

            if(booking != null)
            {
                Booking bookings = new Booking()
                {
                    ShopId = model.ShopId.Value,
                    UserName = user.UserName,
                    UserId = user.Id.Value,
                    Description = model.Description,
                    ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                    Address = model.Address,
                    UpdatedAt = DateTime.UtcNow,
                    DateAndTime = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow,
                    ContactNumber = model.ContactNumber,
                    Id = Guid.NewGuid(),
                    TimeStamps = DateTime.UtcNow
                };

                this._context.Bookings.Add(booking);
                this._context.SaveChanges();
            }
            return View();
        }

    }
}