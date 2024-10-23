using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchStor.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNullableToProductProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
