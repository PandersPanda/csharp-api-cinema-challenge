﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7159),
                            Email = "anderh2@gmail.com",
                            Name = "Anders Hagen Ottersland",
                            Phone = "1234",
                            UpdatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7159)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7161),
                            Email = "Nigel@teacher.com",
                            Name = "Nigel Teacher",
                            Phone = "90909090",
                            UpdatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7161)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7151),
                            Description = "Magic staffs goes boom",
                            Rating = "PG-13",
                            RuntimeMins = 123,
                            Title = "Harry Potter",
                            UpdatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7151)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7154),
                            Description = "Swords, Wizards and fun",
                            Rating = "PG-16",
                            RuntimeMins = 205,
                            Title = "Lord Of The Rings",
                            UpdatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7154)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7155),
                            Description = "Singing",
                            Rating = "PG-All",
                            RuntimeMins = 89,
                            Title = "Frozen",
                            UpdatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7155)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 50,
                            CreatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7165),
                            ScreenNumber = 1,
                            StartsAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7165)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 100,
                            CreatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7168),
                            ScreenNumber = 2,
                            StartsAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedAt = new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7168)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
