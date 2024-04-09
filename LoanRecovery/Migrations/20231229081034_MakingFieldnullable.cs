using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class MakingFieldnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeneralCompanyPersonEntities_CompanyInfos_CompanyInfoId",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneralCompanyPersonEntities_PersonalInfos_PersonInfoId",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.AlterColumn<int>(
                name: "PersonInfoId",
                table: "GeneralCompanyPersonEntities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyInfoId",
                table: "GeneralCompanyPersonEntities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralCompanyPersonEntities_CompanyInfos_CompanyInfoId",
                table: "GeneralCompanyPersonEntities",
                column: "CompanyInfoId",
                principalTable: "CompanyInfos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralCompanyPersonEntities_PersonalInfos_PersonInfoId",
                table: "GeneralCompanyPersonEntities",
                column: "PersonInfoId",
                principalTable: "PersonalInfos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeneralCompanyPersonEntities_CompanyInfos_CompanyInfoId",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneralCompanyPersonEntities_PersonalInfos_PersonInfoId",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.AlterColumn<int>(
                name: "PersonInfoId",
                table: "GeneralCompanyPersonEntities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyInfoId",
                table: "GeneralCompanyPersonEntities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralCompanyPersonEntities_CompanyInfos_CompanyInfoId",
                table: "GeneralCompanyPersonEntities",
                column: "CompanyInfoId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralCompanyPersonEntities_PersonalInfos_PersonInfoId",
                table: "GeneralCompanyPersonEntities",
                column: "PersonInfoId",
                principalTable: "PersonalInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
