using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessTournament.Models
{
    public class Tournament
    {
        [Key]
        public int TournamentId { get; set; }

        public string Name { get; set; }

        public string StateDescription { get; set; }
    }
}
