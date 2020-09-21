using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archieve.Migrations
{
    public partial class userActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserActivities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    IpAddress = table.Column<string>(nullable: true),
                    ActivityDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivities", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 64, DateTimeKind.Local).AddTicks(7877), new DateTime(2020, 9, 20, 17, 22, 48, 64, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 65, DateTimeKind.Local).AddTicks(47), new DateTime(2020, 9, 20, 17, 22, 48, 65, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 65, DateTimeKind.Local).AddTicks(280), new DateTime(2020, 9, 20, 17, 22, 48, 65, DateTimeKind.Local).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 65, DateTimeKind.Local).AddTicks(289), new DateTime(2020, 9, 20, 17, 22, 48, 65, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 62, DateTimeKind.Local).AddTicks(3557), new DateTime(2020, 9, 20, 17, 22, 48, 62, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 63, DateTimeKind.Local).AddTicks(5847), new DateTime(2020, 9, 20, 17, 22, 48, 63, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9449), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9607), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9621), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9631), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9641), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9654), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9664), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9673), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9683), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9724), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9735), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9745), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9754), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9764), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9774), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9784), new DateTime(2020, 9, 20, 17, 22, 48, 68, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 65, DateTimeKind.Local).AddTicks(7515), new DateTime(2020, 9, 20, 17, 22, 48, 65, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 65, DateTimeKind.Local).AddTicks(7788), new DateTime(2020, 9, 20, 17, 22, 48, 65, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 64, DateTimeKind.Local).AddTicks(541), new DateTime(2020, 9, 20, 17, 22, 48, 64, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 64, DateTimeKind.Local).AddTicks(810), new DateTime(2020, 9, 20, 17, 22, 48, 64, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 66, DateTimeKind.Local).AddTicks(1921), new DateTime(2020, 9, 20, 17, 22, 48, 66, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 66, DateTimeKind.Local).AddTicks(2090), new DateTime(2020, 9, 20, 17, 22, 48, 66, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(6852), new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(7006), new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(7021), new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(7031), new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(7041), new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(7053), new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(308), new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(475), new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(489), new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(499), new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(509), new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(524), new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(534), new DateTime(2020, 9, 20, 17, 22, 48, 67, DateTimeKind.Local).AddTicks(537) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserActivities");

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

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2068), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2380), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2403), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2421), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2437), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2458), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2474), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2490), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2506), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2524), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2540), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2556), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2572), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2588), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2604), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "MilitaryRanks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2620), new DateTime(2020, 9, 13, 6, 10, 49, 611, DateTimeKind.Local).AddTicks(2625) });

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
        }
    }
}
