using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.feedback
{
    public class FeedBackViewModel
    {
        public Guid? UserId { get; set; }

        public Guid? ShopId { get; set; }

        public RatingNumber Rating { get; set; }

        public string Comment { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        
    }
}

