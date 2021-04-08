using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.ViewModels.chat;

namespace ProjectBSIS401.WEB.Controllers
{
    public class ChatsController : Controller
    {
        private readonly IHubContext<SignalHub> _hubContext;
        private readonly DefaultDbContext _context;

        public ChatsController(DefaultDbContext context, IHubContext<SignalHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }

        [Route("chats/index")]
        public IActionResult Index()
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == WebIDS.UserId);
            
            var chats = this._context.Chats
                                    .Include(x => x.Users)
                                    .Where(x => !x.Users.Any(y => y.UserId == user.Id))
                                    .ToList();
                                  
            
            return View(new IndexViewModel
            {
                Chats = chats,
                UserId = user.Id
                
            });
        }



        [HttpPost,Route("chats/create-room")]
        public async Task<IActionResult> CreateRoom(string name,Guid? userId)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var userRole = this._context.UserRoles.FirstOrDefault(u => u.UserId == userId);

            var chat = new Chat
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Name = name,
                Type = Infrastructures.Domain.Enums.ChatType.Room

            };
            if(userRole.Role == Infrastructures.Domain.Enums.Role.Admin)
            {

                chat.Users.Add(new ChatUser
                {
                    UserId = userId,
                    Role = Infrastructures.Domain.Enums.Role.Admin
                });

            }
            else if(userRole.Role == Infrastructures.Domain.Enums.Role.User)
            {
                chat.Users.Add(new ChatUser
                {
                    UserId = userId,
                    Role = Infrastructures.Domain.Enums.Role.User
                });

            }
            else if (userRole.Role == Infrastructures.Domain.Enums.Role.ShopAdmin)
            {
                chat.Users.Add(new ChatUser
                {
                    UserId = userId,
                    Role = Infrastructures.Domain.Enums.Role.ShopAdmin
                });

            }
            else
            {

            }


            this._context.Chats.Add(chat);
            await this._context.SaveChangesAsync();


            return RedirectToAction("Index");
        }

        [HttpGet,Route("/chats/join-room/{chatId}")]
        public async Task<IActionResult> JoinRoom(Guid? chatId )
        {
            var chatUser = new ChatUser()
            {
                UserId = WebIDS.UserId,
                Role = Infrastructures.Domain.Enums.Role.Member
                
            };
            WebIDS.RoomId = chatId;

            this._context.ChatUsers.Add(chatUser);
            await this._context.SaveChangesAsync();

            return RedirectToAction("Chat", new { chatId = chatUser.ChatId });
        }


        [HttpGet,Route("chats/new-chat/{chatId}")]
        public IActionResult Chat(Guid? chatId)
        {
            var chat = this._context.Chats
                                    .Include(c => c.Messages)
                                    .OrderByDescending(c => c.Messages.OrderByDescending(m => m.Timestamp))
                                    .FirstOrDefault(c => c.Id == chatId);
            if (chat == null)
            {
                return BadRequest();
            }
            var user = this._context.Users.FirstOrDefault(u => u.Id == WebIDS.UserId);

            return View(new NewChatViewModel
            {
                User = user,
                Chat = chat,
            });
        }

        
        [HttpGet,Route("chats/find")]
        public IActionResult Find()
        {
            var users = this._context.Users.Where(x => x.Id != WebIDS.UserId)
                .Include(x => x.Shops)
                .ToList();

            return View(new FindViewModel
            {
                Users = users
            });
        }


        [HttpGet,Route("/chats/private")]
        public IActionResult Private()
        {
            var chats = this._context.Chats
                                     .Include(x => x.Users)
                                            .ThenInclude(x => x.User)
                                     .Where(x => x.Type == Infrastructures.Domain.Enums.ChatType.Private
                                     && x.Users.Any(y => y.UserId == WebIDS.UserId)
                                     ).ToList();

            return View(new PrivateChatViewModel
            {
                Chats = chats

            });
        }

        [HttpGet,Route("/chats/create-private-room/{userId}")]
        public async Task<IActionResult> CreatePrivateRoom(Guid? userId)
        {
            var user = this._context.Users.Include(x => x.Shops).FirstOrDefault(x => x.Id == userId);
            var chat = new Chat
            {
                Id = Guid.NewGuid(),
                Name = "My Private Chat With" + " " +  user.Shops.BusinessName,
                Type = Infrastructures.Domain.Enums.ChatType.Private
            };

            chat.Users.Add(new ChatUser
            {
                UserId = userId
            });

            chat.Users.Add(new ChatUser
            {
                UserId = WebIDS.UserId
            });

            this._context.Chats.Add(chat);
            await _context.SaveChangesAsync();

            return RedirectToAction("Chat", new { ChatId = chat.Id });
        }



        //
        [HttpGet,Route("~/chats/chat-shop/{chatId}")]
        public IActionResult ChatShop(Guid? chatId)
        {
            var chat = this._context.Chats
                                     .Include(c => c.Messages)
                                     .OrderByDescending(c => c.Messages.OrderByDescending(m => m.Timestamp))
                                     .FirstOrDefault(c => c.Id == chatId);
            if (chat == null)
            {
                return BadRequest();
            }
            var user = this._context.Users.FirstOrDefault(u => u.Id == WebIDS.UserId);
            return View(new ChatsViewModel
            {
                User = user,
                Chat = chat
            });
        }

        [HttpPost,Route("/chats/messages")]
        public async Task<IActionResult> CreateMessages(MessagesViewModel model)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == model.UserId);
            var chat = this._context.Chats.FirstOrDefault(s => s.Id == model.ChatId);
            if(user != null)
            {
                if(chat != null)
                {
                    var Message = new Message()
                    {
                        Id = Guid.NewGuid(),
                        ChatId = model.ChatId,
                        UserId = model.UserId,
                        Name = model.Name,
                        Text = model.Message,
                        Timestamp = DateTime.UtcNow
                    };

                    this._context.Messages.Add(Message);
                    await _context.SaveChangesAsync();
                }
            }

            return RedirectToAction("ChatShop",new { shopId = model.ChatId });
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