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
                    Surname = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Patronymic = table.Column<string>(nullable: true),
                    PictureId = table.Column<Guid>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    TeachingType = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<Guid>(nullable: true),
                    IsDepartmentHead = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), "Описание кафедры", "ИУ-2 КФ" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "AdditionalInfo", "Degree", "DepartmentId", "IsDepartmentHead", "Name", "Patronymic", "PictureId", "Surname", "TeachingType" },
                values: new object[,]
                {
                    { new Guid("c9a8e876-56c5-4adf-8289-de4bd2b8df44"), null, "кандидат технических наук, доцент", new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), true, "Игорь", "Владимирович", null, "Чухраев", 0 },
                    { new Guid("7955bde0-3005-47b7-bec6-242622a6c786"), null, "кандидат технических наук, доцент", new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), false, "Борсук", "Александровна", null, "Наталья", 0 },
                    { new Guid("b9370356-cc41-4a81-8d37-300660197745"), null, "кандидат технических наук, доцент", new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), false, "Дерюгина", "Олеговна", null, "Елена", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_DepartmentId",
                table: "Teachers",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaContents");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
