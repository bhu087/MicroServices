using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductService.ProductManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductsManager manager;
        public ProductController(IProductsManager productsManager)
        {
            this.manager = productsManager;
        }

        [HttpGet]
        public ActionResult GetAllProducts()
        {
            var response = manager.GetAllProducts();
            if (response != null)
            {
                return this.Ok(new { Status = true, Message = "List of products", Data = response });
            }
            else
            {
                return this.BadRequest(new { Status = true, Message = "No product available", Data = response });
            }
        }
    }
}
