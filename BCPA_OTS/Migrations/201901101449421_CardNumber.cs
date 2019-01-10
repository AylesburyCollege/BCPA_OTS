namespace BCPA_OTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CardNumber : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PaymentCards", "CardNumber", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PaymentCards", "CardNumber", c => c.String(nullable: false, maxLength: 16));
        }
    }
}
