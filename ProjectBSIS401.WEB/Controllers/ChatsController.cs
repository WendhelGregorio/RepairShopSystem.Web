using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.ViewModels.chat;

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

        [HttpGet,Route("chats/todo-items")]
        public IActionResult TodoItems()
        {
            return View();
        }


        [HttpPost, Route("chats/todo-items")]
        public IActionResult TodoItems(TodoItemsViewModel model)
        {
            return View();
        }

        //public List<Service> GetServices(Guid? id)
        //{
        //    var service = this._context.Services.FirstOrDefault(s => s.Id == id);
        //    if (service == null)
        //    {
        //        Console.WriteLine("No services found");
        //    }

        //    return _context.Services.Where(s => s.Id == id).Select(s => new GetServicesViewModel
        //    {
        //        Name = s.Name,
        //        ServiceType = s.ServiceType

        //    }).OrderBy(s => s.Name).ToList();
        //}
    }
}