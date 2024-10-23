using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchStor.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddnewCulmstitleToPayModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "pays",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "pays");

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
    }
}
