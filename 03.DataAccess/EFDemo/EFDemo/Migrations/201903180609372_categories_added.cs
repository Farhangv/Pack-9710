namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categories_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Books.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("Books.Book", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("Books.Book", "CategoryId");
            AddForeignKey("Books.Book", "CategoryId", "Books.Category", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Books.Book", "CategoryId", "Books.Category");
            DropIndex("Books.Book", new[] { "CategoryId" });
            DropColumn("Books.Book", "CategoryId");
            DropTable("Books.Category");
        }
    }
}
