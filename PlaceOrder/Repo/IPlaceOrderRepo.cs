using PlaceOrder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceOrder.Repo
{
    public interface IPlaceOrderRepo
    {
        Task<string> PlaceOrder(OrderDetails orderDetails);
    }
}
