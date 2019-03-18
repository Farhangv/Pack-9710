namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class books_table_changed : DbMigration
    {
        public override void Up()
        {
            AddColumn("Books.Book", "CoverImage", c => c.Binary());
            AddColumn("Books.Book", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AlterColumn("Books.Book", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("Books.Book", "Description", c => c.String(maxLength: 250));
            CreateIndex("Books.Book", "Title", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("Books.Book", new[] { "Title" });
            AlterColumn("Books.Book", "Description", c => c.String());
            AlterColumn("Books.Book", "Title", c => c.String());
            DropColumn("Books.Book", "RowVersion");
            DropColumn("Books.Book", "CoverImage");
        }
    }
}
