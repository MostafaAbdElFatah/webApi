using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Product
    {
        public int id { get; set; }
        public String Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
}