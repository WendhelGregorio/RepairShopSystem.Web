using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.chat
{
    public class ChatViewModel
    {
        public Shop Shop { get; set; }

        public List<MessageViewModel> MessageItems { get; set; }

        public Guid? ShopId { get; set; }

        public Guid? UserId { get; set; }

        public string UserName { get; set; }



    }

    public class MessageViewModel
    {
        public Guid? Id { get; set; }

        public Guid? ShopId { get; set; }

        public Guid? UserId { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
