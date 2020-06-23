using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archieve.DataAccess.Migrations
{
    public partial class NEWSTRUCTURE_23_6_2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClassificationName", "InsertDate", "UpdateDate" },
                values: new object[] { "ترقين قيد ", new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(2704), new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "ClassificationName", "InsertDate", "InsertUser", "IsDelete", "UpdateDate", "UpdateUser" },
                values: new object[,]
                {
                    { 2, " طلب اجازة", new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(4221), null, false, new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(4248), null },
                    { 3, " طلب صيانة", new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(4269), null, false, new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(4274), null },
                    { 4, " اوامر ادارية", new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(4281), null, false, new DateTime(2020, 6, 23, 12, 50, 22, 321, DateTimeKind.Local).AddTicks(4285), null }
                });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "MailName", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 311, DateTimeKind.Local).AddTicks(6518), "داخي", new DateTime(2020, 6, 23, 12, 50, 22, 318, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.InsertData(
                table: "MailTypes",
                columns: new[] { "Id", "InsertDate", "InsertUser", "IsDelete", "MailName", "UpdateDate", "UpdateUser" },
                values: new object[] { 2, new DateTime(2020, 6, 23, 12, 50, 22, 319, DateTimeKind.Local).AddTicks(6721), null, false, "خارجي", new DateTime(2020, 6, 23, 12, 50, 22, 319, DateTimeKind.Local).AddTicks(6755), null });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "PostName", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(628), "صادر", new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.InsertData(
                table: "PostTypes",
                columns: new[] { "Id", "InsertDate", "InsertUser", "IsDelete", "PostName", "UpdateDate", "UpdateUser" },
                values: new object[] { 2, new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(2149), null, false, "وارد", new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(2175), null });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "SecurityName", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 23, 12, 50, 22, 320, DateTimeKind.Local).AddTicks(3339), "عادي", new DateTime(2020, 6, 23, 12, 50, 22, 320, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.InsertData(
                table: "Securities",
                columns: new[] { "Id", "InsertDate", "InsertUser", "IsDelete", "SecurityName", "UpdateDate", "UpdateUser" },
                values: new object[] { 2, new DateTime(2020, 6, 23, 12, 50, 22, 320, DateTimeKind.Local).AddTicks(4982), null, false, "سري", new DateTime(2020, 6, 23, 12, 50, 22, 320, DateTimeKind.Local).AddTicks(5008), null });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "InsertDate", "InsertUser", "IsDelete", "StatusName", "UpdateDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(8368), null, false, "منجر", new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(9067), null },
                    { 2, new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(9914), null, false, "غير منجر", new DateTime(2020, 6, 23, 12, 50, 22, 322, DateTimeKind.Local).AddTicks(9939), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClassificationName", "InsertDate", "UpdateDate" },
                values: new object[] { "دولي ", new DateTime(2020, 6, 22, 0, 46, 33, 500, DateTimeKind.Local).AddTicks(8143), new DateTime(2020, 6, 22, 0, 46, 33, 500, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "MailName", "UpdateDate" },
                values: new object[] { null, "داخي ", null });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "PostName", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 22, 0, 46, 33, 501, DateTimeKind.Local).AddTicks(5008), "دوليddd", new DateTime(2020, 6, 22, 0, 46, 33, 501, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "SecurityName", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 22, 0, 46, 33, 496, DateTimeKind.Local).AddTicks(5600), "سري", new DateTime(2020, 6, 22, 0, 46, 33, 500, DateTimeKind.Local).AddTicks(1811) });
        }
    }
}
