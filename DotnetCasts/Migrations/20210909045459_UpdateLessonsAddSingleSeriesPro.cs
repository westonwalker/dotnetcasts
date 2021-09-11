using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetCasts.Migrations
{
    public partial class UpdateLessonsAddSingleSeriesPro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPro",
                table: "Lesson",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSeries",
                table: "Lesson",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSingle",
                table: "Lesson",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPro",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "IsSeries",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "IsSingle",
                table: "Lesson");
        }
    }
}
