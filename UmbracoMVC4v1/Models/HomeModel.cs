using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UmbracoMVC4v1.Models;
using Umbraco.Web.Models;

namespace UmbracoMVC4v1.Models
{
    public class HomeModel : RenderModel
    {
        public HomeModel(RenderModel model) : base(model.Content, model.CurrentCulture)
        {

        }

        public string Message { get; set; }

        //public string SearchTerm { get; set; }

        public string Category { get; set; }

        public IEnumerable<ProductModel> SearchResultsList { get; set; }
    }
}