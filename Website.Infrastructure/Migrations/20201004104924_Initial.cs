using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Website.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MediaContents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    ContentType = table.Column<string>(nullable: false),
                    Content = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    QuestionerName = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Patronymic = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    PictureId = table.Column<Guid>(nullable: true),
                    DepartmentRelationId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentTeacherRelations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DepartmentId = table.Column<Guid>(nullable: false),
                    TeacherId = table.Column<Guid>(nullable: false),
                    TeachingType = table.Column<int>(nullable: false),
                    IsDepartmentHead = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentTeacherRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentTeacherRelations_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentTeacherRelations_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), null, "ИУ-2 КФ" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "AdditionalInfo", "Degree", "DepartmentRelationId", "Name", "Patronymic", "PictureId", "Surname" },
                values: new object[,]
                {
                    { new Guid("c8051737-f9fe-4532-97fe-7030d2e5609d"), null, "кандидат технических наук, доцент", null, "Борсук", "Александровна", null, "Наталья" },
                    { new Guid("b0a631e3-0c97-4bc5-88c0-718ed77d7e94"), null, "кандидат технических наук, доцент", null, "Дерюгина", "Олеговна", null, "Елена" },
                    { new Guid("c6fc9241-51f2-467c-9f59-23f73b358e3f"), null, "кандидат технических наук, доцент", null, "Игорь", "Владимирович", null, "Чухраев" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentTeacherRelations",
                columns: new[] { "Id", "DepartmentId", "IsDepartmentHead", "TeacherId", "TeachingType" },
                values: new object[,]
                {
                    { new Guid("d956fe49-59a3-4221-90b7-c1b8c1bd18e6"), new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), false, new Guid("c8051737-f9fe-4532-97fe-7030d2e5609d"), 0 },
                    { new Guid("1fd6747e-e987-4a5a-b152-6040307eefd4"), new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), false, new Guid("b0a631e3-0c97-4bc5-88c0-718ed77d7e94"), 0 },
                    { new Guid("44557e25-d2c8-4b74-b1bb-e0fc73bd0c7d"), new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), true, new Guid("c6fc9241-51f2-467c-9f59-23f73b358e3f"), 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentTeacherRelations_DepartmentId",
                table: "DepartmentTeacherRelations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentTeacherRelations_TeacherId",
                table: "DepartmentTeacherRelations",
                column: "TeacherId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentTeacherRelations");

            migrationBuilder.DropTable(
                name: "MediaContents");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
