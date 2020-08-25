using Comm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Tournaments
{
    public interface ITournament
    {
        public List<TournamentVM> GetAll();

        public TournamentVM Get(int tournamentId);

        public int Insert(TournamentVM tournamentVM);
    }
}
