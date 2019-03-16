namespace EFCodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chanagesinbook : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Books", newName: "Book");
            AlterColumn("dbo.Book", "ISBN", c => c.String(maxLength: 50));
            CreateIndex("dbo.Book", "ISBN", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Book", new[] { "ISBN" });
            AlterColumn("dbo.Book", "ISBN", c => c.String());
            RenameTable(name: "dbo.Book", newName: "Books");
        }
    }
}
