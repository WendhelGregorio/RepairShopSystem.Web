using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.ViewModels.category;
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


        [HttpGet, Route("/shop-services/get-services")]
        public List<Service> GetServices()
        {
            System.Threading.Thread.Sleep(5000);
            return _context.Services.OrderByDescending(x => x.CreatedAt).ToList();
        }

        [HttpGet,Route("shop-services/add/{serviceId}")]
        public IActionResult Add(Guid? serviceId)
        {
            var shop = this._context.Shops.FirstOrDefault(s => s.Id == WebIDS.GetShopId);
            var service = this._context.Services.FirstOrDefault(s => s.Id == serviceId);
            if (shop == null)
            {
                if(service == null)
                {
                    return RedirectPermanent("/shop/my-dashboard");
                }

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
            var service = this._context.Services.FirstOrDefault(s => s.Id == model.ServiceId);
            if(shop != null)
            {
                if(service != null)
                {
                    var shopServices = this._context.ShopServices.FirstOrDefault(ss => ss.ServiceId == model.ServiceId);
                    if (shopServices != null)
                    {
                        ModelState.AddModelError("", "You already have this service. Click  cancel and choose another services.");
                        return View(model);
                    }
                    else
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
                        return Redirect("~/shop/my-dashboard");
                    }
                }
            }

            return NotFound();

           
        }

       

        [HttpGet, Route("shop-services/my-services/{shopId}")]
        public IActionResult MyShopService(Guid? shopId)
        {
            var myShopServices = this._context.ShopServices.Where(ss => ss.ShopId == shopId)
                                                 .OrderByDescending(ss => ss.UpdatedAt)
                                                 .ToList();

            return View(new MyShopServiceViewModel
            {
                ShopServices = myShopServices
            });
        }

        [HttpGet,Route("shop-services/shop-services-details/{id}")]
        public IActionResult ShopServiceDetails(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopService = this._context.ShopServices.FirstOrDefault(ss => ss.Id == id);
            if (shopService == null)
            {
                return NotFound();
            }

            return View(shopService);
        }

       [HttpGet,Route("shop-services/details/{id}")]
        public IActionResult PublicServiceDetails(Guid? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var service = this._context.Services.FirstOrDefault(ss => ss.Id == id);
            if(service == null)
            {
                return NotFound();
            }

            return View(service);
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

            return Redirect("~/shop/my-dashboard");
        }


      
    }
}