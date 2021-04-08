using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.chat
{
    public class ChatsViewModel
    {
        public User User { get; set; }

        public Chat Chat { get; set; }
    }
}
