using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class addedCompanyshareholderTabl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyShareholderId",
                table: "GeneralCompanyPersonEntities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompanyShareholders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    SharePercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RegdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GeneralId = table.Column<int>(type: "int", nullable: false),
                    CreatedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyShareholders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyShareholders_GeneralCompanyPersonEntities_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "GeneralCompanyPersonEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeneralCompanyPersonEntities_CompanyShareholderId",
                table: "GeneralCompanyPersonEntities",
                column: "CompanyShareholderId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyShareholders_GeneralId",
                table: "CompanyShareholders",
                column: "GeneralId");

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralCompanyPersonEntities_CompanyShareholders_CompanyShareholderId",
                table: "GeneralCompanyPersonEntities",
                column: "CompanyShareholderId",
                principalTable: "CompanyShareholders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeneralCompanyPersonEntities_CompanyShareholders_CompanyShareholderId",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropTable(
                name: "CompanyShareholders");

            migrationBuilder.DropIndex(
                name: "IX_GeneralCompanyPersonEntities_CompanyShareholderId",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropColumn(
                name: "CompanyShareholderId",
                table: "GeneralCompanyPersonEntities");
        }
    }
}
