using OrderHistoryService.Model;
using OrderHistoryService.OrderHistoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderHistoryService.OrderHistoryManager
{
    public class OrdersManager : IOrdersManager
    {
        private IOrdersRepo repo;
        public OrdersManager(IOrdersRepo ordersRepo)
        {
            this.repo = ordersRepo;
        }
        public IEnumerable<OrderHistory> GetOrderHistory()
        {
            try
            {
                return this.repo.GetOrderHistory();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public async Task<string> UpdateOrderHistory(OrderHistory orderHistory)
        {
            try
            {
                return await this.repo.UpdateOrderHistory(orderHistory);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
