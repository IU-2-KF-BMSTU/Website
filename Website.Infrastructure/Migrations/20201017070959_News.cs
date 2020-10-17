using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Website.Infrastructure.Migrations
{
    public partial class News : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("7955bde0-3005-47b7-bec6-242622a6c786"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("b9370356-cc41-4a81-8d37-300660197745"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("c9a8e876-56c5-4adf-8289-de4bd2b8df44"));

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PublicationDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: false),
                    ImagesIds = table.Column<Guid[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "AdditionalInfo", "Degree", "DepartmentId", "IsDepartmentHead", "Name", "Patronymic", "PictureId", "Surname", "TeachingType" },
                values: new object[,]
                {
                    { new Guid("45434bf3-8778-4a9b-b209-ef7e28580f3f"), null, "кандидат технических наук, доцент", new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), true, "Игорь", "Владимирович", null, "Чухраев", 0 },
                    { new Guid("ef598232-6965-47b2-8982-5468fd02d394"), null, "кандидат технических наук, доцент", new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), false, "Борсук", "Александровна", null, "Наталья", 0 },
                    { new Guid("a989eeb9-51ee-4882-a028-c070ecb52e60"), null, "кандидат технических наук, доцент", new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), false, "Дерюгина", "Олеговна", null, "Елена", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("45434bf3-8778-4a9b-b209-ef7e28580f3f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a989eeb9-51ee-4882-a028-c070ecb52e60"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("ef598232-6965-47b2-8982-5468fd02d394"));

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "AdditionalInfo", "Degree", "DepartmentId", "IsDepartmentHead", "Name", "Patronymic", "PictureId", "Surname", "TeachingType" },
                values: new object[,]
                {
                    { new Guid("c9a8e876-56c5-4adf-8289-de4bd2b8df44"), null, "кандидат технических наук, доцент", new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), true, "Игорь", "Владимирович", null, "Чухраев", 0 },
                    { new Guid("7955bde0-3005-47b7-bec6-242622a6c786"), null, "кандидат технических наук, доцент", new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), false, "Борсук", "Александровна", null, "Наталья", 0 },
                    { new Guid("b9370356-cc41-4a81-8d37-300660197745"), null, "кандидат технических наук, доцент", new Guid("175f26be-6bbf-45be-932d-9b312f545c94"), false, "Дерюгина", "Олеговна", null, "Елена", 0 }
                });
        }
    }
}
