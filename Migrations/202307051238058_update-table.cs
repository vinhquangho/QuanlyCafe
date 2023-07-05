namespace QuanlyCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bill", "AccountId", c => c.Int(nullable: false));
            AddColumn("dbo.Table", "AreaTableId", c => c.Int(nullable: false));
            CreateIndex("dbo.Bill", "AccountId");
            CreateIndex("dbo.Table", "AreaTableId");
            AddForeignKey("dbo.Bill", "AccountId", "dbo.Account", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Table", "AreaTableId", "dbo.AreaTable", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Table", "AreaTableId", "dbo.AreaTable");
            DropForeignKey("dbo.Bill", "AccountId", "dbo.Account");
            DropIndex("dbo.Table", new[] { "AreaTableId" });
            DropIndex("dbo.Bill", new[] { "AccountId" });
            DropColumn("dbo.Table", "AreaTableId");
            DropColumn("dbo.Bill", "AccountId");
        }
    }
}
