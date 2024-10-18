using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WatchStor.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    WatchType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WatchId = table.Column<int>(type: "int", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    TimeOfPurchase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOfSend = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Products_WatchId",
                        column: x => x.WatchId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Number", "TimeOfPurchase", "TimeOfSend", "WatchId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 10, 8, 14, 0, 15, 311, DateTimeKind.Local).AddTicks(9202), new DateTime(2024, 10, 11, 14, 0, 15, 311, DateTimeKind.Local).AddTicks(9217), null },
                    { 2, 1, new DateTime(2024, 10, 13, 14, 0, 15, 311, DateTimeKind.Local).AddTicks(9220), new DateTime(2024, 10, 16, 14, 0, 15, 311, DateTimeKind.Local).AddTicks(9221), null },
                    { 3, 3, new DateTime(2024, 10, 15, 14, 0, 15, 311, DateTimeKind.Local).AddTicks(9222), new DateTime(2024, 10, 22, 14, 0, 15, 311, DateTimeKind.Local).AddTicks(9222), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Gender", "Name", "Price", "WatchType" },
                values: new object[,]
                {
                    { 1, "Rolex", 0, "Classic Watch", 1500.00m, 0 },
                    { 2, "Omega", 1, "Elegant Watch", 2000.00m, 1 },
                    { 3, "Gucci", 0, "Luxury Accessories", 500.00m, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WatchId",
                table: "Orders",
                column: "WatchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
