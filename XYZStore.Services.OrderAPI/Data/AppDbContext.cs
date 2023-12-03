using Microsoft.EntityFrameworkCore;
using XYZStore.Services.OrderAPI.Models;

namespace XYZStore.Services.OrderAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>().HasKey(cp => new { cp.OrderID, cp.ProductID });
            modelBuilder.Entity<OrderProduct>().HasOne(c => c.Order).WithMany(c => c.Products).HasForeignKey(c => c.OrderID);

        }
    }
}
