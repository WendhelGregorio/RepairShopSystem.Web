using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.Models;
using ProjectBSIS401.WEB.ViewModels.home;

namespace ProjectBSIS401.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly DefaultDbContext _context;

        public HomeController(DefaultDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var services = this._context.Services.ToList();

            return View(new HomeIndexViewModel()
            {
                Shops = FeedShops(1),
                PublicServices = services
                
            });
        }

        [HttpGet, Route("home/feed-shop")]
        public List<Shop> FeedShops(int pageIndex)
        {
            int skip = (int)(3 * (pageIndex - 1));
            return this._context.Shops
                                .Where(p => p.IsPublished == true)
                                .OrderBy(p => p.CreatedAt)
                                .Skip(skip)
                                .Take(30)
                                .ToList();
        }

      

        //public PartialViewResult RenderClient()
        //{
        //    return PartialView(GetTeachers());
        //}

        [HttpGet,Route("~/home/pricing")]
        public IActionResult Pricing()
        {
            return View();
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

        [HttpGet,Route("home/contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost,Route("home/contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }


            Contact contact = new Contact()
            {
                FullName = model.FullName,
                PhoneNumber = model.PhoneNumber,
                EmailAddress = model.EmailAddress,
                Message = model.Message
            };
            this._context.Contacts.Add(contact);
            this._context.SaveChanges();

            return View();

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
    }
}
