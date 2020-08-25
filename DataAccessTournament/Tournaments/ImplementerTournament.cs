using BL.Tournaments;
using Comm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessTournament.Tournaments
{
    public class ImplementerTournament : ITournament
    {
        public List<TournamentVM> GetAll()
        {
            var tournamentsVM = Mapper.MapToVM(Repository.GetAll());

            return tournamentsVM;
        }

        public int Insert(TournamentVM tournamentVM)
        {
            var tournament = Mapper.MapFromVM(tournamentVM);

            return Repository.Insert(tournament);
        }

        public TournamentVM Get(int tournamentId)
        {
            var tournament = Repository.Get(tournamentId);
            var tournamentVM = Mapper.MapToVM(tournament);

            return tournamentVM;
        }

    }
}
