using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessTournament.Migrations
{
    public partial class PlayedFieldToMatcTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Played",
                table: "Matches",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Played",
                table: "Matches");
        }
    }
}
