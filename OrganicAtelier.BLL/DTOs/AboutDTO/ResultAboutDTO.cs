﻿using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.BLL.DTOs.AboutDTO
{
    public class ResultAboutDTO
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
