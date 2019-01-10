namespace BCPA_OTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentCard : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PaymentCards", "CardType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PaymentCards", "CardType");
        }
    }
}
