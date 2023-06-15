using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDataOfDelivery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 1,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 14, 18, 48, 26, 265, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 2,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 14, 18, 48, 26, 265, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.InsertData(
                table: "Waiters",
                columns: new[] { "WaitersId", "Birthday", "DateAdmission", "WaitersFullName" },
                values: new object[] { 3, new DateTime(2023, 6, 14, 18, 48, 26, 265, DateTimeKind.Local).AddTicks(6963), new DateTime(2023, 6, 14, 18, 48, 26, 265, DateTimeKind.Local).AddTicks(6963), "Para Llevar" });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "WaitersId" },
                values: new object[] { 7, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 1,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 11, 13, 2, 39, 360, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 2,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 11, 13, 2, 39, 360, DateTimeKind.Local).AddTicks(8042));
        }
    }
}
