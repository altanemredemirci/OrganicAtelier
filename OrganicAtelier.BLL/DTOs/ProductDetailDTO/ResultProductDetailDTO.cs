using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.BLL.DTOs.ProductDetailDTO
{
    public class ResultProductDetailDTO
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

