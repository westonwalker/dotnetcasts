using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetCasts.Migrations
{
    public partial class UpdateLessonsAddTypeColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Lesson",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Lesson",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Lesson");
        }
    }
}
