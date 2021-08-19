using OrderHistoryService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderHistoryService.OrderHistoryRepo
{
    public interface IOrdersRepo
    {
        IEnumerable<OrderHistory> GetOrderHistory();
        Task<string> UpdateOrderHistory(OrderHistory orderHistory);
    }
}
