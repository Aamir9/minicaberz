namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class annotations1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CabOffices", "UserPassword", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.CabOffices", "confirmPassword", c => c.String(nullable: true, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CabOffices", "confirmPassword", c => c.String());
            AlterColumn("dbo.CabOffices", "UserPassword", c => c.String());
        }
    }
}
