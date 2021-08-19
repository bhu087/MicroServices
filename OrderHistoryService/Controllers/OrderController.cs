using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderHistoryService.Model;
using OrderHistoryService.OrderHistoryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderHistoryService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private IOrdersManager manager;
        public OrderController(IOrdersManager ordersManager)
        {
            this.manager = ordersManager;
        }

        [HttpGet]
        public ActionResult GetAllProducts()
        {
            var response = manager.GetOrderHistory();
            if (response != null)
            {
                return this.Ok(new { Status = true, Message = "List of orders", Data = response });
            }
            else
            {
                return this.BadRequest(new { Status = true, Message = "No orders list available", Data = response });
            }
        }
        [HttpPost]
        public ActionResult UpdateOrderHistory(OrderHistory orderHistory)
        {
            var response = this.manager.UpdateOrderHistory(orderHistory);
            if (response != null)
            {
                return this.Ok(new { Status = true, Message = "Table updated", Data = response });
            }
            else
            {
                return this.BadRequest(new { Status = true, Message = "Table Not updated", Data = response });
            }
        }
    }
}
