using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PocketParadise.Models;

namespace PocketParadise.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> applicationUsers { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }


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
                new Product { Id = 1, Title = "Pikachu Cube", Description = "Its a cute pikachu HUH", Price = 70.00d, Quantity = 2, CategoryId = 2, ImageUrl = "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" },
                new Product { Id = 2, Title = "Alolan Vulpix Dome", Description = "Latest 5G smartphone with three cameras", Price = 40.00d, Quantity = 3, CategoryId = 2, ImageUrl = "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" },
                new Product { Id = 3, Title = "Vaporeon Mini Cube", Description = "Ergonomic chair with lumbar support", Price = 20.00d, Quantity = 1, CategoryId = 3, ImageUrl = "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" },
                new Product { Id = 4, Title = "Eeveelutions Big Boy", Description = "Noise-cancelling over-the-ear headphones", Price = 500.00d, Quantity = 1, CategoryId = 1, ImageUrl = "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" },
                new Product { Id = 5, Title = "Mitsu Charm", Description = "Waterproof smartwatch with heart rate monitor", Price = 15.00d, Quantity = 4, CategoryId = 4, ImageUrl = "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" }
            );
        }
    }
}
