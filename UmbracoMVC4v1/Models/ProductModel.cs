using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoMVC4v1.Models
{
    public class ProductModel
    {
        public string ProductName { get; set; }
        public string Sku { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
    }
}