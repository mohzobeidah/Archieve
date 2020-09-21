using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archieve.Migrations
{
    public partial class _130920200610 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MilitaryRank",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "FK_MilitaryRankId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MilitaryRanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    RankName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryRanks", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 604, DateTimeKind.Local).AddTicks(6713), new DateTime(2020, 9, 13, 6, 10, 49, 604, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 604, DateTimeKind.Local).AddTicks(8435), new DateTime(2020, 9, 13, 6, 10, 49, 604, DateTimeKind.Local).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 604, DateTimeKind.Local).AddTicks(8492), new DateTime(2020, 9, 13, 6, 10, 49, 604, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 604, DateTimeKind.Local).AddTicks(8506), new DateTime(2020, 9, 13, 6, 10, 49, 604, DateTimeKind.Local).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 600, DateTimeKind.Local).AddTicks(6876), new DateTime(2020, 9, 13, 6, 10, 49, 600, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 602, DateTimeKind.Local).AddTicks(8326), new DateTime(2020, 9, 13, 6, 10, 49, 602, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.InsertData(
                table: "MilitaryRanks",
                columns: new[] { "Id", "InsertDate", "InsertUser", "IsDeleted", "RankName", "UpdateUser", "UpdatedDate" },
                values: new object[,]
                {
                    { 16, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2620), null, false, " السيد", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2625) },
                    { 15, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2604), null, false, " عقد بطالة", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2609) },
                    { 14, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2588), null, false, " جندي", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2593) },
                    { 13, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2572), null, false, "عريف ", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2577) },
                    { 12, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2556), null, false, " رقيب", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2561) },
                    { 1, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2068), null, false, "لواء ", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2088) },
                    { 10, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2524), null, false, " مساعد", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2529) },
                    { 9, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2506), null, false, "مساعد اول ", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2511) },
                    { 8, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2490), null, false, " ملازم", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2495) },
                    { 7, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2474), null, false, " ملازم اول", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2479) },
                    { 2, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2380), null, false, " عميد", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2385) },
                    { 3, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2403), null, false, " عقيد", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2408) },
                    { 4, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2421), null, false, " مقدم", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2425) },
                    { 5, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2437), null, false, "رائد ", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2442) },
                    { 6, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2458), null, false, " نقيب", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2462) },
                    { 11, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2540), null, false, " رقيب اول", null, new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2544) }
                });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 605, DateTimeKind.Local).AddTicks(4719), new DateTime(2020, 9, 13, 6, 10, 49, 605, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 605, DateTimeKind.Local).AddTicks(4976), new DateTime(2020, 9, 13, 6, 10, 49, 605, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 603, DateTimeKind.Local).AddTicks(5515), new DateTime(2020, 9, 13, 6, 10, 49, 603, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 603, DateTimeKind.Local).AddTicks(5809), new DateTime(2020, 9, 13, 6, 10, 49, 603, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 606, DateTimeKind.Local).AddTicks(2825), new DateTime(2020, 9, 13, 6, 10, 49, 606, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 606, DateTimeKind.Local).AddTicks(3212), new DateTime(2020, 9, 13, 6, 10, 49, 606, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 609, DateTimeKind.Local).AddTicks(1590), new DateTime(2020, 9, 13, 6, 10, 49, 609, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 609, DateTimeKind.Local).AddTicks(1854), new DateTime(2020, 9, 13, 6, 10, 49, 609, DateTimeKind.Local).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 609, DateTimeKind.Local).AddTicks(1877), new DateTime(2020, 9, 13, 6, 10, 49, 609, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 609, DateTimeKind.Local).AddTicks(1894), new DateTime(2020, 9, 13, 6, 10, 49, 609, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 609, DateTimeKind.Local).AddTicks(1911), new DateTime(2020, 9, 13, 6, 10, 49, 609, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 609, DateTimeKind.Local).AddTicks(1933), new DateTime(2020, 9, 13, 6, 10, 49, 609, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(999), new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(1340), new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(1363), new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(1380), new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(1463), new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(1488), new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(1505), new DateTime(2020, 9, 13, 6, 10, 49, 608, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FK_MilitaryRankId",
                table: "AspNetUsers",
                column: "FK_MilitaryRankId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MilitaryRanks_FK_MilitaryRankId",
                table: "AspNetUsers",
                column: "FK_MilitaryRankId",
                principalTable: "MilitaryRanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MilitaryRanks_FK_MilitaryRankId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MilitaryRanks");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FK_MilitaryRankId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FK_MilitaryRankId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "MilitaryRank",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNo",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 651, DateTimeKind.Local).AddTicks(1269), new DateTime(2020, 9, 13, 2, 51, 15, 651, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 651, DateTimeKind.Local).AddTicks(3812), new DateTime(2020, 9, 13, 2, 51, 15, 651, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 651, DateTimeKind.Local).AddTicks(3896), new DateTime(2020, 9, 13, 2, 51, 15, 651, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 651, DateTimeKind.Local).AddTicks(3916), new DateTime(2020, 9, 13, 2, 51, 15, 651, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 646, DateTimeKind.Local).AddTicks(379), new DateTime(2020, 9, 13, 2, 51, 15, 646, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 648, DateTimeKind.Local).AddTicks(7512), new DateTime(2020, 9, 13, 2, 51, 15, 648, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 652, DateTimeKind.Local).AddTicks(3043), new DateTime(2020, 9, 13, 2, 51, 15, 652, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 652, DateTimeKind.Local).AddTicks(3446), new DateTime(2020, 9, 13, 2, 51, 15, 652, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 649, DateTimeKind.Local).AddTicks(7662), new DateTime(2020, 9, 13, 2, 51, 15, 649, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 649, DateTimeKind.Local).AddTicks(8136), new DateTime(2020, 9, 13, 2, 51, 15, 649, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 653, DateTimeKind.Local).AddTicks(2581), new DateTime(2020, 9, 13, 2, 51, 15, 653, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 653, DateTimeKind.Local).AddTicks(2975), new DateTime(2020, 9, 13, 2, 51, 15, 653, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 656, DateTimeKind.Local).AddTicks(9481), new DateTime(2020, 9, 13, 2, 51, 15, 656, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 656, DateTimeKind.Local).AddTicks(9944), new DateTime(2020, 9, 13, 2, 51, 15, 656, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 656, DateTimeKind.Local).AddTicks(9980), new DateTime(2020, 9, 13, 2, 51, 15, 656, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 657, DateTimeKind.Local).AddTicks(5), new DateTime(2020, 9, 13, 2, 51, 15, 657, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 657, DateTimeKind.Local).AddTicks(31), new DateTime(2020, 9, 13, 2, 51, 15, 657, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 657, DateTimeKind.Local).AddTicks(60), new DateTime(2020, 9, 13, 2, 51, 15, 657, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(2852), new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(3311), new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(3346), new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(3373), new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(3399), new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(3433), new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(3459), new DateTime(2020, 9, 13, 2, 51, 15, 655, DateTimeKind.Local).AddTicks(3466) });
        }
    }
}
