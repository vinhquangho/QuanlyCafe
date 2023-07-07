namespace QuanlyCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetablebilldateout : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bill", "DateOut", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bill", "DateOut", c => c.DateTime(nullable: false));
        }
    }
}
