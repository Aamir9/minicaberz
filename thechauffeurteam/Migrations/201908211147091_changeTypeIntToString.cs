namespace thechauffeurteam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTypeIntToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FixPrices", "PickUp", c => c.String(nullable: false));
            AlterColumn("dbo.FixPrices", "DropOff", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FixPrices", "DropOff", c => c.Int(nullable: false));
            AlterColumn("dbo.FixPrices", "PickUp", c => c.Int(nullable: false));
        }
    }
}
