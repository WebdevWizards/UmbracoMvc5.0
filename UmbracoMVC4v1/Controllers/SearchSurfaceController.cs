using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examine;
using UmbracoMVC4v1.ViewModels;
using Umbraco.Core.Models;
using umbraco;
using Umbraco.Web;

namespace UmbracoMVC4v1.Controllers
{
    
      public class SearchSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        public ActionResult Search(string SearchTerm)
        {
            SearchViewModel model = new SearchViewModel();
            SearchTerm = SearchTerm.ToLower();

            //UmbracoHelper helper = new UmbracoHelper(this.UmbracoContext);
            //var id = 1052;
            //IPublishedContent content = helper.TypedContent(id);
            //var productNodes = content.AncestorOrSelf(1).Descendants("product");

            var criteria = ExamineManager.Instance.DefaultSearchProvider.CreateSearchCriteria("content");

            var filter = criteria.NodeTypeAlias("Product");
            var results = Umbraco.TypedSearch(filter.Compile()).ToArray();

            //List<IPublishedContent> ResultsList = new List<IPublishedContent>();
            //ResultsList = results;

            List<IPublishedContent> list = new List<IPublishedContent>();

            foreach (var p in results)
            {
                //var cat = p.GetProperty("category").DataValue.ToString();

                if (p.GetProperty("category").DataValue.ToString().ToLower().Contains(SearchTerm))
                {
                    list.Add(p);
                }
            }

            model.SearchProductList = list.ToArray();
            //CustomSearchResults = ExamineManager.Instance.SearchProviderCollection["CustomSearcher"].Search(filter);

            //var renderModel = model.SearchProductList;

            return PartialView("SearchResultsPage", model);
        }
    }
}

