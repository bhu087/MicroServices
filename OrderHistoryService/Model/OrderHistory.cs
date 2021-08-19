using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderHistoryService.Model
{
    public class OrderHistory
    {
        [Key]
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int Quantity { get; set; }
        public int TotalAmount { get; set; }
    }
}
