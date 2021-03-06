﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Classics_Shop.Models
{
    public class Arival
    {
        public int ID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string ProductName { get; set; }
        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Price")]
        public decimal UnitPrice { get; set; }
        public virtual Category Category { get; set; }
    }
}
