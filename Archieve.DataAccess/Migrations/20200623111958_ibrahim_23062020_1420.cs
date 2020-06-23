using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archieve.DataAccess.Migrations
{
    public partial class ibrahim_23062020_1420 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 731, DateTimeKind.Local).AddTicks(6977), new DateTime(2020, 6, 23, 14, 19, 57, 731, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 731, DateTimeKind.Local).AddTicks(8071), new DateTime(2020, 6, 23, 14, 19, 57, 731, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 731, DateTimeKind.Local).AddTicks(8106), new DateTime(2020, 6, 23, 14, 19, 57, 731, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 731, DateTimeKind.Local).AddTicks(8114), new DateTime(2020, 6, 23, 14, 19, 57, 731, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 726, DateTimeKind.Local).AddTicks(5145), new DateTime(2020, 6, 23, 14, 19, 57, 729, DateTimeKind.Local).AddTicks(3741) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 730, DateTimeKind.Local).AddTicks(5000), new DateTime(2020, 6, 23, 14, 19, 57, 730, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 732, DateTimeKind.Local).AddTicks(2642), new DateTime(2020, 6, 23, 14, 19, 57, 732, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 732, DateTimeKind.Local).AddTicks(3722), new DateTime(2020, 6, 23, 14, 19, 57, 732, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 731, DateTimeKind.Local).AddTicks(41), new DateTime(2020, 6, 23, 14, 19, 57, 731, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 731, DateTimeKind.Local).AddTicks(1172), new DateTime(2020, 6, 23, 14, 19, 57, 731, DateTimeKind.Local).AddTicks(1194) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 732, DateTimeKind.Local).AddTicks(7883), new DateTime(2020, 6, 23, 14, 19, 57, 732, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 732, DateTimeKind.Local).AddTicks(9150), new DateTime(2020, 6, 23, 14, 19, 57, 732, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 734, DateTimeKind.Local).AddTicks(6829), new DateTime(2020, 6, 23, 14, 19, 57, 734, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 734, DateTimeKind.Local).AddTicks(7941), new DateTime(2020, 6, 23, 14, 19, 57, 734, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 734, DateTimeKind.Local).AddTicks(8025), new DateTime(2020, 6, 23, 14, 19, 57, 734, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 734, DateTimeKind.Local).AddTicks(8036), new DateTime(2020, 6, 23, 14, 19, 57, 734, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 734, DateTimeKind.Local).AddTicks(8044), new DateTime(2020, 6, 23, 14, 19, 57, 734, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 734, DateTimeKind.Local).AddTicks(8054), new DateTime(2020, 6, 23, 14, 19, 57, 734, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(8445), new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(9886), new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(9923), new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(9932), new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(9940), new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(9952), new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(9961), new DateTime(2020, 6, 23, 14, 19, 57, 733, DateTimeKind.Local).AddTicks(9963) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 197, DateTimeKind.Local).AddTicks(4743), new DateTime(2020, 6, 23, 13, 1, 12, 197, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 197, DateTimeKind.Local).AddTicks(7326), new DateTime(2020, 6, 23, 13, 1, 12, 197, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 197, DateTimeKind.Local).AddTicks(7412), new DateTime(2020, 6, 23, 13, 1, 12, 197, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 197, DateTimeKind.Local).AddTicks(7434), new DateTime(2020, 6, 23, 13, 1, 12, 197, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 186, DateTimeKind.Local).AddTicks(9613), new DateTime(2020, 6, 23, 13, 1, 12, 192, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 194, DateTimeKind.Local).AddTicks(6991), new DateTime(2020, 6, 23, 13, 1, 12, 194, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 198, DateTimeKind.Local).AddTicks(7482), new DateTime(2020, 6, 23, 13, 1, 12, 198, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 199, DateTimeKind.Local).AddTicks(63), new DateTime(2020, 6, 23, 13, 1, 12, 199, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 195, DateTimeKind.Local).AddTicks(7756), new DateTime(2020, 6, 23, 13, 1, 12, 195, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 196, DateTimeKind.Local).AddTicks(192), new DateTime(2020, 6, 23, 13, 1, 12, 196, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 199, DateTimeKind.Local).AddTicks(9730), new DateTime(2020, 6, 23, 13, 1, 12, 200, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 200, DateTimeKind.Local).AddTicks(2399), new DateTime(2020, 6, 23, 13, 1, 12, 200, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(6967), new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9606), new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9687), new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9710), new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9729), new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9756), new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(6402), new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9131), new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9425), new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9456), new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9475), new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9505), new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9524), new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9531) });
        }
    }
}
