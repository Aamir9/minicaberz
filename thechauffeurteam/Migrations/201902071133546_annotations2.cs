namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class annotations2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CabOffices", "confirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CabOffices", "confirmPassword", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
