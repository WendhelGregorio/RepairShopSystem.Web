using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.ViewModels.chatsSignal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Controllers
{
    public class SignalHub : Hub
    {
        private readonly DefaultDbContext _context;

        public SignalHub(DefaultDbContext context)
        {
            _context = context;
        }
        public async Task SendMessage(Guid? userId, string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", userId, message);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("SendAction", WebIDS.Name, "joined");
        }

        public override async Task OnDisconnectedAsync(Exception ex)
        {
            await Clients.All.SendAsync("SendAction", WebIDS.Name, "left");
        }

        public async Task Send(string message, Guid? userid, Guid? chatid,string username)
        {
            var otheruser = this._context.Chats
                                    .Include(x => x.Users)
                                    .FirstOrDefault(u => u.Id == chatid && u.Type == Infrastructures.Domain.Enums.ChatType.Private);

            var otherusers = this._context.ChatUsers.FirstOrDefault(cu => cu.UserId != WebIDS.UserId && cu.ChatId == chatid);
            
            var Message = new Message()
            {
                Id = Guid.NewGuid(),
                Text = message,
                ChatId = chatid,
                UserId = userid,
                Name = username,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Timestamp = DateTime.UtcNow,
            };

            this._context.Messages.Add(Message);
            await _context.SaveChangesAsync();

            await Clients.All.SendAsync("SendMessage", username, message, Message.Timestamp.ToString("hh:mm tt"), Message.Timestamp.ToString("MMMM dd"), userid, otherusers.UserId);

        }


        public async Task SendMessageTo(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

  

     

    }
}