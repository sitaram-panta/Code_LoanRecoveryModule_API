using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class addedCompanySHareholdertableplainwithFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyInfoId",
                table: "CompanyShareholders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyShareholderId",
                table: "CompanyInfos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyShareholders_CompanyInfoId",
                table: "CompanyShareholders",
                column: "CompanyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyInfos_CompanyShareholderId",
                table: "CompanyInfos",
                column: "CompanyShareholderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfos_CompanyShareholders_CompanyShareholderId",
                table: "CompanyInfos",
                column: "CompanyShareholderId",
                principalTable: "CompanyShareholders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyShareholders_CompanyInfos_CompanyInfoId",
                table: "CompanyShareholders",
                column: "CompanyInfoId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfos_CompanyShareholders_CompanyShareholderId",
                table: "CompanyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyShareholders_CompanyInfos_CompanyInfoId",
                table: "CompanyShareholders");

            migrationBuilder.DropIndex(
                name: "IX_CompanyShareholders_CompanyInfoId",
                table: "CompanyShareholders");

            migrationBuilder.DropIndex(
                name: "IX_CompanyInfos_CompanyShareholderId",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "CompanyInfoId",
                table: "CompanyShareholders");

            migrationBuilder.DropColumn(
                name: "CompanyShareholderId",
                table: "CompanyInfos");
        }
    }
}
