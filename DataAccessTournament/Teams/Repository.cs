using DataAccessTournament.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessTournament.Teams
{
    public class Repository
    {
        public static bool Insert(Team team)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Teams.Add(team);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static List<Team> GetAll()
        {
            try
            {
                using (var db = new Context())
                {
                    var teams = db.Teams.ToList();
                    return teams;
                }
            }
            catch (Exception e)
            {
                return new List<Team>();
            }

        }

        public static Team Get(int teamId)
        {
            try
            {
                using (var db = new Context())
                {
                    var team = db.Teams.Find(teamId);
                    return team;
                }
            }
            catch (Exception e)
            {
                return new Team();
            }

        }

        public static bool Update(Team team)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Entry(team).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
