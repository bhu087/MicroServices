using Microsoft.EntityFrameworkCore;
using ProductService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.ProductDBContexts
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
