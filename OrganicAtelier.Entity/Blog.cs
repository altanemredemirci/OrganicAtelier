using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.Entity
{
    public class Blog
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        [StringLength(2000)]
        public string Text { get; set; }
        [StringLength(200)]
        public string Writer { get; set; }       
        public DateTime Date { get; set; }

    }
}
