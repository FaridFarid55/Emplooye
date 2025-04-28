using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstApp.Migrations
{
    /// <inheritdoc />
    public partial class CustomersInvoicesMrMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbEmployees_TbPersonModel_PersonId",
                table: "TbEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_TbEmployeesAllowancesModel_TbAllowancesModel_AllowancesId",
                table: "TbEmployeesAllowancesModel");

            migrationBuilder.DropForeignKey(
                name: "FK_TbEmployeesAllowancesModel_TbEmployees_EmployeesId",
                table: "TbEmployeesAllowancesModel");

            migrationBuilder.DropForeignKey(
                name: "FK_TbInvoiceDetails_TbInvoiceModel_InvoiceDetailId",
                table: "TbInvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TbInvoiceDetails_TbInvoiceModel_InvoiceModelInvoiceId",
                table: "TbInvoiceDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TbPersonModel",
                table: "TbPersonModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TbInvoiceModel",
                table: "TbInvoiceModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TbEmployeesAllowancesModel",
                table: "TbEmployeesAllowancesModel");

            migrationBuilder.RenameTable(
                name: "TbPersonModel",
                newName: "TbPerson");

            migrationBuilder.RenameTable(
                name: "TbInvoiceModel",
                newName: "TbInvoice");

            migrationBuilder.RenameTable(
                name: "TbEmployeesAllowancesModel",
                newName: "TbEmployeesAllowances");

            migrationBuilder.RenameIndex(
                name: "IX_TbEmployeesAllowancesModel_EmployeesId",
                table: "TbEmployeesAllowances",
                newName: "IX_TbEmployeesAllowances_EmployeesId");

            migrationBuilder.RenameIndex(
                name: "IX_TbEmployeesAllowancesModel_AllowancesId",
                table: "TbEmployeesAllowances",
                newName: "IX_TbEmployeesAllowances_AllowancesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TbPerson",
                table: "TbPerson",
                column: "PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TbInvoice",
                table: "TbInvoice",
                column: "InvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TbEmployeesAllowances",
                table: "TbEmployeesAllowances",
                column: "EmployeesAllowancesId");

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

            migrationBuilder.CreateIndex(
                name: "IX_TbCustomersInvoicesBr_CustomerId",
                table: "TbCustomersInvoicesBr",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TbCustomersInvoicesBr_InvoiceId",
                table: "TbCustomersInvoicesBr",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbEmployees_TbPerson_PersonId",
                table: "TbEmployees",
                column: "PersonId",
                principalTable: "TbPerson",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbEmployeesAllowances_TbAllowancesModel_AllowancesId",
                table: "TbEmployeesAllowances",
                column: "AllowancesId",
                principalTable: "TbAllowancesModel",
                principalColumn: "AllowancesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbEmployeesAllowances_TbEmployees_EmployeesId",
                table: "TbEmployeesAllowances",
                column: "EmployeesId",
                principalTable: "TbEmployees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbInvoiceDetails_TbInvoice_InvoiceDetailId",
                table: "TbInvoiceDetails",
                column: "InvoiceDetailId",
                principalTable: "TbInvoice",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbInvoiceDetails_TbInvoice_InvoiceModelInvoiceId",
                table: "TbInvoiceDetails",
                column: "InvoiceModelInvoiceId",
                principalTable: "TbInvoice",
                principalColumn: "InvoiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbEmployees_TbPerson_PersonId",
                table: "TbEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_TbEmployeesAllowances_TbAllowancesModel_AllowancesId",
                table: "TbEmployeesAllowances");

            migrationBuilder.DropForeignKey(
                name: "FK_TbEmployeesAllowances_TbEmployees_EmployeesId",
                table: "TbEmployeesAllowances");

            migrationBuilder.DropForeignKey(
                name: "FK_TbInvoiceDetails_TbInvoice_InvoiceDetailId",
                table: "TbInvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TbInvoiceDetails_TbInvoice_InvoiceModelInvoiceId",
                table: "TbInvoiceDetails");

            migrationBuilder.DropTable(
                name: "TbCustomersInvoicesBr");

            migrationBuilder.DropTable(
                name: "TbCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TbPerson",
                table: "TbPerson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TbInvoice",
                table: "TbInvoice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TbEmployeesAllowances",
                table: "TbEmployeesAllowances");

            migrationBuilder.RenameTable(
                name: "TbPerson",
                newName: "TbPersonModel");

            migrationBuilder.RenameTable(
                name: "TbInvoice",
                newName: "TbInvoiceModel");

            migrationBuilder.RenameTable(
                name: "TbEmployeesAllowances",
                newName: "TbEmployeesAllowancesModel");

            migrationBuilder.RenameIndex(
                name: "IX_TbEmployeesAllowances_EmployeesId",
                table: "TbEmployeesAllowancesModel",
                newName: "IX_TbEmployeesAllowancesModel_EmployeesId");

            migrationBuilder.RenameIndex(
                name: "IX_TbEmployeesAllowances_AllowancesId",
                table: "TbEmployeesAllowancesModel",
                newName: "IX_TbEmployeesAllowancesModel_AllowancesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TbPersonModel",
                table: "TbPersonModel",
                column: "PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TbInvoiceModel",
                table: "TbInvoiceModel",
                column: "InvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TbEmployeesAllowancesModel",
                table: "TbEmployeesAllowancesModel",
                column: "EmployeesAllowancesId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbEmployees_TbPersonModel_PersonId",
                table: "TbEmployees",
                column: "PersonId",
                principalTable: "TbPersonModel",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbEmployeesAllowancesModel_TbAllowancesModel_AllowancesId",
                table: "TbEmployeesAllowancesModel",
                column: "AllowancesId",
                principalTable: "TbAllowancesModel",
                principalColumn: "AllowancesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbEmployeesAllowancesModel_TbEmployees_EmployeesId",
                table: "TbEmployeesAllowancesModel",
                column: "EmployeesId",
                principalTable: "TbEmployees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbInvoiceDetails_TbInvoiceModel_InvoiceDetailId",
                table: "TbInvoiceDetails",
                column: "InvoiceDetailId",
                principalTable: "TbInvoiceModel",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbInvoiceDetails_TbInvoiceModel_InvoiceModelInvoiceId",
                table: "TbInvoiceDetails",
                column: "InvoiceModelInvoiceId",
                principalTable: "TbInvoiceModel",
                principalColumn: "InvoiceId");
        }
    }
}
