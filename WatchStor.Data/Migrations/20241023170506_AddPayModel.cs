using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchStor.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPayModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pays", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 13, 20, 35, 4, 285, DateTimeKind.Local).AddTicks(3730), new DateTime(2024, 10, 16, 20, 35, 4, 285, DateTimeKind.Local).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 18, 20, 35, 4, 285, DateTimeKind.Local).AddTicks(3753), new DateTime(2024, 10, 21, 20, 35, 4, 285, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 20, 20, 35, 4, 285, DateTimeKind.Local).AddTicks(3779), new DateTime(2024, 10, 27, 20, 35, 4, 285, DateTimeKind.Local).AddTicks(3780) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pays");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 11, 15, 11, 36, 505, DateTimeKind.Local).AddTicks(774), new DateTime(2024, 10, 14, 15, 11, 36, 505, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 16, 15, 11, 36, 505, DateTimeKind.Local).AddTicks(798), new DateTime(2024, 10, 19, 15, 11, 36, 505, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 18, 15, 11, 36, 505, DateTimeKind.Local).AddTicks(800), new DateTime(2024, 10, 25, 15, 11, 36, 505, DateTimeKind.Local).AddTicks(801) });
        }
    }
}
