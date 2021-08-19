using ProductService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.ProductRepo
{
    public interface IProductsRepo
    {
        IEnumerable<Product> GetAllProducts();
    }
}
