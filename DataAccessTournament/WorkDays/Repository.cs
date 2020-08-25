using DataAccessTournament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessTournament.WorkDays
{
    public class Repository
    {
        public static int Insert(WorkDay workDay)
        {
            try
            {
                using (var db = new Context())
                {
                    db.WorkDays.Add(workDay);
                    db.SaveChanges();
                    return workDay.WorkDayId;
                }
            }
            catch (Exception e)
            {
                return 0;
            }

        }

        public static List<WorkDay> GetWorkDays(int tournamentId)
        {
            try
            {
                using (var db = new Context())
                {
                   var workDays = db.WorkDays.Where(x => x.TournamentId == tournamentId).ToList();
                    return workDays;
                }
            }
            catch (Exception e)
            {
                return new List<WorkDay>();
            }
        }
    }
}
