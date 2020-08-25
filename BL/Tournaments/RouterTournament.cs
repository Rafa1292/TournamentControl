using BL.Players;
using BL.WorkDays;
using Comm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace BL.Tournaments
{
    public class RouterTournament
    {
        private readonly ITournament _tournament;
        private readonly RouterWorkDay _workDay;
        public RouterTournament(ITournament tournament, RouterWorkDay workDay)
        {
            _tournament = tournament;
            _workDay = workDay;
        }

        public List<TournamentVM> GetAll()
        {
            return _tournament.GetAll();
        }

        public bool Insert(TournamentVM tournamentVM)
        {
            using (var scope = new TransactionScope())
            {
                var tournamentId = _tournament.Insert(tournamentVM);

                if (tournamentId == 0)
                {
                    scope.Dispose();
                    return false;
                }

                if (!_workDay.MakeFixture(tournamentVM.Players, tournamentId))
                {
                    scope.Dispose();
                    return false;
                }

                scope.Complete();
                return true;
            }
        }

        public TournamentVM Get(int tournamentId)
        {
            var tournamentVM = _tournament.Get(tournamentId);
            tournamentVM.WorkDays = _workDay.GetWorkDaysByTournament(tournamentId);
            tournamentVM.Players = GetTournamentPlayers(tournamentVM.WorkDays);

            return tournamentVM;
        }

        public List<PositionTable> GetPositionTable(TournamentVM tournament)
        {
            var workDays = tournament.WorkDays;
            var availableTables = new List<PositionTable>();
            var positionTables = new List<PositionTable>();
            tournament.Players.ForEach(x => availableTables.Add(new PositionTable() { PlayerId = x.PlayerId, Player = x }));

            foreach (var workDay in workDays)
            {
                foreach (var match in workDay.Matches)
                {
                    if (match.Played)
                    {
                        var homePosition = new PositionTable();
                        var awayPosition = new PositionTable();

                        homePosition.LostMatch = match.HomeGoal < match.AwayGoal ? 1 : 0;
                        homePosition.TiedMatch = match.HomeGoal == match.AwayGoal ? 1 : 0;
                        homePosition.MatchWon = match.HomeGoal > match.AwayGoal ? 1 : 0;

                        positionTables.Add(GetTables(match.AwayGoal, match.HomeGoal, homePosition.LostMatch, homePosition.MatchWon, homePosition.TiedMatch, match.HomePlayerId));


                        awayPosition.LostMatch = match.HomeGoal > match.AwayGoal ? 1 : 0;
                        awayPosition.TiedMatch = match.HomeGoal == match.AwayGoal ? 1 : 0;
                        awayPosition.MatchWon = match.HomeGoal < match.AwayGoal ? 1 : 0;

                        positionTables.Add(GetTables(match.HomeGoal, match.AwayGoal, awayPosition.LostMatch, awayPosition.MatchWon, awayPosition.TiedMatch, match.AwayPlayerId));
                    }
                }
            }

            return FinishTable(positionTables, tournament.Players);
        }

        public PositionTable GetTables(int goalsAgainst, int goalsFor, int lostMatch, int matchWon, int tiedMatch, int playerId)
        {
            var positionTable = new PositionTable()
            {
                GoalsAgainst = goalsAgainst,
                GoalsFor = goalsFor,
                LostMatch = lostMatch,
                MatchWon = matchWon,
                TiedMatch = tiedMatch,
                PlayerId = playerId
            };

            return positionTable;
        }

        public List<PositionTable> FinishTable(List<PositionTable> positionTables, List<PlayerVM> players)
        {
            var finalPositionTable = new List<PositionTable>();

            foreach (var player in players)
            {
                var positionTable = new PositionTable();
                positionTable.PlayerId = player.PlayerId;
                positionTable.Player = player;
                positionTable.GoalsAgainst = positionTables.Where(x => x.PlayerId == player.PlayerId).Sum(y => y.GoalsAgainst);
                positionTable.GoalsFor = positionTables.Where(x => x.PlayerId == player.PlayerId).Sum(y => y.GoalsFor);
                positionTable.GoalsDiference = positionTable.GoalsFor - positionTable.GoalsAgainst;
                positionTable.LostMatch = positionTables.Where(x => x.PlayerId == player.PlayerId).Sum(y => y.LostMatch);
                positionTable.TiedMatch = positionTables.Where(x => x.PlayerId == player.PlayerId).Sum(y => y.TiedMatch);
                positionTable.MatchWon = positionTables.Where(x => x.PlayerId == player.PlayerId).Sum(y => y.MatchWon);
                positionTable.MatchPlayed = positionTable.LostMatch + positionTable.MatchWon + positionTable.TiedMatch;
                positionTable.Points = positionTable.MatchWon * 3 + positionTable.TiedMatch;

                finalPositionTable.Add(positionTable);
            }

            return finalPositionTable;

        }

        public List<PlayerVM> GetTournamentPlayers(List<WorkDayVM> workDays)
        {
            List<PlayerVM> players = new List<PlayerVM>();

            foreach (var workDay in workDays)
            {
                foreach (var match in workDay.Matches)
                {
                    if (!players.Select(x => x.PlayerId).Contains(match.AwayPlayer.PlayerId))
                    {
                        players.Add(match.AwayPlayer);
                    }

                    if (!players.Select(x => x.PlayerId).Contains(match.HomePlayer.PlayerId))
                    {
                        players.Add(match.HomePlayer);
                    }
                }
            }

            return players;
        }
    }
}
