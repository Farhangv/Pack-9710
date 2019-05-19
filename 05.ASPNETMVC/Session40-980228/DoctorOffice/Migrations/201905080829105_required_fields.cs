namespace DoctorOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required_fields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.People", "Family", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Family", c => c.String(maxLength: 60));
            AlterColumn("dbo.People", "Name", c => c.String());
        }
    }
}
