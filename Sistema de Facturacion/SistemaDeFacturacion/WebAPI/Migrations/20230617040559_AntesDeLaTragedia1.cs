using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AntesDeLaTragedia1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductsId2",
                table: "Description");

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 1,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 16, 22, 5, 58, 778, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 2,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 16, 22, 5, 58, 778, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 3,
                columns: new[] { "Birthday", "DateAdmission" },
                values: new object[] { new DateTime(2023, 6, 16, 22, 5, 58, 778, DateTimeKind.Local).AddTicks(1212), new DateTime(2023, 6, 16, 22, 5, 58, 778, DateTimeKind.Local).AddTicks(1210) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductsId2",
                table: "Description",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
