using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductManager.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Apple iPhone Xs Max 256GB Bạc", Category = "iPhone", Price = 34.99M },
            new Product { Id = 2, Name = "Apple iPhone Xs Max 512GB Vàng kim", Category = "iPhone", Price = 37.99M },
            new Product { Id = 3, Name = "Apple iPhone Xs 64GB Xám đen", Category = "iPhone", Price = 24.49M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
