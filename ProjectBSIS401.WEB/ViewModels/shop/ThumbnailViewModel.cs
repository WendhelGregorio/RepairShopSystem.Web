using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shop
{
    public class ThumbnailViewModel
    {
        public Guid? ShopId { get; set; }

        public IFormFile Thumbnail { get; set; }
    }
}
