namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class annotations4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CabOffices", "CabOfficeFax", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "InvFax", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "RefBusinessFax", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CabOffices", "RefBusinessFax", c => c.String());
            AlterColumn("dbo.CabOffices", "InvFax", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficeFax", c => c.String());
        }
    }
}
