namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gender_correction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Gender", c => c.String(maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Gender");
        }
    }
}
