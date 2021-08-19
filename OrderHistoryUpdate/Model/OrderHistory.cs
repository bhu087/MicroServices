﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrderHistoryUpdate.Model
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
