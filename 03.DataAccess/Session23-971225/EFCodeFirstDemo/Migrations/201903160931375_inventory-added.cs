namespace EFCodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inventoryadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        BookId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Book", t => t.BookId)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventories", "BookId", "dbo.Book");
            DropIndex("dbo.Inventories", new[] { "BookId" });
            DropTable("dbo.Inventories");
        }
    }
}
