using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.ViewModels.shopServices;

namespace ProjectBSIS401.WEB.Controllers
{
    public class ShopServicesController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private IHostingEnvironment _env;
        public ShopServicesController(DefaultDbContext context, IConfiguration config, IHostingEnvironment env)
        {
            _context = context;
            _config = config;
            _env = env;
        }

        [HttpGet,Route("shop-services/index")]
        [HttpGet, Route("shop-services/index/{shopId}")]
        public IActionResult Index(Guid? shopId)
        {
            // Use LINQ to get list of names.
            IQueryable<string> nameQuery = this._context.Services.Where(s => s.IsPublished == true).OrderBy(s => s.Name).Select(s => s.Name);

            var services = from s in _context.Services
                           select s;
            return View(new IndexViewModel
            {
                ShopId = shopId,
                Services = services.ToList()
            });
        }

        [HttpGet,Route("shop-services/add")]
        [HttpGet,Route("shop-services/add/{shopId}/{serviceId}")]
        public IActionResult Add(Guid? shopId,Guid? serviceId)
        {
            var shop = this._context.Shops.FirstOrDefault(s => s.Id == shopId);
            if(shop == null)
            {
                return BadRequest();

            }
            var service = this._context.Services.FirstOrDefault(s => s.Id == serviceId);
            if(service == null)
            {
                return BadRequest();
            }
            return View(new AddViewModel
            {
                Description = service.Description,
                Service = service.Name,
                ShopId = shop.Id,
                ServiceId = service.Id
            });
        }

        [HttpPost, Route("shop-services/add")]
        public IActionResult Add(AddViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var shop = this._context.Shops.FirstOrDefault(s => s.Id == model.ShopId);
            if(shop == null)
            {
                return NotFound();
            }
            var service = this._context.Services.FirstOrDefault(s => s.Id == model.ServiceId);
            if(service == null)
            {
                return NotFound();
            }

            var shopServices = this._context.ShopServices.FirstOrDefault(ss => ss.ShopId == shop.Id);
            if(shopServices == null)
            {
                ShopService shopService = new ShopService
                {
                    Id = Guid.NewGuid(),
                    ServiceId = model.ServiceId,
                    Description = model.Description,
                    ShopId = model.ShopId,
                    Price = model.Price,
                    Service = model.Service
                };
                this._context.ShopServices.Add(shopService);
                this._context.SaveChanges();
            }
            else
            {
                ViewBag.Error = "You already have this services. Add other services";
                ModelState.AddModelError("", ViewBag.Error);
                return View("~/shop-services/add");
            }
             return Redirect("~/shop/shop-home/" + model.ShopId);
        }

      

        [HttpGet, Route("shop-services/delete-services-shop-services/{shopServiceId}/{shopId}")]
        public IActionResult Delete(Guid? shopServiceId, Guid? shopId)
        {
            var deleteShopServiceServices = this._context.ShopServices.FirstOrDefault(c => c.Id == shopServiceId);

            if (deleteShopServiceServices != null)
            {
                this._context.ShopServices.Remove(deleteShopServiceServices);
                this._context.SaveChanges();
            }

            return Redirect("~/shop/shop-home/" + shopId);
            //return RedirectToAction("index");
        }


        //public List<Service> GetServices(Guid? id)
        //{
        //    var service = this._context.Services.Where(s => s.Id == id).Select(s => new ShopServicesViewModel
        //    {
        //        ServiceId = s.Id,
        //        Name = s.Name,
        //        IsPublished = s.IsPublished,
        //        ServiceType = s.ServiceType
        //    }).OrderBy(s => s.Name)
        //      .ToList();

        //    return 
        //}
    }
}