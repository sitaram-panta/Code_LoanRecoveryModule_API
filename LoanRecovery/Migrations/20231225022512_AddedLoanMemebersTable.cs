using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class AddedLoanMemebersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanRefId = table.Column<int>(type: "int", nullable: false),
                    GeneralId = table.Column<int>(type: "int", nullable: false),
                    IsPrimaryLoanee = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanMembers_Defaulters_LoanRefId",
                        column: x => x.LoanRefId,
                        principalTable: "Defaulters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanMembers_GeneralCompanyPersonEntities_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "GeneralCompanyPersonEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanMembers_GeneralId",
                table: "LoanMembers",
                column: "GeneralId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanMembers_LoanRefId",
                table: "LoanMembers",
                column: "LoanRefId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanMembers");
        }
    }
}
