using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class AddedTableAuctionableLoans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuctionableLoans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuctionStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuctionEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MinAuctionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoanRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionableLoans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuctionableLoans_Defaulters_LoanRefId",
                        column: x => x.LoanRefId,
                        principalTable: "Defaulters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuctionableLoans_LoanRefId",
                table: "AuctionableLoans",
                column: "LoanRefId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuctionableLoans");
        }
    }
}
