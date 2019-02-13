namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add11 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.CabOfficeVMs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CabOfficeVMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        CabofficeOwner = c.String(nullable: false),
                        CabOfficeName = c.String(nullable: false),
                        DispachSystemName = c.String(nullable: false),
                        CabOfficePhoneNo = c.String(nullable: false),
                        CabOfficeFax = c.String(nullable: false),
                        CabOfficeEmail = c.String(nullable: false),
                        CabOfficeAddress = c.String(nullable: false),
                        CabOfficeCity = c.String(nullable: false),
                        CabOfficePostCode = c.String(nullable: false),
                        CabOfficeBusinessStartDate = c.String(nullable: false),
                        CabOfficeLicenseNumber = c.String(nullable: false),
                        CabOfficeBusiessType = c.String(),
                        AcceptDiractPayment = c.Boolean(nullable: false),
                        LikeAccount = c.Boolean(nullable: false),
                        NumberOfSaloon = c.Int(nullable: false),
                        NumberOfEstate = c.Int(nullable: false),
                        NumberOfMPV = c.Int(nullable: false),
                        NumberOfOtherVehicle = c.Int(nullable: false),
                        InvAddress = c.String(nullable: false),
                        InvCity = c.String(nullable: false),
                        InvPostCode = c.String(),
                        InvPrincipalContact = c.String(nullable: false),
                        InvPhone = c.String(nullable: false),
                        InvFax = c.String(nullable: false),
                        InvEmail = c.String(nullable: false),
                        UserFirstName = c.String(nullable: false),
                        UserLastName = c.String(nullable: false),
                        UserMobile = c.String(nullable: false),
                        UserEmail = c.String(nullable: false),
                        UserPassword = c.String(nullable: false, maxLength: 255),
                        confirmPassword = c.String(nullable: false),
                        RefBusinessName = c.String(nullable: false),
                        RefBusinessAddress = c.String(nullable: false),
                        RefBusinessCity = c.String(nullable: false),
                        RefBusinessPostCode = c.String(),
                        RefBusinessPhone = c.String(nullable: false),
                        RefBusinessFax = c.String(nullable: false),
                        RefBusinessEmail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
