using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.Models;
using ProjectBSIS401.WEB.ViewModels.category;
using ProjectBSIS401.WEB.ViewModels.home;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectBSIS401.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly DefaultDbContext _context;

        public HomeController(DefaultDbContext context)
        {
            _context = context;
        }
        [HttpGet, Route("")]
        [HttpGet, Route("/home")]
        [HttpGet, Route("/home/index")]
        [HttpGet,Route("/home/index/{userId}")]
        public IActionResult Index(Guid? userId)
        {
            return View();
            
        }
        [HttpGet,Route("~/home/pricing")]
        public IActionResult Pricing()
        {
            var pricings = this._context.Pricings.Include(p => p.PricingContents).ToList();

            return View(new PricingViewModel
            {
                Pricings = pricings
            });
        }

       [HttpGet,Route("~/home/team")]
       public IActionResult Team()
        {
            return View();
        }


        [HttpGet,Route("~/home/ourservices")]
        public IActionResult OurServices()
        {
            var listServices = this._context.Services.ToList();

            return View(new HomeIndexViewModel
            {
                PublicServices = listServices
            });
        }

        [HttpGet,Route("~/home/faqs")]
        public IActionResult Faqs()
        {
            return View();
        }

        [HttpGet,Route("~/home/about")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpGet,Route("/home/contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost,Route("/home/contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var contactCheck = this._context.Contacts.FirstOrDefault(c => c.FullName == model.FullName  && c.EmailAddress == model.EmailAddress);
            if(contactCheck == null)
            {
         
                var contact = new Contact()
                {
                    Id = Guid.NewGuid(),
                    FullName = model.FullName,
                    PhoneNumber = model.PhoneNumber,
                    EmailAddress = model.EmailAddress,
                    Message = model.Message,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                this._context.Contacts.Add(contact);
            }
            else
            {
                contactCheck.MessageCount++;
            }
            this._context.SaveChanges();
            return Content(@"<p>Thank you for contacting us. We notify you us soon as possible.</p>");

        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

            
        [HttpGet("api/categories-per-type/{type}")]
        public List<CategoriesViewModel> GetCategories(string type = "")
        {
            if (string.IsNullOrEmpty(type))
            {
                return null;
            }

            BusinessType businessType = (BusinessType)Enum.Parse(typeof(BusinessType), type, true);

            return _context.Shops.Where(s => s.BusinessType == businessType)
                .Select(s => new CategoriesViewModel()
                {
                    Id = s.Id,
                    BusinessName = s.BusinessName,
                    BusinessLocation = s.BusinessLocation,
                    BusinessType = s.BusinessType,
                    OpenAt = s.OpenAt,
                    CloseAt = s.CloseAt,
                    BusinessDescription = s.BusinessDescription
      
                    
                }).ToList();
        }


        //public IViewComponentResult Invoke()
        //{
        //    var user = this._context.Users.FirstOrDefault(x => x.Id == WebIDS.UserId);

        //    var chats = this._context.ChatUsers
        //                    .Include(x => x.Chat)
        //                    .Where(x => x.UserId == user.Id && x.Chat.Type == ChatType.Room)
        //                    .Select(x => x.Chat)
        //                    .ToList();

        //    return ViewComponent(chats);
        //}
    }
}
