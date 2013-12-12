using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UmbracoMVC4v1.Models;
using Umbraco.Web.Models;

namespace UmbracoMVC4v1.Controllers
{
    public class HomeController : Umbraco.Web.Mvc.RenderMvcController
    {
        //
        // GET: /Home/

        public override ActionResult Index(RenderModel model)
        {
            HomeModel customModel = new HomeModel(model);
            customModel.Message = "Hello world from HomeController";
            //customModel.SearchTerm = string.Empty;
            return CurrentTemplate(customModel);
        }

    }
}
