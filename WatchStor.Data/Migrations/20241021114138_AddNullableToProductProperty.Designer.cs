﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WatchStor.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241021114138_AddNullableToProductProperty")]
    partial class AddNullableToProductProperty
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WatchStor.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfPurchase")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TimeOfSend")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("WatchId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WatchId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Number = 2,
                            TimeOfPurchase = new DateTime(2024, 10, 11, 15, 11, 36, 505, DateTimeKind.Local).AddTicks(774),
                            TimeOfSend = new DateTime(2024, 10, 14, 15, 11, 36, 505, DateTimeKind.Local).AddTicks(793),
                            WatchId = 1
                        },
                        new
                        {
                            Id = 2,
                            Number = 1,
                            TimeOfPurchase = new DateTime(2024, 10, 16, 15, 11, 36, 505, DateTimeKind.Local).AddTicks(798),
                            TimeOfSend = new DateTime(2024, 10, 19, 15, 11, 36, 505, DateTimeKind.Local).AddTicks(799),
                            WatchId = 2
                        },
                        new
                        {
                            Id = 3,
                            Number = 3,
                            TimeOfPurchase = new DateTime(2024, 10, 18, 15, 11, 36, 505, DateTimeKind.Local).AddTicks(800),
                            TimeOfSend = new DateTime(2024, 10, 25, 15, 11, 36, 505, DateTimeKind.Local).AddTicks(801),
                            WatchId = 3
                        });
                });

            modelBuilder.Entity("WatchStor.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("WatchType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Rolex",
                            Gender = 0,
                            Name = "Classic Watch",
                            Price = 1500.00m,
                            WatchType = 0
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Omega",
                            Gender = 1,
                            Name = "Elegant Watch",
                            Price = 2000.00m,
                            WatchType = 1
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Gucci",
                            Gender = 0,
                            Name = "Luxury Accessories",
                            Price = 500.00m,
                            WatchType = 0
                        });
                });

            modelBuilder.Entity("WatchStor.Models.Order", b =>
                {
                    b.HasOne("WatchStor.Models.Product", "Watch")
                        .WithMany()
                        .HasForeignKey("WatchId");

                    b.Navigation("Watch");
                });
#pragma warning restore 612, 618
        }
    }
}
