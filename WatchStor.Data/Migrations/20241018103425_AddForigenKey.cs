using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchStor.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForigenKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeOfPurchase", "TimeOfSend", "WatchId" },
                values: new object[] { new DateTime(2024, 10, 8, 14, 4, 24, 885, DateTimeKind.Local).AddTicks(2962), new DateTime(2024, 10, 11, 14, 4, 24, 885, DateTimeKind.Local).AddTicks(2978), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeOfPurchase", "TimeOfSend", "WatchId" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 4, 24, 885, DateTimeKind.Local).AddTicks(2983), new DateTime(2024, 10, 16, 14, 4, 24, 885, DateTimeKind.Local).AddTicks(2984), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeOfPurchase", "TimeOfSend", "WatchId" },
                values: new object[] { new DateTime(2024, 10, 15, 14, 4, 24, 885, DateTimeKind.Local).AddTicks(2985), new DateTime(2024, 10, 22, 14, 4, 24, 885, DateTimeKind.Local).AddTicks(2985), 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeOfPurchase", "TimeOfSend", "WatchId" },
                values: new object[] { new DateTime(2024, 10, 8, 14, 0, 15, 311, DateTimeKind.Local).AddTicks(9202), new DateTime(2024, 10, 11, 14, 0, 15, 311, DateTimeKind.Local).AddTicks(9217), null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeOfPurchase", "TimeOfSend", "WatchId" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 0, 15, 311, DateTimeKind.Local).AddTicks(9220), new DateTime(2024, 10, 16, 14, 0, 15, 311, DateTimeKind.Local).AddTicks(9221), null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeOfPurchase", "TimeOfSend", "WatchId" },
                values: new object[] { new DateTime(2024, 10, 15, 14, 0, 15, 311, DateTimeKind.Local).AddTicks(9222), new DateTime(2024, 10, 22, 14, 0, 15, 311, DateTimeKind.Local).AddTicks(9222), null });
        }
    }
}
