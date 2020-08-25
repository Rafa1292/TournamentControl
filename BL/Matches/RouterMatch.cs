using BL.Players;
using Comm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.Matches
{
    public class RouterMatch
    {
        private readonly IMatch _match;
        private readonly RouterPlayer _player;

        public RouterMatch(IMatch  match, RouterPlayer player)
        {
            _match = match;
            _player = player;
        }

        public bool Insert(MatchVM match)
        {            
            return _match.Insert(match);
        }

        public bool Update(MatchVM match)
        {
            return _match.Update(match);
        }

        public List<MatchVM> GetMatchesByWorkDay(int workDayId)
        {
            var matches = _match.GetMatchesByWorkDay(workDayId);
            var players = _player.GetAll();
            matches.ForEach(x => x.AwayPlayer = players.Find(y => y.PlayerId == x.AwayPlayerId));
            matches.ForEach(x => x.HomePlayer = players.Find(y => y.PlayerId == x.HomePlayerId));

            return matches;
        }

        public List<MatchVM> GetMatchesByWorkDay()
        {
            var matches = _match.GetMatchesByWorkDay().Where(x => x.Played).ToList();
            var players = _player.GetAll();
            matches.ForEach(x => x.AwayPlayer = players.Find(y => y.PlayerId == x.AwayPlayerId));
            matches.ForEach(x => x.HomePlayer = players.Find(y => y.PlayerId == x.HomePlayerId));

            return matches.OrderByDescending(x => x.MatchId).ToList();
        }

    }
}
