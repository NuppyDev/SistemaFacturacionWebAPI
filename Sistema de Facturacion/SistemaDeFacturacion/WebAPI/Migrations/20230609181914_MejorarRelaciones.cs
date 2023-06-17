using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class MejorarRelaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Description_DescriptionId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_DescriptionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductsId1",
                table: "Description",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                value: new DateTime(2023, 6, 9, 12, 19, 14, 420, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 2,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 9, 12, 19, 14, 420, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.CreateIndex(
                name: "IX_Description_ProductsId",
                table: "Description",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Description_ProductsId1",
                table: "Description",
                column: "ProductsId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Description_Products_ProductsId",
                table: "Description",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "ProductsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Description_Products_ProductsId1",
                table: "Description",
                column: "ProductsId1",
                principalTable: "Products",
                principalColumn: "ProductsId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Description_Products_ProductsId",
                table: "Description");

            migrationBuilder.DropForeignKey(
                name: "FK_Description_Products_ProductsId1",
                table: "Description");

            migrationBuilder.DropIndex(
                name: "IX_Description_ProductsId",
                table: "Description");

            migrationBuilder.DropIndex(
                name: "IX_Description_ProductsId1",
                table: "Description");

            migrationBuilder.DropColumn(
                name: "ProductsId1",
                table: "Description");

            migrationBuilder.DropColumn(
                name: "ProductsId2",
                table: "Description");

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsId",
                keyValue: 1,
                column: "DescriptionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsId",
                keyValue: 2,
                column: "DescriptionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsId",
                keyValue: 3,
                column: "DescriptionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsId",
                keyValue: 4,
                column: "DescriptionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsId",
                keyValue: 5,
                column: "DescriptionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsId",
                keyValue: 6,
                column: "DescriptionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsId",
                keyValue: 7,
                column: "DescriptionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsId",
                keyValue: 8,
                column: "DescriptionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsId",
                keyValue: 9,
                column: "DescriptionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsId",
                keyValue: 10,
                column: "DescriptionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsId",
                keyValue: 11,
                column: "DescriptionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsId",
                keyValue: 12,
                column: "DescriptionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 1,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 9, 12, 10, 50, 136, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 2,
                column: "DateAdmission",
                value: new DateTime(2023, 6, 9, 12, 10, 50, 136, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.CreateIndex(
                name: "IX_Products_DescriptionId",
                table: "Products",
                column: "DescriptionId",
                unique: true,
                filter: "[DescriptionId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Description_DescriptionId",
                table: "Products",
                column: "DescriptionId",
                principalTable: "Description",
                principalColumn: "DescriptionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
