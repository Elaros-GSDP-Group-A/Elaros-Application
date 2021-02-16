using Microsoft.EntityFrameworkCore.Migrations;

namespace ElarosApp.Migrations
{
    public partial class UpdatedQuestionsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmploymentId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OverallHealthId",
                table: "Questions",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmploymentId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "OverallHealthId",
                table: "Questions");
        }
    }
}
