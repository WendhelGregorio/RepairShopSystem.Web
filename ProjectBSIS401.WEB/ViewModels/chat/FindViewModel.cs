using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.chat
{
    public class FindViewModel
    {
        public Shop Shop { get; set; }

        public UserRole UserRole { get; set; }

        public List<User> Users { get; set; }

    }
}
