using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class AddedLegalNoticeableLoans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LegalNoticeableLoans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanRefId = table.Column<int>(type: "int", nullable: false),
                    NoticeStage = table.Column<int>(type: "int", nullable: false),
                    CreatedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalNoticeableLoans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LegalNoticeableLoans_Defaulters_LoanRefId",
                        column: x => x.LoanRefId,
                        principalTable: "Defaulters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LegalNoticeableLoans_LoanRefId",
                table: "LegalNoticeableLoans",
                column: "LoanRefId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LegalNoticeableLoans");
        }
    }
}
