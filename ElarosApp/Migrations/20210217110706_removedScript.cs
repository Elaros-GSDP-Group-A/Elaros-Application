using Microsoft.EntityFrameworkCore.Migrations;

namespace ElarosApp.Migrations
{
    public partial class removedScript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OverallHealthId",
                table: "Questions",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OverallHealthId",
                table: "Questions");
        }
    }
}
