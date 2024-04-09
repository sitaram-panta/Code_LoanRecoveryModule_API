using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class AddedPersonalTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAlive = table.Column<bool>(type: "bit", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitizenshiipNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitizenshipIssueDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitizenshipIssueData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FatherInfoId = table.Column<int>(type: "int", nullable: true),
                    MotherInfoId = table.Column<int>(type: "int", nullable: true),
                    CreatedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalInfos_PersonalInfos_FatherInfoId",
                        column: x => x.FatherInfoId,
                        principalTable: "PersonalInfos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PersonalInfos_PersonalInfos_MotherInfoId",
                        column: x => x.MotherInfoId,
                        principalTable: "PersonalInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInfos_FatherInfoId",
                table: "PersonalInfos",
                column: "FatherInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInfos_MotherInfoId",
                table: "PersonalInfos",
                column: "MotherInfoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalInfos");
        }
    }
}
