namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingCabOfficeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CabOffices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        CabofficeOwner = c.String(),
                        CabOfficeName = c.String(),
                        DispachSystemName = c.String(),
                        CabOfficePhoneNo = c.String(),
                        CabOfficeFax = c.String(),
                        CabOfficeEmail = c.String(),
                        CabOfficeAddress = c.String(),
                        CabOfficeCity = c.String(),
                        CabOfficePostCode = c.String(),
                        CabOfficeBusinessStartDate = c.String(),
                        CabOfficeLicenseNumber = c.String(),
                        CabOfficeBusiessType = c.String(),
                        AcceptDiractPayment = c.Boolean(nullable: false),
                        LikeAccount = c.Boolean(nullable: false),
                        NumberOfSaloon = c.Int(nullable: false),
                        NumberOfEstate = c.Int(nullable: false),
                        NumberOfMPV = c.Int(nullable: false),
                        NumberOfOtherVehicle = c.Int(nullable: false),
                        InvAddress = c.String(),
                        InvCity = c.String(),
                        InvPostCode = c.String(),
                        InvPrincipalContact = c.String(),
                        InvPhone = c.String(),
                        InvFax = c.String(),
                        InvEmail = c.String(),
                        UserFirstName = c.String(),
                        UserLastName = c.String(),
                        UserMobile = c.String(),
                        UserEmail = c.String(),
                        UserPassword = c.String(),
                        RefBusinessName = c.String(),
                        RefBusinessAddress = c.String(),
                        RefBusinessCity = c.String(),
                        RefBusinessPostCode = c.String(),
                        RefBusinessPhone = c.String(),
                        RefBusinessFax = c.String(),
                        RefBusinessEmail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CabOffices");
        }
    }
}
