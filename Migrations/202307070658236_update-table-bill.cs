namespace QuanlyCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetablebill : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bill", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Bill", "Discount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Bill", "Service", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Bill", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bill", "Note");
            DropColumn("dbo.Bill", "Service");
            DropColumn("dbo.Bill", "Discount");
            DropColumn("dbo.Bill", "Price");
        }
    }
}
