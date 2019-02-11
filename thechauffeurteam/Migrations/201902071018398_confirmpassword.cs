namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class confirmpassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CabOffices", "confirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CabOffices", "confirmPassword");
        }
    }
}
