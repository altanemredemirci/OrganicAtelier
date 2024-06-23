using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.BLL.DTOs.SliderDTO
{
    public class UpdateSliderDTO
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title1 { get; set; }
        [StringLength(100)]
        public string Title2 { get; set; }
        [StringLength(200)]
        public string? Description1 { get; set; }
        [StringLength(200)]
        public string? Description2 { get; set; }
        public string? ImageUrl1 { get; set; }
        public string? ImageUrl2 { get; set; }
        [StringLength(30)]
        public string Page { get; set; }
    }
}
