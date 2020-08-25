using Comm.ViewModels;
using DataAccessTournament.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessTournament.Teams
{
    public class Mapper
    {
        public static Team MapFromVM(TeamVM teamVM)
        {
            Team team = new Team()
            {
                Image = teamVM.Image,
                Name = teamVM.Name,
                TeamId = teamVM.TeamId,
                Acronym = teamVM.Acronym
            };

            return team;
        }

        public static TeamVM MapToVM(Team team)
        {
            TeamVM teamVM = new TeamVM()
            {
                Image = team.Image,
                Name = team.Name,
                TeamId = team.TeamId,
                Acronym = team.Acronym
            };

            return teamVM;
        }

        public static List<TeamVM> MapToVM(List<Team> teams)
        {
            var teamsVM = new List<TeamVM>();
            teams.ForEach(x => teamsVM.Add(MapToVM(x)));

            return teamsVM;
        }
    }
}
