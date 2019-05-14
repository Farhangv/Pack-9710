namespace DoctorOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class home_phone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "HomePhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "HomePhoneNumber");
        }
    }
}
