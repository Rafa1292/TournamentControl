using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessTournament.Models
{
    public class WorkDay
    {
        [Key]
        public int WorkDayId { get; set; }

        public int TournamentId { get; set; }

        public int Number { get; set; }

        public bool State { get; set; }
    }
}
