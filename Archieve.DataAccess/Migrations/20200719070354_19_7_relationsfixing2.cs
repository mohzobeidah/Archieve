using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archieve.DataAccess.Migrations
{
    public partial class _19_7_relationsfixing2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(1628), new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(3848), new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(3906), new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(3920), new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 895, DateTimeKind.Local).AddTicks(7683), new DateTime(2020, 7, 19, 10, 3, 52, 901, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 903, DateTimeKind.Local).AddTicks(8060), new DateTime(2020, 7, 19, 10, 3, 52, 903, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 907, DateTimeKind.Local).AddTicks(3742), new DateTime(2020, 7, 19, 10, 3, 52, 907, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 907, DateTimeKind.Local).AddTicks(8814), new DateTime(2020, 7, 19, 10, 3, 52, 907, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 904, DateTimeKind.Local).AddTicks(7341), new DateTime(2020, 7, 19, 10, 3, 52, 904, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 904, DateTimeKind.Local).AddTicks(9910), new DateTime(2020, 7, 19, 10, 3, 52, 904, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 908, DateTimeKind.Local).AddTicks(8355), new DateTime(2020, 7, 19, 10, 3, 52, 908, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 909, DateTimeKind.Local).AddTicks(690), new DateTime(2020, 7, 19, 10, 3, 52, 909, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 912, DateTimeKind.Local).AddTicks(9844), new DateTime(2020, 7, 19, 10, 3, 52, 913, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 913, DateTimeKind.Local).AddTicks(1965), new DateTime(2020, 7, 19, 10, 3, 52, 913, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 913, DateTimeKind.Local).AddTicks(2016), new DateTime(2020, 7, 19, 10, 3, 52, 913, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 913, DateTimeKind.Local).AddTicks(2031), new DateTime(2020, 7, 19, 10, 3, 52, 913, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 913, DateTimeKind.Local).AddTicks(2044), new DateTime(2020, 7, 19, 10, 3, 52, 913, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 913, DateTimeKind.Local).AddTicks(2063), new DateTime(2020, 7, 19, 10, 3, 52, 913, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(4439), new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(6639), new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(6698), new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(6714), new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(6728), new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(6747), new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(6760), new DateTime(2020, 7, 19, 10, 3, 52, 911, DateTimeKind.Local).AddTicks(6766) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(3007), new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(4845), new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(4900), new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(4914), new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 971, DateTimeKind.Local).AddTicks(4206), new DateTime(2020, 7, 19, 9, 37, 28, 975, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 977, DateTimeKind.Local).AddTicks(3400), new DateTime(2020, 7, 19, 9, 37, 28, 977, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 980, DateTimeKind.Local).AddTicks(3606), new DateTime(2020, 7, 19, 9, 37, 28, 980, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 980, DateTimeKind.Local).AddTicks(5606), new DateTime(2020, 7, 19, 9, 37, 28, 980, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 978, DateTimeKind.Local).AddTicks(1731), new DateTime(2020, 7, 19, 9, 37, 28, 978, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 978, DateTimeKind.Local).AddTicks(3612), new DateTime(2020, 7, 19, 9, 37, 28, 978, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 981, DateTimeKind.Local).AddTicks(6114), new DateTime(2020, 7, 19, 9, 37, 28, 981, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 982, DateTimeKind.Local).AddTicks(370), new DateTime(2020, 7, 19, 9, 37, 28, 982, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(5393), new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7301), new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7358), new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7372), new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7385), new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7404), new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 983, DateTimeKind.Local).AddTicks(9156), new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1255), new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1320), new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1336), new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1349), new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1383), new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1397), new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1402) });
        }
    }
}
