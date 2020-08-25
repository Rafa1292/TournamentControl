using Comm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Teams
{
    public class RouterTeam
    {
        private readonly ITeam _team;

        public RouterTeam(ITeam team)
        {
            _team = team;
        }

        public bool Insert(TeamVM team)
        {
            return _team.Insert(team);
        }

        public List<TeamVM> GetAll()
        {
            return _team.GetAll();
        }

        public TeamVM Get(int teamId)
        {
            return _team.Get(teamId);
        }

        public bool Update(TeamVM team)
        {
            return _team.Update(team);
        }
    }
}
