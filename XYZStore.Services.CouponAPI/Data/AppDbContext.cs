using Microsoft.EntityFrameworkCore;
using XYZStore.Services.CouponAPI.Models;

namespace XYZStore.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coupon>().HasData(new Coupon()
            {
                CouponID = 1,
                CouponCode = "OJOL",
                ExpiredDate = DateTime.Now,
                CouponStatus = true,
                CouponValue = 100000,
                IsPercentage = false
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon()
            {
                CouponID = 2,
                CouponCode = "GRATISMAKAN",
                ExpiredDate = DateTime.Now,
                CouponStatus = false,
                CouponValue = 30000,
                IsPercentage = false
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon()
            {
                CouponID = 3,
                CouponCode = "MAKANTERUS",
                ExpiredDate = DateTime.Now,
                CouponStatus = false,
                CouponValue = 10,
                IsPercentage = true
            });
        }
    }
}
