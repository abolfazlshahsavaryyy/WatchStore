using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchStor.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewProPertyDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Time",
                table: "pays",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 13, 21, 5, 57, 209, DateTimeKind.Local).AddTicks(2032), new DateTime(2024, 10, 16, 21, 5, 57, 209, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 18, 21, 5, 57, 209, DateTimeKind.Local).AddTicks(2055), new DateTime(2024, 10, 21, 21, 5, 57, 209, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 20, 21, 5, 57, 209, DateTimeKind.Local).AddTicks(2057), new DateTime(2024, 10, 27, 21, 5, 57, 209, DateTimeKind.Local).AddTicks(2058) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "pays",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 13, 20, 37, 59, 779, DateTimeKind.Local).AddTicks(1476), new DateTime(2024, 10, 16, 20, 37, 59, 779, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 18, 20, 37, 59, 779, DateTimeKind.Local).AddTicks(1499), new DateTime(2024, 10, 21, 20, 37, 59, 779, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 20, 20, 37, 59, 779, DateTimeKind.Local).AddTicks(1501), new DateTime(2024, 10, 27, 20, 37, 59, 779, DateTimeKind.Local).AddTicks(1502) });
        }
    }
}
