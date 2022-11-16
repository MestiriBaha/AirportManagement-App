using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManagement.Domain;

namespace AirportManagement.Database
{
    public class MainDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-HJ07J7P; Initial Catalog=MainDB ;Trusted_Connection=true;Encrypt = false ");
            base.OnConfiguring(optionsBuilder);
        }
        //EntityFramework does not support Date only type !! niveau bas !! 
       
    
    public DbSet<Flight> Flights { get; set; } = null!;
    public DbSet<Passenger> Passengers { get; set; } = null!;
    public DbSet<Traveller> Travellers { get; set; } = null!;
    public DbSet<Staff> Workers { get; set; } = null!;
    public DbSet<Plane> Planes { get; set; } = null!;

}
}

