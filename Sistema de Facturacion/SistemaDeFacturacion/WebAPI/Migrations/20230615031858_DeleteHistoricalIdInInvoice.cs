using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class DeleteHistoricalIdInInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Historical_HistoricalId",
                table: "Invoice");

            migrationBuilder.AlterColumn<int>(
                name: "HistoricalId",
                table: "Invoice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Historical_HistoricalId",
                table: "Invoice",
                column: "HistoricalId",
                principalTable: "Historical",
                principalColumn: "HistoricalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Historical_HistoricalId",
                table: "Invoice");

            migrationBuilder.AlterColumn<int>(
                name: "HistoricalId",
                table: "Invoice",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 3,
                columns: new[] { "Birthday", "DateAdmission" },
                values: new object[] { new DateTime(2023, 6, 14, 18, 48, 26, 265, DateTimeKind.Local).AddTicks(6963), new DateTime(2023, 6, 14, 18, 48, 26, 265, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Historical_HistoricalId",
                table: "Invoice",
                column: "HistoricalId",
                principalTable: "Historical",
                principalColumn: "HistoricalId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
