using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UmbracoMVC4v1.Models;
using UmbracoMVC4v1.ViewModels;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace UmbracoMVC4v1.Controllers
{
    public class ProductSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        public ActionResult Index()
        {
            UmbracoHelper helper = new UmbracoHelper(this.UmbracoContext);
            var id = 1052;
            IPublishedContent content = helper.TypedContent(id);
            var productNodes = content.AncestorOrSelf(1).Descendants("product");
            List<ProductModel> productList = new List<ProductModel>();

            foreach (var p in productNodes)
            {
                productList.Add(new ProductModel
                {
                    ProductName = p.Name,
                    Category = p.GetPropertyValue("Category").ToString(), 
                    Price = p.GetPropertyValue("Price").ToString(),
                    Sku = p.GetPropertyValue("Sku").ToString(),
                    Description = p.GetPropertyValue("Description").ToString()
                });
            }
           
            return PartialView("ProductList", model: new ProductVM { ProductList = productList });
        }
    }
}


//puuuuhaaaaa