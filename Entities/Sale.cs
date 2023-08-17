using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Sale
    {
        public int SaleID { get; set; }
        public int ProductId { get; set; }
        public int CustomerID { get; set; }
        public int Quantity { get; set; }
        public string Date { get; set; }

    }
}
