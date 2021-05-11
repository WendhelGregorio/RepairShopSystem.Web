using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.ViewModels.booking;
using ProjectBSIS401.WEB.ViewModels.shop;

namespace ProjectBSIS401.WEB.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHubContext<SignalHub> _hubContext;
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private IHostingEnvironment _env;

        public BookingController(DefaultDbContext context, IConfiguration config, IHostingEnvironment env, IHubContext<SignalHub> hubContext)
        {
            _context = context;
            _config = config;
            _env = env;
            _hubContext = hubContext;
        }

     


        public IActionResult Index()
        {
            return View();
        }


        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("booking/book-costumer/{shopId}/{userId}/{shopServiceId}")]
        public IActionResult BookUser(Guid? shopId,Guid? userId,Guid? shopServiceId)
        {
            var shop = this._context.Shops.FirstOrDefault(u => u.Id == shopId);
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);
            var shopService = this._context.ShopServices.FirstOrDefault(u => u.Id == shopServiceId);

            
            if (shop == null)
            {
                if (user == null)
                {
                    if (shopService == null)
                    {
                         return BadRequest();
                    }
                }
            }

            

            return View(new BookingViewModel
            {

                UserName = user.UserName,
                ContactNumber = user.PhoneNumber,
                ShopId = shopId,
                UserId = userId,
                ShopServiceId = shopServiceId,
                TitleShopService = shopService.Service,
                DescriptionShopService = shopService.Description,
                PriceShopService = shopService.Price,
                
                
            });
        }
        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("booking/book-costumer")]
        public IActionResult BookUser(BookingViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

         
            var shop = this._context.Shops.FirstOrDefault(s => s.Id == model.ShopId);
            var user = this._context.Users.FirstOrDefault(u => u.Id == model.UserId);
            var shopServices = this._context.ShopServices.FirstOrDefault(ss => ss.Id == model.ShopServiceId);
            var tacId = Guid.Parse("0919fe8a-f05b-4f1f-a0ee-db37664fad38");
            var tac = this._context.TermAndConditions.FirstOrDefault(t => t.Id == tacId);

            if (shop != null)
            {
                if(user != null)
                {
                    if(shopServices != null)
                    {
                        Booking bookings = new Booking()
                        {
                            Id = Guid.NewGuid(),
                            UserId = model.UserId.Value,
                            ShopId = model.ShopId.Value,
                            ShopServiceId = model.ShopServiceId.Value,
                            UserName = model.UserName,
                            ContactNumber = model.ContactNumber,
                            ShopServiceName = model.TitleShopService,
                            ShopServicePrice = model.PriceShopService,
                            ShopServiceDescription = model.DescriptionShopService,
                            AdditionalDescription = model.AdditionalDescription,
                            ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                            Address = model.Address,
                            UpdatedAt = DateTime.UtcNow,
                            DateAndTime = model.DateAndTime,
                            CreatedAt = DateTime.UtcNow,
                            TimeStamps = DateTime.UtcNow,
                            TermAndConditionId = tacId,
                            TermAndCondition = tac,
                        };
                        WebIDS.SetBookingId(bookings.Id);
                   
                        this._context.Bookings.Add(bookings);

                        shop.LikesEnabled = true;
                        shop.RatingsEnabled = true;
                        shop.CommentsEnabled = true;
                        _context.Shops.Update(shop);

                        this._context.SaveChanges();
                    }
                    else
                    {
                        return Redirect("~/home/index");
                    }
                }
            }
            //return RedirectToAction("Index", new { ShopId = model.ShopId, UserId = model.UserId });

            //return Redirect("~/shop/shop-items/" + model.ShopId + "/" + model.UserId);
            return Redirect("~/booking/book-review/" + WebIDS.GetBookingId);

        }
        [Authorize(Policy = "SignedIn")]
        [HttpGet,Route("/booking/book-review/{bookingId}")]
        public IActionResult BookReview(Guid? bookingId)
        {
          
            var user = this._context.Users.FirstOrDefault(u => u.Id == WebIDS.GetPublicUserId);

            var booking = this._context.Bookings.FirstOrDefault(b => b.Id == bookingId);

            var bookings = this._context.Bookings.Where(b => b.Id == bookingId)
                                               .OrderByDescending(b => b.UpdatedAt)
                                               .ToList();

       

            return View(new BookReviewViewModel
            {
                User = user,
                Booking = booking,
                Bookings = bookings,


            });
        }
        [Authorize(Policy = "SignedIn")]
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

        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("booking/delete-user-booking/{bookingId}/{shopId}")]
        public IActionResult Delete(Guid? bookingId, Guid? shopId)
        {
            var deleteUserBooking = this._context.Bookings.FirstOrDefault(c => c.Id == bookingId);

            if (deleteUserBooking != null)
            {
                this._context.Bookings.Remove(deleteUserBooking);
                this._context.SaveChanges();
            }

            return Redirect("~/shop/my-dashboard");
            //return RedirectToAction("index");
        }

        [Authorize(Policy = "SignedIn")]
        [HttpPost("/booking/change-status")]
        public async Task<IActionResult> ChangeStatus(ChangeStatusViewModel model)
        {
            var booking = _context.Bookings.FirstOrDefault(p => p.Id == model.BookingId);

            if (booking != null)
            {
                booking.ReserveStatus = model.Status;

                _context.Bookings.Update(booking);
                _context.SaveChanges();
            }
            //Post to Hub
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", booking.UserId, "Your booking " + booking.ShopServiceName + " has been updated to " + booking.ReserveStatus + " " + " date of " + booking.UpdatedAt);

       
            return RedirectPermanent("~/shop/my-dashboard");
        }

        [Authorize(Policy = "SignedIn")]
        [HttpPost("/booking/change-payment-status")]
        public async Task<IActionResult> PaymentChangeStatus(PaymentChangeStatusViewModel model)
        {
            var booking = _context.Bookings.FirstOrDefault(p => p.Id == model.BookingId);

            if (booking != null)
            {
                booking.PaymentType = model.PaymentType;

                _context.Bookings.Update(booking);
                _context.SaveChanges();
            }
            //Post to Hub
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", booking.UserId, "Your booking " + booking.ShopServiceName + " has been updated to " + booking.PaymentType + " " + "date of" + booking.UpdatedAt);


            return RedirectPermanent("~/shop/my-dashboard");
        }


        private void TermAndCondition(Guid? bookingId)
        {
            Guid? tacId = Guid.Parse("0919fe8a-f05b-4f1f-a0ee-db37664fad38");

            var booking = this._context.Bookings.FirstOrDefault(b => b.Id == bookingId);
            var tac = this._context.TermAndConditions.FirstOrDefault(t => t.Id == tacId);

            if(booking != null)
            {   
                if(tac != null)
                {
                    booking.TermAndConditionId = tacId;
                    booking.TermAndCondition = tac;

                    this._context.Bookings.Update(booking);
                    this._context.SaveChanges();
                }
                
            }
               
            
        }

    }
}