using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleAPI.Models;

namespace VehicleAPI.Data.SeedData
{
    public class BoatSeed : IEntityTypeConfiguration<Boat>
    {
        public void Configure(EntityTypeBuilder<Boat> builder)
        {
            builder.HasData(
                new Boat { Id = 1, Color = "Violet" },
                new Boat { Id = 2, Color = "Brown" },
                new Boat { Id = 3, Color = "Black" },
                new Boat { Id = 4, Color = "White" });
        }
    }
}
