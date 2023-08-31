using Microsoft.EntityFrameworkCore;
using PocketParadise.Models;

namespace PocketParadise.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

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

        }
    }
}
