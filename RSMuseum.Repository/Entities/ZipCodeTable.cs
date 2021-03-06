﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSMuseum.Repository.Entities
{
    public class ZipCodeTable
    {
        public int ZipCodeTableId { get; set; }

        [Required]
        public int ZipCode { get; set; }

        [Required]
        public string City { get; set; }
    }
}