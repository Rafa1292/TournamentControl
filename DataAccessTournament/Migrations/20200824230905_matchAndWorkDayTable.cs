using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessTournament.Migrations
{
    public partial class matchAndWorkDayTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkDayId = table.Column<int>(nullable: false),
                    HomePlayerId = table.Column<int>(nullable: false),
                    HomeTeamId = table.Column<int>(nullable: false),
                    HomeGoal = table.Column<int>(nullable: false),
                    AwayPlayerId = table.Column<int>(nullable: false),
                    AwayTeamId = table.Column<int>(nullable: false),
                    AwayGoal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchId);
                });

            migrationBuilder.CreateTable(
                name: "WorkDays",
                columns: table => new
                {
                    WorkDayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentId = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    State = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDays", x => x.WorkDayId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "WorkDays");
        }
    }
}
