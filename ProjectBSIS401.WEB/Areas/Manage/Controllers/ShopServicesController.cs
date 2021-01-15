using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;

namespace ProjectBSIS401.WEB.Areas.Manage.Controllers
{
    public class ShopServicesController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private IHostingEnvironment _env;


        public ShopServicesController(DefaultDbContext context,IConfiguration config,IHostingEnvironment env)
        {
            _context = context;
            _config = config;
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListServices()
        {
            var services = this._context.Services.ToList();
           //public IEnumerable<Service> Services { get; set; }
            return View();
        }
    }
}