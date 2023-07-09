using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class TableUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Name", "Password", "Phone", "Role", "Usuario" },
                values: new object[,]
                {
                    { 1, "Stephanie Tenorio", "@LeonMiAmor", "+50575064049", "Administrador", "StephTeno19" },
                    { 2, "Nico Casimiro", "@LeonMiAmor", "+50582855247", "Cajero", "Casi02Miro" },
                    { 3, "Cliente", "admin", null, "Cliente", "Cliente" }
                });

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 1,
                column: "DateAdmission",
                value: new DateTime(2023, 7, 9, 15, 42, 19, 722, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 2,
                column: "DateAdmission",
                value: new DateTime(2023, 7, 9, 15, 42, 19, 722, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "WaitersId",
                keyValue: 3,
                columns: new[] { "Birthday", "DateAdmission" },
                values: new object[] { new DateTime(2023, 7, 9, 15, 42, 19, 722, DateTimeKind.Local).AddTicks(1483), new DateTime(2023, 7, 9, 15, 42, 19, 722, DateTimeKind.Local).AddTicks(1483) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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
    }
}
