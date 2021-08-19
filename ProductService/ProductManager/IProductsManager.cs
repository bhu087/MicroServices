using ProductService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.ProductManager
{
    public interface IProductsManager
    {
        IEnumerable<Product> GetAllProducts();
    }
}
