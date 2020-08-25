using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comm.ViewModels
{
    public class TournamentVM
    {
        public int TournamentId { get; set; }

        public string Name { get; set; }

        public string StateDescription { get; set; }

        public List<PlayerVM> Players { get; set; }

        public List<WorkDayVM> WorkDays { get; set; }
    }
}
