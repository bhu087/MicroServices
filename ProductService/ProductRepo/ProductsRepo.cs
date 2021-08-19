using ProductService.Model;
using ProductService.ProductDBContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.ProductRepo
{
    public class ProductsRepo : IProductsRepo
    {
        public ProductDBContext context;
        public ProductsRepo(ProductDBContext productDbContext)
        {
            this.context = productDbContext;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                var product = this.context.Products.Select(x => x).ToList();
                if (product == null)
                {
                    return null;
                }
                if (product != null)
                {
                    return product;
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
