namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletetable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.userroles", "user_Id", "dbo.users");
            DropForeignKey("dbo.userroles", "role_RoleId", "dbo.roles");
            DropIndex("dbo.userroles", new[] { "user_Id" });
            DropIndex("dbo.userroles", new[] { "role_RoleId" });
            DropTable("dbo.roles");
            DropTable("dbo.users");
            DropTable("dbo.userroles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.userroles",
                c => new
                    {
                        user_Id = c.Int(nullable: false),
                        role_RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.user_Id, t.role_RoleId });
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserFirstName = c.String(nullable: false),
                        UserLastName = c.String(nullable: false),
                        UserEmail = c.String(nullable: false),
                        UserPhNo = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateIndex("dbo.userroles", "role_RoleId");
            CreateIndex("dbo.userroles", "user_Id");
            AddForeignKey("dbo.userroles", "role_RoleId", "dbo.roles", "RoleId", cascadeDelete: true);
            AddForeignKey("dbo.userroles", "user_Id", "dbo.users", "Id", cascadeDelete: true);
        }
    }
}
