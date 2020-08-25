using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comm.ViewModels
{
    public class PositionTable
    {
        public PlayerVM Player { get; set; }
        public int MatchPlayed { get; set; }
        public int MatchWon { get; set; }
        public int TiedMatch { get; set; }
        public int LostMatch { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalsDiference { get; set; }
        public int Points { get; set; }

        public int PlayerId { get; set; }

    }
}
