using Comm.ViewModels;
using DataAccessTournament.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessTournament.Matches
{
    public class Mapper
    {
        public static Match MapFromVM(MatchVM matchVM)
        {
            Match match = new Match()
            {
                AwayGoal = matchVM.AwayGoal,
                AwayPlayerId = matchVM.AwayPlayerId,
                AwayTeamId = matchVM.AwayTeamId,
                HomeGoal = matchVM.HomeGoal,
                HomePlayerId = matchVM.HomePlayerId,
                HomeTeamId = matchVM.HomeTeamId,
                MatchId = matchVM.MatchId,
                WorkDayId = matchVM.WorkDayId,
                Played = matchVM.Played
                
            };

            return match;
        }

        public static MatchVM MapToVM(Match match)
        {
            MatchVM matchVM = new MatchVM()
            {
                AwayGoal = match.AwayGoal,
                AwayPlayerId = match.AwayPlayerId,
                AwayTeamId = match.AwayTeamId,
                HomeGoal = match.HomeGoal,
                HomePlayerId = match.HomePlayerId,
                HomeTeamId = match.HomeTeamId,
                MatchId = match.MatchId,
                WorkDayId = match.WorkDayId,
                Played = match.Played
            };

            return matchVM;
        }

        public static List<MatchVM> MapToVM(List<Match> matches)
        {
            var matchesVM = new List<MatchVM>();

            matches.ForEach(x => matchesVM.Add(MapToVM(x)));

            return matchesVM;
        }
    }
}
