using DataAccessTournament.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessTournament.Players
{
    public class Repository
    {
        public static bool Insert(Player player)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Players.Add(player);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static List<Player> GetAll()
        {
            try
            {
                using (var db = new Context())
                {
                    var players = db.Players.ToList();
                    return players;
                }
            }
            catch (Exception e)
            {
                return new List<Player>();
            }

        }

        public static Player Get(int playerId)
        {
            try
            {
                using (var db = new Context())
                {
                    var player = db.Players.Find(playerId);
                    return player;
                }
            }
            catch (Exception e)
            {
                return new Player();
            }

        }

        public static bool Update(Player player)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Entry(player).State = EntityState.Modified;
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
