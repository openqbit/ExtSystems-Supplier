namespace OpenQbit.ExternalSupplier.Dal.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class supplier_v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        customerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.customerId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        Item_ItemId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Item", t => t.Item_ItemId)
                .Index(t => t.CustomerId)
                .Index(t => t.Item_ItemId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Item", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        Quntity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId);
            
            CreateTable(
                "dbo.ItemPrice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Item", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.ItemStock",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Item", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemStock", "ItemId", "dbo.Item");
            DropForeignKey("dbo.ItemPrice", "ItemId", "dbo.Item");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Order");
            DropForeignKey("dbo.OrderDetails", "ItemId", "dbo.Item");
            DropForeignKey("dbo.Order", "Item_ItemId", "dbo.Item");
            DropForeignKey("dbo.Order", "CustomerId", "dbo.Customer");
            DropIndex("dbo.ItemStock", new[] { "ItemId" });
            DropIndex("dbo.ItemPrice", new[] { "ItemId" });
            DropIndex("dbo.OrderDetails", new[] { "ItemId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Order", new[] { "Item_ItemId" });
            DropIndex("dbo.Order", new[] { "CustomerId" });
            DropTable("dbo.ItemStock");
            DropTable("dbo.ItemPrice");
            DropTable("dbo.Item");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Order");
            DropTable("dbo.Customer");
        }
    }
}
