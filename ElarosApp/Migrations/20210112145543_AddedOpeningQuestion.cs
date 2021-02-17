using Microsoft.EntityFrameworkCore.Migrations;

namespace ElarosApp.Migrations
{
    public partial class AddedOpeningQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmploymentActivitiesId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpeningQuestionId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OverallHealthId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employment",
                columns: table => new
                {
                    ActivitiesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentBeforeLockdown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentPrecovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentNow = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyOrCarerAdditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnmentionedProblemsPostCovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherClinicalNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment", x => x.ActivitiesId);
                });

            migrationBuilder.CreateTable(
                name: "OpeningQuestion",
                columns: table => new
                {
                    OpeningQuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalProblems = table.Column<bool>(type: "bit", nullable: false),
                    MedicalProblemsDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthServicesUsed = table.Column<bool>(type: "bit", nullable: false),
                    HealthServicesDetails = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningQuestion", x => x.OpeningQuestionId);
                });

            migrationBuilder.CreateTable(
                name: "OverallHealth",
                columns: table => new
                {
                    OverallHealthId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverallHealth", x => x.OverallHealthId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_EmploymentActivitiesId",
                table: "Questions",
                column: "EmploymentActivitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_OpeningQuestionId",
                table: "Questions",
                column: "OpeningQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_OverallHealthId",
                table: "Questions",
                column: "OverallHealthId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Employment_EmploymentActivitiesId",
                table: "Questions",
                column: "EmploymentActivitiesId",
                principalTable: "Employment",
                principalColumn: "ActivitiesId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_OpeningQuestion_OpeningQuestionId",
                table: "Questions",
                column: "OpeningQuestionId",
                principalTable: "OpeningQuestion",
                principalColumn: "OpeningQuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_OverallHealth_OverallHealthId",
                table: "Questions",
                column: "OverallHealthId",
                principalTable: "OverallHealth",
                principalColumn: "OverallHealthId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Employment_EmploymentActivitiesId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_OpeningQuestion_OpeningQuestionId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_OverallHealth_OverallHealthId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Employment");

            migrationBuilder.DropTable(
                name: "OpeningQuestion");

            migrationBuilder.DropTable(
                name: "OverallHealth");

            migrationBuilder.DropIndex(
                name: "IX_Questions_EmploymentActivitiesId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_OpeningQuestionId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_OverallHealthId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "EmploymentActivitiesId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "OpeningQuestionId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "OverallHealthId",
                table: "Questions");
        }
    }
}
