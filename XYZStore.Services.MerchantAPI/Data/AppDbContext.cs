using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using XYZStore.Services.MerchantAPI.Models;

namespace XYZStore.Services.MerchantAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Merchant> Merchants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Merchant>().HasData(
            new Merchant()
            {
                MerchantID = 1,
                MerchantName = "ABC",
                MerchantAddress = "XXX"
            });

            modelBuilder.Entity<Merchant>().HasData(
            new Merchant()
            {
                MerchantID = 2,
                MerchantName = "KIN",
                MerchantAddress = "XXX"
            });

            modelBuilder.Entity<Merchant>().HasData(
            new Merchant()
            {
                MerchantID = 3,
                MerchantName = "OT",
                MerchantAddress = "XXX"
            });
        }
    }
}
