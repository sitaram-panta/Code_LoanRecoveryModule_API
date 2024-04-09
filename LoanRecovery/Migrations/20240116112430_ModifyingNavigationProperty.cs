using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class ModifyingNavigationProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfos_CompanyShareholders_CompanyShareholderId",
                table: "CompanyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyShareholders_CompanyInfos_CompanyInfoId",
                table: "CompanyShareholders");

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
                name: "IX_CompanyInfos_CompanyShareholderId",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "CompanyShareholderId",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropColumn(
                name: "CompanyShareholderId",
                table: "CompanyInfos");

            migrationBuilder.AlterColumn<int>(
                name: "GeneralId",
                table: "CompanyShareholders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyInfoId",
                table: "CompanyShareholders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyShareholders_CompanyInfos_CompanyInfoId",
                table: "CompanyShareholders",
                column: "CompanyInfoId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyShareholders_GeneralCompanyPersonEntities_GeneralId",
                table: "CompanyShareholders",
                column: "GeneralId",
                principalTable: "GeneralCompanyPersonEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyShareholders_CompanyInfos_CompanyInfoId",
                table: "CompanyShareholders");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyShareholders_GeneralCompanyPersonEntities_GeneralId",
                table: "CompanyShareholders");

            migrationBuilder.AddColumn<int>(
                name: "CompanyShareholderId",
                table: "GeneralCompanyPersonEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GeneralId",
                table: "CompanyShareholders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyInfoId",
                table: "CompanyShareholders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CompanyShareholderId",
                table: "CompanyInfos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GeneralCompanyPersonEntities_CompanyShareholderId",
                table: "GeneralCompanyPersonEntities",
                column: "CompanyShareholderId");

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
                principalColumn: "Id");

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
    }
}
