﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleAPI.Models;

namespace VehicleAPI.Data.SeedData
{
    public class CarSeed : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(
                new Car { Id = 1, Color = "Red", HeadlightsOn = false, Wheels = 4 },
                new Car { Id = 2, Color = "Blue", HeadlightsOn = false, Wheels = 4 },
                new Car { Id = 3, Color = "Grey", HeadlightsOn = false, Wheels = 4 },
                new Car { Id = 4, Color = "White", HeadlightsOn = false, Wheels = 4 },
                new Car { Id = 5, Color = "Orange", HeadlightsOn = false, Wheels = 4 });
        }
    }
}
