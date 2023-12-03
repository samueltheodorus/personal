using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace XYZStore.Services.CouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCouponToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    CouponID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CouponStatus = table.Column<bool>(type: "bit", nullable: false),
                    CouponValue = table.Column<double>(type: "float", nullable: false),
                    IsPercentage = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.CouponID);
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponID", "CouponCode", "CouponStatus", "CouponValue", "ExpiredDate", "IsPercentage" },
                values: new object[,]
                {
                    { 1, "OJOL", true, 100000.0, new DateTime(2023, 12, 3, 9, 27, 37, 607, DateTimeKind.Local).AddTicks(9981), false },
                    { 2, "GRATISMAKAN", false, 30000.0, new DateTime(2023, 12, 3, 9, 27, 37, 608, DateTimeKind.Local).AddTicks(44), false },
                    { 3, "MAKANTERUS", false, 10.0, new DateTime(2023, 12, 3, 9, 27, 37, 608, DateTimeKind.Local).AddTicks(69), true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupons");
        }
    }
}
