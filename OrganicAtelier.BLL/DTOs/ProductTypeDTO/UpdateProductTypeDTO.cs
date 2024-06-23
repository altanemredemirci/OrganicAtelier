﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.BLL.DTOs.ProductTypeDTO
{
    public class UpdateProductTypeDTO
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool Status { get; set; }
    }
}

