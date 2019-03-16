namespace EFCodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignkeyadded : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Book", name: "Category_Id", newName: "CategoryId");
            RenameIndex(table: "dbo.Book", name: "IX_Category_Id", newName: "IX_CategoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Book", name: "IX_CategoryId", newName: "IX_Category_Id");
            RenameColumn(table: "dbo.Book", name: "CategoryId", newName: "Category_Id");
        }
    }
}
