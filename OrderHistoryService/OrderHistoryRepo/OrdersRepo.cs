using OrderHistoryService.Model;
using OrderHistoryService.OrderDBContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.DBContext;

namespace OrderHistoryService.OrderHistoryRepo
{
    public class OrdersRepo : IOrdersRepo
    {
        public OrderDBContext context;
        public UserDBContext userContext;
        public OrdersRepo(OrderDBContext orderDbContext, UserDBContext userDBContext)
        {
            this.context = orderDbContext;
            this.userContext = userDBContext;
        }
        public IEnumerable<OrderHistory> GetOrderHistory()
        {
            
            try
            {
                var userList = this.userContext.Users.Select(x => x).ToList();
                var ordererList = this.context.Orders.Select(x => x).ToList();
                var innerJoin = (from u in userList // outer sequence
                                join o in ordererList //inner sequence 
                                on u.UserID equals o.UserID // key selector 
                                select new OrderHistory
                                { // result selector 
                                    UserID = o.UserID,
                                    OrderID = o.OrderID
                                }).ToList();
                return innerJoin;
            }
            catch
            {
                throw new Exception();
            }
        }
        public async Task<string> UpdateOrderHistory(OrderHistory orderHistory)
        {

            try
            {
                this.context.Orders.Add(orderHistory);
                var result = await this.context.SaveChangesAsync();
                if (result == 1)
                {
                    return result.ToString();
                }
                return null;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
