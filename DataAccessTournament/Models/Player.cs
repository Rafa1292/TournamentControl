using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessTournament.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }
    }
}
