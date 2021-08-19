using ProductService.Model;
using ProductService.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.ProductManager
{
    public class ProductsManager : IProductsManager
    {
        private IProductsRepo repo;
        public ProductsManager(IProductsRepo productsRepo)
        {
            this.repo = productsRepo;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                return repo.GetAllProducts();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
