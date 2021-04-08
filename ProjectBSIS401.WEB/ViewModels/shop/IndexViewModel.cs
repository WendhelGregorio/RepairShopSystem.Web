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
        public Guid? UserId { get; set; }

        public Page<Shop> Shops { get; set; }

        public BusinessType businessType { get; set; }

        public List<BusinessType> businessTypes
        {
            get
            {
                return Enum.GetValues(typeof(BusinessType)).Cast<BusinessType>().ToList();
            }
        }
    }
}
