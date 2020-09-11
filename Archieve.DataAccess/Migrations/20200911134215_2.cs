using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archieve.DataAccess.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MailArchives_WorkPlaces_FK_FromJehazId",
                table: "MailArchives");

            migrationBuilder.DropForeignKey(
                name: "FK_MailArchives_WorkPlaces_FK_ToJehazId",
                table: "MailArchives");

            migrationBuilder.DropColumn(
                name: "IsDeletedd",
                table: "WorkPlaces");

            migrationBuilder.DropColumn(
                name: "UpdatedUser",
                table: "WorkPlaces");

            migrationBuilder.DropColumn(
                name: "IsDeletedd",
                table: "StructureTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedUser",
                table: "StructureTypes");

            migrationBuilder.DropColumn(
                name: "IsDeletedd",
                table: "ImageArchives");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WorkPlaces",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "WorkPlaces",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StructureTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "StructureTypes",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FK_ToJehazId",
                table: "MailArchives",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FK_FromJehazId",
                table: "MailArchives",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UserWorkPlaceID",
                table: "MailArchives",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ImageArchives",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FourthName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdentityNumber",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecondName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MangerDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    WorkPlaceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangerDepartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MangerDepartment_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MangerDepartment_WorkPlaces_WorkPlaceId",
                        column: x => x.WorkPlaceId,
                        principalTable: "WorkPlaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 551, DateTimeKind.Local).AddTicks(7780), new DateTime(2020, 9, 11, 16, 42, 14, 551, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 551, DateTimeKind.Local).AddTicks(9343), new DateTime(2020, 9, 11, 16, 42, 14, 551, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 551, DateTimeKind.Local).AddTicks(9384), new DateTime(2020, 9, 11, 16, 42, 14, 551, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 551, DateTimeKind.Local).AddTicks(9396), new DateTime(2020, 9, 11, 16, 42, 14, 551, DateTimeKind.Local).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 548, DateTimeKind.Local).AddTicks(859), new DateTime(2020, 9, 11, 16, 42, 14, 548, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 550, DateTimeKind.Local).AddTicks(200), new DateTime(2020, 9, 11, 16, 42, 14, 550, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 552, DateTimeKind.Local).AddTicks(4996), new DateTime(2020, 9, 11, 16, 42, 14, 552, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 552, DateTimeKind.Local).AddTicks(5223), new DateTime(2020, 9, 11, 16, 42, 14, 552, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 550, DateTimeKind.Local).AddTicks(6663), new DateTime(2020, 9, 11, 16, 42, 14, 550, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 550, DateTimeKind.Local).AddTicks(6910), new DateTime(2020, 9, 11, 16, 42, 14, 550, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 553, DateTimeKind.Local).AddTicks(770), new DateTime(2020, 9, 11, 16, 42, 14, 553, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 553, DateTimeKind.Local).AddTicks(995), new DateTime(2020, 9, 11, 16, 42, 14, 553, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 555, DateTimeKind.Local).AddTicks(2778), new DateTime(2020, 9, 11, 16, 42, 14, 555, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 555, DateTimeKind.Local).AddTicks(3012), new DateTime(2020, 9, 11, 16, 42, 14, 555, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 555, DateTimeKind.Local).AddTicks(3031), new DateTime(2020, 9, 11, 16, 42, 14, 555, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 555, DateTimeKind.Local).AddTicks(3046), new DateTime(2020, 9, 11, 16, 42, 14, 555, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 555, DateTimeKind.Local).AddTicks(3060), new DateTime(2020, 9, 11, 16, 42, 14, 555, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 555, DateTimeKind.Local).AddTicks(3079), new DateTime(2020, 9, 11, 16, 42, 14, 555, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3161), new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3402), new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3421), new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3435), new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3450), new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3468), new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3482), new DateTime(2020, 9, 11, 16, 42, 14, 554, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.CreateIndex(
                name: "IX_MailArchives_UserWorkPlaceID",
                table: "MailArchives",
                column: "UserWorkPlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_MangerDepartment_UserId",
                table: "MangerDepartment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MangerDepartment_WorkPlaceId",
                table: "MangerDepartment",
                column: "WorkPlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_MailArchives_WorkPlaces_FK_FromJehazId",
                table: "MailArchives",
                column: "FK_FromJehazId",
                principalTable: "WorkPlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MailArchives_WorkPlaces_FK_ToJehazId",
                table: "MailArchives",
                column: "FK_ToJehazId",
                principalTable: "WorkPlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MailArchives_WorkPlaces_UserWorkPlaceID",
                table: "MailArchives",
                column: "UserWorkPlaceID",
                principalTable: "WorkPlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MailArchives_WorkPlaces_FK_FromJehazId",
                table: "MailArchives");

            migrationBuilder.DropForeignKey(
                name: "FK_MailArchives_WorkPlaces_FK_ToJehazId",
                table: "MailArchives");

            migrationBuilder.DropForeignKey(
                name: "FK_MailArchives_WorkPlaces_UserWorkPlaceID",
                table: "MailArchives");

            migrationBuilder.DropTable(
                name: "MangerDepartment");

            migrationBuilder.DropIndex(
                name: "IX_MailArchives_UserWorkPlaceID",
                table: "MailArchives");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WorkPlaces");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "WorkPlaces");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StructureTypes");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "StructureTypes");

            migrationBuilder.DropColumn(
                name: "UserWorkPlaceID",
                table: "MailArchives");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ImageArchives");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FourthName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdentityNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecondName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ThirdName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeletedd",
                table: "WorkPlaces",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedUser",
                table: "WorkPlaces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeletedd",
                table: "StructureTypes",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedUser",
                table: "StructureTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FK_ToJehazId",
                table: "MailArchives",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FK_FromJehazId",
                table: "MailArchives",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeletedd",
                table: "ImageArchives",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(6664), new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(8179), new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(8241), new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(8262), new DateTime(2020, 9, 7, 22, 56, 31, 742, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 734, DateTimeKind.Local).AddTicks(5072), new DateTime(2020, 9, 7, 22, 56, 31, 738, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "MailTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 740, DateTimeKind.Local).AddTicks(9602), new DateTime(2020, 9, 7, 22, 56, 31, 740, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 743, DateTimeKind.Local).AddTicks(5625), new DateTime(2020, 9, 7, 22, 56, 31, 743, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 743, DateTimeKind.Local).AddTicks(7055), new DateTime(2020, 9, 7, 22, 56, 31, 743, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 741, DateTimeKind.Local).AddTicks(5037), new DateTime(2020, 9, 7, 22, 56, 31, 741, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Securities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 741, DateTimeKind.Local).AddTicks(6149), new DateTime(2020, 9, 7, 22, 56, 31, 741, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 744, DateTimeKind.Local).AddTicks(4098), new DateTime(2020, 9, 7, 22, 56, 31, 744, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 744, DateTimeKind.Local).AddTicks(6034), new DateTime(2020, 9, 7, 22, 56, 31, 744, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "IsDeletedd", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(2831), false, new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "IsDeletedd", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4574), false, new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "IsDeletedd", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4643), false, new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "IsDeletedd", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4663), false, new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "IsDeletedd", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4683), false, new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "StructureTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "IsDeletedd", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4711), false, new DateTime(2020, 9, 7, 22, 56, 31, 748, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "IsDeletedd", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(3654), false, new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "IsDeletedd", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5807), false, new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "IsDeletedd", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5881), false, new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "IsDeletedd", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5901), false, new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertDate", "IsDeletedd", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5918), false, new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertDate", "IsDeletedd", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5946), false, new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "WorkPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertDate", "IsDeletedd", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5966), false, new DateTime(2020, 9, 7, 22, 56, 31, 746, DateTimeKind.Local).AddTicks(5972) });

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
