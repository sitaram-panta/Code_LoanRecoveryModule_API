using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class addedCompanySHareholdertableplainwithFKGeneral : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyShareholderId",
                table: "GeneralCompanyPersonEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GeneralId",
                table: "CompanyShareholders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GeneralCompanyPersonEntities_CompanyShareholderId",
                table: "GeneralCompanyPersonEntities",
                column: "CompanyShareholderId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyShareholders_GeneralId",
                table: "CompanyShareholders",
                column: "GeneralId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyShareholders_GeneralCompanyPersonEntities_GeneralId",
                table: "CompanyShareholders",
                column: "GeneralId",
                principalTable: "GeneralCompanyPersonEntities",
                principalColumn: "Id");

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
                name: "FK_CompanyShareholders_GeneralCompanyPersonEntities_GeneralId",
                table: "CompanyShareholders");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneralCompanyPersonEntities_CompanyShareholders_CompanyShareholderId",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropIndex(
                name: "IX_GeneralCompanyPersonEntities_CompanyShareholderId",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropIndex(
                name: "IX_CompanyShareholders_GeneralId",
                table: "CompanyShareholders");

            migrationBuilder.DropColumn(
                name: "CompanyShareholderId",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropColumn(
                name: "GeneralId",
                table: "CompanyShareholders");
        }
    }
}
