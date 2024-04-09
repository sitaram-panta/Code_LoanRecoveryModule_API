using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationshipbetweenMaturedloanandBranch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Defaulters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Defaulters_BranchId",
                table: "Defaulters",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Defaulters_Branches_BranchId",
                table: "Defaulters",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Defaulters_Branches_BranchId",
                table: "Defaulters");

            migrationBuilder.DropIndex(
                name: "IX_Defaulters_BranchId",
                table: "Defaulters");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Defaulters");
        }
    }
}
