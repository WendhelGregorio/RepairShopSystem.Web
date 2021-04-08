using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class Chat : BaseModel
    {
        public Chat()
        {
            Messages = new List<Message>();
            Users = new List<ChatUser>();
            User = new List<User>();
        }

        public string Name { get; set; }

        public ChatType Type { get; set; }

        public List<Message> Messages { get; set; }

        public List<ChatUser> Users { get; set; }

        public List<User> User { get; set; }
    }
}
