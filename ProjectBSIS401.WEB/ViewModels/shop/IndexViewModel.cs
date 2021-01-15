using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shop
{
    public class IndexViewModel
    {
        public Guid? Id { get; set; }

        public List<Shop> Shops { get; set; }

        public string Keyword { get; set; }

        public BusinessType BType { get; set; }

        //public List<Client> Clients { get; set; }

        public List<BusinessType> btype
        {
            get
            {
                return Enum.GetValues(typeof(BusinessType)).Cast<BusinessType>().ToList();
            }
        }
    }
}
