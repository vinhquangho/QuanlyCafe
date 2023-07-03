namespace QuanlyCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        DislayName = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BillInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BillId = c.Int(nullable: false),
                        FoodId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bill", t => t.BillId, cascadeDelete: true)
                .ForeignKey("dbo.Food", t => t.FoodId, cascadeDelete: true)
                .Index(t => t.BillId)
                .Index(t => t.FoodId);
            
            CreateTable(
                "dbo.Bill",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateIn = c.DateTime(nullable: false),
                        DateOut = c.DateTime(nullable: false),
                        TableId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Table", t => t.TableId, cascadeDelete: true)
                .Index(t => t.TableId);
            
            CreateTable(
                "dbo.Table",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Food",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreationTime = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BillInfo", "FoodId", "dbo.Food");
            DropForeignKey("dbo.Food", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.BillInfo", "BillId", "dbo.Bill");
            DropForeignKey("dbo.Bill", "TableId", "dbo.Table");
            DropIndex("dbo.Food", new[] { "CategoryId" });
            DropIndex("dbo.Bill", new[] { "TableId" });
            DropIndex("dbo.BillInfo", new[] { "FoodId" });
            DropIndex("dbo.BillInfo", new[] { "BillId" });
            DropTable("dbo.Category");
            DropTable("dbo.Food");
            DropTable("dbo.Table");
            DropTable("dbo.Bill");
            DropTable("dbo.BillInfo");
            DropTable("dbo.Account");
        }
    }
}
