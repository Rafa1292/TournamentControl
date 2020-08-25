using DataAccessTournament.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessTournament
{
    public class Context : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }

        public DbSet<WorkDay> WorkDays { get; set; }

        public DbSet<Match> Matches { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Server=.;Database=FifaContext;Trusted_Connection=True;MultipleActiveResultSets=True;Integrated Security=true");
            }
        }
    }
}
