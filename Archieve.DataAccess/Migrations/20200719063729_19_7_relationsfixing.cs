using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archieve.DataAccess.Migrations
{
    public partial class _19_7_relationsfixing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassificationName = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
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
                    FName = table.Column<string>(nullable: true),
                    SName = table.Column<string>(nullable: true),
                    ThName = table.Column<string>(nullable: true),
                    LName = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "MailTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailName = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostName = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Securities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecurityName = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Securities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StructureTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdatedUser = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeletedd = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructureTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    FK_WpId = table.Column<int>(nullable: false),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdatedUser = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeletedd = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPlaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkPlaces_StructureTypes_FK_WpId",
                        column: x => x.FK_WpId,
                        principalTable: "StructureTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FK_JehazId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_WorkPlaces_FK_JehazId",
                        column: x => x.FK_JehazId,
                        principalTable: "WorkPlaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MailArchives",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailId = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Topic = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    ArchiveDate = table.Column<DateTime>(nullable: true),
                    FK_ClassificationId = table.Column<int>(nullable: true),
                    FK_MailTypeId = table.Column<int>(nullable: true),
                    FK_SecurityId = table.Column<int>(nullable: true),
                    FK_PostTypeId = table.Column<int>(nullable: false),
                    FK_StatusId = table.Column<int>(nullable: false),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    FK_User = table.Column<string>(nullable: true),
                    WorkPlaceId = table.Column<int>(nullable: true),
                    WorkPlaceId1 = table.Column<int>(nullable: true)
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MailArchives_Statuses_FK_StatusId",
                        column: x => x.FK_StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MailArchives_AspNetUsers_FK_User",
                        column: x => x.FK_User,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MailArchives_WorkPlaces_WorkPlaceId",
                        column: x => x.WorkPlaceId,
                        principalTable: "WorkPlaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MailArchives_WorkPlaces_WorkPlaceId1",
                        column: x => x.WorkPlaceId1,
                        principalTable: "WorkPlaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageArchives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_MailArchiveID = table.Column<int>(nullable: false),
                    ContentMail = table.Column<byte[]>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeletedd = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageArchives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageArchives_MailArchives_FK_MailArchiveID",
                        column: x => x.FK_MailArchiveID,
                        principalTable: "MailArchives",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "ClassificationName", "InsertDate", "InsertUser", "IsDeleted", "UpdatedDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, "ترقين قيد ", new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(3007), null, false, new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(3843), null },
                    { 2, " طلب اجازة", new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(4845), null, false, new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(4876), null },
                    { 3, " طلب صيانة", new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(4900), null, false, new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(4906), null },
                    { 4, " اوامر ادارية", new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(4914), null, false, new DateTime(2020, 7, 19, 9, 37, 28, 979, DateTimeKind.Local).AddTicks(4919), null }
                });

            migrationBuilder.InsertData(
                table: "MailTypes",
                columns: new[] { "Id", "InsertDate", "InsertUser", "IsDeleted", "MailName", "UpdatedDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 19, 9, 37, 28, 971, DateTimeKind.Local).AddTicks(4206), null, false, "داخي", new DateTime(2020, 7, 19, 9, 37, 28, 975, DateTimeKind.Local).AddTicks(4001), null },
                    { 2, new DateTime(2020, 7, 19, 9, 37, 28, 977, DateTimeKind.Local).AddTicks(3400), null, false, "خارجي", new DateTime(2020, 7, 19, 9, 37, 28, 977, DateTimeKind.Local).AddTicks(3463), null }
                });

            migrationBuilder.InsertData(
                table: "PostTypes",
                columns: new[] { "Id", "InsertDate", "InsertUser", "IsDeleted", "PostName", "UpdatedDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 19, 9, 37, 28, 980, DateTimeKind.Local).AddTicks(3606), null, false, "صادر", new DateTime(2020, 7, 19, 9, 37, 28, 980, DateTimeKind.Local).AddTicks(4537), null },
                    { 2, new DateTime(2020, 7, 19, 9, 37, 28, 980, DateTimeKind.Local).AddTicks(5606), null, false, "وارد", new DateTime(2020, 7, 19, 9, 37, 28, 980, DateTimeKind.Local).AddTicks(5636), null }
                });

            migrationBuilder.InsertData(
                table: "Securities",
                columns: new[] { "Id", "InsertDate", "InsertUser", "IsDeleted", "SecurityName", "UpdatedDate", "UpdateUser" },
                values: new object[,]
                {
                    { 2, new DateTime(2020, 7, 19, 9, 37, 28, 978, DateTimeKind.Local).AddTicks(3612), null, false, "سري", new DateTime(2020, 7, 19, 9, 37, 28, 978, DateTimeKind.Local).AddTicks(3642), null },
                    { 1, new DateTime(2020, 7, 19, 9, 37, 28, 978, DateTimeKind.Local).AddTicks(1731), null, false, "عادي", new DateTime(2020, 7, 19, 9, 37, 28, 978, DateTimeKind.Local).AddTicks(2579), null }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "InsertDate", "InsertUser", "IsDeleted", "StatusName", "UpdatedDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 19, 9, 37, 28, 981, DateTimeKind.Local).AddTicks(6114), null, false, "منجر", new DateTime(2020, 7, 19, 9, 37, 28, 981, DateTimeKind.Local).AddTicks(7709), null },
                    { 2, new DateTime(2020, 7, 19, 9, 37, 28, 982, DateTimeKind.Local).AddTicks(370), null, false, "غير منجر", new DateTime(2020, 7, 19, 9, 37, 28, 982, DateTimeKind.Local).AddTicks(431), null }
                });

            migrationBuilder.InsertData(
                table: "StructureTypes",
                columns: new[] { "Id", "Description", "InsertDate", "InsertUser", "IsDeletedd", "UpdatedDate", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, "الجهاز", new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(5393), null, false, new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(6233), null },
                    { 2, "الادارة", new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7301), null, false, new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7331), null },
                    { 3, "دائرة", new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7358), null, false, new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7363), null },
                    { 4, "قسم", new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7372), null, false, new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7376), null },
                    { 5, "وحدة", new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7385), null, false, new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7390), null },
                    { 6, "اخرى", new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7404), null, false, new DateTime(2020, 7, 19, 9, 37, 28, 985, DateTimeKind.Local).AddTicks(7409), null }
                });

            migrationBuilder.InsertData(
                table: "WorkPlaces",
                columns: new[] { "Id", "FK_WpId", "InsertDate", "InsertUser", "IsDeletedd", "ParentId", "Text", "UpdatedDate", "UpdatedUser" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1255), null, false, 1, "المديرية العامة للعمليات المركزية", new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1289), null },
                    { 4, 2, new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1336), null, false, 2, "ادارة الاتصالات", new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1341), null },
                    { 7, 2, new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1397), null, false, 2, "ادارة الامداد", new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1402), null },
                    { 5, 3, new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1349), null, false, 4, "دائرة نظم المعلومات", new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1368), null },
                    { 6, 4, new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1383), null, false, 5, "قسم البرمجة", new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1388), null },
                    { 1, 6, new DateTime(2020, 7, 19, 9, 37, 28, 983, DateTimeKind.Local).AddTicks(9156), null, false, 0, "عام", new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(19), null },
                    { 3, 6, new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1320), null, false, 1, "هئيات خارجية", new DateTime(2020, 7, 19, 9, 37, 28, 984, DateTimeKind.Local).AddTicks(1327), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FK_JehazId",
                table: "AspNetUsers",
                column: "FK_JehazId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ImageArchives_FK_MailArchiveID",
                table: "ImageArchives",
                column: "FK_MailArchiveID");

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
                name: "IX_MailArchives_FK_User",
                table: "MailArchives",
                column: "FK_User");

            migrationBuilder.CreateIndex(
                name: "IX_MailArchives_WorkPlaceId",
                table: "MailArchives",
                column: "WorkPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_MailArchives_WorkPlaceId1",
                table: "MailArchives",
                column: "WorkPlaceId1");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlaces_FK_WpId",
                table: "WorkPlaces",
                column: "FK_WpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ImageArchives");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

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

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "WorkPlaces");

            migrationBuilder.DropTable(
                name: "StructureTypes");
        }
    }
}
