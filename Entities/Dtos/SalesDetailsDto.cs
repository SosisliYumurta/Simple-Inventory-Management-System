﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class SalesDetailsDto
    {
        public int SaleId { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public string CompanyName { get; set; }
        public int Quantity { get; set; }
        public string Date { get; set; }
    }
}
