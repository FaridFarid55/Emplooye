using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbAllowancesModel",
                columns: table => new
                {
                    AllowancesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbAllowancesModel", x => x.AllowancesId);
                });

            migrationBuilder.CreateTable(
                name: "TbCustomers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Conditions = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCustomers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "TbDepartment",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbDepartment", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "TbInvoice",
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
                    table.PrimaryKey("PK_TbInvoice", x => x.InvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "TbPerson",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPerson", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "TbCustomersInvoicesBr",
                columns: table => new
                {
                    CustomersInvoicesModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCustomersInvoicesBr", x => x.CustomersInvoicesModelId);
                    table.ForeignKey(
                        name: "FK_TbCustomersInvoicesBr_TbCustomers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "TbCustomers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbCustomersInvoicesBr_TbInvoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "TbInvoice",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_TbInvoiceDetails_TbInvoice_InvoiceDetailId",
                        column: x => x.InvoiceDetailId,
                        principalTable: "TbInvoice",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbInvoiceDetails_TbInvoice_InvoiceModelInvoiceId",
                        column: x => x.InvoiceModelInvoiceId,
                        principalTable: "TbInvoice",
                        principalColumn: "InvoiceId");
                });

            migrationBuilder.CreateTable(
                name: "TbEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    imgName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbEmployees_TbDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "TbDepartment",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbEmployees_TbPerson_PersonId",
                        column: x => x.PersonId,
                        principalTable: "TbPerson",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbEmployeesAllowances",
                columns: table => new
                {
                    EmployeesAllowancesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    AllowancesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbEmployeesAllowances", x => x.EmployeesAllowancesId);
                    table.ForeignKey(
                        name: "FK_TbEmployeesAllowances_TbAllowancesModel_AllowancesId",
                        column: x => x.AllowancesId,
                        principalTable: "TbAllowancesModel",
                        principalColumn: "AllowancesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbEmployeesAllowances_TbEmployees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "TbEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbEmployeeVacation",
                columns: table => new
                {
                    EmployeeVacationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    VacationType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbEmployeeVacation", x => x.EmployeeVacationId);
                    table.ForeignKey(
                        name: "FK_TbEmployeeVacation_TbEmployees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "TbEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbCustomersInvoicesBr_CustomerId",
                table: "TbCustomersInvoicesBr",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TbCustomersInvoicesBr_InvoiceId",
                table: "TbCustomersInvoicesBr",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_TbEmployees_DepartmentId",
                table: "TbEmployees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TbEmployees_PersonId",
                table: "TbEmployees",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbEmployeesAllowances_AllowancesId",
                table: "TbEmployeesAllowances",
                column: "AllowancesId");

            migrationBuilder.CreateIndex(
                name: "IX_TbEmployeesAllowances_EmployeesId",
                table: "TbEmployeesAllowances",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_TbEmployeeVacation_EmployeeId",
                table: "TbEmployeeVacation",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TbInvoiceDetails_InvoiceModelInvoiceId",
                table: "TbInvoiceDetails",
                column: "InvoiceModelInvoiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbCustomersInvoicesBr");

            migrationBuilder.DropTable(
                name: "TbEmployeesAllowances");

            migrationBuilder.DropTable(
                name: "TbEmployeeVacation");

            migrationBuilder.DropTable(
                name: "TbInvoiceDetails");

            migrationBuilder.DropTable(
                name: "TbCustomers");

            migrationBuilder.DropTable(
                name: "TbAllowancesModel");

            migrationBuilder.DropTable(
                name: "TbEmployees");

            migrationBuilder.DropTable(
                name: "TbInvoice");

            migrationBuilder.DropTable(
                name: "TbDepartment");

            migrationBuilder.DropTable(
                name: "TbPerson");
        }
    }
}
