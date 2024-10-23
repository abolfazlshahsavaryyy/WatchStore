using Microsoft.EntityFrameworkCore;
using WatchStor.Models;
using WatchStor.Models.Enum;
using System;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Pay> pays { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data for Products
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Classic Watch",
                Brand = "Rolex",
                Price = 1500.00M,
                Gender = Gender.Male,
                WatchType = TypeWatch.classic
            },
            new Product
            {
                Id = 2,
                Name = "Elegant Watch",
                Brand = "Omega",
                Price = 2000.00M,
                Gender = Gender.Female,
                WatchType = TypeWatch.sport
            },
            new Product
            {
                Id = 3,
                Name = "Luxury Accessories",
                Brand = "Gucci",
                Price = 500.00M,
                Gender = Gender.Male,
                WatchType = TypeWatch.classic
            }
        );

        // Seed data for Orders (linked to Products)
        modelBuilder.Entity<Order>().HasData(
            new Order
            {
                Id = 1,
                WatchId = 1, // Classic Watch
                Number = 2,
                TimeOfPurchase = DateTime.Now.AddDays(-10),
                TimeOfSend = DateTime.Now.AddDays(-7)
            },
            new Order
            {
                Id = 2,
                WatchId = 2, // Elegant Watch
                Number = 1,
                TimeOfPurchase = DateTime.Now.AddDays(-5),
                TimeOfSend = DateTime.Now.AddDays(-2)
            },
            new Order
            {
                Id = 3,
                WatchId = 3, // Luxury Accessories
                Number = 3,
                TimeOfPurchase = DateTime.Now.AddDays(-3),
                TimeOfSend = DateTime.Now.AddDays(4)// Not yet sent
            }
        );
    }
}
