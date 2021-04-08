using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.feedback
{
    public class CommentWithRatingViewModel
    {
        public Guid? UserId { get; set; }

        public Guid? ShopId { get; set; }

        public string Comment { get; set; }

        public decimal Score { get; set; }

    }
}
