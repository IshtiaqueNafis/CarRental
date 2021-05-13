using System;
using System.Data.Entity;
using System.Linq;
using CarRental.Models;

namespace CarRental
{
    public class ApplicationDbContext : DbContext
    {
        // Your context has been configured to use a 'ApplicationDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CarRental.ApplicationDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ApplicationDBContext' 
        // connection string in the application configuration file.
        public ApplicationDbContext()
            : base("name=CarRentalDataBase")
        {
        }



        public DbSet<CarRentals> CarRentals { get; set; }
        public DbSet<CarType> CarTypes { get; set; }

        
    }

   
}