using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.chat
{
    public class IndexViewModel
    {
        public List<ChatUser> ChatUsers { get; set; }

        public List<Chat> Chats { get; set; }

        public Guid? UserId { get; set; }

        public Role Role { get; set; }

    }
}
