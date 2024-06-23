using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.BLL.DTOs.ProductDTO
{
    public class CreateProductDTO
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public decimal Price { get; set; }

        public decimal Weight { get; set; }

        public decimal Unit { get; set; }

        [StringLength(200)]
        public string Image { get; set; }
      
        public bool Status { get; set; }

        public bool IsPopular { get; set; }

        public int ProductTypeId { get; set; }
    }
}
