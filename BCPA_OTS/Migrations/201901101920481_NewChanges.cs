namespace BCPA_OTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Artists", "Show_ShowID", "dbo.Shows");
            DropForeignKey("dbo.Tickets", "Seat_SeatID", "dbo.Seats");
            DropIndex("dbo.Tickets", new[] { "Seat_SeatID" });
            DropIndex("dbo.Artists", new[] { "Show_ShowID" });
            DropColumn("dbo.Tickets", "SeatID");
            RenameColumn(table: "dbo.Tickets", name: "Seat_SeatID", newName: "SeatID");
            DropPrimaryKey("dbo.Seats");
            AddColumn("dbo.Seats", "RowLetter", c => c.String());
            AddColumn("dbo.Seats", "Show_ShowID", c => c.Int());
            AlterColumn("dbo.Tickets", "SeatID", c => c.Int(nullable: false));
            AlterColumn("dbo.Seats", "SeatID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Seats", "SeatID");
            CreateIndex("dbo.Tickets", "SeatID");
            CreateIndex("dbo.Seats", "Show_ShowID");
            AddForeignKey("dbo.Seats", "Show_ShowID", "dbo.Shows", "ShowID");
            AddForeignKey("dbo.Tickets", "SeatID", "dbo.Seats", "SeatID", cascadeDelete: true);
            DropTable("dbo.Artists");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.String(nullable: false, maxLength: 128),
                        Description = c.String(nullable: false, maxLength: 500),
                        ImageURL = c.String(nullable: false, maxLength: 255),
                        Show_ShowID = c.Int(),
                    })
                .PrimaryKey(t => t.ArtistID);
            
            DropForeignKey("dbo.Tickets", "SeatID", "dbo.Seats");
            DropForeignKey("dbo.Seats", "Show_ShowID", "dbo.Shows");
            DropIndex("dbo.Seats", new[] { "Show_ShowID" });
            DropIndex("dbo.Tickets", new[] { "SeatID" });
            DropPrimaryKey("dbo.Seats");
            AlterColumn("dbo.Seats", "SeatID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Tickets", "SeatID", c => c.String(maxLength: 128));
            DropColumn("dbo.Seats", "Show_ShowID");
            DropColumn("dbo.Seats", "RowLetter");
            AddPrimaryKey("dbo.Seats", "SeatID");
            RenameColumn(table: "dbo.Tickets", name: "SeatID", newName: "Seat_SeatID");
            AddColumn("dbo.Tickets", "SeatID", c => c.Int(nullable: false));
            CreateIndex("dbo.Artists", "Show_ShowID");
            CreateIndex("dbo.Tickets", "Seat_SeatID");
            AddForeignKey("dbo.Tickets", "Seat_SeatID", "dbo.Seats", "SeatID");
            AddForeignKey("dbo.Artists", "Show_ShowID", "dbo.Shows", "ShowID");
        }
    }
}
