using BL.Teams;
using Comm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessTournament.Teams
{
    public class ImplementerTeam : ITeam
    {
        public bool Insert(TeamVM teamVM)
        {
            var team = Mapper.MapFromVM(teamVM);
            return Repository.Insert(team);
        }

        public List<TeamVM> GetAll()
        {
            var teamsVM = Mapper.MapToVM(Repository.GetAll());

            return teamsVM;
        }

        public TeamVM Get(int teamId)
        {
            var team = Mapper.MapToVM(Repository.Get(teamId));

            return team;
        }

        public bool Update(TeamVM teamVM)
        {
            var team = Mapper.MapFromVM(teamVM);

            return Repository.Update(team);
        }
    }
}
