namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class annotations3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CabOffices", "CabOfficeLicenseNumber", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "InvAddress", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "InvCity", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "InvPrincipalContact", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "InvPhone", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "InvEmail", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "UserFirstName", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "UserLastName", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "UserMobile", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "UserEmail", c => c.String(nullable: true));
            AlterColumn("dbo.CabOffices", "RefBusinessName", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "RefBusinessAddress", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "RefBusinessCity", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "RefBusinessPhone", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "RefBusinessEmail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CabOffices", "RefBusinessEmail", c => c.String());
            AlterColumn("dbo.CabOffices", "RefBusinessPhone", c => c.String());
            AlterColumn("dbo.CabOffices", "RefBusinessCity", c => c.String());
            AlterColumn("dbo.CabOffices", "RefBusinessAddress", c => c.String());
            AlterColumn("dbo.CabOffices", "RefBusinessName", c => c.String());
            AlterColumn("dbo.CabOffices", "UserEmail", c => c.String());
            AlterColumn("dbo.CabOffices", "UserMobile", c => c.String());
            AlterColumn("dbo.CabOffices", "UserLastName", c => c.String());
            AlterColumn("dbo.CabOffices", "UserFirstName", c => c.String());
            AlterColumn("dbo.CabOffices", "InvEmail", c => c.String());
            AlterColumn("dbo.CabOffices", "InvPhone", c => c.String());
            AlterColumn("dbo.CabOffices", "InvPrincipalContact", c => c.String());
            AlterColumn("dbo.CabOffices", "InvCity", c => c.String());
            AlterColumn("dbo.CabOffices", "InvAddress", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficeLicenseNumber", c => c.String());
        }
    }
}
