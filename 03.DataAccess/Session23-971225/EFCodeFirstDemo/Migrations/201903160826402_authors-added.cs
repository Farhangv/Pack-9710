namespace EFCodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authorsadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Book_Id = c.Int(nullable: false),
                        Author_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_Id, t.Author_Id })
                .ForeignKey("dbo.Book", t => t.Book_Id, cascadeDelete: true)
                .ForeignKey("dbo.Author", t => t.Author_Id, cascadeDelete: true)
                .Index(t => t.Book_Id)
                .Index(t => t.Author_Id);
            
            DropColumn("dbo.Book", "Author");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Book", "Author", c => c.String());
            DropForeignKey("dbo.BookAuthors", "Author_Id", "dbo.Author");
            DropForeignKey("dbo.BookAuthors", "Book_Id", "dbo.Book");
            DropIndex("dbo.BookAuthors", new[] { "Author_Id" });
            DropIndex("dbo.BookAuthors", new[] { "Book_Id" });
            DropTable("dbo.BookAuthors");
            DropTable("dbo.Author");
        }
    }
}
