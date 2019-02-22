
using System.Data.Entity;
using thechauffeurteam.Models;
using thechauffeurteam.Models.API;

namespace thechauffeurteam.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {
            //Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<CoverageAndWaiting>()
        //                .MapToStoredProcedures();
        //}
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<PCOLicense> PCOLicenses { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
       public DbSet<Passenger> Passengers { get; set; }
        public DbSet<DistancePrice> DistancePrices { get; set; }
        public DbSet<HourlyPrice> HourlyPrices { get; set; }
        public DbSet<FixPrice> FixPrices { get; set; }
        public DbSet<PostCode> PostCodes { get; set; }

        public DbSet<Sclass> sclasses { get; set; }
        public DbSet<Eclass> eclasses { get; set; }
        public DbSet<Vclass> vclasses { get; set; }
        
        public DbSet<job> jobs { get; set; }
        public DbSet<CabOffice> CabOffices { get; set; }


        public DbSet<CoverageAndWaiting> CoverageAndWaitings { get; set; }

        //public System.Data.Entity.DbSet<thechauffeurteam.Models.ViewModel.CabOfficeVM> CabOfficeVMs { get; set; }
    }
}