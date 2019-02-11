namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class annotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CabOffices", "CabofficeOwner", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficeName", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "DispachSystemName", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficePhoneNo", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficeEmail", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficeAddress", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficeCity", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficeBusinessStartDate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CabOffices", "CabOfficeBusinessStartDate", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficeCity", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficeAddress", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficeEmail", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficePhoneNo", c => c.String());
            AlterColumn("dbo.CabOffices", "DispachSystemName", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficeName", c => c.String());
            AlterColumn("dbo.CabOffices", "CabofficeOwner", c => c.String());
        }
    }
}
