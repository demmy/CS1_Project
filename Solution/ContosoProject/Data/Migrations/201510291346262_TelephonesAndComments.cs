namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TelephonesAndComments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        EntityType = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Author_Id = c.Int(),
                        Client_Id = c.Int(),
                        Order_Id = c.Int(),
                        Category_Id = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author_Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Order_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Telephones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Comments", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Comments", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Telephones", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Comments", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Comments", "Author_Id", "dbo.Users");
            DropIndex("dbo.Telephones", new[] { "Client_Id" });
            DropIndex("dbo.Comments", new[] { "Product_Id" });
            DropIndex("dbo.Comments", new[] { "Category_Id" });
            DropIndex("dbo.Comments", new[] { "Order_Id" });
            DropIndex("dbo.Comments", new[] { "Client_Id" });
            DropIndex("dbo.Comments", new[] { "Author_Id" });
            DropTable("dbo.Telephones");
            DropTable("dbo.Comments");
        }
    }
}
