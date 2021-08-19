using OrderHistoryService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderHistoryService.OrderHistoryManager
{
    public interface IOrdersManager
    {
        IEnumerable<OrderHistory> GetOrderHistory();
        Task<string> UpdateOrderHistory(OrderHistory orderHistory);
    }
}
