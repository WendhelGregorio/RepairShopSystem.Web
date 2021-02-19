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
        [HttpGet, Route("booking/book-costumer/{shopId}/{userId}")]
        public IActionResult BookUser(Guid? shopId,Guid? userId)
        {
            var shop = this._context.Shops.FirstOrDefault(u => u.Id == shopId);
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);
            if (shop == null)
            {
                return BadRequest();
            }

            if(user == null)
            {
                return BadRequest();
            }

            return View(new BookingViewModel
            {
                Name = user.UserName,
                ShopId = shopId,
                UserId = userId
                
            });
        }

        [HttpPost, Route("booking/book-costumer")]
        public IActionResult BookUser(BookingViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var shop = this._context.Shops.FirstOrDefault(s => s.Id == model.ShopId);
            var user = this._context.Users.FirstOrDefault(u => u.Id == model.UserId);

            if(shop != null && user != null)
            {
                Booking bookings = new Booking()
                {
                    ShopId = model.ShopId.Value,
                    UserName = model.Name,
                    UserId = model.UserId.Value,
                    Description = model.Description,
                    ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                    Address = model.Address,
                    UpdatedAt = DateTime.UtcNow,
                    DateAndTime = model.DateAndTime,
                    CreatedAt = DateTime.UtcNow,
                    ContactNumber = model.ContactNumber,
                    Id = Guid.NewGuid(),
                    TimeStamps = DateTime.UtcNow
                    
                };

                this._context.Bookings.Add(bookings);
                this._context.SaveChanges();
            }
            //return RedirectToAction("Index", new { ShopId = model.ShopId, UserId = model.UserId });

            return Redirect("~/shop/shop-items/" + model.ShopId + "/" + model.UserId);
        }

        [HttpGet,Route("booking/details/{bookingId}")]
        public IActionResult Details(Guid? bookingId)
        {
            var booking = this._context.Bookings.FirstOrDefault(b => b.Id == bookingId);
            if(booking == null)
            {
                return NotFound();
            }
       
            return View(booking);
        }

        [HttpGet, Route("booking/delete-user-booking/{bookingId}/{shopId}")]
        public IActionResult Delete(Guid? bookingId, Guid? shopId)
        {
            var deleteUserBooking = this._context.Bookings.FirstOrDefault(c => c.Id == bookingId);

            if (deleteUserBooking != null)
            {
                this._context.Bookings.Remove(deleteUserBooking);
                this._context.SaveChanges();
            }

            return Redirect("~/shop/shop-home/" + shopId);
            //return RedirectToAction("index");
        }
    }
}