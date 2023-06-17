using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ModificarDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Description",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Description");

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 1,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 9, 13, 58, 20, 652, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 2,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 9, 13, 58, 20, 652, DateTimeKind.Local).AddTicks(163));
        }
    }
}
