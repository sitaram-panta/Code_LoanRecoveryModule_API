using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class addedDefaulterTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Defaulters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanCamId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisburshedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OutstandingPrincipal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DuePrincipal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueInterest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccuredInterest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InterestRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsStatus = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defaulters", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Defaulters");
        }
    }
}
