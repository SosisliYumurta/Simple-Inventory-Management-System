﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int StockQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string DateAdded { get; set; }
    }
}