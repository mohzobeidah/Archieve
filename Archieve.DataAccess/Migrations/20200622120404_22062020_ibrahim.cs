using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archieve.DataAccess.Migrations
{
    public partial class _22062020_ibrahim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 22, 15, 4, 3, 962, DateTimeKind.Local).AddTicks(3557), new DateTime(2020, 6, 22, 15, 4, 3, 962, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 22, 15, 4, 3, 962, DateTimeKind.Local).AddTicks(9249), new DateTime(2020, 6, 22, 15, 4, 3, 962, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 22, 15, 4, 3, 958, DateTimeKind.Local).AddTicks(8263), new DateTime(2020, 6, 22, 15, 4, 3, 961, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "InsertDate", "InsertUser", "IsDelete", "StatusName", "UpdateDate", "UpdateUser" },
                values: new object[] { 1, new DateTime(2020, 6, 22, 15, 4, 3, 963, DateTimeKind.Local).AddTicks(8986), null, false, "دوليddd", new DateTime(2020, 6, 22, 15, 4, 3, 963, DateTimeKind.Local).AddTicks(9473), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2020, 6, 22, 0, 46, 33, 500, DateTimeKind.Local).AddTicks(8143), new DateTime(2020, 6, 22, 0, 46, 33, 500, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 22, 0, 46, 33, 501, DateTimeKind.Local).AddTicks(5008), new DateTime(2020, 6, 22, 0, 46, 33, 501, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 6, 22, 0, 46, 33, 496, DateTimeKind.Local).AddTicks(5600), new DateTime(2020, 6, 22, 0, 46, 33, 500, DateTimeKind.Local).AddTicks(1811) });
        }
    }
}
