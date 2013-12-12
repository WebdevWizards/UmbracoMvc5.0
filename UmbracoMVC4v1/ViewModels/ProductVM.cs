using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UmbracoMVC4v1.Models;

namespace UmbracoMVC4v1.ViewModels
{
    public class ProductVM
    {
        public IEnumerable<ProductModel> ProductList { get; set; }
    }
}