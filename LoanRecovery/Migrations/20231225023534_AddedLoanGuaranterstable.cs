using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class AddedLoanGuaranterstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanGuaranters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanRefId = table.Column<int>(type: "int", nullable: false),
                    GeneralId = table.Column<int>(type: "int", nullable: false),
                    GuaranteePercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanGuaranters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanGuaranters_Defaulters_LoanRefId",
                        column: x => x.LoanRefId,
                        principalTable: "Defaulters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanGuaranters_GeneralCompanyPersonEntities_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "GeneralCompanyPersonEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanGuaranters_GeneralId",
                table: "LoanGuaranters",
                column: "GeneralId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanGuaranters_LoanRefId",
                table: "LoanGuaranters",
                column: "LoanRefId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanGuaranters");
        }
    }
}
