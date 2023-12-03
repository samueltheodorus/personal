using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace XYZStore.Services.MerchantAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchants",
                columns: table => new
                {
                    MerchantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerchantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchants", x => x.MerchantID);
                });

            migrationBuilder.InsertData(
                table: "Merchants",
                columns: new[] { "MerchantID", "MerchantAddress", "MerchantName" },
                values: new object[,]
                {
                    { 1, "XXX", "ABC" },
                    { 2, "XXX", "KIN" },
                    { 3, "XXX", "OT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Merchants");
        }
    }
}
