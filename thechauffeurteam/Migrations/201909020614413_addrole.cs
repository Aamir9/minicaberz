namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrole : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.userroles",
                c => new
                    {
                        user_Id = c.Int(nullable: false),
                        role_RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.user_Id, t.role_RoleId })
                .ForeignKey("dbo.users", t => t.user_Id, cascadeDelete: true)
                .ForeignKey("dbo.roles", t => t.role_RoleId, cascadeDelete: true)
                .Index(t => t.user_Id)
                .Index(t => t.role_RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.userroles", "role_RoleId", "dbo.roles");
            DropForeignKey("dbo.userroles", "user_Id", "dbo.users");
            DropIndex("dbo.userroles", new[] { "role_RoleId" });
            DropIndex("dbo.userroles", new[] { "user_Id" });
            DropTable("dbo.userroles");
            DropTable("dbo.roles");
        }
    }
}
