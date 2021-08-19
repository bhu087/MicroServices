using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderHistoryUpdate.Model;

namespace OrderHistoryUpdate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderHistoryUpdateController : ControllerBase
    {
        [HttpPost]
        public ActionResult AddToOrderHistory(OrderHistory orderHistory)
        {
            System.Threading.Thread.Sleep(10000);
            if (true)
            {
                return this.Ok(new { Status = true, Message = "List of orders", Data = "Order History Updated" });
            }
            else
            {
                return this.BadRequest(new { Status = true, Message = "No orders list available", Data = "Order History not Updated" });
            }
        }
    }
}
