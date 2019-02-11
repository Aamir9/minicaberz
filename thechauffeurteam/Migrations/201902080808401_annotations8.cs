namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class annotations8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CabOffices", "CabofficeOwner", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficeName", c => c.String());
            AlterColumn("dbo.CabOffices", "DispachSystemName", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficePhoneNo", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficeFax", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficeEmail", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficeAddress", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficeCity", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficeBusinessStartDate", c => c.String());
            AlterColumn("dbo.CabOffices", "CabOfficeLicenseNumber", c => c.String());
            AlterColumn("dbo.CabOffices", "InvAddress", c => c.String());
            AlterColumn("dbo.CabOffices", "InvCity", c => c.String());
            AlterColumn("dbo.CabOffices", "InvPrincipalContact", c => c.String());
            AlterColumn("dbo.CabOffices", "InvPhone", c => c.String());
            AlterColumn("dbo.CabOffices", "InvFax", c => c.String());
            AlterColumn("dbo.CabOffices", "InvEmail", c => c.String());
            AlterColumn("dbo.CabOffices", "UserFirstName", c => c.String());
            AlterColumn("dbo.CabOffices", "UserLastName", c => c.String());
            AlterColumn("dbo.CabOffices", "UserMobile", c => c.String());
            AlterColumn("dbo.CabOffices", "UserEmail", c => c.String());
            AlterColumn("dbo.CabOffices", "UserPassword", c => c.String());
            AlterColumn("dbo.CabOffices", "RefBusinessName", c => c.String());
            AlterColumn("dbo.CabOffices", "RefBusinessAddress", c => c.String());
            AlterColumn("dbo.CabOffices", "RefBusinessCity", c => c.String());
            AlterColumn("dbo.CabOffices", "RefBusinessPhone", c => c.String());
            AlterColumn("dbo.CabOffices", "RefBusinessFax", c => c.String());
            AlterColumn("dbo.CabOffices", "RefBusinessEmail", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CabOffices", "RefBusinessEmail", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "RefBusinessFax", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "RefBusinessPhone", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "RefBusinessCity", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "RefBusinessAddress", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "RefBusinessName", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "UserPassword", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.CabOffices", "UserEmail", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "UserMobile", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "UserLastName", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "UserFirstName", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "InvEmail", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "InvFax", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "InvPhone", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "InvPrincipalContact", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "InvCity", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "InvAddress", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficeLicenseNumber", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficeBusinessStartDate", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficeCity", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficeAddress", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficeEmail", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficeFax", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficePhoneNo", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "DispachSystemName", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabOfficeName", c => c.String(nullable: false));
            AlterColumn("dbo.CabOffices", "CabofficeOwner", c => c.String(nullable: false));
        }
    }
}
