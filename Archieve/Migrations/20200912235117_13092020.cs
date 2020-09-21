using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archieve.Migrations
{
    public partial class _13092020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FinanceNumber",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MilitaryRank",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNo",
                table: "AspNetUsers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinanceNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MilitaryRank",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 852, DateTimeKind.Local).AddTicks(511), new DateTime(2020, 9, 12, 23, 23, 54, 852, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 852, DateTimeKind.Local).AddTicks(3512), new DateTime(2020, 9, 12, 23, 23, 54, 852, DateTimeKind.Local).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 852, DateTimeKind.Local).AddTicks(3596), new DateTime(2020, 9, 12, 23, 23, 54, 852, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 852, DateTimeKind.Local).AddTicks(3616), new DateTime(2020, 9, 12, 23, 23, 54, 852, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 221, DateTimeKind.Local).AddTicks(5041), new DateTime(2020, 9, 12, 23, 23, 54, 221, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 847, DateTimeKind.Local).AddTicks(7541), new DateTime(2020, 9, 12, 23, 23, 54, 847, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 853, DateTimeKind.Local).AddTicks(3214), new DateTime(2020, 9, 12, 23, 23, 54, 853, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 853, DateTimeKind.Local).AddTicks(3627), new DateTime(2020, 9, 12, 23, 23, 54, 853, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 850, DateTimeKind.Local).AddTicks(791), new DateTime(2020, 9, 12, 23, 23, 54, 850, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 850, DateTimeKind.Local).AddTicks(1548), new DateTime(2020, 9, 12, 23, 23, 54, 850, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 855, DateTimeKind.Local).AddTicks(6306), new DateTime(2020, 9, 12, 23, 23, 54, 855, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 855, DateTimeKind.Local).AddTicks(6933), new DateTime(2020, 9, 12, 23, 23, 54, 855, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 861, DateTimeKind.Local).AddTicks(174), new DateTime(2020, 9, 12, 23, 23, 54, 861, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 861, DateTimeKind.Local).AddTicks(810), new DateTime(2020, 9, 12, 23, 23, 54, 861, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 861, DateTimeKind.Local).AddTicks(862), new DateTime(2020, 9, 12, 23, 23, 54, 861, DateTimeKind.Local).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 861, DateTimeKind.Local).AddTicks(901), new DateTime(2020, 9, 12, 23, 23, 54, 861, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 861, DateTimeKind.Local).AddTicks(938), new DateTime(2020, 9, 12, 23, 23, 54, 861, DateTimeKind.Local).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 861, DateTimeKind.Local).AddTicks(1024), new DateTime(2020, 9, 12, 23, 23, 54, 861, DateTimeKind.Local).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(1444), new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(2113), new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(2148), new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(2174), new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(2199), new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(2238), new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(2262), new DateTime(2020, 9, 12, 23, 23, 54, 859, DateTimeKind.Local).AddTicks(2269) });
        }
    }
}
