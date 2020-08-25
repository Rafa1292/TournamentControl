using Comm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Teams
{
    public interface ITeam
    {
        public bool Insert(TeamVM teamVM);

        public List<TeamVM> GetAll();

        public TeamVM Get(int teamId);

        public bool Update(TeamVM teamVM);
    }
}
