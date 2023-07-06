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
                "dbo.Bill",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateIn = c.DateTime(nullable: false),
                        DateOut = c.DateTime(nullable: false),
                        TableId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AccountId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Account", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Table", t => t.TableId, cascadeDelete: true)
                .Index(t => t.TableId)
                .Index(t => t.AccountId);
            
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
                "dbo.Table",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        AreaTableId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AreaTable", t => t.AreaTableId, cascadeDelete: true)
                .Index(t => t.AreaTableId);
            
            CreateTable(
                "dbo.AreaTable",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            DropForeignKey("dbo.Food", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.Table", "AreaTableId", "dbo.AreaTable");
            DropForeignKey("dbo.Bill", "TableId", "dbo.Table");
            DropForeignKey("dbo.BillInfo", "FoodId", "dbo.Food");
            DropForeignKey("dbo.BillInfo", "BillId", "dbo.Bill");
            DropForeignKey("dbo.Bill", "AccountId", "dbo.Account");
            DropIndex("dbo.Table", new[] { "AreaTableId" });
            DropIndex("dbo.Food", new[] { "CategoryId" });
            DropIndex("dbo.BillInfo", new[] { "FoodId" });
            DropIndex("dbo.BillInfo", new[] { "BillId" });
            DropIndex("dbo.Bill", new[] { "AccountId" });
            DropIndex("dbo.Bill", new[] { "TableId" });
            DropTable("dbo.Category");
            DropTable("dbo.AreaTable");
            DropTable("dbo.Table");
            DropTable("dbo.Food");
            DropTable("dbo.BillInfo");
            DropTable("dbo.Bill");
            DropTable("dbo.Account");
        }
    }
}
