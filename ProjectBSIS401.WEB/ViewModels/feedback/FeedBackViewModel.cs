using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.feedback
{
    public class FeedBackViewModel
    {
        public string Comment { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        //public int? Select { get; set; }
        //public List<Answer> Answers { get; set; }
    }
}

