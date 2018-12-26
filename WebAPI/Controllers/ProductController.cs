using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using Newtonsoft.Json;


namespace WebAPI.Controllers
{
    public class ProductController : ApiController
    {
        

        List<Product> products = new List<Product>() {
            new Product{ id = 0, Name = "asd 0", Price = 400.80f, Quantity = 52 },
            new Product{ id = 1, Name = "asd 1", Price = 20.5f, Quantity = 20 },
            new Product{ id = 2, Name = "asd 2", Price = 50.5f, Quantity = 100 },
            new Product{ id = 3, Name = "asd 3", Price = 240.89f, Quantity = 10 },
            new Product{ id = 4, Name = "asd 4", Price = 90.5f, Quantity = 200 },
            new Product{ id = 5, Name = "asd 5", Price = 230.60f, Quantity = 30 },
            new Product{ id = 6, Name = "asd 6", Price = 560.99f, Quantity = 300 },
            new Product{ id = 7, Name = "asd 7", Price = 20.80f, Quantity = 52 },
            new Product{ id = 8, Name = "asd 8", Price = 230.60f, Quantity = 30 },
            new Product{ id = 9, Name = "asd 9", Price = 560.99f, Quantity = 300 },
        };

       
        public List<Product> Get() {
            return products;
        }

        /*
        [HttpGet]
        public List<Product> ListProducts()
        {
            return products;
        }


        public IEnumerable<Product> Get(){ 
            return products;
        }
        
        public IEnumerable<Product> GetList()
        {
            return products;
        }

        public HttpResponseMessage Get(int id)
        {
            
            if (products.Count > id) {
                String message = JsonConvert.SerializeObject(products[id]);
                return Request.CreateResponse(HttpStatusCode.OK, message);
            }
            else {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,"Not found the Product");

            }

        }

        public IHttpActionResult Post(product newProduct)
        {
            if (newProduct == null)
                return NotFound();
            else
            {
                //using (ProductContext productContext = new ProductContext())
                //{
                //    productContext.Products.Add(newProduct);
                //    productContext.SaveChanges();
                //}
                return Ok(newProduct);
            }


        }
        // can determinte route for the get action without the default route
        [Route("home/allstrings")]
        public List<String> Get()
        {
            return new List<string>() {"asd1", "asd2", "asd3", "asd4", "asd5", "asd6", "asd7" };
        }

        /*
         * 
        public IHttpActionResult Post(Product newProduct)
        {
            if (newProduct == null)
                return NotFound();
            else
            {
                products.Add(newProduct);
                return Ok(newProduct);
            }


        }
        public Product Get(int id)
        {
            return products.Count > id ? products[id] : null;
        }

        public IHttpActionResult Get(int id) {
            var product = products.Where(x => x.id == id);
            if (product == null)
                return NotFound();
            else
                return Ok(product);
        }*/
    }
}