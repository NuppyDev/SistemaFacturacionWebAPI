using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AntesDeLaTragedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 1,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 16, 22, 1, 16, 890, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 2,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 16, 22, 1, 16, 890, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 3,
                columns: new[] { "Birthday", "DateAdmission" },
                values: new object[] { new DateTime(2023, 6, 16, 22, 1, 16, 890, DateTimeKind.Local).AddTicks(9548), new DateTime(2023, 6, 16, 22, 1, 16, 890, DateTimeKind.Local).AddTicks(9547) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 1,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 14, 21, 18, 58, 127, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 2,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 14, 21, 18, 58, 127, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 3,
                columns: new[] { "Birthday", "DateAdmission" },
                values: new object[] { new DateTime(2023, 6, 14, 21, 18, 58, 127, DateTimeKind.Local).AddTicks(5939), new DateTime(2023, 6, 14, 21, 18, 58, 127, DateTimeKind.Local).AddTicks(5938) });
        }
    }
}
