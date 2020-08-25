using BL.Matches;
using Comm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BL.WorkDays
{
    public class RouterWorkDay
    {
        private readonly IWorkDay _workDay;
        private readonly RouterMatch _routerMatch;
        public RouterWorkDay(IWorkDay workDay, RouterMatch routerMatch)
        {
            _workDay = workDay;
            _routerMatch = routerMatch;
        }

        public bool MakeFixture(List<PlayerVM> players, int tournamentId)
        {
            var playersQuantity = players.Count;
            var odd = playersQuantity % 2 == 0 ? true : false;
            var rounds = playersQuantity - 1;
            var matches = (int)Math.Ceiling((double)playersQuantity / 2);
            var fixtures = GetFixture(rounds, matches, players, odd);


            for (int i = 0; i < rounds; i++)
            {
                var workDay = new WorkDayVM() { Number = i + 1, TournamentId = tournamentId };
                var workDayId = _workDay.Insert(workDay);
                if (workDayId == 0)
                {
                    return false;
                }

                for (int j = 0; j < matches; j++)
                {
                    if (fixtures[i, j].HomePlayerId != 0 && fixtures[i,j].AwayPlayerId != 0)
                    {

                        fixtures[i, j].WorkDayId = workDayId;
                        var tryInsert = _routerMatch.Insert(fixtures[i, j]);

                        if (!tryInsert)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;

        }

        public MatchVM[,] GetFixture(int rounds, int matches, List<PlayerVM> players, bool odd)
        {
            var fixture = new MatchVM[rounds, matches];

            fixture = SetHomeMatches(rounds, matches, players, fixture);

            if (odd)
            {
                fixture = SetFirstRoundMatch(rounds, matches, players, fixture);
            }

            fixture = SetAwayGames(rounds, matches, players, fixture);

            return fixture;

        }

        public MatchVM[,] SetHomeMatches(int rounds, int matches, List<PlayerVM> players, MatchVM[,] fixture)
        {
            for (int i = 0, k = 0; i < rounds; i++)
            {
                for (int j = 0; j < matches; j++)
                {
                    fixture[i, j] = new MatchVM();

                    fixture[i, j].HomePlayerId = players[k].PlayerId;

                    k++;

                    if (k == rounds)
                        k = 0;
                }
            }

            return fixture;
        }

        public MatchVM[,] SetFirstRoundMatch(int rounds, int matches, List<PlayerVM> players, MatchVM[,] fixture)
        {
            for (int i = 0; i < rounds; i++)
            {
                if (i % 2 == 0)
                {
                    fixture[i, 0].AwayPlayerId = players[rounds].PlayerId;
                }
                else
                {
                    fixture[i, 0].AwayPlayerId = fixture[i, 0].HomePlayerId;
                    fixture[i, 0].HomePlayerId = players[rounds].PlayerId;
                }
            }
            return fixture;
        }

        public MatchVM[,] SetAwayGames(int rounds, int matches, List<PlayerVM> players, MatchVM[,] fixture)
        {
            for (int i = 0, k = rounds - 1; i < rounds; i++)
            {
                for (int j = 1; j < matches; j++)
                {
                    fixture[i, j].AwayPlayerId = players[k].PlayerId;

                    k--;

                    if (k == -1)
                    {
                        k = rounds - 1;
                    }
                }
            }
            return fixture;
        }

        public List<WorkDayVM> GetWorkDaysByTournament(int tournamentId)
        {
            var workDays = _workDay.GetWorkDays(tournamentId);
            workDays.ForEach(x => x.Matches = _routerMatch.GetMatchesByWorkDay(x.WorkDayId));

            return workDays;
        }
    }
}
