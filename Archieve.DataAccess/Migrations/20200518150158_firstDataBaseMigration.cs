using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archieve.DataAccess.Migrations
{
    public partial class firstDataBaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassificationName = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    InsertUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmpId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(nullable: true),
                    FinID = table.Column<string>(nullable: true),
                    FName = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    SName = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    ThName = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    LName = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    InsertUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "ImageArchives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_MailArchiveID = table.Column<string>(nullable: true),
                    ContentMail = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageArchives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailName = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    MailTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MailTypes_MailTypes_MailTypeId",
                        column: x => x.MailTypeId,
                        principalTable: "MailTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostName = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    PostTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostTypes_PostTypes_PostTypeId",
                        column: x => x.PostTypeId,
                        principalTable: "PostTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Securities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecurityName = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    SecurityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Securities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Securities_Securities_SecurityId",
                        column: x => x.SecurityId,
                        principalTable: "Securities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    StatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statuses_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MailArchives",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailId = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    FK_FromJehazId = table.Column<int>(nullable: false),
                    FK_ToJehazId = table.Column<int>(nullable: true),
                    Topic = table.Column<string>(type: "VARCHAR(4000)", nullable: true),
                    Note = table.Column<string>(type: "VARCHAR(4000)", nullable: true),
                    FK_ClassificationId = table.Column<int>(nullable: true),
                    FK_MailTypeId = table.Column<int>(nullable: false),
                    FK_SecurityId = table.Column<int>(nullable: false),
                    FK_PostTypeId = table.Column<int>(nullable: false),
                    FK_StatusId = table.Column<int>(nullable: false),
                    InsertUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    test = table.Column<string>(nullable: true),
                    ScannedFiles = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailArchives", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MailArchives_Classifications_FK_ClassificationId",
                        column: x => x.FK_ClassificationId,
                        principalTable: "Classifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MailArchives_MailTypes_FK_MailTypeId",
                        column: x => x.FK_MailTypeId,
                        principalTable: "MailTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MailArchives_PostTypes_FK_PostTypeId",
                        column: x => x.FK_PostTypeId,
                        principalTable: "PostTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MailArchives_Securities_FK_SecurityId",
                        column: x => x.FK_SecurityId,
                        principalTable: "Securities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MailArchives_Statuses_FK_StatusId",
                        column: x => x.FK_StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MailArchives_FK_ClassificationId",
                table: "MailArchives",
                column: "FK_ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_MailArchives_FK_MailTypeId",
                table: "MailArchives",
                column: "FK_MailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MailArchives_FK_PostTypeId",
                table: "MailArchives",
                column: "FK_PostTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MailArchives_FK_SecurityId",
                table: "MailArchives",
                column: "FK_SecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_MailArchives_FK_StatusId",
                table: "MailArchives",
                column: "FK_StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MailTypes_MailTypeId",
                table: "MailTypes",
                column: "MailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTypes_PostTypeId",
                table: "PostTypes",
                column: "PostTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Securities_SecurityId",
                table: "Securities",
                column: "SecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_StatusId",
                table: "Statuses",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ImageArchives");

            migrationBuilder.DropTable(
                name: "MailArchives");

            migrationBuilder.DropTable(
                name: "Classifications");

            migrationBuilder.DropTable(
                name: "MailTypes");

            migrationBuilder.DropTable(
                name: "PostTypes");

            migrationBuilder.DropTable(
                name: "Securities");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
