using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;

namespace ProjectBSIS401.WEB.Controllers
{
    public class ChatsController : Controller
    {
        private readonly DefaultDbContext _context;

        public ChatsController(DefaultDbContext context)
        {
            _context = context;
        }



        public IActionResult Chat()
        {
            return View();
        }
    }
}