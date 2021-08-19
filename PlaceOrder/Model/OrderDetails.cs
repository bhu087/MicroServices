using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceOrder.Model
{
    public class OrderDetails
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int Quantity { get; set; }
        public int TotalAmount { get; set; }
    }
}
