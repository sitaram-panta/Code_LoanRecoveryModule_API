using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanRecovery.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultModelEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PersonalInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "PersonalInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "PersonalInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "PersonalInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "LoanSecurities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedName",
                table: "LoanSecurities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LoanSecurities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "LoanSecurities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "LoanSecurities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "LoanSecurities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LoanPaymentLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "LoanPaymentLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "LoanPaymentLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "LoanPaymentLogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "LoanMembers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedName",
                table: "LoanMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LoanMembers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "LoanMembers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "LoanMembers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "LoanMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "LoanGuaranters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedName",
                table: "LoanGuaranters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LoanGuaranters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "LoanGuaranters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "LoanGuaranters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "LoanGuaranters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "LoanFacilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedName",
                table: "LoanFacilities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LoanFacilities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "LoanFacilities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "LoanFacilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "LoanFacilities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "GeneralCompanyPersonEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedName",
                table: "GeneralCompanyPersonEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "GeneralCompanyPersonEntities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "GeneralCompanyPersonEntities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "GeneralCompanyPersonEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "GeneralCompanyPersonEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "FollowUps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedName",
                table: "FollowUps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "FollowUps",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "FollowUps",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "FollowUps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "FollowUps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Defaulters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "Defaulters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Defaulters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "Defaulters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CompanyShareholders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "CompanyShareholders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "CompanyShareholders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "CompanyShareholders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CompanyInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "CompanyInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "CompanyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Branches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedName",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Branches",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "Branches",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AuctionPayments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedName",
                table: "AuctionPayments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AuctionPayments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "AuctionPayments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "AuctionPayments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "AuctionPayments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AuctionBidders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedName",
                table: "AuctionBidders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AuctionBidders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "AuctionBidders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "AuctionBidders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "AuctionBidders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AuctionableLoans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedName",
                table: "AuctionableLoans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AuctionableLoans",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "AuctionableLoans",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "AuctionableLoans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "AuctionableLoans",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PersonalInfos");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "PersonalInfos");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "PersonalInfos");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "PersonalInfos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "LoanSecurities");

            migrationBuilder.DropColumn(
                name: "CreatedName",
                table: "LoanSecurities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LoanSecurities");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "LoanSecurities");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "LoanSecurities");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "LoanSecurities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LoanPaymentLogs");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "LoanPaymentLogs");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "LoanPaymentLogs");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "LoanPaymentLogs");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "LoanMembers");

            migrationBuilder.DropColumn(
                name: "CreatedName",
                table: "LoanMembers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LoanMembers");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "LoanMembers");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "LoanMembers");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "LoanMembers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "LoanGuaranters");

            migrationBuilder.DropColumn(
                name: "CreatedName",
                table: "LoanGuaranters");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LoanGuaranters");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "LoanGuaranters");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "LoanGuaranters");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "LoanGuaranters");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "LoanFacilities");

            migrationBuilder.DropColumn(
                name: "CreatedName",
                table: "LoanFacilities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LoanFacilities");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "LoanFacilities");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "LoanFacilities");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "LoanFacilities");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropColumn(
                name: "CreatedName",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "GeneralCompanyPersonEntities");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "FollowUps");

            migrationBuilder.DropColumn(
                name: "CreatedName",
                table: "FollowUps");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "FollowUps");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "FollowUps");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "FollowUps");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "FollowUps");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Defaulters");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "Defaulters");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Defaulters");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "Defaulters");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CompanyShareholders");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "CompanyShareholders");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "CompanyShareholders");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "CompanyShareholders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "CreatedName",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AuctionPayments");

            migrationBuilder.DropColumn(
                name: "CreatedName",
                table: "AuctionPayments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AuctionPayments");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "AuctionPayments");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "AuctionPayments");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "AuctionPayments");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AuctionBidders");

            migrationBuilder.DropColumn(
                name: "CreatedName",
                table: "AuctionBidders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AuctionBidders");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "AuctionBidders");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "AuctionBidders");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "AuctionBidders");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AuctionableLoans");

            migrationBuilder.DropColumn(
                name: "CreatedName",
                table: "AuctionableLoans");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AuctionableLoans");

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "AuctionableLoans");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "AuctionableLoans");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "AuctionableLoans");
        }
    }
}
