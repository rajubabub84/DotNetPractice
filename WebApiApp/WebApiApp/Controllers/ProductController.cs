using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiApp.Models;

namespace WebApiApp.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {ProductID=1,ProductName="Prod1",ProductCategory="cat1",Price=1 },
            new Product {ProductID=2,ProductName="Prod2",ProductCategory="cat2",Price=2 },
            new Product {ProductID=3,ProductName="Prod3",ProductCategory="cat3",Price=3 }

        };

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
