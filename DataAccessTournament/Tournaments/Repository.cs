using DataAccessTournament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessTournament.Tournaments
{
    public class Repository
    {
        public static List<Tournament> GetAll()
        {
            try
            {
                using (var db = new Context())
                {
                    var tournaments = db.Tournaments.ToList();
                    return tournaments;
                }
            }
            catch (Exception e)
            {
                return new List<Tournament>();
            }

        }

        public static Tournament Get(int tournamentId)
        {
            try
            {
                using (var db = new Context())
                {
                    var tournament = db.Tournaments.Find(tournamentId);
                    return tournament;
                }
            }
            catch (Exception e)
            {
                return new Tournament();
            }

        }

        public static int Insert(Tournament tournament)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Tournaments.Add(tournament);
                    db.SaveChanges();
                    return tournament.TournamentId;
                }
            }
            catch (Exception e)
            {
                return 0;
            }

        }

    }
}
