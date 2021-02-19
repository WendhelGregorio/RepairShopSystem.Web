using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.shopServices
{
    public class AddViewModel
    {
        [Required,]
        public Guid? ShopId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required,]
        public Guid? ServiceId { get; set; }
        [Required]
        public string Service { get; set; }

        [Required(ErrorMessage = "Price is required to add services")]
        [Range(1, 10000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
