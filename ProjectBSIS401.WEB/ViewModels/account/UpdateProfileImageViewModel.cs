using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.account
{
    public class UpdateProfileImageViewModel
    {
        public Guid? UserId { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}

