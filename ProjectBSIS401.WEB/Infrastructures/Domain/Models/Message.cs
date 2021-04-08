using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class Message : BaseModel
    {
        public Guid? ChatId { get; set; }
        public Chat Chat { get; set; }

        public Guid? UserId { get; set; }

        public DateTime Timestamp { get; set; }

        public string Text { get; set; }

        public string Name { get; set; }

        public int  MessageCount { get; set; }

       

    }
}
