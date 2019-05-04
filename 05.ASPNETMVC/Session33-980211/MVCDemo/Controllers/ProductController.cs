using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            //var search = Request.QueryString["search"];
            //var search = Request.Form["search"];
            var search = string.IsNullOrEmpty(Request["search"]) ? "" : Request["search"] ;

            AWEntities ctx = new AWEntities();
            var products = ctx
                .Products
                .Where(p => p.Name.Contains(search) || p.ProductID.ToString() == search)
                .ToList();
            return View(products);
        }
    }
}