namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add13 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoverageAndWaitings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        postCode = c.String(),
                        waiting = c.String(),
                        CabOfficeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CabOffices", t => t.CabOfficeId, cascadeDelete: true)
                .Index(t => t.CabOfficeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CoverageAndWaitings", "CabOfficeId", "dbo.CabOffices");
            DropIndex("dbo.CoverageAndWaitings", new[] { "CabOfficeId" });
            DropTable("dbo.CoverageAndWaitings");
        }
    }
}
