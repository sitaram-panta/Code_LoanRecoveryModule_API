using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class AddedTableLoanReminderLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanReminderLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanRefId = table.Column<int>(type: "int", nullable: false),
                    Reminder = table.Column<int>(type: "int", nullable: false),
                    ReminderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasNextReminderSchedule = table.Column<bool>(type: "bit", nullable: false),
                    NextReminderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanReminderLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanReminderLog_Defaulters_LoanRefId",
                        column: x => x.LoanRefId,
                        principalTable: "Defaulters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanReminderLog_LoanRefId",
                table: "LoanReminderLog",
                column: "LoanRefId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanReminderLog");
        }
    }
}
