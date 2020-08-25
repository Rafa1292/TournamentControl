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
                options.UseSqlServer(@"Server=tcp:fifa.database.windows.net,1433;Initial Catalog=fifa;Persist Security Info=False;User ID=rvilla;Password=rafavilla2013.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}
