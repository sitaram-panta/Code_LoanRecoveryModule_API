using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class AddedGeneralCompanyPersonEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralCompanyPersonEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCompany = table.Column<bool>(type: "bit", nullable: false),
                    CompanyInfoId = table.Column<int>(type: "int", nullable: false),
                    PersonInfoId = table.Column<int>(type: "int", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralCompanyPersonEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralCompanyPersonEntities_CompanyInfos_CompanyInfoId",
                        column: x => x.CompanyInfoId,
                        principalTable: "CompanyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneralCompanyPersonEntities_PersonalInfos_PersonInfoId",
                        column: x => x.PersonInfoId,
                        principalTable: "PersonalInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeneralCompanyPersonEntities_CompanyInfoId",
                table: "GeneralCompanyPersonEntities",
                column: "CompanyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralCompanyPersonEntities_PersonInfoId",
                table: "GeneralCompanyPersonEntities",
                column: "PersonInfoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralCompanyPersonEntities");
        }
    }
}
