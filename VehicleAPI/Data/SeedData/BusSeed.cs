using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleAPI.Models;

namespace VehicleAPI.Data.SeedData
{
    public class BusSeed : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.HasData(
                new Bus { Id = 1, Color = "Purple" },
                new Bus { Id = 2, Color = "Yellow" },
                new Bus { Id = 3, Color = "Black" },
                new Bus { Id = 4, Color = "Red" });    
        }
    }
}
