using Microsoft.EntityFrameworkCore.Migrations;

namespace ElarosApp.Migrations
{
    public partial class UpdatedQuestionsModelAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActivitiesId",
                table: "Employment",
                newName: "EmploymentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmploymentId",
                table: "Employment",
                newName: "ActivitiesId");
        }
    }
}
