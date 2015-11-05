namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RolePermission : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Permissions", "Role_Id", "dbo.Roles");
            DropIndex("dbo.Permissions", new[] { "Role_Id" });
            CreateTable(
                "dbo.PermissionRoles",
                c => new
                    {
                        Permission_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Permission_Id, t.Role_Id })
                .ForeignKey("dbo.Permissions", t => t.Permission_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.Permission_Id)
                .Index(t => t.Role_Id);
            
            DropColumn("dbo.Permissions", "Role_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Permissions", "Role_Id", c => c.Int());
            DropForeignKey("dbo.PermissionRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.PermissionRoles", "Permission_Id", "dbo.Permissions");
            DropIndex("dbo.PermissionRoles", new[] { "Role_Id" });
            DropIndex("dbo.PermissionRoles", new[] { "Permission_Id" });
            DropTable("dbo.PermissionRoles");
            CreateIndex("dbo.Permissions", "Role_Id");
            AddForeignKey("dbo.Permissions", "Role_Id", "dbo.Roles", "Id");
        }
    }
}
