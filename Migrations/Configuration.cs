using CarRental.Models;

namespace CarRental.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
           context.CarTypes.AddOrUpdate(c=>c.Id,
               new CarType() { Id = 1,Name = "BMW"},
               new CarType() { Id = 2,Name = "Toyota"},
               new CarType() { Id = 3,Name = "Aura"},
               new CarType() { Id = 4,Name = "NISSAN"}
               );
        }
    }
}
