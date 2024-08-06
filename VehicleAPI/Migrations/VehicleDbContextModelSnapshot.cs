﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleAPI.VehicleDb;

#nullable disable

namespace VehicleAPI.Migrations
{
    [DbContext(typeof(VehicleDbContext))]
    partial class VehicleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VehicleAPI.Models.Boat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Boats", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Violet"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Brown"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Black"
                        },
                        new
                        {
                            Id = 4,
                            Color = "White"
                        });
                });

            modelBuilder.Entity("VehicleAPI.Models.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Buses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Purple"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Yellow"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Black"
                        },
                        new
                        {
                            Id = 4,
                            Color = "Red"
                        });
                });

            modelBuilder.Entity("VehicleAPI.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("HeadlightsOn")
                        .HasColumnType("bit");

                    b.Property<int>("Wheels")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Red",
                            HeadlightsOn = false,
                            Wheels = 4
                        },
                        new
                        {
                            Id = 2,
                            Color = "Blue",
                            HeadlightsOn = false,
                            Wheels = 4
                        },
                        new
                        {
                            Id = 3,
                            Color = "Grey",
                            HeadlightsOn = false,
                            Wheels = 4
                        },
                        new
                        {
                            Id = 4,
                            Color = "White",
                            HeadlightsOn = false,
                            Wheels = 4
                        },
                        new
                        {
                            Id = 5,
                            Color = "Orange",
                            HeadlightsOn = false,
                            Wheels = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
