namespace Slon.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Img = c.String(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        ParentCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.ParentCategoryId)
                .Index(t => t.ParentCategoryId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false),
                        Img = c.String(nullable: false),
                        Price = c.Decimal(precision: 18, scale: 2),
                        IsAvailable = c.Boolean(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        DimensionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.ItemOrders",
                c => new
                    {
                        ItemId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        SizeId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        Count = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.ItemId, t.OrderId })
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        CourierId = c.Int(),
                        DateCreated = c.DateTime(nullable: false),
                        DateStatusChanged = c.DateTime(nullable: false),
                        DateClosed = c.DateTime(),
                        Notes = c.String(),
                        InitialPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExtraPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeliveryPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentSelectionId = c.Int(),
                        IsPayed = c.Boolean(nullable: false),
                        IsClosed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CourierId)
                .ForeignKey("dbo.Users", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.CourierId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        City = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        Img = c.Binary(),
                        Email = c.String(nullable: false, maxLength: 50),
                        IsEmailVerified = c.Boolean(nullable: false),
                        GenderId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemSizes",
                c => new
                    {
                        ItemId = c.Int(nullable: false),
                        ItemSizeId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.ItemId, t.ItemSizeId })
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.ItemTypes",
                c => new
                    {
                        ItemId = c.Int(nullable: false),
                        ItemTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ItemId, t.ItemTypeId })
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "ParentCategoryId", "dbo.Categories");
            DropForeignKey("dbo.ItemTypes", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ItemSizes", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ItemOrders", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Users");
            DropForeignKey("dbo.Orders", "CourierId", "dbo.Users");
            DropForeignKey("dbo.ItemOrders", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Items", "CategoryId", "dbo.Categories");
            DropIndex("dbo.ItemTypes", new[] { "ItemId" });
            DropIndex("dbo.ItemSizes", new[] { "ItemId" });
            DropIndex("dbo.Orders", new[] { "CourierId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.ItemOrders", new[] { "OrderId" });
            DropIndex("dbo.ItemOrders", new[] { "ItemId" });
            DropIndex("dbo.Items", new[] { "CategoryId" });
            DropIndex("dbo.Categories", new[] { "ParentCategoryId" });
            DropTable("dbo.ItemTypes");
            DropTable("dbo.ItemSizes");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.ItemOrders");
            DropTable("dbo.Items");
            DropTable("dbo.Categories");
        }
    }
}
