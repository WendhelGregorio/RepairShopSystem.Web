using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.chat
{
    public class MessagesViewModel
    {
        public Guid? ChatId { get; set; }

        public Guid? UserId { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }

     


    }
}
