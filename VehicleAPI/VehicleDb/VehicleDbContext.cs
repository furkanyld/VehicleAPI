using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using VehicleAPI.Models;
using VehicleAPI.Data.SeedData;
using VehicleAPI.Data.Configurations;

namespace VehicleAPI.VehicleDb
{
    public class VehicleDbContext :DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarConfiguration());
            modelBuilder.ApplyConfiguration(new CarSeed());
            modelBuilder.ApplyConfiguration(new BoatConfiguration());
            modelBuilder.ApplyConfiguration(new BoatSeed());
            modelBuilder.ApplyConfiguration(new BusConfiguration());
            modelBuilder.ApplyConfiguration(new BusSeed());
        }
    }
}
