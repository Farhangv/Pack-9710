namespace EFCodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class booktitlemaxlength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Book", "Title", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Book", "Title", c => c.String());
        }
    }
}
