namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringToInteger : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CoverageAndWaitings", "waiting", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CoverageAndWaitings", "waiting", c => c.String());
        }
    }
}
