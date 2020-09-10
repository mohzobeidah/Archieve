using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archieve.DataAccess.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MailArchives_WorkPlaces_WorkPlaceId",
                table: "MailArchives");

            migrationBuilder.DropForeignKey(
                name: "FK_MailArchives_WorkPlaces_WorkPlaceId1",
                table: "MailArchives");

            migrationBuilder.DropIndex(
                name: "IX_MailArchives_WorkPlaceId",
                table: "MailArchives");

            migrationBuilder.DropIndex(
                name: "IX_MailArchives_WorkPlaceId1",
                table: "MailArchives");

            migrationBuilder.DropColumn(
                name: "WorkPlaceId",
                table: "MailArchives");

            migrationBuilder.DropColumn(
                name: "WorkPlaceId1",
                table: "MailArchives");

            migrationBuilder.AddColumn<int>(
                name: "FK_FromJehazId",
                table: "MailArchives",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FK_ToJehazId",
                table: "MailArchives",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(6664), new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(8179), new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(8241), new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(8262), new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 734, DateTimeKind.Local).AddTicks(5072), new DateTime(2020, 9, 7, 22, 56, 31, 738, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 740, DateTimeKind.Local).AddTicks(9602), new DateTime(2020, 9, 7, 22, 56, 31, 740, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 743, DateTimeKind.Local).AddTicks(5625), new DateTime(2020, 9, 7, 22, 56, 31, 743, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 743, DateTimeKind.Local).AddTicks(7055), new DateTime(2020, 9, 7, 22, 56, 31, 743, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 741, DateTimeKind.Local).AddTicks(5037), new DateTime(2020, 9, 7, 22, 56, 31, 741, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 741, DateTimeKind.Local).AddTicks(6149), new DateTime(2020, 9, 7, 22, 56, 31, 741, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 744, DateTimeKind.Local).AddTicks(4098), new DateTime(2020, 9, 7, 22, 56, 31, 744, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 744, DateTimeKind.Local).AddTicks(6034), new DateTime(2020, 9, 7, 22, 56, 31, 744, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(2831), new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4574), new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4643), new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4663), new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4683), new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4711), new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(3654), new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5807), new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5881), new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5901), new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5918), new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5946), new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5966), new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.CreateIndex(
                name: "IX_MailArchives_FK_FromJehazId",
                table: "MailArchives",
                column: "FK_FromJehazId");

            migrationBuilder.CreateIndex(
                name: "IX_MailArchives_FK_ToJehazId",
                table: "MailArchives",
                column: "FK_ToJehazId");

            migrationBuilder.AddForeignKey(
                name: "FK_MailArchives_WorkPlaces_FK_FromJehazId",
                table: "MailArchives",
                column: "FK_FromJehazId",
                principalTable: "WorkPlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MailArchives_WorkPlaces_FK_ToJehazId",
                table: "MailArchives",
                column: "FK_ToJehazId",
                principalTable: "WorkPlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MailArchives_WorkPlaces_FK_FromJehazId",
                table: "MailArchives");

            migrationBuilder.DropForeignKey(
                name: "FK_MailArchives_WorkPlaces_FK_ToJehazId",
                table: "MailArchives");

            migrationBuilder.DropIndex(
                name: "IX_MailArchives_FK_FromJehazId",
                table: "MailArchives");

            migrationBuilder.DropIndex(
                name: "IX_MailArchives_FK_ToJehazId",
                table: "MailArchives");

            migrationBuilder.DropColumn(
                name: "FK_FromJehazId",
                table: "MailArchives");

            migrationBuilder.DropColumn(
                name: "FK_ToJehazId",
                table: "MailArchives");

            migrationBuilder.AddColumn<int>(
                name: "WorkPlaceId",
                table: "MailArchives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkPlaceId1",
                table: "MailArchives",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(1628), new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(3848), new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(3906), new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(3920), new DateTime(2020, 7, 19, 10, 3, 52, 906, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 895, DateTimeKind.Local).AddTicks(7683), new DateTime(2020, 7, 19, 10, 3, 52, 901, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 903, DateTimeKind.Local).AddTicks(8060), new DateTime(2020, 7, 19, 10, 3, 52, 903, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 907, DateTimeKind.Local).AddTicks(3742), new DateTime(2020, 7, 19, 10, 3, 52, 907, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 907, DateTimeKind.Local).AddTicks(8814), new DateTime(2020, 7, 19, 10, 3, 52, 907, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 904, DateTimeKind.Local).AddTicks(7341), new DateTime(2020, 7, 19, 10, 3, 52, 904, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 904, DateTimeKind.Local).AddTicks(9910), new DateTime(2020, 7, 19, 10, 3, 52, 904, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 7, 19, 10, 3, 52, 908, DateTimeKind.Local).AddTicks(8355), new DateTime(2020, 7, 19, 10, 3, 52, 908, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
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

            migrationBuilder.CreateIndex(
                name: "IX_MailArchives_WorkPlaceId",
                table: "MailArchives",
                column: "WorkPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_MailArchives_WorkPlaceId1",
                table: "MailArchives",
                column: "WorkPlaceId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MailArchives_WorkPlaces_WorkPlaceId",
                table: "MailArchives",
                column: "WorkPlaceId",
                principalTable: "WorkPlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MailArchives_WorkPlaces_WorkPlaceId1",
                table: "MailArchives",
                column: "WorkPlaceId1",
                principalTable: "WorkPlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
