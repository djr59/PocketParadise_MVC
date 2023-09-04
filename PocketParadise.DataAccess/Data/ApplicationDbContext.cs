﻿using Microsoft.EntityFrameworkCore;
using PocketParadise.Models;

namespace PocketParadise.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Halloween", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Christmas", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Valentine's Day", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Easter", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Special", DisplayOrder = 5 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Title = "Pikachu Cube", Description = "Its a cute pikachu HUH", Price = 70.00m, Quantity = 2, CategoryId = 2, ImageUrl = "" },
                new Product { Id = 2, Title = "Alolan Vulpix Dome", Description = "Latest 5G smartphone with three cameras", Price = 40.00m, Quantity = 3, CategoryId = 2, ImageUrl = "" },
                new Product { Id = 3, Title = "Vaporeon Mini Cube", Description = "Ergonomic chair with lumbar support", Price = 20.00m, Quantity = 1, CategoryId = 3, ImageUrl = "" },
                new Product { Id = 4, Title = "Eeveelutions Big Boy", Description = "Noise-cancelling over-the-ear headphones", Price = 500.00m, Quantity = 1, CategoryId = 1, ImageUrl = "" },
                new Product { Id = 5, Title = "Mitsu Charm", Description = "Waterproof smartwatch with heart rate monitor", Price = 15.00m, Quantity = 4, CategoryId = 4, ImageUrl = "" }
            );
        }
    }
}