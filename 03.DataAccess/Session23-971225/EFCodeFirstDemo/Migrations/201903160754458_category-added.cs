namespace EFCodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Book", "Category_Id", c => c.Int());
            CreateIndex("dbo.Book", "Category_Id");
            AddForeignKey("dbo.Book", "Category_Id", "dbo.Category", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Book", "Category_Id", "dbo.Category");
            DropIndex("dbo.Book", new[] { "Category_Id" });
            DropColumn("dbo.Book", "Category_Id");
            DropTable("dbo.Category");
        }
    }
}
