using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archieve.DataAccess.Migrations
{
    public partial class ibrahim_23062020_1450 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 50, DateTimeKind.Local).AddTicks(7933), new DateTime(2020, 6, 23, 14, 50, 36, 50, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 50, DateTimeKind.Local).AddTicks(9033), new DateTime(2020, 6, 23, 14, 50, 36, 50, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 50, DateTimeKind.Local).AddTicks(9069), new DateTime(2020, 6, 23, 14, 50, 36, 50, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 50, DateTimeKind.Local).AddTicks(9077), new DateTime(2020, 6, 23, 14, 50, 36, 50, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 45, DateTimeKind.Local).AddTicks(5779), new DateTime(2020, 6, 23, 14, 50, 36, 48, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 49, DateTimeKind.Local).AddTicks(5861), new DateTime(2020, 6, 23, 14, 50, 36, 49, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 51, DateTimeKind.Local).AddTicks(3259), new DateTime(2020, 6, 23, 14, 50, 36, 51, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 51, DateTimeKind.Local).AddTicks(4321), new DateTime(2020, 6, 23, 14, 50, 36, 51, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 50, DateTimeKind.Local).AddTicks(1246), new DateTime(2020, 6, 23, 14, 50, 36, 50, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 50, DateTimeKind.Local).AddTicks(2368), new DateTime(2020, 6, 23, 14, 50, 36, 50, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 51, DateTimeKind.Local).AddTicks(9645), new DateTime(2020, 6, 23, 14, 50, 36, 51, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "InsertDate", "InsertUser", "IsDelete", "StatusName", "UpdateDate", "UpdateUser" },
                values: new object[] { 11, new DateTime(2020, 6, 23, 14, 50, 36, 51, DateTimeKind.Local).AddTicks(8539), null, false, "منجر", new DateTime(2020, 6, 23, 14, 50, 36, 51, DateTimeKind.Local).AddTicks(9061), null });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(7151), new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(8468), new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(8507), new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(8516), new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(8524), new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(8535), new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 52, DateTimeKind.Local).AddTicks(9079), new DateTime(2020, 6, 23, 14, 50, 36, 52, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(262), new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(296), new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(306), new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(313), new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(369), new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(379), new DateTime(2020, 6, 23, 14, 50, 36, 53, DateTimeKind.Local).AddTicks(382) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 11);

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
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 14, 19, 57, 732, DateTimeKind.Local).AddTicks(9150), new DateTime(2020, 6, 23, 14, 19, 57, 732, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "InsertDate", "InsertUser", "IsDelete", "StatusName", "UpdateDate", "UpdateUser" },
                values: new object[] { 1, new DateTime(2020, 6, 23, 14, 19, 57, 732, DateTimeKind.Local).AddTicks(7883), null, false, "منجر", new DateTime(2020, 6, 23, 14, 19, 57, 732, DateTimeKind.Local).AddTicks(8367), null });

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
    }
}
