using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class EliminarAlgunasRelacionesPrueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Historical_HistoricalId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDescription_Description_DescriptionId",
                table: "InvoiceDescription");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDescription_Invoice_InvoiceId",
                table: "InvoiceDescription");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceDescription_DescriptionId",
                table: "InvoiceDescription");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceDescription_InvoiceId",
                table: "InvoiceDescription");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_HistoricalId",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "HistoricalId",
                table: "Invoice");

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 1,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 17, 12, 48, 21, 684, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 2,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 17, 12, 48, 21, 684, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 3,
                columns: new[] { "Birthday", "DateAdmission" },
                values: new object[] { new DateTime(2023, 6, 17, 12, 48, 21, 684, DateTimeKind.Local).AddTicks(858), new DateTime(2023, 6, 17, 12, 48, 21, 684, DateTimeKind.Local).AddTicks(858) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HistoricalId",
                table: "Invoice",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 1,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 16, 22, 50, 53, 911, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 2,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 16, 22, 50, 53, 911, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 3,
                columns: new[] { "Birthday", "DateAdmission" },
                values: new object[] { new DateTime(2023, 6, 16, 22, 50, 53, 911, DateTimeKind.Local).AddTicks(6478), new DateTime(2023, 6, 16, 22, 50, 53, 911, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDescription_DescriptionId",
                table: "InvoiceDescription",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDescription_InvoiceId",
                table: "InvoiceDescription",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_HistoricalId",
                table: "Invoice",
                column: "HistoricalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Historical_HistoricalId",
                table: "Invoice",
                column: "HistoricalId",
                principalTable: "Historical",
                principalColumn: "HistoricalId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDescription_Description_DescriptionId",
                table: "InvoiceDescription",
                column: "DescriptionId",
                principalTable: "Description",
                principalColumn: "DescriptionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDescription_Invoice_InvoiceId",
                table: "InvoiceDescription",
                column: "InvoiceId",
                principalTable: "Invoice",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
