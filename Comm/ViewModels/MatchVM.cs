using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comm.ViewModels
{
    public class MatchVM
    {
        public int MatchId { get; set; }

        public int WorkDayId { get; set; }

        public int HomePlayerId { get; set; }

        public int HomeTeamId { get; set; }

        public int HomeGoal { get; set; }

        public int AwayPlayerId { get; set; }

        public int AwayTeamId { get; set; }

        public int AwayGoal { get; set; }

        public bool Played { get; set; }

        public PlayerVM HomePlayer { get; set; }

        public PlayerVM AwayPlayer { get; set; }
    }
}
