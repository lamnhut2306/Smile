using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile.GoldPriceService.DataAccessor.Entities
{
    public class PriceEntity : BaseEntity
    {
        [Required]
        public string? Unit { get; set; }

        public decimal Price { get; set; }

        [Required]
        public string? Type { get; set; }
    }
}
