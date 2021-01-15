using Microsoft.EntityFrameworkCore.Migrations;

namespace ElarosApp.Migrations
{
    public partial class UpdatePatientModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentQuestion",
                table: "Patients");

            migrationBuilder.AddColumn<bool>(
                name: "FinishedQuestionniare",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinishedQuestionniare",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "CurrentQuestion",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
