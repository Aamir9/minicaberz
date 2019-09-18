namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMoreCarForhours : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HourlyPrices", "SPerHour", c => c.Single(nullable: false));
            AddColumn("dbo.HourlyPrices", "EPerHour", c => c.Single(nullable: false));
            AddColumn("dbo.HourlyPrices", "MPerHour", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HourlyPrices", "MPerHour");
            DropColumn("dbo.HourlyPrices", "EPerHour");
            DropColumn("dbo.HourlyPrices", "SPerHour");
        }
    }
}
