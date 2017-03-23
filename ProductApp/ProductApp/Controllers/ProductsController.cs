using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] p = new Product[]
        {
            new Product {id=1,name="x" }
        };
        public IEnumerable<Product> GetAllProduct()
        {
            return p;
        }
    }
}
