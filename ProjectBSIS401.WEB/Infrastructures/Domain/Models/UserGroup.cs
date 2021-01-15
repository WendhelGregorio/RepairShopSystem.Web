﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class UserGroup : BaseModel
    {
        public Guid? UserId { get; set; }

        public Guid? GroupId { get; set; }

        public string UserAlias { get; set; }

        public bool UpdateLocation { get; set; }

        public bool IsAdmin { get; set; }
    }
}
