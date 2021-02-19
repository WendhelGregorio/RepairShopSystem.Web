    using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class Service : BaseModel
    { 
    
        public string Name { get; set; }

        public string Description { get; set; }

        public ServiceType ServiceType { get; set; }

        public bool IsPublished { get; set; }
      

    }
}
