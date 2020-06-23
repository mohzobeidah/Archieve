using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archieve.DataAccess.Migrations
{
    public partial class NEWSTRUCTURE_23_6_2020_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "StructureTypes",
                columns: new[] { "Id", "Description", "InsertDate", "InsertUser", "IsDeleted", "UpdatedDate", "UpdatedUser" },
                values: new object[,]
                {
                    { 6, "اخرى", new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9756), null, false, new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9764), null },
                    { 5, "وحدة", new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9729), null, false, new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9736), null },
                    { 4, "قسم", new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9710), null, false, new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9717), null },
                    { 3, "دائرة", new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9687), null, false, new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9697), null },
                    { 2, "الادارة", new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9606), null, false, new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(9649), null },
                    { 1, "الجهاز", new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(6967), null, false, new DateTime(2020, 6, 23, 13, 1, 12, 204, DateTimeKind.Local).AddTicks(8116), null }
                });

            migrationBuilder.InsertData(
                table: "WorkPlaces",
                columns: new[] { "Id", "FK_WpId", "InsertDate", "InsertUser", "IsDeleted", "ParentId", "Text", "UpdatedDate", "UpdatedUser" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9131), null, false, 1, "المديرية العامة للعمليات المركزية", new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9178), null },
                    { 4, 2, new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9456), null, false, 2, "ادارة الاتصالات", new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9463), null },
                    { 7, 2, new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9524), null, false, 2, "ادارة الامداد", new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9531), null },
                    { 5, 3, new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9475), null, false, 4, "دائرة نظم المعلومات", new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9482), null },
                    { 6, 4, new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9505), null, false, 5, "قسم البرمجة", new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9512), null },
                    { 1, 6, new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(6402), null, false, 0, "عام", new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(7488), null },
                    { 3, 6, new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9425), null, false, 1, "هئيات خارجية", new DateTime(2020, 6, 23, 13, 1, 12, 202, DateTimeKind.Local).AddTicks(9439), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(2704), new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(4221), new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(4269), new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(4281), new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 311, DateTimeKind.Local).AddTicks(6518), new DateTime(2020, 6, 23, 12, 50, 22, 318, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 319, DateTimeKind.Local).AddTicks(6721), new DateTime(2020, 6, 23, 12, 50, 22, 319, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(628), new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(2149), new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 320, DateTimeKind.Local).AddTicks(3339), new DateTime(2020, 6, 23, 12, 50, 22, 320, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 320, DateTimeKind.Local).AddTicks(4982), new DateTime(2020, 6, 23, 12, 50, 22, 320, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(8368), new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(9914), new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(9939) });
        }
    }
}
