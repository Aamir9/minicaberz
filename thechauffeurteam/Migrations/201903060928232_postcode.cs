namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postcode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.jobs", "postcode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.jobs", "postcode");
        }
    }
}
