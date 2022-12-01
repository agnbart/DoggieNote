using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoggieNote.Migrations
{
    public partial class InitRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompetitionId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CompetitionId",
                table: "Courses",
                column: "CompetitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Competitions_CompetitionId",
                table: "Courses",
                column: "CompetitionId",
                principalTable: "Competitions",
                principalColumn: "CompetitionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Competitions_CompetitionId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CompetitionId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CompetitionId",
                table: "Courses");
        }
    }
}
