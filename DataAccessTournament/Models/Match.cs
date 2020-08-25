using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessTournament.Models
{
    public class Match
    {
        [Key]
        public int MatchId { get; set; }

        public int WorkDayId { get; set; }

        public int HomePlayerId { get; set; }

        public int HomeTeamId { get; set; }

        public int HomeGoal { get; set; }

        public int AwayPlayerId { get; set; }

        public int AwayTeamId { get; set; }

        public int AwayGoal { get; set; }

        public bool Played { get; set; }
    }
}
