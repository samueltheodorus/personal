using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;
using XYZStore.Service.CustomerAPI.Models;

namespace XYZStore.Service.CustomerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerCoupon> CustomerCoupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CustomerCoupon>().HasKey(cp => new {cp.CouponID, cp.CustomerID});
            modelBuilder.Entity<CustomerCoupon>().HasOne(c => c.Customer).WithMany(c => c.Coupons).HasForeignKey(c => c.CustomerID);

        }
    }
}
