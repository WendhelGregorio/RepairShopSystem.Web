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
            return View();
            
        }
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

            var userCheck = this._context.Contacts.FirstOrDefault(c => c.FullName == model.FullName  && c.EmailAddress == model.EmailAddress);
            if(userCheck == null)
            {
         
                Contact contact = new Contact()
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
                this._context.SaveChanges();

                

            }
            else
            {
                 ViewBag.Error = ",You already contact us. The contact page have one message a day.";
                 return View();
            }

            ViewBag.Success = "The message sent succesfully. Thank you for messaging us.";
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
