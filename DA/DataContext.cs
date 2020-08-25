using DA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DA
{
    public class DataContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Match> Matches { get; set; }

        public DbSet<WorkDay> WorkDays { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Server=.;Database=FifaContext;Trusted_Connection=True;MultipleActiveResultSets=True;Integrated Security=true");
            }
        }
    }
}
