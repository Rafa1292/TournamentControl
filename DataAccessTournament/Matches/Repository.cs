using DataAccessTournament.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessTournament.Matches
{
    public class Repository
    {
        public static bool Insert(Match match)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Matches.Add(match);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }


        public static List<Match> GetMatchesByWorkDay(int workDayId)
        {
            try
            {
                using (var db = new Context())
                {
                    var matches = db.Matches.Where(x => x.WorkDayId == workDayId).ToList();
                    return matches;
                }
            }
            catch (Exception e)
            {
                return new List<Match>();
            }
        }

        public static bool Update(Match match)
        {
            try
            {
                using (var db = new Context())
                {
                     db.Entry(match).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static List<Match> GetMatchesByWorkDay()
        {
            try
            {
                using (var db = new Context())
                {
                    var matches = db.Matches.OrderByDescending(x => x.MatchId).ToList();
                    return matches;
                }
            }
            catch (Exception e)
            {
                return new List<Match>();
            }
        }
    }
}
