using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class addedCompanyshareholderTableRemoveCompanywithColumnsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfos_CompanyShareholders_CompanyId",
                table: "CompanyInfos");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "CompanyInfos",
                newName: "CompanyInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfos_CompanyId",
                table: "CompanyInfos",
                newName: "IX_CompanyInfos_CompanyInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfos_CompanyShareholders_CompanyInfoId",
                table: "CompanyInfos",
                column: "CompanyInfoId",
                principalTable: "CompanyShareholders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfos_CompanyShareholders_CompanyInfoId",
                table: "CompanyInfos");

            migrationBuilder.RenameColumn(
                name: "CompanyInfoId",
                table: "CompanyInfos",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfos_CompanyInfoId",
                table: "CompanyInfos",
                newName: "IX_CompanyInfos_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfos_CompanyShareholders_CompanyId",
                table: "CompanyInfos",
                column: "CompanyId",
                principalTable: "CompanyShareholders",
                principalColumn: "Id");
        }
    }
}
