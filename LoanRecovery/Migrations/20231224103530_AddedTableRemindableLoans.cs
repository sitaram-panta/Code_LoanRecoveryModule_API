using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class AddedTableRemindableLoans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RemindableLoans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanRefId = table.Column<int>(type: "int", nullable: false),
                    ReminderStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReminderEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasDisableReminder = table.Column<bool>(type: "bit", nullable: false),
                    CreatedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemindableLoans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RemindableLoans_Defaulters_LoanRefId",
                        column: x => x.LoanRefId,
                        principalTable: "Defaulters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RemindableLoans_LoanRefId",
                table: "RemindableLoans",
                column: "LoanRefId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RemindableLoans");
        }
    }
}
