using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.feedback
{
    public class LikeViewModel
    {
        public Guid? UserId { get; set; }
        public Guid? ShopId { get; set; }
        public bool IsLiked { get; set; }
    }
}
