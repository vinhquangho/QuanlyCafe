namespace QuanlyCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdata1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AreaTable", "CreationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.AreaTable", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AreaTable", "Status");
            DropColumn("dbo.AreaTable", "CreationTime");
        }
    }
}
