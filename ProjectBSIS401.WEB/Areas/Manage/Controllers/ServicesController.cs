using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Areas.Manage.ViewModels.services;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;

namespace ProjectBSIS401.WEB.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ServicesController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private IHostingEnvironment _env;

        public ServicesController(DefaultDbContext context, IConfiguration config, IHostingEnvironment env)
        {
            _context = context;
            _config = config;
            _env = env;
        }




        [HttpGet, Route("manage/service")]
        [HttpGet, Route("manage/service/index")]
        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string keyword = "", string service = "Android Phone")
        {
            Enum.TryParse(service, out ServiceType serviceType); ;

            Page<Service> result = new Page<Service>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Service> serviceQuery = (IQueryable<Service>)this._context.Services.Where(s => s.ServiceType == serviceType);

            if (string.IsNullOrEmpty(keyword) == false)
            {
                serviceQuery = serviceQuery.Where(s => s.Name.Contains(keyword));

            }

            long queryCount = serviceQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Service> services = serviceQuery.ToList();

            result.Items = services.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                Services = result,
                ServiceT = serviceType
            });
        }

        //[Authorize(Policy = "AuthorizeAdmin")]
        [HttpGet, Route("manage/service/delete/{serviceId}")]
        public IActionResult Delete(Guid? serviceId)
        {
            var service = this._context.Services.FirstOrDefault(s => s.Id == serviceId);

            if (service != null)
            {
                this._context.Services.Remove(service);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }

        [HttpGet, Route("manage/service/details/{id}")]
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = this._context.Services.FirstOrDefault(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }


        [HttpGet, Route("manage/service/public-details/{id}")]
        public IActionResult PublicDetails(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = this._context.Services.FirstOrDefault(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }




        [HttpGet, Route("manage/service/create")]
        public IActionResult CreateService()
        {

           
            return View();
        }

        [HttpPost, Route("manage/service/create")]
        public IActionResult CreateService(CreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Service service = new Service()
            {
                Id = Guid.NewGuid(),
                ServiceType = model.ServiceType,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            this._context.Services.Add(service);
            this._context.SaveChanges();


            return RedirectToAction("Index");

        }

   


        [HttpGet, Route("manage/service/edit/{id}")]
        public IActionResult Edit(Guid? id)
        {
            var service = this._context.Services.FirstOrDefault(s => s.Id == id);

            if (service == null)
            {
                return RedirectToAction("Index");
            }


            if (service != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = service.Id.Value,
                        Name = service.Name,
                        ServiceType = service.ServiceType,
                       
                    }
                );
            }

            return View();
        }

        [HttpPost, Route("manage/service/edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var service = this._context.Services.FirstOrDefault(s => s.Id == model.Id);

            if (service != null)
            {
                service.Name = model.Name;
                service.ServiceType = model.ServiceType;
                this._context.Services.Update(service);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }



        [HttpPost, Route("manage/service/unpublish")]
        public IActionResult Unpublish(ServiceIdViewModel model)
        {
            var service = this._context.Services.FirstOrDefault(s => s.Id == model.Id);
            if (service != null)
            {
                service.IsPublished = false;
                this._context.Services.Update(service);
                this._context.SaveChanges();
                return Ok();
            }
            return null;
        }


    
        [HttpPost, Route("manage/service/publish")]
        public IActionResult Publish(ServiceIdViewModel model)
        {
            var service = this._context.Services.FirstOrDefault(s => s.Id == model.Id);

            if (service != null)
            {
                service.IsPublished = true;
                this._context.Services.Update(service);
                this._context.SaveChanges();
                return Ok();
            }
            return null;
        }
       

     
    }
}