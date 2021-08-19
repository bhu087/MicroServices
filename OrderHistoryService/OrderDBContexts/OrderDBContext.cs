using Microsoft.EntityFrameworkCore;
using OrderHistoryService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Model;

namespace OrderHistoryService.OrderDBContexts
{
    public class OrderDBContext : DbContext
    {
        public OrderDBContext(DbContextOptions<OrderDBContext> options) : base(options)
        {

        }
        public DbSet<OrderHistory> Orders { get; set; }
    }
}
