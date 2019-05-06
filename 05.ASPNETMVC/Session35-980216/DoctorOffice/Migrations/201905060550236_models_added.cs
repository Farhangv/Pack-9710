namespace DoctorOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class models_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family = c.String(),
                        NationalCode = c.String(),
                        BirthDate = c.DateTime(),
                        Gender = c.Int(),
                        StaffCode = c.String(),
                        ContractType = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OriginalFileName = c.String(),
                        Extension = c.String(),
                        Size = c.Int(nullable: false),
                        ContentType = c.String(),
                        Content = c.Binary(),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            AddColumn("dbo.AspNetUsers", "Person_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "Person_Id");
            AddForeignKey("dbo.AspNetUsers", "Person_Id", "dbo.People", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "PatientId", "dbo.People");
            DropForeignKey("dbo.AspNetUsers", "Person_Id", "dbo.People");
            DropIndex("dbo.Files", new[] { "PatientId" });
            DropIndex("dbo.AspNetUsers", new[] { "Person_Id" });
            DropColumn("dbo.AspNetUsers", "Person_Id");
            DropTable("dbo.Files");
            DropTable("dbo.People");
        }
    }
}
