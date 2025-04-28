// Ignore Spelling: App

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstApp.Migrations
{
    /// <inheritdoc />
    public partial class PersonTabaleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "TbEmployees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TbPersonModel",
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
                    table.PrimaryKey("PK_TbPersonModel", x => x.PersonId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbEmployees_PersonId",
                table: "TbEmployees",
                column: "PersonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TbEmployees_TbPersonModel_PersonId",
                table: "TbEmployees",
                column: "PersonId",
                principalTable: "TbPersonModel",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbEmployees_TbPersonModel_PersonId",
                table: "TbEmployees");

            migrationBuilder.DropTable(
                name: "TbPersonModel");

            migrationBuilder.DropIndex(
                name: "IX_TbEmployees_PersonId",
                table: "TbEmployees");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "TbEmployees");
        }
    }
}
