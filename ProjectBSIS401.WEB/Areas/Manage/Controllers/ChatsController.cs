using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using ProjectBSIS401.WEB.Areas.Manage.ViewModels.hub;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;

namespace ProjectBSIS401.WEB.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ChatsController : Controller
    {
        private readonly IHubContext<NotificationHub> _hubcontext;
        public IHubContext<ChatHub> _hubctx { get; set; }

        private readonly DefaultDbContext _context;

        public ChatsController(IHubContext<ChatHub> hubctx, IHubContext<NotificationHub> hubContext, DefaultDbContext context)
        {
            _hubctx = hubctx;
            _hubcontext = hubContext;
            _context = context;
        }



        [Route("manage/chat")]
        public IActionResult Chat()
        {
            var chathub = new ChatHub();
      
            return View(chathub);
        }

       

    





    }
}