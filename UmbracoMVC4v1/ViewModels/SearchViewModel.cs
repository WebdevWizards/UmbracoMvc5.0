using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using UmbracoMVC4v1.Models;

namespace UmbracoMVC4v1.ViewModels
{

    public class SearchViewModel
    {
        public string SearchTerm { get; set; }
        public string Category { get; set; }
        public IPublishedContent[] SearchProductList { get; set; }
    }

    //public class SearchViewModel(string SearchTerm)
    //{
    //    public string SearchTerm { get; set; }
    //    public string Category { get; set; }
    //    public IPublishedContent[] SearchProductList { get; set; }
    //}
}