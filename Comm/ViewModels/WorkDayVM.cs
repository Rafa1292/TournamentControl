using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comm.ViewModels
{
    public class WorkDayVM
    {
        public int WorkDayId { get; set; }

        public int TournamentId { get; set; }

        public int Number { get; set; }

        public bool State { get; set; }

        public List<MatchVM> Matches { get; set; }

    }
}
