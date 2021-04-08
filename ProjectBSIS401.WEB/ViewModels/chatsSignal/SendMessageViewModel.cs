using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.chatsSignal
{
    public class SendMessageViewModel
    {
        public string Message { get; set; }


        public Guid? UserId { get; set; }

        public Guid? RoomId { get; set; }
    }
}
