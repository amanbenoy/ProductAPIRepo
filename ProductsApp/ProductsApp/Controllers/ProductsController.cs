using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Baseball", Category = "Toy", Price = 3.50M },
            new Product { Id = 2, Name = "Super Mario Bros", Category = "Games", Price = 9M },
            new Product { Id = 3, Name = "Apple Juice", Category = "Shmoceries", Price = 4.59M }
        };

        public ProductsController()
        {

        }

        public ProductsController(Product[] products)
        {
            this.products = products;
        }

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