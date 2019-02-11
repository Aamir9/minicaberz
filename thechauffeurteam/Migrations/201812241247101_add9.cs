namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Passengers", "tests", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Passengers", "tests");
        }
    }
}
