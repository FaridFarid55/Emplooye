using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstApp.Migrations
{
    /// <inheritdoc />
    public partial class EmployeesAllowancesMigration : Migration 
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
                name: "TbEmployeesAllowancesModel",
                columns: table => new
                {
                    EmployeesAllowancesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    AllowancesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbEmployeesAllowancesModel", x => x.EmployeesAllowancesId);
                    table.ForeignKey(
                        name: "FK_TbEmployeesAllowancesModel_TbAllowancesModel_AllowancesId",
                        column: x => x.AllowancesId,
                        principalTable: "TbAllowancesModel",
                        principalColumn: "AllowancesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbEmployeesAllowancesModel_TbEmployees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "TbEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbEmployeesAllowancesModel_AllowancesId",
                table: "TbEmployeesAllowancesModel",
                column: "AllowancesId");

            migrationBuilder.CreateIndex(
                name: "IX_TbEmployeesAllowancesModel_EmployeesId",
                table: "TbEmployeesAllowancesModel",
                column: "EmployeesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbEmployeesAllowancesModel");

            migrationBuilder.DropTable(
                name: "TbAllowancesModel");
        }
    }
}
