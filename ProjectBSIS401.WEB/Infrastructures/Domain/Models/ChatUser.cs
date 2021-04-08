using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class ChatUser
    {
        public Guid? UserId { get; set; }

        public User User { get; set; }

        public Guid? ChatId { get; set; }

        public Chat Chat { get; set; }

        public Role Role { get; set; }

    }
}
