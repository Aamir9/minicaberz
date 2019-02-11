namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add10 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Passengers", "tests");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Passengers", "tests", c => c.String());
        }
    }
}
