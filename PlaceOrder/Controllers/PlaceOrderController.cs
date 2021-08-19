using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlaceOrder.Model;
using PlaceOrder.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceOrder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlaceOrderController : ControllerBase
    {
        private IPlaceOrderRepo repo;
        public PlaceOrderController(IPlaceOrderRepo placeOrderRepo)
        {
            this.repo = placeOrderRepo;
        }

        [HttpPost]
        public ActionResult PlaceOrder(OrderDetails orderDetails)
        {
            Task<string> response = repo.PlaceOrder(orderDetails);
            if (response != null)
            {
                return this.Ok(new { Status = true, Message = "Order Placed", Data = response });
            }
            else
            {
                return this.BadRequest(new { Status = true, Message = "Order Not Placed", Data = response });
            }
        }
    }
}
