namespace BCPA_OTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false),
                        House = c.String(nullable: false, maxLength: 20),
                        Street = c.String(nullable: false, maxLength: 30),
                        Town = c.String(maxLength: 30),
                        Postcode = c.String(nullable: false, maxLength: 8),
                        County = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.People", t => t.AddressID)
                .Index(t => t.AddressID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 100),
                        HomePhoneNumber = c.String(maxLength: 16),
                        MobilePhoneNumber = c.String(maxLength: 16),
                        DateOfBirth = c.DateTime(nullable: false),
                        PaymentCardID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.PaymentCards",
                c => new
                    {
                        PaymentCardID = c.Int(nullable: false),
                        HolderName = c.String(nullable: false, maxLength: 20),
                        CardNumber = c.String(nullable: false, maxLength: 16),
                        ExpiryMonth = c.Int(nullable: false),
                        ExpiryYear = c.Int(nullable: false),
                        SecurityNumber = c.String(nullable: false, maxLength: 3),
                    })
                .PrimaryKey(t => t.PaymentCardID)
                .ForeignKey("dbo.People", t => t.PaymentCardID)
                .Index(t => t.PaymentCardID);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        PurchaseID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        EmailSent = c.Boolean(nullable: false),
                        DateTicketSent = c.DateTime(nullable: false),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseID)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketID = c.Int(nullable: false, identity: true),
                        PurchaseDate = c.DateTime(nullable: false),
                        Event = c.Boolean(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SeatID = c.Int(nullable: false),
                        ShowID = c.Int(nullable: false),
                        Seat_SeatID = c.String(maxLength: 128),
                        Purchase_PurchaseID = c.Int(),
                    })
                .PrimaryKey(t => t.TicketID)
                .ForeignKey("dbo.Seats", t => t.Seat_SeatID)
                .ForeignKey("dbo.Shows", t => t.ShowID, cascadeDelete: true)
                .ForeignKey("dbo.Purchases", t => t.Purchase_PurchaseID)
                .Index(t => t.ShowID)
                .Index(t => t.Seat_SeatID)
                .Index(t => t.Purchase_PurchaseID);
            
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        SeatID = c.String(nullable: false, maxLength: 128),
                        Type = c.String(nullable: false, maxLength: 10),
                        AisleSeat = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SeatID);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        ShowID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 500),
                        ImageURL = c.String(nullable: false, maxLength: 255),
                        VideoURL = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ShowID);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.String(nullable: false, maxLength: 128),
                        Description = c.String(nullable: false, maxLength: 500),
                        ImageURL = c.String(nullable: false, maxLength: 255),
                        Show_ShowID = c.Int(),
                    })
                .PrimaryKey(t => t.ArtistID)
                .ForeignKey("dbo.Shows", t => t.Show_ShowID)
                .Index(t => t.Show_ShowID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Purchase_PurchaseID", "dbo.Purchases");
            DropForeignKey("dbo.Tickets", "ShowID", "dbo.Shows");
            DropForeignKey("dbo.Artists", "Show_ShowID", "dbo.Shows");
            DropForeignKey("dbo.Tickets", "Seat_SeatID", "dbo.Seats");
            DropForeignKey("dbo.Purchases", "PersonID", "dbo.People");
            DropForeignKey("dbo.Addresses", "AddressID", "dbo.People");
            DropForeignKey("dbo.PaymentCards", "PaymentCardID", "dbo.People");
            DropIndex("dbo.Artists", new[] { "Show_ShowID" });
            DropIndex("dbo.Tickets", new[] { "Purchase_PurchaseID" });
            DropIndex("dbo.Tickets", new[] { "Seat_SeatID" });
            DropIndex("dbo.Tickets", new[] { "ShowID" });
            DropIndex("dbo.Purchases", new[] { "PersonID" });
            DropIndex("dbo.PaymentCards", new[] { "PaymentCardID" });
            DropIndex("dbo.Addresses", new[] { "AddressID" });
            DropTable("dbo.Artists");
            DropTable("dbo.Shows");
            DropTable("dbo.Seats");
            DropTable("dbo.Tickets");
            DropTable("dbo.Purchases");
            DropTable("dbo.PaymentCards");
            DropTable("dbo.People");
            DropTable("dbo.Addresses");
        }
    }
}
