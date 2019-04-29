using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult ProductList()
        {
            //return Content("صفحه لیست محصولات");
            //return new ContentResult() {
            //    Content = "صفحه لیست محصولات",
            //    ContentEncoding = Encoding.UTF8,
            //    ContentType = "text/plain"
            //};

            return View();
        }
    }
}