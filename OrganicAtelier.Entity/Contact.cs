using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.Entity
{
    public class Contact
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Text { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(13)]
        public string Phone { get; set; }
        [StringLength(300)]
        public string Email { get; set; }
        public string Location { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string LinkedIn { get; set; }
    }
}
