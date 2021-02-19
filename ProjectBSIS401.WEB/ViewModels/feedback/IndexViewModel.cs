using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.feedback
{
    public class IndexViewModel
    {


        public List<FeedBack> ShopFeedBacks { get; set; }

        public int Count { get; set; }

    }
}
