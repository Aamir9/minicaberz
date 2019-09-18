namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addChaffeurtable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChauffeurPrices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MileFrom = c.Int(nullable: false),
                        MileTo = c.Int(nullable: false),
                        SclassFirstMile = c.Single(nullable: false),
                        SclassPerMile = c.Single(nullable: false),
                        VclassFirstMile = c.Single(nullable: false),
                        VclassPerMile = c.Single(nullable: false),
                        EclassFirstMile = c.Single(nullable: false),
                        EclassPerMile = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChauffeurPrices");
        }
    }
}
