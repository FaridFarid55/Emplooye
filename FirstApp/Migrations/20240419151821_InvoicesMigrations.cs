// Ignore Spelling: App

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstApp.Migrations
{
    /// <inheritdoc />
    public partial class InvoicesMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "TbEmployeeVacation",
                newName: "Description");

            migrationBuilder.CreateTable(
                name: "TbInvoiceModel",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    HasShipping = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbInvoiceModel", x => x.InvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "TbInvoiceDetails",
                columns: table => new
                {
                    InvoiceDetailId = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    InvoiceModelInvoiceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbInvoiceDetails", x => x.InvoiceDetailId);
                    table.ForeignKey(
                        name: "FK_TbInvoiceDetails_TbInvoiceModel_InvoiceDetailId",
                        column: x => x.InvoiceDetailId,
                        principalTable: "TbInvoiceModel",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbInvoiceDetails_TbInvoiceModel_InvoiceModelInvoiceId",
                        column: x => x.InvoiceModelInvoiceId,
                        principalTable: "TbInvoiceModel",
                        principalColumn: "InvoiceId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbInvoiceDetails_InvoiceModelInvoiceId",
                table: "TbInvoiceDetails",
                column: "InvoiceModelInvoiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbInvoiceDetails");

            migrationBuilder.DropTable(
                name: "TbInvoiceModel");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "TbEmployeeVacation",
                newName: "description");
        }
    }
}
