namespace BCPA_OTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 500),
                        ImageURL = c.String(nullable: false, maxLength: 255),
                        Event_EventID = c.Int(),
                    })
                .PrimaryKey(t => t.ArtistID)
                .ForeignKey("dbo.Events", t => t.Event_EventID)
                .Index(t => t.Event_EventID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        ImageURL = c.String(nullable: false, maxLength: 255),
                        VideoURL = c.String(nullable: false, maxLength: 255),
                        Description = c.String(nullable: false, maxLength: 500),
                        IsShow = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffID = c.Int(nullable: false),
                        Department = c.Int(nullable: false),
                        JobRole = c.Int(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.StaffID)
                .ForeignKey("dbo.People", t => t.StaffID)
                .Index(t => t.StaffID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "StaffID", "dbo.People");
            DropForeignKey("dbo.Artists", "Event_EventID", "dbo.Events");
            DropIndex("dbo.Staffs", new[] { "StaffID" });
            DropIndex("dbo.Artists", new[] { "Event_EventID" });
            DropTable("dbo.Staffs");
            DropTable("dbo.Events");
            DropTable("dbo.Artists");
        }
    }
}
