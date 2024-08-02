using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleAPI.Models;

namespace VehicleAPI.Data.SeedData
{
    public class CarSeed : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(
                new Car { Id = 1, Color = "Red", headlightsOn = false },
                new Car { Id = 2, Color = "Blue", headlightsOn = false },
                new Car { Id = 3, Color = "Grey", headlightsOn = false },
                new Car { Id = 4, Color = "White", headlightsOn = false },
                new Car { Id = 5, Color = "Orange", headlightsOn = false });
        }
    }
}
