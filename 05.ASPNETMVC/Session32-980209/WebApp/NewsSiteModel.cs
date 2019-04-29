namespace WebApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NewsSiteModel : DbContext
    {
        public NewsSiteModel()
            : base("NewsSiteModel")
        {
        }
        public DbSet<News> News { get; set; }
    }
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
    }
}