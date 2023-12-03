using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace XYZStore.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<float>(type: "real", nullable: false),
                    ProductStatus = table.Column<bool>(type: "bit", nullable: false),
                    MerchantID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "MerchantID", "ProductName", "ProductPrice", "ProductStatus" },
                values: new object[,]
                {
                    { 1, 1, "AYAM MANIS", 10000f, true },
                    { 2, 1, "AYAM BAKAR", 90000f, true },
                    { 3, 3, "TAHU GORENG", 10000f, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
