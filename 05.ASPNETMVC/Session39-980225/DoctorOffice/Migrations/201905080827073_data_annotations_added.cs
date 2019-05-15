namespace DoctorOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data_annotations_added : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Family", c => c.String(maxLength: 60));
            AlterColumn("dbo.People", "NationalCode", c => c.String(maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "NationalCode", c => c.String());
            AlterColumn("dbo.People", "Family", c => c.String());
        }
    }
}
