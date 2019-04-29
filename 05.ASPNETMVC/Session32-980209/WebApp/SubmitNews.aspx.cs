using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class SubmitNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            News news = new News()
            {
                Title = Request.Form["title"],
                SubTitle = Request.Form["subtitle"],
                Content = Request.Form["content"]
            };
            //throw new Exception();
            Thread.Sleep(5000);
            NewsSiteModel ctx = new NewsSiteModel();
            ctx.News.Add(news);
            ctx.SaveChanges();
            message.InnerHtml = "خبر با موفقیت درج شد";
        }
    }
}