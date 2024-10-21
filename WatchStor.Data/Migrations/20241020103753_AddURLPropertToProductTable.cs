using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchStor.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddURLPropertToProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 7, 52, 402, DateTimeKind.Local).AddTicks(7718), new DateTime(2024, 10, 13, 14, 7, 52, 402, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 15, 14, 7, 52, 402, DateTimeKind.Local).AddTicks(7736), new DateTime(2024, 10, 18, 14, 7, 52, 402, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 17, 14, 7, 52, 402, DateTimeKind.Local).AddTicks(7738), new DateTime(2024, 10, 24, 14, 7, 52, 402, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 8, 14, 4, 24, 885, DateTimeKind.Local).AddTicks(2962), new DateTime(2024, 10, 11, 14, 4, 24, 885, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 4, 24, 885, DateTimeKind.Local).AddTicks(2983), new DateTime(2024, 10, 16, 14, 4, 24, 885, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeOfPurchase", "TimeOfSend" },
                values: new object[] { new DateTime(2024, 10, 15, 14, 4, 24, 885, DateTimeKind.Local).AddTicks(2985), new DateTime(2024, 10, 22, 14, 4, 24, 885, DateTimeKind.Local).AddTicks(2985) });
        }
    }
}
