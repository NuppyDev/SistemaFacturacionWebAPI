using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class MejorarLazos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Historical_HistoricalId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Tables_TableId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Waiters_WaitersId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDescription_Facturas_InvoiceId",
                table: "InvoiceDescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas");

            migrationBuilder.RenameTable(
                name: "Facturas",
                newName: "Invoice");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_WaitersId",
                table: "Invoice",
                newName: "IX_Invoice_WaitersId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_TableId",
                table: "Invoice",
                newName: "IX_Invoice_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_HistoricalId",
                table: "Invoice",
                newName: "IX_Invoice_HistoricalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice",
                column: "InvoiceId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Historical_HistoricalId",
                table: "Invoice",
                column: "HistoricalId",
                principalTable: "Historical",
                principalColumn: "HistoricalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Tables_TableId",
                table: "Invoice",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Waiters_WaitersId",
                table: "Invoice",
                column: "WaitersId",
                principalTable: "Waiters",
                principalColumn: "WaitersId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDescription_Invoice_InvoiceId",
                table: "InvoiceDescription",
                column: "InvoiceId",
                principalTable: "Invoice",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Historical_HistoricalId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Tables_TableId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Waiters_WaitersId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDescription_Invoice_InvoiceId",
                table: "InvoiceDescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice");

            migrationBuilder.RenameTable(
                name: "Invoice",
                newName: "Facturas");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_WaitersId",
                table: "Facturas",
                newName: "IX_Facturas_WaitersId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_TableId",
                table: "Facturas",
                newName: "IX_Facturas_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_HistoricalId",
                table: "Facturas",
                newName: "IX_Facturas_HistoricalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas",
                column: "InvoiceId");

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 1,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 9, 12, 19, 14, 420, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 2,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 9, 12, 19, 14, 420, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Historical_HistoricalId",
                table: "Facturas",
                column: "HistoricalId",
                principalTable: "Historical",
                principalColumn: "HistoricalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Tables_TableId",
                table: "Facturas",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Waiters_WaitersId",
                table: "Facturas",
                column: "WaitersId",
                principalTable: "Waiters",
                principalColumn: "WaitersId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDescription_Facturas_InvoiceId",
                table: "InvoiceDescription",
                column: "InvoiceId",
                principalTable: "Facturas",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
