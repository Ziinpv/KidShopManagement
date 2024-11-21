namespace QuanLyShopQuanAoTreEm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quantity = c.String(),
                        ProductCategoryID = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.ProductCategoryID, cascadeDelete: true)
                .Index(t => t.ProductCategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductCategoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "ProductCategoryID" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
