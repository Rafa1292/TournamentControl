using Comm.ViewModels;
using DataAccessTournament.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessTournament.Tournaments
{
    public class Mapper
    {
        public static TournamentVM MapToVM(Tournament tournament)
        {
            TournamentVM tournamentVM = new TournamentVM()
            {
                Name = tournament.Name,
                TournamentId = tournament.TournamentId
            };

            return tournamentVM;
        }

        public static List<TournamentVM> MapToVM(List<Tournament> tournaments)
        {
            var tournamentsVM = new List<TournamentVM>();
            tournaments.ForEach(x => tournamentsVM.Add(MapToVM(x)));

            return tournamentsVM;
        }

        public static Tournament MapFromVM(TournamentVM tournamentVM)
        {
            Tournament tournament = new Tournament()
            {
                Name = tournamentVM.Name,
                TournamentId = tournamentVM.TournamentId
            };

            return tournament;
        }
    }
}
