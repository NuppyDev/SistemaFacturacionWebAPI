using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoriesId);
                });

            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    Cant = table.Column<int>(type: "int", nullable: false),
                    UnitePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.DescriptionId);
                });

            migrationBuilder.CreateTable(
                name: "Historical",
                columns: table => new
                {
                    HistoricalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historical", x => x.HistoricalId);
                });

            migrationBuilder.CreateTable(
                name: "Waiters",
                columns: table => new
                {
                    WaitersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WaitersFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateAdmission = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waiters", x => x.WaitersId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    NombreDelProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductsId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "CategoriesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Description",
                        principalColumn: "DescriptionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    TableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WaitersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.TableId);
                    table.ForeignKey(
                        name: "FK_Tables_Waiters_WaitersId",
                        column: x => x.WaitersId,
                        principalTable: "Waiters",
                        principalColumn: "WaitersId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HistoricalId = table.Column<int>(type: "int", nullable: false),
                    TableId = table.Column<int>(type: "int", nullable: false),
                    WaitersId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Facturas_Historical_HistoricalId",
                        column: x => x.HistoricalId,
                        principalTable: "Historical",
                        principalColumn: "HistoricalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "TableId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Waiters_WaitersId",
                        column: x => x.WaitersId,
                        principalTable: "Waiters",
                        principalColumn: "WaitersId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDescription",
                columns: table => new
                {
                    InDeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDescription", x => x.InDeId);
                    table.ForeignKey(
                        name: "FK_InvoiceDescription_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Description",
                        principalColumn: "DescriptionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceDescription_Facturas_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Facturas",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoriesId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Bebida" },
                    { 2, "Comida" }
                });

            migrationBuilder.InsertData(
                table: "Waiters",
                columns: new[] { "WaitersId", "Birthday", "DateAdmission", "WaitersFullName" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 9, 12, 10, 50, 136, DateTimeKind.Local).AddTicks(8873), "Katou Megumi" },
                    { 2, new DateTime(2005, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 9, 12, 10, 50, 136, DateTimeKind.Local).AddTicks(8892), "Leon Scott Kennedy" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductsId", "CategoriesId", "DescriptionId", "NombreDelProducto", "PrecioUnitario" },
                values: new object[,]
                {
                    { 1, 1, null, "Café Caliente", 10m },
                    { 2, 1, null, "Café Helado", 20m },
                    { 3, 1, null, "Frapuccino", 30m },
                    { 4, 1, null, "Té de Limon", 15m },
                    { 5, 1, null, "Limonada", 20m },
                    { 6, 1, null, "Té Caliente", 10m },
                    { 7, 2, null, "Rosquillas y Viejitas Somoteñas", 20m },
                    { 8, 2, null, "Panini de Queso", 25m },
                    { 9, 2, null, "Panqueques", 50m },
                    { 10, 2, null, "Slice de Torta Marmoleada", 20m },
                    { 11, 2, null, "Gomitas de Café", 15m },
                    { 12, 2, null, "Papitas Fritas", 35m }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "WaitersId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 1 },
                    { 6, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_HistoricalId",
                table: "Facturas",
                column: "HistoricalId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_TableId",
                table: "Facturas",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_WaitersId",
                table: "Facturas",
                column: "WaitersId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDescription_DescriptionId",
                table: "InvoiceDescription",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDescription_InvoiceId",
                table: "InvoiceDescription",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoriesId",
                table: "Products",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DescriptionId",
                table: "Products",
                column: "DescriptionId",
                unique: true,
                filter: "[DescriptionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_WaitersId",
                table: "Tables",
                column: "WaitersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceDescription");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.DropTable(
                name: "Historical");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Waiters");
        }
    }
}
