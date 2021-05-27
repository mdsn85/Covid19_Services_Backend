using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Covid19_Services_Backend.Migrations
{
    public partial class addtestcases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cases",
                columns: new[] { "CaseId", "CountryId", "Date", "Lat", "Lon", "NumberOfCases", "StatusId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 5, 26, 12, 55, 44, 362, DateTimeKind.Local).AddTicks(3940), 1.2, 1.3, 5, 1 },
                    { 2, 1, new DateTime(2021, 5, 26, 12, 55, 44, 362, DateTimeKind.Local).AddTicks(7212), 1.2, 1.3, 15, 2 },
                    { 3, 2, new DateTime(2021, 5, 26, 12, 55, 44, 362, DateTimeKind.Local).AddTicks(7383), 1.2, 1.3, 5, 1 },
                    { 4, 5, new DateTime(2021, 5, 26, 12, 55, 44, 362, DateTimeKind.Local).AddTicks(7408), 1.2, 1.3, 35, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "CaseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "CaseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "CaseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "CaseId",
                keyValue: 4);
        }
    }
}
