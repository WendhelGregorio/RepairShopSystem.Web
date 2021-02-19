﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Areas.Manage.ViewModels.shops
{
    public class BannerViewModel
    {
        public Guid? ShopId { get; set; }
        public IFormFile Banner { get; set; }
    }
}
