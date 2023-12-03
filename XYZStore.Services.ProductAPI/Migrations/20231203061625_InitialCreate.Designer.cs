﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XYZStore.Services.ProductAPI.Data;

#nullable disable

namespace XYZStore.Services.ProductAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231203061625_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("XYZStore.Services.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<int>("MerchantID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ProductPrice")
                        .HasColumnType("real");

                    b.Property<bool>("ProductStatus")
                        .HasColumnType("bit");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            MerchantID = 1,
                            ProductName = "AYAM MANIS",
                            ProductPrice = 10000f,
                            ProductStatus = true
                        },
                        new
                        {
                            ProductID = 2,
                            MerchantID = 1,
                            ProductName = "AYAM BAKAR",
                            ProductPrice = 90000f,
                            ProductStatus = true
                        },
                        new
                        {
                            ProductID = 3,
                            MerchantID = 3,
                            ProductName = "TAHU GORENG",
                            ProductPrice = 10000f,
                            ProductStatus = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
