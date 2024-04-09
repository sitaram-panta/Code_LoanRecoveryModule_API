using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class AddedAuctionBidderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuctionBidders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanRefId = table.Column<int>(type: "int", nullable: false),
                    BidderInfo = table.Column<int>(type: "int", nullable: false),
                    BidderAmount = table.Column<int>(type: "int", nullable: false),
                    BidDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAwarded = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionBidders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuctionBidders_Defaulters_LoanRefId",
                        column: x => x.LoanRefId,
                        principalTable: "Defaulters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuctionBidders_GeneralCompanyPersonEntities_BidderInfo",
                        column: x => x.BidderInfo,
                        principalTable: "GeneralCompanyPersonEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuctionBidders_BidderInfo",
                table: "AuctionBidders",
                column: "BidderInfo");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionBidders_LoanRefId",
                table: "AuctionBidders",
                column: "LoanRefId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuctionBidders");
        }
    }
}
