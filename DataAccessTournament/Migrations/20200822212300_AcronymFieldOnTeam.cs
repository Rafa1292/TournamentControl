using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessTournament.Migrations
{
    public partial class AcronymFieldOnTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Acronym",
                table: "Teams",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acronym",
                table: "Teams");
        }
    }
}
