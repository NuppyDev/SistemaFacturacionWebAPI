using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AntesDeLaTragedia2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Description_Products_ProductsId1",
                table: "Description");

            migrationBuilder.DropIndex(
                name: "IX_Description_ProductsId1",
                table: "Description");

            migrationBuilder.DropColumn(
                name: "ProductsId1",
                table: "Description");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductsId1",
                table: "Description",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Description_ProductsId1",
                table: "Description",
                column: "ProductsId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Description_Products_ProductsId1",
                table: "Description",
                column: "ProductsId1",
                principalTable: "Products",
                principalColumn: "ProductsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
