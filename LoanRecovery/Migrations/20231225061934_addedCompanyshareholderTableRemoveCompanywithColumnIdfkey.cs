using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class addedCompanyshareholderTableRemoveCompanywithColumnIdfkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "CompanyShareholders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "CompanyInfos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyInfos_CompanyId",
                table: "CompanyInfos",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfos_CompanyShareholders_CompanyId",
                table: "CompanyInfos",
                column: "CompanyId",
                principalTable: "CompanyShareholders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfos_CompanyShareholders_CompanyId",
                table: "CompanyInfos");

            migrationBuilder.DropIndex(
                name: "IX_CompanyInfos_CompanyId",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "CompanyShareholders");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "CompanyInfos");
        }
    }
}
