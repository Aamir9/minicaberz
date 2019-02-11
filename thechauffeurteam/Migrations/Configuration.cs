namespace thechauffeurteam.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using thechauffeurteam.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<thechauffeurteam.DAL.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(thechauffeurteam.DAL.MyContext context)
        {
            
           
        }
    }
}
