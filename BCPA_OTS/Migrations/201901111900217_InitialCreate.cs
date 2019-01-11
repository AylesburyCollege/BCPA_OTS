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
                        Postcode = c.String(nullable: false, maxLength: 10),
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
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 100),
                        HomePhoneNumber = c.String(maxLength: 20),
                        MobilePhoneNumber = c.String(maxLength: 20),
                        DateOfBirth = c.DateTime(nullable: false),
                        PaymentCardID = c.Int(nullable: false),
                        AddressID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.PaymentCards",
                c => new
                    {
                        PaymentCardID = c.Int(nullable: false),
                        CardType = c.Int(nullable: false),
                        HolderName = c.String(nullable: false, maxLength: 20),
                        CardNumber = c.String(nullable: false, maxLength: 20),
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
                        PurchaseDate = c.DateTime(nullable: false),
                        EmailSent = c.Boolean(nullable: false),
                        DateTicketSent = c.DateTime(nullable: false),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseID)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        SeatID = c.Int(nullable: false, identity: true),
                        RowLetter = c.String(),
                        SeatNo = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        AisleSeat = c.Boolean(nullable: false),
                        Ticket = c.Int(nullable: false),
                        ShowID = c.Int(nullable: false),
                        PurchaseID = c.Int(),
                        AgentID = c.Int(),
                    })
                .PrimaryKey(t => t.SeatID)
                .ForeignKey("dbo.Agents", t => t.AgentID)
                .ForeignKey("dbo.Purchases", t => t.PurchaseID)
                .ForeignKey("dbo.Shows", t => t.ShowID, cascadeDelete: true)
                .Index(t => t.ShowID)
                .Index(t => t.PurchaseID)
                .Index(t => t.AgentID);
            
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        AgentID = c.Int(nullable: false),
                        StartRow = c.Int(nullable: false),
                        EndRow = c.Int(nullable: false),
                        ContractStartDate = c.DateTime(nullable: false),
                        ContractEndDate = c.DateTime(nullable: false),
                        Comission = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AgentID)
                .ForeignKey("dbo.People", t => t.AgentID)
                .Index(t => t.AgentID);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        ShowID = c.Int(nullable: false, identity: true),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                        IntervalTime = c.DateTime(nullable: false),
                        HasTickets = c.Boolean(nullable: false),
                        PromotionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShowID)
                .ForeignKey("dbo.Promotions", t => t.PromotionID, cascadeDelete: true)
                .Index(t => t.PromotionID);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        PromotionID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        AdultDiscount = c.Int(nullable: false),
                        StudentDiscount = c.Int(nullable: false),
                        ChildDiscount = c.Int(nullable: false),
                        SeniorDiscount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PromotionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "AddressID", "dbo.People");
            DropForeignKey("dbo.Seats", "ShowID", "dbo.Shows");
            DropForeignKey("dbo.Shows", "PromotionID", "dbo.Promotions");
            DropForeignKey("dbo.Seats", "PurchaseID", "dbo.Purchases");
            DropForeignKey("dbo.Seats", "AgentID", "dbo.Agents");
            DropForeignKey("dbo.Agents", "AgentID", "dbo.People");
            DropForeignKey("dbo.Purchases", "PersonID", "dbo.People");
            DropForeignKey("dbo.PaymentCards", "PaymentCardID", "dbo.People");
            DropIndex("dbo.Shows", new[] { "PromotionID" });
            DropIndex("dbo.Agents", new[] { "AgentID" });
            DropIndex("dbo.Seats", new[] { "AgentID" });
            DropIndex("dbo.Seats", new[] { "PurchaseID" });
            DropIndex("dbo.Seats", new[] { "ShowID" });
            DropIndex("dbo.Purchases", new[] { "PersonID" });
            DropIndex("dbo.PaymentCards", new[] { "PaymentCardID" });
            DropIndex("dbo.Addresses", new[] { "AddressID" });
            DropTable("dbo.Promotions");
            DropTable("dbo.Shows");
            DropTable("dbo.Agents");
            DropTable("dbo.Seats");
            DropTable("dbo.Purchases");
            DropTable("dbo.PaymentCards");
            DropTable("dbo.People");
            DropTable("dbo.Addresses");
        }
    }
}
