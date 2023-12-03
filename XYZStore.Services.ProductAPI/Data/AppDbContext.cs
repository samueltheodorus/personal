using Microsoft.EntityFrameworkCore;
using XYZStore.Services.ProductAPI.Models;

namespace XYZStore.Services.ProductAPI.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                ProductID = 1,
                ProductName = "AYAM MANIS",
                ProductPrice = 10000,
                ProductStatus = true,
                MerchantID = 1
            });

            modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                ProductID = 2,
                ProductName = "AYAM BAKAR",
                ProductPrice = 90000,
                ProductStatus = true,
                MerchantID = 1
            });

            modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                ProductID = 3,
                ProductName = "TAHU GORENG",
                ProductPrice = 10000,
                ProductStatus = true,
                MerchantID = 3
            });
        }
    }
}
